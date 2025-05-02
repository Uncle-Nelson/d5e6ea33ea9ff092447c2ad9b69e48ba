using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004AD RID: 1197
	public class Greg : NPC
	{
		// Token: 0x06001A87 RID: 6791 RVA: 0x0007144C File Offset: 0x0006F64C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.GregAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.GregAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00071465 File Offset: 0x0006F665
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.GregAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.GregAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0007147E File Offset: 0x0006F67E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0007148C File Offset: 0x0006F68C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001695 RID: 5781
		private bool dll_Excuted;

		// Token: 0x04001696 RID: 5782
		private bool dll_Excuted;
	}
}
