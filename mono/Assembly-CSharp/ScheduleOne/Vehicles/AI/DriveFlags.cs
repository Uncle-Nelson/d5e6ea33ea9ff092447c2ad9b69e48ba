using System;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020007EB RID: 2027
	[Serializable]
	public class DriveFlags
	{
		// Token: 0x0600374B RID: 14155 RVA: 0x000E8ABC File Offset: 0x000E6CBC
		public void ResetFlags()
		{
			this.OverrideSpeed = false;
			this.OverriddenSpeed = 50f;
			this.OverriddenReverseSpeed = 10f;
			this.SpeedLimitMultiplier = 1f;
			this.IgnoreTrafficLights = false;
			this.UseRoads = true;
			this.StuckDetection = true;
			this.ObstacleMode = DriveFlags.EObstacleMode.Default;
			this.AutoBrakeAtDestination = true;
			this.TurnBasedSpeedReduction = true;
		}

		// Token: 0x040027E9 RID: 10217
		public bool OverrideSpeed;

		// Token: 0x040027EA RID: 10218
		public float OverriddenSpeed = 50f;

		// Token: 0x040027EB RID: 10219
		public float OverriddenReverseSpeed = 10f;

		// Token: 0x040027EC RID: 10220
		public float SpeedLimitMultiplier = 1f;

		// Token: 0x040027ED RID: 10221
		public bool IgnoreTrafficLights;

		// Token: 0x040027EE RID: 10222
		public bool UseRoads = true;

		// Token: 0x040027EF RID: 10223
		public bool StuckDetection = true;

		// Token: 0x040027F0 RID: 10224
		public DriveFlags.EObstacleMode ObstacleMode;

		// Token: 0x040027F1 RID: 10225
		public bool AutoBrakeAtDestination = true;

		// Token: 0x040027F2 RID: 10226
		public bool TurnBasedSpeedReduction = true;

		// Token: 0x020007EC RID: 2028
		public enum EObstacleMode
		{
			// Token: 0x040027F4 RID: 10228
			Default,
			// Token: 0x040027F5 RID: 10229
			IgnoreAll,
			// Token: 0x040027F6 RID: 10230
			IgnoreOnlySquishy
		}
	}
}
