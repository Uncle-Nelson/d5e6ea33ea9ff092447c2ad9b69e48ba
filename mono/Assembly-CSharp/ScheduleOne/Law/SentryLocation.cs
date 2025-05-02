using System;
using System.Collections.Generic;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005D2 RID: 1490
	public class SentryLocation : MonoBehaviour
	{
		// Token: 0x04001B76 RID: 7030
		[Header("References")]
		public List<Transform> StandPoints = new List<Transform>();

		// Token: 0x04001B77 RID: 7031
		[Header("Info")]
		public List<PoliceOfficer> AssignedOfficers = new List<PoliceOfficer>();
	}
}
