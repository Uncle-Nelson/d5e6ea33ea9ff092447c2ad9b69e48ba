using System;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000533 RID: 1331
	public class StationaryBehaviour : Behaviour
	{
		// Token: 0x06002055 RID: 8277 RVA: 0x0007F54F File Offset: 0x0007D74F
		protected override void Begin()
		{
			base.Begin();
			base.Npc.Movement.Stop();
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00084FBC File Offset: 0x000831BC
		protected override void Resume()
		{
			base.Resume();
			base.Npc.Movement.Stop();
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00084FD4 File Offset: 0x000831D4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StationaryBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StationaryBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00084FED File Offset: 0x000831ED
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StationaryBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StationaryBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00085006 File Offset: 0x00083206
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00085014 File Offset: 0x00083214
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001904 RID: 6404
		private bool dll_Excuted;

		// Token: 0x04001905 RID: 6405
		private bool dll_Excuted;
	}
}
