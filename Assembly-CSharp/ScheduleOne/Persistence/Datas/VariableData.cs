using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200043D RID: 1085
	[Serializable]
	public class VariableData : SaveData
	{
		// Token: 0x060015B9 RID: 5561 RVA: 0x000604DA File Offset: 0x0005E6DA
		public VariableData(string name, string value)
		{
			this.Name = name;
			this.Value = value;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000604F0 File Offset: 0x0005E6F0
		public VariableData()
		{
			this.Name = "";
			this.Value = "";
		}

		// Token: 0x0400147B RID: 5243
		public string Name;

		// Token: 0x0400147C RID: 5244
		public string Value;
	}
}
