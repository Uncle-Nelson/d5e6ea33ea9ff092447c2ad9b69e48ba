using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020007FB RID: 2043
	public class PathPoint : MonoBehaviour
	{
		// Token: 0x04002831 RID: 10289
		public List<PathPoint> connections = new List<PathPoint>();

		// Token: 0x04002832 RID: 10290
		public bool unique;
	}
}
