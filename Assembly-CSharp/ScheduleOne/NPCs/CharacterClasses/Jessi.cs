using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004BA RID: 1210
	public class Jessi : NPC
	{
		// Token: 0x06001ACC RID: 6860 RVA: 0x000719F7 File Offset: 0x0006FBF7
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JessiAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JessiAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00071A10 File Offset: 0x0006FC10
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JessiAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JessiAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00071A29 File Offset: 0x0006FC29
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00071A37 File Offset: 0x0006FC37
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016B4 RID: 5812
		private bool dll_Excuted;

		// Token: 0x040016B5 RID: 5813
		private bool dll_Excuted;
	}
}
