using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000437 RID: 1079
	[Serializable]
	public class TextResponseData
	{
		// Token: 0x060015B2 RID: 5554 RVA: 0x0006042A File Offset: 0x0005E62A
		public TextResponseData(string text, string label)
		{
			this.Text = text;
			this.Label = label;
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00060440 File Offset: 0x0005E640
		public TextResponseData()
		{
			this.Text = "";
			this.Label = "";
		}

		// Token: 0x0400146E RID: 5230
		public string Text;

		// Token: 0x0400146F RID: 5231
		public string Label;
	}
}
