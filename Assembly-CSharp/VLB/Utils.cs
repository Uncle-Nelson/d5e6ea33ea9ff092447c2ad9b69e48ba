using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000154 RID: 340
	public static class Utils
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x0001CF35 File Offset: 0x0001B135
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return fallOffEnd * Mathf.Tan(spotAngle * 0.017453292f * 0.5f);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0001CF4B File Offset: 0x0001B14B
		public static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
		{
			return Mathf.Atan2(coneRadiusEnd, fallOffEnd) * 57.29578f * 2f;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001CF60 File Offset: 0x0001B160
		public static void Swap<T>(ref T a, ref T b)
		{
			T t = a;
			a = b;
			b = t;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001CF87 File Offset: 0x0001B187
		public static string GetPath(Transform current)
		{
			if (current.parent == null)
			{
				return "/" + current.name;
			}
			return Utils.GetPath(current.parent) + "/" + current.name;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0001CFC3 File Offset: 0x0001B1C3
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return new GameObject(name, new Type[]
			{
				typeof(T)
			}).GetComponent<T>();
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001CFE4 File Offset: 0x0001B1E4
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			T t = self.GetComponent<T>();
			if (t == null)
			{
				t = self.AddComponent<T>();
			}
			return t;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001D00E File Offset: 0x0001B20E
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return self.gameObject.GetOrAddComponent<T>();
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0001D01C File Offset: 0x0001B21C
		public static void ForeachComponentsInAnyChildrenOnly<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
			foreach (T t in self.GetComponentsInChildren<T>(includeInactive))
			{
				if (t.gameObject != self)
				{
					lambda(t);
				}
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0001D064 File Offset: 0x0001B264
		public static void ForeachComponentsInDirectChildrenOnly<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
			foreach (T t in self.GetComponentsInChildren<T>(includeInactive))
			{
				if (t.transform.parent == self.transform)
				{
					lambda(t);
				}
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001D0B4 File Offset: 0x0001B2B4
		public static void SetupDepthCamera(Camera depthCamera, float coneApexOffsetZ, float maxGeometryDistance, float coneRadiusStart, float coneRadiusEnd, Vector3 beamLocalForward, Vector3 lossyScale, bool isScalable, Quaternion beamInternalLocalRotation, bool shouldScaleMinNearClipPlane)
		{
			if (!isScalable)
			{
				lossyScale.x = (lossyScale.y = 1f);
			}
			bool flag = coneApexOffsetZ >= 0f;
			float num = Mathf.Max(coneApexOffsetZ, 0f);
			depthCamera.orthographic = !flag;
			depthCamera.transform.localPosition = beamLocalForward * -num;
			Quaternion quaternion = beamInternalLocalRotation;
			if (Mathf.Sign(lossyScale.z) < 0f)
			{
				quaternion *= Quaternion.Euler(0f, 180f, 0f);
			}
			depthCamera.transform.localRotation = quaternion;
			if (!Mathf.Approximately(lossyScale.y * lossyScale.z, 0f))
			{
				float num2 = flag ? 0.1f : 0f;
				float num3 = Mathf.Abs(lossyScale.z);
				depthCamera.nearClipPlane = Mathf.Max(num * num3, num2 * (shouldScaleMinNearClipPlane ? num3 : 1f));
				depthCamera.farClipPlane = (maxGeometryDistance + num * (isScalable ? 1f : num3)) * (isScalable ? num3 : 1f);
				depthCamera.aspect = Mathf.Abs(lossyScale.x / lossyScale.y);
				if (flag)
				{
					float fieldOfView = Mathf.Atan2(coneRadiusEnd * Mathf.Abs(lossyScale.y), depthCamera.farClipPlane) * 57.29578f * 2f;
					depthCamera.fieldOfView = fieldOfView;
					return;
				}
				depthCamera.orthographicSize = coneRadiusStart * lossyScale.y;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0001D22E File Offset: 0x0001B42E
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return ((int)mask & (int)flags) == (int)flags;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001D248 File Offset: 0x0001B448
		public static Vector3 Divide(this Vector3 aVector, Vector3 scale)
		{
			if (Mathf.Approximately(scale.x * scale.y * scale.z, 0f))
			{
				return Vector3.zero;
			}
			return new Vector3(aVector.x / scale.x, aVector.y / scale.y, aVector.z / scale.z);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0001D2A7 File Offset: 0x0001B4A7
		public static Vector2 xy(this Vector3 aVector)
		{
			return new Vector2(aVector.x, aVector.y);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0001D2BA File Offset: 0x0001B4BA
		public static Vector2 xz(this Vector3 aVector)
		{
			return new Vector2(aVector.x, aVector.z);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001D2CD File Offset: 0x0001B4CD
		public static Vector2 yz(this Vector3 aVector)
		{
			return new Vector2(aVector.y, aVector.z);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
		public static Vector2 yx(this Vector3 aVector)
		{
			return new Vector2(aVector.y, aVector.x);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001D2F3 File Offset: 0x0001B4F3
		public static Vector2 zx(this Vector3 aVector)
		{
			return new Vector2(aVector.z, aVector.x);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001D306 File Offset: 0x0001B506
		public static Vector2 zy(this Vector3 aVector)
		{
			return new Vector2(aVector.z, aVector.y);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001D319 File Offset: 0x0001B519
		public static bool Approximately(this float a, float b, float epsilon = 1E-05f)
		{
			return Mathf.Abs(a - b) < epsilon;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001D326 File Offset: 0x0001B526
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return Vector2.SqrMagnitude(a - b) < epsilon;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0001D337 File Offset: 0x0001B537
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return Vector3.SqrMagnitude(a - b) < epsilon;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001D348 File Offset: 0x0001B548
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return Vector4.SqrMagnitude(a - b) < epsilon;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001D359 File Offset: 0x0001B559
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return new Vector4(vec3.x, vec3.y, vec3.z, w);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001D373 File Offset: 0x0001B573
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return normalizedNormal.AsVector4(-Vector3.Dot(normalizedNormal, pt));
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001D383 File Offset: 0x0001B583
		public static float GetVolumeCubic(this Bounds self)
		{
			return self.size.x * self.size.y * self.size.z;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0001D3AC File Offset: 0x0001B5AC
		public static float GetMaxArea2D(this Bounds self)
		{
			return Mathf.Max(Mathf.Max(self.size.x * self.size.y, self.size.y * self.size.z), self.size.x * self.size.z);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0001D40E File Offset: 0x0001B60E
		public static Color Opaque(this Color self)
		{
			return new Color(self.r, self.g, self.b, 1f);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001D42C File Offset: 0x0001B62C
		public static Color ComputeComplementaryColor(this Color self, bool blackAndWhite)
		{
			if (!blackAndWhite)
			{
				return new Color(1f - self.r, 1f - self.g, 1f - self.b);
			}
			if ((double)self.r * 0.299 + (double)self.g * 0.587 + (double)self.b * 0.114 <= 0.729411780834198)
			{
				return Color.white;
			}
			return Color.black;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001D4B1 File Offset: 0x0001B6B1
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			plane.distance += Vector3.Dot(translation.normalized, plane.normal) * translation.magnitude;
			return plane;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001D4DD File Offset: 0x0001B6DD
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return point - plane.GetDistanceToPoint(point) * plane.normal;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001D4F9 File Offset: 0x0001B6F9
		public static bool IsAlmostZero(float f)
		{
			return Mathf.Abs(f) < 0.001f;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0001D508 File Offset: 0x0001B708
		public static bool IsValid(this Plane plane)
		{
			return plane.normal.sqrMagnitude > 0.5f;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0001D52B File Offset: 0x0001B72B
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
			if (enabled)
			{
				mat.EnableKeyword(name);
				return;
			}
			mat.DisableKeyword(name);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001D53F File Offset: 0x0001B73F
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
			if (enabled)
			{
				Shader.EnableKeyword(name);
				return;
			}
			Shader.DisableKeyword(name);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0001D554 File Offset: 0x0001B754
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			Matrix4x4 result = default(Matrix4x4);
			for (int i = 0; i < 16; i++)
			{
				Color color = self.Evaluate(Mathf.Clamp01((float)i / 15f));
				result[i] = color.PackToFloat(floatPackingPrecision);
			}
			return result;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0001D59C File Offset: 0x0001B79C
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			Color[] array = new Color[samplesCount];
			for (int i = 0; i < samplesCount; i++)
			{
				array[i] = self.Evaluate(Mathf.Clamp01((float)i / (float)(samplesCount - 1)));
			}
			return array;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0001D5D6 File Offset: 0x0001B7D6
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return new Vector4(Mathf.Floor(vec.x), Mathf.Floor(vec.y), Mathf.Floor(vec.z), Mathf.Floor(vec.w));
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001D60C File Offset: 0x0001B80C
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			Vector4 vector = Utils.Vector4_Floor(color * (float)(floatPackingPrecision - 1));
			return 0f + vector.x * (float)floatPackingPrecision * (float)floatPackingPrecision * (float)floatPackingPrecision + vector.y * (float)floatPackingPrecision * (float)floatPackingPrecision + vector.z * (float)floatPackingPrecision + vector.w;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0001D661 File Offset: 0x0001B861
		public static Utils.FloatPackingPrecision GetFloatPackingPrecision()
		{
			if (Utils.ms_FloatPackingPrecision == Utils.FloatPackingPrecision.Undef)
			{
				Utils.ms_FloatPackingPrecision = ((SystemInfo.graphicsShaderLevel >= 35) ? Utils.FloatPackingPrecision.High : Utils.FloatPackingPrecision.Low);
			}
			return Utils.ms_FloatPackingPrecision;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001D682 File Offset: 0x0001B882
		public static bool HasAtLeastOneFlag(this Enum mask, Enum flags)
		{
			return ((int)mask & (int)flags) != 0;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000045B1 File Offset: 0x000027B1
		public static void MarkCurrentSceneDirty()
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000045B1 File Offset: 0x000027B1
		public static void MarkObjectDirty(Object obj)
		{
		}

		// Token: 0x04000759 RID: 1881
		private const float kEpsilon = 1E-05f;

		// Token: 0x0400075A RID: 1882
		private static Utils.FloatPackingPrecision ms_FloatPackingPrecision;

		// Token: 0x0400075B RID: 1883
		private const int kFloatPackingHighMinShaderLevel = 35;

		// Token: 0x02000155 RID: 341
		public enum FloatPackingPrecision
		{
			// Token: 0x0400075D RID: 1885
			High = 64,
			// Token: 0x0400075E RID: 1886
			Low = 8,
			// Token: 0x0400075F RID: 1887
			Undef = 0
		}
	}
}
