using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007CE RID: 1998
	[RequireComponent(typeof(BoxCollider))]
	public class SpeedZone : MonoBehaviour
	{
		// Token: 0x060036AC RID: 13996 RVA: 0x000E631C File Offset: 0x000E451C
		public virtual void Awake()
		{
			SpeedZone.speedZones.Add(this);
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x000E632C File Offset: 0x000E452C
		public static List<SpeedZone> GetSpeedZones(Vector3 point)
		{
			List<SpeedZone> list = new List<SpeedZone>();
			for (int i = 0; i < SpeedZone.speedZones.Count; i++)
			{
				if (SpeedZone.speedZones[i].col.bounds.Contains(point))
				{
					list.Add(SpeedZone.speedZones[i]);
				}
			}
			return list;
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x000045B1 File Offset: 0x000027B1
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x000045B1 File Offset: 0x000027B1
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x04002730 RID: 10032
		public static List<SpeedZone> speedZones = new List<SpeedZone>();

		// Token: 0x04002731 RID: 10033
		public BoxCollider col;

		// Token: 0x04002732 RID: 10034
		public float speed = 20f;
	}
}
