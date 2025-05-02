using System;
using ScheduleOne.Economy;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004E0 RID: 1248
	public class Wei : Dealer
	{
		// Token: 0x06001BBB RID: 7099 RVA: 0x000731D4 File Offset: 0x000713D4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.WeiAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.WeiAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000731ED File Offset: 0x000713ED
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.WeiAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.WeiAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00073206 File Offset: 0x00071406
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00073214 File Offset: 0x00071414
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001721 RID: 5921
		private bool dll_Excuted;

		// Token: 0x04001722 RID: 5922
		private bool dll_Excuted;
	}
}
