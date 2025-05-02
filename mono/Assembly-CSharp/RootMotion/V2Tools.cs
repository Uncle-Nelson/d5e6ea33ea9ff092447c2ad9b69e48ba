using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000026 RID: 38
	public static class V2Tools
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00007C37 File Offset: 0x00005E37
		public static Vector2 XZ(Vector3 v)
		{
			return new Vector2(v.x, v.z);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00007C4C File Offset: 0x00005E4C
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			float current = Mathf.Atan2(dir1.x, dir1.y) * 57.29578f;
			float target = Mathf.Atan2(dir2.x, dir2.y) * 57.29578f;
			return Mathf.DeltaAngle(current, target);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00007C90 File Offset: 0x00005E90
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			float current = Mathf.Atan2(dir1.x, dir1.z) * 57.29578f;
			float target = Mathf.Atan2(dir2.x, dir2.z) * 57.29578f;
			return Mathf.DeltaAngle(current, target);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00007CD4 File Offset: 0x00005ED4
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			Vector2 vector = p2 - p1;
			Vector2 vector2 = c - p1;
			float num = Vector2.Dot(vector, vector);
			float num2 = 2f * Vector2.Dot(vector2, vector);
			float num3 = Vector2.Dot(vector2, vector2) - r * r;
			float num4 = num2 * num2 - 4f * num * num3;
			if (num4 < 0f)
			{
				return false;
			}
			num4 = Mathf.Sqrt(num4);
			float num5 = 2f * num;
			float num6 = (num2 - num4) / num5;
			float num7 = (num2 + num4) / num5;
			return (num6 >= 0f && num6 <= 1f) || (num7 >= 0f && num7 <= 1f);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00007D7C File Offset: 0x00005F7C
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			Vector2 vector = p1 + dir;
			p1 -= c;
			vector -= c;
			float f = vector.x - p1.x;
			float f2 = vector.y - p1.y;
			float f3 = Mathf.Sqrt(Mathf.Pow(f, 2f) + Mathf.Pow(f2, 2f));
			float f4 = p1.x * vector.y - vector.x * p1.y;
			return Mathf.Pow(r, 2f) * Mathf.Pow(f3, 2f) - Mathf.Pow(f4, 2f) >= 0f;
		}
	}
}
