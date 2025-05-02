using System;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008DB RID: 2267
	[Serializable]
	public class CocaineAppearanceSettings
	{
		// Token: 0x06003D67 RID: 15719 RVA: 0x00101B98 File Offset: 0x000FFD98
		public CocaineAppearanceSettings(Color32 mainColor, Color32 secondaryColor)
		{
			this.MainColor = mainColor;
			this.SecondaryColor = secondaryColor;
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x0000494F File Offset: 0x00002B4F
		public CocaineAppearanceSettings()
		{
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x00101BAE File Offset: 0x000FFDAE
		public bool IsUnintialized()
		{
			return this.MainColor == Color.clear || this.SecondaryColor == Color.clear;
		}

		// Token: 0x04002C3B RID: 11323
		public Color32 MainColor;

		// Token: 0x04002C3C RID: 11324
		public Color32 SecondaryColor;
	}
}
