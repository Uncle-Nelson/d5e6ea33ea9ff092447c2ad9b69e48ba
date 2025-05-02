using System;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000534 RID: 1332
	public class UnconsciousBehaviour : Behaviour
	{
		// Token: 0x0600205C RID: 8284 RVA: 0x00085028 File Offset: 0x00083228
		protected override void Begin()
		{
			base.Begin();
			base.Npc.behaviour.RagdollBehaviour.Disable();
			base.Npc.Movement.ActivateRagdoll(Vector3.zero, Vector3.zero, 0f);
			base.Npc.Movement.SetRagdollDraggable(true);
			base.Npc.dialogueHandler.HideWorldspaceDialogue();
			base.Npc.awareness.SetAwarenessActive(false);
			base.Npc.Avatar.EmotionManager.ClearOverrides();
			base.Npc.Avatar.EmotionManager.AddEmotionOverride("Sleeping", "Dead", 0f, 20);
			this.Particles.Play();
			base.Npc.PlayVO(EVOLineType.Die);
			this.timeOnLastSnore = Time.time;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00085100 File Offset: 0x00083300
		protected override void End()
		{
			base.End();
			base.Npc.awareness.SetAwarenessActive(true);
			base.Npc.Avatar.EmotionManager.RemoveEmotionOverride("Dead");
			base.Npc.Movement.DeactivateRagdoll();
			base.Npc.Movement.SetRagdollDraggable(false);
			this.Particles.Stop();
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0008516A File Offset: 0x0008336A
		public override void ActiveMinPass()
		{
			base.ActiveMinPass();
			if (this.PlaySnoreSounds && Time.time - this.timeOnLastSnore > 6f)
			{
				base.Npc.PlayVO(EVOLineType.Snore);
				this.timeOnLastSnore = Time.time;
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00077708 File Offset: 0x00075908
		public override void Disable()
		{
			base.Disable();
			this.End();
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000851B4 File Offset: 0x000833B4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000851CD File Offset: 0x000833CD
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000851E6 File Offset: 0x000833E6
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000851F4 File Offset: 0x000833F4
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001906 RID: 6406
		public const float SnoreInterval = 6f;

		// Token: 0x04001907 RID: 6407
		public ParticleSystem Particles;

		// Token: 0x04001908 RID: 6408
		public bool PlaySnoreSounds = true;

		// Token: 0x04001909 RID: 6409
		private float timeOnLastSnore;

		// Token: 0x0400190A RID: 6410
		private bool dll_Excuted;

		// Token: 0x0400190B RID: 6411
		private bool dll_Excuted;
	}
}
