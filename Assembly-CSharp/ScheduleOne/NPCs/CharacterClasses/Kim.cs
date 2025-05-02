using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C0 RID: 1216
	public class Kim : NPC
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x00071BEF File Offset: 0x0006FDEF
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KimAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KimAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00071C08 File Offset: 0x0006FE08
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KimAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KimAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00071C21 File Offset: 0x0006FE21
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00071C2F File Offset: 0x0006FE2F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016C0 RID: 5824
		private bool dll_Excuted;

		// Token: 0x040016C1 RID: 5825
		private bool dll_Excuted;
	}
}
