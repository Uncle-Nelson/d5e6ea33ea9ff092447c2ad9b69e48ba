using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;

namespace ScheduleOne.Trash
{
	// Token: 0x0200082E RID: 2094
	[Serializable]
	public class TrashContent
	{
		// Token: 0x0600395E RID: 14686 RVA: 0x000F2A88 File Offset: 0x000F0C88
		public void AddTrash(string trashID, int quantity)
		{
			TrashContent.Entry entry = this.Entries.Find((TrashContent.Entry e) => e.TrashID == trashID);
			if (entry == null)
			{
				entry = new TrashContent.Entry(trashID, 0);
				this.Entries.Add(entry);
			}
			this.Entries.Remove(entry);
			this.Entries.Add(entry);
			entry.Quantity += quantity;
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x000F2B00 File Offset: 0x000F0D00
		public void RemoveTrash(string trashID, int quantity)
		{
			TrashContent.Entry entry = this.Entries.Find((TrashContent.Entry e) => e.TrashID == trashID);
			if (entry == null)
			{
				return;
			}
			entry.Quantity -= quantity;
			if (entry.Quantity <= 0)
			{
				this.Entries.Remove(entry);
			}
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x000F2B5C File Offset: 0x000F0D5C
		public int GetTrashQuantity(string trashID)
		{
			TrashContent.Entry entry = this.Entries.Find((TrashContent.Entry e) => e.TrashID == trashID);
			if (entry == null)
			{
				return 0;
			}
			return entry.Quantity;
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x000F2B99 File Offset: 0x000F0D99
		public void Clear()
		{
			this.Entries.Clear();
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x000F2BA8 File Offset: 0x000F0DA8
		public int GetTotalSize()
		{
			int num = 0;
			foreach (TrashContent.Entry entry in this.Entries)
			{
				num += entry.Quantity * entry.UnitSize;
			}
			return num;
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x000F2C08 File Offset: 0x000F0E08
		public TrashContentData GetData()
		{
			TrashContentData trashContentData = new TrashContentData();
			trashContentData.TrashIDs = new string[this.Entries.Count];
			trashContentData.TrashQuantities = new int[this.Entries.Count];
			for (int i = 0; i < this.Entries.Count; i++)
			{
				trashContentData.TrashIDs[i] = this.Entries[i].TrashID;
				trashContentData.TrashQuantities[i] = this.Entries[i].Quantity;
			}
			return trashContentData;
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x000F2C90 File Offset: 0x000F0E90
		public void LoadFromData(TrashContentData data)
		{
			for (int i = 0; i < data.TrashIDs.Length; i++)
			{
				this.AddTrash(data.TrashIDs[i], data.TrashQuantities[i]);
			}
		}

		// Token: 0x0400297B RID: 10619
		public List<TrashContent.Entry> Entries = new List<TrashContent.Entry>();

		// Token: 0x0200082F RID: 2095
		[Serializable]
		public class Entry
		{
			// Token: 0x1700081F RID: 2079
			// (get) Token: 0x06003966 RID: 14694 RVA: 0x000F2CD9 File Offset: 0x000F0ED9
			// (set) Token: 0x06003967 RID: 14695 RVA: 0x000F2CE1 File Offset: 0x000F0EE1
			public int UnitSize { get; private set; }

			// Token: 0x17000820 RID: 2080
			// (get) Token: 0x06003968 RID: 14696 RVA: 0x000F2CEA File Offset: 0x000F0EEA
			// (set) Token: 0x06003969 RID: 14697 RVA: 0x000F2CF2 File Offset: 0x000F0EF2
			public int UnitValue { get; private set; }

			// Token: 0x0600396A RID: 14698 RVA: 0x000F2CFC File Offset: 0x000F0EFC
			public Entry(string id, int quantity)
			{
				this.TrashID = id;
				this.Quantity = quantity;
				TrashItem trashPrefab = NetworkSingleton<TrashManager>.Instance.GetTrashPrefab(id);
				if (trashPrefab != null)
				{
					this.UnitSize = trashPrefab.Size;
					this.UnitValue = trashPrefab.SellValue;
				}
			}

			// Token: 0x0400297C RID: 10620
			public string TrashID;

			// Token: 0x0400297D RID: 10621
			public int Quantity;
		}
	}
}
