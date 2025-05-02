using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.ItemLoaders
{
	// Token: 0x02000449 RID: 1097
	public class TrashGrabberLoader : ItemLoader
	{
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x00060BA1 File Offset: 0x0005EDA1
		public override string ItemType
		{
			get
			{
				return typeof(TrashGrabberData).Name;
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00060BB4 File Offset: 0x0005EDB4
		public override ItemInstance LoadItem(string itemString)
		{
			TrashGrabberData trashGrabberData = base.LoadData<TrashGrabberData>(itemString);
			if (trashGrabberData == null)
			{
				Console.LogWarning("Failed loading item data from " + itemString, null);
				return null;
			}
			if (trashGrabberData.ID == string.Empty)
			{
				return null;
			}
			ItemDefinition item = Registry.GetItem(trashGrabberData.ID);
			if (item == null)
			{
				Console.LogWarning("Failed to find item definition for " + trashGrabberData.ID, null);
				return null;
			}
			TrashGrabberInstance trashGrabberInstance = new TrashGrabberInstance(item, trashGrabberData.Quantity);
			trashGrabberInstance.LoadContentData(trashGrabberData.Content);
			return trashGrabberInstance;
		}
	}
}
