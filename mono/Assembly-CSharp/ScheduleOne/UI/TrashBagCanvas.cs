using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Input;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A55 RID: 2645
	public class TrashBagCanvas : Singleton<TrashBagCanvas>
	{
		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06004739 RID: 18233 RVA: 0x0012A5B5 File Offset: 0x001287B5
		// (set) Token: 0x0600473A RID: 18234 RVA: 0x0012A5BD File Offset: 0x001287BD
		public bool IsOpen { get; private set; }

		// Token: 0x0600473B RID: 18235 RVA: 0x0012A5C6 File Offset: 0x001287C6
		public void Open()
		{
			this.IsOpen = true;
			this.Canvas.enabled = true;
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x0012A5DB File Offset: 0x001287DB
		public void Close()
		{
			this.IsOpen = false;
			this.Canvas.enabled = false;
		}

		// Token: 0x040034A9 RID: 13481
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040034AA RID: 13482
		public InputPrompt InputPrompt;
	}
}
