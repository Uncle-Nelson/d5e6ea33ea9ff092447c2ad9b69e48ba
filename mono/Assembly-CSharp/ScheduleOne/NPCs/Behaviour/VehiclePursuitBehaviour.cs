using System;
using FishNet;
using ScheduleOne.Lighting;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.AI;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000537 RID: 1335
	public class VehiclePursuitBehaviour : Behaviour
	{
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x000856DB File Offset: 0x000838DB
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x000856E3 File Offset: 0x000838E3
		public Player TargetPlayer { get; protected set; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x000856EC File Offset: 0x000838EC
		private bool isDriving
		{
			get
			{
				return this.vehicle.OccupantNPCs[0] == base.Npc;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x00085706 File Offset: 0x00083906
		private VehicleAgent Agent
		{
			get
			{
				return this.vehicle.Agent;
			}
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00085714 File Offset: 0x00083914
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00085733 File Offset: 0x00083933
		private void OnDestroy()
		{
			PoliceOfficer.OnPoliceVisionEvent = (Action<VisionEventReceipt>)Delegate.Remove(PoliceOfficer.OnPoliceVisionEvent, new Action<VisionEventReceipt>(this.ProcessThirdPartyVisionEvent));
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00085755 File Offset: 0x00083955
		public void BeginAsSighted()
		{
			this.beginAsSighted = true;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00085760 File Offset: 0x00083960
		protected override void Begin()
		{
			base.Begin();
			base.Npc.awareness.VisionCone.RangeMultiplier = 1.5f;
			if (this.beginAsSighted)
			{
				this.isTargetVisible = true;
				this.initialContactMade = true;
				this.isTargetStrictlyVisible = true;
				this.SetAggressiveDriving(this.initialContactMade);
				this.DriveTo(this.GetPlayerChasePoint());
			}
			this.StartPursuit();
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000857C8 File Offset: 0x000839C8
		protected override void Resume()
		{
			base.Resume();
			this.StartPursuit();
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x000857D8 File Offset: 0x000839D8
		protected override void Pause()
		{
			base.Pause();
			this.initialContactMade = false;
			if (InstanceFinder.IsServer)
			{
				base.Npc.ExitVehicle();
				this.Agent.StopNavigating();
			}
			base.Npc.awareness.VisionCone.RangeMultiplier = 1f;
			base.Npc.awareness.SetAwarenessActive(true);
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x0008583C File Offset: 0x00083A3C
		protected override void End()
		{
			base.End();
			this.Disable();
			this.initialContactMade = false;
			if (this.vehicle != null)
			{
				PoliceLight componentInChildren = this.vehicle.GetComponentInChildren<PoliceLight>();
				if (componentInChildren != null)
				{
					componentInChildren.IsOn = false;
				}
			}
			if (InstanceFinder.IsServer)
			{
				base.Npc.ExitVehicle();
				this.Agent.StopNavigating();
				if (this.TargetPlayer != null)
				{
					(base.Npc as PoliceOfficer).PursuitBehaviour.AssignTarget(null, this.TargetPlayer.NetworkObject);
					(base.Npc as PoliceOfficer).PursuitBehaviour.MarkPlayerVisible();
				}
			}
			base.Npc.awareness.VisionCone.RangeMultiplier = 1f;
			base.Npc.awareness.SetAwarenessActive(true);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00085912 File Offset: 0x00083B12
		public virtual void AssignTarget(Player target)
		{
			this.TargetPlayer = target;
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0008591C File Offset: 0x00083B1C
		private void StartPursuit()
		{
			if (this.vehicle == null)
			{
				Console.LogError("VehiclePursuitBehaviour: Vehicle is unassigned", null);
				this.End();
				return;
			}
			if (this.TargetPlayer == null)
			{
				Console.LogError("VehiclePursuitBehaviour: TargetPlayer is unassigned", null);
				this.End();
				return;
			}
			if (InstanceFinder.IsServer && base.Npc.CurrentVehicle != this.vehicle)
			{
				if (base.Npc.CurrentVehicle != null)
				{
					base.Npc.ExitVehicle();
				}
				base.Npc.EnterVehicle(null, this.vehicle);
			}
			PoliceLight componentInChildren = this.vehicle.GetComponentInChildren<PoliceLight>();
			if (componentInChildren != null)
			{
				componentInChildren.IsOn = true;
			}
			if (!this.isDriving)
			{
				Console.Log("Disabling awareness", null);
				base.Npc.awareness.SetAwarenessActive(false);
			}
			this.UpdateDestination();
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x000859FE File Offset: 0x00083BFE
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.timeSincePursuitStart += Time.deltaTime;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x00085A20 File Offset: 0x00083C20
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsTargetValid())
			{
				base.End_Networked(null);
				return;
			}
			this.CheckExitVehicle();
			if (!this.isDriving)
			{
				return;
			}
			this.SetAggressiveDriving(this.initialContactMade);
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x00085A5B File Offset: 0x00083C5B
		protected virtual void FixedUpdate()
		{
			if (!base.Active)
			{
				return;
			}
			this.CheckPlayerVisibility();
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00085A6C File Offset: 0x00083C6C
		private void UpdateDestination()
		{
			if (!base.Active)
			{
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.Agent.NavigationCalculationInProgress)
			{
				return;
			}
			if (!this.isDriving)
			{
				return;
			}
			if (this.Agent.GetIsStuck() && this.vehicle.speed_Kmh < 4f)
			{
				base.End_Networked(null);
				return;
			}
			if (this.vehicle.VelocityCalculator.Velocity.magnitude < 1f)
			{
				this.timeStationary += 0.2f;
				if (this.timeStationary > 3f && this.timeSincePursuitStart > 10f)
				{
					base.End_Networked(null);
					return;
				}
			}
			else
			{
				this.timeStationary = 0f;
			}
			if (this.isTargetVisible)
			{
				Vector3 b;
				if (this.IsAsCloseAsPossible(this.GetPlayerChasePoint(), out b) || this.IsAsCloseAsPossible(this.TargetPlayer.Avatar.CenterPoint, out b) || Vector3.Distance(this.vehicle.transform.position, b) < 10f)
				{
					this.vehicle.ApplyHandbrake();
					this.Agent.StopNavigating();
					if (this.vehicle.speed_Kmh < 4f)
					{
						base.End_Networked(null);
						return;
					}
				}
				else if (!this.Agent.AutoDriving || Vector3.Distance(this.vehicle.Agent.TargetLocation, this.GetPlayerChasePoint()) > 10f)
				{
					this.DriveTo(this.GetPlayerChasePoint());
				}
				float num = Vector3.Distance(this.currentDriveTarget, this.TargetPlayer.CrimeData.LastKnownPosition);
				float value = Vector3.Distance(base.transform.position, this.TargetPlayer.CrimeData.LastKnownPosition);
				if (num > this.RepathDistanceThresholdMap.Evaluate(Mathf.Clamp(value, 0f, 100f)))
				{
					this.DriveTo(this.GetPlayerChasePoint());
					return;
				}
			}
			else
			{
				if (!this.Agent.AutoDriving)
				{
					Vector3 a;
					if (this.IsAsCloseAsPossible(this.TargetPlayer.CrimeData.LastKnownPosition, out a) || Vector3.Distance(a, this.vehicle.transform.position) < 10f)
					{
						if (this.vehicle.speed_Kmh < 4f)
						{
							base.End_Networked(null);
							return;
						}
					}
					else
					{
						this.DriveTo(this.TargetPlayer.CrimeData.LastKnownPosition);
					}
				}
				float num2 = Vector3.Distance(this.currentDriveTarget, this.TargetPlayer.CrimeData.LastKnownPosition);
				float value2 = Vector3.Distance(base.transform.position, this.TargetPlayer.CrimeData.LastKnownPosition);
				if (num2 > this.RepathDistanceThresholdMap.Evaluate(Mathf.Clamp(value2, 0f, 100f)))
				{
					this.DriveTo(this.TargetPlayer.CrimeData.LastKnownPosition);
				}
			}
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00085D2C File Offset: 0x00083F2C
		private bool IsTargetValid()
		{
			return !(this.TargetPlayer == null) && !this.TargetPlayer.IsArrested && !this.TargetPlayer.IsUnconscious && this.TargetPlayer.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None;
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00085D7C File Offset: 0x00083F7C
		private void CheckExitVehicle()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.isDriving && this.vehicle.OccupantNPCs[0] == null)
			{
				base.End_Networked(null);
				return;
			}
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00085DAC File Offset: 0x00083FAC
		private Vector3 GetPlayerChasePoint()
		{
			Mathf.Min(5f, Vector3.Distance(this.TargetPlayer.Avatar.CenterPoint, base.transform.position));
			Mathf.Clamp01(this.TargetPlayer.VelocityCalculator.Velocity.magnitude / 8f);
			return this.TargetPlayer.Avatar.CenterPoint;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00085E18 File Offset: 0x00084018
		private void SetAggressiveDriving(bool aggressive)
		{
			bool flag = this.aggressiveDrivingEnabled;
			this.aggressiveDrivingEnabled = aggressive;
			if (aggressive)
			{
				this.vehicle.Agent.Flags.OverriddenSpeed = 80f;
				this.vehicle.Agent.Flags.OverriddenReverseSpeed = 20f;
				this.vehicle.Agent.Flags.OverrideSpeed = true;
				this.vehicle.Agent.Flags.AutoBrakeAtDestination = false;
				this.vehicle.Agent.Flags.IgnoreTrafficLights = true;
				this.vehicle.Agent.Flags.UseRoads = false;
				this.vehicle.Agent.Flags.ObstacleMode = DriveFlags.EObstacleMode.IgnoreOnlySquishy;
			}
			else
			{
				this.vehicle.Agent.Flags.OverrideSpeed = false;
				this.vehicle.Agent.Flags.SpeedLimitMultiplier = 1.5f;
				this.vehicle.Agent.Flags.AutoBrakeAtDestination = true;
				this.vehicle.Agent.Flags.IgnoreTrafficLights = true;
				this.vehicle.Agent.Flags.UseRoads = true;
				this.vehicle.Agent.Flags.ObstacleMode = DriveFlags.EObstacleMode.Default;
			}
			if (aggressive != flag && this.vehicle.Agent.AutoDriving)
			{
				this.vehicle.Agent.RecalculateNavigation();
			}
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00085F8E File Offset: 0x0008418E
		private void DriveTo(Vector3 location)
		{
			if (!this.Agent.IsOnVehicleGraph())
			{
				this.End();
				return;
			}
			this.targetChanges++;
			this.currentDriveTarget = location;
			this.Agent.Navigate(location, null, null);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00085FC7 File Offset: 0x000841C7
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

		// Token: 0x06002090 RID: 8336 RVA: 0x0008553C File Offset: 0x0008373C
		private bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			closestPosition = NavigationUtility.SampleVehicleGraph(pos);
			return Vector3.Distance(closestPosition, base.transform.position) < 10f;
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00085FFF File Offset: 0x000841FF
		private bool IsPlayerVisible()
		{
			return base.Npc.awareness.VisionCone.IsPlayerVisible(this.TargetPlayer);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0008601C File Offset: 0x0008421C
		private void CheckPlayerVisibility()
		{
			if (this.TargetPlayer == null)
			{
				return;
			}
			if (this.isTargetVisible)
			{
				this.playerSightedDuration += Time.fixedDeltaTime;
				if (this.IsPlayerVisible())
				{
					this.initialContactMade = true;
					this.TargetPlayer.CrimeData.RecordLastKnownPosition(true);
					this.timeSinceLastSighting = 0f;
				}
				else
				{
					this.TargetPlayer.CrimeData.RecordLastKnownPosition(false);
				}
			}
			if (!this.IsPlayerVisible())
			{
				this.playerSightedDuration = 0f;
				this.timeSinceLastSighting += Time.fixedDeltaTime;
				this.isTargetVisible = false;
				this.isTargetStrictlyVisible = false;
				if (this.timeSinceLastSighting < 6f)
				{
					this.TargetPlayer.CrimeData.RecordLastKnownPosition(false);
					this.isTargetVisible = true;
					return;
				}
			}
			else
			{
				this.isTargetStrictlyVisible = true;
			}
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x000860F0 File Offset: 0x000842F0
		private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			if (!base.Active)
			{
				return;
			}
			if (visionEventReceipt.TargetPlayer == this.TargetPlayer.NetworkObject && visionEventReceipt.State == PlayerVisualState.EVisualState.SearchedFor)
			{
				this.isTargetVisible = true;
				this.initialContactMade = true;
				this.isTargetStrictlyVisible = true;
				this.DriveTo(this.GetPlayerChasePoint());
				if (this.TargetPlayer.IsOwner && this.TargetPlayer.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.Investigating)
				{
					this.TargetPlayer.CrimeData.Escalate();
				}
			}
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00086178 File Offset: 0x00084378
		private void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			if (!base.Active)
			{
				return;
			}
			if (visionEventReceipt.TargetPlayer == this.TargetPlayer.NetworkObject && visionEventReceipt.State == PlayerVisualState.EVisualState.SearchedFor)
			{
				this.isTargetVisible = true;
				this.isTargetStrictlyVisible = true;
				this.DriveTo(this.GetPlayerChasePoint());
			}
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x000861E7 File Offset: 0x000843E7
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00086200 File Offset: 0x00084400
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00086219 File Offset: 0x00084419
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00086228 File Offset: 0x00084428
		protected virtual void dll()
		{
			base.Awake();
			if (InstanceFinder.IsOffline || InstanceFinder.IsServer)
			{
				VisionCone visionCone = base.Npc.awareness.VisionCone;
				visionCone.onVisionEventFull = (VisionCone.EventStateChange)Delegate.Combine(visionCone.onVisionEventFull, new VisionCone.EventStateChange(this.ProcessVisionEvent));
				base.InvokeRepeating("UpdateDestination", 0.5f, 0.2f);
			}
			PoliceOfficer.OnPoliceVisionEvent = (Action<VisionEventReceipt>)Delegate.Combine(PoliceOfficer.OnPoliceVisionEvent, new Action<VisionEventReceipt>(this.ProcessThirdPartyVisionEvent));
		}

		// Token: 0x04001918 RID: 6424
		public new const float MAX_CONSECUTIVE_PATHING_FAILURES = 5f;

		// Token: 0x04001919 RID: 6425
		public const float EXTRA_VISIBILITY_TIME = 6f;

		// Token: 0x0400191A RID: 6426
		public const float EXIT_VEHICLE_MAX_SPEED = 4f;

		// Token: 0x0400191B RID: 6427
		public const float CLOSE_ENOUGH_THRESHOLD = 10f;

		// Token: 0x0400191C RID: 6428
		public const float UPDATE_FREQUENCY = 0.2f;

		// Token: 0x0400191D RID: 6429
		public const float STATIONARY_THRESHOLD = 1f;

		// Token: 0x0400191E RID: 6430
		public const float TIME_STATIONARY_TO_EXIT = 3f;

		// Token: 0x04001920 RID: 6432
		[Header("Settings")]
		public AnimationCurve RepathDistanceThresholdMap;

		// Token: 0x04001921 RID: 6433
		public LandVehicle vehicle;

		// Token: 0x04001922 RID: 6434
		private bool initialContactMade;

		// Token: 0x04001923 RID: 6435
		private bool aggressiveDrivingEnabled;

		// Token: 0x04001924 RID: 6436
		private bool isTargetVisible;

		// Token: 0x04001925 RID: 6437
		private bool isTargetStrictlyVisible;

		// Token: 0x04001926 RID: 6438
		private float playerSightedDuration;

		// Token: 0x04001927 RID: 6439
		private float timeSinceLastSighting = 10000f;

		// Token: 0x04001928 RID: 6440
		private new int consecutivePathingFailures;

		// Token: 0x04001929 RID: 6441
		private float timeStationary;

		// Token: 0x0400192A RID: 6442
		private Vector3 currentDriveTarget = Vector3.zero;

		// Token: 0x0400192B RID: 6443
		private int targetChanges;

		// Token: 0x0400192C RID: 6444
		private float timeSincePursuitStart;

		// Token: 0x0400192D RID: 6445
		private bool beginAsSighted;

		// Token: 0x0400192E RID: 6446
		private bool dll_Excuted;

		// Token: 0x0400192F RID: 6447
		private bool dll_Excuted;
	}
}
