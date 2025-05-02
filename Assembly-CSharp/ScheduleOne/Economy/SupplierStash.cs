using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Money;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Storage;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x02000682 RID: 1666
	public class SupplierStash : MonoBehaviour
	{
		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x000C0CB7 File Offset: 0x000BEEB7
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x000C0CBF File Offset: 0x000BEEBF
		public float CashAmount { get; private set; }

		// Token: 0x06002E08 RID: 11784 RVA: 0x000C0CC8 File Offset: 0x000BEEC8
		protected virtual void Awake()
		{
			this.IntObj.SetMessage("View " + this.Supplier.fullName + "'s stash");
			this.IntObj.enabled = this.Supplier.RelationData.Unlocked;
			NPCRelationData relationData = this.Supplier.RelationData;
			relationData.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(delegate(NPCRelationData.EUnlockType type, bool b)
			{
				this.SupplierUnlocked();
			}));
			this.Storage.StorageEntityName = this.Supplier.fullName + "'s Stash";
			this.Interacted();
			this.RecalculateCash();
			this.Storage.onContentsChanged.AddListener(new UnityAction(this.RecalculateCash));
			this.StashPoI.enabled = this.Supplier.RelationData.Unlocked;
			this.StashPoI.SetMainText(this.Supplier.fullName + "'s Stash");
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x000C0DC4 File Offset: 0x000BEFC4
		protected virtual void Start()
		{
			this.UpdateDeadDrop();
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
			this.Storage.onContentsChanged.AddListener(new UnityAction(this.UpdateDeadDrop));
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000C0E04 File Offset: 0x000BF004
		private void SupplierUnlocked()
		{
			Console.Log("Supplier unlocked: " + this.Supplier.fullName, null);
			this.StashPoI.enabled = true;
			this.IntObj.enabled = true;
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000C0E3C File Offset: 0x000BF03C
		private void RecalculateCash()
		{
			float num = 0f;
			for (int i = 0; i < this.Storage.ItemSlots.Count; i++)
			{
				if (this.Storage.ItemSlots[i] != null && this.Storage.ItemSlots[i].ItemInstance != null && this.Storage.ItemSlots[i].ItemInstance is CashInstance)
				{
					num += (this.Storage.ItemSlots[i].ItemInstance as CashInstance).Balance;
				}
			}
			this.CashAmount = num;
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x000C0EE0 File Offset: 0x000BF0E0
		private void Interacted()
		{
			this.Storage.StorageEntitySubtitle = string.Concat(new string[]
			{
				"You owe ",
				this.Supplier.fullName,
				" <color=#54E717>",
				MoneyManager.FormatAmount(this.Supplier.Debt, false, false),
				"</color>. Insert cash and exit stash to pay off your debt"
			});
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000C0F40 File Offset: 0x000BF140
		public void RemoveCash(float amount)
		{
			float num = amount;
			int num2 = 0;
			while (num2 < this.Storage.SlotCount && num > 0f)
			{
				if (this.Storage.ItemSlots[num2].ItemInstance != null && this.Storage.ItemSlots[num2].ItemInstance is CashInstance)
				{
					CashInstance cashInstance = this.Storage.ItemSlots[num2].ItemInstance as CashInstance;
					float num3 = Mathf.Min(num, cashInstance.Balance);
					cashInstance.ChangeBalance(-num3);
					if (cashInstance.Balance > 0f)
					{
						this.Storage.ItemSlots[num2].SetStoredItem(cashInstance, false);
					}
					num -= num3;
				}
				num2++;
			}
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x000C1005 File Offset: 0x000BF205
		private void UpdateDeadDrop()
		{
			this.Light.Enabled = (this.Storage.ItemCount > 0);
		}

		// Token: 0x040020A7 RID: 8359
		public string locationDescription = "behind the X";

		// Token: 0x040020A8 RID: 8360
		[Header("References")]
		public Supplier Supplier;

		// Token: 0x040020A9 RID: 8361
		public StorageEntity Storage;

		// Token: 0x040020AA RID: 8362
		public InteractableObject IntObj;

		// Token: 0x040020AB RID: 8363
		public OptimizedLight Light;

		// Token: 0x040020AC RID: 8364
		public POI StashPoI;
	}
}
