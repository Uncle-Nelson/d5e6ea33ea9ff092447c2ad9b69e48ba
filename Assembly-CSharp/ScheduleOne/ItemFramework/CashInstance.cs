using System;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000933 RID: 2355
	[Serializable]
	public class CashInstance : StorableItemInstance
	{
		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x0010E035 File Offset: 0x0010C235
		// (set) Token: 0x06004005 RID: 16389 RVA: 0x0010E03D File Offset: 0x0010C23D
		public float Balance { get; protected set; }

		// Token: 0x06004006 RID: 16390 RVA: 0x000D1AAE File Offset: 0x000CFCAE
		public CashInstance()
		{
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x0010E046 File Offset: 0x0010C246
		public CashInstance(ItemDefinition definition, int quantity) : base(definition, quantity)
		{
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x0010E050 File Offset: 0x0010C250
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new CashInstance(base.Definition, quantity);
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x0010E076 File Offset: 0x0010C276
		public void ChangeBalance(float amount)
		{
			this.SetBalance(this.Balance + amount, false);
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x0010E088 File Offset: 0x0010C288
		public void SetBalance(float newBalance, bool blockClear = false)
		{
			this.Balance = Mathf.Clamp(newBalance, 0f, 1E+09f);
			if (this.Balance <= 0f && !blockClear)
			{
				base.RequestClearSlot();
			}
			if (this.onDataChanged != null)
			{
				this.onDataChanged();
			}
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x0010E0D4 File Offset: 0x0010C2D4
		public override ItemData GetItemData()
		{
			return new CashData(this.ID, this.Quantity, this.Balance);
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x0010E0ED File Offset: 0x0010C2ED
		public override float GetMonetaryValue()
		{
			return this.Balance;
		}

		// Token: 0x04002DF3 RID: 11763
		public const float MAX_BALANCE = 1E+09f;
	}
}
