using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C13 RID: 3091
	public class AutoshopAccessZone : NPCPresenceAccessZone
	{
		// Token: 0x060056D8 RID: 22232 RVA: 0x0016D43E File Offset: 0x0016B63E
		public override void SetIsOpen(bool open)
		{
			base.SetIsOpen(open);
			if (this.rollerDoorOpen != open)
			{
				this.rollerDoorOpen = open;
				this.RollerDoorAnim.Play(this.rollerDoorOpen ? "Roller door open" : "Roller door close");
			}
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x0016D478 File Offset: 0x0016B678
		protected override void MinPass()
		{
			if (this.TargetNPC == null)
			{
				return;
			}
			this.SetIsOpen(this.DetectionZone.bounds.Contains(this.TargetNPC.Avatar.CenterPoint) || this.VehicleDetection.closestVehicle != null);
		}

		// Token: 0x0400403D RID: 16445
		public Animation RollerDoorAnim;

		// Token: 0x0400403E RID: 16446
		public VehicleDetector VehicleDetection;

		// Token: 0x0400403F RID: 16447
		private bool rollerDoorOpen = true;
	}
}
