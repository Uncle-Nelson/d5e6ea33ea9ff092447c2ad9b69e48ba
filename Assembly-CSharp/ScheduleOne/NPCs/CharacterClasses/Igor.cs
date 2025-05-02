using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004B0 RID: 1200
	public class Igor : NPC
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x000715C3 File Offset: 0x0006F7C3
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.IgorAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.IgorAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x000715DC File Offset: 0x0006F7DC
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.IgorAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.IgorAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x000715F5 File Offset: 0x0006F7F5
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00071603 File Offset: 0x0006F803
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400169D RID: 5789
		private bool dll_Excuted;

		// Token: 0x0400169E RID: 5790
		private bool dll_Excuted;
	}
}
