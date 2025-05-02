using System;
using ScheduleOne.Equipping;
using ScheduleOne.PlayerTasks.Tasks;

namespace ScheduleOne.ObjectScripts.Soil
{
	// Token: 0x02000BFE RID: 3070
	public class Equippable_Soil : Equippable_Pourable
	{
		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x0600566B RID: 22123 RVA: 0x0016B7BE File Offset: 0x001699BE
		// (set) Token: 0x0600566C RID: 22124 RVA: 0x0016B7C6 File Offset: 0x001699C6
		public override string InteractionLabel { get; set; } = "Pour soil";

		// Token: 0x0600566D RID: 22125 RVA: 0x0016B7D0 File Offset: 0x001699D0
		protected override bool CanPour(Pot pot, out string reason)
		{
			if (pot.SoilLevel >= pot.SoilCapacity)
			{
				reason = "Pot already full";
				return false;
			}
			if (!string.IsNullOrEmpty(pot.SoilID) && pot.SoilID != this.itemInstance.ID)
			{
				reason = "Soil type mismatch";
				return false;
			}
			return base.CanPour(pot, out reason);
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x0016B82A File Offset: 0x00169A2A
		protected override void StartPourTask(Pot pot)
		{
			new PourSoilTask(pot, this.itemInstance, this.PourablePrefab);
		}
	}
}
