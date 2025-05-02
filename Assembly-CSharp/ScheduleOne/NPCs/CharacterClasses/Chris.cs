using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A1 RID: 1185
	public class Chris : NPC
	{
		// Token: 0x06001A3F RID: 6719 RVA: 0x00070DBB File Offset: 0x0006EFBB
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ChrisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ChrisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00070DD4 File Offset: 0x0006EFD4
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ChrisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ChrisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00070DED File Offset: 0x0006EFED
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x00070DFB File Offset: 0x0006EFFB
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001672 RID: 5746
		private bool dll_Excuted;

		// Token: 0x04001673 RID: 5747
		private bool dll_Excuted;
	}
}
