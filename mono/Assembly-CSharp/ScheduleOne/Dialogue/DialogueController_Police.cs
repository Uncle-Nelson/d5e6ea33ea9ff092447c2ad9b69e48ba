using System;
using ScheduleOne.Police;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006A4 RID: 1700
	public class DialogueController_Police : DialogueController
	{
		// Token: 0x06002F02 RID: 12034 RVA: 0x000C4CC5 File Offset: 0x000C2EC5
		protected override void Start()
		{
			base.Start();
			this.officer = (this.npc as PoliceOfficer);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x000C4CE0 File Offset: 0x000C2EE0
		public override bool CanStartDialogue()
		{
			return !this.officer.PursuitBehaviour.Active && !this.officer.VehiclePursuitBehaviour.Active && !this.officer.BodySearchBehaviour.Active && (!this.officer.CheckpointBehaviour.Active || !this.officer.CheckpointBehaviour.IsSearching) && base.CanStartDialogue();
		}

		// Token: 0x0400215E RID: 8542
		private PoliceOfficer officer;
	}
}
