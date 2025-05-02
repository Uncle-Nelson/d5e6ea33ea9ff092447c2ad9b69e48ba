using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004DD RID: 1245
	public class Trent : NPC
	{
		// Token: 0x06001BAB RID: 7083 RVA: 0x00073040 File Offset: 0x00071240
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.TrentAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.TrentAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00073059 File Offset: 0x00071259
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.TrentAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.TrentAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00073072 File Offset: 0x00071272
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00073080 File Offset: 0x00071280
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001719 RID: 5913
		private bool dll_Excuted;

		// Token: 0x0400171A RID: 5914
		private bool dll_Excuted;
	}
}
