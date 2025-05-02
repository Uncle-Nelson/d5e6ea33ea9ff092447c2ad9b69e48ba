using System;

namespace ScheduleOne.Money
{
	// Token: 0x02000B91 RID: 2961
	public class Transaction
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x0014D6B0 File Offset: 0x0014B8B0
		public float total_Amount
		{
			get
			{
				return this.unit_Amount * this.quantity;
			}
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x0014D6C0 File Offset: 0x0014B8C0
		public Transaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			this.transaction_Name = _transaction_Name;
			this.unit_Amount = _unit_Amount;
			this.quantity = _quantity;
			this.transaction_Note = _transaction_Note;
		}

		// Token: 0x04003B9D RID: 15261
		public string transaction_Name = string.Empty;

		// Token: 0x04003B9E RID: 15262
		public float unit_Amount;

		// Token: 0x04003B9F RID: 15263
		public float quantity = 1f;

		// Token: 0x04003BA0 RID: 15264
		public string transaction_Note = string.Empty;
	}
}
