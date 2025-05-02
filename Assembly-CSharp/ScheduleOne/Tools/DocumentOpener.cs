using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000853 RID: 2131
	public class DocumentOpener : MonoBehaviour
	{
		// Token: 0x06003A66 RID: 14950 RVA: 0x000F6B23 File Offset: 0x000F4D23
		public void Open()
		{
			Singleton<DocumentViewer>.Instance.Open(this.DocumentName);
		}

		// Token: 0x04002A0C RID: 10764
		public string DocumentName;
	}
}
