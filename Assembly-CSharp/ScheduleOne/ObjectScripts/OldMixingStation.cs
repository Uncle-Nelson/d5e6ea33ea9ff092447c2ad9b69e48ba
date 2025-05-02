using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tools;
using ScheduleOne.UI.Compass;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BE5 RID: 3045
	public class OldMixingStation : GridItem, IUsable, IItemSlotOwner
	{
		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x00164F44 File Offset: 0x00163144
		// (set) Token: 0x060054C7 RID: 21703 RVA: 0x00164F4C File Offset: 0x0016314C
		public bool IsOpen { get; private set; }

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060054C8 RID: 21704 RVA: 0x00164F55 File Offset: 0x00163155
		// (set) Token: 0x060054C9 RID: 21705 RVA: 0x00164F5D File Offset: 0x0016315D
		public MixOperation CurrentMixOperation { get; set; }

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060054CA RID: 21706 RVA: 0x00164F66 File Offset: 0x00163166
		// (set) Token: 0x060054CB RID: 21707 RVA: 0x00164F6E File Offset: 0x0016316E
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x00164F77 File Offset: 0x00163177
		// (set) Token: 0x060054CD RID: 21709 RVA: 0x00164F7F File Offset: 0x0016317F
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

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060054CE RID: 21710 RVA: 0x00164F89 File Offset: 0x00163189
		// (set) Token: 0x060054CF RID: 21711 RVA: 0x00164F91 File Offset: 0x00163191
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

		// Token: 0x060054D0 RID: 21712 RVA: 0x00164F9C File Offset: 0x0016319C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.OldMixingStation_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x00164FBB File Offset: 0x001631BB
		protected override void Start()
		{
			base.Start();
			if (!this.isGhost)
			{
				TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x00164FF1 File Offset: 0x001631F1
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			((IItemSlotOwner)this).SendItemsToClient(connection);
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x00165001 File Offset: 0x00163201
		public override void DestroyItem(bool callOnServer = true)
		{
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			base.DestroyItem(callOnServer);
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x00165030 File Offset: 0x00163230
		private void MinPass()
		{
			if (InstanceFinder.IsServer && this.CurrentMixOperation != null)
			{
				this.UpdateScreen();
			}
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x00165048 File Offset: 0x00163248
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetMixOperation(NetworkConnection conn, MixOperation operation)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetMixOperation_719366965(conn, operation);
				this.RpcLogic___SetMixOperation_719366965(conn, operation);
			}
			else
			{
				this.RpcWriter___Target_SetMixOperation_719366965(conn, operation);
			}
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00165089 File Offset: 0x00163289
		private void EnableScreen()
		{
			this.UpdateScreen();
			this.ScreenCanvas.enabled = true;
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x0016509D File Offset: 0x0016329D
		private void UpdateScreen()
		{
			MixOperation currentMixOperation = this.CurrentMixOperation;
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x001650A6 File Offset: 0x001632A6
		private void DisableScreen()
		{
			this.ScreenCanvas.enabled = false;
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x000045B1 File Offset: 0x000027B1
		public void CompleteMixOperation()
		{
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x001650B4 File Offset: 0x001632B4
		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			StorableItemInstance productInstance = recipe.GetProductInstance(this.GetIngredients());
			return this.OutputSlot.GetCapacityForItem(productInstance) >= 1;
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x001650E0 File Offset: 0x001632E0
		public List<ItemInstance> GetIngredients()
		{
			List<ItemInstance> list = new List<ItemInstance>();
			if (this.ProductSlot.ItemInstance != null)
			{
				list.Add(this.ProductSlot.ItemInstance);
			}
			if (this.MixerSlot.ItemInstance != null)
			{
				list.Add(this.MixerSlot.ItemInstance);
			}
			return list;
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x00165130 File Offset: 0x00163330
		public void Open()
		{
			this.IsOpen = true;
			this.SetPlayerUser(Player.Local.NetworkObject);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition.position, this.CameraPosition.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<CompassManager>.Instance.SetVisible(false);
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x001651CC File Offset: 0x001633CC
		public void Close()
		{
			this.IsOpen = false;
			this.SetPlayerUser(null);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			Singleton<CompassManager>.Instance.SetVisible(true);
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x00165244 File Offset: 0x00163444
		public void Hovered()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			this.IntObj.SetMessage("Use " + base.ItemInstance.Name);
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x0016529E File Offset: 0x0016349E
		public void Interacted()
		{
			if (((IUsable)this).IsInUse || Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				return;
			}
			this.Open();
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x001652BB File Offset: 0x001634BB
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x001652E4 File Offset: 0x001634E4
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
				this.RpcLogic___SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
			}
			else
			{
				this.RpcWriter___Target_SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
				this.RpcLogic___SetStoredInstance_Internal_2652194801(conn, itemSlotIndex, instance);
			}
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x00165343 File Offset: 0x00163543
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x00165361 File Offset: 0x00163561
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x0016537F File Offset: 0x0016357F
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x001653B8 File Offset: 0x001635B8
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
				this.RpcLogic___SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			}
			else
			{
				this.RpcWriter___Target_SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
				this.RpcLogic___SetSlotLocked_Internal_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			}
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x00165437 File Offset: 0x00163637
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
			this.RpcWriter___Server_SetPlayerUser_3323014238(playerObject);
			this.RpcLogic___SetPlayerUser_3323014238(playerObject);
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x0016544D File Offset: 0x0016364D
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
			this.RpcWriter___Server_SetNPCUser_3323014238(npcObject);
			this.RpcLogic___SetNPCUser_3323014238(npcObject);
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x00165464 File Offset: 0x00163664
		public override string GetSaveString()
		{
			return new MixingStationData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, new ItemSet(new List<ItemSlot>
			{
				this.ProductSlot
			}), new ItemSet(new List<ItemSlot>
			{
				this.MixerSlot
			}), new ItemSet(new List<ItemSlot>
			{
				this.OutputSlot
			}), this.CurrentMixOperation, 0).GetJson(true);
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x00165508 File Offset: 0x00163708
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<PlayerUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<PlayerUserObject>k__BackingField);
			this.syncVar___<NPCUserObject>k__BackingField = new SyncVar<NetworkObject>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<NPCUserObject>k__BackingField);
			base.RegisterObserversRpc(8U, new ClientRpcDelegate(this.RpcReader___Observers_SetMixOperation_719366965));
			base.RegisterTargetRpc(9U, new ClientRpcDelegate(this.RpcReader___Target_SetMixOperation_719366965));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterTargetRpc(11U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterObserversRpc(12U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(13U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(14U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(15U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(16U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(17U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
			base.RegisterServerRpc(18U, new ServerRpcDelegate(this.RpcReader___Server_SetPlayerUser_3323014238));
			base.RegisterServerRpc(19U, new ServerRpcDelegate(this.RpcReader___Server_SetNPCUser_3323014238));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.ObjectScripts.OldMixingStation));
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x001656A8 File Offset: 0x001638A8
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.OldMixingStationAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<PlayerUserObject>k__BackingField.SetRegistered();
			this.syncVar___<NPCUserObject>k__BackingField.SetRegistered();
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x001656D7 File Offset: 0x001638D7
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x001656E8 File Offset: 0x001638E8
		private void RpcWriter___Observers_SetMixOperation_719366965(NetworkConnection conn, MixOperation operation)
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
			writer.Write___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generated(operation);
			base.SendObserversRpc(8U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x001657A0 File Offset: 0x001639A0
		public void RpcLogic___SetMixOperation_719366965(NetworkConnection conn, MixOperation operation)
		{
			MixOperation currentMixOperation = this.CurrentMixOperation;
			this.CurrentMixOperation = operation;
			if (operation != null)
			{
				if (currentMixOperation == null)
				{
					this.Animation.Play("Mixing station start");
					this.MachineSound.StartAudio();
					this.StartSound.Play();
				}
				this.EnableScreen();
				return;
			}
			if (currentMixOperation != null)
			{
				this.Animation.Play("Mixing station end");
				this.MachineSound.StopAudio();
				this.StopSound.Play();
			}
			this.DisableScreen();
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x00165820 File Offset: 0x00163A20
		private void RpcReader___Observers_SetMixOperation_719366965(PooledReader PooledReader0, Channel channel)
		{
			MixOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetMixOperation_719366965(null, operation);
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x0016585C File Offset: 0x00163A5C
		private void RpcWriter___Target_SetMixOperation_719366965(NetworkConnection conn, MixOperation operation)
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
			writer.Write___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generated(operation);
			base.SendTargetRpc(9U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x00165914 File Offset: 0x00163B14
		private void RpcReader___Target_SetMixOperation_719366965(PooledReader PooledReader0, Channel channel)
		{
			MixOperation operation = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetMixOperation_719366965(base.LocalConnection, operation);
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x0016594C File Offset: 0x00163B4C
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
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
			writer.WriteNetworkConnection(conn);
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteItemInstance(instance);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x00165A12 File Offset: 0x00163C12
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x060054F7 RID: 21751 RVA: 0x00165A20 File Offset: 0x00163C20
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			ItemInstance instance = PooledReader0.ReadItemInstance();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetStoredInstance_2652194801(conn2, itemSlotIndex, instance);
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x00165A88 File Offset: 0x00163C88
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteItemInstance(instance);
			base.SendTargetRpc(11U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x00165B4F File Offset: 0x00163D4F
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x00165B7C File Offset: 0x00163D7C
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			ItemInstance instance = PooledReader0.ReadItemInstance();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetStoredInstance_Internal_2652194801(base.LocalConnection, itemSlotIndex, instance);
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x00165BD4 File Offset: 0x00163DD4
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteItemInstance(instance);
			base.SendObserversRpc(12U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00165C9C File Offset: 0x00163E9C
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			ItemInstance instance = PooledReader0.ReadItemInstance();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetStoredInstance_Internal_2652194801(null, itemSlotIndex, instance);
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00165CF0 File Offset: 0x00163EF0
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendServerRpc(13U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00165DAE File Offset: 0x00163FAE
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x00165DB8 File Offset: 0x00163FB8
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x00165E14 File Offset: 0x00164014
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteInt32(quantity, AutoPackType.Packed);
			base.SendObserversRpc(14U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x00165EE1 File Offset: 0x001640E1
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x00165EF8 File Offset: 0x001640F8
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			int quantity = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00165F50 File Offset: 0x00164150
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
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
			writer.WriteNetworkConnection(conn);
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteBoolean(locked);
			writer.WriteNetworkObject(lockOwner);
			writer.WriteString(lockReason);
			base.SendServerRpc(15U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00166030 File Offset: 0x00164230
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00166040 File Offset: 0x00164240
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkConnection conn2 = PooledReader0.ReadNetworkConnection();
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool locked = PooledReader0.ReadBoolean();
			NetworkObject lockOwner = PooledReader0.ReadNetworkObject();
			string lockReason = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetSlotLocked_3170825843(conn2, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x001660C8 File Offset: 0x001642C8
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteBoolean(locked);
			writer.WriteNetworkObject(lockOwner);
			writer.WriteString(lockReason);
			base.SendTargetRpc(16U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x001661A9 File Offset: 0x001643A9
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x001661D8 File Offset: 0x001643D8
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool locked = PooledReader0.ReadBoolean();
			NetworkObject lockOwner = PooledReader0.ReadNetworkObject();
			string lockReason = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetSlotLocked_Internal_3170825843(base.LocalConnection, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x00166254 File Offset: 0x00164454
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
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
			writer.WriteInt32(itemSlotIndex, AutoPackType.Packed);
			writer.WriteBoolean(locked);
			writer.WriteNetworkObject(lockOwner);
			writer.WriteString(lockReason);
			base.SendObserversRpc(17U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x00166338 File Offset: 0x00164538
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			int itemSlotIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool locked = PooledReader0.ReadBoolean();
			NetworkObject lockOwner = PooledReader0.ReadNetworkObject();
			string lockReason = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetSlotLocked_Internal_3170825843(null, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x001663AC File Offset: 0x001645AC
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
			base.SendServerRpc(18U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x00166453 File Offset: 0x00164653
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			this.PlayerUserObject = playerObject;
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x0016645C File Offset: 0x0016465C
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

		// Token: 0x0600550E RID: 21774 RVA: 0x0016649C File Offset: 0x0016469C
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
			base.SendServerRpc(19U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x00166543 File Offset: 0x00164743
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			this.NPCUserObject = npcObject;
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x0016654C File Offset: 0x0016474C
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

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x0016658A File Offset: 0x0016478A
		// (set) Token: 0x06005512 RID: 21778 RVA: 0x00166592 File Offset: 0x00164792
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

		// Token: 0x06005513 RID: 21779 RVA: 0x001665D0 File Offset: 0x001647D0
		public virtual bool OldMixingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 1U)
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
			else
			{
				if (UInt321 != 0U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_<NPCUserObject>k__BackingField(this.syncVar___<NPCUserObject>k__BackingField.GetValue(true), true);
					return true;
				}
				NetworkObject value2 = PooledReader0.ReadNetworkObject();
				this.sync___set_value_<NPCUserObject>k__BackingField(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06005514 RID: 21780 RVA: 0x00166666 File Offset: 0x00164866
		// (set) Token: 0x06005515 RID: 21781 RVA: 0x0016666E File Offset: 0x0016486E
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

		// Token: 0x06005516 RID: 21782 RVA: 0x001666AC File Offset: 0x001648AC
		protected virtual void dll()
		{
			base.Awake();
			if (!this.isGhost)
			{
				this.ProductSlot.AddFilter(new ItemFilter_UnpackagedProduct());
				this.ProductSlot.SetSlotOwner(this);
				this.InputVisuals.AddSlot(this.ProductSlot, false);
				ItemSlot productSlot = this.ProductSlot;
				productSlot.onItemDataChanged = (Action)Delegate.Combine(productSlot.onItemDataChanged, new Action(delegate()
				{
					base.HasChanged = true;
				}));
				this.MixerSlot.AddFilter(new ItemFilter_Category(new List<EItemCategory>
				{
					EItemCategory.Ingredient
				}));
				this.MixerSlot.SetSlotOwner(this);
				this.InputVisuals.AddSlot(this.MixerSlot, false);
				ItemSlot mixerSlot = this.MixerSlot;
				mixerSlot.onItemDataChanged = (Action)Delegate.Combine(mixerSlot.onItemDataChanged, new Action(delegate()
				{
					base.HasChanged = true;
				}));
				this.OutputSlot.SetIsAddLocked(true);
				this.OutputSlot.SetSlotOwner(this);
				this.OutputVisuals.AddSlot(this.OutputSlot, false);
				ItemSlot outputSlot = this.OutputSlot;
				outputSlot.onItemDataChanged = (Action)Delegate.Combine(outputSlot.onItemDataChanged, new Action(delegate()
				{
					base.HasChanged = true;
				}));
			}
		}

		// Token: 0x04003EFF RID: 16127
		public int MIX_TIME_PER_ITEM = 15;

		// Token: 0x04003F00 RID: 16128
		public int MIN_MIX_TIME = 30;

		// Token: 0x04003F03 RID: 16131
		public ItemSlot ProductSlot;

		// Token: 0x04003F04 RID: 16132
		public ItemSlot MixerSlot;

		// Token: 0x04003F05 RID: 16133
		public ItemSlot OutputSlot;

		// Token: 0x04003F09 RID: 16137
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04003F0A RID: 16138
		public Transform CameraPosition;

		// Token: 0x04003F0B RID: 16139
		public StorageVisualizer InputVisuals;

		// Token: 0x04003F0C RID: 16140
		public StorageVisualizer OutputVisuals;

		// Token: 0x04003F0D RID: 16141
		public Animation Animation;

		// Token: 0x04003F0E RID: 16142
		[Header("Screen")]
		public Canvas ScreenCanvas;

		// Token: 0x04003F0F RID: 16143
		public Image OutputIcon;

		// Token: 0x04003F10 RID: 16144
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x04003F11 RID: 16145
		public TextMeshProUGUI ProgressLabel;

		// Token: 0x04003F12 RID: 16146
		[Header("Sounds")]
		public StartLoopStopAudio MachineSound;

		// Token: 0x04003F13 RID: 16147
		public AudioSourceController StartSound;

		// Token: 0x04003F14 RID: 16148
		public AudioSourceController StopSound;

		// Token: 0x04003F15 RID: 16149
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04003F16 RID: 16150
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04003F17 RID: 16151
		private bool dll_Excuted;

		// Token: 0x04003F18 RID: 16152
		private bool dll_Excuted;
	}
}
