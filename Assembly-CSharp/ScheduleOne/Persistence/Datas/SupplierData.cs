using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000412 RID: 1042
	[Serializable]
	public class SupplierData : NPCData
	{
		// Token: 0x06001587 RID: 5511 RVA: 0x0005FD7C File Offset: 0x0005DF7C
		public SupplierData(string id, int _timeSinceMeetingStart, int _timeSinceLastMeetingEnd, float _debt, int _minsUntilDeadDropReady, StringIntPair[] _deaddropItems, bool _debtReminderSent) : base(id)
		{
			this.timeSinceMeetingStart = _timeSinceMeetingStart;
			this.timeSinceLastMeetingEnd = _timeSinceLastMeetingEnd;
			this.debt = _debt;
			this.minsUntilDeadDropReady = _minsUntilDeadDropReady;
			this.deaddropItems = _deaddropItems;
			this.debtReminderSent = _debtReminderSent;
		}

		// Token: 0x040013F7 RID: 5111
		public int timeSinceMeetingStart;

		// Token: 0x040013F8 RID: 5112
		public int timeSinceLastMeetingEnd;

		// Token: 0x040013F9 RID: 5113
		public float debt;

		// Token: 0x040013FA RID: 5114
		public int minsUntilDeadDropReady;

		// Token: 0x040013FB RID: 5115
		public StringIntPair[] deaddropItems;

		// Token: 0x040013FC RID: 5116
		public bool debtReminderSent;
	}
}
