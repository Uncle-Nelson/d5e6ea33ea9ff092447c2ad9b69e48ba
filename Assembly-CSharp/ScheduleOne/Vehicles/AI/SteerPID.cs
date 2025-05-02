using System;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020007FE RID: 2046
	public class SteerPID
	{
		// Token: 0x06003790 RID: 14224 RVA: 0x000EA3E4 File Offset: 0x000E85E4
		public float GetNewValue(float error, PID_Parameters pid_parameters)
		{
			float num = -pid_parameters.P * error;
			this.error_sum = SteerPID.AddValueToAverage(this.error_sum, Time.deltaTime * error, 1000f);
			float num2 = num - pid_parameters.I * this.error_sum;
			float num3 = (error - this.error_old) / Time.deltaTime;
			float result = num2 - pid_parameters.D * num3;
			this.error_old = error;
			return result;
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x000EA444 File Offset: 0x000E8644
		public static float AddValueToAverage(float oldAverage, float valueToAdd, float count)
		{
			return (oldAverage * count + valueToAdd) / (count + 1f);
		}

		// Token: 0x0400283E RID: 10302
		private float error_old;

		// Token: 0x0400283F RID: 10303
		private float error_sum;
	}
}
