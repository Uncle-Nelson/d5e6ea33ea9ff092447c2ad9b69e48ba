using System;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007DB RID: 2011
	public class VehicleObstacle : MonoBehaviour
	{
		// Token: 0x04002783 RID: 10115
		public Collider col;

		// Token: 0x04002784 RID: 10116
		[Header("Settings")]
		public bool twoSided = true;

		// Token: 0x04002785 RID: 10117
		public VehicleObstacle.EObstacleType type;

		// Token: 0x020007DC RID: 2012
		public enum EObstacleType
		{
			// Token: 0x04002787 RID: 10119
			Generic,
			// Token: 0x04002788 RID: 10120
			TrafficLight
		}
	}
}
