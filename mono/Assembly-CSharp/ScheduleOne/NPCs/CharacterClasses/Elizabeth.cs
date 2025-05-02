using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A5 RID: 1189
	public class Elizabeth : NPC
	{
		// Token: 0x06001A57 RID: 6743 RVA: 0x00070FDD File Offset: 0x0006F1DD
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ElizabethAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ElizabethAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00070FF6 File Offset: 0x0006F1F6
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ElizabethAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ElizabethAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0007100F File Offset: 0x0006F20F
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0007101D File Offset: 0x0006F21D
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400167D RID: 5757
		private bool dll_Excuted;

		// Token: 0x0400167E RID: 5758
		private bool dll_Excuted;
	}
}
