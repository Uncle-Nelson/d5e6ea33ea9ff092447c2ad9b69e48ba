using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003EA RID: 1002
	[Serializable]
	public class QualityItemData : ItemData
	{
		// Token: 0x0600155D RID: 5469 RVA: 0x0005F8D2 File Offset: 0x0005DAD2
		public QualityItemData(string iD, int quantity, string quality) : base(iD, quantity)
		{
			this.Quality = quality;
		}

		// Token: 0x040013A0 RID: 5024
		public string Quality;
	}
}
