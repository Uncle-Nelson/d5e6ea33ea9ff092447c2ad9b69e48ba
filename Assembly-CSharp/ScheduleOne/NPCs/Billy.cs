using System;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200044C RID: 1100
	public class Billy : NPC
	{
		// Token: 0x060015E1 RID: 5601 RVA: 0x00060DA7 File Offset: 0x0005EFA7
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00060DC0 File Offset: 0x0005EFC0
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.BillyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00060DD9 File Offset: 0x0005EFD9
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00060DE7 File Offset: 0x0005EFE7
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001486 RID: 5254
		private bool dll_Excuted;

		// Token: 0x04001487 RID: 5255
		private bool dll_Excuted;
	}
}
