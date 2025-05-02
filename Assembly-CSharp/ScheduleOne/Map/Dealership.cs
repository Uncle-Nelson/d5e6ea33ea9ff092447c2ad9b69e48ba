using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C18 RID: 3096
	public class Dealership : MonoBehaviour
	{
		// Token: 0x06005705 RID: 22277 RVA: 0x0016DDA0 File Offset: 0x0016BFA0
		public void SpawnVehicle(string vehicleCode)
		{
			Transform transform = this.SpawnPoints[Random.Range(0, this.SpawnPoints.Length)];
			NetworkSingleton<VehicleManager>.Instance.SpawnVehicle(vehicleCode, transform.position, transform.rotation, true);
		}

		// Token: 0x04004055 RID: 16469
		public Transform[] SpawnPoints;
	}
}
