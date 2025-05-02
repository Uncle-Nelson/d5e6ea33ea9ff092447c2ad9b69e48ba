using System;
using FishNet;
using FishNet.Object;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x0200047B RID: 1147
	[Serializable]
	public abstract class NPCAction : NetworkBehaviour
	{
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0006D212 File Offset: 0x0006B412
		protected string ActionName
		{
			get
			{
				return "ActionName";
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x0006D219 File Offset: 0x0006B419
		public bool IsEvent
		{
			get
			{
				return this is NPCEvent;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x0006D224 File Offset: 0x0006B424
		public bool IsSignal
		{
			get
			{
				return this is NPCSignal;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x0006D22F File Offset: 0x0006B42F
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x0006D237 File Offset: 0x0006B437
		public bool IsActive { get; protected set; }

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x0006D240 File Offset: 0x0006B440
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x0006D248 File Offset: 0x0006B448
		public bool HasStarted { get; protected set; }

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0006D251 File Offset: 0x0006B451
		public virtual int Priority
		{
			get
			{
				return this.priority;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0006D259 File Offset: 0x0006B459
		protected NPCMovement movement
		{
			get
			{
				return this.npc.Movement;
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0006D266 File Offset: 0x0006B466
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCAction_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0006D27A File Offset: 0x0006B47A
		protected override void OnValidate()
		{
			base.OnValidate();
			this.GetReferences();
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0006D288 File Offset: 0x0006B488
		private void GetReferences()
		{
			if (this.npc == null)
			{
				this.npc = base.GetComponentInParent<NPC>();
			}
			if (this.schedule == null)
			{
				this.schedule = base.GetComponentInParent<NPCScheduleManager>();
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0006D2BE File Offset: 0x0006B4BE
		protected virtual void Start()
		{
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPassed));
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0006D2E8 File Offset: 0x0006B4E8
		public virtual void Started()
		{
			this.GetReferences();
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log(this.GetName() + " started");
			}
			this.IsActive = true;
			this.schedule.ActiveAction = this;
			this.HasStarted = true;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0006D338 File Offset: 0x0006B538
		public virtual void LateStarted()
		{
			this.GetReferences();
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log(this.GetName() + " late started");
			}
			this.IsActive = true;
			this.schedule.ActiveAction = this;
			this.HasStarted = true;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0006D388 File Offset: 0x0006B588
		public virtual void JumpTo()
		{
			this.GetReferences();
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log(this.GetName() + " jumped to");
			}
			this.IsActive = true;
			this.schedule.ActiveAction = this;
			this.HasStarted = true;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0006D3D8 File Offset: 0x0006B5D8
		public virtual void End()
		{
			this.GetReferences();
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log(this.GetName() + " ended");
			}
			this.IsActive = false;
			this.schedule.ActiveAction = null;
			this.HasStarted = false;
			if (this.onEnded != null)
			{
				this.onEnded();
			}
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0006D43C File Offset: 0x0006B63C
		public virtual void Interrupt()
		{
			this.GetReferences();
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log(this.GetName() + " interrupted");
			}
			this.IsActive = false;
			this.schedule.ActiveAction = null;
			if (!this.schedule.PendingActions.Contains(this))
			{
				this.schedule.PendingActions.Add(this);
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0006D4A8 File Offset: 0x0006B6A8
		public virtual void Resume()
		{
			this.GetReferences();
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log(this.GetName() + " resumed");
			}
			this.IsActive = true;
			this.schedule.ActiveAction = this;
			if (this.schedule.PendingActions.Contains(this))
			{
				this.schedule.PendingActions.Remove(this);
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0006D518 File Offset: 0x0006B718
		public virtual void ResumeFailed()
		{
			this.GetReferences();
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log(this.GetName() + " resume failed");
			}
			this.HasStarted = false;
			if (this.schedule.PendingActions.Contains(this))
			{
				this.schedule.PendingActions.Remove(this);
			}
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0006D579 File Offset: 0x0006B779
		public virtual void Skipped()
		{
			this.GetReferences();
			if (this.schedule.DEBUG_MODE)
			{
				Debug.Log(base.gameObject.name + " skipped");
			}
			this.IsActive = false;
			this.HasStarted = false;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void ActiveUpdate()
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void ActiveMinPassed()
		{
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0006D5B6 File Offset: 0x0006B7B6
		public virtual void PendingMinPassed()
		{
			if (this.HasStarted && !this.IsActive && !NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime, this.GetEndTime()))
			{
				this.ResumeFailed();
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void MinPassed()
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0006D5E6 File Offset: 0x0006B7E6
		public virtual bool ShouldStart()
		{
			return base.gameObject.activeInHierarchy;
		}

		// Token: 0x060018E3 RID: 6371
		public abstract string GetName();

		// Token: 0x060018E4 RID: 6372
		public abstract string GetTimeDescription();

		// Token: 0x060018E5 RID: 6373
		public abstract int GetEndTime();

		// Token: 0x060018E6 RID: 6374 RVA: 0x0006D5F8 File Offset: 0x0006B7F8
		protected void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (teleportIfFail && this.consecutivePathingFailures >= 5 && !this.movement.CanGetTo(position, 1f))
			{
				Console.LogWarning(this.npc.fullName + " too many pathing failures. Warping to " + position.ToString(), null);
				this.movement.Warp(position);
				this.WalkCallback(NPCMovement.WalkResult.Success);
				return;
			}
			this.movement.SetDestination(position, new Action<NPCMovement.WalkResult>(this.WalkCallback), 1f, 1f);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0006D68C File Offset: 0x0006B88C
		protected virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			if (!this.IsActive)
			{
				return;
			}
			if (result == NPCMovement.WalkResult.Failed)
			{
				this.consecutivePathingFailures++;
			}
			else
			{
				this.consecutivePathingFailures = 0;
			}
			if (this.schedule.DEBUG_MODE)
			{
				Console.Log("Walk callback result: " + result.ToString(), null);
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0006D6E6 File Offset: 0x0006B8E6
		public virtual void SetStartTime(int startTime)
		{
			this.StartTime = startTime;
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0006D6EF File Offset: 0x0006B8EF
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0006D702 File Offset: 0x0006B902
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0006D715 File Offset: 0x0006B915
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0006D723 File Offset: 0x0006B923
		protected virtual void dll()
		{
			this.GetReferences();
		}

		// Token: 0x040015DC RID: 5596
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		// Token: 0x040015DF RID: 5599
		[SerializeField]
		protected int priority;

		// Token: 0x040015E0 RID: 5600
		[Header("Timing Settings")]
		public int StartTime;

		// Token: 0x040015E1 RID: 5601
		protected NPC npc;

		// Token: 0x040015E2 RID: 5602
		protected NPCScheduleManager schedule;

		// Token: 0x040015E3 RID: 5603
		public Action onEnded;

		// Token: 0x040015E4 RID: 5604
		protected int consecutivePathingFailures;

		// Token: 0x040015E5 RID: 5605
		private bool dll_Excuted;

		// Token: 0x040015E6 RID: 5606
		private bool dll_Excuted;
	}
}
