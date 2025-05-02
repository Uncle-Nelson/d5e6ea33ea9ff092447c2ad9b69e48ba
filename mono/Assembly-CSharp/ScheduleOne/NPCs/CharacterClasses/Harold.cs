using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004AE RID: 1198
	public class Harold : NPC
	{
		// Token: 0x06001A8C RID: 6796 RVA: 0x000714A0 File Offset: 0x0006F6A0
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.HaroldAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.HaroldAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000714B9 File Offset: 0x0006F6B9
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.HaroldAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.HaroldAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000714D2 File Offset: 0x0006F6D2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000714E0 File Offset: 0x0006F6E0
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001697 RID: 5783
		private bool dll_Excuted;

		// Token: 0x04001698 RID: 5784
		private bool dll_Excuted;
	}
}
