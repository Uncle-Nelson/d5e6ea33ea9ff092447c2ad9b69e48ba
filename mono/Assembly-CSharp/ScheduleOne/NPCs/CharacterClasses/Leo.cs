using System;
using ScheduleOne.Economy;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C2 RID: 1218
	public class Leo : Dealer
	{
		// Token: 0x06001AF4 RID: 6900 RVA: 0x00071C97 File Offset: 0x0006FE97
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LeoAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LeoAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00071CB0 File Offset: 0x0006FEB0
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LeoAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LeoAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00071CC9 File Offset: 0x0006FEC9
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00071CD7 File Offset: 0x0006FED7
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016C4 RID: 5828
		private bool dll_Excuted;

		// Token: 0x040016C5 RID: 5829
		private bool dll_Excuted;
	}
}
