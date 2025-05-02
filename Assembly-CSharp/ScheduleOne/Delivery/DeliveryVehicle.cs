using System;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Delivery
{
	// Token: 0x0200071C RID: 1820
	[RequireComponent(typeof(LandVehicle))]
	public class DeliveryVehicle : MonoBehaviour
	{
		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x000CC898 File Offset: 0x000CAA98
		// (set) Token: 0x06003136 RID: 12598 RVA: 0x000CC8A0 File Offset: 0x000CAAA0
		public LandVehicle Vehicle { get; private set; }

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x000CC8A9 File Offset: 0x000CAAA9
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x000CC8B1 File Offset: 0x000CAAB1
		public DeliveryInstance ActiveDelivery { get; private set; }

		// Token: 0x06003139 RID: 12601 RVA: 0x000CC8BA File Offset: 0x000CAABA
		private void Awake()
		{
			this.Vehicle = base.GetComponent<LandVehicle>();
			this.Vehicle.SetGUID(new Guid(this.GUID));
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x000CC8E0 File Offset: 0x000CAAE0
		public void Activate(DeliveryInstance instance)
		{
			Console.Log("Activating delivery vehicle for delivery instance " + instance.DeliveryID, null);
			this.ActiveDelivery = instance;
			ParkingLot parking = instance.LoadingDock.Parking;
			instance.LoadingDock.SetStaticOccupant(this.Vehicle);
			this.Vehicle.Park(null, new ParkData
			{
				lotGUID = parking.GUID,
				spotIndex = 0,
				alignment = parking.ParkingSpots[0].Alignment
			}, false);
			this.Vehicle.SetVisible(true);
			this.Vehicle.Storage.AccessSettings = StorageEntity.EAccessSettings.Full;
			this.Vehicle.GetComponentInChildren<StorageDoorAnimation>().OverrideState(true);
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x000CC994 File Offset: 0x000CAB94
		public void Deactivate()
		{
			Console.Log("Deactivating delivery vehicle", null);
			if (this.Vehicle != null)
			{
				this.Vehicle.ExitPark(false);
				this.Vehicle.SetIsStatic(true);
				this.Vehicle.SetVisible(false);
				this.Vehicle.SetTransform(new Vector3(0f, -100f, 0f), Quaternion.identity);
			}
			if (this.ActiveDelivery != null)
			{
				this.ActiveDelivery.LoadingDock.SetStaticOccupant(null);
				this.ActiveDelivery.LoadingDock.VehicleDetector.Clear();
			}
		}

		// Token: 0x04002313 RID: 8979
		public string GUID = string.Empty;
	}
}
