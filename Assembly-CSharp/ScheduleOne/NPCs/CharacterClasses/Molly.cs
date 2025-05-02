using System;
using ScheduleOne.Economy;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004CE RID: 1230
	public class Molly : Dealer
	{
		// Token: 0x06001B41 RID: 6977 RVA: 0x0007241E File Offset: 0x0007061E
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MollyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MollyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00072437 File Offset: 0x00070637
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MollyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MollyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00072450 File Offset: 0x00070650
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0007245E File Offset: 0x0007065E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016E5 RID: 5861
		private bool dll_Excuted;

		// Token: 0x040016E6 RID: 5862
		private bool dll_Excuted;
	}
}
