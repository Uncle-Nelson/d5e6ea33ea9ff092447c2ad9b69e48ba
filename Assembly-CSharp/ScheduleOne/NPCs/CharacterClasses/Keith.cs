using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004BE RID: 1214
	public class Keith : NPC
	{
		// Token: 0x06001AE0 RID: 6880 RVA: 0x00071B47 File Offset: 0x0006FD47
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KeithAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KeithAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00071B60 File Offset: 0x0006FD60
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KeithAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KeithAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00071B79 File Offset: 0x0006FD79
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00071B87 File Offset: 0x0006FD87
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016BC RID: 5820
		private bool dll_Excuted;

		// Token: 0x040016BD RID: 5821
		private bool dll_Excuted;
	}
}
