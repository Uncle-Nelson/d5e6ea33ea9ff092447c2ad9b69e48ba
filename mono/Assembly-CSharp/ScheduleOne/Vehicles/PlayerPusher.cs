using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007CD RID: 1997
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(BoxCollider))]
	public class PlayerPusher : MonoBehaviour
	{
		// Token: 0x060036A8 RID: 13992 RVA: 0x000E61A6 File Offset: 0x000E43A6
		private void Awake()
		{
			this.veh = base.GetComponentInParent<LandVehicle>();
			this.collider = base.GetComponent<Collider>();
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Ignore Raycast"));
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x000E61D5 File Offset: 0x000E43D5
		private void FixedUpdate()
		{
			this.collider.enabled = !this.veh.Rb.isKinematic;
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x000E61F8 File Offset: 0x000E43F8
		private void OnTriggerStay(Collider other)
		{
			if (this.veh.speed_Kmh < this.MinSpeedToPush)
			{
				return;
			}
			Player componentInParent = other.GetComponentInParent<Player>();
			if (componentInParent != null && componentInParent == Player.Local && componentInParent.CurrentVehicle == null)
			{
				Vector3 normalized = Vector3.Project((componentInParent.transform.position - base.transform.position).normalized, base.transform.right).normalized;
				float d = this.MinPushForce + Mathf.Clamp((this.veh.speed_Kmh - this.MinSpeedToPush) / this.MaxPushSpeed, 0f, 1f) * (this.MaxPushSpeed - this.MinPushForce);
				PlayerSingleton<PlayerMovement>.Instance.Controller.Move(normalized * d * Time.fixedDeltaTime);
			}
		}

		// Token: 0x0400272A RID: 10026
		private LandVehicle veh;

		// Token: 0x0400272B RID: 10027
		[Header("Settings")]
		public float MinSpeedToPush = 3f;

		// Token: 0x0400272C RID: 10028
		public float MaxPushSpeed = 20f;

		// Token: 0x0400272D RID: 10029
		public float MinPushForce = 0.5f;

		// Token: 0x0400272E RID: 10030
		public float MaxPushForce = 5f;

		// Token: 0x0400272F RID: 10031
		private Collider collider;
	}
}
