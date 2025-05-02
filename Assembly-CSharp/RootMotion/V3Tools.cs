using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000027 RID: 39
	public static class V3Tools
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00007E22 File Offset: 0x00006022
		public static float GetYaw(Vector3 forward)
		{
			return Mathf.Atan2(forward.x, forward.z) * 57.29578f;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00007E3B File Offset: 0x0000603B
		public static float GetPitch(Vector3 forward)
		{
			forward = forward.normalized;
			return -Mathf.Asin(forward.y) * 57.29578f;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00007E58 File Offset: 0x00006058
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			up = Quaternion.Inverse(Quaternion.LookRotation(Vector3.up, forward)) * up;
			return Mathf.Atan2(up.x, up.z) * 57.29578f;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00007E8C File Offset: 0x0000608C
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			Vector3 vector = Quaternion.Inverse(Quaternion.LookRotation(spaceForward, spaceUp)) * forward;
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00007EC3 File Offset: 0x000060C3
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return -Mathf.Asin((Quaternion.Inverse(Quaternion.LookRotation(spaceForward, spaceUp)) * forward).y) * 57.29578f;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00007EE8 File Offset: 0x000060E8
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			Quaternion rotation = Quaternion.Inverse(Quaternion.LookRotation(spaceForward, spaceUp));
			forward = rotation * forward;
			up = rotation * up;
			up = Quaternion.Inverse(Quaternion.LookRotation(spaceUp, forward)) * up;
			return Mathf.Atan2(up.x, up.z) * 57.29578f;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00007F3D File Offset: 0x0000613D
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			if (weight <= 0f)
			{
				return fromVector;
			}
			if (weight >= 1f)
			{
				return toVector;
			}
			return Vector3.Lerp(fromVector, toVector, weight);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00007F5B File Offset: 0x0000615B
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			if (weight <= 0f)
			{
				return fromVector;
			}
			if (weight >= 1f)
			{
				return toVector;
			}
			return Vector3.Slerp(fromVector, toVector, weight);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007F7C File Offset: 0x0000617C
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			if (weight <= 0f)
			{
				return Vector3.zero;
			}
			if (verticalAxis == Vector3.up)
			{
				return Vector3.up * v.y * weight;
			}
			return Vector3.Project(v, verticalAxis) * weight;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007FC8 File Offset: 0x000061C8
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			if (weight <= 0f)
			{
				return Vector3.zero;
			}
			if (normal == Vector3.up)
			{
				return new Vector3(v.x, 0f, v.z) * weight;
			}
			Vector3 onNormal = v;
			Vector3.OrthoNormalize(ref normal, ref onNormal);
			return Vector3.Project(v, onNormal) * weight;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00008025 File Offset: 0x00006225
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			if (normal == Vector3.up)
			{
				return new Vector3(v.x, 0f, v.z);
			}
			return v - Vector3.Project(v, normal);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00008058 File Offset: 0x00006258
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			if (clampWeight <= 0f)
			{
				return direction;
			}
			if (clampWeight >= 1f)
			{
				return normalDirection;
			}
			float num = Vector3.Angle(normalDirection, direction);
			float num2 = 1f - num / 180f;
			if (num2 > clampWeight)
			{
				return direction;
			}
			float num3 = (clampWeight > 0f) ? Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f) : 1f;
			float num4 = (clampWeight > 0f) ? Mathf.Clamp(num2 / clampWeight, 0f, 1f) : 1f;
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
			}
			return Vector3.Slerp(normalDirection, direction, num4 * num3);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008114 File Offset: 0x00006314
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			changed = false;
			if (clampWeight <= 0f)
			{
				return direction;
			}
			if (clampWeight >= 1f)
			{
				changed = true;
				return normalDirection;
			}
			float num = Vector3.Angle(normalDirection, direction);
			float num2 = 1f - num / 180f;
			if (num2 > clampWeight)
			{
				return direction;
			}
			changed = true;
			float num3 = (clampWeight > 0f) ? Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f) : 1f;
			float num4 = (clampWeight > 0f) ? Mathf.Clamp(num2 / clampWeight, 0f, 1f) : 1f;
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
			}
			return Vector3.Slerp(normalDirection, direction, num4 * num3);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000081DC File Offset: 0x000063DC
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			clampValue = 1f;
			if (clampWeight <= 0f)
			{
				return direction;
			}
			if (clampWeight >= 1f)
			{
				return normalDirection;
			}
			float num = Vector3.Angle(normalDirection, direction);
			float num2 = 1f - num / 180f;
			if (num2 > clampWeight)
			{
				clampValue = 0f;
				return direction;
			}
			float num3 = (clampWeight > 0f) ? Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f) : 1f;
			float num4 = (clampWeight > 0f) ? Mathf.Clamp(num2 / clampWeight, 0f, 1f) : 1f;
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
			}
			float num5 = num4 * num3;
			clampValue = 1f - num5;
			return Vector3.Slerp(normalDirection, direction, num5);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000082B8 File Offset: 0x000064B8
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			float num = Vector3.Dot(planePoint - origin, planeNormal);
			float num2 = Vector3.Dot(direction, planeNormal);
			if (num2 == 0f)
			{
				return Vector3.zero;
			}
			float d = num / num2;
			return origin + direction.normalized * d;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00008300 File Offset: 0x00006500
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			if (planeNormal == Vector3.up)
			{
				return new Vector3(point.x, planePosition.y, point.z);
			}
			Vector3 onNormal = point - planePosition;
			Vector3 vector = planeNormal;
			Vector3.OrthoNormalize(ref vector, ref onNormal);
			return planePosition + Vector3.Project(point - planePosition, onNormal);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00008358 File Offset: 0x00006558
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return t.position + t.rotation * point;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00008371 File Offset: 0x00006571
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return Quaternion.Inverse(t.rotation) * (point - t.position);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000838F File Offset: 0x0000658F
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return V3Tools.Div(Quaternion.Inverse(tRot) * (point - tPos), tScale);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000083A9 File Offset: 0x000065A9
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return tPos + Vector3.Scale(tRot * point, tScale);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000083BE File Offset: 0x000065BE
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return new Vector3(v1.x / v2.x, v1.y / v2.y, v1.z / v2.z);
		}
	}
}
