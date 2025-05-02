using System;

namespace ScheduleOne.Persistence.Datas.Characters
{
	// Token: 0x02000440 RID: 1088
	public class ThomasData : NPCData
	{
		// Token: 0x060015BD RID: 5565 RVA: 0x00060581 File Offset: 0x0005E781
		public ThomasData(string id, bool meetingReminderSent, bool handoverReminderSent) : base(id)
		{
			this.MeetingReminderSent = meetingReminderSent;
			this.HandoverReminderSent = handoverReminderSent;
		}

		// Token: 0x04001484 RID: 5252
		public bool MeetingReminderSent;

		// Token: 0x04001485 RID: 5253
		public bool HandoverReminderSent;
	}
}
