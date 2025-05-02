using System;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200045B RID: 1115
	public class NPCInventory : NetworkBehaviour, IItemSlotOwner
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x00065D79 File Offset: 0x00063F79
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x00065D81 File Offset: 0x00063F81
		public List<ItemSlot> ItemSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x0600171E RID: 5918 RVA: 0x00065D8C File Offset: 0x00063F8C
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.NPCInventory_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00065DAB File Offset: 0x00063FAB
		protected virtual void Start()
		{
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.OnSleepStart));
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.OnSleepStart));
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00065DE5 File Offset: 0x00063FE5
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsLocalClient)
			{
				return;
			}
			((IItemSlotOwner)this).SendItemsToClient(connection);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00065DFE File Offset: 0x00063FFE
		private void OnDestroy()
		{
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.InstanceExists)
			{
				NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.OnSleepStart));
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00065E24 File Offset: 0x00064024
		protected virtual void OnSleepStart()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.ClearInventoryEachNight)
			{
				foreach (ItemSlot itemSlot in this.ItemSlots)
				{
					itemSlot.ClearStoredInstance(false);
				}
			}
			if (this.GetTotalItemCount() >= 3)
			{
				return;
			}
			if (this.RandomCash)
			{
				int num = Random.Range(this.RandomCashMin, this.RandomCashMax);
				if (num > 0)
				{
					CashInstance cashInstance = NetworkSingleton<MoneyManager>.Instance.GetCashInstance((float)num);
					this.InsertItem(cashInstance, true);
				}
			}
			if (this.RandomItems)
			{
				int num2 = Random.Range(this.RandomItemMin, this.RandomItemMax + 1);
				for (int i = 0; i < num2; i++)
				{
					ItemInstance defaultInstance = this.RandomItemDefinitions[Random.Range(0, this.RandomItemDefinitions.Length)].GetDefaultInstance(1);
					this.InsertItem(defaultInstance, true);
				}
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00065F14 File Offset: 0x00064114
		public int GetItemCount()
		{
			return ((IItemSlotOwner)this).GetTotalItemCount();
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00065F1C File Offset: 0x0006411C
		public int _GetItemAmount(string id)
		{
			return ((IItemSlotOwner)this).GetItemCount(id);
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00065F28 File Offset: 0x00064128
		public int GetIdenticalItemAmount(ItemInstance item)
		{
			int num = 0;
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].Quantity != 0 && this.ItemSlots[i].ItemInstance.CanStackWith(item, false))
				{
					num += this.ItemSlots[i].Quantity;
				}
			}
			return num;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00065F90 File Offset: 0x00064190
		public int GetMaxItemCount(string[] ids)
		{
			int[] array = new int[ids.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = ((IItemSlotOwner)this).GetItemCount(ids[i]);
			}
			if (array.Length == 0)
			{
				return 0;
			}
			return array.Max();
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00065FCC File Offset: 0x000641CC
		public bool CanItemFit(ItemInstance item, int quantity = 1)
		{
			return this.HowManyCanFit(item) >= quantity;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00065FDC File Offset: 0x000641DC
		public int HowManyCanFit(ItemInstance item)
		{
			if (item == null)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i] != null && !this.ItemSlots[i].IsLocked && !this.ItemSlots[i].IsAddLocked)
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

		// Token: 0x06001729 RID: 5929 RVA: 0x0006609C File Offset: 0x0006429C
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
					if (this.ItemSlots[i].ItemInstance != null && this.ItemSlots[i].ItemInstance.CanStackWith(item, true))
					{
						int num2 = Mathf.Min(item.StackLimit - this.ItemSlots[i].ItemInstance.Quantity, num);
						num -= num2;
						this.ItemSlots[i].ChangeQuantity(num2, network);
					}
					if (num <= 0)
					{
						return;
					}
				}
			}
			for (int j = 0; j < this.ItemSlots.Count; j++)
			{
				if (!this.ItemSlots[j].IsLocked && !this.ItemSlots[j].IsAddLocked)
				{
					if (this.ItemSlots[j].ItemInstance == null)
					{
						num -= item.StackLimit;
						this.ItemSlots[j].SetStoredItem(item, !network);
						return;
					}
					if (num <= 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x000661F4 File Offset: 0x000643F4
		public ItemInstance GetFirstItem(string id, NPCInventory.ItemFilter filter = null)
		{
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].ItemInstance != null && this.ItemSlots[i].ItemInstance.ID == id && (filter == null || filter(this.ItemSlots[i].ItemInstance)))
				{
					return this.ItemSlots[i].ItemInstance;
				}
			}
			return null;
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00066278 File Offset: 0x00064478
		public ItemInstance GetFirstIdenticalItem(ItemInstance item, NPCInventory.ItemFilter filter = null)
		{
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].ItemInstance != null && this.ItemSlots[i].ItemInstance.CanStackWith(item, false) && (filter == null || filter(this.ItemSlots[i].ItemInstance)))
				{
					return this.ItemSlots[i].ItemInstance;
				}
			}
			return null;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x000662F7 File Offset: 0x000644F7
		protected virtual void InventoryContentsChanged()
		{
			if (this.onContentsChanged != null)
			{
				this.onContentsChanged.Invoke();
			}
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0006630C File Offset: 0x0006450C
		public int GetTotalItemCount()
		{
			int num = 0;
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].ItemInstance != null)
				{
					num += this.ItemSlots[i].ItemInstance.Quantity;
				}
			}
			return num;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0006635E File Offset: 0x0006455E
		public void Hovered()
		{
			if (this.CanPickpocket())
			{
				this.PickpocketIntObj.SetMessage("Pickpocket");
				this.PickpocketIntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.PickpocketIntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00066391 File Offset: 0x00064591
		public void Interacted()
		{
			if (this.CanPickpocket())
			{
				this.StartPickpocket();
			}
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000663A1 File Offset: 0x000645A1
		private void StartPickpocket()
		{
			Singleton<PickpocketScreen>.Instance.Open(this.npc);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000663B3 File Offset: 0x000645B3
		public void ExpirePickpocket()
		{
			this.timeOnLastExpire = Time.time;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x000663C0 File Offset: 0x000645C0
		private bool CanPickpocket()
		{
			return this.CanBePickpocketed && PlayerSingleton<PlayerMovement>.Instance.isCrouched && Player.Local.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None && Time.time - this.timeOnLastExpire >= 30f && this.npc.IsConscious && !this.npc.behaviour.CallPoliceBehaviour.Active && !this.npc.behaviour.CombatBehaviour.Active && !this.npc.behaviour.FacePlayerBehaviour.Active && !this.npc.behaviour.FleeBehaviour.Active && !this.npc.behaviour.GenericDialogueBehaviour.Active && !this.npc.behaviour.StationaryBehaviour.Active && !this.npc.behaviour.RequestProductBehaviour.Active && !GameManager.IS_TUTORIAL;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000664D8 File Offset: 0x000646D8
		[Button]
		public void PrintInventoryContents()
		{
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].Quantity != 0)
				{
					Console.Log(string.Concat(new string[]
					{
						"Slot ",
						i.ToString(),
						": ",
						this.ItemSlots[i].ItemInstance.Name,
						" x",
						this.ItemSlots[i].Quantity.ToString()
					}), null);
				}
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00066579 File Offset: 0x00064779
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			this.RpcWriter___Server_SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
			this.RpcLogic___SetStoredInstance_2652194801(conn, itemSlotIndex, instance);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x000665A0 File Offset: 0x000647A0
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

		// Token: 0x06001736 RID: 5942 RVA: 0x000665FF File Offset: 0x000647FF
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Server_SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0006661D File Offset: 0x0006481D
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			this.RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
			this.RpcLogic___SetItemSlotQuantity_Internal_1692629761(itemSlotIndex, quantity);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0006663B File Offset: 0x0006483B
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			this.RpcWriter___Server_SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
			this.RpcLogic___SetSlotLocked_3170825843(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00066674 File Offset: 0x00064874
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

		// Token: 0x0600173B RID: 5947 RVA: 0x00066758 File Offset: 0x00064958
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SetStoredInstance_2652194801));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetStoredInstance_Internal_2652194801));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_SetStoredInstance_Internal_2652194801));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_SetItemSlotQuantity_1692629761));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761));
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_SetSlotLocked_3170825843));
			base.RegisterTargetRpc(6U, new ClientRpcDelegate(this.RpcReader___Target_SetSlotLocked_Internal_3170825843));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_SetSlotLocked_Internal_3170825843));
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0006682E File Offset: 0x00064A2E
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00066841 File Offset: 0x00064A41
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00066850 File Offset: 0x00064A50
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

		// Token: 0x0600173F RID: 5951 RVA: 0x00066916 File Offset: 0x00064B16
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetStoredInstance_Internal(null, itemSlotIndex, instance);
				return;
			}
			this.SetStoredInstance_Internal(conn, itemSlotIndex, instance);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00066940 File Offset: 0x00064B40
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

		// Token: 0x06001741 RID: 5953 RVA: 0x000669A8 File Offset: 0x00064BA8
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

		// Token: 0x06001742 RID: 5954 RVA: 0x00066A70 File Offset: 0x00064C70
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			if (instance != null)
			{
				this.ItemSlots[itemSlotIndex].SetStoredItem(instance, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].ClearStoredInstance(true);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00066A9C File Offset: 0x00064C9C
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

		// Token: 0x06001744 RID: 5956 RVA: 0x00066AF0 File Offset: 0x00064CF0
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

		// Token: 0x06001745 RID: 5957 RVA: 0x00066BB8 File Offset: 0x00064DB8
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

		// Token: 0x06001746 RID: 5958 RVA: 0x00066C10 File Offset: 0x00064E10
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

		// Token: 0x06001747 RID: 5959 RVA: 0x00066CCE File Offset: 0x00064ECE
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			this.SetItemSlotQuantity_Internal(itemSlotIndex, quantity);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00066CD8 File Offset: 0x00064ED8
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

		// Token: 0x06001749 RID: 5961 RVA: 0x00066D34 File Offset: 0x00064F34
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

		// Token: 0x0600174A RID: 5962 RVA: 0x00066E01 File Offset: 0x00065001
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			this.ItemSlots[itemSlotIndex].SetQuantity(quantity, true);
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00066E18 File Offset: 0x00065018
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

		// Token: 0x0600174C RID: 5964 RVA: 0x00066E70 File Offset: 0x00065070
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

		// Token: 0x0600174D RID: 5965 RVA: 0x00066F50 File Offset: 0x00065150
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (conn == null || conn.ClientId == -1)
			{
				this.SetSlotLocked_Internal(null, itemSlotIndex, locked, lockOwner, lockReason);
				return;
			}
			this.SetSlotLocked_Internal(conn, itemSlotIndex, locked, lockOwner, lockReason);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00066F80 File Offset: 0x00065180
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

		// Token: 0x0600174F RID: 5967 RVA: 0x00067008 File Offset: 0x00065208
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

		// Token: 0x06001750 RID: 5968 RVA: 0x000670E9 File Offset: 0x000652E9
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			if (locked)
			{
				this.ItemSlots[itemSlotIndex].ApplyLock(lockOwner, lockReason, true);
				return;
			}
			this.ItemSlots[itemSlotIndex].RemoveLock(true);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00067118 File Offset: 0x00065318
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

		// Token: 0x06001752 RID: 5970 RVA: 0x00067194 File Offset: 0x00065394
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

		// Token: 0x06001753 RID: 5971 RVA: 0x00067278 File Offset: 0x00065478
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

		// Token: 0x06001754 RID: 5972 RVA: 0x000672EC File Offset: 0x000654EC
		protected virtual void dll()
		{
			for (int i = 0; i < this.SlotCount; i++)
			{
				ItemSlot itemSlot = new ItemSlot();
				itemSlot.SetSlotOwner(this);
				itemSlot.onItemDataChanged = (Action)Delegate.Combine(itemSlot.onItemDataChanged, new Action(this.InventoryContentsChanged));
			}
			if (Application.isEditor)
			{
				ItemDefinition[] testItems = this.TestItems;
				for (int j = 0; j < testItems.Length; j++)
				{
					ItemInstance defaultInstance = testItems[j].GetDefaultInstance(1);
					this.InsertItem(defaultInstance, true);
				}
			}
			this.npc = base.GetComponent<NPC>();
			this.PickpocketIntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.PickpocketIntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x04001501 RID: 5377
		public InteractableObject PickpocketIntObj;

		// Token: 0x04001502 RID: 5378
		public const float COOLDOWN = 30f;

		// Token: 0x04001503 RID: 5379
		[Header("Settings")]
		public int SlotCount = 5;

		// Token: 0x04001504 RID: 5380
		public bool CanBePickpocketed = true;

		// Token: 0x04001505 RID: 5381
		public bool ClearInventoryEachNight = true;

		// Token: 0x04001506 RID: 5382
		public ItemDefinition[] TestItems;

		// Token: 0x04001507 RID: 5383
		[Header("Random cash")]
		public bool RandomCash = true;

		// Token: 0x04001508 RID: 5384
		public int RandomCashMin;

		// Token: 0x04001509 RID: 5385
		public int RandomCashMax = 100;

		// Token: 0x0400150A RID: 5386
		[Header("Random items")]
		public bool RandomItems = true;

		// Token: 0x0400150B RID: 5387
		public StorableItemDefinition[] RandomItemDefinitions;

		// Token: 0x0400150C RID: 5388
		public int RandomItemMin = -1;

		// Token: 0x0400150D RID: 5389
		public int RandomItemMax = 2;

		// Token: 0x0400150E RID: 5390
		private NPC npc;

		// Token: 0x04001510 RID: 5392
		public UnityEvent onContentsChanged;

		// Token: 0x04001511 RID: 5393
		private float timeOnLastExpire = -100f;

		// Token: 0x04001512 RID: 5394
		private bool dll_Excuted;

		// Token: 0x04001513 RID: 5395
		private bool dll_Excuted;

		// Token: 0x0200045C RID: 1116
		// (Invoke) Token: 0x06001756 RID: 5974
		public delegate bool ItemFilter(ItemInstance item);
	}
}
