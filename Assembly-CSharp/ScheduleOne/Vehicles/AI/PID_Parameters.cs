using System;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020007FF RID: 2047
	[Serializable]
	public struct PID_Parameters
	{
		// Token: 0x06003793 RID: 14227 RVA: 0x000EA453 File Offset: 0x000E8653
		public PID_Parameters(float P, float I, float D)
		{
			this.P = P;
			this.I = I;
			this.D = D;
		}

		// Token: 0x04002840 RID: 10304
		public float P;

		// Token: 0x04002841 RID: 10305
		public float I;

		// Token: 0x04002842 RID: 10306
		public float D;
	}
}
