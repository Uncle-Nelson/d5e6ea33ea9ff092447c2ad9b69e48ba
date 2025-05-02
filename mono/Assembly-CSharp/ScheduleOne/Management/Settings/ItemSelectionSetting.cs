using System;
using System.Collections.Generic;

namespace ScheduleOne.Management.Settings
{
	// Token: 0x02000594 RID: 1428
	[Serializable]
	public class ItemSelectionSetting
	{
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x00090D5E File Offset: 0x0008EF5E
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x00090D66 File Offset: 0x0008EF66
		public List<string> SelectedItems { get; protected set; } = new List<string>();
	}
}
