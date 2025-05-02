using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007DD RID: 2013
	public class VehicleRecoveryPoint : MonoBehaviour
	{
		// Token: 0x06003710 RID: 14096 RVA: 0x000E7B21 File Offset: 0x000E5D21
		protected virtual void Awake()
		{
			VehicleRecoveryPoint.recoveryPoints.Add(this);
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x000E7B30 File Offset: 0x000E5D30
		public static VehicleRecoveryPoint GetClosestRecoveryPoint(Vector3 pos)
		{
			VehicleRecoveryPoint vehicleRecoveryPoint = null;
			for (int i = 0; i < VehicleRecoveryPoint.recoveryPoints.Count; i++)
			{
				if (vehicleRecoveryPoint == null || Vector3.Distance(VehicleRecoveryPoint.recoveryPoints[i].transform.position, pos) < Vector3.Distance(vehicleRecoveryPoint.transform.position, pos))
				{
					vehicleRecoveryPoint = VehicleRecoveryPoint.recoveryPoints[i];
				}
			}
			return vehicleRecoveryPoint;
		}

		// Token: 0x04002789 RID: 10121
		public static List<VehicleRecoveryPoint> recoveryPoints = new List<VehicleRecoveryPoint>();
	}
}
