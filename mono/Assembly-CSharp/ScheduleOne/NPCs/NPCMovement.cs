using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dragging;
using ScheduleOne.Management;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Skating;
using ScheduleOne.Tools;
using ScheduleOne.Vehicles;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000460 RID: 1120
	public class NPCMovement : NetworkBehaviour
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x0006766A File Offset: 0x0006586A
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x00067672 File Offset: 0x00065872
		public bool hasDestination { get; protected set; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x0006767B File Offset: 0x0006587B
		public bool IsMoving
		{
			get
			{
				return ((this.Agent.hasPath || this.Agent.pathPending) && this.Agent.remainingDistance > 0.25f) || this.forceIsMoving;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x000676B1 File Offset: 0x000658B1
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x000676B9 File Offset: 0x000658B9
		public bool IsPaused { get; protected set; }

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x000676C2 File Offset: 0x000658C2
		public Vector3 FootPosition
		{
			get
			{
				return base.transform.position;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x000676CF File Offset: 0x000658CF
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x000676D7 File Offset: 0x000658D7
		public float GravityMultiplier { get; protected set; } = 1f;

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x000676E0 File Offset: 0x000658E0
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x000676E8 File Offset: 0x000658E8
		public NPCMovement.EStance Stance { get; protected set; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x000676F1 File Offset: 0x000658F1
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x000676F9 File Offset: 0x000658F9
		public float timeSinceHitByCar { get; protected set; }

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x00067702 File Offset: 0x00065902
		public bool FaceDirectionInProgress
		{
			get
			{
				return this.FaceDirectionRoutine != null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x0006770D File Offset: 0x0006590D
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x00067715 File Offset: 0x00065915
		public Vector3 CurrentDestination { get; protected set; } = Vector3.zero;

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x0006771E File Offset: 0x0006591E
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x00067726 File Offset: 0x00065926
		public NPCPathCache PathCache { get; private set; } = new NPCPathCache();

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0006772F File Offset: 0x0006592F
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x00067737 File Offset: 0x00065937
		public bool Disoriented { get; set; }

		// Token: 0x0600178A RID: 6026 RVA: 0x00067740 File Offset: 0x00065940
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.NPCMovement_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00067760 File Offset: 0x00065960
		private void Start()
		{
			string text = this.npc.BakedGUID;
			if (text != string.Empty)
			{
				if (text[text.Length - 1] != '1')
				{
					text = text.Substring(0, text.Length - 1) + "1";
				}
				else
				{
					text = text.Substring(0, text.Length - 1) + "2";
				}
				this.RagdollDraggable.SetGUID(new Guid(text));
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x000677DF File Offset: 0x000659DF
		public override void OnStartClient()
		{
			base.OnStartClient();
			if (!InstanceFinder.IsServer)
			{
				this.Agent.enabled = false;
			}
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000677FA File Offset: 0x000659FA
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00067803 File Offset: 0x00065A03
		protected virtual void Update()
		{
			bool debug = this.DEBUG;
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0006780C File Offset: 0x00065A0C
		protected virtual void LateUpdate()
		{
			this.forceIsMoving = false;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00067815 File Offset: 0x00065A15
		private void UpdateRagdoll()
		{
			if (!this.npc.IsConscious)
			{
				return;
			}
			if (this.anim.Avatar.Ragdolled && this.ragdollStaticTime > 1.5f)
			{
				this.DeactivateRagdoll();
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0006784C File Offset: 0x00065A4C
		[Button]
		private void Stumble()
		{
			this.timeUntilNextStumble = Random.Range(5f, 15f);
			if (Random.Range(1f, 0f) < 0.1f)
			{
				this.ActivateRagdoll_Server();
				return;
			}
			this.timeSinceStumble = 0f;
			this.stumbleDirection = Random.onUnitSphere;
			this.stumbleDirection.y = 0f;
			this.stumbleDirection.Normalize();
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000678BC File Offset: 0x00065ABC
		private void UpdateDestination()
		{
			if (!this.hasDestination)
			{
				return;
			}
			if (this.npc.IsInVehicle)
			{
				this.EndSetDestination(NPCMovement.WalkResult.Interrupted);
				return;
			}
			if (!this.IsMoving && !this.Agent.pathPending && this.CanMove())
			{
				if (this.IsAsCloseAsPossible(this.CurrentDestination, 0.5f))
				{
					if (this.Agent.hasPath)
					{
						this.Agent.ResetPath();
					}
					if (Vector3.Distance(this.CurrentDestination, this.FootPosition) < this.currentMaxDistanceForSuccess || Vector3.Distance(this.CurrentDestination, base.transform.position) < this.currentMaxDistanceForSuccess)
					{
						this.EndSetDestination(NPCMovement.WalkResult.Success);
						return;
					}
					this.EndSetDestination(NPCMovement.WalkResult.Partial);
					return;
				}
				else
				{
					this.SetDestination(this.CurrentDestination, this.walkResultCallback, false, this.currentMaxDistanceForSuccess, 1f);
				}
			}
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000679A0 File Offset: 0x00065BA0
		protected virtual void FixedUpdate()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.IsPaused)
			{
				this.Agent.isStopped = true;
			}
			this.timeSinceHitByCar += Time.fixedDeltaTime;
			this.capsuleCollider.transform.position = this.ragdollCentralRB.transform.position;
			this.UpdateSpeed();
			this.UpdateStumble();
			this.UpdateRagdoll();
			this.UpdateDestination();
			this.RecordVelocity();
			this.UpdateSlippery();
			this.UpdateCache();
			if (!this.anim.Avatar.Ragdolled || !this.CanRecoverFromRagdoll())
			{
				this.ragdollStaticTime = 0f;
				return;
			}
			this.ragdollTime += Time.fixedDeltaTime;
			if (this.ragdollCentralRB.velocity.magnitude < 0.25f)
			{
				this.ragdollStaticTime += Time.fixedDeltaTime;
				return;
			}
			this.ragdollStaticTime = 0f;
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00067A98 File Offset: 0x00065C98
		private void UpdateStumble()
		{
			if (this.Disoriented && this.IsMoving)
			{
				this.timeUntilNextStumble -= Time.fixedDeltaTime;
				if (this.timeUntilNextStumble <= 0f)
				{
					this.Stumble();
				}
			}
			this.timeSinceStumble += Time.fixedDeltaTime;
			if (this.timeSinceStumble < 0.66f)
			{
				this.Agent.Move(this.stumbleDirection * (0.66f - this.timeSinceStumble) * Time.fixedDeltaTime * 7f);
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00067B30 File Offset: 0x00065D30
		private void UpdateSpeed()
		{
			if ((double)this.MovementSpeedScale >= 0.0)
			{
				this.Agent.speed = Mathf.Lerp(this.WalkSpeed, this.RunSpeed, this.MovementSpeedScale) * this.MoveSpeedMultiplier;
				return;
			}
			this.Agent.speed = 0f;
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00067B8C File Offset: 0x00065D8C
		private void RecordVelocity()
		{
			if (this.timeSinceLastVelocityHistoryRecord > this.velocityHistorySpacing)
			{
				this.timeSinceLastVelocityHistoryRecord = 0f;
				this.desiredVelocityHistory.Add(this.Agent.velocity);
				if (this.desiredVelocityHistory.Count > this.desiredVelocityHistoryLength)
				{
					this.desiredVelocityHistory.RemoveAt(0);
					return;
				}
			}
			else
			{
				this.timeSinceLastVelocityHistoryRecord += Time.fixedDeltaTime;
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00067BFC File Offset: 0x00065DFC
		private void UpdateSlippery()
		{
			if (this.SlipperyMode)
			{
				Vector3 vector = Vector3.zero;
				foreach (Vector3 b in this.desiredVelocityHistory)
				{
					vector += b;
				}
				vector /= (float)this.desiredVelocityHistory.Count;
				if (this.Agent.enabled && this.Agent.isOnNavMesh)
				{
					float num = Vector3.Angle(vector, base.transform.forward);
					this.Agent.Move(vector * this.SlipperyModeMultiplier * Time.fixedDeltaTime * Mathf.Clamp01(num / 90f));
				}
			}
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00067CD4 File Offset: 0x00065ED4
		private void UpdateCache()
		{
			if (this.cacheNextPath && this.Agent.path != null && this.Agent.path.corners.Length > 1)
			{
				this.cacheNextPath = false;
				this.PathCache.AddPath(this.Agent.path.corners[0], this.Agent.path.corners[this.Agent.path.corners.Length - 1], this.Agent.path);
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00067D67 File Offset: 0x00065F67
		public bool CanRecoverFromRagdoll()
		{
			return !this.npc.behaviour.RagdollBehaviour.Seizure;
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00067D84 File Offset: 0x00065F84
		private void UpdateAvoidance()
		{
			float num;
			Player.GetClosestPlayer(base.transform.position, out num, null);
			if (num > 25f)
			{
				this.Agent.obstacleAvoidanceType = 0;
				return;
			}
			this.Agent.obstacleAvoidanceType = this.DefaultObstacleAvoidanceType;
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00067DCB File Offset: 0x00065FCB
		public void OnTriggerEnter(Collider other)
		{
			this.CheckHit(other, this.capsuleCollider, false, other.transform.position);
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00067DE6 File Offset: 0x00065FE6
		public void OnCollisionEnter(Collision collision)
		{
			this.CheckHit(collision.collider, collision.contacts[0].thisCollider, true, collision.contacts[0].point);
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00067E18 File Offset: 0x00066018
		private void CheckHit(Collider other, Collider thisCollider, bool isCollision, Vector3 hitPoint)
		{
			float num;
			Player closestPlayer = Player.GetClosestPlayer(base.transform.position, out num, null);
			if (num > 30f)
			{
				return;
			}
			if ((other.gameObject.layer == LayerMask.NameToLayer("Vehicle") || other.gameObject.layer == LayerMask.NameToLayer("Ignore Raycast")) && !this.anim.Avatar.Ragdolled)
			{
				LandVehicle landVehicle = other.GetComponentInParent<LandVehicle>();
				if (landVehicle == null)
				{
					VehicleHumanoidCollider componentInParent = other.GetComponentInParent<VehicleHumanoidCollider>();
					if (componentInParent != null)
					{
						landVehicle = componentInParent.vehicle;
					}
				}
				if (landVehicle != null && this.npc.CurrentVehicle != landVehicle && Mathf.Abs(landVehicle.speed_Kmh) > 10f)
				{
					this.ActivateRagdoll_Server();
					if (this.onHitByCar != null)
					{
						this.onHitByCar.Invoke(other.GetComponentInParent<LandVehicle>());
					}
					this.timeSinceHitByCar = 0f;
					return;
				}
			}
			else if (other.GetComponentInParent<Skateboard>() != null && !this.anim.Avatar.Ragdolled)
			{
				if (other.GetComponentInParent<Skateboard>().VelocityCalculator.Velocity.magnitude > 2.777778f)
				{
					this.ActivateRagdoll_Server();
					this.npc.PlayVO(EVOLineType.Hurt);
					return;
				}
			}
			else if (other.GetComponentInParent<PhysicsDamageable>() != null && InstanceFinder.IsServer)
			{
				PhysicsDamageable componentInParent2 = other.GetComponentInParent<PhysicsDamageable>();
				float num2 = Mathf.Sqrt(componentInParent2.Rb.mass) * componentInParent2.Rb.velocity.magnitude;
				float num3 = componentInParent2.Rb.velocity.magnitude;
				if (num3 > 40f)
				{
					return;
				}
				if (num3 > 1f)
				{
					num3 = Mathf.Pow(num3, 1.5f);
				}
				else
				{
					num3 = Mathf.Sqrt(num3);
				}
				if (num2 > 10f)
				{
					float num4 = 1f;
					NPCMovement.EStance stance = this.Stance;
					if (stance != NPCMovement.EStance.None)
					{
						if (stance == NPCMovement.EStance.Stanced)
						{
							num4 = 0.5f;
						}
					}
					else
					{
						num4 = 1f;
					}
					float num5 = num2 * 2.5f;
					float num6 = num2 * 0.3f;
					if (num2 > 20f)
					{
						this.npc.Health.TakeDamage(num6, false);
						this.npc.ProcessImpactForce(hitPoint, componentInParent2.Rb.velocity.normalized, num5 * num4);
					}
					Impact impact = new Impact(default(RaycastHit), hitPoint, componentInParent2.Rb.velocity.normalized, num5, num6, EImpactType.PhysicsProp, (num < 15f) ? closestPlayer : null, Random.Range(int.MinValue, int.MaxValue));
					this.npc.responses.ImpactReceived(impact);
				}
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x000680D9 File Offset: 0x000662D9
		public void Warp(Transform target)
		{
			this.Warp(target.position);
			this.FaceDirection(target.forward, 0.5f);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x000680F8 File Offset: 0x000662F8
		public void Warp(Vector3 position)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsNPCPositionValid(position))
			{
				string str = "NPCMovement.Warp called with invalid position: ";
				Vector3 vector = position;
				Console.LogWarning(str + vector.ToString(), null);
				return;
			}
			this.Agent.Warp(position);
			this.ReceiveWarp(position);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0006814C File Offset: 0x0006634C
		[ObserversRpc(ExcludeServer = true)]
		private void ReceiveWarp(Vector3 position)
		{
			this.RpcWriter___Observers_ReceiveWarp_4276783012(position);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00068163 File Offset: 0x00066363
		public void VisibilityChange(bool visible)
		{
			this.capsuleCollider.gameObject.SetActive(visible);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00068176 File Offset: 0x00066376
		public bool CanMove()
		{
			return !this.anim.Avatar.Ragdolled && !this.npc.isInBuilding && !this.npc.IsInVehicle;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x000681A8 File Offset: 0x000663A8
		public void SetAgentType(NPCMovement.EAgentType type)
		{
			string name = type.ToString();
			if (type == NPCMovement.EAgentType.BigHumanoid)
			{
				name = "Big Humanoid";
			}
			if (type == NPCMovement.EAgentType.IgnoreCosts)
			{
				name = "Ignore Costs";
			}
			this.Agent.agentTypeID = NavMeshUtility.GetNavMeshAgentID(name);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x000681E8 File Offset: 0x000663E8
		public void SetSeat(AvatarSeat seat)
		{
			this.npc.Avatar.Anim.SetSeat(seat);
			this.Agent.enabled = (seat == null && InstanceFinder.IsServer);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0006821C File Offset: 0x0006641C
		public void SetStance(NPCMovement.EStance stance)
		{
			this.Stance = stance;
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00068228 File Offset: 0x00066428
		public void SetGravityMultiplier(float multiplier)
		{
			this.GravityMultiplier = multiplier;
			foreach (ConstantForce constantForce in this.ragdollForceComponents)
			{
				constantForce.force = Physics.gravity * this.GravityMultiplier * constantForce.GetComponent<Rigidbody>().mass;
			}
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x000682A4 File Offset: 0x000664A4
		public void SetRagdollDraggable(bool draggable)
		{
			this.RagdollDraggable.enabled = draggable;
			this.RagdollDraggableCollider.enabled = draggable;
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x000682BE File Offset: 0x000664BE
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void ActivateRagdoll_Server()
		{
			this.RpcWriter___Server_ActivateRagdoll_Server_2166136261();
			this.RpcLogic___ActivateRagdoll_Server_2166136261();
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000682CC File Offset: 0x000664CC
		[ObserversRpc(RunLocally = true)]
		public void ActivateRagdoll(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			this.RpcWriter___Observers_ActivateRagdoll_2690242654(forcePoint, forceDir, forceMagnitude);
			this.RpcLogic___ActivateRagdoll_2690242654(forcePoint, forceDir, forceMagnitude);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00068300 File Offset: 0x00066500
		[ObserversRpc(RunLocally = true)]
		public void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			this.RpcWriter___Observers_ApplyRagdollForce_2690242654(forcePoint, forceDir, forceMagnitude);
			this.RpcLogic___ApplyRagdollForce_2690242654(forcePoint, forceDir, forceMagnitude);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00068334 File Offset: 0x00066534
		[ObserversRpc(RunLocally = true)]
		public void DeactivateRagdoll()
		{
			this.RpcWriter___Observers_DeactivateRagdoll_2166136261();
			this.RpcLogic___DeactivateRagdoll_2166136261();
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00068350 File Offset: 0x00066550
		private bool SmartSampleNavMesh(Vector3 position, out NavMeshHit hit, float minRadius = 1f, float maxRadius = 10f, int steps = 3)
		{
			hit = default(NavMeshHit);
			NavMeshQueryFilter navMeshQueryFilter = default(NavMeshQueryFilter);
			navMeshQueryFilter.agentTypeID = NavMeshUtility.GetNavMeshAgentID("Humanoid");
			navMeshQueryFilter.areaMask = -1;
			for (int i = 0; i < steps; i++)
			{
				float num = Mathf.Lerp(minRadius, maxRadius, (float)(i / steps));
				if (NavMesh.SamplePosition(base.transform.position, ref hit, num, navMeshQueryFilter))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x000683B8 File Offset: 0x000665B8
		public void SetDestination(Vector3 pos)
		{
			this.SetDestination(pos, null, 1f, 1f);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000683CC File Offset: 0x000665CC
		public void SetDestination(ITransitEntity entity)
		{
			this.SetDestination(NavMeshUtility.GetAccessPoint(entity, this.npc).position);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000683E5 File Offset: 0x000665E5
		public void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback = null, float maximumDistanceForSuccess = 1f, float cacheMaxDistSqr = 1f)
		{
			this.SetDestination(pos, callback, true, maximumDistanceForSuccess, cacheMaxDistSqr);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x000683F4 File Offset: 0x000665F4
		private void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback = null, bool interruptExistingCallback = true, float successThreshold = 1f, float cacheMaxDistSqr = 1f)
		{
			if (!this.IsNPCPositionValid(pos))
			{
				string str = "NPCMovement.SetDestination called with invalid position: ";
				Vector3 vector = pos;
				Console.LogWarning(str + vector.ToString(), null);
				return;
			}
			if (this.npc.Avatar.Anim.IsSeated)
			{
				this.npc.Movement.SetSeat(null);
			}
			if (!InstanceFinder.IsServer)
			{
				Console.LogWarning("NPCMovement.SetDestination called on client", null);
				return;
			}
			if (this.npc.isInBuilding)
			{
				this.npc.ExitBuilding("");
			}
			if (this.DEBUG)
			{
				string fullName = this.npc.fullName;
				string str2 = " SetDestination called: ";
				Vector3 vector = pos;
				Console.Log(fullName + str2 + vector.ToString(), null);
				Debug.DrawLine(this.FootPosition, pos, Color.green, 1f);
			}
			if (!this.CanMove())
			{
				Console.LogWarning("NPCMovement.SetDestination called but CanWalk == false (" + this.npc.fullName + ")", null);
				return;
			}
			if (!this.Agent.isOnNavMesh)
			{
				Console.LogWarning("NPC is not on navmesh; warping to navmesh", null);
				NavMeshHit navMeshHit;
				if (!this.SmartSampleNavMesh(base.transform.position, out navMeshHit, 1f, 10f, 3))
				{
					Console.LogWarning("NavMesh sample failed at " + base.transform.position.ToString(), null);
					return;
				}
				this.Agent.Warp(navMeshHit.position);
				this.Agent.enabled = false;
				this.Agent.enabled = true;
			}
			if (this.walkResultCallback != null && interruptExistingCallback)
			{
				this.EndSetDestination(NPCMovement.WalkResult.Interrupted);
			}
			this.walkResultCallback = callback;
			this.currentMaxDistanceForSuccess = successThreshold;
			if (this.npc.IsInVehicle)
			{
				Console.LogWarning("SetDestination called but NPC is in a vehicle; returning WalkResult.Failed", null);
				this.EndSetDestination(NPCMovement.WalkResult.Failed);
				return;
			}
			Vector3 zero = Vector3.zero;
			if (!this.GetClosestReachablePoint(pos, out zero))
			{
				string fullName2 = this.npc.fullName;
				string str3 = " failed to find closest reachable point for destination: ";
				Vector3 vector = pos;
				Console.LogWarning(fullName2 + str3 + vector.ToString(), null);
				this.EndSetDestination(NPCMovement.WalkResult.Failed);
				return;
			}
			if (!this.IsNPCPositionValid(zero))
			{
				string fullName3 = this.npc.fullName;
				string str4 = " failed to find valid reachable point for destination: ";
				Vector3 vector = pos;
				Console.LogWarning(fullName3 + str4 + vector.ToString(), null);
				this.EndSetDestination(NPCMovement.WalkResult.Failed);
				return;
			}
			this.hasDestination = true;
			this.CurrentDestination = pos;
			this.currentDestination_Reachable = zero;
			NavMeshPath path = this.PathCache.GetPath(this.Agent.transform.position, zero, cacheMaxDistSqr);
			bool flag = false;
			if (path != null)
			{
				try
				{
					flag = this.Agent.SetPath(path);
				}
				catch (Exception ex)
				{
					Console.LogWarning("Agent.SetDestination error: " + ex.Message, null);
					flag = false;
				}
			}
			if (!flag)
			{
				if (this.DEBUG)
				{
					Console.Log("No cached path for " + this.npc.fullName + "; calculating new path", null);
				}
				try
				{
					this.Agent.SetDestination(zero);
					this.cacheNextPath = true;
				}
				catch (Exception ex2)
				{
					Console.LogWarning("Agent.SetDestination error: " + ex2.Message, null);
				}
			}
			if (this.IsPaused)
			{
				this.Agent.isStopped = true;
			}
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00068734 File Offset: 0x00066934
		private bool IsNPCPositionValid(Vector3 position)
		{
			return !float.IsNaN(position.x) && !float.IsNaN(position.y) && !float.IsNaN(position.z) && !float.IsInfinity(position.x) && !float.IsInfinity(position.y) && !float.IsInfinity(position.z) && position.magnitude <= 10000f;
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x000687A4 File Offset: 0x000669A4
		private void EndSetDestination(NPCMovement.WalkResult result)
		{
			if (this.DEBUG)
			{
				Console.Log(this.npc.fullName + " EndSetDestination called: " + result.ToString(), null);
			}
			if (this.walkResultCallback != null)
			{
				this.walkResultCallback(result);
				this.walkResultCallback = null;
			}
			this.hasDestination = false;
			this.CurrentDestination = Vector3.zero;
			this.currentDestination_Reachable = Vector3.zero;
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0006881C File Offset: 0x00066A1C
		public void Stop()
		{
			if (this.Agent.isOnNavMesh)
			{
				this.Agent.ResetPath();
				this.Agent.velocity = Vector3.zero;
				this.Agent.isStopped = true;
				this.Agent.isStopped = false;
			}
			if (InstanceFinder.IsServer)
			{
				this.EndSetDestination(NPCMovement.WalkResult.Stopped);
			}
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000045B1 File Offset: 0x000027B1
		public void WarpToNavMesh()
		{
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00068878 File Offset: 0x00066A78
		public void FacePoint(Vector3 point, float lerpTime = 0.5f)
		{
			Vector3 forward = new Vector3(point.x, base.transform.position.y, point.z) - base.transform.position;
			if (this.FaceDirectionRoutine != null)
			{
				base.StopCoroutine(this.FaceDirectionRoutine);
			}
			if (this.DEBUG)
			{
				string str = "Facing point: ";
				Vector3 vector = point;
				Debug.Log(str + vector.ToString());
			}
			this.FaceDirectionRoutine = base.StartCoroutine(this.FaceDirection_Process(forward, lerpTime));
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00068908 File Offset: 0x00066B08
		public void FaceDirection(Vector3 forward, float lerpTime = 0.5f)
		{
			if (this.FaceDirectionRoutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.FaceDirectionRoutine);
			}
			if (this.DEBUG)
			{
				string str = "Facing dir: ";
				Vector3 vector = forward;
				Debug.Log(str + vector.ToString());
			}
			this.FaceDirectionRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.FaceDirection_Process(forward, lerpTime));
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0006896B File Offset: 0x00066B6B
		protected IEnumerator FaceDirection_Process(Vector3 forward, float lerpTime)
		{
			if (lerpTime > 0f)
			{
				Quaternion startRot = base.transform.rotation;
				for (float i = 0f; i < lerpTime; i += Time.deltaTime)
				{
					base.transform.rotation = Quaternion.Lerp(startRot, Quaternion.LookRotation(forward, Vector3.up), i / lerpTime);
					yield return new WaitForEndOfFrame();
				}
				startRot = default(Quaternion);
			}
			base.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
			this.FaceDirectionRoutine = null;
			yield break;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00068988 File Offset: 0x00066B88
		public void PauseMovement()
		{
			this.IsPaused = true;
			this.Agent.isStopped = true;
			this.Agent.velocity = Vector3.zero;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000689AD File Offset: 0x00066BAD
		public void ResumeMovement()
		{
			this.IsPaused = false;
			if (this.Agent.isOnNavMesh)
			{
				this.Agent.isStopped = false;
			}
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000689D0 File Offset: 0x00066BD0
		public bool IsAsCloseAsPossible(Vector3 location, float distanceThreshold = 0.5f)
		{
			Vector3 zero = Vector3.zero;
			return this.GetClosestReachablePoint(location, out zero) && Vector3.Distance(this.FootPosition, zero) < distanceThreshold;
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00068A00 File Offset: 0x00066C00
		public bool GetClosestReachablePoint(Vector3 targetPosition, out Vector3 closestPoint)
		{
			closestPoint = Vector3.zero;
			bool flag = false;
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < NPCMovement.cachedClosestPointKeys.Count; i++)
			{
				if (Vector3.SqrMagnitude(NPCMovement.cachedClosestPointKeys[i] - targetPosition) < 1f)
				{
					vector = NPCMovement.cachedClosestReachablePoints[NPCMovement.cachedClosestPointKeys[i]];
					flag = true;
					break;
				}
			}
			if (flag)
			{
				closestPoint = vector;
				return true;
			}
			if (!this.Agent.isOnNavMesh)
			{
				return false;
			}
			NavMeshPath navMeshPath = new NavMeshPath();
			float num = 3f;
			for (int j = 0; j < 3; j++)
			{
				NavMeshHit navMeshHit;
				if (NavMeshUtility.SamplePosition(targetPosition, out navMeshHit, num * (float)(j + 1), -1, true) && this.Agent.CalculatePath(navMeshHit.position, navMeshPath))
				{
					Vector3 vector2 = navMeshPath.corners[navMeshPath.corners.Length - 1];
					if (this.Agent.isActiveAndEnabled && this.Agent.isOnNavMesh && Vector3.Distance(navMeshHit.position, vector2) <= 1f)
					{
						closestPoint = vector2;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00068B28 File Offset: 0x00066D28
		public bool CanGetTo(Vector3 position, float proximityReq = 1f)
		{
			NavMeshPath navMeshPath = null;
			return this.CanGetTo(position, proximityReq, out navMeshPath);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00068B44 File Offset: 0x00066D44
		public bool CanGetTo(ITransitEntity entity, float proximityReq = 1f)
		{
			if (entity == null)
			{
				return false;
			}
			foreach (Transform transform in entity.AccessPoints)
			{
				if (!(transform == null) && this.CanGetTo(transform.position, proximityReq))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00068B8C File Offset: 0x00066D8C
		public bool CanGetTo(Vector3 position, float proximityReq, out NavMeshPath path)
		{
			path = null;
			if (Vector3.Distance(position, base.transform.position) <= proximityReq)
			{
				return true;
			}
			if (!this.Agent.isOnNavMesh)
			{
				return false;
			}
			NavMeshHit navMeshHit;
			if (!NavMeshUtility.SamplePosition(position, out navMeshHit, 2f, -1, true))
			{
				return false;
			}
			path = this.GetPathTo(navMeshHit.position, proximityReq);
			if (path == null)
			{
				Debug.DrawLine(this.FootPosition, navMeshHit.position, Color.red, 1f);
				return false;
			}
			if (path.corners.Length < 2)
			{
				Console.LogWarning("Path length < 2", null);
				return false;
			}
			float num = Vector3.Distance(path.corners[path.corners.Length - 1], navMeshHit.position);
			float num2 = Vector3.Distance(navMeshHit.position, position);
			return num <= proximityReq && num2 <= proximityReq;
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00068C5C File Offset: 0x00066E5C
		private NavMeshPath GetPathTo(Vector3 position, float proximityReq = 1f)
		{
			if (!this.Agent.isOnNavMesh)
			{
				Console.LogWarning("Agent not on nav mesh!", null);
				return null;
			}
			NavMeshPath navMeshPath = new NavMeshPath();
			NavMeshHit navMeshHit;
			NavMeshUtility.SamplePosition(position, out navMeshHit, 2f, -1, true);
			if (!this.Agent.CalculatePath(navMeshHit.position, navMeshPath))
			{
				return null;
			}
			float num = Vector3.Distance(navMeshPath.corners[navMeshPath.corners.Length - 1], navMeshHit.position);
			float num2 = Vector3.Distance(navMeshHit.position, position);
			if (num <= proximityReq && num2 <= proximityReq)
			{
				return navMeshPath;
			}
			return null;
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00068DC0 File Offset: 0x00066FC0
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted = true;
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveWarp_4276783012));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_ActivateRagdoll_Server_2166136261));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_ActivateRagdoll_2690242654));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_ApplyRagdollForce_2690242654));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_DeactivateRagdoll_2166136261));
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00068E51 File Offset: 0x00067051
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00068E64 File Offset: 0x00067064
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00068E74 File Offset: 0x00067074
		private void RpcWriter___Observers_ReceiveWarp_4276783012(Vector3 position)
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
			writer.WriteVector3(position);
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, true, false);
			writer.Store();
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00068F2C File Offset: 0x0006712C
		private void RpcLogic___ReceiveWarp_4276783012(Vector3 position)
		{
			if (!this.IsNPCPositionValid(position))
			{
				string str = "NPCMovement.Warp called with invalid position: ";
				Vector3 vector = position;
				Console.LogWarning(str + vector.ToString(), null);
				return;
			}
			this.Agent.Warp(position);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00068F70 File Offset: 0x00067170
		private void RpcReader___Observers_ReceiveWarp_4276783012(PooledReader PooledReader0, Channel channel)
		{
			Vector3 position = PooledReader0.ReadVector3();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveWarp_4276783012(position);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00068FA4 File Offset: 0x000671A4
		private void RpcWriter___Server_ActivateRagdoll_Server_2166136261()
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
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0006903E File Offset: 0x0006723E
		public void RpcLogic___ActivateRagdoll_Server_2166136261()
		{
			this.ActivateRagdoll(Vector3.zero, Vector3.zero, 0f);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00069058 File Offset: 0x00067258
		private void RpcReader___Server_ActivateRagdoll_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___ActivateRagdoll_Server_2166136261();
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00069088 File Offset: 0x00067288
		private void RpcWriter___Observers_ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
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
			writer.WriteVector3(forcePoint);
			writer.WriteVector3(forceDir);
			writer.WriteSingle(forceMagnitude, AutoPackType.Unpacked);
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00069160 File Offset: 0x00067360
		public void RpcLogic___ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			this.anim.SetRagdollActive(true);
			if (this.onRagdollStart != null)
			{
				this.onRagdollStart.Invoke();
			}
			if (InstanceFinder.IsServer)
			{
				this.EndSetDestination(NPCMovement.WalkResult.Interrupted);
				this.Agent.enabled = false;
			}
			this.capsuleCollider.gameObject.SetActive(false);
			if (forceMagnitude > 0f)
			{
				this.ApplyRagdollForce(forcePoint, forceDir, forceMagnitude);
			}
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x000691C8 File Offset: 0x000673C8
		private void RpcReader___Observers_ActivateRagdoll_2690242654(PooledReader PooledReader0, Channel channel)
		{
			Vector3 forcePoint = PooledReader0.ReadVector3();
			Vector3 forceDir = PooledReader0.ReadVector3();
			float forceMagnitude = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ActivateRagdoll_2690242654(forcePoint, forceDir, forceMagnitude);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0006922C File Offset: 0x0006742C
		private void RpcWriter___Observers_ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
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
			writer.WriteVector3(forcePoint);
			writer.WriteVector3(forceDir);
			writer.WriteSingle(forceMagnitude, AutoPackType.Unpacked);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00069304 File Offset: 0x00067504
		public void RpcLogic___ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			(from x in this.npc.Avatar.RagdollRBs
			select new
			{
				rb = x,
				dist = Vector3.Distance(x.transform.position, forcePoint)
			} into x
			orderby x.dist
			select x).First().rb.AddForceAtPosition(forceDir.normalized * forceMagnitude, forcePoint, 1);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00069388 File Offset: 0x00067588
		private void RpcReader___Observers_ApplyRagdollForce_2690242654(PooledReader PooledReader0, Channel channel)
		{
			Vector3 forcePoint = PooledReader0.ReadVector3();
			Vector3 forceDir = PooledReader0.ReadVector3();
			float forceMagnitude = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ApplyRagdollForce_2690242654(forcePoint, forceDir, forceMagnitude);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x000693EC File Offset: 0x000675EC
		private void RpcWriter___Observers_DeactivateRagdoll_2166136261()
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
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00069498 File Offset: 0x00067698
		public void RpcLogic___DeactivateRagdoll_2166136261()
		{
			this.capsuleCollider.gameObject.SetActive(this.npc.isVisible);
			this.anim.SetRagdollActive(false);
			base.transform.position = this.anim.Avatar.transform.position;
			base.transform.rotation = this.anim.Avatar.transform.rotation;
			this.anim.Avatar.transform.localPosition = Vector3.zero;
			this.anim.Avatar.transform.localRotation = Quaternion.identity;
			this.velocityCalculator.FlushBuffer();
			if (InstanceFinder.IsServer)
			{
				this.Agent.enabled = false;
				if (!this.Agent.isOnNavMesh)
				{
					NavMeshQueryFilter navMeshQueryFilter = default(NavMeshQueryFilter);
					navMeshQueryFilter.agentTypeID = NavMeshUtility.GetNavMeshAgentID("Humanoid");
					navMeshQueryFilter.areaMask = -1;
					NavMeshHit navMeshHit;
					if (this.SmartSampleNavMesh(base.transform.position, out navMeshHit, 1f, 10f, 3))
					{
						this.Agent.Warp(navMeshHit.position);
					}
					this.Agent.enabled = false;
					this.Agent.enabled = true;
				}
			}
			if (this.onRagdollEnd != null)
			{
				this.onRagdollEnd.Invoke();
			}
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x000695F0 File Offset: 0x000677F0
		private void RpcReader___Observers_DeactivateRagdoll_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___DeactivateRagdoll_2166136261();
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0006961C File Offset: 0x0006781C
		protected virtual void dll()
		{
			this.npc = base.GetComponent<NPC>();
			NPC npc = this.npc;
			npc.onVisibilityChanged = (Action<bool>)Delegate.Combine(npc.onVisibilityChanged, new Action<bool>(this.VisibilityChange));
			this.VisibilityChange(this.npc.isVisible);
			base.InvokeRepeating("UpdateAvoidance", 0f, 0.5f);
			for (int i = 0; i < this.npc.Avatar.RagdollRBs.Length; i++)
			{
				this.ragdollForceComponents.Add(this.npc.Avatar.RagdollRBs[i].gameObject.AddComponent<ConstantForce>());
			}
			this.SetRagdollDraggable(false);
			this.SetGravityMultiplier(1f);
		}

		// Token: 0x04001525 RID: 5413
		public const float VEHICLE_RUNOVER_THRESHOLD = 10f;

		// Token: 0x04001526 RID: 5414
		public const float SKATEBOARD_RUNOVER_THRESHOLD = 10f;

		// Token: 0x04001527 RID: 5415
		public const float LIGHT_FLINCH_THRESHOLD = 50f;

		// Token: 0x04001528 RID: 5416
		public const float HEAVY_FLINCH_THRESHOLD = 100f;

		// Token: 0x04001529 RID: 5417
		public const float RAGDOLL_THRESHOLD = 150f;

		// Token: 0x0400152A RID: 5418
		public const float MOMENTUM_ANNOYED_THRESHOLD = 10f;

		// Token: 0x0400152B RID: 5419
		public const float MOMENTUM_LIGHT_FLINCH_THRESHOLD = 20f;

		// Token: 0x0400152C RID: 5420
		public const float MOMENTUM_HEAVY_FLINCH_THRESHOLD = 40f;

		// Token: 0x0400152D RID: 5421
		public const float MOMENTUM_RAGDOLL_THRESHOLD = 60f;

		// Token: 0x0400152E RID: 5422
		public const bool USE_PATH_CACHE = true;

		// Token: 0x0400152F RID: 5423
		public const float STUMBLE_DURATION = 0.66f;

		// Token: 0x04001530 RID: 5424
		public const float STUMBLE_FORCE = 7f;

		// Token: 0x04001531 RID: 5425
		public const float OBSTACLE_AVOIDANCE_RANGE = 25f;

		// Token: 0x04001532 RID: 5426
		public const float PLAYER_DIST_IMPACT_THRESHOLD = 30f;

		// Token: 0x04001533 RID: 5427
		public static Dictionary<Vector3, Vector3> cachedClosestReachablePoints = new Dictionary<Vector3, Vector3>();

		// Token: 0x04001534 RID: 5428
		public static List<Vector3> cachedClosestPointKeys = new List<Vector3>();

		// Token: 0x04001535 RID: 5429
		public const float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = 1f;

		// Token: 0x04001536 RID: 5430
		public bool DEBUG;

		// Token: 0x04001537 RID: 5431
		[Header("Settings")]
		public float WalkSpeed = 1.8f;

		// Token: 0x04001538 RID: 5432
		public float RunSpeed = 7f;

		// Token: 0x04001539 RID: 5433
		public float MoveSpeedMultiplier = 1f;

		// Token: 0x0400153A RID: 5434
		public bool SlipperyMode;

		// Token: 0x0400153B RID: 5435
		public float SlipperyModeMultiplier = 1f;

		// Token: 0x0400153C RID: 5436
		public ObstacleAvoidanceType DefaultObstacleAvoidanceType = 4;

		// Token: 0x0400153D RID: 5437
		[Header("References")]
		public NavMeshAgent Agent;

		// Token: 0x0400153E RID: 5438
		public NPCSpeedController SpeedController;

		// Token: 0x0400153F RID: 5439
		protected NPC npc;

		// Token: 0x04001540 RID: 5440
		public CapsuleCollider capsuleCollider;

		// Token: 0x04001541 RID: 5441
		[SerializeField]
		protected NPCAnimation anim;

		// Token: 0x04001542 RID: 5442
		[SerializeField]
		protected Rigidbody ragdollCentralRB;

		// Token: 0x04001543 RID: 5443
		public SmoothedVelocityCalculator velocityCalculator;

		// Token: 0x04001544 RID: 5444
		[SerializeField]
		protected Draggable RagdollDraggable;

		// Token: 0x04001545 RID: 5445
		[SerializeField]
		protected Collider RagdollDraggableCollider;

		// Token: 0x04001546 RID: 5446
		public float MovementSpeedScale;

		// Token: 0x0400154C RID: 5452
		private float ragdollTime;

		// Token: 0x0400154D RID: 5453
		private float ragdollStaticTime;

		// Token: 0x0400154E RID: 5454
		public UnityEvent<LandVehicle> onHitByCar;

		// Token: 0x0400154F RID: 5455
		public UnityEvent onRagdollStart;

		// Token: 0x04001550 RID: 5456
		public UnityEvent onRagdollEnd;

		// Token: 0x04001553 RID: 5459
		private bool cacheNextPath;

		// Token: 0x04001554 RID: 5460
		private Vector3 currentDestination_Reachable = Vector3.zero;

		// Token: 0x04001555 RID: 5461
		private Action<NPCMovement.WalkResult> walkResultCallback;

		// Token: 0x04001556 RID: 5462
		private float currentMaxDistanceForSuccess = 0.5f;

		// Token: 0x04001557 RID: 5463
		private bool forceIsMoving;

		// Token: 0x04001558 RID: 5464
		private Coroutine FaceDirectionRoutine;

		// Token: 0x04001559 RID: 5465
		private List<ConstantForce> ragdollForceComponents = new List<ConstantForce>();

		// Token: 0x0400155B RID: 5467
		private float timeUntilNextStumble;

		// Token: 0x0400155C RID: 5468
		private float timeSinceStumble = 1000f;

		// Token: 0x0400155D RID: 5469
		private Vector3 stumbleDirection = Vector3.zero;

		// Token: 0x0400155E RID: 5470
		private List<Vector3> desiredVelocityHistory = new List<Vector3>();

		// Token: 0x0400155F RID: 5471
		private int desiredVelocityHistoryLength = 40;

		// Token: 0x04001560 RID: 5472
		private float velocityHistorySpacing = 0.05f;

		// Token: 0x04001561 RID: 5473
		private float timeSinceLastVelocityHistoryRecord;

		// Token: 0x04001562 RID: 5474
		private bool dll_Excuted;

		// Token: 0x04001563 RID: 5475
		private bool dll_Excuted;

		// Token: 0x02000461 RID: 1121
		public enum EAgentType
		{
			// Token: 0x04001565 RID: 5477
			Humanoid,
			// Token: 0x04001566 RID: 5478
			BigHumanoid,
			// Token: 0x04001567 RID: 5479
			IgnoreCosts
		}

		// Token: 0x02000462 RID: 1122
		public enum EStance
		{
			// Token: 0x04001569 RID: 5481
			None,
			// Token: 0x0400156A RID: 5482
			Stanced
		}

		// Token: 0x02000463 RID: 1123
		public enum WalkResult
		{
			// Token: 0x0400156C RID: 5484
			Failed,
			// Token: 0x0400156D RID: 5485
			Interrupted,
			// Token: 0x0400156E RID: 5486
			Stopped,
			// Token: 0x0400156F RID: 5487
			Partial,
			// Token: 0x04001570 RID: 5488
			Success
		}
	}
}
