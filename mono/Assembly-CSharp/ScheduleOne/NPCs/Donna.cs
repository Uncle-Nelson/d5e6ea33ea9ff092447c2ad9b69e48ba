using System;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200044E RID: 1102
	public class Donna : NPC
	{
		// Token: 0x060015EB RID: 5611 RVA: 0x00060E4F File Offset: 0x0005F04F
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.DonnaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.DonnaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00060E68 File Offset: 0x0005F068
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.DonnaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.DonnaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00060E81 File Offset: 0x0005F081
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00060E8F File Offset: 0x0005F08F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400148A RID: 5258
		private bool dll_Excuted;

		// Token: 0x0400148B RID: 5259
		private bool dll_Excuted;
	}
}
