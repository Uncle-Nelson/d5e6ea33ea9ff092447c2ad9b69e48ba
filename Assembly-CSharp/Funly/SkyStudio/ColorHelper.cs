using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001CB RID: 459
	public abstract class ColorHelper
	{
		// Token: 0x06000A21 RID: 2593 RVA: 0x0002D58E File Offset: 0x0002B78E
		public static Color ColorWithHex(uint hex)
		{
			return ColorHelper.ColorWithHexAlpha(hex << 8 | 255U);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
		public static Color ColorWithHexAlpha(uint hex)
		{
			float r = (hex >> 24 & 255U) / 255f;
			float g = (hex >> 16 & 255U) / 255f;
			float b = (hex >> 8 & 255U) / 255f;
			float a = (hex & 255U) / 255f;
			return new Color(r, g, b, a);
		}
	}
}
