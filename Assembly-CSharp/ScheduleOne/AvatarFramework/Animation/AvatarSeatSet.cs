using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200099C RID: 2460
	public class AvatarSeatSet : MonoBehaviour
	{
		// Token: 0x060042B4 RID: 17076 RVA: 0x00117FEC File Offset: 0x001161EC
		public AvatarSeat GetFirstFreeSeat()
		{
			for (int i = 0; i < this.Seats.Length; i++)
			{
				if (!this.Seats[i].IsOccupied)
				{
					return this.Seats[i];
				}
			}
			Console.LogWarning("Failed to find a free seat! Returning the first seat.", null);
			return this.Seats[0];
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x00118038 File Offset: 0x00116238
		public AvatarSeat GetRandomFreeSeat()
		{
			List<AvatarSeat> list = (from x in this.Seats
			where !x.IsOccupied
			select x).ToList<AvatarSeat>();
			if (list.Count == 0)
			{
				Console.LogWarning("Failed to find a free seat! Returning the first seat.", null);
				return this.Seats[0];
			}
			return list[Random.Range(0, list.Count)];
		}

		// Token: 0x04003066 RID: 12390
		public AvatarSeat[] Seats;
	}
}
