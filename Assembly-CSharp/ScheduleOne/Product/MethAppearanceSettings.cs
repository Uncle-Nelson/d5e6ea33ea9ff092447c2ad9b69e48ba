using System;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008E5 RID: 2277
	[Serializable]
	public class MethAppearanceSettings
	{
		// Token: 0x06003D84 RID: 15748 RVA: 0x001022BF File Offset: 0x001004BF
		public MethAppearanceSettings(Color32 mainColor, Color32 secondaryColor)
		{
			this.MainColor = mainColor;
			this.SecondaryColor = secondaryColor;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x0000494F File Offset: 0x00002B4F
		public MethAppearanceSettings()
		{
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x001022D5 File Offset: 0x001004D5
		public bool IsUnintialized()
		{
			return this.MainColor == Color.clear || this.SecondaryColor == Color.clear;
		}

		// Token: 0x04002C5C RID: 11356
		public Color32 MainColor;

		// Token: 0x04002C5D RID: 11357
		public Color32 SecondaryColor;
	}
}
