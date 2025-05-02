using System;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;

namespace ScheduleOne.Tools
{
	// Token: 0x0200086E RID: 2158
	public class PlayerSmoothedVelocityCalculator : SmoothedVelocityCalculator
	{
		// Token: 0x06003ACE RID: 15054 RVA: 0x000F7968 File Offset: 0x000F5B68
		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (this.Player.CurrentVehicle != null)
			{
				this.Velocity = this.Player.CurrentVehicle.GetComponent<LandVehicle>().VelocityCalculator.Velocity;
			}
		}

		// Token: 0x04002A4D RID: 10829
		public Player Player;
	}
}
