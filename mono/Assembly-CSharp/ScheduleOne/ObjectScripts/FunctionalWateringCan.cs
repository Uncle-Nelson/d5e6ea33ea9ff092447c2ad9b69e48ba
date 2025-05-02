using System;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.PlayerTasks;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BEE RID: 3054
	public class FunctionalWateringCan : Pourable
	{
		// Token: 0x060055C2 RID: 21954 RVA: 0x00169510 File Offset: 0x00167710
		public void Setup(WateringCanInstance instance)
		{
			this.itemInstance = instance;
			this.autoSetCurrentQuantity = false;
			this.currentQuantity = this.itemInstance.CurrentFillAmount;
			this.Visuals.SetFillLevel(this.itemInstance.CurrentFillAmount / 15f);
			base.Rb.isKinematic = false;
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00169564 File Offset: 0x00167764
		protected override void PourAmount(float amount)
		{
			this.itemInstance.ChangeFillAmount(-amount);
			this.Visuals.SetFillLevel(this.itemInstance.CurrentFillAmount / 15f);
			base.PourAmount(amount);
		}

		// Token: 0x04003F76 RID: 16246
		public WateringCanVisuals Visuals;

		// Token: 0x04003F77 RID: 16247
		private WateringCanInstance itemInstance;
	}
}
