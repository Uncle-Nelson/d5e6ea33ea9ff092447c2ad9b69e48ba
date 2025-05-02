using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.Map;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x0200047F RID: 1151
	public class NPCSignal_DriveToCarPark : NPCSignal
	{
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x0006D9D9 File Offset: 0x0006BBD9
		public new string ActionName
		{
			get
			{
				return "Drive to car park";
			}
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0006D9E0 File Offset: 0x0006BBE0
		public override string GetName()
		{
			if (this.ParkingLot == null)
			{
				return this.ActionName + " (No Parking Lot)";
			}
			return this.ActionName + " (" + this.ParkingLot.gameObject.name + ")";
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0006DA31 File Offset: 0x0006BC31
		protected override void OnValidate()
		{
			base.OnValidate();
			this.priority = 12;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0006DA41 File Offset: 0x0006BC41
		public override void Started()
		{
			base.Started();
			this.isAtDestination = false;
			this.CheckValidForStart();
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0006DA56 File Offset: 0x0006BC56
		public override void End()
		{
			base.End();
			if (this.npc.CurrentVehicle != null)
			{
				this.npc.ExitVehicle();
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0006DA7C File Offset: 0x0006BC7C
		public override void LateStarted()
		{
			base.LateStarted();
			this.isAtDestination = false;
			this.CheckValidForStart();
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0006DA91 File Offset: 0x0006BC91
		private void CheckValidForStart()
		{
			if (this.Vehicle.CurrentParkingLot == this.ParkingLot)
			{
				this.End();
			}
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0006DAB4 File Offset: 0x0006BCB4
		public override void Interrupt()
		{
			base.Interrupt();
			this.Park();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.npc.IsInVehicle)
			{
				this.Vehicle.Agent.StopNavigating();
				this.npc.ExitVehicle();
				return;
			}
			this.npc.Movement.Stop();
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0006DB0E File Offset: 0x0006BD0E
		public override void Resume()
		{
			base.Resume();
			this.isAtDestination = false;
			this.CheckValidForStart();
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0006DB23 File Offset: 0x0006BD23
		public override void Skipped()
		{
			base.Skipped();
			this.Park();
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0006DB31 File Offset: 0x0006BD31
		public override void ResumeFailed()
		{
			base.ResumeFailed();
			this.Park();
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0006DB3F File Offset: 0x0006BD3F
		public override void JumpTo()
		{
			base.JumpTo();
			this.isAtDestination = false;
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0006DB50 File Offset: 0x0006BD50
		public override void ActiveMinPassed()
		{
			base.ActiveMinPassed();
			if (this.npc.IsInVehicle)
			{
				this.timeInVehicle += 1f;
			}
			else
			{
				this.timeInVehicle = 0f;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.npc.IsInVehicle && this.npc.CurrentVehicle.CurrentParkingLot == this.ParkingLot)
			{
				this.timeAtDestination += 1f;
				if (this.timeAtDestination > 1f)
				{
					this.End();
				}
			}
			else
			{
				this.timeAtDestination = 0f;
			}
			if (!this.isAtDestination)
			{
				if (this.npc.IsInVehicle)
				{
					if (this.Vehicle.isParked)
					{
						if (this.timeInVehicle > 1f)
						{
							this.Vehicle.ExitPark_Networked(null, this.Vehicle.CurrentParkingLot.UseExitPoint);
							return;
						}
					}
					else if (!this.Vehicle.Agent.AutoDriving)
					{
						this.Vehicle.Agent.Navigate(this.ParkingLot.EntryPoint.position, null, new VehicleAgent.NavigationCallback(this.DriveCallback));
						return;
					}
				}
				else if ((!this.npc.Movement.IsMoving || Vector3.Distance(this.npc.Movement.CurrentDestination, this.GetWalkDestination()) > 1f) && this.npc.Movement.CanMove())
				{
					if (this.npc.Movement.CanGetTo(this.GetWalkDestination(), 2f))
					{
						base.SetDestination(this.GetWalkDestination(), true);
						return;
					}
					this.npc.EnterVehicle(null, this.Vehicle);
					Console.LogWarning(string.Concat(new string[]
					{
						"NPC ",
						this.npc.name,
						" was unable to reach vehicle ",
						this.Vehicle.name,
						" and was teleported to it."
					}), null);
					Debug.DrawLine(this.npc.transform.position, this.GetWalkDestination(), Color.red, 10f);
				}
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0006DD7B File Offset: 0x0006BF7B
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
			base.WalkCallback(result);
			if (!base.IsActive)
			{
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (result == NPCMovement.WalkResult.Success || result == NPCMovement.WalkResult.Partial)
			{
				this.npc.EnterVehicle(null, this.Vehicle);
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0006DDB0 File Offset: 0x0006BFB0
		private Vector3 GetWalkDestination()
		{
			if (!this.Vehicle.IsVisible && this.Vehicle.CurrentParkingLot != null && this.Vehicle.CurrentParkingLot.HiddenVehicleAccessPoint != null)
			{
				return this.Vehicle.CurrentParkingLot.HiddenVehicleAccessPoint.position;
			}
			return this.Vehicle.driverEntryPoint.position;
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0006DE1B File Offset: 0x0006C01B
		private void DriveCallback(VehicleAgent.ENavigationResult result)
		{
			if (!base.IsActive)
			{
				return;
			}
			this.isAtDestination = true;
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.Park();
			base.StartCoroutine(this.<DriveCallback>g__Wait|23_0());
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0006DE48 File Offset: 0x0006C048
		private void Park()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			int randomFreeSpotIndex = this.ParkingLot.GetRandomFreeSpotIndex();
			EParkingAlignment alignment = EParkingAlignment.FrontToKerb;
			if (randomFreeSpotIndex != -1)
			{
				alignment = (this.OverrideParkingType ? this.ParkingType : this.ParkingLot.ParkingSpots[randomFreeSpotIndex].Alignment);
			}
			this.Vehicle.Park(null, new ParkData
			{
				lotGUID = this.ParkingLot.GUID,
				alignment = alignment,
				spotIndex = randomFreeSpotIndex
			}, true);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0006DEC7 File Offset: 0x0006C0C7
		private EParkingAlignment GetParkingType()
		{
			if (this.OverrideParkingType)
			{
				return this.ParkingType;
			}
			return this.ParkingLot.GetRandomFreeSpot().Alignment;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0006DEF0 File Offset: 0x0006C0F0
		[CompilerGenerated]
		private IEnumerator <DriveCallback>g__Wait|23_0()
		{
			yield return new WaitForSeconds(1f);
			this.End();
			yield break;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0006DEFF File Offset: 0x0006C0FF
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0006DF18 File Offset: 0x0006C118
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_DriveToCarParkAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0006DF31 File Offset: 0x0006C131
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0006DF3F File Offset: 0x0006C13F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040015F0 RID: 5616
		public ParkingLot ParkingLot;

		// Token: 0x040015F1 RID: 5617
		public LandVehicle Vehicle;

		// Token: 0x040015F2 RID: 5618
		[Header("Parking Settings")]
		public bool OverrideParkingType;

		// Token: 0x040015F3 RID: 5619
		public EParkingAlignment ParkingType;

		// Token: 0x040015F4 RID: 5620
		private bool isAtDestination;

		// Token: 0x040015F5 RID: 5621
		private float timeInVehicle;

		// Token: 0x040015F6 RID: 5622
		private float timeAtDestination;

		// Token: 0x040015F7 RID: 5623
		private bool dll_Excuted;

		// Token: 0x040015F8 RID: 5624
		private bool dll_Excuted;
	}
}
