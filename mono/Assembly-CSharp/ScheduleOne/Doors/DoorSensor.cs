using System;
using System.Collections.Generic;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x0200068B RID: 1675
	[RequireComponent(typeof(Rigidbody))]
	public class DoorSensor : MonoBehaviour
	{
		// Token: 0x06002E77 RID: 11895 RVA: 0x000C2F11 File Offset: 0x000C1111
		private void Awake()
		{
			this.collider = base.GetComponent<Collider>();
			base.InvokeRepeating("UpdateCollider", 0f, 1f);
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000C2F34 File Offset: 0x000C1134
		private void UpdateCollider()
		{
			if (PlayerSingleton<PlayerCamera>.Instance == null)
			{
				return;
			}
			float num = Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, base.transform.position);
			if (InstanceFinder.IsServer)
			{
				Player.GetClosestPlayer(base.transform.position, out num, null);
			}
			this.collider.enabled = (num < 30f);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000C2FA0 File Offset: 0x000C11A0
		private void OnTriggerStay(Collider other)
		{
			if (this.exclude.Contains(other))
			{
				return;
			}
			NPC componentInParent = other.GetComponentInParent<NPC>();
			if (componentInParent != null && componentInParent.IsConscious && !componentInParent.Avatar.Ragdolled && componentInParent.CanOpenDoors)
			{
				this.Door.NPCVicinityDetected(this.DetectorSide);
				return;
			}
			if (other.GetComponentInParent<Player>() != null)
			{
				this.Door.PlayerVicinityDetected(this.DetectorSide);
				return;
			}
			this.exclude.Add(other);
		}

		// Token: 0x040020F5 RID: 8437
		public const float ActivationDistance = 30f;

		// Token: 0x040020F6 RID: 8438
		public EDoorSide DetectorSide = EDoorSide.Exterior;

		// Token: 0x040020F7 RID: 8439
		public DoorController Door;

		// Token: 0x040020F8 RID: 8440
		private List<Collider> exclude = new List<Collider>();

		// Token: 0x040020F9 RID: 8441
		private Collider collider;
	}
}
