using System;
using ScheduleOne.VoiceOver;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004EF RID: 1263
	public class CoweringBehaviour : Behaviour
	{
		// Token: 0x06001CCC RID: 7372 RVA: 0x000776B9 File Offset: 0x000758B9
		protected override void Begin()
		{
			base.Begin();
			this.SetCowering(true);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x000776C8 File Offset: 0x000758C8
		public override void Enable()
		{
			base.Enable();
			Console.Log("CoweringBehaviour Enabled", null);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000776DB File Offset: 0x000758DB
		protected override void End()
		{
			base.End();
			this.SetCowering(false);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000776EA File Offset: 0x000758EA
		protected override void Resume()
		{
			base.Resume();
			this.SetCowering(true);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000776F9 File Offset: 0x000758F9
		protected override void Pause()
		{
			base.Pause();
			this.SetCowering(false);
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00077708 File Offset: 0x00075908
		public override void Disable()
		{
			base.Disable();
			this.End();
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00077718 File Offset: 0x00075918
		public override void BehaviourUpdate()
		{
			base.BehaviourUpdate();
			base.Npc.Avatar.LookController.OverrideLookTarget(base.Npc.Movement.FootPosition + base.Npc.Avatar.transform.forward * 2f, 5, false);
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00077778 File Offset: 0x00075978
		private void SetCowering(bool cowering)
		{
			base.Npc.Avatar.Anim.SetCrouched(cowering);
			base.Npc.Avatar.Anim.SetBool("HandsUp", cowering);
			if (cowering)
			{
				base.Npc.PlayVO(EVOLineType.Scared);
				base.Npc.Movement.SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("cowering", 80, 0f));
				return;
			}
			base.Npc.Movement.SpeedController.RemoveSpeedControl("cowering");
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00077807 File Offset: 0x00075A07
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CoweringBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CoweringBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00077820 File Offset: 0x00075A20
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CoweringBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CoweringBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00077839 File Offset: 0x00075A39
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00077847 File Offset: 0x00075A47
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400177F RID: 6015
		private bool dll_Excuted;

		// Token: 0x04001780 RID: 6016
		private bool dll_Excuted;
	}
}
