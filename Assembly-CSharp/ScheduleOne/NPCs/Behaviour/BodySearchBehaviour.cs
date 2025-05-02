using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.ItemFramework;
using ScheduleOne.Law;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.UI;
using ScheduleOne.Vehicles;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004E7 RID: 1255
	public class BodySearchBehaviour : Behaviour
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x000749A4 File Offset: 0x00072BA4
		public static float BODY_SEARCH_TIME
		{
			get
			{
				if (!NetworkSingleton<GameManager>.Instance.IsTutorial)
				{
					return 2.5f;
				}
				return 4f;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x000749BD File Offset: 0x00072BBD
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x000749C5 File Offset: 0x00072BC5
		public Player TargetPlayer { get; protected set; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x000749CE File Offset: 0x00072BCE
		private DialogueDatabase dialogueDatabase
		{
			get
			{
				return this.officer.dialogueHandler.Database;
			}
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x000749E0 File Offset: 0x00072BE0
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.BodySearchBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x000749F4 File Offset: 0x00072BF4
		protected override void Begin()
		{
			base.Begin();
			base.Npc.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Police, "bodysearch_begin"), NetworkSingleton<GameManager>.Instance.IsTutorial ? 4f : 5f);
			base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("bodysearching", 40, 0.15f));
			base.Npc.Movement.SetAgentType(NPCMovement.EAgentType.IgnoreCosts);
			base.Npc.PlayVO(EVOLineType.Command);
			if (this.TargetPlayer.IsOwner)
			{
				PlayerSingleton<PlayerCamera>.Instance.FocusCameraOnTarget(base.Npc.Avatar.MiddleSpineRB.transform);
			}
			this.TargetPlayer.CrimeData.ResetBodysearchCooldown();
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00074AC0 File Offset: 0x00072CC0
		protected override void Resume()
		{
			base.Resume();
			base.Npc.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Police, "bodysearch_begin"), 5f);
			base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("bodysearching", 40, 0.15f));
			base.Npc.Movement.SetAgentType(NPCMovement.EAgentType.IgnoreCosts);
			this.TargetPlayer.CrimeData.ResetBodysearchCooldown();
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00074B40 File Offset: 0x00072D40
		protected override void End()
		{
			base.End();
			if (this.TargetPlayer != null)
			{
				this.TargetPlayer.CrimeData.BodySearchPending = false;
			}
			this.Disable();
			base.Npc.Avatar.Anim.SetBool("PatDown", false);
			base.Npc.Movement.SetAgentType(NPCMovement.EAgentType.Humanoid);
			this.ClearSpeedControls();
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00074BAA File Offset: 0x00072DAA
		protected override void Pause()
		{
			base.Pause();
			base.Npc.Avatar.Anim.SetBool("PatDown", false);
			base.Npc.Movement.SetAgentType(NPCMovement.EAgentType.Humanoid);
			this.ClearSpeedControls();
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00074BE4 File Offset: 0x00072DE4
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			this.searchTime += Time.deltaTime;
			this.UpdateSearch();
			this.UpdateCircle();
			this.UpdateLookAt();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (!this.IsTargetValid(this.TargetPlayer))
			{
				base.Disable_Networked(null);
				base.End_Networked(null);
				return;
			}
			this.UpdateMovement();
			this.UpdateEscalation();
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00074C4C File Offset: 0x00072E4C
		private void UpdateSearch()
		{
			if (this.TargetPlayer == null)
			{
				return;
			}
			if (this.TargetPlayer.IsOwner && Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) < 2f && !Singleton<BodySearchScreen>.Instance.IsOpen)
			{
				base.Npc.dialogueHandler.HideWorldspaceDialogue();
				Singleton<BodySearchScreen>.Instance.onSearchClear.AddListener(new UnityAction(this.SearchClean));
				if (!GameManager.IS_TUTORIAL)
				{
					Singleton<BodySearchScreen>.Instance.onSearchFail.AddListener(new UnityAction(this.SearchFail));
				}
				float num = 1f;
				if (Player.Local.Sneaky)
				{
					num = 1.5f;
				}
				base.Npc.Movement.Stop();
				Singleton<BodySearchScreen>.Instance.Open(this.officer, this.officer.BodySearchDuration * num);
				PlayerSingleton<PlayerCamera>.Instance.StopFocus();
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00074D50 File Offset: 0x00072F50
		protected virtual void UpdateMovement()
		{
			if (InstanceFinder.IsServer && Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) >= 2f)
			{
				bool flag = false;
				if (!base.Npc.Movement.IsMoving)
				{
					flag = true;
				}
				if (Vector3.Distance(this.TargetPlayer.Avatar.CenterPoint, base.Npc.Movement.CurrentDestination) > 2f)
				{
					flag = true;
				}
				if (flag)
				{
					Vector3 newDestination = this.GetNewDestination();
					if (base.Npc.Movement.CanGetTo(newDestination, 2f))
					{
						this.timeSinceCantReach = 0f;
						base.Npc.Movement.SetDestination(this.GetNewDestination());
						return;
					}
					this.timeSinceCantReach += Time.deltaTime;
					if (this.timeSinceCantReach >= 1f)
					{
						this.Escalate();
					}
				}
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00074E3E File Offset: 0x0007303E
		private void SearchClean()
		{
			Singleton<BodySearchScreen>.Instance.onSearchClear.RemoveListener(new UnityAction(this.SearchClean));
			Singleton<BodySearchScreen>.Instance.onSearchFail.RemoveListener(new UnityAction(this.SearchFail));
			this.ConcludeSearch(true);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00074E7D File Offset: 0x0007307D
		private void SearchFail()
		{
			Singleton<BodySearchScreen>.Instance.onSearchClear.RemoveListener(new UnityAction(this.SearchClean));
			Singleton<BodySearchScreen>.Instance.onSearchFail.RemoveListener(new UnityAction(this.SearchFail));
			this.ConcludeSearch(false);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00074EBC File Offset: 0x000730BC
		private void UpdateEscalation()
		{
			if (NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				return;
			}
			if (this.searchTime >= 15f && this.TargetPlayer.IsOwner && !Singleton<BodySearchScreen>.Instance.IsOpen)
			{
				this.Escalate();
			}
			if (this.timeOutsideRange >= 4f)
			{
				this.Escalate();
			}
			if (this.TargetPlayer.CurrentVehicle != null)
			{
				this.Escalate();
			}
			if (Vector3.Distance(base.transform.position, this.TargetPlayer.Avatar.CenterPoint) > Mathf.Max(15f, this.targetDistanceOnStart + 5f))
			{
				this.Escalate();
			}
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00074F6C File Offset: 0x0007316C
		protected virtual void UpdateLookAt()
		{
			if (this.TargetPlayer != null)
			{
				base.Npc.Avatar.LookController.OverrideLookTarget(this.TargetPlayer.MimicCamera.position, 10, true);
			}
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00074FA4 File Offset: 0x000731A4
		protected virtual void UpdateCircle()
		{
			if (this.TargetPlayer == null || this.TargetPlayer != Player.Local)
			{
				this.SetArrestCircleAlpha(0f);
				return;
			}
			float num = Vector3.Distance(this.TargetPlayer.Avatar.CenterPoint, base.transform.position);
			if (num < 2f)
			{
				this.SetArrestCircleAlpha(this.ArrestCircle_MaxOpacity);
				this.SetArrestCircleColor(new Color32(75, 165, byte.MaxValue, byte.MaxValue));
				return;
			}
			if (num < this.ArrestCircle_MaxVisibleDistance)
			{
				float arrestCircleAlpha = Mathf.Lerp(this.ArrestCircle_MaxOpacity, 0f, (num - 2f) / (this.ArrestCircle_MaxVisibleDistance - 2f));
				this.SetArrestCircleAlpha(arrestCircleAlpha);
				this.SetArrestCircleColor(Color.white);
				return;
			}
			this.SetArrestCircleAlpha(0f);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00075080 File Offset: 0x00073280
		private void SetArrestCircleAlpha(float alpha)
		{
			this.officer.ProxCircle.SetAlpha(alpha);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00075093 File Offset: 0x00073293
		private void SetArrestCircleColor(Color col)
		{
			this.officer.ProxCircle.SetColor(col);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x000750A8 File Offset: 0x000732A8
		private Vector3 GetNewDestination()
		{
			return this.TargetPlayer.Avatar.CenterPoint + (base.transform.position - this.TargetPlayer.Avatar.CenterPoint).normalized * 1.2f;
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000750FC File Offset: 0x000732FC
		private void ClearSpeedControls()
		{
			if (base.Npc.Movement.SpeedController.DoesSpeedControlExist("bodysearching"))
			{
				base.Npc.Movement.SpeedController.RemoveSpeedControl("bodysearching");
			}
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00075134 File Offset: 0x00073334
		private bool IsTargetValid(Player player)
		{
			return !(player == null) && !player.IsArrested && !player.IsSleeping && !player.IsUnconscious && player.Health.IsAlive && player.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None;
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0007518C File Offset: 0x0007338C
		[ObserversRpc(RunLocally = true)]
		public virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
			this.RpcWriter___Observers_AssignTarget_1824087381(conn, target);
			this.RpcLogic___AssignTarget_1824087381(conn, target);
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x000751B8 File Offset: 0x000733B8
		public virtual bool DoesPlayerContainItemsOfInterest()
		{
			foreach (ItemSlot itemSlot in PlayerSingleton<PlayerInventory>.Instance.hotbarSlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					if (itemSlot.ItemInstance is ProductItemInstance)
					{
						ProductItemInstance productItemInstance = itemSlot.ItemInstance as ProductItemInstance;
						if (productItemInstance.AppliedPackaging == null || productItemInstance.AppliedPackaging.StealthLevel <= this.MaxStealthLevel)
						{
							return true;
						}
					}
					else if (itemSlot.ItemInstance.Definition.legalStatus != ELegalStatus.Legal)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00075268 File Offset: 0x00073468
		public virtual void ConcludeSearch(bool clear)
		{
			if (!clear)
			{
				if (this.ShowPostSearchDialogue)
				{
					base.Npc.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Police, "bodysearch_escalate"), 2f);
				}
				base.Npc.PlayVO(EVOLineType.Angry);
				this.TargetPlayer.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				this.officer.BeginFootPursuit_Networked(this.TargetPlayer.NetworkObject, true);
				if (this.onSearchComplete_ItemsFound != null)
				{
					this.onSearchComplete_ItemsFound.Invoke();
				}
			}
			else
			{
				this.NoItemsOfInterestFound();
				if (!NetworkSingleton<GameManager>.Instance.IsTutorial)
				{
					base.Npc.PlayVO(EVOLineType.Thanks);
				}
				if (this.onSearchComplete_Clear != null)
				{
					this.onSearchComplete_Clear.Invoke();
				}
				if (this.officer.CheckpointBehaviour.Enabled)
				{
					LandVehicle lastDrivenVehicle = this.TargetPlayer.LastDrivenVehicle;
					CheckpointBehaviour checkpointBehaviour = this.officer.CheckpointBehaviour;
					if (lastDrivenVehicle != null && (checkpointBehaviour.Checkpoint.SearchArea1.vehicles.Contains(lastDrivenVehicle) || checkpointBehaviour.Checkpoint.SearchArea2.vehicles.Contains(lastDrivenVehicle)))
					{
						this.officer.dialogueHandler.ShowWorldspaceDialogue("Thanks. I'll now check your vehicle.", 5f);
						checkpointBehaviour.StartSearch(lastDrivenVehicle.NetworkObject, this.TargetPlayer.NetworkObject);
					}
				}
			}
			base.SendEnd();
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x000753C4 File Offset: 0x000735C4
		public virtual void Escalate()
		{
			if (GameManager.IS_TUTORIAL)
			{
				return;
			}
			Debug.Log("Escalating!");
			base.Npc.PlayVO(EVOLineType.Angry);
			base.Npc.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Police, "bodysearch_escalate"), 2f);
			this.TargetPlayer.CrimeData.AddCrime(new FailureToComply(), 1);
			this.TargetPlayer.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
			this.officer.BeginFootPursuit_Networked(this.TargetPlayer.NetworkObject, true);
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00075454 File Offset: 0x00073654
		public virtual void NoItemsOfInterestFound()
		{
			if (this.ShowPostSearchDialogue)
			{
				base.Npc.dialogueHandler.ShowWorldspaceDialogue(this.dialogueDatabase.GetLine(EDialogueModule.Police, "bodysearch_all_clear"), 3f);
			}
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x000754A9 File Offset: 0x000736A9
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(15U, new ClientRpcDelegate(this.RpcReader___Observers_AssignTarget_1824087381));
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x000754D9 File Offset: 0x000736D9
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000754F2 File Offset: 0x000736F2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00075500 File Offset: 0x00073700
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

		// Token: 0x06001C4D RID: 7245 RVA: 0x000755C4 File Offset: 0x000737C4
		public virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			this.TargetPlayer = target.GetComponent<Player>();
			this.TargetPlayer.CrimeData.BodySearchPending = true;
			this.searchTime = 0f;
			this.timeWithinSearchRange = 0f;
			this.timeOutsideRange = 0f;
			this.hasBeenInRange = false;
			this.timeSinceCantReach = 0f;
			this.targetDistanceOnStart = Vector3.Distance(this.TargetPlayer.Avatar.CenterPoint, base.transform.position);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00075648 File Offset: 0x00073848
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

		// Token: 0x06001C4F RID: 7247 RVA: 0x00075694 File Offset: 0x00073894
		protected virtual void dll()
		{
			base.Awake();
			this.officer = (base.Npc as PoliceOfficer);
		}

		// Token: 0x0400173D RID: 5949
		public const EStealthLevel MAX_STEALTH_LEVEL = EStealthLevel.None;

		// Token: 0x0400173E RID: 5950
		public const float BODY_SEARCH_RANGE = 2f;

		// Token: 0x0400173F RID: 5951
		public const float MAX_SEARCH_TIME = 15f;

		// Token: 0x04001740 RID: 5952
		public const float MAX_TIME_OUTSIDE_RANGE = 4f;

		// Token: 0x04001741 RID: 5953
		public const float RANGE_TO_ESCALATE = 15f;

		// Token: 0x04001742 RID: 5954
		public const float MOVE_SPEED = 0.15f;

		// Token: 0x04001743 RID: 5955
		public const float BODY_SEARCH_COOLDOWN = 30f;

		// Token: 0x04001745 RID: 5957
		[Header("Settings")]
		public float ArrestCircle_MaxVisibleDistance = 5f;

		// Token: 0x04001746 RID: 5958
		public float ArrestCircle_MaxOpacity = 0.25f;

		// Token: 0x04001747 RID: 5959
		public bool ShowPostSearchDialogue = true;

		// Token: 0x04001748 RID: 5960
		[Header("Item of interest settings")]
		public EStealthLevel MaxStealthLevel;

		// Token: 0x04001749 RID: 5961
		private PoliceOfficer officer;

		// Token: 0x0400174A RID: 5962
		private float targetDistanceOnStart;

		// Token: 0x0400174B RID: 5963
		private float searchTime;

		// Token: 0x0400174C RID: 5964
		private bool hasBeenInRange;

		// Token: 0x0400174D RID: 5965
		private float timeOutsideRange;

		// Token: 0x0400174E RID: 5966
		private float timeWithinSearchRange;

		// Token: 0x0400174F RID: 5967
		private float timeSinceCantReach;

		// Token: 0x04001750 RID: 5968
		[Header("Events")]
		public UnityEvent onSearchComplete_Clear;

		// Token: 0x04001751 RID: 5969
		public UnityEvent onSearchComplete_ItemsFound;

		// Token: 0x04001752 RID: 5970
		private bool dll_Excuted;

		// Token: 0x04001753 RID: 5971
		private bool dll_Excuted;
	}
}
