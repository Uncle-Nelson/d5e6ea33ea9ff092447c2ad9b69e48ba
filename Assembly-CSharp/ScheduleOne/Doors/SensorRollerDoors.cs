using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x0200068F RID: 1679
	public class SensorRollerDoors : RollerDoor
	{
		// Token: 0x06002E8B RID: 11915 RVA: 0x000C32B0 File Offset: 0x000C14B0
		protected virtual void Update()
		{
			if (!this.CanOpen())
			{
				if (base.IsOpen)
				{
					base.Close();
				}
				return;
			}
			if (this.Detector.vehicles.Count <= 0)
			{
				base.Close();
				return;
			}
			if (!this.DetectPlayerOccupiedVehiclesOnly || this.ClipDetector.vehicles.Count > 0)
			{
				base.Open();
				return;
			}
			for (int i = 0; i < this.Detector.vehicles.Count; i++)
			{
				if (this.Detector.vehicles[i].DriverPlayer != null)
				{
					base.Open();
					return;
				}
			}
			base.Close();
		}

		// Token: 0x0400210B RID: 8459
		[Header("References")]
		public VehicleDetector Detector;

		// Token: 0x0400210C RID: 8460
		public VehicleDetector ClipDetector;

		// Token: 0x0400210D RID: 8461
		[Header("Settings")]
		public bool DetectPlayerOccupiedVehiclesOnly = true;
	}
}
