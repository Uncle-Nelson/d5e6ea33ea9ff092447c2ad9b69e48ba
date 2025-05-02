using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Storage
{
	// Token: 0x020008A9 RID: 2217
	public class StorageEntity : NetworkBehaviour, IItemSlotOwner
	{
		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06003C0E RID: 15374 RVA: 0x000FCCC4 File Offset: 0x000FAEC4
		public bool IsOpened
		{
			get
			{
				return this.CurrentAccessor != null;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x000FCCD2 File Offset: 0x000FAED2
		// (set) Token: 0x06003C10 RID: 15376 RVA: 0x000FCCDA File Offset: 0x000FAEDA
		public Player CurrentAccessor { get; protected set; }

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x00065F14 File Offset: 0x00064114
		public int ItemCount
		{
			get
			{
				return ((IItemSlotOwner)this).GetTotalItemCount();
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06003C12 RID: 15378 RVA: 0x000FCCE3 File Offset: 0x000FAEE3
		// (set) Token: 0x06003C13 RID: 15379 RVA: 0x000FCCEB File Offset: 0x000FAEEB
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x06003C14 RID: 15380 RVA: 0x000FCCF4 File Offset: 0x000FAEF4
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Storage.StorageEntity_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x000FCD14 File Offset: 0x000FAF14
		protected virtual void Start()
		{
			MoneyManager instance = NetworkSingleton<MoneyManager>.Instance;
			instance.onNetworthCalculation = (Action<MoneyManager.FloatContainer>)Delegate.Combine(instance.onNetworthCalculation, new Action<MoneyManager.FloatContainer>(this.GetNetworth));
			if (this.EmptyOnSleep)
			{
				ScheduleOne.GameTime.TimeManager.onSleepStart = (Action)Delegate.Combine(ScheduleOne.GameTime.TimeManager.onSleepStart, new Action(this.ClearContents));
			}
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x000FCD70 File Offset: 0x000FAF70
		protected virtual void OnDestroy()
		{
			if (NetworkSingleton<MoneyManager>.InstanceExists)
			{
				MoneyManager instance = NetworkSingleton<MoneyManager>.Instance;
				instance.onNetworthCalculation = (Action<MoneyManager.FloatContainer>)Delegate.Remove(instance.onNetworthCalculation, new Action<MoneyManager.FloatContainer>(this.GetNetworth));
			}
			ScheduleOne.GameTime.TimeManager.onSleepStart = (Action)Delegate.Remove(ScheduleOne.GameTime.TimeManager.onSleepStart, new Action(this.ClearContents));
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x000FCDCC File Offset: 0x000FAFCC
		private void GetNetworth(MoneyManager.FloatContainer container)
		{
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].ItemInstance != null)
				{
					container.ChangeValue(this.ItemSlots[i].ItemInstance.GetMonetaryValue());
				}
			}
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x000FCE1E File Offset: 0x000FB01E
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			((IItemSlotOwner)this).SendItemsToClient(connection);
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x000FCE30 File Offset: 0x000FB030
		protected virtual void FixedUpdate()
		{
			if (this.IsOpened && this.CurrentAccessor == Player.Local && this.MaxAccessDistance > 0f && Vector3.Distance(PlayerSingleton<PlayerMovement>.Instance.transform.position, base.transform.position) > this.MaxAccessDistance + 1f)
			{
				this.Close();
			}
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x000FCE98 File Offset: 0x000FB098
		public Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			Dictionary<StorableItemInstance, int> dictionary = new Dictionary<StorableItemInstance, int>();
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].ItemInstance != null && this.ItemSlots[i].ItemInstance is StorableItemInstance && this.ItemSlots[i].Quantity > 0 && !dictionary.ContainsKey(this.ItemSlots[i].ItemInstance as StorableItemInstance))
				{
					dictionary.Add(this.ItemSlots[i].ItemInstance as StorableItemInstance, this.ItemSlots[i].Quantity);
				}
			}
			return dictionary;
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x000FCF52 File Offset: 0x000FB152
		public bool CanItemFit(ItemInstance item, int quantity = 1)
		{
			return this.HowManyCanFit(item) >= quantity;
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x000FCF64 File Offset: 0x000FB164
		public int HowManyCanFit(ItemInstance item)
		{
			int num = 0;
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (!this.ItemSlots[i].IsLocked && !this.ItemSlots[i].IsAddLocked)
				{
					if (this.ItemSlots[i].ItemInstance == null)
					{
						num += item.StackLimit;
					}
					else if (this.ItemSlots[i].ItemInstance.CanStackWith(item, true))
					{
						num += item.StackLimit - this.ItemSlots[i].ItemInstance.Quantity;
					}
				}
			}
			return num;
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x000FD010 File Offset: 0x000FB210
		public void InsertItem(ItemInstance item, bool network = true)
		{
			if (!this.CanItemFit(item, item.Quantity))
			{
				Console.LogWarning("StorageEntity InsertItem() called but CanItemFit() returned false", null);
				return;
			}
			int num = item.Quantity;
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (!this.ItemSlots[i].IsLocked && !this.ItemSlots[i].IsAddLocked)
				{
					if (this.ItemSlots[i].ItemInstance == null)
					{
						num -= item.StackLimit;
						this.ItemSlots[i].SetStoredItem(item, !network);
						return;
					}
					if (this.ItemSlots[i].ItemInstance.CanStackWith(item, true))
					{
						int num2 = Mathf.Min(item.StackLimit - this.ItemSlots[i].ItemInstance.Quantity, num);
						num -= num2;
						this.ItemSlots[i].ChangeQuantity(-num2, network);
					}
					if (num <= 0)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x000FD114 File Offset: 0x000FB314
		protected virtual void ContentsChanged()
		{
			if (this.onContentsChanged != null)
			{
				this.onContentsChanged.Invoke();
			}
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x000FD12C File Offset: 0x000FB32C
		public List<ItemInstance> GetAllItems()
		{
			List<ItemInstance> list = new List<ItemInstance>();
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].ItemInstance != null)
				{
					list.Add(this.ItemSlots[i].ItemInstance);
				}
			}
			return list;
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x000FD180 File Offset: 0x000FB380
		public void LoadFromItemSet(ItemInstance[] items)
		{
			int num = 0;
			while (num < items.Length && num < this.ItemSlots.Count)
			{
				this.ItemSlots[num].SetStoredItem(items[num], false);
				num++;
			}
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x000FD1C0 File Offset: 0x000FB3C0
		public void ClearContents()
		{
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				this.ItemSlots[i].ClearStoredInstance(false);
			}
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x000FD1F5 File Offset: 0x000FB3F5
		public void Open()
		{
			if (!this.CanBeOpened())
			{
				Console.LogWarning("StorageEntity Open() called but CanBeOpened() returned false", null);
				return;
			}
			Singleton<StorageMenu>.Instance.Open(this);
			this.SendAccessor(Player.Local.NetworkObject);
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x000FD226 File Offset: 0x000FB426
		public void Close()
		{
			if (Singleton<StorageMenu>.Instance.OpenedStorageEntity != this)
			{
				Console.LogWarning("StorageEntity Close() called but StorageMenu.Instance.OpenedStorageEntity != this", null);
				return;
			}
			Singleton<StorageMenu>.Instance.CloseMenu();
			this.SendAccessor(null);
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x000FD257 File Offset: 0x000FB457
		protected virtual void OnOpened()
		{
			if (this.onOpened != null)
			{
				this.onOpened.Invoke();
			}
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x000FD26C File Offset: 0x000FB46C
		protected virtual void OnClosed()
		{
			if (this.onClosed != null)
			{
				this.onClosed.Invoke();
			}
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x000FD281 File Offset: 0x000FB481
		public virtual bool CanBeOpened()
		{
			return !Singleton<ManagementClipboard>.Instance.IsEquipped && this.AccessSettings != StorageEntity.EAccessSettings.Closed && (this.AccessSettings != StorageEntity.EAccessSettings.SinglePlayerOnly || !(this.CurrentAccessor != null));
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x000FD2B5 File Offset: 0x000FB4B5
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendAccessor(NetworkObject accessor)
		{
			this.RpcWriter___Server_SendAccessor_3323014238(accessor);
			this.RpcLogic___SendAccessor_3323014238(accessor);
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x000FD2CC File Offset: 0x000FB4CC
		[ObserversRpc(RunLocally = true)]
		private void SetAccessor(NetworkObject accessor)
		{
			this.RpcWriter___Observers_SetAccessor_3323014238(accessor);
			this.RpcLogic___SetAccessor_3323014238(accessor);
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x000FD2ED File Offset: 0x000FB4ED
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x000FD314 File Offset: 0x000FB514
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

		// Token: 0x06003C2B RID: 15403 RVA: 0x000FD373 File Offset: 0x000FB573
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x000FD391 File Offset: 0x000FB591
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x000FD3AF File Offset: 0x000FB5AF
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x000FD3E8 File Offset: 0x000FB5E8
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

		// Token: 0x06003C30 RID: 15408 RVA: 0x000FD4BC File Offset: 0x000FB6BC
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendAccessor_3323014238));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetAccessor_3323014238));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterTargetRpc(4U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(6U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(7U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(8U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x000FD5C0 File Offset: 0x000FB7C0
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Storage.StorageEntityAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x000FD5D3 File Offset: 0x000FB7D3
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x000FD5E4 File Offset: 0x000FB7E4
		private void RpcWriter___Server_SendAccessor_3323014238(NetworkObject accessor)
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
			writer.WriteNetworkObject(accessor);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x000FD68B File Offset: 0x000FB88B
		private void RpcLogic___SendAccessor_3323014238(NetworkObject accessor)
		{
			this.SetAccessor(accessor);
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x000FD694 File Offset: 0x000FB894
		private void RpcReader___Server_SendAccessor_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject accessor = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendAccessor_3323014238(accessor);
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x000FD6D4 File Offset: 0x000FB8D4
		private void RpcWriter___Observers_SetAccessor_3323014238(NetworkObject accessor)
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
			writer.WriteNetworkObject(accessor);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x000FD78C File Offset: 0x000FB98C
		private void RpcLogic___SetAccessor_3323014238(NetworkObject accessor)
		{
			Player currentAccessor = this.CurrentAccessor;
			if (accessor != null)
			{
				this.CurrentAccessor = accessor.GetComponent<Player>();
			}
			else
			{
				this.CurrentAccessor = null;
			}
			if (this.CurrentAccessor != null && currentAccessor == null)
			{
				this.OnOpened();
			}
			if (this.CurrentAccessor == null && currentAccessor != null)
			{
				this.OnClosed();
			}
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x000FD7F8 File Offset: 0x000FB9F8
		private void RpcReader___Observers_SetAccessor_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject accessor = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetAccessor_3323014238(accessor);
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x000FD834 File Offset: 0x000FBA34
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
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x000FD8FA File Offset: 0x000FBAFA
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x000FD924 File Offset: 0x000FBB24
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

		// Token: 0x06003C3C RID: 15420 RVA: 0x000FD98C File Offset: 0x000FBB8C
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
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x000FDA54 File Offset: 0x000FBC54
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x000FDA80 File Offset: 0x000FBC80
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

		// Token: 0x06003C3F RID: 15423 RVA: 0x000FDAD4 File Offset: 0x000FBCD4
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
			base.SendTargetRpc(4U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x000FDB9C File Offset: 0x000FBD9C
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

		// Token: 0x06003C41 RID: 15425 RVA: 0x000FDBF4 File Offset: 0x000FBDF4
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
			base.SendServerRpc(5U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x000FDCB2 File Offset: 0x000FBEB2
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x000FDCBC File Offset: 0x000FBEBC
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

		// Token: 0x06003C44 RID: 15428 RVA: 0x000FDD18 File Offset: 0x000FBF18
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
			base.SendObserversRpc(6U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x000FDDE5 File Offset: 0x000FBFE5
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x000FDDFC File Offset: 0x000FBFFC
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

		// Token: 0x06003C47 RID: 15431 RVA: 0x000FDE54 File Offset: 0x000FC054
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
			base.SendServerRpc(7U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x000FDF34 File Offset: 0x000FC134
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x000FDF64 File Offset: 0x000FC164
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

		// Token: 0x06003C4A RID: 15434 RVA: 0x000FDFEC File Offset: 0x000FC1EC
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
			base.SendTargetRpc(8U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x000FE0CD File Offset: 0x000FC2CD
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x000FE0FC File Offset: 0x000FC2FC
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

		// Token: 0x06003C4D RID: 15437 RVA: 0x000FE178 File Offset: 0x000FC378
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
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x000FE25C File Offset: 0x000FC45C
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

		// Token: 0x06003C4F RID: 15439 RVA: 0x000FE2D0 File Offset: 0x000FC4D0
		protected virtual void dll()
		{
			for (int i = 0; i < this.SlotCount; i++)
			{
				ItemSlot itemSlot = new ItemSlot();
				itemSlot.onItemDataChanged = (Action)Delegate.Combine(itemSlot.onItemDataChanged, new Action(this.ContentsChanged));
				itemSlot.SetSlotOwner(this);
			}
		}

		// Token: 0x04002B55 RID: 11093
		public const int MAX_SLOTS = 20;

		// Token: 0x04002B57 RID: 11095
		[Header("Settings")]
		public string StorageEntityName = "Storage Entity";

		// Token: 0x04002B58 RID: 11096
		public string StorageEntitySubtitle = string.Empty;

		// Token: 0x04002B59 RID: 11097
		[Range(1f, 20f)]
		public int SlotCount = 5;

		// Token: 0x04002B5A RID: 11098
		public bool EmptyOnSleep;

		// Token: 0x04002B5B RID: 11099
		[Header("Display Settings")]
		[Tooltip("How many rows to enforce when display contents in StorageMenu")]
		[Range(1f, 5f)]
		public int DisplayRowCount = 1;

		// Token: 0x04002B5C RID: 11100
		[Header("Access Settings")]
		public StorageEntity.EAccessSettings AccessSettings = StorageEntity.EAccessSettings.Full;

		// Token: 0x04002B5D RID: 11101
		[Tooltip("If the distance between this StorageEntity and the player is greater than this, the StorageMenu will be closed.")]
		[Range(0f, 10f)]
		public float MaxAccessDistance = 6f;

		// Token: 0x04002B5F RID: 11103
		[Header("Events")]
		[Tooltip("Invoked when this StorageEntity is accessed in the StorageMenu")]
		public UnityEvent onOpened;

		// Token: 0x04002B60 RID: 11104
		[Tooltip("Invoked when the StorageMenu is closed.")]
		public UnityEvent onClosed;

		// Token: 0x04002B61 RID: 11105
		[Tooltip("Invoked when the contents change in any way. i.e. an item is added, removed, or the quantity of an item changes.")]
		public UnityEvent onContentsChanged;

		// Token: 0x04002B62 RID: 11106
		private bool dll_Excuted;

		// Token: 0x04002B63 RID: 11107
		private bool dll_Excuted;

		// Token: 0x020008AA RID: 2218
		public enum EAccessSettings
		{
			// Token: 0x04002B65 RID: 11109
			Closed,
			// Token: 0x04002B66 RID: 11110
			SinglePlayerOnly,
			// Token: 0x04002B67 RID: 11111
			Full
		}
	}
}
