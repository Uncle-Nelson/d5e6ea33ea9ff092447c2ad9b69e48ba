using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200001A RID: 26
	public class Interp
	{
		// Token: 0x060000BC RID: 188 RVA: 0x000067AC File Offset: 0x000049AC
		public static float Float(float t, InterpolationMode mode)
		{
			float result;
			switch (mode)
			{
			case InterpolationMode.None:
				result = Interp.None(t, 0f, 1f);
				break;
			case InterpolationMode.InOutCubic:
				result = Interp.InOutCubic(t, 0f, 1f);
				break;
			case InterpolationMode.InOutQuintic:
				result = Interp.InOutQuintic(t, 0f, 1f);
				break;
			case InterpolationMode.InOutSine:
				result = Interp.InOutSine(t, 0f, 1f);
				break;
			case InterpolationMode.InQuintic:
				result = Interp.InQuintic(t, 0f, 1f);
				break;
			case InterpolationMode.InQuartic:
				result = Interp.InQuartic(t, 0f, 1f);
				break;
			case InterpolationMode.InCubic:
				result = Interp.InCubic(t, 0f, 1f);
				break;
			case InterpolationMode.InQuadratic:
				result = Interp.InQuadratic(t, 0f, 1f);
				break;
			case InterpolationMode.InElastic:
				result = Interp.OutElastic(t, 0f, 1f);
				break;
			case InterpolationMode.InElasticSmall:
				result = Interp.InElasticSmall(t, 0f, 1f);
				break;
			case InterpolationMode.InElasticBig:
				result = Interp.InElasticBig(t, 0f, 1f);
				break;
			case InterpolationMode.InSine:
				result = Interp.InSine(t, 0f, 1f);
				break;
			case InterpolationMode.InBack:
				result = Interp.InBack(t, 0f, 1f);
				break;
			case InterpolationMode.OutQuintic:
				result = Interp.OutQuintic(t, 0f, 1f);
				break;
			case InterpolationMode.OutQuartic:
				result = Interp.OutQuartic(t, 0f, 1f);
				break;
			case InterpolationMode.OutCubic:
				result = Interp.OutCubic(t, 0f, 1f);
				break;
			case InterpolationMode.OutInCubic:
				result = Interp.OutInCubic(t, 0f, 1f);
				break;
			case InterpolationMode.OutInQuartic:
				result = Interp.OutInCubic(t, 0f, 1f);
				break;
			case InterpolationMode.OutElastic:
				result = Interp.OutElastic(t, 0f, 1f);
				break;
			case InterpolationMode.OutElasticSmall:
				result = Interp.OutElasticSmall(t, 0f, 1f);
				break;
			case InterpolationMode.OutElasticBig:
				result = Interp.OutElasticBig(t, 0f, 1f);
				break;
			case InterpolationMode.OutSine:
				result = Interp.OutSine(t, 0f, 1f);
				break;
			case InterpolationMode.OutBack:
				result = Interp.OutBack(t, 0f, 1f);
				break;
			case InterpolationMode.OutBackCubic:
				result = Interp.OutBackCubic(t, 0f, 1f);
				break;
			case InterpolationMode.OutBackQuartic:
				result = Interp.OutBackQuartic(t, 0f, 1f);
				break;
			case InterpolationMode.BackInCubic:
				result = Interp.BackInCubic(t, 0f, 1f);
				break;
			case InterpolationMode.BackInQuartic:
				result = Interp.BackInQuartic(t, 0f, 1f);
				break;
			default:
				result = 0f;
				break;
			}
			return result;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006A7C File Offset: 0x00004C7C
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			float num = Interp.Float(t, mode);
			return (1f - num) * v1 + num * v2;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006AAA File Offset: 0x00004CAA
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			if (value == target)
			{
				return target;
			}
			if (value < target)
			{
				return Mathf.Clamp(value + Time.deltaTime * increaseSpeed, float.NegativeInfinity, target);
			}
			return Mathf.Clamp(value - Time.deltaTime * decreaseSpeed, target, float.PositiveInfinity);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006ADF File Offset: 0x00004CDF
		private static float None(float t, float b, float c)
		{
			return b + c * t;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006AE8 File Offset: 0x00004CE8
		private static float InOutCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (-2f * num2 + 3f * num);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006B10 File Offset: 0x00004D10
		private static float InOutQuintic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (6f * num2 * num + -15f * num * num + 10f * num2);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006B44 File Offset: 0x00004D44
		private static float InQuintic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (num2 * num);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006B60 File Offset: 0x00004D60
		private static float InQuartic(float t, float b, float c)
		{
			float num = t * t;
			return b + c * (num * num);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006B78 File Offset: 0x00004D78
		private static float InCubic(float t, float b, float c)
		{
			float num = t * t * t;
			return b + c * num;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006B90 File Offset: 0x00004D90
		private static float InQuadratic(float t, float b, float c)
		{
			float num = t * t;
			return b + c * num;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006BA8 File Offset: 0x00004DA8
		private static float OutQuintic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (num2 * num + -5f * num * num + 10f * num2 + -10f * num + 5f * t);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00006BE8 File Offset: 0x00004DE8
		private static float OutQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (-1f * num * num + 4f * num2 + -6f * num + 4f * t);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006C24 File Offset: 0x00004E24
		private static float OutCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (num2 + -3f * num + 3f * t);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006C50 File Offset: 0x00004E50
		private static float OutInCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (4f * num2 + -6f * num + 3f * t);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00006C80 File Offset: 0x00004E80
		private static float OutInQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (6f * num2 + -9f * num + 4f * t);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00006CB0 File Offset: 0x00004EB0
		private static float BackInCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (4f * num2 + -3f * num);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006CD8 File Offset: 0x00004ED8
		private static float BackInQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (2f * num * num + 2f * num2 + -3f * num);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00006D0C File Offset: 0x00004F0C
		private static float OutBackCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (4f * num2 + -9f * num + 6f * t);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00006D3C File Offset: 0x00004F3C
		private static float OutBackQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (-2f * num * num + 10f * num2 + -15f * num + 8f * t);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00006D78 File Offset: 0x00004F78
		private static float OutElasticSmall(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (33f * num2 * num + -106f * num * num + 126f * num2 + -67f * num + 15f * t);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006DBC File Offset: 0x00004FBC
		private static float OutElasticBig(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (56f * num2 * num + -175f * num * num + 200f * num2 + -100f * num + 20f * t);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006E00 File Offset: 0x00005000
		private static float InElasticSmall(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (33f * num2 * num + -59f * num * num + 32f * num2 + -5f * num);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006E3C File Offset: 0x0000503C
		private static float InElasticBig(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (56f * num2 * num + -105f * num * num + 60f * num2 + -10f * num);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006E78 File Offset: 0x00005078
		private static float InSine(float t, float b, float c)
		{
			c -= b;
			return -c * Mathf.Cos(t / 1f * 1.5707964f) + c + b;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006E98 File Offset: 0x00005098
		private static float OutSine(float t, float b, float c)
		{
			c -= b;
			return c * Mathf.Sin(t / 1f * 1.5707964f) + b;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006EB5 File Offset: 0x000050B5
		private static float InOutSine(float t, float b, float c)
		{
			c -= b;
			return -c / 2f * (Mathf.Cos(3.1415927f * t / 1f) - 1f) + b;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006EE0 File Offset: 0x000050E0
		private static float InElastic(float t, float b, float c)
		{
			c -= b;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			if (t == 0f)
			{
				return b;
			}
			if ((t /= num) == 1f)
			{
				return b + c;
			}
			float num4;
			if (num3 == 0f || num3 < Mathf.Abs(c))
			{
				num3 = c;
				num4 = num2 / 4f;
			}
			else
			{
				num4 = num2 / 6.2831855f * Mathf.Asin(c / num3);
			}
			return -(num3 * Mathf.Pow(2f, 10f * (t -= 1f)) * Mathf.Sin((t * num - num4) * 6.2831855f / num2)) + b;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00006F88 File Offset: 0x00005188
		private static float OutElastic(float t, float b, float c)
		{
			c -= b;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			if (t == 0f)
			{
				return b;
			}
			if ((t /= num) == 1f)
			{
				return b + c;
			}
			float num4;
			if (num3 == 0f || num3 < Mathf.Abs(c))
			{
				num3 = c;
				num4 = num2 / 4f;
			}
			else
			{
				num4 = num2 / 6.2831855f * Mathf.Asin(c / num3);
			}
			return num3 * Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * num - num4) * 6.2831855f / num2) + c + b;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00007028 File Offset: 0x00005228
		private static float InBack(float t, float b, float c)
		{
			c -= b;
			t /= 1f;
			float num = 1.70158f;
			return c * t * t * ((num + 1f) * t - num) + b;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000705C File Offset: 0x0000525C
		private static float OutBack(float t, float b, float c)
		{
			float num = 1.70158f;
			c -= b;
			t = t / 1f - 1f;
			return c * (t * t * ((num + 1f) * t + num) + 1f) + b;
		}
	}
}
