using System;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006F4 RID: 1780
	[Serializable]
	public class PID
	{
		// Token: 0x0600306C RID: 12396 RVA: 0x000C9B65 File Offset: 0x000C7D65
		public PID(float pFactor, float iFactor, float dFactor)
		{
			this.pFactor = pFactor;
			this.iFactor = iFactor;
			this.dFactor = dFactor;
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x000C9B84 File Offset: 0x000C7D84
		public float Update(float setpoint, float actual, float timeFrame)
		{
			float num = setpoint - actual;
			this.integral += num * timeFrame;
			float num2 = (num - this.lastError) / timeFrame;
			this.lastError = num;
			return num * this.pFactor + this.integral * this.iFactor + num2 * this.dFactor;
		}

		// Token: 0x04002268 RID: 8808
		public float pFactor;

		// Token: 0x04002269 RID: 8809
		public float iFactor;

		// Token: 0x0400226A RID: 8810
		public float dFactor;

		// Token: 0x0400226B RID: 8811
		private float integral;

		// Token: 0x0400226C RID: 8812
		private float lastError;
	}
}
