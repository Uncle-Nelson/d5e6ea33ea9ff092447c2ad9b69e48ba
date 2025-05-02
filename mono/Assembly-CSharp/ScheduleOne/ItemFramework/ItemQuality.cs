using System;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000952 RID: 2386
	public static class ItemQuality
	{
		// Token: 0x06004075 RID: 16501 RVA: 0x0010ED04 File Offset: 0x0010CF04
		public static EQuality GetQuality(float qualityScalar)
		{
			if (qualityScalar > 0.9f)
			{
				return EQuality.Heavenly;
			}
			if (qualityScalar > 0.75f)
			{
				return EQuality.Premium;
			}
			if (qualityScalar > 0.4f)
			{
				return EQuality.Standard;
			}
			if (qualityScalar > 0.25f)
			{
				return EQuality.Poor;
			}
			return EQuality.Trash;
		}

		// Token: 0x06004076 RID: 16502 RVA: 0x0010ED30 File Offset: 0x0010CF30
		public static Color GetColor(EQuality quality)
		{
			switch (quality)
			{
			case EQuality.Trash:
				return ItemQuality.Trash_Color;
			case EQuality.Poor:
				return ItemQuality.Poor_Color;
			case EQuality.Standard:
				return ItemQuality.Standard_Color;
			case EQuality.Premium:
				return ItemQuality.Premium_Color;
			case EQuality.Heavenly:
				return ItemQuality.Heavenly_Color;
			default:
				Console.LogWarning("Quality color not found!", null);
				return Color.white;
			}
		}

		// Token: 0x04002E4D RID: 11853
		public const float Heavenly_Threshold = 0.9f;

		// Token: 0x04002E4E RID: 11854
		public const float Premium_Threshold = 0.75f;

		// Token: 0x04002E4F RID: 11855
		public const float Standard_Threshold = 0.4f;

		// Token: 0x04002E50 RID: 11856
		public const float Poor_Threshold = 0.25f;

		// Token: 0x04002E51 RID: 11857
		public static Color Heavenly_Color = new Color32(byte.MaxValue, 200, 50, byte.MaxValue);

		// Token: 0x04002E52 RID: 11858
		public static Color Premium_Color = new Color32(225, 75, byte.MaxValue, byte.MaxValue);

		// Token: 0x04002E53 RID: 11859
		public static Color Standard_Color = new Color32(100, 190, byte.MaxValue, byte.MaxValue);

		// Token: 0x04002E54 RID: 11860
		public static Color Poor_Color = new Color32(80, 145, 50, byte.MaxValue);

		// Token: 0x04002E55 RID: 11861
		public static Color Trash_Color = new Color32(125, 50, 50, byte.MaxValue);
	}
}
