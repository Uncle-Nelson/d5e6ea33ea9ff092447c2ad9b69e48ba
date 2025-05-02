using System;
using ScheduleOne.Economy;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004E2 RID: 1250
	public class Albert : Supplier
	{
		// Token: 0x06001BCA RID: 7114 RVA: 0x00073422 File Offset: 0x00071622
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.AlbertAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.AlbertAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0007343B File Offset: 0x0007163B
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.AlbertAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.AlbertAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00073454 File Offset: 0x00071654
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00073462 File Offset: 0x00071662
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001726 RID: 5926
		private bool dll_Excuted;

		// Token: 0x04001727 RID: 5927
		private bool dll_Excuted;
	}
}
