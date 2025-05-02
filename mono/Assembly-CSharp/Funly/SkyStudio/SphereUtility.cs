using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001D5 RID: 469
	public abstract class SphereUtility
	{
		// Token: 0x06000A40 RID: 2624 RVA: 0x0002DD58 File Offset: 0x0002BF58
		public static Vector2 DirectionToSphericalCoordinate(Vector3 direction)
		{
			Vector3 normalized = direction.normalized;
			float x = SphereUtility.Atan2Positive(normalized.z, normalized.x);
			float num = Vector3.Angle(direction, Vector3.up) * 0.017453292f;
			float y;
			if (num <= 1.5707964f)
			{
				y = 1.5707964f - num;
			}
			else
			{
				y = -1f * (num - 1.5707964f);
			}
			return new Vector2(x, y);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0002DDBC File Offset: 0x0002BFBC
		public static Vector3 SphericalCoordinateToDirection(Vector2 coord)
		{
			float num = Mathf.Cos(coord.y);
			float y = Mathf.Sin(coord.y);
			float num2 = num;
			num = num2 * Mathf.Cos(coord.x);
			float z = num2 * Mathf.Sin(coord.x);
			return new Vector3(num, y, z);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002DE0B File Offset: 0x0002C00B
		public static float RadiusAtHeight(float yPos)
		{
			return Mathf.Abs(Mathf.Cos(Mathf.Asin(yPos)));
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002DE20 File Offset: 0x0002C020
		public static Vector3 SphericalToPoint(float yPosition, float radAngle)
		{
			float num = SphereUtility.RadiusAtHeight(yPosition);
			return new Vector3(num * Mathf.Cos(radAngle), yPosition, num * Mathf.Sin(radAngle));
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002DE4A File Offset: 0x0002C04A
		public static float RadAngleToPercent(float radAngle)
		{
			return radAngle / 6.2831855f;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002DE53 File Offset: 0x0002C053
		public static float PercentToRadAngle(float percent)
		{
			return percent * 6.2831855f;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002DE5C File Offset: 0x0002C05C
		public static float HeightToPercent(float yValue)
		{
			return yValue / 2f + 0.5f;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002DE6B File Offset: 0x0002C06B
		public static float PercentToHeight(float hPercent)
		{
			return Mathf.Lerp(-1f, 1f, hPercent);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002DE80 File Offset: 0x0002C080
		public static float AngleToReachTarget(Vector2 point, float targetAngle)
		{
			float num = SphereUtility.Atan2Positive(point.y, point.x);
			return 6.2831855f - num + targetAngle;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002DEA8 File Offset: 0x0002C0A8
		public static float Atan2Positive(float y, float x)
		{
			float num = Mathf.Atan2(y, x);
			if (num < 0f)
			{
				num = 3.1415927f + (3.1415927f + num);
			}
			return num;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002DED4 File Offset: 0x0002C0D4
		public static Vector3 RotateAroundXAxis(Vector3 point, float angle)
		{
			Vector2 vector = SphereUtility.Rotate2d(new Vector2(point.z, point.y), angle);
			return new Vector3(point.x, vector.y, vector.x);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002DF10 File Offset: 0x0002C110
		public static Vector3 RotateAroundYAxis(Vector3 point, float angle)
		{
			Vector2 vector = SphereUtility.Rotate2d(new Vector2(point.x, point.z), angle);
			return new Vector3(vector.x, point.y, vector.y);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0002DF4C File Offset: 0x0002C14C
		public static Vector3 RotatePoint(Vector3 point, float xAxisRotation, float yAxisRotation)
		{
			return SphereUtility.RotateAroundXAxis(SphereUtility.RotateAroundYAxis(point, yAxisRotation), xAxisRotation);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002DF5B File Offset: 0x0002C15B
		public static Vector2 Rotate2d(Vector2 pos, float angle)
		{
			return SphereUtility.Matrix2x2Mult(new Vector4(Mathf.Cos(angle), -Mathf.Sin(angle), Mathf.Sin(angle), Mathf.Cos(angle)), pos);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002DF84 File Offset: 0x0002C184
		public static Vector2 Matrix2x2Mult(Vector4 matrix, Vector2 pos)
		{
			return new Vector2(matrix[0] * pos[0] + matrix[1] * pos[1], matrix[2] * pos[0] + matrix[3] * pos[1]);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0002DFDC File Offset: 0x0002C1DC
		public static void CalculateStarRotation(Vector3 star, out float xRotationAngle, out float yRotationAngle)
		{
			Vector3 vector = new Vector3(star.x, star.y, star.z);
			yRotationAngle = SphereUtility.AngleToReachTarget(new Vector2(vector.x, vector.z), 1.5707964f);
			vector = SphereUtility.RotateAroundYAxis(vector, yRotationAngle);
			xRotationAngle = SphereUtility.AngleToReachTarget(new Vector3(vector.z, vector.y), 0f);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002E04A File Offset: 0x0002C24A
		public static Vector2 ConvertUVToSphericalCoordinate(Vector2 uv)
		{
			return new Vector2(Mathf.Lerp(0f, 6.2831855f, uv.x), Mathf.Lerp(-1.5707964f, 1.5707964f, uv.y));
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0002E07B File Offset: 0x0002C27B
		public static Vector2 ConvertSphericalCoordateToUV(Vector2 sphereCoord)
		{
			return new Vector2(sphereCoord.x / 6.2831855f, (sphereCoord.y + 1.5707964f) / 3.1415927f);
		}

		// Token: 0x04000B55 RID: 2901
		private const float k_HalfPI = 1.5707964f;
	}
}
