using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007C1 RID: 1985
	public class ForkliftCamera : VehicleCamera
	{
		// Token: 0x060035CA RID: 13770 RVA: 0x000E2108 File Offset: 0x000E0308
		protected override void Update()
		{
			base.Update();
			this.forkliftCamActive = false;
			if (this.vehicle.localPlayerIsDriver && Input.GetKey(KeyCode.LeftShift))
			{
				this.forkliftCamActive = true;
			}
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x000E2138 File Offset: 0x000E0338
		protected override void LateUpdate()
		{
			base.LateUpdate();
			this.guidanceLight.enabled = false;
			if (this.vehicle.localPlayerIsDriver && this.forkliftCamActive)
			{
				PlayerSingleton<PlayerCamera>.Instance.transform.position = this.forkCamPos.position;
				PlayerSingleton<PlayerCamera>.Instance.transform.rotation = this.forkCamPos.rotation;
				this.guidanceLight.enabled = true;
			}
		}

		// Token: 0x040026AB RID: 9899
		[Header("Forklift References")]
		[SerializeField]
		protected Transform forkCamPos;

		// Token: 0x040026AC RID: 9900
		[SerializeField]
		protected Light guidanceLight;

		// Token: 0x040026AD RID: 9901
		protected bool forkliftCamActive;
	}
}
