using System;
using FluffyUnderware.DevTools.Extensions;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200051E RID: 1310
	public class FootPatrolRoute : MonoBehaviour
	{
		// Token: 0x06001F55 RID: 8021 RVA: 0x0008042C File Offset: 0x0007E62C
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
			Gizmos.color = this.PathColor;
			for (int j = 0; j < this.Waypoints.Length - 1; j++)
			{
				if (!(this.Waypoints[j] == null))
				{
					Gizmos.DrawLine(this.Waypoints[j].position + Vector3.up * 0.5f, this.Waypoints[j + 1].position + Vector3.up * 0.5f);
				}
			}
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0008053D File Offset: 0x0007E73D
		private void OnValidate()
		{
			this.UpdateWaypoints();
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00080545 File Offset: 0x0007E745
		private void UpdateWaypoints()
		{
			this.Waypoints = base.transform.GetComponentsInChildren<Transform>();
			this.Waypoints = ArrayExt.Remove<Transform>(this.Waypoints, base.transform);
		}

		// Token: 0x04001877 RID: 6263
		[Header("Settings")]
		public string RouteName = "Foot patrol route";

		// Token: 0x04001878 RID: 6264
		public Color PathColor = Color.red;

		// Token: 0x04001879 RID: 6265
		public Transform[] Waypoints;

		// Token: 0x0400187A RID: 6266
		public int StartWaypointIndex;
	}
}
