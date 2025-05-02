using System;
using System.Collections.Generic;
using System.Linq;
using FishNet.Object;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x0200057E RID: 1406
	public interface ITransitEntity
	{
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06002304 RID: 8964
		string Name { get; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002305 RID: 8965
		// (set) Token: 0x06002306 RID: 8966
		List<ItemSlot> InputSlots { get; set; }

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06002307 RID: 8967
		// (set) Token: 0x06002308 RID: 8968
		List<ItemSlot> OutputSlots { get; set; }

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002309 RID: 8969
		Transform LinkOrigin { get; }

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600230A RID: 8970
		Transform[] AccessPoints { get; }

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600230B RID: 8971
		bool Selectable { get; }

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600230C RID: 8972
		bool IsAcceptingItems { get; }

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600230D RID: 8973
		bool IsDestroyed { get; }

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600230E RID: 8974
		Guid GUID { get; }

		// Token: 0x0600230F RID: 8975
		void ShowOutline(Color color);

		// Token: 0x06002310 RID: 8976
		void HideOutline();

		// Token: 0x06002311 RID: 8977 RVA: 0x0008F9D4 File Offset: 0x0008DBD4
		void InsertItemIntoInput(ItemInstance item, NPC inserter = null)
		{
			if (this.GetInputCapacityForItem(item, inserter) < item.Quantity)
			{
				Console.LogWarning("ITransitEntity InsertItem() called but item won't fit!", null);
				return;
			}
			int num = item.Quantity;
			for (int i = 0; i < this.InputSlots.Count; i++)
			{
				if (!this.InputSlots[i].IsLocked && !this.InputSlots[i].IsAddLocked)
				{
					int capacityForItem = this.InputSlots[i].GetCapacityForItem(item);
					if (capacityForItem > 0)
					{
						int num2 = Mathf.Min(capacityForItem, num);
						if (this.InputSlots[i].ItemInstance == null)
						{
							this.InputSlots[i].SetStoredItem(item, false);
						}
						else
						{
							this.InputSlots[i].ChangeQuantity(num2, false);
						}
						num -= num2;
					}
					if (num <= 0)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x0008FAA8 File Offset: 0x0008DCA8
		void InsertItemIntoOutput(ItemInstance item, NPC inserter = null)
		{
			if (this.GetOutputCapacityForItem(item, inserter) < item.Quantity)
			{
				Console.LogWarning("ITransitEntity InsertItem() called but item won't fit!", null);
				return;
			}
			int num = item.Quantity;
			for (int i = 0; i < this.OutputSlots.Count; i++)
			{
				if (!this.OutputSlots[i].IsLocked && !this.OutputSlots[i].IsAddLocked)
				{
					int capacityForItem = this.OutputSlots[i].GetCapacityForItem(item);
					if (capacityForItem > 0)
					{
						int num2 = Mathf.Min(capacityForItem, num);
						if (this.OutputSlots[i].ItemInstance == null)
						{
							this.OutputSlots[i].SetStoredItem(item, false);
						}
						else
						{
							this.OutputSlots[i].ChangeQuantity(num2, false);
						}
						num -= num2;
					}
					if (num <= 0)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x0008FB7C File Offset: 0x0008DD7C
		int GetInputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			int num = 0;
			NetworkObject networkObject = (asker != null) ? asker.NetworkObject : null;
			int i = 0;
			while (i < this.InputSlots.Count)
			{
				if (!this.InputSlots[i].IsLocked && !this.InputSlots[i].IsAddLocked)
				{
					goto IL_83;
				}
				bool flag = false;
				if (networkObject != null && this.InputSlots[i].ActiveLock != null && this.InputSlots[i].ActiveLock.LockOwner == networkObject)
				{
					flag = true;
				}
				if (flag)
				{
					goto IL_83;
				}
				IL_98:
				i++;
				continue;
				IL_83:
				num += this.InputSlots[i].GetCapacityForItem(item);
				goto IL_98;
			}
			return num;
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x0008FC38 File Offset: 0x0008DE38
		int GetOutputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			int num = 0;
			NetworkObject networkObject = (asker != null) ? asker.NetworkObject : null;
			int i = 0;
			while (i < this.OutputSlots.Count)
			{
				if (!this.OutputSlots[i].IsLocked && !this.OutputSlots[i].IsAddLocked)
				{
					goto IL_83;
				}
				bool flag = false;
				if (networkObject != null && this.OutputSlots[i].ActiveLock != null && this.OutputSlots[i].ActiveLock.LockOwner == networkObject)
				{
					flag = true;
				}
				if (flag)
				{
					goto IL_83;
				}
				IL_98:
				i++;
				continue;
				IL_83:
				num += this.OutputSlots[i].GetCapacityForItem(item);
				goto IL_98;
			}
			return num;
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x0008FCF4 File Offset: 0x0008DEF4
		ItemSlot GetOutputItemContainer(ItemInstance item)
		{
			return this.OutputSlots.FirstOrDefault((ItemSlot x) => x.ItemInstance == item);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x0008FD28 File Offset: 0x0008DF28
		List<ItemSlot> ReserveInputSlotsForItem(ItemInstance item, NetworkObject locker)
		{
			List<ItemSlot> list = new List<ItemSlot>();
			int num = item.Quantity;
			for (int i = 0; i < this.InputSlots.Count; i++)
			{
				int capacityForItem = this.InputSlots[i].GetCapacityForItem(item);
				if (capacityForItem != 0)
				{
					int num2 = Mathf.Min(capacityForItem, num);
					num -= num2;
					this.InputSlots[i].ApplyLock(locker, "Employee is about to place an item here", false);
					list.Add(this.InputSlots[i]);
					if (num <= 0)
					{
						break;
					}
				}
			}
			return list;
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x0008FDAC File Offset: 0x0008DFAC
		void RemoveSlotLocks(NetworkObject locker)
		{
			for (int i = 0; i < this.InputSlots.Count; i++)
			{
				if (this.InputSlots[i].ActiveLock != null && this.InputSlots[i].ActiveLock.LockOwner == locker)
				{
					this.InputSlots[i].RemoveLock(false);
				}
			}
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0008FE14 File Offset: 0x0008E014
		ItemSlot GetFirstSlotContainingItem(string id, ITransitEntity.ESlotType searchType)
		{
			if (searchType == ITransitEntity.ESlotType.Output || searchType == ITransitEntity.ESlotType.Both)
			{
				for (int i = 0; i < this.OutputSlots.Count; i++)
				{
					if (this.OutputSlots[i].ItemInstance != null && this.OutputSlots[i].ItemInstance.ID == id)
					{
						return this.OutputSlots[i];
					}
				}
			}
			if (searchType == ITransitEntity.ESlotType.Input || searchType == ITransitEntity.ESlotType.Both)
			{
				for (int j = 0; j < this.InputSlots.Count; j++)
				{
					if (this.InputSlots[j].ItemInstance != null && this.InputSlots[j].ItemInstance.ID == id)
					{
						return this.InputSlots[j];
					}
				}
			}
			return null;
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0008FEDC File Offset: 0x0008E0DC
		ItemSlot GetFirstSlotContainingTemplateItem(ItemInstance templateItem, ITransitEntity.ESlotType searchType)
		{
			if (searchType == ITransitEntity.ESlotType.Output || searchType == ITransitEntity.ESlotType.Both)
			{
				for (int i = 0; i < this.OutputSlots.Count; i++)
				{
					if (this.OutputSlots[i].ItemInstance != null && this.OutputSlots[i].ItemInstance.CanStackWith(templateItem, false))
					{
						return this.OutputSlots[i];
					}
				}
			}
			if (searchType == ITransitEntity.ESlotType.Input || searchType == ITransitEntity.ESlotType.Both)
			{
				for (int j = 0; j < this.InputSlots.Count; j++)
				{
					if (this.InputSlots[j].ItemInstance != null && this.InputSlots[j].ItemInstance.CanStackWith(templateItem, false))
					{
						return this.InputSlots[j];
					}
				}
			}
			return null;
		}

		// Token: 0x0200057F RID: 1407
		public enum ESlotType
		{
			// Token: 0x04001A48 RID: 6728
			Input,
			// Token: 0x04001A49 RID: 6729
			Output,
			// Token: 0x04001A4A RID: 6730
			Both
		}
	}
}
