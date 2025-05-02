using System;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007DE RID: 2014
	public class VehicleSeat : MonoBehaviour
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x000E7BA4 File Offset: 0x000E5DA4
		public bool isOccupied
		{
			get
			{
				return this.Occupant != null;
			}
		}

		// Token: 0x0400278A RID: 10122
		public bool isDriverSeat;

		// Token: 0x0400278B RID: 10123
		public Player Occupant;
	}
}
