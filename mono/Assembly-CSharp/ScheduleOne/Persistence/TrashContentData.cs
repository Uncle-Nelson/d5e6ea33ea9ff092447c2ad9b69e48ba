using System;
using System.Collections.Generic;
using ScheduleOne.Trash;

namespace ScheduleOne.Persistence
{
	// Token: 0x0200037B RID: 891
	[Serializable]
	public class TrashContentData
	{
		// Token: 0x06001435 RID: 5173 RVA: 0x0005A493 File Offset: 0x00058693
		public TrashContentData()
		{
			this.TrashIDs = new string[0];
			this.TrashQuantities = new int[0];
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0005A4B3 File Offset: 0x000586B3
		public TrashContentData(string[] trashIDs, int[] trashQuantities)
		{
			this.TrashIDs = trashIDs;
			this.TrashQuantities = trashQuantities;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0005A4CC File Offset: 0x000586CC
		public TrashContentData(List<TrashItem> trashItems)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			foreach (TrashItem trashItem in trashItems)
			{
				if (!dictionary.ContainsKey(trashItem.ID))
				{
					dictionary.Add(trashItem.ID, 0);
				}
				Dictionary<string, int> dictionary2 = dictionary;
				string id = trashItem.ID;
				int num = dictionary2[id];
				dictionary2[id] = num + 1;
			}
			this.TrashIDs = new string[dictionary.Count];
			this.TrashQuantities = new int[dictionary.Count];
			int num2 = 0;
			foreach (KeyValuePair<string, int> keyValuePair in dictionary)
			{
				this.TrashIDs[num2] = keyValuePair.Key;
				this.TrashQuantities[num2] = keyValuePair.Value;
				num2++;
			}
		}

		// Token: 0x04001310 RID: 4880
		public string[] TrashIDs;

		// Token: 0x04001311 RID: 4881
		public int[] TrashQuantities;
	}
}
