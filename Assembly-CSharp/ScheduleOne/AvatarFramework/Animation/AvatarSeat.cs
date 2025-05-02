using System;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200099B RID: 2459
	public class AvatarSeat : MonoBehaviour
	{
		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x00117FA7 File Offset: 0x001161A7
		public bool IsOccupied
		{
			get
			{
				return this.Occupant != null;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x00117FB5 File Offset: 0x001161B5
		// (set) Token: 0x060042B0 RID: 17072 RVA: 0x00117FBD File Offset: 0x001161BD
		public NPC Occupant { get; protected set; }

		// Token: 0x060042B1 RID: 17073 RVA: 0x000045B1 File Offset: 0x000027B1
		private void Awake()
		{
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x00117FC6 File Offset: 0x001161C6
		public void SetOccupant(NPC npc)
		{
			if (npc != null && this.IsOccupied)
			{
				Debug.LogWarning("Seat is already occupied");
				return;
			}
			this.Occupant = npc;
		}

		// Token: 0x04003064 RID: 12388
		public Transform SittingPoint;

		// Token: 0x04003065 RID: 12389
		public Transform AccessPoint;
	}
}
