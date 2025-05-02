using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000877 RID: 2167
	public class SmoothedVelocityCalculator : MonoBehaviour
	{
		// Token: 0x06003AE5 RID: 15077 RVA: 0x000F80C7 File Offset: 0x000F62C7
		private void Start()
		{
			this.lastFramePosition = base.transform.position;
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x000F80DC File Offset: 0x000F62DC
		protected virtual void FixedUpdate()
		{
			if (this.zeroOut)
			{
				this.Velocity = Vector3.zero;
				return;
			}
			Vector3 item = (base.transform.position - this.lastFramePosition) / Time.fixedDeltaTime;
			if (item.magnitude <= this.MaxReasonableVelocity)
			{
				this.VelocityHistory.Add(new Tuple<Vector3, float>(item, Time.timeSinceLevelLoad));
			}
			if (this.VelocityHistory.Count > this.maxSamples)
			{
				this.VelocityHistory.RemoveAt(0);
			}
			this.Velocity = this.GetAverageVelocity();
			this.lastFramePosition = base.transform.position;
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x000F8180 File Offset: 0x000F6380
		private Vector3 GetAverageVelocity()
		{
			Vector3 a = Vector3.zero;
			int num = 0;
			int num2 = this.VelocityHistory.Count - 1;
			while (num2 >= 0 && Time.timeSinceLevelLoad - this.VelocityHistory[num2].Item2 <= this.SampleLength)
			{
				a += this.VelocityHistory[num2].Item1;
				num++;
				num2--;
			}
			if (num == 0)
			{
				return Vector3.zero;
			}
			return a / (float)num;
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x000F81FB File Offset: 0x000F63FB
		public void FlushBuffer()
		{
			this.VelocityHistory.Clear();
			this.Velocity = Vector3.zero;
			this.lastFramePosition = base.transform.position;
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x000F8224 File Offset: 0x000F6424
		public void ZeroOut(float duration)
		{
			SmoothedVelocityCalculator.<>c__DisplayClass11_0 CS$<>8__locals1 = new SmoothedVelocityCalculator.<>c__DisplayClass11_0();
			CS$<>8__locals1.duration = duration;
			CS$<>8__locals1.<>4__this = this;
			this.zeroOut = true;
			base.StartCoroutine(CS$<>8__locals1.<ZeroOut>g__Routine|0());
		}

		// Token: 0x04002A65 RID: 10853
		public Vector3 Velocity = Vector3.zero;

		// Token: 0x04002A66 RID: 10854
		[Header("Settings")]
		public float SampleLength = 0.2f;

		// Token: 0x04002A67 RID: 10855
		public float MaxReasonableVelocity = 25f;

		// Token: 0x04002A68 RID: 10856
		private List<Tuple<Vector3, float>> VelocityHistory = new List<Tuple<Vector3, float>>();

		// Token: 0x04002A69 RID: 10857
		private int maxSamples = 20;

		// Token: 0x04002A6A RID: 10858
		private Vector3 lastFramePosition = Vector3.zero;

		// Token: 0x04002A6B RID: 10859
		private bool zeroOut;
	}
}
