using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004D2 RID: 1234
	public class Pearl : NPC
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x000726CA File Offset: 0x000708CA
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.PearlAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.PearlAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x000726E3 File Offset: 0x000708E3
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.PearlAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.PearlAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x000726FC File Offset: 0x000708FC
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0007270A File Offset: 0x0007090A
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016F2 RID: 5874
		private bool dll_Excuted;

		// Token: 0x040016F3 RID: 5875
		private bool dll_Excuted;
	}
}
