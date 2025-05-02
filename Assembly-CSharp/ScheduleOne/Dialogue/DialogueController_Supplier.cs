using System;
using ScheduleOne.Economy;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006A9 RID: 1705
	public class DialogueController_Supplier : DialogueController
	{
		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000C5091 File Offset: 0x000C3291
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x000C5099 File Offset: 0x000C3299
		public Supplier Supplier { get; private set; }

		// Token: 0x06002F13 RID: 12051 RVA: 0x000C50A2 File Offset: 0x000C32A2
		protected override void Start()
		{
			base.Start();
			this.Supplier = (this.npc as Supplier);
		}
	}
}
