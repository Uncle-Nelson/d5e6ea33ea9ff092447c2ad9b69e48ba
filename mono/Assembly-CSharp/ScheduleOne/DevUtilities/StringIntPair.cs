using System;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006FB RID: 1787
	[Serializable]
	public class StringIntPair
	{
		// Token: 0x0600308E RID: 12430 RVA: 0x000CA128 File Offset: 0x000C8328
		public StringIntPair(string str, int i)
		{
			this.String = str;
			this.Int = i;
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x0000494F File Offset: 0x00002B4F
		public StringIntPair()
		{
		}

		// Token: 0x04002283 RID: 8835
		public string String;

		// Token: 0x04002284 RID: 8836
		public int Int;
	}
}
