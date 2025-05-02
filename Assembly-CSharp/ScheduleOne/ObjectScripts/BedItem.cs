using System;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.Storage;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BA1 RID: 2977
	public class BedItem : PlaceableStorageEntity
	{
		// Token: 0x06004FEE RID: 20462 RVA: 0x00150CC2 File Offset: 0x0014EEC2
		protected override void Start()
		{
			base.Start();
			this.Bed.onAssignedEmployeeChanged.AddListener(new UnityAction(this.UpdateBriefcase));
			this.UpdateBriefcase();
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x00150CEC File Offset: 0x0014EEEC
		public static bool IsBedValid(BuildableItem obj, out string reason)
		{
			reason = string.Empty;
			if (!(obj is BedItem))
			{
				return false;
			}
			BedItem bedItem = obj as BedItem;
			if (bedItem.Bed.AssignedEmployee != null)
			{
				reason = "Already assigned to " + bedItem.Bed.AssignedEmployee.fullName;
				return false;
			}
			return true;
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x00150D44 File Offset: 0x0014EF44
		private void UpdateBriefcase()
		{
			this.Briefcase.gameObject.SetActive(this.Bed.AssignedEmployee != null || this.Storage.ItemCount > 0);
			if (this.Bed.AssignedEmployee != null)
			{
				this.Storage.StorageEntityName = this.Bed.AssignedEmployee.FirstName + "'s Briefcase";
				string text = "<color=#54E717>" + MoneyManager.FormatAmount(this.Bed.AssignedEmployee.DailyWage, false, false) + "</color>";
				this.Storage.StorageEntitySubtitle = string.Concat(new string[]
				{
					this.Bed.AssignedEmployee.fullName,
					" will draw ",
					this.Bed.AssignedEmployee.IsMale ? "his" : "her",
					" daily wage of ",
					text,
					" from this briefcase."
				});
				return;
			}
			this.Storage.StorageEntityName = "Briefcase";
			this.Storage.StorageEntitySubtitle = string.Empty;
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x00150E70 File Offset: 0x0014F070
		public float GetCashSum()
		{
			float num = 0f;
			foreach (ItemSlot itemSlot in this.Storage.ItemSlots)
			{
				if (itemSlot.ItemInstance != null && itemSlot.ItemInstance is CashInstance)
				{
					num += (itemSlot.ItemInstance as CashInstance).Balance;
				}
			}
			return num;
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x00150EF0 File Offset: 0x0014F0F0
		public void RemoveCash(float amount)
		{
			foreach (ItemSlot itemSlot in this.Storage.ItemSlots)
			{
				if (amount <= 0f)
				{
					break;
				}
				if (itemSlot.ItemInstance != null && itemSlot.ItemInstance is CashInstance)
				{
					CashInstance cashInstance = itemSlot.ItemInstance as CashInstance;
					float num = Mathf.Min(amount, cashInstance.Balance);
					cashInstance.ChangeBalance(-num);
					itemSlot.ReplicateStoredInstance();
					amount -= num;
				}
			}
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x00150F94 File Offset: 0x0014F194
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x00150FAD File Offset: 0x0014F1AD
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x00150FC6 File Offset: 0x0014F1C6
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x00150FD4 File Offset: 0x0014F1D4
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003C45 RID: 15429
		public Bed Bed;

		// Token: 0x04003C46 RID: 15430
		public StorageEntity Storage;

		// Token: 0x04003C47 RID: 15431
		public GameObject Briefcase;

		// Token: 0x04003C48 RID: 15432
		private bool dll_Excuted;

		// Token: 0x04003C49 RID: 15433
		private bool dll_Excuted;
	}
}
