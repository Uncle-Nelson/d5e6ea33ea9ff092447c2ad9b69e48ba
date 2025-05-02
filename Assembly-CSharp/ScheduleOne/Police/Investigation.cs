using System;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Police
{
	// Token: 0x02000331 RID: 817
	public class Investigation
	{
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0004DF8E File Offset: 0x0004C18E
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x0004DF96 File Offset: 0x0004C196
		public float CurrentProgress { get; protected set; }

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0004DF9F File Offset: 0x0004C19F
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x0004DFA7 File Offset: 0x0004C1A7
		public Player Target { get; protected set; }

		// Token: 0x060011EC RID: 4588 RVA: 0x0004DFB0 File Offset: 0x0004C1B0
		public Investigation(Player target)
		{
			this.Target = target;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0004DFBF File Offset: 0x0004C1BF
		public void ChangeProgress(float progress)
		{
			this.CurrentProgress += progress;
		}
	}
}
