using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A9 RID: 1193
	public class Frank : NPC
	{
		// Token: 0x06001A73 RID: 6771 RVA: 0x000712FC File Offset: 0x0006F4FC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FrankAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.FrankAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00071315 File Offset: 0x0006F515
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FrankAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.FrankAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0007132E File Offset: 0x0006F52E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0007133C File Offset: 0x0006F53C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400168D RID: 5773
		private bool dll_Excuted;

		// Token: 0x0400168E RID: 5774
		private bool dll_Excuted;
	}
}
