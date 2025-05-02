using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004AB RID: 1195
	public class George : NPC
	{
		// Token: 0x06001A7D RID: 6781 RVA: 0x000713A4 File Offset: 0x0006F5A4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.GeorgeAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.GeorgeAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x000713BD File Offset: 0x0006F5BD
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.GeorgeAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.GeorgeAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000713D6 File Offset: 0x0006F5D6
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000713E4 File Offset: 0x0006F5E4
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001691 RID: 5777
		private bool dll_Excuted;

		// Token: 0x04001692 RID: 5778
		private bool dll_Excuted;
	}
}
