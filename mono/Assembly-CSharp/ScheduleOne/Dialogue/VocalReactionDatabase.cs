using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006D0 RID: 1744
	[Serializable]
	public class VocalReactionDatabase
	{
		// Token: 0x06002FA6 RID: 12198 RVA: 0x000C6AAC File Offset: 0x000C4CAC
		public VocalReactionDatabase.Entry GetEntry(string key)
		{
			foreach (VocalReactionDatabase.Entry entry in this.Entries)
			{
				if (entry.Key == key)
				{
					return entry;
				}
			}
			return null;
		}

		// Token: 0x040021CA RID: 8650
		public List<VocalReactionDatabase.Entry> Entries = new List<VocalReactionDatabase.Entry>();

		// Token: 0x020006D1 RID: 1745
		[Serializable]
		public class Entry
		{
			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x000C6B23 File Offset: 0x000C4D23
			public string name
			{
				get
				{
					return this.Key;
				}
			}

			// Token: 0x06002FA9 RID: 12201 RVA: 0x000C6B2B File Offset: 0x000C4D2B
			public string GetRandomReaction()
			{
				return this.Reactions[Random.Range(0, this.Reactions.Length)];
			}

			// Token: 0x040021CB RID: 8651
			public string Key;

			// Token: 0x040021CC RID: 8652
			public string[] Reactions;
		}
	}
}
