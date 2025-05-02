using System;
using ScheduleOne.Economy;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200049E RID: 1182
	public class Brad : Dealer
	{
		// Token: 0x06001A30 RID: 6704 RVA: 0x00070CBF File Offset: 0x0006EEBF
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.BradAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.BradAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00070CD8 File Offset: 0x0006EED8
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.BradAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.BradAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00070CF1 File Offset: 0x0006EEF1
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00070CFF File Offset: 0x0006EEFF
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400166C RID: 5740
		private bool dll_Excuted;

		// Token: 0x0400166D RID: 5741
		private bool dll_Excuted;
	}
}
