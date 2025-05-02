using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000022 RID: 34
	public static class QuaTools
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00007400 File Offset: 0x00005600
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			Vector3 vector = Quaternion.Inverse(space) * forward;
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007431 File Offset: 0x00005631
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			forward = forward.normalized;
			return -Mathf.Asin((Quaternion.Inverse(space) * forward).y) * 57.29578f;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000745C File Offset: 0x0000565C
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			Vector3 forward2 = space * Vector3.up;
			Quaternion rotation = Quaternion.Inverse(space);
			forward = rotation * forward;
			up = rotation * up;
			up = Quaternion.Inverse(Quaternion.LookRotation(forward2, forward)) * up;
			return Mathf.Atan2(up.x, up.z) * 57.29578f;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000074B8 File Offset: 0x000056B8
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			Vector3 vector = Quaternion.Inverse(space) * (rotation * Vector3.forward);
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000074F3 File Offset: 0x000056F3
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return -Mathf.Asin((Quaternion.Inverse(space) * (rotation * Vector3.forward)).y) * 57.29578f;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000751C File Offset: 0x0000571C
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			Vector3 forward = space * Vector3.up;
			Quaternion rotation2 = Quaternion.Inverse(space);
			Vector3 upwards = rotation2 * (rotation * Vector3.forward);
			Vector3 vector = rotation2 * (rotation * Vector3.up);
			vector = Quaternion.Inverse(Quaternion.LookRotation(forward, upwards)) * vector;
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007586 File Offset: 0x00005786
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			if (weight <= 0f)
			{
				return fromRotation;
			}
			if (weight >= 1f)
			{
				return toRotation;
			}
			return Quaternion.Lerp(fromRotation, toRotation, weight);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000075A4 File Offset: 0x000057A4
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			if (weight <= 0f)
			{
				return fromRotation;
			}
			if (weight >= 1f)
			{
				return toRotation;
			}
			return Quaternion.Slerp(fromRotation, toRotation, weight);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000075C2 File Offset: 0x000057C2
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			if (weight <= 0f)
			{
				return Quaternion.identity;
			}
			if (weight >= 1f)
			{
				return q;
			}
			return Quaternion.Lerp(Quaternion.identity, q, weight);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000075E8 File Offset: 0x000057E8
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			if (weight <= 0f)
			{
				return Quaternion.identity;
			}
			if (weight >= 1f)
			{
				return q;
			}
			return Quaternion.Slerp(Quaternion.identity, q, weight);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00007610 File Offset: 0x00005810
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
			float num = 0f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (Vector3.Dot(zero, axis) < 0f)
			{
				num = -num;
			}
			return Quaternion.AngleAxis(num, axis);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00007654 File Offset: 0x00005854
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return Quaternion.Inverse(Quaternion.Inverse(space) * rotation);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00007667 File Offset: 0x00005867
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			if (to == from)
			{
				return Quaternion.identity;
			}
			return to * Quaternion.Inverse(from);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00007684 File Offset: 0x00005884
		public static Vector3 GetAxis(Vector3 v)
		{
			Vector3 vector = Vector3.right;
			bool flag = false;
			float num = Vector3.Dot(v, Vector3.right);
			float num2 = Mathf.Abs(num);
			if (num < 0f)
			{
				flag = true;
			}
			float num3 = Vector3.Dot(v, Vector3.up);
			float num4 = Mathf.Abs(num3);
			if (num4 > num2)
			{
				num2 = num4;
				vector = Vector3.up;
				flag = (num3 < 0f);
			}
			float num5 = Vector3.Dot(v, Vector3.forward);
			num4 = Mathf.Abs(num5);
			if (num4 > num2)
			{
				vector = Vector3.forward;
				flag = (num5 < 0f);
			}
			if (flag)
			{
				vector = -vector;
			}
			return vector;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00007718 File Offset: 0x00005918
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			if (clampWeight >= 1f)
			{
				return Quaternion.identity;
			}
			if (clampWeight <= 0f)
			{
				return rotation;
			}
			float num = Quaternion.Angle(Quaternion.identity, rotation);
			float num2 = 1f - num / 180f;
			float num3 = Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f);
			float num4 = Mathf.Clamp(num2 / clampWeight, 0f, 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
			}
			return Quaternion.Slerp(Quaternion.identity, rotation, num4 * num3);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000077BC File Offset: 0x000059BC
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			if (clampWeight >= 1f)
			{
				return 0f;
			}
			if (clampWeight <= 0f)
			{
				return angle;
			}
			float num = 1f - Mathf.Abs(angle) / 180f;
			float num2 = Mathf.Clamp(1f - (clampWeight - num) / (1f - num), 0f, 1f);
			float num3 = Mathf.Clamp(num / clampWeight, 0f, 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num3 = Mathf.Sin(num3 * 3.1415927f * 0.5f);
			}
			return Mathf.Lerp(0f, angle, num3 * num2);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00007858 File Offset: 0x00005A58
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			Quaternion rotation = Quaternion.LookRotation(axis1, axis2);
			Quaternion rhs = Quaternion.LookRotation(targetAxis1, targetAxis2);
			return targetRotation * rhs * Quaternion.Inverse(rotation);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00007888 File Offset: 0x00005A88
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return new Vector3(QuaTools.ToBiPolar(euler.x), QuaTools.ToBiPolar(euler.y), QuaTools.ToBiPolar(euler.z));
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000078B0 File Offset: 0x00005AB0
		public static float ToBiPolar(float angle)
		{
			angle %= 360f;
			if (angle >= 180f)
			{
				return angle - 360f;
			}
			if (angle <= -180f)
			{
				return angle + 360f;
			}
			return angle;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000078DC File Offset: 0x00005ADC
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			r = Quaternion.Inverse(space) * r;
			Vector3 forward = r * Vector3.forward;
			Vector3 upwards = r * Vector3.up;
			forward.x *= -1f;
			upwards.x *= -1f;
			return space * Quaternion.LookRotation(forward, upwards);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000793C File Offset: 0x00005B3C
		public static Quaternion MirrorYZ(Quaternion r)
		{
			Vector3 forward = r * Vector3.forward;
			Vector3 upwards = r * Vector3.up;
			forward.x *= -1f;
			upwards.x *= -1f;
			return Quaternion.LookRotation(forward, upwards);
		}
	}
}
