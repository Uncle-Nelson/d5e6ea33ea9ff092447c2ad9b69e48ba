using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004B2 RID: 1202
	public class Jackie : NPC
	{
		// Token: 0x06001AA2 RID: 6818 RVA: 0x0007166B File Offset: 0x0006F86B
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JackieAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JackieAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00071684 File Offset: 0x0006F884
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JackieAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JackieAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x0007169D File Offset: 0x0006F89D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x000716AB File Offset: 0x0006F8AB
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016A1 RID: 5793
		private bool dll_Excuted;

		// Token: 0x040016A2 RID: 5794
		private bool dll_Excuted;
	}
}
