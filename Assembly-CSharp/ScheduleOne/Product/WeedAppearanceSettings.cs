using System;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200090D RID: 2317
	[Serializable]
	public class WeedAppearanceSettings
	{
		// Token: 0x06003EC9 RID: 16073 RVA: 0x00108DDD File Offset: 0x00106FDD
		public WeedAppearanceSettings(Color32 mainColor, Color32 secondaryColor, Color32 leafColor, Color32 stemColor)
		{
			this.MainColor = mainColor;
			this.SecondaryColor = secondaryColor;
			this.LeafColor = leafColor;
			this.StemColor = stemColor;
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0000494F File Offset: 0x00002B4F
		public WeedAppearanceSettings()
		{
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x00108E04 File Offset: 0x00107004
		public bool IsUnintialized()
		{
			return this.MainColor == Color.clear || this.SecondaryColor == Color.clear || this.LeafColor == Color.clear || this.StemColor == Color.clear;
		}

		// Token: 0x04002CFE RID: 11518
		public Color32 MainColor;

		// Token: 0x04002CFF RID: 11519
		public Color32 SecondaryColor;

		// Token: 0x04002D00 RID: 11520
		public Color32 LeafColor;

		// Token: 0x04002D01 RID: 11521
		public Color32 StemColor;
	}
}
