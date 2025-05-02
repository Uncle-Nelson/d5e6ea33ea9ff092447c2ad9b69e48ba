using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004BD RID: 1213
	public class Kathy : NPC
	{
		// Token: 0x06001ADB RID: 6875 RVA: 0x00071AF3 File Offset: 0x0006FCF3
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KathyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KathyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00071B0C File Offset: 0x0006FD0C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KathyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KathyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00071B25 File Offset: 0x0006FD25
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00071B33 File Offset: 0x0006FD33
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016BA RID: 5818
		private bool dll_Excuted;

		// Token: 0x040016BB RID: 5819
		private bool dll_Excuted;
	}
}
