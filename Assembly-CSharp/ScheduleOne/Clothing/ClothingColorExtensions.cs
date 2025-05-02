using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	// Token: 0x0200074E RID: 1870
	public static class ClothingColorExtensions
	{
		// Token: 0x0600328A RID: 12938 RVA: 0x000D1DEB File Offset: 0x000CFFEB
		public static Color GetActualColor(this EClothingColor color)
		{
			return Singleton<ClothingUtility>.Instance.GetColorData(color).ActualColor;
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000D1DFD File Offset: 0x000CFFFD
		public static Color GetLabelColor(this EClothingColor color)
		{
			return Singleton<ClothingUtility>.Instance.GetColorData(color).LabelColor;
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000D1E0F File Offset: 0x000D000F
		public static string GetLabel(this EClothingColor color)
		{
			return color.ToString();
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000D1E20 File Offset: 0x000D0020
		public static EClothingColor GetClothingColor(Color color)
		{
			foreach (object obj in Enum.GetValues(typeof(EClothingColor)))
			{
				EClothingColor eclothingColor = (EClothingColor)obj;
				if (ClothingColorExtensions.ColorEquals(eclothingColor.GetActualColor(), color, 0.004f))
				{
					return eclothingColor;
				}
			}
			string str = "Could not find clothing color for color ";
			Color color2 = color;
			Console.LogError(str + color2.ToString(), null);
			return EClothingColor.White;
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000D1EB8 File Offset: 0x000D00B8
		public static bool ColorEquals(Color a, Color b, float tolerance = 0.004f)
		{
			return a.r <= b.r + tolerance && a.g <= b.g + tolerance && a.b <= b.b + tolerance && a.r >= b.r - tolerance && a.g >= b.g - tolerance && a.b >= b.b - tolerance;
		}
	}
}
