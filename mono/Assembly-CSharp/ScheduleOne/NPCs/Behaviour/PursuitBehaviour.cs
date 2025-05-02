using System;
using System.Collections;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.DevUtilities;
using ScheduleOne.Noise;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vision;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000529 RID: 1321
	public class PursuitBehaviour : Behaviour
	{
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x000818F2 File Offset: 0x0007FAF2
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x000818FA File Offset: 0x0007FAFA
		public Player TargetPlayer { get; protected set; }

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x00081903 File Offset: 0x0007FB03
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0008190B File Offset: 0x0007FB0B
		public bool IsSearching { get; protected set; }

		// Token: 0x06001FBB RID: 8123 RVA: 0x00081914 File Offset: 0x0007FB14
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.PursuitBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00081933 File Offset: 0x0007FB33
		private void OnDestroy()
		{
			PoliceOfficer.OnPoliceVisionEvent = (Action<VisionEventReceipt>)Delegate.Remove(PoliceOfficer.OnPoliceVisionEvent, new Action<VisionEventReceipt>(this.ProcessThirdPartyVisionEvent));
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x00081955 File Offset: 0x0007FB55
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (base.Active && this.TargetPlayer != null)
			{
				this.AssignTarget(connection, this.TargetPlayer.NetworkObject);
			}
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x00081988 File Offset: 0x0007FB88
		[ObserversRpc(RunLocally = true)]
		public virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
			this.RpcWriter___Observers_AssignTarget_1824087381(conn, target);
			this.RpcLogic___AssignTarget_1824087381(conn, target);
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x000819B4 File Offset: 0x0007FBB4
		protected override void Begin()
		{
			base.Begin();
			this.CheckPlayerVisibility();
			this.sync___set_value_isTargetVisible(true, true);
			this.nextAngryVO = Time.time + Random.Range(5f, 15f);
			this.officer.ProxCircle.SetRadius(2.5f);
			this.officer.Avatar.EmotionManager.AddEmotionOverride((Random.Range(0f, 1f) > 0.5f) ? "Angry" : "Annoyed", "pursuit", 0f, 0);
			this.officer.Movement.SetStance(NPCMovement.EStance.Stanced);
			this.officer.Movement.SetAgentType(NPCMovement.EAgentType.IgnoreCosts);
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00081A6C File Offset: 0x0007FC6C
		protected override void Resume()
		{
			base.Resume();
			this.CheckPlayerVisibility();
			this.sync___set_value_isTargetVisible(true, true);
			this.nextAngryVO = Time.time + Random.Range(5f, 15f);
			this.officer.ProxCircle.SetRadius(2.5f);
			this.officer.Avatar.EmotionManager.AddEmotionOverride((Random.Range(0f, 1f) > 0.5f) ? "Angry" : "Annoyed", "pursuit", 0f, 0);
			this.officer.Movement.SetStance(NPCMovement.EStance.Stanced);
			this.officer.Movement.SetAgentType(NPCMovement.EAgentType.IgnoreCosts);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00081B24 File Offset: 0x0007FD24
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			this.UpdateLookAt();
			this.UpdateArrest(Time.deltaTime);
			this.UpdateArrestCircle();
			this.SetWorldspaceIconsActive(this.timeSinceLastSighting < 3f || this.timeSinceLastSighting > 10f);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00081B74 File Offset: 0x0007FD74
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (Time.time > this.nextAngryVO)
			{
				EVOLineType lineType = (Random.Range(0, 2) == 0) ? EVOLineType.Angry : EVOLineType.Command;
				base.Npc.PlayVO(lineType);
				this.nextAngryVO = Time.time + Random.Range(5f, 15f);
			}
			if (InstanceFinder.IsServer)
			{
				if (!this.IsTargetValid())
				{
					base.Disable_Networked(null);
					return;
				}
				if (this.rangedWeaponRoutine != null && this.TargetPlayer.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.NonLethal && this.TargetPlayer.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.Lethal)
				{
					this.StopRangedWeaponRoutine();
				}
			}
			if (!this.IsTargetValid())
			{
				return;
			}
			if (this.IsSearching)
			{
				if (this.SyncAccessor_isTargetVisible || this.TargetPlayer.CrimeData.TimeSinceSighted < 1f)
				{
					this.StopSearching();
				}
			}
			else
			{
				switch (this.TargetPlayer.CrimeData.CurrentPursuitLevel)
				{
				case PlayerCrimeData.EPursuitLevel.None:
					if (InstanceFinder.IsServer)
					{
						base.End_Networked(null);
					}
					break;
				case PlayerCrimeData.EPursuitLevel.Investigating:
					this.UpdateInvestigatingBehaviour();
					break;
				case PlayerCrimeData.EPursuitLevel.Arresting:
					this.UpdateArrestBehaviour();
					break;
				case PlayerCrimeData.EPursuitLevel.NonLethal:
					this.UpdateNonLethalBehaviour();
					break;
				case PlayerCrimeData.EPursuitLevel.Lethal:
					this.UpdateLethalBehaviour();
					break;
				}
			}
			this.UpdateEquippable();
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00081CB0 File Offset: 0x0007FEB0
		private bool IsTargetValid()
		{
			return !(this.TargetPlayer == null) && !this.TargetPlayer.IsArrested && !this.TargetPlayer.IsUnconscious && this.TargetPlayer.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00081D00 File Offset: 0x0007FF00
		protected virtual void FixedUpdate()
		{
			if (!base.Active)
			{
				return;
			}
			this.CheckPlayerVisibility();
			this.currentPursuitLevelDuration += Time.fixedDeltaTime;
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00081D24 File Offset: 0x0007FF24
		protected virtual void UpdateInvestigatingBehaviour()
		{
			this.arrestingEnabled = false;
			if (InstanceFinder.IsServer && !base.Npc.Movement.SpeedController.DoesSpeedControlExist("investigating"))
			{
				base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("investigating", 50, 0.35f));
			}
			if (Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) >= 2.5f)
			{
				if (this.isTargetStrictlyVisible && this.SyncAccessor_isTargetVisible)
				{
					this.TargetPlayer.CrimeData.Escalate();
					return;
				}
				if (InstanceFinder.IsServer)
				{
					if (!base.Npc.Movement.IsMoving && Vector3.Distance(this.TargetPlayer.CrimeData.LastKnownPosition, base.transform.position) < 2.5f)
					{
						this.StartSearching();
						return;
					}
					if (!base.Npc.Movement.IsMoving || Vector3.Distance(this.TargetPlayer.CrimeData.LastKnownPosition, base.Npc.Movement.CurrentDestination) > 2.5f)
					{
						if (base.Npc.Movement.CanGetTo(this.TargetPlayer.CrimeData.LastKnownPosition, 2.5f))
						{
							base.Npc.Movement.SetDestination(this.TargetPlayer.CrimeData.LastKnownPosition);
							return;
						}
						this.StartSearching();
						return;
					}
				}
			}
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00081EA4 File Offset: 0x000800A4
		protected virtual void UpdateArrestBehaviour()
		{
			this.arrestingEnabled = true;
			if (InstanceFinder.IsServer)
			{
				if (!base.Npc.Movement.SpeedController.DoesSpeedControlExist("arresting"))
				{
					base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("arresting", 50, 0.6f));
				}
				if (Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) >= 2.5f)
				{
					if (this.SyncAccessor_isTargetVisible)
					{
						bool flag = false;
						if (!base.Npc.Movement.IsMoving)
						{
							flag = true;
						}
						if (Vector3.Distance(this.TargetPlayer.Avatar.CenterPoint, base.Npc.Movement.CurrentDestination) > 2.5f)
						{
							flag = true;
						}
						if (flag)
						{
							base.Npc.Movement.SetDestination(this.GetNewArrestDestination());
						}
					}
					else
					{
						if (!base.Npc.Movement.IsMoving && Vector3.Distance(this.TargetPlayer.CrimeData.LastKnownPosition, base.transform.position) < 2.5f)
						{
							this.StartSearching();
							return;
						}
						if (!base.Npc.Movement.IsMoving || Vector3.Distance(this.TargetPlayer.CrimeData.LastKnownPosition, base.Npc.Movement.CurrentDestination) > 2.5f)
						{
							if (!base.Npc.Movement.CanGetTo(this.TargetPlayer.CrimeData.LastKnownPosition, 2.5f))
							{
								this.StartSearching();
								return;
							}
							base.Npc.Movement.SetDestination(this.TargetPlayer.CrimeData.LastKnownPosition);
						}
					}
				}
			}
			if (Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) > Mathf.Max(15f, this.distanceOnPursuitStart + 5f) && this.timeSinceLastSighting < 1f)
			{
				Debug.Log("Target too far! Escalating");
				this.TargetPlayer.CrimeData.Escalate();
			}
			if (this.TargetPlayer.CurrentVehicle != null && !this.targetWasDrivingOnPursuitStart && this.timeSinceLastSighting < 1f)
			{
				Debug.Log("Target got in vehicle! Escalating");
				this.TargetPlayer.CrimeData.Escalate();
			}
			if (this.leaveArrestCircleCount >= 3 && this.timeSinceLastSighting < 1f)
			{
				Debug.Log("Left arrest circle too many times! Escalating");
				this.TargetPlayer.CrimeData.Escalate();
			}
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0008213C File Offset: 0x0008033C
		private void UpdateArrest(float tick)
		{
			if (this.TargetPlayer == null)
			{
				return;
			}
			if (Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) < 2.5f && this.arrestingEnabled && this.SyncAccessor_isTargetVisible)
			{
				this.timeWithinArrestRange += tick;
				if (this.timeWithinArrestRange > 0.5f)
				{
					this.wasInArrestCircleLastFrame = true;
				}
			}
			else
			{
				if (this.wasInArrestCircleLastFrame)
				{
					this.leaveArrestCircleCount++;
					this.wasInArrestCircleLastFrame = false;
				}
				this.timeWithinArrestRange = Mathf.Clamp(this.timeWithinArrestRange - tick, 0f, float.MaxValue);
			}
			if (this.TargetPlayer.IsOwner && this.timeWithinArrestRange / 1.75f > this.TargetPlayer.CrimeData.CurrentArrestProgress)
			{
				this.TargetPlayer.CrimeData.SetArrestProgress(this.timeWithinArrestRange / 1.75f);
			}
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00082234 File Offset: 0x00080434
		private Vector3 GetNewArrestDestination()
		{
			return this.TargetPlayer.Avatar.CenterPoint + (base.transform.position - this.TargetPlayer.Avatar.CenterPoint).normalized * 0.75f;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00082288 File Offset: 0x00080488
		private void ClearSpeedControls()
		{
			if (base.Npc.Movement.SpeedController.DoesSpeedControlExist("investigating"))
			{
				base.Npc.Movement.SpeedController.RemoveSpeedControl("investigating");
			}
			if (base.Npc.Movement.SpeedController.DoesSpeedControlExist("arresting"))
			{
				base.Npc.Movement.SpeedController.RemoveSpeedControl("arresting");
			}
			if (base.Npc.Movement.SpeedController.DoesSpeedControlExist("chasing"))
			{
				base.Npc.Movement.SpeedController.RemoveSpeedControl("chasing");
			}
			if (base.Npc.Movement.SpeedController.DoesSpeedControlExist("shooting"))
			{
				base.Npc.Movement.SpeedController.RemoveSpeedControl("shooting");
			}
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0008236D File Offset: 0x0008056D
		protected virtual void UpdateNonLethalBehaviour()
		{
			this.arrestingEnabled = true;
			if (InstanceFinder.IsServer && this.rangedWeaponRoutine == null)
			{
				this.rangedWeaponRoutine = base.StartCoroutine(this.RangedWeaponRoutine());
			}
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0008236D File Offset: 0x0008056D
		protected virtual void UpdateLethalBehaviour()
		{
			this.arrestingEnabled = true;
			if (InstanceFinder.IsServer && this.rangedWeaponRoutine == null)
			{
				this.rangedWeaponRoutine = base.StartCoroutine(this.RangedWeaponRoutine());
			}
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00082397 File Offset: 0x00080597
		private IEnumerator RangedWeaponRoutine()
		{
			PursuitBehaviour.EPursuitAction currentAction = PursuitBehaviour.EPursuitAction.None;
			float currentActionDuration = 0f;
			float currentActionTime = 0f;
			for (;;)
			{
				if (this.rangedWeapon == null)
				{
					yield return new WaitForEndOfFrame();
				}
				else
				{
					float num = Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint);
					if (this.SyncAccessor_isTargetVisible && num > this.rangedWeapon.MinUseRange && num < this.rangedWeapon.MaxUseRange)
					{
						currentActionDuration += Time.deltaTime;
						if (currentActionDuration > currentActionTime)
						{
							currentAction = PursuitBehaviour.EPursuitAction.None;
						}
						if (currentAction == PursuitBehaviour.EPursuitAction.None)
						{
							currentActionDuration = 0f;
							PursuitBehaviour.EPursuitAction epursuitAction;
							if (this.rangedWeapon.CanShootWhileMoving)
							{
								if (Random.Range(0, 3) == 0)
								{
									epursuitAction = PursuitBehaviour.EPursuitAction.Move;
								}
								else if ((double)num < (double)this.rangedWeapon.MaxUseRange * 0.5)
								{
									epursuitAction = PursuitBehaviour.EPursuitAction.Shoot;
								}
								else
								{
									epursuitAction = PursuitBehaviour.EPursuitAction.MoveAndShoot;
								}
							}
							else
							{
								epursuitAction = ((Random.Range(0, 2) == 0) ? PursuitBehaviour.EPursuitAction.Move : PursuitBehaviour.EPursuitAction.Shoot);
							}
							if (this.TargetPlayer.CrimeData.timeSinceLastShot < 2f)
							{
								epursuitAction = PursuitBehaviour.EPursuitAction.Move;
							}
							this.SetWeaponRaised(epursuitAction == PursuitBehaviour.EPursuitAction.Shoot || epursuitAction == PursuitBehaviour.EPursuitAction.MoveAndShoot);
							this.consecutiveMissedShots = 0;
							this.ClearSpeedControls();
							if (epursuitAction == PursuitBehaviour.EPursuitAction.Move)
							{
								base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("chasing", 60, 0.8f));
							}
							else if (epursuitAction == PursuitBehaviour.EPursuitAction.MoveAndShoot)
							{
								base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("shooting", 60, 0.15f));
							}
							currentActionTime = Random.Range(3f, 6f);
							currentAction = epursuitAction;
						}
						switch (currentAction)
						{
						case PursuitBehaviour.EPursuitAction.Move:
							if (this.arrestingEnabled)
							{
								if (!base.Npc.Movement.IsMoving && Vector3.Distance(base.Npc.Movement.transform.position, this.TargetPlayer.Avatar.CenterPoint) < 2.5f)
								{
									currentAction = PursuitBehaviour.EPursuitAction.None;
								}
								else if (!base.Npc.Movement.IsMoving || Vector3.Distance(base.Npc.Movement.CurrentDestination, this.TargetPlayer.Avatar.CenterPoint) > 2.5f)
								{
									base.Npc.Movement.SetDestination(this.TargetPlayer.Avatar.CenterPoint);
								}
							}
							else if (!base.Npc.Movement.IsMoving && Vector3.Distance(base.Npc.Movement.transform.position, this.TargetPlayer.Avatar.CenterPoint) < this.rangedWeapon.MaxUseRange)
							{
								currentAction = PursuitBehaviour.EPursuitAction.None;
							}
							else if (!base.Npc.Movement.IsMoving || Vector3.Distance(base.Npc.Movement.CurrentDestination, this.TargetPlayer.Avatar.CenterPoint) > this.rangedWeapon.MaxUseRange)
							{
								float randomRadius = Mathf.Max(Mathf.Min(this.rangedWeapon.MaxUseRange * 0.6f, num), this.rangedWeapon.MinUseRange * 2f);
								base.Npc.Movement.SetDestination(this.GetRandomReachablePointNear(this.TargetPlayer.Avatar.CenterPoint, randomRadius, this.rangedWeapon.MinUseRange));
							}
							break;
						case PursuitBehaviour.EPursuitAction.Shoot:
							if (base.Npc.Movement.IsMoving)
							{
								base.Npc.Movement.Stop();
							}
							if (Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) > this.rangedWeapon.MaxUseRange)
							{
								currentAction = PursuitBehaviour.EPursuitAction.None;
							}
							if (this.CanShoot() && this.Shoot())
							{
								currentAction = PursuitBehaviour.EPursuitAction.None;
							}
							break;
						case PursuitBehaviour.EPursuitAction.MoveAndShoot:
							if (this.arrestingEnabled)
							{
								if (!base.Npc.Movement.IsMoving || Vector3.Distance(base.Npc.Movement.CurrentDestination, this.TargetPlayer.Avatar.CenterPoint) > 2.5f)
								{
									base.Npc.Movement.SetDestination(this.TargetPlayer.Avatar.CenterPoint);
								}
							}
							else if (!base.Npc.Movement.IsMoving || Vector3.Distance(base.Npc.Movement.CurrentDestination, this.TargetPlayer.Avatar.CenterPoint) > this.rangedWeapon.MaxUseRange)
							{
								float randomRadius2 = Mathf.Max(Mathf.Min(this.rangedWeapon.MaxUseRange * 0.6f, num), this.rangedWeapon.MinUseRange * 2f);
								base.Npc.Movement.SetDestination(this.GetRandomReachablePointNear(this.TargetPlayer.Avatar.CenterPoint, randomRadius2, this.rangedWeapon.MinUseRange));
							}
							if (this.CanShoot() && this.Shoot())
							{
								currentAction = PursuitBehaviour.EPursuitAction.None;
							}
							break;
						}
					}
					else
					{
						this.ClearSpeedControls();
						base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("chasing", 60, 0.8f));
						this.SetWeaponRaised(false);
						currentAction = PursuitBehaviour.EPursuitAction.Move;
						if (this.SyncAccessor_isTargetVisible)
						{
							if (this.arrestingEnabled)
							{
								if (!base.Npc.Movement.IsMoving || Vector3.Distance(base.Npc.Movement.CurrentDestination, this.TargetPlayer.Avatar.CenterPoint) > 2.5f)
								{
									base.Npc.Movement.SetDestination(this.TargetPlayer.Avatar.CenterPoint);
								}
							}
							else if (!base.Npc.Movement.IsMoving || Vector3.Distance(base.Npc.Movement.CurrentDestination, this.TargetPlayer.Avatar.CenterPoint) > this.rangedWeapon.MaxUseRange)
							{
								float randomRadius3 = Mathf.Max(Mathf.Min(this.rangedWeapon.MaxUseRange * 0.6f, num), this.rangedWeapon.MinUseRange * 2f);
								base.Npc.Movement.SetDestination(this.GetRandomReachablePointNear(this.TargetPlayer.Avatar.CenterPoint, randomRadius3, this.rangedWeapon.MinUseRange));
							}
						}
						else
						{
							if (!base.Npc.Movement.IsMoving && Vector3.Distance(this.TargetPlayer.CrimeData.LastKnownPosition, base.transform.position) < 2.5f)
							{
								break;
							}
							if (!base.Npc.Movement.IsMoving || Vector3.Distance(this.TargetPlayer.CrimeData.LastKnownPosition, base.Npc.Movement.CurrentDestination) > 2.5f)
							{
								if (!base.Npc.Movement.CanGetTo(this.TargetPlayer.CrimeData.LastKnownPosition, 2.5f))
								{
									goto IL_7B3;
								}
								base.Npc.Movement.SetDestination(this.TargetPlayer.CrimeData.LastKnownPosition);
							}
						}
					}
					yield return new WaitForEndOfFrame();
				}
			}
			this.StartSearching();
			this.StopRangedWeaponRoutine();
			yield break;
			IL_7B3:
			this.StartSearching();
			this.StopRangedWeaponRoutine();
			yield break;
			yield break;
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x000823A8 File Offset: 0x000805A8
		private bool CanShoot()
		{
			return !base.Npc.IsInVehicle && !base.Npc.Avatar.Ragdolled && !base.Npc.Avatar.Anim.StandUpAnimationPlaying && this.isTargetStrictlyVisible && this.rangedWeapon.CanShoot();
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00082408 File Offset: 0x00080608
		private bool Shoot()
		{
			bool flag = false;
			float num = Mathf.Lerp(this.rangedWeapon.HitChange_MinRange, this.rangedWeapon.HitChange_MaxRange, Mathf.Clamp01(Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) / this.rangedWeapon.MaxUseRange));
			num *= this.TargetPlayer.CrimeData.GetShotAccuracyMultiplier();
			num *= 1f + 0.1f * (float)this.consecutiveMissedShots;
			if (Random.Range(0f, 1f) < num)
			{
				flag = true;
			}
			Vector3 vector = this.TargetPlayer.Avatar.CenterPoint;
			bool flag2 = false;
			if (flag && this.rangedWeapon.IsPlayerInLoS(this.TargetPlayer))
			{
				flag2 = true;
			}
			else
			{
				vector += Random.insideUnitSphere * 4f;
				Vector3 normalized = (vector - this.rangedWeapon.MuzzlePoint.position).normalized;
				RaycastHit raycastHit;
				if (Physics.Raycast(this.rangedWeapon.MuzzlePoint.position, normalized, ref raycastHit, this.rangedWeapon.MaxUseRange, LayerMask.GetMask(AvatarRangedWeapon.RaycastLayers)))
				{
					vector = raycastHit.point;
				}
				else
				{
					vector = this.rangedWeapon.MuzzlePoint.position + normalized * this.rangedWeapon.MaxUseRange;
				}
			}
			if (flag2)
			{
				this.consecutiveMissedShots = 0;
				if (this.rangedWeapon is Taser)
				{
					this.TargetPlayer.Taze();
				}
				if (this.rangedWeapon.Damage > 0f && this.TargetPlayer.Health.CanTakeDamage)
				{
					this.TargetPlayer.Health.TakeDamage(this.rangedWeapon.Damage, true, true);
				}
				if (this.rangedWeapon is Handgun)
				{
					NoiseUtility.EmitNoise(this.rangedWeapon.MuzzlePoint.position, ENoiseType.Gunshot, 25f, base.Npc.gameObject);
				}
				this.TargetPlayer.CrimeData.ResetShotAccuracy();
			}
			else
			{
				this.consecutiveMissedShots++;
			}
			base.Npc.SendEquippableMessage_Networked_Vector(null, "Shoot", vector);
			return flag2;
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00082636 File Offset: 0x00080836
		private void SetWeaponRaised(bool raised)
		{
			if (this.rangedWeapon.IsRaised != raised)
			{
				if (raised)
				{
					base.Npc.SendEquippableMessage_Networked(null, "Raise");
					return;
				}
				base.Npc.SendEquippableMessage_Networked(null, "Lower");
			}
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x0008266C File Offset: 0x0008086C
		private void StopRangedWeaponRoutine()
		{
			if (this.rangedWeaponRoutine != null)
			{
				base.StopCoroutine(this.rangedWeaponRoutine);
				this.rangedWeaponRoutine = null;
			}
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00082689 File Offset: 0x00080889
		protected virtual void UpdateLookAt()
		{
			if (this.TargetPlayer != null && this.SyncAccessor_isTargetVisible)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.TargetPlayer.MimicCamera.position, 10, true);
			}
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x000826CC File Offset: 0x000808CC
		protected virtual void UpdateEquippable()
		{
			if (!base.Active)
			{
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.rangedWeapon = null;
			string text = string.Empty;
			if (this.TargetPlayer.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.Arresting)
			{
				text = this.officer.BatonPrefab.AssetPath;
				this.officer.belt.SetBatonVisible(false);
			}
			else
			{
				this.officer.belt.SetBatonVisible(true);
			}
			if (this.TargetPlayer.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.NonLethal)
			{
				text = this.officer.TaserPrefab.AssetPath;
				this.officer.belt.SetTaserVisible(false);
			}
			else
			{
				this.officer.belt.SetTaserVisible(true);
			}
			if (this.TargetPlayer.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.Lethal)
			{
				text = this.officer.GunPrefab.AssetPath;
				this.officer.belt.SetGunVisible(false);
			}
			else
			{
				this.officer.belt.SetGunVisible(true);
			}
			if (text != string.Empty)
			{
				if (base.Npc.Avatar.CurrentEquippable == null || base.Npc.Avatar.CurrentEquippable.AssetPath != text)
				{
					base.Npc.SetEquippable_Networked(null, text);
				}
				if (base.Npc.Avatar.CurrentEquippable is AvatarRangedWeapon)
				{
					this.rangedWeapon = (base.Npc.Avatar.CurrentEquippable as AvatarRangedWeapon);
					return;
				}
			}
			else if (base.Npc.Avatar.CurrentEquippable != null)
			{
				base.Npc.SetEquippable_Networked(null, string.Empty);
			}
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0008287A File Offset: 0x00080A7A
		public override void Disable()
		{
			base.Disable();
			this.TargetPlayer = null;
			this.End();
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x0008288F File Offset: 0x00080A8F
		protected override void Pause()
		{
			base.Pause();
			this.Stop();
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x0008289D File Offset: 0x00080A9D
		protected override void End()
		{
			base.End();
			this.Stop();
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x000828AC File Offset: 0x00080AAC
		private void Stop()
		{
			this.ClearSpeedControls();
			this.SetArrestCircleAlpha(0f);
			this.StopSearching();
			this.StopRangedWeaponRoutine();
			this.ClearEquippables();
			this.officer.Movement.SetAgentType(NPCMovement.EAgentType.Humanoid);
			this.officer.Movement.SetStance(NPCMovement.EStance.None);
			this.officer.Avatar.EmotionManager.RemoveEmotionOverride("pursuit");
			this.arrestingEnabled = false;
			this.timeSinceLastSighting = 10000f;
			this.currentPursuitLevelDuration = 0f;
			this.timeWithinArrestRange = 0f;
			this.rangedWeapon = null;
			if (this.TargetPlayer != null)
			{
				base.Npc.awareness.VisionCone.StateSettings[this.TargetPlayer][PlayerVisualState.EVisualState.Visible].Enabled = false;
			}
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00082984 File Offset: 0x00080B84
		private void ClearEquippables()
		{
			base.Npc.SetEquippable_Networked(null, string.Empty);
			if (this.officer.belt != null)
			{
				this.officer.belt.SetBatonVisible(true);
				this.officer.belt.SetTaserVisible(true);
				this.officer.belt.SetGunVisible(true);
			}
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x000829E8 File Offset: 0x00080BE8
		protected void CheckPlayerVisibility()
		{
			if (this.TargetPlayer == null)
			{
				return;
			}
			if (this.IsPlayerVisible())
			{
				this.playerSightedDuration += Time.fixedDeltaTime;
				this.sync___set_value_isTargetVisible(true, true);
				this.isTargetStrictlyVisible = true;
			}
			else
			{
				this.playerSightedDuration = 0f;
				this.timeSinceLastSighting += Time.fixedDeltaTime;
				this.sync___set_value_isTargetVisible(false, true);
				this.isTargetStrictlyVisible = false;
				if (this.timeSinceLastSighting < 2f)
				{
					this.TargetPlayer.CrimeData.RecordLastKnownPosition(false);
					this.sync___set_value_isTargetVisible(true, true);
				}
			}
			if (this.SyncAccessor_isTargetVisible)
			{
				this.TargetPlayer.CrimeData.RecordLastKnownPosition(this.timeSinceLastSighting < 2f);
			}
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00082AA6 File Offset: 0x00080CA6
		public void MarkPlayerVisible()
		{
			if (this.IsPlayerVisible())
			{
				this.TargetPlayer.CrimeData.RecordLastKnownPosition(true);
				this.timeSinceLastSighting = 0f;
				return;
			}
			this.TargetPlayer.CrimeData.RecordLastKnownPosition(false);
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00082ADE File Offset: 0x00080CDE
		protected bool IsPlayerVisible()
		{
			return base.Npc.awareness.VisionCone.IsPlayerVisible(this.TargetPlayer);
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00082AFC File Offset: 0x00080CFC
		private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			if (!base.Active)
			{
				return;
			}
			if (visionEventReceipt.TargetPlayer == this.TargetPlayer.NetworkObject && visionEventReceipt.State == PlayerVisualState.EVisualState.SearchedFor)
			{
				this.MarkPlayerVisible();
				this.sync___set_value_isTargetVisible(true, true);
				this.isTargetStrictlyVisible = true;
			}
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00082B48 File Offset: 0x00080D48
		private void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			if (!base.Active)
			{
				return;
			}
			if (visionEventReceipt.TargetPlayer == this.TargetPlayer.NetworkObject && visionEventReceipt.State == PlayerVisualState.EVisualState.SearchedFor)
			{
				this.sync___set_value_isTargetVisible(true, true);
				this.isTargetStrictlyVisible = true;
			}
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00082B84 File Offset: 0x00080D84
		protected virtual void UpdateArrestCircle()
		{
			if (this.TargetPlayer == null || !this.arrestingEnabled || this.TargetPlayer != Player.Local)
			{
				this.SetArrestCircleAlpha(0f);
				return;
			}
			if (this.TargetPlayer.CrimeData.NearestOfficer != base.Npc)
			{
				this.SetArrestCircleAlpha(0f);
				return;
			}
			if (!this.SyncAccessor_isTargetVisible)
			{
				this.SetArrestCircleAlpha(0f);
				return;
			}
			float num = Vector3.Distance(this.TargetPlayer.Avatar.CenterPoint, base.transform.position);
			if (num < 2.5f)
			{
				this.SetArrestCircleAlpha(this.ArrestCircle_MaxOpacity);
				this.SetArrestCircleColor(new Color32(byte.MaxValue, 50, 50, byte.MaxValue));
				return;
			}
			if (num < this.ArrestCircle_MaxVisibleDistance)
			{
				float arrestCircleAlpha = Mathf.Lerp(this.ArrestCircle_MaxOpacity, 0f, (num - 2.5f) / (this.ArrestCircle_MaxVisibleDistance - 2.5f));
				this.SetArrestCircleAlpha(arrestCircleAlpha);
				this.SetArrestCircleColor(Color.white);
				return;
			}
			this.SetArrestCircleAlpha(0f);
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00082CA2 File Offset: 0x00080EA2
		public void ResetArrestProgress()
		{
			this.timeWithinArrestRange = 0f;
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00082CAF File Offset: 0x00080EAF
		private void SetArrestCircleAlpha(float alpha)
		{
			this.officer.ProxCircle.SetAlpha(alpha);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00082CC2 File Offset: 0x00080EC2
		private void SetArrestCircleColor(Color col)
		{
			this.officer.ProxCircle.SetColor(col);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00082CD5 File Offset: 0x00080ED5
		private void StartSearching()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.IsSearching = true;
			this.searchRoutine = base.StartCoroutine(this.SearchRoutine());
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00082CF8 File Offset: 0x00080EF8
		private void StopSearching()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			this.IsSearching = false;
			this.hasSearchDestination = false;
			if (this.searchRoutine != null)
			{
				base.StopCoroutine(this.searchRoutine);
			}
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00082D24 File Offset: 0x00080F24
		private IEnumerator SearchRoutine()
		{
			while (this.IsSearching)
			{
				if (!this.hasSearchDestination)
				{
					this.currentSearchDestination = this.GetNextSearchLocation();
					base.Npc.Movement.SetDestination(this.currentSearchDestination);
					this.hasSearchDestination = true;
				}
				for (;;)
				{
					if (!base.Npc.Movement.IsMoving && base.Npc.Movement.CanMove())
					{
						base.Npc.Movement.SetDestination(this.currentSearchDestination);
					}
					if (Vector3.Distance(base.transform.position, this.currentSearchDestination) < 2.5f)
					{
						break;
					}
					yield return new WaitForSeconds(1f);
				}
				this.hasSearchDestination = false;
				yield return new WaitForSeconds(Random.Range(1f, 6f));
			}
			this.searchRoutine = null;
			this.StopSearching();
			yield break;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00082D34 File Offset: 0x00080F34
		private Vector3 GetNextSearchLocation()
		{
			float num = Mathf.Lerp(25f, 80f, Mathf.Clamp(this.timeSinceLastSighting / this.TargetPlayer.CrimeData.GetSearchTime(), 0f, 1f));
			num = Mathf.Min(num, Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint));
			return this.GetRandomReachablePointNear(this.TargetPlayer.Avatar.CenterPoint, num, 0f);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00082DBC File Offset: 0x00080FBC
		private Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			bool flag = false;
			Vector3 result = point;
			int num = 0;
			while (!flag)
			{
				Vector2 insideUnitCircle = Random.insideUnitCircle;
				Vector3 normalized = new Vector3(insideUnitCircle.x, 0f, insideUnitCircle.y).normalized;
				NavMeshHit navMeshHit;
				NavMeshUtility.SamplePosition(point + normalized * randomRadius, out navMeshHit, 5f, base.Npc.Movement.Agent.areaMask, true);
				if (base.Npc.Movement.CanGetTo(navMeshHit.position, 2.5f) && Vector3.Distance(point, navMeshHit.position) > minDistance)
				{
					result = navMeshHit.position;
					break;
				}
				num++;
				if (num > 10)
				{
					Console.LogError("Failed to find search destination", null);
					break;
				}
			}
			return result;
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00082E83 File Offset: 0x00081083
		private void SetWorldspaceIconsActive(bool active)
		{
			base.Npc.awareness.VisionCone.WorldspaceIconsEnabled = active;
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00082ED0 File Offset: 0x000810D0
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___isTargetVisible = new SyncVar<bool>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, 0.25f, Channel.Reliable, this.isTargetVisible);
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_AssignTarget_1824087381));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.NPCs.Behaviour.PursuitBehaviour));
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00082F48 File Offset: 0x00081148
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___isTargetVisible.SetRegistered();
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00082F6C File Offset: 0x0008116C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00082F7C File Offset: 0x0008117C
		private void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
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
			writer.WriteNetworkConnection(conn);
			writer.WriteNetworkObject(target);
			base.SendObserversRpc(15U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00083040 File Offset: 0x00081240
		public virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			this.TargetPlayer = target.GetComponent<Player>();
			this.playerSightedDuration = 0f;
			this.timeSinceLastSighting = 0f;
			this.timeWithinArrestRange = 0f;
			this.leaveArrestCircleCount = 0;
			this.wasInArrestCircleLastFrame = false;
			this.distanceOnPursuitStart = Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint);
			this.targetWasDrivingOnPursuitStart = (this.TargetPlayer.CurrentVehicle != null);
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x000830C8 File Offset: 0x000812C8
		private void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			NetworkConnection conn = PooledReader0.ReadNetworkConnection();
			NetworkObject target = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___AssignTarget_1824087381(conn, target);
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x00083114 File Offset: 0x00081314
		// (set) Token: 0x06001FEF RID: 8175 RVA: 0x0008311C File Offset: 0x0008131C
		public bool SyncAccessor_isTargetVisible
		{
			get
			{
				return this.isTargetVisible;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.isTargetVisible = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___isTargetVisible.SetValue(value, value);
				}
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x00083158 File Offset: 0x00081358
		public virtual bool PursuitBehaviour(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 != 0U)
			{
				return false;
			}
			if (PooledReader0 == null)
			{
				this.sync___set_value_isTargetVisible(this.syncVar___isTargetVisible.GetValue(true), true);
				return true;
			}
			bool value = PooledReader0.ReadBoolean();
			this.sync___set_value_isTargetVisible(value, Boolean2);
			return true;
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000831AC File Offset: 0x000813AC
		protected virtual void dll()
		{
			base.Awake();
			this.officer = (base.Npc as PoliceOfficer);
			VisionCone visionCone = this.officer.awareness.VisionCone;
			visionCone.onVisionEventFull = (VisionCone.EventStateChange)Delegate.Combine(visionCone.onVisionEventFull, new VisionCone.EventStateChange(this.ProcessVisionEvent));
			PoliceOfficer.OnPoliceVisionEvent = (Action<VisionEventReceipt>)Delegate.Combine(PoliceOfficer.OnPoliceVisionEvent, new Action<VisionEventReceipt>(this.ProcessThirdPartyVisionEvent));
		}

		// Token: 0x040018AD RID: 6317
		public const float ARREST_RANGE = 2.5f;

		// Token: 0x040018AE RID: 6318
		public const float ARREST_TIME = 1.75f;

		// Token: 0x040018AF RID: 6319
		public const float EXTRA_VISIBILITY_TIME = 2f;

		// Token: 0x040018B0 RID: 6320
		public const float MOVE_SPEED_INVESTIGATING = 0.35f;

		// Token: 0x040018B1 RID: 6321
		public const float MOVE_SPEED_ARRESTING = 0.6f;

		// Token: 0x040018B2 RID: 6322
		public const float MOVE_SPEED_CHASE = 0.8f;

		// Token: 0x040018B3 RID: 6323
		public const float MOVE_SPEED_SHOOTING = 0.15f;

		// Token: 0x040018B4 RID: 6324
		public const float SEARCH_RADIUS_MIN = 25f;

		// Token: 0x040018B5 RID: 6325
		public const float SEARCH_RADIUS_MAX = 80f;

		// Token: 0x040018B6 RID: 6326
		public const float ARREST_MAX_DISTANCE = 15f;

		// Token: 0x040018B7 RID: 6327
		public const int LEAVE_ARREST_CIRCLE_LIMIT = 3;

		// Token: 0x040018B8 RID: 6328
		public const float CONSECUTIVE_MISS_ACCURACY_BOOST = 0.1f;

		// Token: 0x040018BB RID: 6331
		[Header("Settings")]
		public float ArrestCircle_MaxVisibleDistance = 5f;

		// Token: 0x040018BC RID: 6332
		public float ArrestCircle_MaxOpacity = 0.25f;

		// Token: 0x040018BD RID: 6333
		[SyncVar(SendRate = 0.25f, WritePermissions = WritePermission.ClientUnsynchronized)]
		public bool isTargetVisible;

		// Token: 0x040018BE RID: 6334
		protected bool isTargetStrictlyVisible;

		// Token: 0x040018BF RID: 6335
		protected bool arrestingEnabled;

		// Token: 0x040018C0 RID: 6336
		protected float timeSinceLastSighting = 10000f;

		// Token: 0x040018C1 RID: 6337
		protected float currentPursuitLevelDuration;

		// Token: 0x040018C2 RID: 6338
		protected float timeWithinArrestRange;

		// Token: 0x040018C3 RID: 6339
		protected float playerSightedDuration;

		// Token: 0x040018C4 RID: 6340
		protected float distanceOnPursuitStart;

		// Token: 0x040018C5 RID: 6341
		private Coroutine searchRoutine;

		// Token: 0x040018C6 RID: 6342
		private Coroutine rangedWeaponRoutine;

		// Token: 0x040018C7 RID: 6343
		private Vector3 currentSearchDestination = Vector3.zero;

		// Token: 0x040018C8 RID: 6344
		private bool hasSearchDestination;

		// Token: 0x040018C9 RID: 6345
		private PoliceOfficer officer;

		// Token: 0x040018CA RID: 6346
		private bool targetWasDrivingOnPursuitStart;

		// Token: 0x040018CB RID: 6347
		private bool wasInArrestCircleLastFrame;

		// Token: 0x040018CC RID: 6348
		private int leaveArrestCircleCount;

		// Token: 0x040018CD RID: 6349
		private AvatarRangedWeapon rangedWeapon;

		// Token: 0x040018CE RID: 6350
		private int consecutiveMissedShots;

		// Token: 0x040018CF RID: 6351
		private float nextAngryVO;

		// Token: 0x040018D0 RID: 6352
		public SyncVar<bool> syncVar___isTargetVisible;

		// Token: 0x040018D1 RID: 6353
		private bool dll_Excuted;

		// Token: 0x040018D2 RID: 6354
		private bool dll_Excuted;

		// Token: 0x0200052A RID: 1322
		private enum EPursuitAction
		{
			// Token: 0x040018D4 RID: 6356
			None,
			// Token: 0x040018D5 RID: 6357
			Move,
			// Token: 0x040018D6 RID: 6358
			Shoot,
			// Token: 0x040018D7 RID: 6359
			MoveAndShoot
		}
	}
}
