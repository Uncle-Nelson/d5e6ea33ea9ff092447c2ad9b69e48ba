using System;
using System.Collections.Generic;
using FishNet.Object;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000955 RID: 2389
	[Serializable]
	public class ItemSlot
	{
		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x0010F90B File Offset: 0x0010DB0B
		// (set) Token: 0x060040A0 RID: 16544 RVA: 0x0010F913 File Offset: 0x0010DB13
		public ItemInstance ItemInstance { get; protected set; }

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060040A1 RID: 16545 RVA: 0x0010F91C File Offset: 0x0010DB1C
		// (set) Token: 0x060040A2 RID: 16546 RVA: 0x0010F924 File Offset: 0x0010DB24
		public IItemSlotOwner SlotOwner { get; protected set; }

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x0010F92D File Offset: 0x0010DB2D
		private int SlotIndex
		{
			get
			{
				return this.SlotOwner.ItemSlots.IndexOf(this);
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x0010F940 File Offset: 0x0010DB40
		public int Quantity
		{
			get
			{
				if (this.ItemInstance == null)
				{
					return 0;
				}
				return this.ItemInstance.Quantity;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060040A5 RID: 16549 RVA: 0x0010F957 File Offset: 0x0010DB57
		public bool IsAtCapacity
		{
			get
			{
				return this.ItemInstance != null && this.Quantity >= this.ItemInstance.StackLimit;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060040A6 RID: 16550 RVA: 0x0010F979 File Offset: 0x0010DB79
		public bool IsLocked
		{
			get
			{
				return this.ActiveLock != null;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060040A7 RID: 16551 RVA: 0x0010F984 File Offset: 0x0010DB84
		// (set) Token: 0x060040A8 RID: 16552 RVA: 0x0010F98C File Offset: 0x0010DB8C
		public ItemSlotLock ActiveLock { get; protected set; }

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x0010F995 File Offset: 0x0010DB95
		// (set) Token: 0x060040AA RID: 16554 RVA: 0x0010F99D File Offset: 0x0010DB9D
		public bool IsRemovalLocked { get; protected set; }

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060040AB RID: 16555 RVA: 0x0010F9A6 File Offset: 0x0010DBA6
		// (set) Token: 0x060040AC RID: 16556 RVA: 0x0010F9AE File Offset: 0x0010DBAE
		public bool IsAddLocked { get; protected set; }

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060040AD RID: 16557 RVA: 0x0010F9B7 File Offset: 0x0010DBB7
		// (set) Token: 0x060040AE RID: 16558 RVA: 0x0010F9BF File Offset: 0x0010DBBF
		protected List<ItemFilter> Filters { get; set; } = new List<ItemFilter>();

		// Token: 0x060040AF RID: 16559 RVA: 0x0010F9C8 File Offset: 0x0010DBC8
		public void SetSlotOwner(IItemSlotOwner owner)
		{
			this.SlotOwner = owner;
			this.SlotOwner.ItemSlots.Add(this);
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x0010F9E2 File Offset: 0x0010DBE2
		public void ReplicateStoredInstance()
		{
			if (this.SlotOwner == null)
			{
				return;
			}
			this.SlotOwner.SetStoredInstance(null, this.SlotIndex, this.ItemInstance);
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x0010FA08 File Offset: 0x0010DC08
		public virtual void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			if (this.IsLocked)
			{
				Console.LogError("SetStoredInstance called on ItemSlot that is locked! Refusing.", null);
				return;
			}
			if (this.IsRemovalLocked)
			{
				Console.LogWarning("SetStoredItem called on ItemSlot that isRemovalLocked. You probably shouldn't do this.", null);
			}
			if (_internal || this.SlotOwner == null)
			{
				if (this.ItemInstance != null)
				{
					this.ClearStoredInstance(true);
				}
				this.ItemInstance = instance;
				if (this.ItemInstance != null)
				{
					ItemInstance itemInstance = this.ItemInstance;
					itemInstance.onDataChanged = (Action)Delegate.Combine(itemInstance.onDataChanged, new Action(this.ItemDataChanged));
					ItemInstance itemInstance2 = this.ItemInstance;
					itemInstance2.requestClearSlot = (Action)Delegate.Combine(itemInstance2.requestClearSlot, new Action(this.ClearItemInstanceRequested));
				}
				if (this.onItemDataChanged != null)
				{
					this.onItemDataChanged();
				}
				if (this.onItemInstanceChanged != null)
				{
					this.onItemInstanceChanged();
				}
				this.ItemDataChanged();
				return;
			}
			this.SlotOwner.SetStoredInstance(null, this.SlotIndex, instance);
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x0010FAF8 File Offset: 0x0010DCF8
		public virtual void InsertItem(ItemInstance item)
		{
			if (this.ItemInstance == null)
			{
				this.AddItem(item, false);
				return;
			}
			if (this.ItemInstance.CanStackWith(item, true))
			{
				this.ChangeQuantity(item.Quantity, false);
				return;
			}
			Console.LogWarning("InsertItem called with item that cannot stack with current item. Refusing.", null);
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x0010FB33 File Offset: 0x0010DD33
		public virtual void AddItem(ItemInstance item, bool _internal = false)
		{
			if (this.ItemInstance == null)
			{
				this.SetStoredItem(item, _internal);
				return;
			}
			if (!this.ItemInstance.CanStackWith(item, true))
			{
				Console.LogWarning("AddItem called with item that cannot stack with current item. Refusing.", null);
				return;
			}
			this.ChangeQuantity(item.Quantity, _internal);
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x0010FB70 File Offset: 0x0010DD70
		public virtual void ClearStoredInstance(bool _internal = false)
		{
			if (this.IsLocked)
			{
				Console.LogError("ClearStoredInstance called on ItemSlot that is locked! Refusing.", null);
				return;
			}
			if (this.IsRemovalLocked)
			{
				Console.LogError("ClearStoredInstance called on ItemSlot that is removal locked! Refusing.", null);
				return;
			}
			if (this.ItemInstance == null)
			{
				return;
			}
			if (_internal || this.SlotOwner == null)
			{
				ItemInstance itemInstance = this.ItemInstance;
				itemInstance.onDataChanged = (Action)Delegate.Remove(itemInstance.onDataChanged, new Action(this.ItemDataChanged));
				ItemInstance itemInstance2 = this.ItemInstance;
				itemInstance2.requestClearSlot = (Action)Delegate.Remove(itemInstance2.requestClearSlot, new Action(this.ClearItemInstanceRequested));
				this.ItemInstance = null;
				if (this.onItemDataChanged != null)
				{
					this.onItemDataChanged();
				}
				if (this.onItemInstanceChanged != null)
				{
					this.onItemInstanceChanged();
					return;
				}
			}
			else
			{
				this.SlotOwner.SetStoredInstance(null, this.SlotIndex, null);
			}
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x0010FC4C File Offset: 0x0010DE4C
		public void SetQuantity(int amount, bool _internal = false)
		{
			if (this.IsLocked)
			{
				Console.LogError("SetQuantity called on ItemSlot that is locked! Refusing.", null);
				return;
			}
			if (this.ItemInstance == null)
			{
				Console.LogWarning("ChangeQuantity called but ItemInstance is null", null);
				return;
			}
			if (amount < this.ItemInstance.Quantity && this.IsRemovalLocked)
			{
				Console.LogError("SetQuantity called on ItemSlot and passed lower quantity that current, and isRemovalLocked = true. Refusing.", null);
				return;
			}
			if (_internal || this.SlotOwner == null)
			{
				this.ItemInstance.SetQuantity(amount);
				return;
			}
			this.SlotOwner.SetItemSlotQuantity(this.SlotIndex, amount);
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x0010FCD0 File Offset: 0x0010DED0
		public void ChangeQuantity(int change, bool _internal = false)
		{
			if (this.IsLocked)
			{
				Console.LogWarning("isLocked = true!", null);
				return;
			}
			if (this.ItemInstance == null)
			{
				Console.LogWarning("ChangeQuantity called but ItemInstance is null", null);
				return;
			}
			if (this.IsRemovalLocked && change < 0)
			{
				Console.Log("Removal locked!", null);
				return;
			}
			if (_internal || this.SlotOwner == null)
			{
				this.ItemInstance.ChangeQuantity(change);
				return;
			}
			this.SlotOwner.SetItemSlotQuantity(this.SlotIndex, this.Quantity + change);
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x0010FD4E File Offset: 0x0010DF4E
		protected virtual void ItemDataChanged()
		{
			if (this.ItemInstance != null && this.ItemInstance.Quantity <= 0)
			{
				this.ClearStoredInstance(false);
				return;
			}
			if (this.onItemDataChanged != null)
			{
				this.onItemDataChanged();
			}
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x0010FD81 File Offset: 0x0010DF81
		protected virtual void ClearItemInstanceRequested()
		{
			this.ClearStoredInstance(false);
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x0010FD8A File Offset: 0x0010DF8A
		public void AddFilter(ItemFilter filter)
		{
			this.Filters.Add(filter);
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x0010FD98 File Offset: 0x0010DF98
		public void ApplyLock(NetworkObject lockOwner, string lockReason, bool _internal = false)
		{
			if (_internal || this.SlotOwner == null)
			{
				this.ActiveLock = new ItemSlotLock(this, lockOwner, lockReason);
				if (this.onLocked != null)
				{
					this.onLocked();
					return;
				}
			}
			else
			{
				this.SlotOwner.SetSlotLocked(null, this.SlotIndex, true, lockOwner, lockReason);
			}
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x0010FDE8 File Offset: 0x0010DFE8
		public void RemoveLock(bool _internal = false)
		{
			if (_internal || this.SlotOwner == null)
			{
				this.ActiveLock = null;
				if (this.onUnlocked != null)
				{
					this.onUnlocked();
					return;
				}
			}
			else
			{
				this.SlotOwner.SetSlotLocked(null, this.SlotIndex, false, null, string.Empty);
			}
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x0010FE34 File Offset: 0x0010E034
		public void SetIsRemovalLocked(bool locked)
		{
			this.IsRemovalLocked = locked;
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x0010FE3D File Offset: 0x0010E03D
		public void SetIsAddLocked(bool locked)
		{
			this.IsAddLocked = locked;
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x0010FE48 File Offset: 0x0010E048
		public virtual bool DoesItemMatchFilters(ItemInstance item)
		{
			using (List<ItemFilter>.Enumerator enumerator = this.Filters.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.DoesItemMatchFilter(item))
					{
						return false;
					}
				}
			}
			return !(item is CashInstance) || this.CanSlotAcceptCash();
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x0010FEB4 File Offset: 0x0010E0B4
		public virtual int GetCapacityForItem(ItemInstance item)
		{
			if (!this.DoesItemMatchFilters(item))
			{
				return 0;
			}
			if (this.ItemInstance == null || this.ItemInstance.CanStackWith(item, false))
			{
				return item.StackLimit - this.Quantity;
			}
			return 0;
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x000022C9 File Offset: 0x000004C9
		public virtual bool CanSlotAcceptCash()
		{
			return true;
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x0010FEE8 File Offset: 0x0010E0E8
		public static bool TryInsertItemIntoSet(List<ItemSlot> ItemSlots, ItemInstance item)
		{
			int num = item.Quantity;
			int num2 = 0;
			while (num2 < ItemSlots.Count && num > 0)
			{
				if (!ItemSlots[num2].IsLocked && !ItemSlots[num2].IsAddLocked && ItemSlots[num2].ItemInstance != null && ItemSlots[num2].ItemInstance.CanStackWith(item, true))
				{
					int num3 = Mathf.Min(item.StackLimit - ItemSlots[num2].ItemInstance.Quantity, num);
					num -= num3;
					ItemSlots[num2].ChangeQuantity(num3, false);
				}
				num2++;
			}
			int num4 = 0;
			while (num4 < ItemSlots.Count && num > 0)
			{
				if (!ItemSlots[num4].IsLocked && !ItemSlots[num4].IsAddLocked && ItemSlots[num4].ItemInstance == null)
				{
					num -= item.StackLimit;
					ItemSlots[num4].SetStoredItem(item, false);
					break;
				}
				num4++;
			}
			return num <= 0;
		}

		// Token: 0x04002E5B RID: 11867
		public Action onItemDataChanged;

		// Token: 0x04002E5C RID: 11868
		public Action onItemInstanceChanged;

		// Token: 0x04002E5E RID: 11870
		public Action onLocked;

		// Token: 0x04002E5F RID: 11871
		public Action onUnlocked;
	}
}
