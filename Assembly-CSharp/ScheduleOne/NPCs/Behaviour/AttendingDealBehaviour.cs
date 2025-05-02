using System;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x020004E5 RID: 1253
	public class AttendingDealBehaviour : Behaviour
	{
		// Token: 0x06001BDA RID: 7130 RVA: 0x0007356A File Offset: 0x0007176A
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.AttendingDealBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.AttendingDealBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00073583 File Offset: 0x00071783
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.AttendingDealBehaviourAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.Behaviour.AttendingDealBehaviourAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0007359C File Offset: 0x0007179C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x000735AA File Offset: 0x000717AA
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400172C RID: 5932
		private bool dll_Excuted;

		// Token: 0x0400172D RID: 5933
		private bool dll_Excuted;
	}
}
