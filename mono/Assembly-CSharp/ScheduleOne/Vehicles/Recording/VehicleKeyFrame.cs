using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.Recording
{
	// Token: 0x020007E2 RID: 2018
	[Serializable]
	public class VehicleKeyFrame
	{
		// Token: 0x040027C0 RID: 10176
		public Vector3 position;

		// Token: 0x040027C1 RID: 10177
		public Quaternion rotation;

		// Token: 0x040027C2 RID: 10178
		public bool brakesApplied;

		// Token: 0x040027C3 RID: 10179
		public bool reversing;

		// Token: 0x040027C4 RID: 10180
		public bool headlightsOn;

		// Token: 0x040027C5 RID: 10181
		public List<VehicleKeyFrame.WheelTransform> wheels = new List<VehicleKeyFrame.WheelTransform>();

		// Token: 0x020007E3 RID: 2019
		[Serializable]
		public class WheelTransform
		{
			// Token: 0x040027C6 RID: 10182
			public float yPos;

			// Token: 0x040027C7 RID: 10183
			public Quaternion rotation;
		}
	}
}
