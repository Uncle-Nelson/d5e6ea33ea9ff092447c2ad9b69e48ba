using System;
using ScheduleOne.Economy;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004B3 RID: 1203
	public class Jane : Dealer
	{
		// Token: 0x06001AA7 RID: 6823 RVA: 0x000716BF File Offset: 0x0006F8BF
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JaneAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JaneAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x000716D8 File Offset: 0x0006F8D8
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JaneAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JaneAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x000716F1 File Offset: 0x0006F8F1
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x000716FF File Offset: 0x0006F8FF
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016A3 RID: 5795
		private bool dll_Excuted;

		// Token: 0x040016A4 RID: 5796
		private bool dll_Excuted;
	}
}
