using System;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000536 RID: 1334
	public class VehiclePatrolRoute : MonoBehaviour
	{
		// Token: 0x06002077 RID: 8311 RVA: 0x000855B8 File Offset: 0x000837B8
		private void OnDrawGizmos()
		{
			Gizmos.color = Color.green;
			Gizmos.DrawWireSphere(base.transform.position + Vector3.up * 0.5f, 0.5f);
			Gizmos.color = Color.yellow;
			for (int i = 0; i < this.Waypoints.Length; i++)
			{
				if (!(this.Waypoints[i] == null))
				{
					Gizmos.DrawWireSphere(this.Waypoints[i].position + Vector3.up * 0.5f, 0.5f);
				}
			}
			Gizmos.color = Color.red;
			for (int j = 0; j < this.Waypoints.Length - 1; j++)
			{
				if (!(this.Waypoints[j] == null))
				{
					Gizmos.DrawLine(this.Waypoints[j].position + Vector3.up * 0.5f, this.Waypoints[j + 1].position + Vector3.up * 0.5f);
				}
			}
		}

		// Token: 0x04001915 RID: 6421
		[Header("Settings")]
		public string RouteName = "Vehicle patrol route";

		// Token: 0x04001916 RID: 6422
		public Transform[] Waypoints;

		// Token: 0x04001917 RID: 6423
		public int StartWaypointIndex;
	}
}
