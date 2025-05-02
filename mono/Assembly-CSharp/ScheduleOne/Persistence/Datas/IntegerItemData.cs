using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003E5 RID: 997
	[Serializable]
	public class IntegerItemData : ItemData
	{
		// Token: 0x06001558 RID: 5464 RVA: 0x0005F898 File Offset: 0x0005DA98
		public IntegerItemData(string iD, int quantity, int value) : base(iD, quantity)
		{
			this.Value = value;
		}

		// Token: 0x0400139C RID: 5020
		public int Value;
	}
}
