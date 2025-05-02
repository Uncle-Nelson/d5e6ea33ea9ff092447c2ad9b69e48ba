using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200049D RID: 1181
	public class Beth : NPC
	{
		// Token: 0x06001A2B RID: 6699 RVA: 0x00070C63 File Offset: 0x0006EE63
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.BethAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.BethAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00070C7C File Offset: 0x0006EE7C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.BethAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.BethAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00070C95 File Offset: 0x0006EE95
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00070CA3 File Offset: 0x0006EEA3
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400166A RID: 5738
		private bool dll_Excuted;

		// Token: 0x0400166B RID: 5739
		private bool dll_Excuted;
	}
}
