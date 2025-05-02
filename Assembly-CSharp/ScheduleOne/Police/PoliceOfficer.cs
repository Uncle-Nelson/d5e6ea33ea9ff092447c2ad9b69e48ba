using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.FX;
using ScheduleOne.Law;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Police
{
	// Token: 0x02000335 RID: 821
	public class PoliceOfficer : NPC
	{
		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x0004E720 File Offset: 0x0004C920
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x0004E728 File Offset: 0x0004C928
		public NetworkObject TargetPlayerNOB
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<TargetPlayerNOB>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				this.sync___set_value_<TargetPlayerNOB>k__BackingField(value, true);
			}
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0004E734 File Offset: 0x0004C934
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Police.PoliceOfficer_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0004E753 File Offset: 0x0004C953
		protected override void Start()
		{
			base.Start();
			this.belt = this.Avatar.GetComponentInChildren<PoliceBelt>();
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0004E76C File Offset: 0x0004C96C
		protected override void Update()
		{
			base.Update();
			if (InstanceFinder.IsServer)
			{
				this.UpdateBodySearch();
			}
			this.UpdateChatter();
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0004E788 File Offset: 0x0004C988
		protected void FixedUpdate()
		{
			for (int i = 0; i < Player.PlayerList.Count; i++)
			{
				this.awareness.VisionCone.StateSettings[Player.PlayerList[i]][PlayerVisualState.EVisualState.Wanted].Enabled = (this.TargetPlayerNOB == null);
				this.awareness.VisionCone.StateSettings[Player.PlayerList[i]][PlayerVisualState.EVisualState.Suspicious].Enabled = (this.TargetPlayerNOB == null && !Player.PlayerList[i].CrimeData.BodySearchPending && Player.PlayerList[i].CrimeData.TimeSinceLastBodySearch > 30f);
				this.awareness.VisionCone.StateSettings[Player.PlayerList[i]][PlayerVisualState.EVisualState.DisobeyingCurfew].Enabled = (this.TargetPlayerNOB == null);
				this.awareness.VisionCone.StateSettings[Player.PlayerList[i]][PlayerVisualState.EVisualState.DrugDealing].Enabled = (this.TargetPlayerNOB == null);
				this.awareness.VisionCone.StateSettings[Player.PlayerList[i]][PlayerVisualState.EVisualState.Vandalizing].Enabled = (this.TargetPlayerNOB == null);
				this.awareness.VisionCone.StateSettings[Player.PlayerList[i]][PlayerVisualState.EVisualState.Pickpocketing].Enabled = (this.TargetPlayerNOB == null);
				this.awareness.VisionCone.StateSettings[Player.PlayerList[i]][PlayerVisualState.EVisualState.Brandishing].Enabled = (this.TargetPlayerNOB == null);
				this.awareness.VisionCone.StateSettings[Player.PlayerList[i]][PlayerVisualState.EVisualState.DischargingWeapon].Enabled = (this.TargetPlayerNOB == null);
			}
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0004E9A2 File Offset: 0x0004CBA2
		protected override void MinPass()
		{
			base.MinPass();
			if (base.CurrentBuilding == null && InstanceFinder.IsServer && this.AutoDeactivate)
			{
				this.CheckDeactivation();
			}
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0004E9D0 File Offset: 0x0004CBD0
		private void CheckDeactivation()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.TargetPlayerNOB != null)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (this.behaviour.ScheduleManager.ActiveAction != null)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (this.CheckpointBehaviour.Active)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (this.FootPatrolBehaviour.Active)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (this.VehiclePatrolBehaviour.Active)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (this.BodySearchBehaviour.Active)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (this.SentryBehaviour.Active)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (!base.IsConscious)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (this.behaviour.RagdollBehaviour.Active)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (this.behaviour.GenericDialogueBehaviour.Active)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			if (this.behaviour.FacePlayerBehaviour.Active)
			{
				this.timeSinceReadyToPool = 0f;
				this.timeSinceOutOfSight = 0f;
				return;
			}
			this.timeSinceReadyToPool += 1f;
			if (this.timeSinceReadyToPool < 1f)
			{
				return;
			}
			if (!this.movement.IsMoving && Singleton<Map>.InstanceExists)
			{
				if (this.movement.IsAsCloseAsPossible(Singleton<Map>.Instance.PoliceStation.Doors[0].transform.position, 1f))
				{
					this.Deactivate();
					return;
				}
				if (this.movement.CanGetTo(Singleton<Map>.Instance.PoliceStation.Doors[0].transform.position, 1f))
				{
					this.movement.SetDestination(Singleton<Map>.Instance.PoliceStation.Doors[0].transform.position);
				}
				else
				{
					this.Deactivate();
				}
			}
			bool flag = false;
			foreach (Player player in Player.PlayerList)
			{
				if (player.IsPointVisibleToPlayer(this.Avatar.CenterPoint, 30f, 5f))
				{
					flag = true;
					break;
				}
				if (this.AssignedVehicle != null && player.IsPointVisibleToPlayer(this.AssignedVehicle.transform.position, 30f, 5f))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				this.timeSinceReadyToPool += 1f;
				this.timeSinceOutOfSight += 1f;
				if (this.timeSinceOutOfSight > 1f)
				{
					this.Deactivate();
					return;
				}
			}
			else
			{
				this.timeSinceOutOfSight = 0f;
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0004ED2C File Offset: 0x0004CF2C
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginFootPursuit_Networked(NetworkObject target, bool includeColleagues = true)
		{
			this.RpcWriter___Server_BeginFootPursuit_Networked_419679943(target, includeColleagues);
			this.RpcLogic___BeginFootPursuit_Networked_419679943(target, includeColleagues);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0004ED58 File Offset: 0x0004CF58
		[ObserversRpc(RunLocally = true)]
		private void BeginFootPursuitTest(string playerCode)
		{
			this.RpcWriter___Observers_BeginFootPursuitTest_3615296227(playerCode);
			this.RpcLogic___BeginFootPursuitTest_3615296227(playerCode);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0004ED79 File Offset: 0x0004CF79
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginVehiclePursuit_Networked(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			this.RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652(target, vehicle, beginAsSighted);
			this.RpcLogic___BeginVehiclePursuit_Networked_2261819652(target, vehicle, beginAsSighted);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0004EDA0 File Offset: 0x0004CFA0
		[ObserversRpc(RunLocally = true)]
		private void BeginVehiclePursuit(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			this.RpcWriter___Observers_BeginVehiclePursuit_2261819652(target, vehicle, beginAsSighted);
			this.RpcLogic___BeginVehiclePursuit_2261819652(target, vehicle, beginAsSighted);
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0004EDD1 File Offset: 0x0004CFD1
		public void BeginBodySearch_LocalPlayer()
		{
			this.BeginBodySearch_Networked(Player.Local.NetworkObject);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0004EDE3 File Offset: 0x0004CFE3
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginBodySearch_Networked(NetworkObject target)
		{
			this.RpcWriter___Server_BeginBodySearch_Networked_3323014238(target);
			this.RpcLogic___BeginBodySearch_Networked_3323014238(target);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0004EDF9 File Offset: 0x0004CFF9
		[ObserversRpc(RunLocally = true)]
		private void BeginBodySearch(NetworkObject target)
		{
			this.RpcWriter___Observers_BeginBodySearch_3323014238(target);
			this.RpcLogic___BeginBodySearch_3323014238(target);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0004EE10 File Offset: 0x0004D010
		[ObserversRpc(RunLocally = true)]
		public virtual void AssignToCheckpoint(CheckpointManager.ECheckpointLocation location)
		{
			this.RpcWriter___Observers_AssignToCheckpoint_4087078542(location);
			this.RpcLogic___AssignToCheckpoint_4087078542(location);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0004EE31 File Offset: 0x0004D031
		public void UnassignFromCheckpoint()
		{
			this.CheckpointBehaviour.Disable_Networked(null);
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = null;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0004EE50 File Offset: 0x0004D050
		public void StartFootPatrol(PatrolGroup group, bool warpToStartPoint)
		{
			this.FootPatrolBehaviour.SetGroup(group);
			this.FootPatrolBehaviour.Enable_Networked(null);
			if (warpToStartPoint)
			{
				this.movement.Warp(group.GetDestination(this));
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0004EE7F File Offset: 0x0004D07F
		public void StartVehiclePatrol(VehiclePatrolRoute route, LandVehicle vehicle)
		{
			this.VehiclePatrolBehaviour.Vehicle = vehicle;
			this.VehiclePatrolBehaviour.SetRoute(route);
			this.VehiclePatrolBehaviour.Enable_Networked(null);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0004EEA5 File Offset: 0x0004D0A5
		public virtual void AssignToSentryLocation(SentryLocation location)
		{
			this.SentryBehaviour.AssignLocation(location);
			this.SentryBehaviour.Enable();
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0004EEBE File Offset: 0x0004D0BE
		public void UnassignFromSentryLocation()
		{
			this.SentryBehaviour.UnassignLocation();
			this.SentryBehaviour.Disable();
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0004EED6 File Offset: 0x0004D0D6
		public void Activate()
		{
			this.timeSinceReadyToPool = 0f;
			this.timeSinceOutOfSight = 0f;
			base.ExitBuilding("");
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0004EEFC File Offset: 0x0004D0FC
		public void Deactivate()
		{
			if (!InstanceFinder.IsServer)
			{
				Console.LogError("Attempted to deactivate an officer on the client", null);
				return;
			}
			if (this.AssignedVehicle != null)
			{
				Singleton<CoroutineService>.Instance.StartCoroutine(this.<Deactivate>g__Wait|59_0());
			}
			base.EnterBuilding(null, Singleton<Map>.Instance.PoliceStation.GUID.ToString(), 0);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0004EF60 File Offset: 0x0004D160
		protected override bool ShouldNoticeGeneralCrime(Player player)
		{
			return !(this.TargetPlayerNOB != null) && base.ShouldNoticeGeneralCrime(player);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000141BA File Offset: 0x000123BA
		public override bool ShouldSave()
		{
			return false;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0004EF79 File Offset: 0x0004D179
		public override string GetNameAddress()
		{
			return "Officer " + this.LastName;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0004EF8C File Offset: 0x0004D18C
		private void UpdateChatter()
		{
			this.chatterCountDown -= Time.deltaTime;
			if (this.chatterCountDown <= 0f)
			{
				this.chatterCountDown = Random.Range(15f, 45f);
				if (this.ChatterEnabled && this.ChatterVO.gameObject.activeInHierarchy)
				{
					this.ChatterVO.Play(EVOLineType.PoliceChatter);
				}
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0004EFF4 File Offset: 0x0004D1F4
		private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			if (PoliceOfficer.OnPoliceVisionEvent != null)
			{
				PoliceOfficer.OnPoliceVisionEvent(visionEventReceipt);
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0004F008 File Offset: 0x0004D208
		public virtual void UpdateBodySearch()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.CanInvestigate())
			{
				return;
			}
			if (this.currentBodySearchInvestigation != null)
			{
				this.UpdateExistingInvestigation();
			}
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0004F029 File Offset: 0x0004D229
		private bool CanInvestigate()
		{
			return !this.VehiclePursuitBehaviour.Active && !this.PursuitBehaviour.Active && !this.BodySearchBehaviour.Active && !(base.CurrentBuilding != null);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0004F068 File Offset: 0x0004D268
		private void UpdateExistingInvestigation()
		{
			if (!this.CanInvestigatePlayer(this.currentBodySearchInvestigation.Target))
			{
				this.StopBodySearchInvestigation();
				return;
			}
			Player target = this.currentBodySearchInvestigation.Target;
			float playerVisibility = this.awareness.VisionCone.GetPlayerVisibility(target);
			float suspiciousness = target.VisualState.Suspiciousness;
			float num = Mathf.Lerp(0.2f, 2f, suspiciousness);
			float num2 = Mathf.Lerp(0.4f, 1f, playerVisibility);
			float num3 = Mathf.Lerp(1f, 0.05f, Vector3.Distance(this.Avatar.CenterPoint, target.Avatar.CenterPoint) / 12f);
			float num4 = num2 * num * num3;
			if (Application.isEditor && Input.GetKey(KeyCode.B))
			{
				num4 = 0.5f;
			}
			if (num4 < 0.08f)
			{
				num4 = -0.08f;
			}
			else if (num4 < 0.12f)
			{
				num4 = 0f;
			}
			this.currentBodySearchInvestigation.ChangeProgress(num4 * Time.deltaTime);
			if (this.currentBodySearchInvestigation.CurrentProgress >= 1f)
			{
				this.ConductBodySearch(this.currentBodySearchInvestigation.Target);
				this.StopBodySearchInvestigation();
				return;
			}
			if (this.currentBodySearchInvestigation.CurrentProgress <= -0.1f)
			{
				this.StopBodySearchInvestigation();
				return;
			}
			if (this.currentBodySearchInvestigation.CurrentProgress >= 0f)
			{
				float speed = Mathf.Lerp(0.05f, 0f, this.currentBodySearchInvestigation.CurrentProgress);
				base.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("consideringbodysearch", 5, speed));
				this.Avatar.LookController.OverrideLookTarget(target.EyePosition, 10, this.currentBodySearchInvestigation.CurrentProgress >= 0.2f);
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0004F21C File Offset: 0x0004D41C
		private void CheckNewInvestigation()
		{
			if (this.currentBodySearchInvestigation != null)
			{
				return;
			}
			if (!this.CanInvestigate())
			{
				return;
			}
			if (this.BodySearchChance <= 0f)
			{
				return;
			}
			foreach (Player player in Player.PlayerList)
			{
				if (this.CanInvestigatePlayer(player) && Vector3.Distance(this.Avatar.CenterPoint, player.Avatar.CenterPoint) <= 8f)
				{
					float playerVisibility = this.awareness.VisionCone.GetPlayerVisibility(player);
					if (playerVisibility >= 0.2f)
					{
						float suspiciousness = player.VisualState.Suspiciousness;
						float num = Mathf.Lerp(0.2f, 2f, suspiciousness);
						float num2 = Mathf.Lerp(0.4f, 1f, playerVisibility);
						float num3 = Mathf.Lerp(0.5f, 1f, this.Suspicion);
						float num4 = Mathf.Clamp01(this.BodySearchChance * num * num2 * num3 * 1f);
						if (Random.Range(0f, 1f) < num4)
						{
							this.currentBodySearchInvestigation = new Investigation(player);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0004F360 File Offset: 0x0004D560
		private void StartBodySearchInvestigation(Player player)
		{
			Console.Log("Starting body search investigation", null);
			this.currentBodySearchInvestigation = new Investigation(player);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0004F379 File Offset: 0x0004D579
		private void StopBodySearchInvestigation()
		{
			this.currentBodySearchInvestigation = null;
			base.Movement.SpeedController.RemoveSpeedControl("consideringbodysearch");
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0004F397 File Offset: 0x0004D597
		public void ConductBodySearch(Player player)
		{
			Console.Log("Conducting body search on " + player.PlayerName, null);
			this.BodySearchBehaviour.AssignTarget(null, player.NetworkObject);
			this.BodySearchBehaviour.Enable_Networked(null);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0004F3D0 File Offset: 0x0004D5D0
		private bool CanInvestigatePlayer(Player player)
		{
			return !(player == null) && player.Health.IsAlive && !player.CrimeData.BodySearchPending && player.CrimeData.CurrentPursuitLevel <= PlayerCrimeData.EPursuitLevel.None && player.CrimeData.TimeSinceLastBodySearch >= 60f && !player.IsArrested;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0004F49A File Offset: 0x0004D69A
		[CompilerGenerated]
		private IEnumerator <Deactivate>g__Wait|59_0()
		{
			yield return new WaitUntil(() => !this.AssignedVehicle.isOccupied);
			this.AssignedVehicle.DestroyVehicle();
			yield break;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0004F4BC File Offset: 0x0004D6BC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<TargetPlayerNOB>k__BackingField = new SyncVar<NetworkObject>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.<TargetPlayerNOB>k__BackingField);
			base.RegisterServerRpc(35U, new ServerRpcDelegate(this.RpcReader___Server_BeginFootPursuit_Networked_419679943));
			base.RegisterObserversRpc(36U, new ClientRpcDelegate(this.RpcReader___Observers_BeginFootPursuitTest_3615296227));
			base.RegisterServerRpc(37U, new ServerRpcDelegate(this.RpcReader___Server_BeginVehiclePursuit_Networked_2261819652));
			base.RegisterObserversRpc(38U, new ClientRpcDelegate(this.RpcReader___Observers_BeginVehiclePursuit_2261819652));
			base.RegisterServerRpc(39U, new ServerRpcDelegate(this.RpcReader___Server_BeginBodySearch_Networked_3323014238));
			base.RegisterObserversRpc(40U, new ClientRpcDelegate(this.RpcReader___Observers_BeginBodySearch_3323014238));
			base.RegisterObserversRpc(41U, new ClientRpcDelegate(this.RpcReader___Observers_AssignToCheckpoint_4087078542));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Police.PoliceOfficer));
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0004F5BE File Offset: 0x0004D7BE
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<TargetPlayerNOB>k__BackingField.SetRegistered();
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0004F5E2 File Offset: 0x0004D7E2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0004F5F0 File Offset: 0x0004D7F0
		private void RpcWriter___Server_BeginFootPursuit_Networked_419679943(NetworkObject target, bool includeColleagues = true)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(target);
			writer.WriteBoolean(includeColleagues);
			base.SendServerRpc(35U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0004F6A4 File Offset: 0x0004D8A4
		public virtual void RpcLogic___BeginFootPursuit_Networked_419679943(NetworkObject target, bool includeColleagues = true)
		{
			if (target == null)
			{
				Console.LogError("Attempted to begin foot pursuit with null target", null);
				return;
			}
			this.BeginFootPursuitTest(target.GetComponent<Player>().PlayerCode);
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.BodySearchBehaviour.Disable_Networked(null);
			if (includeColleagues)
			{
				if (this.FootPatrolBehaviour.Enabled && this.FootPatrolBehaviour.Group != null)
				{
					for (int i = 0; i < this.FootPatrolBehaviour.Group.Members.Count; i++)
					{
						if (!(this.FootPatrolBehaviour.Group.Members[i] == this))
						{
							(this.FootPatrolBehaviour.Group.Members[i] as PoliceOfficer).BeginFootPursuitTest(target.GetComponent<Player>().PlayerCode);
						}
					}
				}
				if (this.CheckpointBehaviour.Enabled && this.CheckpointBehaviour.Checkpoint != null)
				{
					for (int j = 0; j < this.CheckpointBehaviour.Checkpoint.AssignedNPCs.Count; j++)
					{
						if (!(this.CheckpointBehaviour.Checkpoint.AssignedNPCs[j] == this))
						{
							(this.CheckpointBehaviour.Checkpoint.AssignedNPCs[j] as PoliceOfficer).BeginFootPursuitTest(target.GetComponent<Player>().PlayerCode);
						}
					}
				}
				if (this.SentryBehaviour.Enabled && this.SentryBehaviour.AssignedLocation != null)
				{
					for (int k = 0; k < this.SentryBehaviour.AssignedLocation.AssignedOfficers.Count; k++)
					{
						if (!(this.SentryBehaviour.AssignedLocation.AssignedOfficers[k] == this))
						{
							this.SentryBehaviour.AssignedLocation.AssignedOfficers[k].BeginFootPursuitTest(target.GetComponent<Player>().PlayerCode);
						}
					}
				}
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0004F884 File Offset: 0x0004DA84
		private void RpcReader___Server_BeginFootPursuit_Networked_419679943(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject target = PooledReader0.ReadNetworkObject();
			bool includeColleagues = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___BeginFootPursuit_Networked_419679943(target, includeColleagues);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0004F8D4 File Offset: 0x0004DAD4
		private void RpcWriter___Observers_BeginFootPursuitTest_3615296227(string playerCode)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteString(playerCode);
			base.SendObserversRpc(36U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0004F98C File Offset: 0x0004DB8C
		private void RpcLogic___BeginFootPursuitTest_3615296227(string playerCode)
		{
			this.TargetPlayerNOB = Player.GetPlayer(playerCode).NetworkObject;
			if (this.TargetPlayerNOB == null)
			{
				Console.LogError("Attempted to begin foot pursuit with null target", null);
				return;
			}
			this.PursuitBehaviour.AssignTarget(null, this.TargetPlayerNOB);
			this.PursuitBehaviour.Enable();
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0004F9E4 File Offset: 0x0004DBE4
		private void RpcReader___Observers_BeginFootPursuitTest_3615296227(PooledReader PooledReader0, Channel channel)
		{
			string playerCode = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___BeginFootPursuitTest_3615296227(playerCode);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0004FA20 File Offset: 0x0004DC20
		private void RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(target);
			writer.WriteNetworkObject(vehicle);
			writer.WriteBoolean(beginAsSighted);
			base.SendServerRpc(37U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0004FAE1 File Offset: 0x0004DCE1
		public virtual void RpcLogic___BeginVehiclePursuit_Networked_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			this.BeginVehiclePursuit(target, vehicle, beginAsSighted);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0004FAEC File Offset: 0x0004DCEC
		private void RpcReader___Server_BeginVehiclePursuit_Networked_2261819652(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject target = PooledReader0.ReadNetworkObject();
			NetworkObject vehicle = PooledReader0.ReadNetworkObject();
			bool beginAsSighted = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___BeginVehiclePursuit_Networked_2261819652(target, vehicle, beginAsSighted);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0004FB4C File Offset: 0x0004DD4C
		private void RpcWriter___Observers_BeginVehiclePursuit_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(target);
			writer.WriteNetworkObject(vehicle);
			writer.WriteBoolean(beginAsSighted);
			base.SendObserversRpc(38U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0004FC1C File Offset: 0x0004DE1C
		private void RpcLogic___BeginVehiclePursuit_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			this.TargetPlayerNOB = target.GetComponent<Player>().NetworkObject;
			this.VehiclePursuitBehaviour.vehicle = vehicle.GetComponent<LandVehicle>();
			this.VehiclePursuitBehaviour.AssignTarget(this.TargetPlayerNOB.GetComponent<Player>());
			if (beginAsSighted)
			{
				this.VehiclePursuitBehaviour.BeginAsSighted();
			}
			this.VehiclePursuitBehaviour.Enable();
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0004FC7C File Offset: 0x0004DE7C
		private void RpcReader___Observers_BeginVehiclePursuit_2261819652(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject target = PooledReader0.ReadNetworkObject();
			NetworkObject vehicle = PooledReader0.ReadNetworkObject();
			bool beginAsSighted = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___BeginVehiclePursuit_2261819652(target, vehicle, beginAsSighted);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0004FCDC File Offset: 0x0004DEDC
		private void RpcWriter___Server_BeginBodySearch_Networked_3323014238(NetworkObject target)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(target);
			base.SendServerRpc(39U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0004FD83 File Offset: 0x0004DF83
		public virtual void RpcLogic___BeginBodySearch_Networked_3323014238(NetworkObject target)
		{
			this.BeginBodySearch(target);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0004FD8C File Offset: 0x0004DF8C
		private void RpcReader___Server_BeginBodySearch_Networked_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject target = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___BeginBodySearch_Networked_3323014238(target);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0004FDCC File Offset: 0x0004DFCC
		private void RpcWriter___Observers_BeginBodySearch_3323014238(NetworkObject target)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteNetworkObject(target);
			base.SendObserversRpc(40U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0004FE82 File Offset: 0x0004E082
		private void RpcLogic___BeginBodySearch_3323014238(NetworkObject target)
		{
			this.TargetPlayerNOB = target.GetComponent<Player>().NetworkObject;
			this.BodySearchBehaviour.AssignTarget(null, target);
			this.BodySearchBehaviour.Enable();
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0004FEB0 File Offset: 0x0004E0B0
		private void RpcReader___Observers_BeginBodySearch_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject target = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___BeginBodySearch_3323014238(target);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0004FEEC File Offset: 0x0004E0EC
		private void RpcWriter___Observers_AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Law.CheckpointManager/ECheckpointLocationFishNet.Serializing.Generated(location);
			base.SendObserversRpc(41U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0004FFA4 File Offset: 0x0004E1A4
		public virtual void RpcLogic___AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
			this.movement.Warp(NetworkSingleton<CheckpointManager>.Instance.GetCheckpoint(location).transform.position);
			this.CheckpointBehaviour.SetCheckpoint(location);
			this.CheckpointBehaviour.Enable();
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = this.CheckpointDialogue;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00050000 File Offset: 0x0004E200
		private void RpcReader___Observers_AssignToCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
			CheckpointManager.ECheckpointLocation location = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Law.CheckpointManager/ECheckpointLocationFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___AssignToCheckpoint_4087078542(location);
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x0005003B File Offset: 0x0004E23B
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00050043 File Offset: 0x0004E243
		public NetworkObject SyncAccessor_<TargetPlayerNOB>k__BackingField
		{
			get
			{
				return this.<TargetPlayerNOB>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<TargetPlayerNOB>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<TargetPlayerNOB>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00050080 File Offset: 0x0004E280
		public virtual bool PoliceOfficer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 != 1U)
			{
				return false;
			}
			if (PooledReader0 == null)
			{
				this.sync___set_value_<TargetPlayerNOB>k__BackingField(this.syncVar___<TargetPlayerNOB>k__BackingField.GetValue(true), true);
				return true;
			}
			NetworkObject value = PooledReader0.ReadNetworkObject();
			this.sync___set_value_<TargetPlayerNOB>k__BackingField(value, Boolean2);
			return true;
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000500D4 File Offset: 0x0004E2D4
		protected virtual void dll()
		{
			base.Awake();
			if (!PoliceOfficer.Officers.Contains(this))
			{
				PoliceOfficer.Officers.Add(this);
			}
			this.PursuitBehaviour.onEnd.AddListener(new UnityAction(delegate()
			{
				this.TargetPlayerNOB = null;
			}));
			base.InvokeRepeating("CheckNewInvestigation", 1f, 1f);
			this.chatterCountDown = Random.Range(15f, 45f);
			VisionCone visionCone = this.awareness.VisionCone;
			visionCone.onVisionEventFull = (VisionCone.EventStateChange)Delegate.Combine(visionCone.onVisionEventFull, new VisionCone.EventStateChange(this.ProcessVisionEvent));
		}

		// Token: 0x0400117B RID: 4475
		public const float DEACTIVATION_TIME = 1f;

		// Token: 0x0400117C RID: 4476
		public const float INVESTIGATION_COOLDOWN = 60f;

		// Token: 0x0400117D RID: 4477
		public const float INVESTIGATION_MAX_DISTANCE = 8f;

		// Token: 0x0400117E RID: 4478
		public const float INVESTIGATION_MIN_VISIBILITY = 0.2f;

		// Token: 0x0400117F RID: 4479
		public const float INVESTIGATION_CHECK_INTERVAL = 1f;

		// Token: 0x04001180 RID: 4480
		public const float BODY_SEARCH_CHANCE_DEFAULT = 0.1f;

		// Token: 0x04001181 RID: 4481
		public const float MIN_CHATTER_INTERVAL = 15f;

		// Token: 0x04001182 RID: 4482
		public const float MAX_CHATTER_INTERVAL = 45f;

		// Token: 0x04001183 RID: 4483
		public static Action<VisionEventReceipt> OnPoliceVisionEvent;

		// Token: 0x04001184 RID: 4484
		public static List<PoliceOfficer> Officers = new List<PoliceOfficer>();

		// Token: 0x04001186 RID: 4486
		public LandVehicle AssignedVehicle;

		// Token: 0x04001187 RID: 4487
		[Header("References")]
		public PursuitBehaviour PursuitBehaviour;

		// Token: 0x04001188 RID: 4488
		public VehiclePursuitBehaviour VehiclePursuitBehaviour;

		// Token: 0x04001189 RID: 4489
		public BodySearchBehaviour BodySearchBehaviour;

		// Token: 0x0400118A RID: 4490
		public CheckpointBehaviour CheckpointBehaviour;

		// Token: 0x0400118B RID: 4491
		public FootPatrolBehaviour FootPatrolBehaviour;

		// Token: 0x0400118C RID: 4492
		public ProximityCircle ProxCircle;

		// Token: 0x0400118D RID: 4493
		public VehiclePatrolBehaviour VehiclePatrolBehaviour;

		// Token: 0x0400118E RID: 4494
		public SentryBehaviour SentryBehaviour;

		// Token: 0x0400118F RID: 4495
		public PoliceChatterVO ChatterVO;

		// Token: 0x04001190 RID: 4496
		[Header("Dialogue")]
		public DialogueContainer CheckpointDialogue;

		// Token: 0x04001191 RID: 4497
		[Header("Tools")]
		public AvatarEquippable BatonPrefab;

		// Token: 0x04001192 RID: 4498
		public AvatarEquippable TaserPrefab;

		// Token: 0x04001193 RID: 4499
		public AvatarEquippable GunPrefab;

		// Token: 0x04001194 RID: 4500
		[Header("Settings")]
		public bool AutoDeactivate = true;

		// Token: 0x04001195 RID: 4501
		public bool ChatterEnabled = true;

		// Token: 0x04001196 RID: 4502
		[Header("Behaviour Settings")]
		[Range(0f, 1f)]
		public float Suspicion = 0.5f;

		// Token: 0x04001197 RID: 4503
		[Range(0f, 1f)]
		public float Leniency = 0.5f;

		// Token: 0x04001198 RID: 4504
		[Header("Body Search Settings")]
		[Range(0f, 1f)]
		public float BodySearchChance = 0.1f;

		// Token: 0x04001199 RID: 4505
		[Range(1f, 10f)]
		public float BodySearchDuration = 5f;

		// Token: 0x0400119A RID: 4506
		[HideInInspector]
		public PoliceBelt belt;

		// Token: 0x0400119B RID: 4507
		private float timeSinceReadyToPool;

		// Token: 0x0400119C RID: 4508
		private float timeSinceOutOfSight;

		// Token: 0x0400119D RID: 4509
		private float chatterCountDown;

		// Token: 0x0400119E RID: 4510
		private Investigation currentBodySearchInvestigation;

		// Token: 0x0400119F RID: 4511
		public SyncVar<NetworkObject> syncVar___<TargetPlayerNOB>k__BackingField;

		// Token: 0x040011A0 RID: 4512
		private bool dll_Excuted;

		// Token: 0x040011A1 RID: 4513
		private bool dll_Excuted;
	}
}
