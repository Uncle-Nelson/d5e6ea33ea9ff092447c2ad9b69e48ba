using System;
using ScheduleOne.Economy;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004E3 RID: 1251
	public class Salvador : Supplier
	{
		// Token: 0x06001BCF RID: 7119 RVA: 0x00073476 File Offset: 0x00071676
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SalvadorAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SalvadorAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0007348F File Offset: 0x0007168F
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SalvadorAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SalvadorAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x000734A8 File Offset: 0x000716A8
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000734B6 File Offset: 0x000716B6
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001728 RID: 5928
		private bool dll_Excuted;

		// Token: 0x04001729 RID: 5929
		private bool dll_Excuted;
	}
}
