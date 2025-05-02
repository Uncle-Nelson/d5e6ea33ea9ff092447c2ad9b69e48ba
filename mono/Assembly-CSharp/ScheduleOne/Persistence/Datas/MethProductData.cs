using System;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200042A RID: 1066
	[Serializable]
	public class MethProductData : ProductData
	{
		// Token: 0x060015A0 RID: 5536 RVA: 0x0006017A File Offset: 0x0005E37A
		public MethProductData(string name, string id, EDrugType drugType, string[] properties, MethAppearanceSettings appearanceSettings) : base(name, id, drugType, properties)
		{
			this.AppearanceSettings = appearanceSettings;
		}

		// Token: 0x0400143E RID: 5182
		public MethAppearanceSettings AppearanceSettings;
	}
}
