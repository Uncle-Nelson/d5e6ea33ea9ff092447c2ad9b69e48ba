using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A4 RID: 1188
	public class Dennis : NPC
	{
		// Token: 0x06001A52 RID: 6738 RVA: 0x00070F89 File Offset: 0x0006F189
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.DennisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.DennisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00070FA2 File Offset: 0x0006F1A2
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.DennisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.DennisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00070FBB File Offset: 0x0006F1BB
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00070FC9 File Offset: 0x0006F1C9
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400167B RID: 5755
		private bool dll_Excuted;

		// Token: 0x0400167C RID: 5756
		private bool dll_Excuted;
	}
}
