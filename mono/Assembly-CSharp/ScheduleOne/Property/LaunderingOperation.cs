using System;

namespace ScheduleOne.Property
{
	// Token: 0x02000811 RID: 2065
	public class LaunderingOperation
	{
		// Token: 0x0600381B RID: 14363 RVA: 0x000EDD6F File Offset: 0x000EBF6F
		public LaunderingOperation(Business _business, float _amount, int _minutesSinceStarted)
		{
			this.business = _business;
			this.amount = _amount;
			this.minutesSinceStarted = _minutesSinceStarted;
		}

		// Token: 0x040028D6 RID: 10454
		public Business business;

		// Token: 0x040028D7 RID: 10455
		public float amount;

		// Token: 0x040028D8 RID: 10456
		public int minutesSinceStarted;

		// Token: 0x040028D9 RID: 10457
		public int completionTime_Minutes = 1440;
	}
}
