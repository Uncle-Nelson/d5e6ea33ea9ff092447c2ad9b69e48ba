using System;
using System.Collections.Generic;
using System.Linq;
using FishNet.Connection;
using FishNet.Object;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000946 RID: 2374
	public interface IItemSlotOwner
	{
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06004031 RID: 16433
		// (set) Token: 0x06004032 RID: 16434
		List<ItemSlot> ItemSlots { get; set; }

		// Token: 0x06004033 RID: 16435
		void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance);

		// Token: 0x06004034 RID: 16436
		void SetItemSlotQuantity(int itemSlotIndex, int quantity);

		// Token: 0x06004035 RID: 16437
		void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason);

		// Token: 0x06004036 RID: 16438 RVA: 0x0010E464 File Offset: 0x0010C664
		void SendItemsToClient(NetworkConnection conn)
		{
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].IsLocked)
				{
					this.SetSlotLocked(conn, i, true, this.ItemSlots[i].ActiveLock.LockOwner, this.ItemSlots[i].ActiveLock.LockReason);
				}
				if (this.ItemSlots[i].ItemInstance != null)
				{
					this.SetStoredInstance(conn, i, this.ItemSlots[i].ItemInstance);
				}
			}
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x0010E4FE File Offset: 0x0010C6FE
		int GetTotalItemCount()
		{
			return this.ItemSlots.Sum((ItemSlot x) => x.Quantity);
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x0010E52C File Offset: 0x0010C72C
		int GetItemCount(string id)
		{
			int num = 0;
			for (int i = 0; i < this.ItemSlots.Count; i++)
			{
				if (this.ItemSlots[i].ItemInstance != null && this.ItemSlots[i].ItemInstance.ID == id)
				{
					num += this.ItemSlots[i].Quantity;
				}
			}
			return num;
		}
	}
}
