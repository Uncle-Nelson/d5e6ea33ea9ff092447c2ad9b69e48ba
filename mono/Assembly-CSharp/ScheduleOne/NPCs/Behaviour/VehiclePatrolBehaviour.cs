using System;
using FishNet;
using ScheduleOne.Police;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000535 RID: 1333
	public class VehiclePatrolBehaviour : Behaviour
	{
		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x00085208 File Offset: 0x00083408
		private bool isDriving
		{
			get
			{
				return this.Vehicle.OccupantNPCs[0] == base.Npc;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x00085222 File Offset: 0x00083422
		private VehicleAgent Agent
		{
			get
			{
				return this.Vehicle.Agent;
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0008522F File Offset: 0x0008342F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00085243 File Offset: 0x00083443
		protected override void Begin()
		{
			base.Begin();
			this.StartPatrol();
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00085251 File Offset: 0x00083451
		protected override void Resume()
		{
			base.Resume();
			this.StartPatrol();
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00085260 File Offset: 0x00083460
		protected override void Pause()
		{
			base.Pause();
			if (InstanceFinder.IsServer)
			{
				base.Npc.ExitVehicle();
				this.Agent.StopNavigating();
			}
			base.Npc.awareness.VisionCone.RangeMultiplier = 1f;
			(base.Npc as PoliceOfficer).BodySearchChance = 0.1f;
			base.Npc.awareness.SetAwarenessActive(true);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000852D0 File Offset: 0x000834D0
		protected override void End()
		{
			base.End();
			if (InstanceFinder.IsServer)
			{
				base.Npc.ExitVehicle();
				this.Agent.StopNavigating();
			}
			base.Npc.awareness.VisionCone.RangeMultiplier = 1f;
			(base.Npc as PoliceOfficer).BodySearchChance = 0.1f;
			base.Npc.awareness.SetAwarenessActive(true);
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x00085340 File Offset: 0x00083540
		public void SetRoute(VehiclePatrolRoute route)
		{
			this.Route = route;
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x0008534C File Offset: 0x0008354C
		private void StartPatrol()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.Vehicle == null)
			{
				Console.LogError("VehiclePursuitBehaviour: Vehicle is unassigned", null);
				base.Disable_Networked(null);
				base.End_Networked(null);
				return;
			}
			if (InstanceFinder.IsServer && base.Npc.CurrentVehicle != this.Vehicle)
			{
				if (base.Npc.CurrentVehicle != null)
				{
					base.Npc.ExitVehicle();
				}
				base.Npc.EnterVehicle(null, this.Vehicle);
			}
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000853D8 File Offset: 0x000835D8
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.isDriving)
			{
				return;
			}
			if (this.Agent.AutoDriving)
			{
				if (!this.Agent.NavigationCalculationInProgress && Vector3.Distance(this.Vehicle.transform.position, this.Route.Waypoints[this.CurrentWaypoint].position) < 10f)
				{
					this.CurrentWaypoint++;
					if (this.CurrentWaypoint >= this.Route.Waypoints.Length)
					{
						base.Disable_Networked(null);
						return;
					}
					this.DriveTo(this.Route.Waypoints[this.CurrentWaypoint].position);
					return;
				}
			}
			else
			{
				if (this.CurrentWaypoint >= this.Route.Waypoints.Length)
				{
					base.Disable_Networked(null);
					return;
				}
				this.DriveTo(this.Route.Waypoints[this.CurrentWaypoint].position);
			}
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000854D5 File Offset: 0x000836D5
		private void DriveTo(Vector3 location)
		{
			if (!this.Agent.IsOnVehicleGraph())
			{
				this.End();
				return;
			}
			this.Agent.Navigate(location, null, new VehicleAgent.NavigationCallback(this.NavigationCallback));
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00085504 File Offset: 0x00083704
		private void NavigationCallback(VehicleAgent.ENavigationResult status)
		{
			if (status == VehicleAgent.ENavigationResult.Failed)
			{
				this.consecutivePathingFailures++;
			}
			else
			{
				this.consecutivePathingFailures = 0;
			}
			if ((float)this.consecutivePathingFailures > 5f && InstanceFinder.IsServer)
			{
				base.End_Networked(null);
			}
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0008553C File Offset: 0x0008373C
		private bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			closestPosition = NavigationUtility.SampleVehicleGraph(pos);
			return Vector3.Distance(closestPosition, base.transform.position) < 10f;
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00085576 File Offset: 0x00083776
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x0008558F File Offset: 0x0008378F
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x000855A8 File Offset: 0x000837A8
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00084D1D File Offset: 0x00082F1D
		protected virtual void dll()
		{
			base.Awake();
		}

		// Token: 0x0400190C RID: 6412
		public new const float MAX_CONSECUTIVE_PATHING_FAILURES = 5f;

		// Token: 0x0400190D RID: 6413
		public const float PROGRESSION_THRESHOLD = 10f;

		// Token: 0x0400190E RID: 6414
		public int CurrentWaypoint;

		// Token: 0x0400190F RID: 6415
		[Header("Settings")]
		public VehiclePatrolRoute Route;

		// Token: 0x04001910 RID: 6416
		public LandVehicle Vehicle;

		// Token: 0x04001911 RID: 6417
		private bool aggressiveDrivingEnabled = true;

		// Token: 0x04001912 RID: 6418
		private new int consecutivePathingFailures;

		// Token: 0x04001913 RID: 6419
		private bool dll_Excuted;

		// Token: 0x04001914 RID: 6420
		private bool dll_Excuted;
	}
}
