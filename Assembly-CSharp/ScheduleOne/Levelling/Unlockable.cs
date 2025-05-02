using System;
using UnityEngine;

namespace ScheduleOne.Levelling
{
	// Token: 0x020005B2 RID: 1458
	public class Unlockable
	{
		// Token: 0x06002443 RID: 9283 RVA: 0x0009313C File Offset: 0x0009133C
		public Unlockable(FullRank rank, string title, Sprite icon)
		{
			this.Rank = rank;
			this.Title = title;
			this.Icon = icon;
		}

		// Token: 0x04001AFF RID: 6911
		public FullRank Rank;

		// Token: 0x04001B00 RID: 6912
		public string Title;

		// Token: 0x04001B01 RID: 6913
		public Sprite Icon;
	}
}
