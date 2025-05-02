using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020007ED RID: 2029
	[RequireComponent(typeof(BoxCollider))]
	public class FunnelZone : MonoBehaviour
	{
		// Token: 0x0600374D RID: 14157 RVA: 0x000E8B6C File Offset: 0x000E6D6C
		protected virtual void Awake()
		{
			FunnelZone.funnelZones.Add(this);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x000E8B7C File Offset: 0x000E6D7C
		public static FunnelZone GetFunnelZone(Vector3 point)
		{
			for (int i = 0; i < FunnelZone.funnelZones.Count; i++)
			{
				if (FunnelZone.funnelZones[i].col.bounds.Contains(point))
				{
					return FunnelZone.funnelZones[i];
				}
			}
			return null;
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x000E8BCC File Offset: 0x000E6DCC
		private void OnDrawGizmos()
		{
			Gizmos.color = new Color(0.5f, 0.5f, 1f, 0.5f);
			Gizmos.DrawCube(base.transform.TransformPoint(this.col.center), new Vector3(this.col.size.x, this.col.size.y, this.col.size.z));
			Gizmos.DrawLine(base.transform.position, this.entryPoint.position);
		}

		// Token: 0x040027F7 RID: 10231
		public static List<FunnelZone> funnelZones = new List<FunnelZone>();

		// Token: 0x040027F8 RID: 10232
		public BoxCollider col;

		// Token: 0x040027F9 RID: 10233
		public Transform entryPoint;
	}
}
