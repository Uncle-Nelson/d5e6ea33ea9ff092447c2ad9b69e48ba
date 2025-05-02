using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000132 RID: 306
	[Serializable]
	public struct MinMaxRangeFloat : IEquatable<MinMaxRangeFloat>
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00019517 File Offset: 0x00017717
		public float minValue
		{
			get
			{
				return this.m_MinValue;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0001951F File Offset: 0x0001771F
		public float maxValue
		{
			get
			{
				return this.m_MaxValue;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00019527 File Offset: 0x00017727
		public float randomValue
		{
			get
			{
				return Random.Range(this.minValue, this.maxValue);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001953A File Offset: 0x0001773A
		public Vector2 asVector2
		{
			get
			{
				return new Vector2(this.minValue, this.maxValue);
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0001954D File Offset: 0x0001774D
		public float GetLerpedValue(float lerp01)
		{
			return Mathf.Lerp(this.minValue, this.maxValue, lerp01);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00019561 File Offset: 0x00017761
		public MinMaxRangeFloat(float min, float max)
		{
			this.m_MinValue = min;
			this.m_MaxValue = max;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00019574 File Offset: 0x00017774
		public override bool Equals(object obj)
		{
			if (obj is MinMaxRangeFloat)
			{
				MinMaxRangeFloat other = (MinMaxRangeFloat)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00019599 File Offset: 0x00017799
		public bool Equals(MinMaxRangeFloat other)
		{
			return this.m_MinValue == other.m_MinValue && this.m_MaxValue == other.m_MaxValue;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000195BC File Offset: 0x000177BC
		public override int GetHashCode()
		{
			return new ValueTuple<float, float>(this.m_MinValue, this.m_MaxValue).GetHashCode();
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000195E8 File Offset: 0x000177E8
		public static bool operator ==(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000195F2 File Offset: 0x000177F2
		public static bool operator !=(MinMaxRangeFloat lhs, MinMaxRangeFloat rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000684 RID: 1668
		[SerializeField]
		private float m_MinValue;

		// Token: 0x04000685 RID: 1669
		[SerializeField]
		private float m_MaxValue;
	}
}
