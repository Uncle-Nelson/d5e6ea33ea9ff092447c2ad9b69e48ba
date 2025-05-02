using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Clothing;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005EF RID: 1519
	public class PlayerClothing : NetworkBehaviour, IItemSlotOwner
	{
		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x0009FAE3 File Offset: 0x0009DCE3
		// (set) Token: 0x06002727 RID: 10023 RVA: 0x0009FAEB File Offset: 0x0009DCEB
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x0009FAF4 File Offset: 0x0009DCF4
		private AvatarSettings appearanceSettings
		{
			get
			{
				return this.Player.Avatar.CurrentSettings;
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x0009FB08 File Offset: 0x0009DD08
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.PlayerScripts.PlayerClothing_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00065DE5 File Offset: 0x00063FE5
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsLocalClient)
			{
				return;
			}
			((IItemSlotOwner)this).SendItemsToClient(connection);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0009FB28 File Offset: 0x0009DD28
		public void InsertClothing(ClothingInstance clothing)
		{
			EClothingSlot slot = (clothing.Definition as ClothingDefinition).Slot;
			if (!this.ClothingSlots.ContainsKey(slot))
			{
				Console.LogError("No slot found for clothing slot type: " + slot.ToString(), null);
				return;
			}
			this.ClothingSlots[slot].SetStoredItem(clothing, false);
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0009FB85 File Offset: 0x0009DD85
		protected virtual void ClothingChanged()
		{
			this.RefreshAppearance();
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0009FB90 File Offset: 0x0009DD90
		public virtual void RefreshAppearance()
		{
			AvatarSettings avatarSettings = Object.Instantiate<AvatarSettings>(this.appearanceSettings);
			for (int i = 0; i < avatarSettings.BodyLayerSettings.Count; i++)
			{
				if (!(avatarSettings.BodyLayerSettings[i].layerPath == string.Empty))
				{
					AvatarLayer avatarLayer = Resources.Load<AvatarLayer>(avatarSettings.BodyLayerSettings[i].layerPath);
					ClothingInstance clothingInstance;
					if (!(avatarLayer == null) && avatarLayer.Order > 19 && !this.TryGetInventoryClothing(avatarLayer.AssetPath, avatarSettings.BodyLayerSettings[i].layerTint, out clothingInstance))
					{
						avatarSettings.BodyLayerSettings.RemoveAt(i);
						i--;
					}
				}
			}
			for (int j = 0; j < avatarSettings.AccessorySettings.Count; j++)
			{
				if (!(avatarSettings.AccessorySettings[j].path == string.Empty))
				{
					Accessory accessory = Resources.Load<Accessory>(avatarSettings.AccessorySettings[j].path);
					ClothingInstance clothingInstance2;
					if (!(accessory == null) && !this.TryGetInventoryClothing(accessory.AssetPath, avatarSettings.AccessorySettings[j].color, out clothingInstance2))
					{
						avatarSettings.AccessorySettings.RemoveAt(j);
						j--;
					}
				}
			}
			for (int k = 0; k < this.ItemSlots.Count; k++)
			{
				if (this.ItemSlots[k].Quantity > 0)
				{
					ClothingInstance clothingInstance3 = this.ItemSlots[k].ItemInstance as ClothingInstance;
					if (clothingInstance3 != null && !this.IsClothingApplied(avatarSettings, clothingInstance3))
					{
						this.ApplyClothing(avatarSettings, clothingInstance3);
					}
				}
			}
			this.Player.SetAvatarSettings(avatarSettings);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x0009FD3C File Offset: 0x0009DF3C
		private bool TryGetInventoryClothing(string assetPath, Color color, out ClothingInstance clothing)
		{
			clothing = null;
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].Quantity > 0)
				{
					ClothingInstance clothingInstance = this.ItemSlots[i].ItemInstance as ClothingInstance;
					if (clothingInstance != null)
					{
						ClothingDefinition clothingDefinition = clothingInstance.Definition as ClothingDefinition;
						if (!(clothingDefinition == null) && clothingInstance.Color.GetActualColor() == color && clothingDefinition.ClothingAssetPath == assetPath)
						{
							clothing = clothingInstance;
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x0009FDCC File Offset: 0x0009DFCC
		private bool IsClothingApplied(AvatarSettings settings, ClothingInstance clothing)
		{
			if (clothing == null)
			{
				return false;
			}
			ClothingDefinition clothingDefinition = clothing.Definition as ClothingDefinition;
			for (int i = 0; i < settings.BodyLayerSettings.Count; i++)
			{
				if (settings.BodyLayerSettings[i].layerPath == clothingDefinition.ClothingAssetPath && settings.BodyLayerSettings[i].layerTint == clothing.Color.GetActualColor())
				{
					return true;
				}
			}
			for (int j = 0; j < settings.AccessorySettings.Count; j++)
			{
				if (settings.AccessorySettings[j].path == clothingDefinition.ClothingAssetPath && settings.AccessorySettings[j].color == clothing.Color.GetActualColor())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0009FEA0 File Offset: 0x0009E0A0
		private void ApplyClothing(AvatarSettings settings, ClothingInstance clothing)
		{
			if (clothing == null)
			{
				return;
			}
			ClothingDefinition clothingDefinition = clothing.Definition as ClothingDefinition;
			if (clothingDefinition.ApplicationType == EClothingApplicationType.BodyLayer)
			{
				settings.BodyLayerSettings.Add(new AvatarSettings.LayerSetting
				{
					layerPath = clothingDefinition.ClothingAssetPath,
					layerTint = clothing.Color.GetActualColor()
				});
				return;
			}
			if (clothingDefinition.ApplicationType == EClothingApplicationType.Accessory)
			{
				settings.AccessorySettings.Add(new AvatarSettings.AccessorySetting
				{
					path = clothingDefinition.ClothingAssetPath,
					color = clothing.Color.GetActualColor()
				});
				return;
			}
			Console.LogError("Unknown clothing application type: " + clothingDefinition.ApplicationType.ToString(), null);
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0009FF51 File Offset: 0x0009E151
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0009FF78 File Offset: 0x0009E178
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
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

		// Token: 0x06002733 RID: 10035 RVA: 0x0009FFD7 File Offset: 0x0009E1D7
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0009FFF5 File Offset: 0x0009E1F5
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000A0013 File Offset: 0x0009E213
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000A004C File Offset: 0x0009E24C
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

		// Token: 0x06002738 RID: 10040 RVA: 0x000A00F4 File Offset: 0x0009E2F4
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(6U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x000A01CA File Offset: 0x0009E3CA
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x000A01DD File Offset: 0x0009E3DD
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x000A01EC File Offset: 0x0009E3EC
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
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000A02B2 File Offset: 0x0009E4B2
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000A02DC File Offset: 0x0009E4DC
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

		// Token: 0x0600273E RID: 10046 RVA: 0x000A0344 File Offset: 0x0009E544
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
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000A040C File Offset: 0x0009E60C
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000A0438 File Offset: 0x0009E638
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

		// Token: 0x06002741 RID: 10049 RVA: 0x000A048C File Offset: 0x0009E68C
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
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000A0554 File Offset: 0x0009E754
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

		// Token: 0x06002743 RID: 10051 RVA: 0x000A05AC File Offset: 0x0009E7AC
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
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000A066A File Offset: 0x0009E86A
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000A0674 File Offset: 0x0009E874
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

		// Token: 0x06002746 RID: 10054 RVA: 0x000A06D0 File Offset: 0x0009E8D0
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
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000A079D File Offset: 0x0009E99D
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000A07B4 File Offset: 0x0009E9B4
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

		// Token: 0x06002749 RID: 10057 RVA: 0x000A080C File Offset: 0x0009EA0C
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
			base.SendServerRpc(5U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x000A08EC File Offset: 0x0009EAEC
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x000A091C File Offset: 0x0009EB1C
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

		// Token: 0x0600274C RID: 10060 RVA: 0x000A09A4 File Offset: 0x0009EBA4
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
			base.SendTargetRpc(6U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x000A0A85 File Offset: 0x0009EC85
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x000A0AB4 File Offset: 0x0009ECB4
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

		// Token: 0x0600274F RID: 10063 RVA: 0x000A0B30 File Offset: 0x0009ED30
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
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x000A0C14 File Offset: 0x0009EE14
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

		// Token: 0x06002751 RID: 10065 RVA: 0x000A0C88 File Offset: 0x0009EE88
		protected virtual void dll()
		{
			foreach (object obj in Enum.GetValues(typeof(EClothingSlot)))
			{
				EClothingSlot eclothingSlot = (EClothingSlot)obj;
				ItemSlot itemSlot = new ItemSlot();
				itemSlot.SetSlotOwner(this);
				itemSlot.AddFilter(new ItemFilter_ClothingSlot(eclothingSlot));
				ItemSlot itemSlot2 = itemSlot;
				itemSlot2.onItemDataChanged = (Action)Delegate.Combine(itemSlot2.onItemDataChanged, new Action(this.ClothingChanged));
				this.ClothingSlots.Add(eclothingSlot, itemSlot);
			}
		}

		// Token: 0x04001C81 RID: 7297
		public Player Player;

		// Token: 0x04001C83 RID: 7299
		public Dictionary<EClothingSlot, ItemSlot> ClothingSlots = new Dictionary<EClothingSlot, ItemSlot>();

		// Token: 0x04001C84 RID: 7300
		private List<ClothingInstance> appliedClothing = new List<ClothingInstance>();

		// Token: 0x04001C85 RID: 7301
		private bool dll_Excuted;

		// Token: 0x04001C86 RID: 7302
		private bool dll_Excuted;
	}
}
