using System;
using FishNet.Object;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007D7 RID: 2007
	[RequireComponent(typeof(LandVehicle))]
	public class VehicleInitializer : NetworkBehaviour
	{
		// Token: 0x060036D6 RID: 14038 RVA: 0x000E6E90 File Offset: 0x000E5090
		public override void OnStartServer()
		{
			base.OnStartServer();
			if (this.InitialParkingLot != null && !base.GetComponent<LandVehicle>().isParked)
			{
				int randomFreeSpotIndex = this.InitialParkingLot.GetRandomFreeSpotIndex();
				if (randomFreeSpotIndex != -1)
				{
					EParkingAlignment alignment = this.InitialParkingLot.ParkingSpots[randomFreeSpotIndex].Alignment;
				}
			}
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x000E6EE5 File Offset: 0x000E50E5
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x000E6EF8 File Offset: 0x000E50F8
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x000E6F0B File Offset: 0x000E510B
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x000E6F0B File Offset: 0x000E510B
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002758 RID: 10072
		public ParkingLot InitialParkingLot;

		// Token: 0x04002759 RID: 10073
		private bool dll_Excuted;

		// Token: 0x0400275A RID: 10074
		private bool dll_Excuted;
	}
}
