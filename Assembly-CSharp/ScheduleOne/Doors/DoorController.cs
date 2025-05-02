using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Doors
{
	// Token: 0x0200068A RID: 1674
	public class DoorController : NetworkBehaviour
	{
		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000C244D File Offset: 0x000C064D
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x000C2455 File Offset: 0x000C0655
		public bool IsOpen { get; protected set; }

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000C245E File Offset: 0x000C065E
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x000C2466 File Offset: 0x000C0666
		public bool openedByNPC { get; protected set; }

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x000C246F File Offset: 0x000C066F
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x000C2477 File Offset: 0x000C0677
		public float timeSinceNPCSensed { get; protected set; } = float.MaxValue;

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x000C2480 File Offset: 0x000C0680
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x000C2488 File Offset: 0x000C0688
		public bool playerDetectedSinceOpened { get; protected set; }

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x000C2491 File Offset: 0x000C0691
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x000C2499 File Offset: 0x000C0699
		public float timeSincePlayerSensed { get; protected set; } = float.MaxValue;

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x000C24A2 File Offset: 0x000C06A2
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x000C24AA File Offset: 0x000C06AA
		public float timeInCurrentState { get; protected set; }

		// Token: 0x06002E59 RID: 11865 RVA: 0x000C24B4 File Offset: 0x000C06B4
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Doors.DoorController_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x000C24D3 File Offset: 0x000C06D3
		protected virtual void Start()
		{
			if (this.AutoCloseOnSleep)
			{
				ScheduleOne.GameTime.TimeManager.onSleepStart = (Action)Delegate.Combine(ScheduleOne.GameTime.TimeManager.onSleepStart, new Action(delegate()
				{
					if (this.IsOpen)
					{
						this.SetIsOpen(false, EDoorSide.Interior);
					}
				}));
			}
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x000C2500 File Offset: 0x000C0700
		protected virtual void Update()
		{
			this.timeSinceNPCSensed += Time.deltaTime;
			this.timeSincePlayerSensed += Time.deltaTime;
			this.timeInCurrentState += Time.deltaTime;
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.IsOpen && ((this.openedByNPC && this.timeSinceNPCSensed > this.ReturnToOriginalTime) || (this.autoOpenedForPlayer && this.timeSincePlayerSensed > this.ReturnToOriginalTime)))
			{
				this.openedByNPC = false;
				this.autoOpenedForPlayer = false;
				this.PlayerBlocker.enabled = false;
				this.SetIsOpen_Server(false, EDoorSide.Interior, false);
			}
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000C25A2 File Offset: 0x000C07A2
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.IsOpen)
			{
				this.SetIsOpen(connection, true, this.lastOpenSide);
			}
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x000C25C4 File Offset: 0x000C07C4
		public virtual void InteriorHandleHovered()
		{
			string text;
			if (this.CanPlayerAccess(EDoorSide.Interior, out text))
			{
				foreach (InteractableObject interactableObject in this.InteriorIntObjs)
				{
					interactableObject.SetMessage(this.IsOpen ? "Close" : "Open");
					interactableObject.SetInteractableState(InteractableObject.EInteractableState.Default);
				}
				return;
			}
			foreach (InteractableObject interactableObject2 in this.InteriorIntObjs)
			{
				if (text != string.Empty)
				{
					interactableObject2.SetMessage(text);
					interactableObject2.SetInteractableState(InteractableObject.EInteractableState.Invalid);
				}
				else
				{
					interactableObject2.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				}
			}
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000C2652 File Offset: 0x000C0852
		public virtual void InteriorHandleInteracted()
		{
			if (this.CanPlayerAccess(EDoorSide.Interior))
			{
				if (!this.IsOpen && this.InteriorDoorHandleAnimation != null)
				{
					this.InteriorDoorHandleAnimation.Play();
				}
				this.SetIsOpen_Server(!this.IsOpen, EDoorSide.Interior, false);
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000C2690 File Offset: 0x000C0890
		public virtual void ExteriorHandleHovered()
		{
			string text;
			if (this.CanPlayerAccess(EDoorSide.Exterior, out text))
			{
				foreach (InteractableObject interactableObject in this.ExteriorIntObjs)
				{
					interactableObject.SetMessage(this.IsOpen ? "Close" : "Open");
					interactableObject.SetInteractableState(InteractableObject.EInteractableState.Default);
				}
				return;
			}
			foreach (InteractableObject interactableObject2 in this.ExteriorIntObjs)
			{
				if (text != string.Empty)
				{
					interactableObject2.SetMessage(text);
					interactableObject2.SetInteractableState(InteractableObject.EInteractableState.Invalid);
				}
				else
				{
					interactableObject2.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				}
			}
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x000C271E File Offset: 0x000C091E
		public virtual void ExteriorHandleInteracted()
		{
			if (this.CanPlayerAccess(EDoorSide.Exterior))
			{
				if (!this.IsOpen && this.ExteriorDoorHandleAnimation != null)
				{
					this.ExteriorDoorHandleAnimation.Play();
				}
				this.SetIsOpen_Server(!this.IsOpen, EDoorSide.Exterior, false);
			}
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000C275C File Offset: 0x000C095C
		public bool CanPlayerAccess(EDoorSide side)
		{
			string text;
			return this.CanPlayerAccess(side, out text);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000C2772 File Offset: 0x000C0972
		protected virtual bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			reason = this.noAccessErrorMessage;
			if (side != EDoorSide.Interior)
			{
				return side == EDoorSide.Exterior && (this.PlayerAccess == EDoorAccess.Open || this.PlayerAccess == EDoorAccess.EnterOnly);
			}
			return this.PlayerAccess == EDoorAccess.Open || this.PlayerAccess == EDoorAccess.ExitOnly;
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x000C27B0 File Offset: 0x000C09B0
		public virtual void NPCVicinityDetected(EDoorSide side)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.timeSinceNPCSensed = 0f;
			if (this.OpenableByNPCs && this.PlayerAccess != EDoorAccess.Open)
			{
				this.PlayerBlocker.enabled = true;
			}
			if (!this.IsOpen && this.OpenableByNPCs)
			{
				this.openedByNPC = true;
				this.SetIsOpen_Server(true, side, false);
			}
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x000C280C File Offset: 0x000C0A0C
		public virtual void PlayerVicinityDetected(EDoorSide side)
		{
			this.timeSincePlayerSensed = 0f;
			if (this.IsOpen)
			{
				this.playerDetectedSinceOpened = true;
			}
			if (!this.IsOpen && this.AutoOpenForPlayer && this.CanPlayerAccess(side))
			{
				this.autoOpenedForPlayer = true;
				this.SetIsOpen_Server(true, side, true);
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000C285C File Offset: 0x000C0A5C
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetIsOpen_Server(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			this.RpcWriter___Server_SetIsOpen_Server_1319291243(open, accessSide, openedForPlayer);
			this.RpcLogic___SetIsOpen_Server_1319291243(open, accessSide, openedForPlayer);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000C2884 File Offset: 0x000C0A84
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetIsOpen(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetIsOpen_3381113727(conn, open, openSide);
				this.RpcLogic___SetIsOpen_3381113727(conn, open, openSide);
			}
			else
			{
				this.RpcWriter___Target_SetIsOpen_3381113727(conn, open, openSide);
			}
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x000C28D4 File Offset: 0x000C0AD4
		public virtual void SetIsOpen(bool open, EDoorSide openSide)
		{
			if (this.IsOpen != open)
			{
				this.timeInCurrentState = 0f;
			}
			this.IsOpen = open;
			if (this.IsOpen)
			{
				this.playerDetectedSinceOpened = false;
			}
			this.lastOpenSide = openSide;
			if (this.IsOpen)
			{
				this.onDoorOpened.Invoke(openSide);
				return;
			}
			this.onDoorClosed.Invoke();
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x000C2934 File Offset: 0x000C0B34
		protected virtual void CheckAutoCloseForDistantPlayer()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (this.timeSinceNPCSensed < this.ReturnToOriginalTime)
			{
				return;
			}
			if (this.timeSincePlayerSensed < this.ReturnToOriginalTime)
			{
				return;
			}
			float num;
			Player.GetClosestPlayer(base.transform.position, out num, null);
			if (num > 40f)
			{
				this.SetIsOpen_Server(false, EDoorSide.Interior, false);
			}
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000C2A08 File Offset: 0x000C0C08
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SetIsOpen_Server_1319291243));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetIsOpen_3381113727));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_SetIsOpen_3381113727));
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000C2A6B File Offset: 0x000C0C6B
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000C2A7E File Offset: 0x000C0C7E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000C2A8C File Offset: 0x000C0C8C
		private void RpcWriter___Server_SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
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
			writer.WriteBoolean(open);
			writer.Write___ScheduleOne.Doors.EDoorSideFishNet.Serializing.Generated(accessSide);
			writer.WriteBoolean(openedForPlayer);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000C2B4D File Offset: 0x000C0D4D
		public void RpcLogic___SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			this.autoOpenedForPlayer = openedForPlayer;
			if (openedForPlayer)
			{
				this.timeSincePlayerSensed = 0f;
			}
			this.SetIsOpen(null, open, accessSide);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000C2B70 File Offset: 0x000C0D70
		private void RpcReader___Server_SetIsOpen_Server_1319291243(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			bool open = PooledReader0.ReadBoolean();
			EDoorSide accessSide = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Doors.EDoorSideFishNet.Serializing.Generateds(PooledReader0);
			bool openedForPlayer = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetIsOpen_Server_1319291243(open, accessSide, openedForPlayer);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000C2BD0 File Offset: 0x000C0DD0
		private void RpcWriter___Observers_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
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
			writer.WriteBoolean(open);
			writer.Write___ScheduleOne.Doors.EDoorSideFishNet.Serializing.Generated(openSide);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000C2C93 File Offset: 0x000C0E93
		public void RpcLogic___SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			this.SetIsOpen(open, openSide);
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000C2CA0 File Offset: 0x000C0EA0
		private void RpcReader___Observers_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			bool open = PooledReader0.ReadBoolean();
			EDoorSide openSide = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Doors.EDoorSideFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetIsOpen_3381113727(null, open, openSide);
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000C2CF0 File Offset: 0x000C0EF0
		private void RpcWriter___Target_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
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
			writer.WriteBoolean(open);
			writer.Write___ScheduleOne.Doors.EDoorSideFishNet.Serializing.Generated(openSide);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000C2DB4 File Offset: 0x000C0FB4
		private void RpcReader___Target_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			bool open = PooledReader0.ReadBoolean();
			EDoorSide openSide = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Doors.EDoorSideFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetIsOpen_3381113727(base.LocalConnection, open, openSide);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000C2DFC File Offset: 0x000C0FFC
		protected virtual void dll()
		{
			this.PlayerBlocker.enabled = false;
			foreach (InteractableObject interactableObject in this.InteriorIntObjs)
			{
				interactableObject.onHovered.AddListener(new UnityAction(this.InteriorHandleHovered));
				interactableObject.onInteractStart.AddListener(new UnityAction(this.InteriorHandleInteracted));
				interactableObject.SetMessage(this.IsOpen ? "Close" : "Open");
			}
			foreach (InteractableObject interactableObject2 in this.ExteriorIntObjs)
			{
				interactableObject2.onHovered.AddListener(new UnityAction(this.ExteriorHandleHovered));
				interactableObject2.onInteractStart.AddListener(new UnityAction(this.ExteriorHandleInteracted));
				interactableObject2.SetMessage(this.IsOpen ? "Close" : "Open");
			}
			if (base.gameObject.isStatic)
			{
				Console.LogError("DoorController is static! Doors should not be static!", base.gameObject);
			}
			if (this.AutoCloseOnDistantPlayer)
			{
				base.InvokeRepeating("CheckAutoCloseForDistantPlayer", 2f, 2f);
			}
		}

		// Token: 0x040020DC RID: 8412
		public const float DISTANT_PLAYER_THRESHOLD = 40f;

		// Token: 0x040020DE RID: 8414
		public EDoorAccess PlayerAccess;

		// Token: 0x040020DF RID: 8415
		public bool AutoOpenForPlayer;

		// Token: 0x040020E0 RID: 8416
		[Header("References")]
		[SerializeField]
		protected InteractableObject[] InteriorIntObjs;

		// Token: 0x040020E1 RID: 8417
		[SerializeField]
		protected InteractableObject[] ExteriorIntObjs;

		// Token: 0x040020E2 RID: 8418
		[Tooltip("Used to block player from entering when the door is open for an NPC, but player isn't permitted access.")]
		[SerializeField]
		protected BoxCollider PlayerBlocker;

		// Token: 0x040020E3 RID: 8419
		[Header("Animation")]
		[SerializeField]
		protected Animation InteriorDoorHandleAnimation;

		// Token: 0x040020E4 RID: 8420
		[SerializeField]
		protected Animation ExteriorDoorHandleAnimation;

		// Token: 0x040020E5 RID: 8421
		[Header("Settings")]
		[SerializeField]
		protected bool AutoCloseOnSleep = true;

		// Token: 0x040020E6 RID: 8422
		[SerializeField]
		protected bool AutoCloseOnDistantPlayer = true;

		// Token: 0x040020E7 RID: 8423
		[Header("NPC Access")]
		[SerializeField]
		protected bool OpenableByNPCs = true;

		// Token: 0x040020E8 RID: 8424
		[Tooltip("How many seconds to wait after NPC passes through to return to original state")]
		[SerializeField]
		protected float ReturnToOriginalTime = 0.5f;

		// Token: 0x040020E9 RID: 8425
		public UnityEvent<EDoorSide> onDoorOpened;

		// Token: 0x040020EA RID: 8426
		public UnityEvent onDoorClosed;

		// Token: 0x040020EB RID: 8427
		private EDoorSide lastOpenSide = EDoorSide.Exterior;

		// Token: 0x040020EE RID: 8430
		private bool autoOpenedForPlayer;

		// Token: 0x040020F2 RID: 8434
		[HideInInspector]
		public string noAccessErrorMessage = string.Empty;

		// Token: 0x040020F3 RID: 8435
		private bool dll_Excuted;

		// Token: 0x040020F4 RID: 8436
		private bool dll_Excuted;
	}
}
