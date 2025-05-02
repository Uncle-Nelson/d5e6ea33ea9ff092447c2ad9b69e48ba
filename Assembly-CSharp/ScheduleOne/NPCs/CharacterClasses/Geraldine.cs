using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004AC RID: 1196
	public class Geraldine : NPC
	{
		// Token: 0x06001A82 RID: 6786 RVA: 0x000713F8 File Offset: 0x0006F5F8
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.GeraldineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.GeraldineAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00071411 File Offset: 0x0006F611
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.GeraldineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.GeraldineAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0007142A File Offset: 0x0006F62A
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00071438 File Offset: 0x0006F638
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001693 RID: 5779
		private bool dll_Excuted;

		// Token: 0x04001694 RID: 5780
		private bool dll_Excuted;
	}
}
