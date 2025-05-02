using System;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200042B RID: 1067
	[Serializable]
	public class ProductData : SaveData
	{
		// Token: 0x060015A1 RID: 5537 RVA: 0x0006018F File Offset: 0x0005E38F
		public ProductData(string name, string id, EDrugType drugType, string[] properties)
		{
			this.Name = name;
			this.ID = id;
			this.DrugType = drugType;
			this.Properties = properties;
		}

		// Token: 0x0400143F RID: 5183
		public string Name;

		// Token: 0x04001440 RID: 5184
		public string ID;

		// Token: 0x04001441 RID: 5185
		public EDrugType DrugType;

		// Token: 0x04001442 RID: 5186
		public string[] Properties;
	}
}
