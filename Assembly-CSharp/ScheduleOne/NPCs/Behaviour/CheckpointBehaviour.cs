using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.ItemFramework;
using ScheduleOne.Law;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Product;
using ScheduleOne.Storage;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004E9 RID: 1257
	public class CheckpointBehaviour : Behaviour
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00075B46 File Offset: 0x00073D46
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x00075B4E File Offset: 0x00073D4E
		public CheckpointManager.ECheckpointLocation AssignedCheckpoint { get; protected set; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00075B57 File Offset: 0x00073D57
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x00075B5F File Offset: 0x00073D5F
		public RoadCheckpoint Checkpoint { get; protected set; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00075B68 File Offset: 0x00073D68
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x00075B70 File Offset: 0x00073D70
		public bool IsSearching { get; protected set; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00075B79 File Offset: 0x00073D79
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x00075B81 File Offset: 0x00073D81
		public LandVehicle CurrentSearchedVehicle { get; protected set; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x00075B8A File Offset: 0x00073D8A
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x00075B92 File Offset: 0x00073D92
		public Player Initiator { get; protected set; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x00075B9B File Offset: 0x00073D9B
		private Transform standPoint
		{
			get
			{
				return this.Checkpoint.StandPoints[Mathf.Clamp(this.Checkpoint.AssignedNPCs.IndexOf(base.Npc), 0, this.Checkpoint.StandPoints.Length - 1)];
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00075BD4 File Offset: 0x00073DD4
		private DialogueDatabase dialogueDatabase
		{
			get
			{
				return base.Npc.dialogueHandler.Database;
			}
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00075BE8 File Offset: 0x00073DE8
		protected override void Begin()
		{
			base.Begin();
			this.Checkpoint = NetworkSingleton<CheckpointManager>.Instance.GetCheckpoint(this.AssignedCheckpoint);
			if (!this.Checkpoint.AssignedNPCs.Contains(base.Npc))
			{
				this.Checkpoint.AssignedNPCs.Add(base.Npc);
			}
			this.Checkpoint.onPlayerWalkThrough.AddListener(new UnityAction<Player>(this.PlayerWalkedThroughCheckPoint));
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x00075C5C File Offset: 0x00073E5C
		protected override void Resume()
		{
			base.Resume();
			this.Checkpoint = NetworkSingleton<CheckpointManager>.Instance.GetCheckpoint(this.AssignedCheckpoint);
			if (!this.Checkpoint.AssignedNPCs.Contains(base.Npc))
			{
				this.Checkpoint.AssignedNPCs.Add(base.Npc);
			}
			this.Checkpoint.onPlayerWalkThrough.AddListener(new UnityAction<Player>(this.PlayerWalkedThroughCheckPoint));
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00075CD0 File Offset: 0x00073ED0
		protected override void End()
		{
			base.End();
			this.IsSearching = false;
			if (this.Checkpoint.AssignedNPCs.Contains(base.Npc))
			{
				this.Checkpoint.AssignedNPCs.Remove(base.Npc);
			}
			if (this.CurrentSearchedVehicle != null && this.trunkOpened)
			{
				this.CurrentSearchedVehicle.Trunk.SetIsOpen(false);
			}
			this.Checkpoint.onPlayerWalkThrough.RemoveListener(new UnityAction<Player>(this.PlayerWalkedThroughCheckPoint));
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00075D5C File Offset: 0x00073F5C
		protected override void Pause()
		{
			base.Pause();
			this.IsSearching = false;
			if (this.Checkpoint.AssignedNPCs.Contains(base.Npc))
			{
				this.Checkpoint.AssignedNPCs.Remove(base.Npc);
			}
			if (this.CurrentSearchedVehicle != null && this.trunkOpened)
			{
				this.CurrentSearchedVehicle.Trunk.SetIsOpen(false);
			}
			this.Checkpoint.onPlayerWalkThrough.RemoveListener(new UnityAction<Player>(this.PlayerWalkedThroughCheckPoint));
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00075DE8 File Offset: 0x00073FE8
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (this.IsSearching && !base.Npc.Movement.IsMoving && base.Npc.Movement.IsAsCloseAsPossible(this.GetSearchPoint(), 0.5f))
			{
				if (!this.CurrentSearchedVehicle.Trunk.IsOpen)
				{
					StorageDoorAnimation trunk = this.CurrentSearchedVehicle.Trunk;
					if (trunk != null)
					{
						trunk.SetIsOpen(true);
					}
					this.trunkOpened = true;
				}
			}
			else if (this.trunkOpened && this.CurrentSearchedVehicle != null)
			{
				StorageDoorAnimation trunk2 = this.CurrentSearchedVehicle.Trunk;
				if (trunk2 != null)
				{
					trunk2.SetIsOpen(false);
				}
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.Checkpoint == null || this.Checkpoint.ActivationState == RoadCheckpoint.ECheckpointState.Disabled)
			{
				base.Disable_Networked(null);
				return;
			}
			if (!this.IsSearching)
			{
				if (!base.Npc.Movement.IsMoving)
				{
					if (base.Npc.Movement.IsAsCloseAsPossible(this.standPoint.position, 0.5f))
					{
						if (!base.Npc.Movement.FaceDirectionInProgress)
						{
							base.Npc.Movement.FaceDirection(this.standPoint.forward, 0.5f);
							return;
						}
					}
					else if (base.Npc.Movement.CanMove())
					{
						base.Npc.Movement.SetDestination(this.standPoint.position);
						return;
					}
				}
			}
			else
			{
				if (!this.Checkpoint.SearchArea1.vehicles.Contains(this.CurrentSearchedVehicle) && !this.Checkpoint.SearchArea2.vehicles.Contains(this.CurrentSearchedVehicle))
				{
					this.StopSearch();
					return;
				}
				if (!base.Npc.Movement.IsMoving)
				{
					if (base.Npc.Movement.IsAsCloseAsPossible(this.GetSearchPoint(), 1f))
					{
						if (!base.Npc.Movement.FaceDirectionInProgress)
						{
							base.Npc.Movement.FacePoint(this.CurrentSearchedVehicle.transform.position, 0.5f);
						}
						this.currentLookTime += 1f;
						if (this.currentLookTime >= 1.5f)
						{
							this.ConcludeSearch();
							return;
						}
					}
					else
					{
						this.currentLookTime = 0f;
						if (base.Npc.Movement.CanMove())
						{
							base.Npc.Movement.SetDestination(this.GetSearchPoint());
						}
					}
				}
			}
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00076068 File Offset: 0x00074268
		[ObserversRpc(RunLocally = true)]
		public void SetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			this.RpcWriter___Observers_SetCheckpoint_4087078542(loc);
			this.RpcLogic___SetCheckpoint_4087078542(loc);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0007607E File Offset: 0x0007427E
		[ObserversRpc(RunLocally = true)]
		public void SetInitiator(NetworkObject init)
		{
			this.RpcWriter___Observers_SetInitiator_3323014238(init);
			this.RpcLogic___SetInitiator_3323014238(init);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00076094 File Offset: 0x00074294
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void StartSearch(NetworkObject targetVehicle, NetworkObject initiator)
		{
			this.RpcWriter___Server_StartSearch_3694055493(targetVehicle, initiator);
			this.RpcLogic___StartSearch_3694055493(targetVehicle, initiator);
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x000760C0 File Offset: 0x000742C0
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void StopSearch()
		{
			this.RpcWriter___Server_StopSearch_2166136261();
			this.RpcLogic___StopSearch_2166136261();
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x000760D9 File Offset: 0x000742D9
		[ObserversRpc(RunLocally = true)]
		public void SetIsSearching(bool s)
		{
			this.RpcWriter___Observers_SetIsSearching_1140765316(s);
			this.RpcLogic___SetIsSearching_1140765316(s);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000760F0 File Offset: 0x000742F0
		private Vector3 GetSearchPoint()
		{
			return this.CurrentSearchedVehicle.transform.position - this.CurrentSearchedVehicle.transform.forward * (this.CurrentSearchedVehicle.boundingBoxDimensions.z / 2f + 0.75f);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00076144 File Offset: 0x00074344
		[ObserversRpc(RunLocally = true)]
		private void ConcludeSearch()
		{
			this.RpcWriter___Observers_ConcludeSearch_2166136261();
			this.RpcLogic___ConcludeSearch_2166136261();
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00076160 File Offset: 0x00074360
		private bool DoesVehicleContainIllicitItems()
		{
			if (this.CurrentSearchedVehicle == null)
			{
				return false;
			}
			(from x in this.CurrentSearchedVehicle.Storage.ItemSlots
			select x.ItemInstance).ToList<ItemInstance>();
			foreach (ItemSlot itemSlot in this.CurrentSearchedVehicle.Storage.ItemSlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					if (itemSlot.ItemInstance is ProductItemInstance)
					{
						ProductItemInstance productItemInstance = itemSlot.ItemInstance as ProductItemInstance;
						if (productItemInstance.AppliedPackaging == null || productItemInstance.AppliedPackaging.StealthLevel <= this.Checkpoint.MaxStealthLevel)
						{
							return true;
						}
					}
					else if (itemSlot.ItemInstance.Definition.legalStatus != ELegalStatus.Legal)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00076264 File Offset: 0x00074464
		private void PlayerWalkedThroughCheckPoint(Player player)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (player.CrimeData.TimeSinceLastBodySearch < 60f)
			{
				return;
			}
			if (player.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
			{
				return;
			}
			if (NetworkSingleton<CurfewManager>.Instance.IsCurrentlyActive)
			{
				return;
			}
			if (this.Checkpoint.AssignedNPCs.Count == 0)
			{
				return;
			}
			List<NPC> list = new List<NPC>();
			for (int i = 0; i < this.Checkpoint.AssignedNPCs.Count; i++)
			{
				Transform transform = this.Checkpoint.StandPoints[Mathf.Clamp(i, 0, this.Checkpoint.StandPoints.Length - 1)];
				if (Vector3.Distance(this.Checkpoint.AssignedNPCs[i].transform.position, transform.position) < 6f)
				{
					list.Add(this.Checkpoint.AssignedNPCs[i]);
				}
			}
			NPC x = null;
			float num = float.MaxValue;
			for (int j = 0; j < list.Count; j++)
			{
				float num2 = Vector3.Distance(player.transform.position, list[j].transform.position);
				if (num2 < num)
				{
					num = num2;
					x = list[j];
				}
			}
			if (num > 6f)
			{
				return;
			}
			if (x != base.Npc)
			{
				return;
			}
			player.CrimeData.ResetBodysearchCooldown();
			(base.Npc as PoliceOfficer).ConductBodySearch(player);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000763CC File Offset: 0x000745CC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_SetCheckpoint_4087078542));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.RpcReader___Observers_SetInitiator_3323014238));
			base.RegisterServerRpc(17U, new ServerRpcDelegate(this.RpcReader___Server_StartSearch_3694055493));
			base.RegisterServerRpc(18U, new ServerRpcDelegate(this.RpcReader___Server_StopSearch_2166136261));
			base.RegisterObserversRpc(19U, new ClientRpcDelegate(this.RpcReader___Observers_SetIsSearching_1140765316));
			base.RegisterObserversRpc(20U, new ClientRpcDelegate(this.RpcReader___Observers_ConcludeSearch_2166136261));
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0007647A File Offset: 0x0007467A
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00076493 File Offset: 0x00074693
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x000764A4 File Offset: 0x000746A4
		private void RpcWriter___Observers_SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Law.CheckpointManager/ECheckpointLocationFishNet.Serializing.Generated(loc);
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0007655A File Offset: 0x0007475A
		public void RpcLogic___SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			this.AssignedCheckpoint = loc;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00076564 File Offset: 0x00074764
		private void RpcReader___Observers_SetCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
			CheckpointManager.ECheckpointLocation loc = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Law.CheckpointManager/ECheckpointLocationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetCheckpoint_4087078542(loc);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x000765A0 File Offset: 0x000747A0
		private void RpcWriter___Observers_SetInitiator_3323014238(NetworkObject init)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(init);
			base.SendObserversRpc(16U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00076656 File Offset: 0x00074856
		public void RpcLogic___SetInitiator_3323014238(NetworkObject init)
		{
			this.Initiator = init.GetComponent<Player>();
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00076664 File Offset: 0x00074864
		private void RpcReader___Observers_SetInitiator_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject init = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetInitiator_3323014238(init);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x000766A0 File Offset: 0x000748A0
		private void RpcWriter___Server_StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(targetVehicle);
			writer.WriteNetworkObject(initiator);
			base.SendServerRpc(17U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00076754 File Offset: 0x00074954
		public void RpcLogic___StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			this.currentLookTime = 0f;
			this.SetIsSearching(true);
			this.SetInitiator(initiator);
			this.CurrentSearchedVehicle = targetVehicle.GetComponent<LandVehicle>();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("searchingvehicle", 20, 0.15f));
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x000767B4 File Offset: 0x000749B4
		private void RpcReader___Server_StartSearch_3694055493(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject targetVehicle = PooledReader0.ReadNetworkObject();
			NetworkObject initiator = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___StartSearch_3694055493(targetVehicle, initiator);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00076804 File Offset: 0x00074A04
		private void RpcWriter___Server_StopSearch_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(18U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x000768A0 File Offset: 0x00074AA0
		public void RpcLogic___StopSearch_2166136261()
		{
			this.SetIsSearching(false);
			if (this.CurrentSearchedVehicle != null && this.trunkOpened)
			{
				StorageDoorAnimation trunk = this.CurrentSearchedVehicle.Trunk;
				if (trunk != null)
				{
					trunk.SetIsOpen(false);
				}
			}
			this.CurrentSearchedVehicle = null;
			this.Initiator = null;
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			base.Npc.Movement.SpeedController.RemoveSpeedControl("searchingvehicle");
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00076914 File Offset: 0x00074B14
		private void RpcReader___Server_StopSearch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___StopSearch_2166136261();
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00076944 File Offset: 0x00074B44
		private void RpcWriter___Observers_SetIsSearching_1140765316(bool s)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteBoolean(s);
			base.SendObserversRpc(19U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x000769FA File Offset: 0x00074BFA
		public void RpcLogic___SetIsSearching_1140765316(bool s)
		{
			this.IsSearching = s;
			if (this.IsSearching)
			{
				base.Npc.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Police, "checkpoint_search_start"), 3f);
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00076A34 File Offset: 0x00074C34
		private void RpcReader___Observers_SetIsSearching_1140765316(PooledReader PooledReader0, Channel channel)
		{
			bool s = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetIsSearching_1140765316(s);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00076A70 File Offset: 0x00074C70
		private void RpcWriter___Observers_ConcludeSearch_2166136261()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(20U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00076B1C File Offset: 0x00074D1C
		private void RpcLogic___ConcludeSearch_2166136261()
		{
			if (this.CurrentSearchedVehicle == null)
			{
				Console.LogWarning("ConcludeSearch called with null vehicle", null);
			}
			if (this.CurrentSearchedVehicle != null && this.DoesVehicleContainIllicitItems() && this.Initiator != null)
			{
				base.Npc.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Police, "checkpoint_items_found"), 3f);
				if (this.Initiator == Player.Local)
				{
					Player.Local.CrimeData.AddCrime(new TransportingIllicitItems(), 1);
					Player.Local.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
					(base.Npc as PoliceOfficer).BeginFootPursuit_Networked(Player.Local.NetworkObject, true);
				}
			}
			else
			{
				base.Npc.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Police, "checkpoint_all_clear"), 3f);
				if (this.Checkpoint.SearchArea1.vehicles.Contains(this.CurrentSearchedVehicle))
				{
					this.Checkpoint.SetGate1Open(true);
				}
				else if (this.Checkpoint.SearchArea1.vehicles.Contains(this.CurrentSearchedVehicle))
				{
					this.Checkpoint.SetGate2Open(true);
				}
				else
				{
					this.Checkpoint.SetGate1Open(true);
					this.Checkpoint.SetGate2Open(true);
				}
			}
			this.StopSearch();
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00076C8C File Offset: 0x00074E8C
		private void RpcReader___Observers_ConcludeSearch_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ConcludeSearch_2166136261();
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00076CB6 File Offset: 0x00074EB6
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400175D RID: 5981
		public const float LOOK_TIME = 1.5f;

		// Token: 0x04001763 RID: 5987
		private float currentLookTime;

		// Token: 0x04001764 RID: 5988
		private bool trunkOpened;

		// Token: 0x04001765 RID: 5989
		private bool dll_Excuted;

		// Token: 0x04001766 RID: 5990
		private bool dll_Excuted;
	}
}
