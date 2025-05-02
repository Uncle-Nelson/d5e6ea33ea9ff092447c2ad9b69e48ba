using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004F0 RID: 1264
	public class DeadBehaviour : Behaviour
	{
		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x0007785B File Offset: 0x00075A5B
		public bool IsInMedicalCenter
		{
			get
			{
				return base.Npc.CurrentBuilding == Singleton<Map>.Instance.MedicalCentre;
			}
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00077877 File Offset: 0x00075A77
		private void Start()
		{
			ScheduleOne.GameTime.TimeManager.onSleepStart = (Action)Delegate.Combine(ScheduleOne.GameTime.TimeManager.onSleepStart, new Action(this.SleepStart));
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00077899 File Offset: 0x00075A99
		private void OnDestroy()
		{
			ScheduleOne.GameTime.TimeManager.onSleepStart = (Action)Delegate.Remove(ScheduleOne.GameTime.TimeManager.onSleepStart, new Action(this.SleepStart));
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000778BC File Offset: 0x00075ABC
		protected override void Begin()
		{
			base.Begin();
			base.Npc.behaviour.RagdollBehaviour.Disable();
			if (Singleton<LoadManager>.Instance.IsLoading)
			{
				this.EnterMedicalCentre();
			}
			else
			{
				base.Npc.Movement.ActivateRagdoll(Vector3.zero, Vector3.zero, 0f);
				base.Npc.Movement.SetRagdollDraggable(true);
			}
			base.Npc.dialogueHandler.HideWorldspaceDialogue();
			base.Npc.awareness.SetAwarenessActive(false);
			base.Npc.Avatar.EmotionManager.ClearOverrides();
			base.Npc.Avatar.EmotionManager.AddEmotionOverride("Sleeping", "Dead", 0f, 20);
			base.Npc.PlayVO(EVOLineType.Die);
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00077994 File Offset: 0x00075B94
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (!this.IsInMedicalCenter && !base.Npc.Avatar.Ragdolled)
			{
				if (base.Npc.Movement.IsMoving)
				{
					base.Npc.Movement.Stop();
				}
				this.EnterMedicalCentre();
			}
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x000779E9 File Offset: 0x00075BE9
		private void SleepStart()
		{
			if (base.Active && !this.IsInMedicalCenter)
			{
				this.EnterMedicalCentre();
			}
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00077A04 File Offset: 0x00075C04
		private void EnterMedicalCentre()
		{
			Console.Log(base.Npc.fullName + " entering medical center", null);
			base.Npc.Movement.DeactivateRagdoll();
			base.Npc.Movement.SetRagdollDraggable(false);
			base.Npc.EnterBuilding(null, Singleton<Map>.Instance.MedicalCentre.GUID.ToString(), 0);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00077A78 File Offset: 0x00075C78
		protected override void End()
		{
			base.End();
			base.Npc.awareness.SetAwarenessActive(true);
			base.Npc.Avatar.EmotionManager.RemoveEmotionOverride("Dead");
			base.Npc.Movement.DeactivateRagdoll();
			base.Npc.Movement.SetRagdollDraggable(false);
			if (this.IsInMedicalCenter)
			{
				base.Npc.ExitBuilding("");
			}
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00077708 File Offset: 0x00075908
		public override void Disable()
		{
			base.Disable();
			this.End();
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00077AEF File Offset: 0x00075CEF
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.DeadBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.DeadBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00077B08 File Offset: 0x00075D08
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.DeadBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.DeadBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00077B21 File Offset: 0x00075D21
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00077B2F File Offset: 0x00075D2F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001781 RID: 6017
		private bool dll_Excuted;

		// Token: 0x04001782 RID: 6018
		private bool dll_Excuted;
	}
}
