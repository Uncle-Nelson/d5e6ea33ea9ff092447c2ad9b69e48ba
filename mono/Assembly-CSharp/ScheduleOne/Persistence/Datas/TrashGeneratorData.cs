using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200043B RID: 1083
	public class TrashGeneratorData : SaveData
	{
		// Token: 0x060015B7 RID: 5559 RVA: 0x0006049F File Offset: 0x0005E69F
		public TrashGeneratorData(string guid, string[] generatedItems)
		{
			this.GUID = guid;
			this.GeneratedItems = generatedItems;
		}

		// Token: 0x04001474 RID: 5236
		public string GUID;

		// Token: 0x04001475 RID: 5237
		public string[] GeneratedItems;
	}
}
