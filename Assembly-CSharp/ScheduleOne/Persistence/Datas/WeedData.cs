using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003EE RID: 1006
	[Serializable]
	public class WeedData : ProductItemData
	{
		// Token: 0x06001561 RID: 5473 RVA: 0x0005F88B File Offset: 0x0005DA8B
		public WeedData(string iD, int quantity, string quality, string packagingID) : base(iD, quantity, quality, packagingID)
		{
		}
	}
}
