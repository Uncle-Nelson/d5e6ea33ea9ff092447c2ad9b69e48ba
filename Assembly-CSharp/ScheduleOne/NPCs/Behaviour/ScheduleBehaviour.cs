using System;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000531 RID: 1329
	public class ScheduleBehaviour : Behaviour
	{
		// Token: 0x06002039 RID: 8249 RVA: 0x00084C7D File Offset: 0x00082E7D
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.Behaviour.ScheduleBehaviour_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00084C91 File Offset: 0x00082E91
		protected override void Begin()
		{
			base.Begin();
			this.schedule.EnableSchedule();
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00084CA4 File Offset: 0x00082EA4
		protected override void Resume()
		{
			base.Resume();
			this.schedule.EnableSchedule();
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00084CB7 File Offset: 0x00082EB7
		protected override void Pause()
		{
			base.Pause();
			this.schedule.DisableSchedule();
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00084CCA File Offset: 0x00082ECA
		protected override void End()
		{
			base.End();
			this.schedule.DisableSchedule();
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00084CDD File Offset: 0x00082EDD
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ScheduleBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ScheduleBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00084CF6 File Offset: 0x00082EF6
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ScheduleBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ScheduleBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00084D0F File Offset: 0x00082F0F
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00084D1D File Offset: 0x00082F1D
		protected virtual void dll()
		{
			base.Awake();
		}

		// Token: 0x040018F7 RID: 6391
		[Header("References")]
		public NPCScheduleManager schedule;

		// Token: 0x040018F8 RID: 6392
		private bool dll_Excuted;

		// Token: 0x040018F9 RID: 6393
		private bool dll_Excuted;
	}
}
