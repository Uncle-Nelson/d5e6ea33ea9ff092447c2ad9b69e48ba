using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C2C RID: 3116
	public class ParkingLot : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x0016EE9C File Offset: 0x0016D09C
		// (set) Token: 0x0600575D RID: 22365 RVA: 0x0016EEA4 File Offset: 0x0016D0A4
		public Guid GUID { get; protected set; }

		// Token: 0x0600575E RID: 22366 RVA: 0x0016EEB0 File Offset: 0x0016D0B0
		private void Awake()
		{
			if (this.ExitPoint != null && this.ExitPointVehicleDetector == null)
			{
				Console.LogWarning("ExitPoint specified but no ExitPointVehicleDetector!", null);
			}
			if (!GUIDManager.IsGUIDValid(this.BakedGUID))
			{
				Console.LogError(base.gameObject.name + "'s baked GUID is not valid! Bad.", null);
			}
			this.GUID = new Guid(this.BakedGUID);
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x0016EF23 File Offset: 0x0016D123
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x0016EF34 File Offset: 0x0016D134
		public ParkingSpot GetRandomFreeSpot()
		{
			List<ParkingSpot> freeParkingSpots = this.GetFreeParkingSpots();
			if (freeParkingSpots.Count == 0)
			{
				Console.Log("No free parking spots in " + base.gameObject.name + "!", null);
				return null;
			}
			return freeParkingSpots[Random.Range(0, freeParkingSpots.Count)];
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x0016EF84 File Offset: 0x0016D184
		public int GetRandomFreeSpotIndex()
		{
			List<ParkingSpot> freeParkingSpots = this.GetFreeParkingSpots();
			if (freeParkingSpots.Count == 0)
			{
				return -1;
			}
			return this.ParkingSpots.IndexOf(freeParkingSpots[Random.Range(0, freeParkingSpots.Count)]);
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x0016EFC0 File Offset: 0x0016D1C0
		public List<ParkingSpot> GetFreeParkingSpots()
		{
			if (this.ParkingSpots == null || this.ParkingSpots.Count == 0)
			{
				return new List<ParkingSpot>();
			}
			return (from x in this.ParkingSpots
			where x != null && x.OccupantVehicle == null
			select x).ToList<ParkingSpot>();
		}

		// Token: 0x040040A4 RID: 16548
		[SerializeField]
		protected string BakedGUID = string.Empty;

		// Token: 0x040040A6 RID: 16550
		[Header("READONLY")]
		public List<ParkingSpot> ParkingSpots = new List<ParkingSpot>();

		// Token: 0x040040A7 RID: 16551
		[Header("Entry")]
		public Transform EntryPoint;

		// Token: 0x040040A8 RID: 16552
		public Transform HiddenVehicleAccessPoint;

		// Token: 0x040040A9 RID: 16553
		[Header("Exit")]
		public bool UseExitPoint;

		// Token: 0x040040AA RID: 16554
		public EParkingAlignment ExitAlignment = EParkingAlignment.RearToKerb;

		// Token: 0x040040AB RID: 16555
		public Transform ExitPoint;

		// Token: 0x040040AC RID: 16556
		public VehicleDetector ExitPointVehicleDetector;
	}
}
