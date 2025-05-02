using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003E9 RID: 1001
	[Serializable]
	public class ProductItemData : QualityItemData
	{
		// Token: 0x0600155C RID: 5468 RVA: 0x0005F8BF File Offset: 0x0005DABF
		public ProductItemData(string iD, int quantity, string quality, string packagingID) : base(iD, quantity, quality)
		{
			this.PackagingID = packagingID;
		}

		// Token: 0x0400139F RID: 5023
		public string PackagingID;
	}
}
