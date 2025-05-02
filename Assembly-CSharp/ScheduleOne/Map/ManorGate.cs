using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C1E RID: 3102
	public class ManorGate : Gate
	{
		// Token: 0x06005718 RID: 22296 RVA: 0x0016E25E File Offset: 0x0016C45E
		protected virtual void Start()
		{
			this.SetIntercomActive(false);
			this.SetEnterable(false);
			base.InvokeRepeating("UpdateDetection", 0f, 0.25f);
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x0016E284 File Offset: 0x0016C484
		private void UpdateDetection()
		{
			bool flag = false;
			if (this.ExteriorVehicleDetector.AreAnyVehiclesOccupied())
			{
				flag = true;
			}
			if (this.ExteriorPlayerDetector.DetectedPlayers.Count > 0)
			{
				flag = true;
			}
			if (this.InteriorVehicleDetector.AreAnyVehiclesOccupied())
			{
				flag = true;
			}
			if (this.InteriorPlayerDetector.DetectedPlayers.Count > 0)
			{
				flag = true;
			}
			if (flag != base.IsOpen)
			{
				if (flag)
				{
					base.Open();
					return;
				}
				base.Close();
			}
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x0016E2F4 File Offset: 0x0016C4F4
		public void IntercomBuzzed()
		{
			this.SetIntercomActive(false);
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x0016E2FD File Offset: 0x0016C4FD
		public void SetEnterable(bool enterable)
		{
			this.ExteriorPlayerDetector.SetIgnoreNewCollisions(!enterable);
			this.ExteriorVehicleDetector.SetIgnoreNewCollisions(!enterable);
			this.ExteriorVehicleDetector.vehicles.Clear();
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x0016E32D File Offset: 0x0016C52D
		[Button]
		public void ActivateIntercom()
		{
			this.SetIntercomActive(true);
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x0016E336 File Offset: 0x0016C536
		public void SetIntercomActive(bool active)
		{
			this.intercomActive = active;
			this.UpdateIntercom();
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x0016E345 File Offset: 0x0016C545
		private void UpdateIntercom()
		{
			this.IntercomInt.SetInteractableState(this.intercomActive ? InteractableObject.EInteractableState.Default : InteractableObject.EInteractableState.Disabled);
			this.IntercomLight.enabled = this.intercomActive;
		}

		// Token: 0x04004078 RID: 16504
		[Header("References")]
		public InteractableObject IntercomInt;

		// Token: 0x04004079 RID: 16505
		public Light IntercomLight;

		// Token: 0x0400407A RID: 16506
		public VehicleDetector ExteriorVehicleDetector;

		// Token: 0x0400407B RID: 16507
		public PlayerDetector ExteriorPlayerDetector;

		// Token: 0x0400407C RID: 16508
		public VehicleDetector InteriorVehicleDetector;

		// Token: 0x0400407D RID: 16509
		public PlayerDetector InteriorPlayerDetector;

		// Token: 0x0400407E RID: 16510
		private bool intercomActive;
	}
}
