using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D8 RID: 216
	[Serializable]
	public sealed class ColorGradingCurve
	{
		// Token: 0x0600037A RID: 890 RVA: 0x00014354 File Offset: 0x00012554
		public ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
		{
			this.curve = curve;
			this.m_ZeroValue = zeroValue;
			this.m_Loop = loop;
			this.m_Range = bounds.magnitude;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00014380 File Offset: 0x00012580
		public void Cache()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 2)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00014430 File Offset: 0x00012630
		public float Evaluate(float t)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(t);
			}
			return this.m_InternalLoopingCurve.Evaluate(t);
		}

		// Token: 0x04000475 RID: 1141
		public AnimationCurve curve;

		// Token: 0x04000476 RID: 1142
		[SerializeField]
		private bool m_Loop;

		// Token: 0x04000477 RID: 1143
		[SerializeField]
		private float m_ZeroValue;

		// Token: 0x04000478 RID: 1144
		[SerializeField]
		private float m_Range;

		// Token: 0x04000479 RID: 1145
		private AnimationCurve m_InternalLoopingCurve;
	}
}
