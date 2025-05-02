using System;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006AA RID: 1706
	[Serializable]
	public class DialogueList
	{
		// Token: 0x06002F15 RID: 12053 RVA: 0x000C50BC File Offset: 0x000C32BC
		public string GetRandomLine()
		{
			if (this.Lines.Length == 0)
			{
				return string.Empty;
			}
			int num = Random.Range(0, this.Lines.Length);
			return this.Lines[num];
		}

		// Token: 0x0400216A RID: 8554
		public string[] Lines;
	}
}
