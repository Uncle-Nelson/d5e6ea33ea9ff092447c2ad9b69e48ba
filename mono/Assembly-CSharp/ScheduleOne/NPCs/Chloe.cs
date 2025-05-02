using System;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200044D RID: 1101
	public class Chloe : NPC
	{
		// Token: 0x060015E6 RID: 5606 RVA: 0x00060DFB File Offset: 0x0005EFFB
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.ChloeAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.ChloeAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00060E14 File Offset: 0x0005F014
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.ChloeAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.ChloeAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00060E2D File Offset: 0x0005F02D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00060E3B File Offset: 0x0005F03B
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001488 RID: 5256
		private bool dll_Excuted;

		// Token: 0x04001489 RID: 5257
		private bool dll_Excuted;
	}
}
