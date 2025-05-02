using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003EC RID: 1004
	[Serializable]
	public class TrashGrabberData : ItemData
	{
		// Token: 0x0600155F RID: 5471 RVA: 0x0005F900 File Offset: 0x0005DB00
		public TrashGrabberData(string iD, int quantity, TrashContentData content) : base(iD, quantity)
		{
			this.Content = content;
		}

		// Token: 0x040013A4 RID: 5028
		public TrashContentData Content;
	}
}
