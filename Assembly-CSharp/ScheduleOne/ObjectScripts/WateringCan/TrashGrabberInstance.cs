using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Trash;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000BF7 RID: 3063
	[Serializable]
	public class TrashGrabberInstance : StorableItemInstance
	{
		// Token: 0x0600564C RID: 22092 RVA: 0x0016B397 File Offset: 0x00169597
		public TrashGrabberInstance()
		{
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x0016B3AA File Offset: 0x001695AA
		public TrashGrabberInstance(ItemDefinition definition, int quantity) : base(definition, quantity)
		{
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x0016B3C0 File Offset: 0x001695C0
		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			int quantity = this.Quantity;
			if (overrideQuantity != -1)
			{
				quantity = overrideQuantity;
			}
			TrashGrabberInstance trashGrabberInstance = new TrashGrabberInstance(base.Definition, quantity);
			trashGrabberInstance.Content.LoadFromData(this.Content.GetData());
			return trashGrabberInstance;
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x0016B3FC File Offset: 0x001695FC
		public void LoadContentData(TrashContentData content)
		{
			this.Content.LoadFromData(content);
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x0016B40A File Offset: 0x0016960A
		public override ItemData GetItemData()
		{
			return new TrashGrabberData(this.ID, this.Quantity, this.Content.GetData());
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x0016B428 File Offset: 0x00169628
		public void AddTrash(string id, int quantity)
		{
			this.Content.AddTrash(id, quantity);
			base.InvokeDataChange();
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x0016B43D File Offset: 0x0016963D
		public void RemoveTrash(string id, int quantity)
		{
			this.Content.RemoveTrash(id, quantity);
			base.InvokeDataChange();
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x0016B452 File Offset: 0x00169652
		public void ClearTrash()
		{
			this.Content.Clear();
			base.InvokeDataChange();
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x0016B465 File Offset: 0x00169665
		public int GetTotalSize()
		{
			return this.Content.GetTotalSize();
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x0016B474 File Offset: 0x00169674
		public List<string> GetTrashIDs()
		{
			List<string> list = new List<string>();
			foreach (TrashContent.Entry entry in this.Content.Entries)
			{
				list.Add(entry.TrashID);
			}
			return list;
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x0016B4D8 File Offset: 0x001696D8
		public List<int> GetTrashQuantities()
		{
			List<int> list = new List<int>();
			foreach (TrashContent.Entry entry in this.Content.Entries)
			{
				list.Add(entry.Quantity);
			}
			return list;
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x0016B53C File Offset: 0x0016973C
		public List<ushort> GetTrashUshortQuantities()
		{
			List<ushort> list = new List<ushort>();
			foreach (TrashContent.Entry entry in this.Content.Entries)
			{
				list.Add((ushort)entry.Quantity);
			}
			return list;
		}

		// Token: 0x04003FB7 RID: 16311
		public const int TRASH_CAPACITY = 20;

		// Token: 0x04003FB8 RID: 16312
		private TrashContent Content = new TrashContent();
	}
}
