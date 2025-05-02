using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000C05 RID: 3077
	public class StoredItem_Cash : StoredItem
	{
		// Token: 0x06005690 RID: 22160 RVA: 0x0016C0E8 File Offset: 0x0016A2E8
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			base.InitializeStoredItem(_item, grid, _originCoordinate, _rotation);
			this.cashInstance = (base.item as CashInstance);
			this.RefreshShownBills();
			CashInstance cashInstance = this.cashInstance;
			cashInstance.onDataChanged = (Action)Delegate.Combine(cashInstance.onDataChanged, new Action(this.RefreshShownBills));
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x0016C13E File Offset: 0x0016A33E
		private void RefreshShownBills()
		{
			this.Visuals.ShowAmount(this.cashInstance.Balance);
		}

		// Token: 0x04003FF0 RID: 16368
		protected CashInstance cashInstance;

		// Token: 0x04003FF1 RID: 16369
		[Header("References")]
		public CashStackVisuals Visuals;
	}
}
