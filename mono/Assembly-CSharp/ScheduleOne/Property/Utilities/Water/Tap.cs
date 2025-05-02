using System;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Property.Utilities.Water
{
	// Token: 0x02000823 RID: 2083
	public class Tap : NetworkBehaviour, IUsable
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x000EFD7D File Offset: 0x000EDF7D
		// (set) Token: 0x060038C0 RID: 14528 RVA: 0x000EFD85 File Offset: 0x000EDF85
		public bool IsHeldOpen
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<IsHeldOpen>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<IsHeldOpen>k__BackingField(value, true);
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x000EFD8F File Offset: 0x000EDF8F
		public float ActualFlowRate
		{
			get
			{
				return 6f * this.tapFlow;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060038C2 RID: 14530 RVA: 0x000EFD9D File Offset: 0x000EDF9D
		// (set) Token: 0x060038C3 RID: 14531 RVA: 0x000EFDA5 File Offset: 0x000EDFA5
		public NetworkObject NPCUserObject
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<NPCUserObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<NPCUserObject>k__BackingField(value, true);
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060038C4 RID: 14532 RVA: 0x000EFDAF File Offset: 0x000EDFAF
		// (set) Token: 0x060038C5 RID: 14533 RVA: 0x000EFDB7 File Offset: 0x000EDFB7
		public NetworkObject PlayerUserObject
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<PlayerUserObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.sync___set_value_<PlayerUserObject>k__BackingField(value, true);
			}
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x000EFDC1 File Offset: 0x000EDFC1
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Property.Utilities.Water.Tap_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x000EFDD8 File Offset: 0x000EDFD8
		protected virtual void LateUpdate()
		{
			float num = 2f;
			if (this.IsHeldOpen)
			{
				this.tapFlow = Mathf.Clamp(this.tapFlow + Time.deltaTime * num, 0f, 1f);
			}
			else
			{
				this.tapFlow = Mathf.Clamp(this.tapFlow - Time.deltaTime * num, 0f, 1f);
			}
			this.UpdateTapVisuals();
			this.UpdateWaterSound();
			if (!this.intObjSetThisFrame)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
			}
			this.intObjSetThisFrame = false;
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x000EFE62 File Offset: 0x000EE062
		public void SetInteractableObject(string message, InteractableObject.EInteractableState state)
		{
			this.intObjSetThisFrame = true;
			this.IntObj.SetMessage(message);
			this.IntObj.SetInteractableState(state);
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x000EFE84 File Offset: 0x000EE084
		protected void UpdateTapVisuals()
		{
			this.Handle.transform.localEulerAngles = new Vector3(0f, -this.tapFlow * 360f, 0f);
			if (this.tapFlow > 0f)
			{
				this.WaterParticles.main.startSize = new ParticleSystem.MinMaxCurve(0.075f * this.tapFlow, 0.1f * this.tapFlow);
				if (!this.WaterParticles.isPlaying)
				{
					this.WaterParticles.Play();
					return;
				}
			}
			else if (this.WaterParticles.isPlaying)
			{
				this.WaterParticles.Stop();
			}
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x000EFF2C File Offset: 0x000EE12C
		protected void UpdateWaterSound()
		{
			if (this.tapFlow > 0.01f)
			{
				this.WaterRunningSound.VolumeMultiplier = this.tapFlow;
				if (!this.WaterRunningSound.isPlaying)
				{
					this.WaterRunningSound.Play();
					return;
				}
			}
			else if (this.WaterRunningSound.isPlaying)
			{
				this.WaterRunningSound.Stop();
			}
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x000EFF88 File Offset: 0x000EE188
		public void Hovered()
		{
			if (this.CanInteract())
			{
				this.IntObj.SetMessage("Fill watering can");
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x000EFFBB File Offset: 0x000EE1BB
		public void Interacted()
		{
			if (!this.CanInteract())
			{
				return;
			}
			HotbarSlot equippedSlot = PlayerSingleton<PlayerInventory>.Instance.equippedSlot;
			new FillWateringCan(this, ((equippedSlot != null) ? equippedSlot.ItemInstance : null) as WateringCanInstance);
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x000EFFE8 File Offset: 0x000EE1E8
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x000F0009 File Offset: 0x000EE209
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x000F001F File Offset: 0x000EE21F
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetHeldOpen(bool open)
		{
			this.RpcWriter___Server_SetHeldOpen_1140765316(open);
			this.RpcLogic___SetHeldOpen_1140765316(open);
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x000F0038 File Offset: 0x000EE238
		protected virtual bool CanInteract()
		{
			HotbarSlot equippedSlot = PlayerSingleton<PlayerInventory>.Instance.equippedSlot;
			ItemInstance itemInstance = (equippedSlot != null) ? equippedSlot.ItemInstance : null;
			if (itemInstance == null)
			{
				return false;
			}
			WateringCanInstance wateringCanInstance = itemInstance as WateringCanInstance;
			return wateringCanInstance != null && wateringCanInstance.CurrentFillAmount < 15f && !((IUsable)this).IsInUse;
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x000F0087 File Offset: 0x000EE287
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendWateringCanModel(string ID)
		{
			this.RpcWriter___Server_SendWateringCanModel_3615296227(ID);
			this.RpcLogic___SendWateringCanModel_3615296227(ID);
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x000F009D File Offset: 0x000EE29D
		[ObserversRpc(RunLocally = true)]
		private void CreateWateringCanModel(string ID)
		{
			this.RpcWriter___Observers_CreateWateringCanModel_3615296227(ID);
			this.RpcLogic___CreateWateringCanModel_3615296227(ID);
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x000F00B3 File Offset: 0x000EE2B3
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendClearWateringCanModelModel()
		{
			this.RpcWriter___Server_SendClearWateringCanModelModel_2166136261();
			this.RpcLogic___SendClearWateringCanModelModel_2166136261();
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x000F00C1 File Offset: 0x000EE2C1
		[ObserversRpc(RunLocally = true)]
		private void ClearWateringCanModel()
		{
			this.RpcWriter___Observers_ClearWateringCanModel_2166136261();
			this.RpcLogic___ClearWateringCanModel_2166136261();
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x000F00D0 File Offset: 0x000EE2D0
		public GameObject CreateWateringCanModel_Local(string ID, bool force = false)
		{
			if (this.wateringCanModel != null && !force)
			{
				return null;
			}
			WateringCanDefinition wateringCanDefinition = Registry.GetItem(ID) as WateringCanDefinition;
			if (wateringCanDefinition == null)
			{
				Console.LogWarning("CreateWateringCanModel_Local: WateringCanDefinition not found", null);
				return null;
			}
			this.wateringCanModel = Object.Instantiate<GameObject>(wateringCanDefinition.FunctionalWateringCanPrefab, base.transform);
			this.wateringCanModel.transform.position = this.WateringCamPos.position;
			this.wateringCanModel.GetComponent<Rigidbody>().position = this.WateringCamPos.position;
			this.wateringCanModel.transform.rotation = this.WateringCamPos.rotation;
			this.wateringCanModel.GetComponent<Rigidbody>().rotation = this.WateringCamPos.rotation;
			this.wateringCanModel.GetComponent<FunctionalWateringCan>().enabled = false;
			return this.wateringCanModel;
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x000F01AC File Offset: 0x000EE3AC
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Property.Utilities.Water.TapAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Property.Utilities.Water.TapAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 2U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			this.syncVar___<IsHeldOpen>k__BackingField = new SyncVar<bool>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<IsHeldOpen>k__BackingField);
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SetHeldOpen_1140765316));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_SendWateringCanModel_3615296227));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_CreateWateringCanModel_3615296227));
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_SendClearWateringCanModelModel_2166136261));
			base.RegisterObserversRpc(6U, new ClientRpcDelegate(this.RpcReader___Observers_ClearWateringCanModel_2166136261));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Property.Utilities.Water.Tap));
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x000F02FE File Offset: 0x000EE4FE
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Property.Utilities.Water.TapAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Property.Utilities.Water.TapAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
			this.syncVar___<IsHeldOpen>k__BackingField.SetRegistered();
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x000F0332 File Offset: 0x000EE532
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x000F0340 File Offset: 0x000EE540
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
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
			writer.WriteNetworkObject(playerObject);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x000F03E8 File Offset: 0x000EE5E8
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			if (this.PlayerUserObject != null && this.PlayerUserObject.Owner.IsLocalClient && playerObject != null && !playerObject.Owner.IsLocalClient)
			{
				Singleton<GameInput>.Instance.ExitAll();
			}
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x000F043C File Offset: 0x000EE63C
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x000F047C File Offset: 0x000EE67C
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
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
			writer.WriteNetworkObject(npcObject);
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x000F0523 File Offset: 0x000EE723
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x000F052C File Offset: 0x000EE72C
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject npcObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x000F056C File Offset: 0x000EE76C
		private void RpcWriter___Server_SetHeldOpen_1140765316(bool open)
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
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x000F0613 File Offset: 0x000EE813
		public void RpcLogic___SetHeldOpen_1140765316(bool open)
		{
			if (open && !this.IsHeldOpen)
			{
				this.SqueakSound.Play();
			}
			this.IsHeldOpen = open;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x000F0634 File Offset: 0x000EE834
		private void RpcReader___Server_SetHeldOpen_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			bool open = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetHeldOpen_1140765316(open);
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x000F0674 File Offset: 0x000EE874
		private void RpcWriter___Server_SendWateringCanModel_3615296227(string ID)
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
			writer.WriteString(ID);
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x000F071B File Offset: 0x000EE91B
		public void RpcLogic___SendWateringCanModel_3615296227(string ID)
		{
			this.CreateWateringCanModel(ID);
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x000F0724 File Offset: 0x000EE924
		private void RpcReader___Server_SendWateringCanModel_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string id = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendWateringCanModel_3615296227(id);
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x000F0764 File Offset: 0x000EE964
		private void RpcWriter___Observers_CreateWateringCanModel_3615296227(string ID)
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
			writer.WriteString(ID);
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x000F081A File Offset: 0x000EEA1A
		private void RpcLogic___CreateWateringCanModel_3615296227(string ID)
		{
			this.wateringCanModel = this.CreateWateringCanModel_Local(ID, false);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x000F082C File Offset: 0x000EEA2C
		private void RpcReader___Observers_CreateWateringCanModel_3615296227(PooledReader PooledReader0, Channel channel)
		{
			string id = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___CreateWateringCanModel_3615296227(id);
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x000F0868 File Offset: 0x000EEA68
		private void RpcWriter___Server_SendClearWateringCanModelModel_2166136261()
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
			base.SendServerRpc(5U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x000F0902 File Offset: 0x000EEB02
		public void RpcLogic___SendClearWateringCanModelModel_2166136261()
		{
			this.ClearWateringCanModel();
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x000F090C File Offset: 0x000EEB0C
		private void RpcReader___Server_SendClearWateringCanModelModel_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendClearWateringCanModelModel_2166136261();
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x000F093C File Offset: 0x000EEB3C
		private void RpcWriter___Observers_ClearWateringCanModel_2166136261()
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
			base.SendObserversRpc(6U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x000F09E5 File Offset: 0x000EEBE5
		private void RpcLogic___ClearWateringCanModel_2166136261()
		{
			if (this.wateringCanModel != null)
			{
				Object.Destroy(this.wateringCanModel);
				this.wateringCanModel = null;
			}
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x000F0A08 File Offset: 0x000EEC08
		private void RpcReader___Observers_ClearWateringCanModel_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ClearWateringCanModel_2166136261();
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x000F0A32 File Offset: 0x000EEC32
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x000F0A3A File Offset: 0x000EEC3A
		public bool SyncAccessor_<IsHeldOpen>k__BackingField
		{
			get
			{
				return this.<IsHeldOpen>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<IsHeldOpen>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<IsHeldOpen>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x000F0A78 File Offset: 0x000EEC78
		public virtual bool Tap(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 2U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<PlayerUserObject>k__BackingField(this.syncVar___<PlayerUserObject>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<PlayerUserObject>k__BackingField(value, Boolean2);
				return true;
			}
			else if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<NPCUserObject>k__BackingField(this.syncVar___<NPCUserObject>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value2 = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<NPCUserObject>k__BackingField(value2, Boolean2);
				return true;
			}
			else
			{
				if (UInt321 != 0U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_<IsHeldOpen>k__BackingField(this.syncVar___<IsHeldOpen>k__BackingField.GetValue(true), true);
					return true;
				}
				bool value3 = PooledReader0.ReadBoolean();
				this.sync___set_value_<IsHeldOpen>k__BackingField(value3, Boolean2);
				return true;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x000F0B52 File Offset: 0x000EED52
		// (set) Token: 0x060038F3 RID: 14579 RVA: 0x000F0B5A File Offset: 0x000EED5A
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			get
			{
				return this.<NPCUserObject>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<NPCUserObject>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<NPCUserObject>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060038F4 RID: 14580 RVA: 0x000F0B96 File Offset: 0x000EED96
		// (set) Token: 0x060038F5 RID: 14581 RVA: 0x000F0B9E File Offset: 0x000EED9E
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			get
			{
				return this.<PlayerUserObject>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<PlayerUserObject>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<PlayerUserObject>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x000F0BDA File Offset: 0x000EEDDA
		private void dll()
		{
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x04002930 RID: 10544
		public const float MaxFlowRate = 6f;

		// Token: 0x04002932 RID: 10546
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04002933 RID: 10547
		public Transform CameraPos;

		// Token: 0x04002934 RID: 10548
		public Transform WateringCamPos;

		// Token: 0x04002935 RID: 10549
		public Collider HandleCollider;

		// Token: 0x04002936 RID: 10550
		public Transform Handle;

		// Token: 0x04002937 RID: 10551
		public Clickable HandleClickable;

		// Token: 0x04002938 RID: 10552
		public ParticleSystem WaterParticles;

		// Token: 0x04002939 RID: 10553
		public AudioSourceController SqueakSound;

		// Token: 0x0400293A RID: 10554
		public AudioSourceController WaterRunningSound;

		// Token: 0x0400293D RID: 10557
		private float tapFlow;

		// Token: 0x0400293E RID: 10558
		private GameObject wateringCanModel;

		// Token: 0x0400293F RID: 10559
		private bool intObjSetThisFrame;

		// Token: 0x04002940 RID: 10560
		public SyncVar<bool> syncVar___<IsHeldOpen>k__BackingField;

		// Token: 0x04002941 RID: 10561
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04002942 RID: 10562
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04002943 RID: 10563
		private bool dll_Excuted;

		// Token: 0x04002944 RID: 10564
		private bool dll_Excuted;
	}
}
