using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000410 RID: 1040
	[Serializable]
	public class MoveItemData
	{
		// Token: 0x06001585 RID: 5509 RVA: 0x0005FCFC File Offset: 0x0005DEFC
		public MoveItemData(string templateItemJson, int grabbedItemQuantity, Guid sourceGUID, Guid destinationGUID)
		{
			this.TemplateItemJSON = templateItemJson;
			this.GrabbedItemQuantity = grabbedItemQuantity;
			this.SourceGUID = sourceGUID.ToString();
			this.DestinationGUID = destinationGUID.ToString();
		}

		// Token: 0x040013F2 RID: 5106
		public string TemplateItemJSON = string.Empty;

		// Token: 0x040013F3 RID: 5107
		public int GrabbedItemQuantity;

		// Token: 0x040013F4 RID: 5108
		public string SourceGUID;

		// Token: 0x040013F5 RID: 5109
		public string DestinationGUID;
	}
}
