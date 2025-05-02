using System;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C2E RID: 3118
	public class ParkingSpot : MonoBehaviour
	{
		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06005767 RID: 22375 RVA: 0x0016F061 File Offset: 0x0016D261
		// (set) Token: 0x06005768 RID: 22376 RVA: 0x0016F069 File Offset: 0x0016D269
		public LandVehicle OccupantVehicle { get; protected set; }

		// Token: 0x06005769 RID: 22377 RVA: 0x0016F072 File Offset: 0x0016D272
		private void Awake()
		{
			this.Init();
			if (this.ParentLot == null)
			{
				Debug.LogError("ParkingSpot has not parent ParkingLot!");
			}
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x0016F094 File Offset: 0x0016D294
		private void Init()
		{
			if (this.ParentLot == null)
			{
				this.ParentLot = base.GetComponentInParent<ParkingLot>();
			}
			if (this.ParentLot == null)
			{
				Debug.LogError("ParkingSpot has not parent ParkingLot!");
			}
			this.ParentLot.ParkingSpots.Add(this);
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x0016F0E4 File Offset: 0x0016D2E4
		public void SetOccupant(LandVehicle vehicle)
		{
			this.OccupantVehicle = vehicle;
			this.OccupantVehicle_Readonly = this.OccupantVehicle;
		}

		// Token: 0x040040AF RID: 16559
		private ParkingLot ParentLot;

		// Token: 0x040040B0 RID: 16560
		public Transform AlignmentPoint;

		// Token: 0x040040B1 RID: 16561
		public EParkingAlignment Alignment;

		// Token: 0x040040B2 RID: 16562
		[SerializeField]
		private LandVehicle OccupantVehicle_Readonly;
	}
}
