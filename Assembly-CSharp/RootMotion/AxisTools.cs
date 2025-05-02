using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000011 RID: 17
	public class AxisTools
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00004926 File Offset: 0x00002B26
		public static Vector3 ToVector3(Axis axis)
		{
			if (axis == Axis.X)
			{
				return Vector3.right;
			}
			if (axis == Axis.Y)
			{
				return Vector3.up;
			}
			return Vector3.forward;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004940 File Offset: 0x00002B40
		public static Axis ToAxis(Vector3 v)
		{
			float num = Mathf.Abs(v.x);
			float num2 = Mathf.Abs(v.y);
			float num3 = Mathf.Abs(v.z);
			Axis result = Axis.X;
			if (num2 > num && num2 > num3)
			{
				result = Axis.Y;
			}
			if (num3 > num && num3 > num2)
			{
				result = Axis.Z;
			}
			return result;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004988 File Offset: 0x00002B88
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			Vector3 axisVectorToPoint = AxisTools.GetAxisVectorToPoint(t, worldPosition);
			if (axisVectorToPoint == Vector3.right)
			{
				return Axis.X;
			}
			if (axisVectorToPoint == Vector3.up)
			{
				return Axis.Y;
			}
			return Axis.Z;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000049BC File Offset: 0x00002BBC
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			Vector3 axisVectorToDirection = AxisTools.GetAxisVectorToDirection(t, direction);
			if (axisVectorToDirection == Vector3.right)
			{
				return Axis.X;
			}
			if (axisVectorToDirection == Vector3.up)
			{
				return Axis.Y;
			}
			return Axis.Z;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000049F0 File Offset: 0x00002BF0
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return AxisTools.GetAxisVectorToDirection(t, worldPosition - t.position);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004A04 File Offset: 0x00002C04
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return AxisTools.GetAxisVectorToDirection(t.rotation, direction);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004A14 File Offset: 0x00002C14
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			direction = direction.normalized;
			Vector3 result = Vector3.right;
			float num = Mathf.Abs(Vector3.Dot(r * Vector3.right, direction));
			float num2 = Mathf.Abs(Vector3.Dot(r * Vector3.up, direction));
			if (num2 > num)
			{
				result = Vector3.up;
			}
			float num3 = Mathf.Abs(Vector3.Dot(r * Vector3.forward, direction));
			if (num3 > num && num3 > num2)
			{
				result = Vector3.forward;
			}
			return result;
		}
	}
}
