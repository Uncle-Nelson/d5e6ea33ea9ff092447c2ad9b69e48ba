using System;
using System.Collections;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vision;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.Combat
{
	// Token: 0x02000740 RID: 1856
	public class CombatBehaviour : ScheduleOne.NPCs.Behaviour.Behaviour
	{
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x000D0711 File Offset: 0x000CE911
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x000D0719 File Offset: 0x000CE919
		public Player TargetPlayer { get; protected set; }

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x000D0722 File Offset: 0x000CE922
		// (set) Token: 0x06003235 RID: 12853 RVA: 0x000D072A File Offset: 0x000CE92A
		public bool IsSearching { get; protected set; }

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x000D0733 File Offset: 0x000CE933
		// (set) Token: 0x06003237 RID: 12855 RVA: 0x000D073B File Offset: 0x000CE93B
		public float TimeSinceTargetReacquired { get; protected set; }

		// Token: 0x06003238 RID: 12856 RVA: 0x000D0744 File Offset: 0x000CE944
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Combat.CombatBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x000D0763 File Offset: 0x000CE963
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (base.Active && this.TargetPlayer != null)
			{
				this.SetTarget(connection, this.TargetPlayer.NetworkObject);
			}
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x000D0794 File Offset: 0x000CE994
		[ObserversRpc(RunLocally = true)]
		public virtual void SetTarget(NetworkConnection conn, NetworkObject target)
		{
			this.RpcWriter___Observers_SetTarget_1824087381(conn, target);
			this.RpcLogic___SetTarget_1824087381(conn, target);
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x000D07B2 File Offset: 0x000CE9B2
		protected override void Begin()
		{
			base.Begin();
			base.Npc.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "post combat", 120f, 1);
			this.StartCombat();
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x000D07E5 File Offset: 0x000CE9E5
		protected override void Resume()
		{
			base.Resume();
			this.StartCombat();
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x000D07F3 File Offset: 0x000CE9F3
		protected override void Pause()
		{
			base.Pause();
			this.EndCombat();
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x000D0801 File Offset: 0x000CEA01
		protected override void End()
		{
			base.End();
			this.EndCombat();
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x000D080F File Offset: 0x000CEA0F
		public override void Disable()
		{
			base.Disable();
			this.TargetPlayer = null;
			this.End();
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000D0824 File Offset: 0x000CEA24
		protected virtual void StartCombat()
		{
			this.CheckPlayerVisibility();
			this.isTargetRecentlyVisible = true;
			this.SetMovementSpeed(this.DefaultMovementSpeed);
			base.Npc.Movement.SetStance(NPCMovement.EStance.Stanced);
			base.Npc.Movement.SetAgentType(NPCMovement.EAgentType.IgnoreCosts);
			base.Npc.Avatar.EmotionManager.AddEmotionOverride("Angry", "combat", 0f, 3);
			if (InstanceFinder.IsServer && this.DefaultWeapon != null)
			{
				this.SetWeapon(this.DefaultWeapon.AssetPath);
			}
			this.nextAngryVO = Time.time + Random.Range(5f, 15f);
			this.successfulHits = 0;
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000D08DC File Offset: 0x000CEADC
		protected void EndCombat()
		{
			this.StopSearching();
			if (InstanceFinder.IsServer && this.currentWeapon != null)
			{
				this.ClearWeapon();
			}
			base.Npc.Movement.SpeedController.RemoveSpeedControl("combat");
			base.Npc.Movement.SetAgentType(NPCMovement.EAgentType.Humanoid);
			base.Npc.Movement.SetStance(NPCMovement.EStance.None);
			base.Npc.Avatar.EmotionManager.RemoveEmotionOverride("combat");
			if (this.TargetPlayer != null)
			{
				base.Npc.awareness.VisionCone.StateSettings[this.TargetPlayer][PlayerVisualState.EVisualState.Visible].Enabled = false;
			}
			this.timeSinceLastSighting = 10000f;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x000D09A8 File Offset: 0x000CEBA8
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			this.UpdateLookAt();
			if (InstanceFinder.IsServer && !this.IsTargetValid())
			{
				base.Disable_Networked(null);
				return;
			}
			if (Time.time > this.nextAngryVO && this.PlayAngryVO)
			{
				EVOLineType lineType = (Random.Range(0, 2) == 0) ? EVOLineType.Angry : EVOLineType.Command;
				base.Npc.PlayVO(lineType);
				this.nextAngryVO = Time.time + Random.Range(5f, 15f);
			}
			if (this.isTargetRecentlyVisible)
			{
				this.lastKnownTargetPosition = this.TargetPlayer.Avatar.CenterPoint;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.IsSearching)
			{
				if (!this.isTargetImmediatelyVisible)
				{
					Console.Log("Combat action: searching", null);
					return;
				}
				this.StopSearching();
			}
			Vector3 centerPoint = base.Npc.Avatar.CenterPoint;
			if (base.Npc.Movement.IsMoving)
			{
				Vector3 currentDestination = base.Npc.Movement.CurrentDestination;
			}
			if (this.isTargetRecentlyVisible)
			{
				if (this.IsTargetInRange(base.Npc.transform.position + Vector3.up * 1f) && this.isTargetImmediatelyVisible)
				{
					if (this.ReadyToAttack(false))
					{
						this.Attack();
						return;
					}
				}
				else if (!this.IsTargetInRange(base.Npc.Movement.CurrentDestination) || !base.Npc.Movement.IsMoving)
				{
					this.RepositionToTargetRange(this.lastKnownTargetPosition);
					return;
				}
			}
			else if (base.Npc.Movement.IsMoving)
			{
				if (Vector3.Distance(base.Npc.Movement.CurrentDestination, this.lastKnownTargetPosition) > 2f)
				{
					base.Npc.Movement.SetDestination(this.lastKnownTargetPosition);
					return;
				}
			}
			else
			{
				if (Vector3.Distance(base.transform.position, this.lastKnownTargetPosition) < 2f)
				{
					this.StartSearching();
					return;
				}
				base.Npc.Movement.SetDestination(this.lastKnownTargetPosition);
			}
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x000D0BB2 File Offset: 0x000CEDB2
		protected virtual void FixedUpdate()
		{
			if (!base.Active)
			{
				return;
			}
			this.CheckPlayerVisibility();
			this.UpdateTimeout();
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x000D0BC9 File Offset: 0x000CEDC9
		protected void UpdateTimeout()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.timeSinceLastSighting > this.GetSearchTime())
			{
				base.Disable_Networked(null);
			}
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x000D0BE8 File Offset: 0x000CEDE8
		protected virtual void UpdateLookAt()
		{
			if (this.isTargetImmediatelyVisible && this.TargetPlayer != null)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.TargetPlayer.MimicCamera.position, 10, true);
			}
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x000D0C28 File Offset: 0x000CEE28
		protected void SetMovementSpeed(float speed)
		{
			base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("combat", 5, speed));
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x000D0C4C File Offset: 0x000CEE4C
		[ObserversRpc(RunLocally = true)]
		protected virtual void SetWeapon(string weaponPath)
		{
			this.RpcWriter___Observers_SetWeapon_3615296227(weaponPath);
			this.RpcLogic___SetWeapon_3615296227(weaponPath);
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x000D0C70 File Offset: 0x000CEE70
		[ObserversRpc(RunLocally = true)]
		protected void ClearWeapon()
		{
			this.RpcWriter___Observers_ClearWeapon_2166136261();
			this.RpcLogic___ClearWeapon_2166136261();
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x000D0C89 File Offset: 0x000CEE89
		protected virtual bool ReadyToAttack(bool checkTarget = true)
		{
			if (this.TimeSinceTargetReacquired < 0.5f && checkTarget)
			{
				return false;
			}
			if (this.currentWeapon != null)
			{
				return this.currentWeapon.IsReadyToAttack();
			}
			return this.VirtualPunchWeapon.IsReadyToAttack();
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x000D0CC3 File Offset: 0x000CEEC3
		[ObserversRpc(RunLocally = true)]
		protected virtual void Attack()
		{
			this.RpcWriter___Observers_Attack_2166136261();
			this.RpcLogic___Attack_2166136261();
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x000D0CD1 File Offset: 0x000CEED1
		protected void SucessfulHit()
		{
			this.successfulHits++;
			if (this.GiveUpAfterSuccessfulHits > 0 && this.successfulHits >= this.GiveUpAfterSuccessfulHits)
			{
				base.Disable_Networked(null);
			}
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x000D0D00 File Offset: 0x000CEF00
		protected void CheckPlayerVisibility()
		{
			if (this.TargetPlayer == null)
			{
				return;
			}
			base.Npc.awareness.VisionCone.StateSettings[this.TargetPlayer][PlayerVisualState.EVisualState.Visible].Enabled = !this.isTargetRecentlyVisible;
			if (this.IsPlayerVisible())
			{
				this.playerSightedDuration += Time.fixedDeltaTime;
				this.isTargetImmediatelyVisible = true;
				this.isTargetRecentlyVisible = true;
			}
			else
			{
				this.playerSightedDuration = 0f;
				this.timeSinceLastSighting += Time.fixedDeltaTime;
				this.isTargetImmediatelyVisible = false;
				if (this.timeSinceLastSighting < 2.5f)
				{
					this.TargetPlayer.CrimeData.RecordLastKnownPosition(false);
					this.isTargetRecentlyVisible = true;
				}
				else
				{
					this.isTargetRecentlyVisible = false;
				}
			}
			if (this.isTargetRecentlyVisible)
			{
				this.MarkPlayerVisible();
			}
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x000D0DDA File Offset: 0x000CEFDA
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

		// Token: 0x0600324E RID: 12878 RVA: 0x000D0E12 File Offset: 0x000CF012
		protected bool IsPlayerVisible()
		{
			return base.Npc.awareness.VisionCone.IsPlayerVisible(this.TargetPlayer);
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x000D0E30 File Offset: 0x000CF030
		private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			if (!base.Active)
			{
				return;
			}
			if (visionEventReceipt.TargetPlayer == this.TargetPlayer.NetworkObject)
			{
				if (!this.isTargetRecentlyVisible)
				{
					this.TimeSinceTargetReacquired = 0f;
				}
				this.isTargetRecentlyVisible = true;
				this.isTargetImmediatelyVisible = true;
				if (this.PlayAngryVO)
				{
					base.Npc.PlayVO(EVOLineType.Angry);
					this.nextAngryVO = Time.time + Random.Range(5f, 15f);
				}
			}
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x000D0EAF File Offset: 0x000CF0AF
		protected virtual float GetSearchTime()
		{
			return this.DefaultSearchTime;
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x000D0EB8 File Offset: 0x000CF0B8
		private void StartSearching()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			Console.Log("Combat action: start searching", null);
			this.IsSearching = true;
			base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("searching", 6, 0.4f));
			this.searchRoutine = base.StartCoroutine(this.SearchRoutine());
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x000D0F18 File Offset: 0x000CF118
		private void StopSearching()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			Console.Log("Combat action: stop searching", null);
			this.IsSearching = false;
			base.Npc.Movement.SpeedController.RemoveSpeedControl("searching");
			this.hasSearchDestination = false;
			if (this.searchRoutine != null)
			{
				base.StopCoroutine(this.searchRoutine);
			}
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x000D0F74 File Offset: 0x000CF174
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
					if (Vector3.Distance(base.transform.position, this.currentSearchDestination) < 2f)
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

		// Token: 0x06003254 RID: 12884 RVA: 0x000D0F84 File Offset: 0x000CF184
		private Vector3 GetNextSearchLocation()
		{
			float num = Mathf.Lerp(25f, 60f, Mathf.Clamp(this.timeSinceLastSighting / this.TargetPlayer.CrimeData.GetSearchTime(), 0f, 1f));
			num = Mathf.Min(num, Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint));
			return this.GetRandomReachablePointNear(this.TargetPlayer.Avatar.CenterPoint, num, 0f);
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x000D100C File Offset: 0x000CF20C
		protected bool IsTargetValid()
		{
			return !(this.TargetPlayer == null) && !this.TargetPlayer.IsArrested && !this.TargetPlayer.IsUnconscious && this.TargetPlayer.Health.IsAlive && !this.TargetPlayer.CrimeData.BodySearchPending && Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) <= this.GiveUpRange;
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x000D109C File Offset: 0x000CF29C
		private void RepositionToTargetRange(Vector3 origin)
		{
			if (this.TargetPlayer == null)
			{
				return;
			}
			Vector3 randomReachablePointNear = this.GetRandomReachablePointNear(origin, this.GetMaxTargetDistance(), this.GetMinTargetDistance());
			base.Npc.Movement.SetDestination(randomReachablePointNear);
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x000D10E0 File Offset: 0x000CF2E0
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
				if (base.Npc.Movement.CanGetTo(navMeshHit.position, 2f) && Vector3.Distance(point, navMeshHit.position) > minDistance)
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

		// Token: 0x06003258 RID: 12888 RVA: 0x000D11A7 File Offset: 0x000CF3A7
		protected float GetMinTargetDistance()
		{
			if (this.overrideTargetDistance)
			{
				return this.targetDistanceOverride;
			}
			if (this.currentWeapon != null)
			{
				return this.currentWeapon.MinUseRange;
			}
			return 0f;
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x000D11D7 File Offset: 0x000CF3D7
		protected float GetMaxTargetDistance()
		{
			if (this.overrideTargetDistance)
			{
				return this.targetDistanceOverride;
			}
			if (this.currentWeapon != null)
			{
				return this.currentWeapon.MaxUseRange;
			}
			return 1.5f;
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x000D1208 File Offset: 0x000CF408
		protected bool IsTargetInRange(Vector3 origin = default(Vector3))
		{
			if (origin == default(Vector3))
			{
				origin = base.transform.position;
			}
			float num = Vector3.Distance(origin, this.TargetPlayer.Avatar.CenterPoint);
			return num > this.GetMinTargetDistance() && num < this.GetMaxTargetDistance();
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x000D12C8 File Offset: 0x000CF4C8
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_SetTarget_1824087381));
			base.RegisterObserversRpc(16U, new ClientRpcDelegate(this.RpcReader___Observers_SetWeapon_3615296227));
			base.RegisterObserversRpc(17U, new ClientRpcDelegate(this.RpcReader___Observers_ClearWeapon_2166136261));
			base.RegisterObserversRpc(18U, new ClientRpcDelegate(this.RpcReader___Observers_Attack_2166136261));
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x000D1348 File Offset: 0x000CF548
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x000D1361 File Offset: 0x000CF561
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x000D1370 File Offset: 0x000CF570
		private void RpcWriter___Observers_SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
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

		// Token: 0x06003260 RID: 12896 RVA: 0x000D1433 File Offset: 0x000CF633
		public virtual void RpcLogic___SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			this.TargetPlayer = target.GetComponent<Player>();
			this.playerSightedDuration = 0f;
			this.timeSinceLastSighting = 0f;
			this.TimeSinceTargetReacquired = 0f;
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x000D1464 File Offset: 0x000CF664
		private void RpcReader___Observers_SetTarget_1824087381(PooledReader PooledReader0, Channel channel)
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
			this.RpcLogic___SetTarget_1824087381(conn, target);
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x000D14B0 File Offset: 0x000CF6B0
		private void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath)
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
			writer.WriteString(weaponPath);
			base.SendObserversRpc(16U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x000D1568 File Offset: 0x000CF768
		protected virtual void RpcLogic___SetWeapon_3615296227(string weaponPath)
		{
			if (this.currentWeapon != null)
			{
				if (weaponPath == this.currentWeapon.AssetPath)
				{
					return;
				}
				this.ClearWeapon();
			}
			if (weaponPath == string.Empty)
			{
				return;
			}
			this.VirtualPunchWeapon.onSuccessfulHit.RemoveListener(new UnityAction(this.SucessfulHit));
			this.currentWeapon = (base.Npc.SetEquippable_Return(weaponPath) as AvatarWeapon);
			this.currentWeapon.onSuccessfulHit.AddListener(new UnityAction(this.SucessfulHit));
			if (this.currentWeapon == null)
			{
				Console.LogError("Failed to equip weapon", null);
				return;
			}
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x000D1614 File Offset: 0x000CF814
		private void RpcReader___Observers_SetWeapon_3615296227(PooledReader PooledReader0, Channel channel)
		{
			string weaponPath = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetWeapon_3615296227(weaponPath);
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000D1650 File Offset: 0x000CF850
		private void RpcWriter___Observers_ClearWeapon_2166136261()
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
			base.SendObserversRpc(17U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x000D16FC File Offset: 0x000CF8FC
		protected void RpcLogic___ClearWeapon_2166136261()
		{
			if (this.currentWeapon == null)
			{
				return;
			}
			this.currentWeapon.onSuccessfulHit.RemoveListener(new UnityAction(this.SucessfulHit));
			base.Npc.SetEquippable_Networked(null, string.Empty);
			this.currentWeapon = null;
			this.VirtualPunchWeapon.onSuccessfulHit.AddListener(new UnityAction(this.SucessfulHit));
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000D1768 File Offset: 0x000CF968
		private void RpcReader___Observers_ClearWeapon_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ClearWeapon_2166136261();
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x000D1794 File Offset: 0x000CF994
		private void RpcWriter___Observers_Attack_2166136261()
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
			base.SendObserversRpc(18U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x000D183D File Offset: 0x000CFA3D
		protected virtual void RpcLogic___Attack_2166136261()
		{
			if (!this.ReadyToAttack(false))
			{
				return;
			}
			if (this.currentWeapon != null)
			{
				this.currentWeapon.Attack();
				return;
			}
			this.VirtualPunchWeapon.Attack();
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x000D1870 File Offset: 0x000CFA70
		private void RpcReader___Observers_Attack_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Attack_2166136261();
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x000D189C File Offset: 0x000CFA9C
		protected virtual void dll()
		{
			base.Awake();
			VisionCone visionCone = base.Npc.awareness.VisionCone;
			visionCone.onVisionEventFull = (VisionCone.EventStateChange)Delegate.Combine(visionCone.onVisionEventFull, new VisionCone.EventStateChange(this.ProcessVisionEvent));
			this.VirtualPunchWeapon.Equip(base.Npc.Avatar);
		}

		// Token: 0x040023C8 RID: 9160
		public const float EXTRA_VISIBILITY_TIME = 2.5f;

		// Token: 0x040023C9 RID: 9161
		public const float SEARCH_RADIUS_MIN = 25f;

		// Token: 0x040023CA RID: 9162
		public const float SEARCH_RADIUS_MAX = 60f;

		// Token: 0x040023CB RID: 9163
		public const float SEARCH_SPEED = 0.4f;

		// Token: 0x040023CC RID: 9164
		public const float CONSECUTIVE_MISS_ACCURACY_BOOST = 0.1f;

		// Token: 0x040023CD RID: 9165
		public const float REACHED_DESTINATION_DISTANCE = 2f;

		// Token: 0x040023D1 RID: 9169
		[Header("General Setttings")]
		public float GiveUpRange = 20f;

		// Token: 0x040023D2 RID: 9170
		public float GiveUpTime = 30f;

		// Token: 0x040023D3 RID: 9171
		public int GiveUpAfterSuccessfulHits;

		// Token: 0x040023D4 RID: 9172
		public bool PlayAngryVO = true;

		// Token: 0x040023D5 RID: 9173
		[Header("Movement settings")]
		[Range(0f, 1f)]
		public float DefaultMovementSpeed = 0.6f;

		// Token: 0x040023D6 RID: 9174
		[Header("Weapon settings")]
		public AvatarWeapon DefaultWeapon;

		// Token: 0x040023D7 RID: 9175
		public AvatarMeleeWeapon VirtualPunchWeapon;

		// Token: 0x040023D8 RID: 9176
		[Header("Search settings")]
		public float DefaultSearchTime = 30f;

		// Token: 0x040023D9 RID: 9177
		protected bool overrideTargetDistance;

		// Token: 0x040023DA RID: 9178
		protected float targetDistanceOverride;

		// Token: 0x040023DB RID: 9179
		protected bool isTargetRecentlyVisible;

		// Token: 0x040023DC RID: 9180
		protected bool isTargetImmediatelyVisible;

		// Token: 0x040023DD RID: 9181
		protected float timeSinceLastSighting = 10000f;

		// Token: 0x040023DE RID: 9182
		protected float playerSightedDuration;

		// Token: 0x040023DF RID: 9183
		protected Vector3 lastKnownTargetPosition = Vector3.zero;

		// Token: 0x040023E0 RID: 9184
		protected AvatarWeapon currentWeapon;

		// Token: 0x040023E1 RID: 9185
		protected int successfulHits;

		// Token: 0x040023E2 RID: 9186
		protected int consecutiveMissedShots;

		// Token: 0x040023E3 RID: 9187
		protected Coroutine rangedWeaponRoutine;

		// Token: 0x040023E4 RID: 9188
		protected Coroutine searchRoutine;

		// Token: 0x040023E5 RID: 9189
		protected Vector3 currentSearchDestination = Vector3.zero;

		// Token: 0x040023E6 RID: 9190
		protected bool hasSearchDestination;

		// Token: 0x040023E7 RID: 9191
		private float nextAngryVO;

		// Token: 0x040023E8 RID: 9192
		private bool dll_Excuted;

		// Token: 0x040023E9 RID: 9193
		private bool dll_Excuted;
	}
}
