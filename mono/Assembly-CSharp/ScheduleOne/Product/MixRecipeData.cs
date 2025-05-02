using System;

namespace ScheduleOne.Product
{
	// Token: 0x020008E9 RID: 2281
	[Serializable]
	public class MixRecipeData
	{
		// Token: 0x06003D9A RID: 15770 RVA: 0x0010296D File Offset: 0x00100B6D
		public MixRecipeData(string product, string mixer, string output)
		{
			this.Product = product;
			this.Mixer = mixer;
			this.Output = output;
		}

		// Token: 0x04002C63 RID: 11363
		public string Product;

		// Token: 0x04002C64 RID: 11364
		public string Mixer;

		// Token: 0x04002C65 RID: 11365
		public string Output;
	}
}
