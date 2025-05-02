using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x02000194 RID: 404
	public static class ColorBlendingExtensions
	{
		// Token: 0x06000831 RID: 2097 RVA: 0x0002625C File Offset: 0x0002445C
		public static Color Clear(this Color color)
		{
			return new Color(color.r, color.g, color.b, 0f);
		}
	}
}
