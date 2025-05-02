using System;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000949 RID: 2377
	public class IntegerItemInstance : StorableItemInstance
	{
		// Token: 0x0600403E RID: 16446 RVA: 0x000D1AAE File Offset: 0x000CFCAE
		public IntegerItemInstance()
		{
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x0010E5BA File Offset: 0x0010C7BA
		public IntegerItemInstance(ItemDefinition definition, int quantity, int value) : base(definition, quantity)
		{
			this.Value = value;
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0010E5CC File Offset: 0x0010C7CC
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			return new IntegerItemInstance(base.Definition, quantity, this.Value);
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x0010E5F8 File Offset: 0x0010C7F8
		public void ChangeValue(int change)
		{
			this.Value += change;
			if (this.onDataChanged != null)
			{
				this.onDataChanged();
			}
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x0010E61B File Offset: 0x0010C81B
		public void SetValue(int value)
		{
			this.Value = value;
			if (this.onDataChanged != null)
			{
				this.onDataChanged();
			}
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x0010E637 File Offset: 0x0010C837
		public override ItemData GetItemData()
		{
			return new IntegerItemData(this.ID, this.Quantity, this.Value);
		}

		// Token: 0x04002E1D RID: 11805
		public int Value;
	}
}
