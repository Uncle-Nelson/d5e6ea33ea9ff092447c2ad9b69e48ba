using System;

namespace ScheduleOne.UI
{
	// Token: 0x02000A29 RID: 2601
	public interface IPostSleepEvent
	{
		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600462A RID: 17962
		bool IsRunning { get; }

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600462B RID: 17963
		int Order { get; }

		// Token: 0x0600462C RID: 17964
		void StartEvent();
	}
}
