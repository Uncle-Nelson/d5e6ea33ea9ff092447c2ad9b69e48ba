using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004D3 RID: 1235
	public class Peggy : NPC
	{
		// Token: 0x06001B60 RID: 7008 RVA: 0x0007271E File Offset: 0x0007091E
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.PeggyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.PeggyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00072737 File Offset: 0x00070937
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.PeggyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.PeggyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00072750 File Offset: 0x00070950
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0007275E File Offset: 0x0007095E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016F4 RID: 5876
		private bool dll_Excuted;

		// Token: 0x040016F5 RID: 5877
		private bool dll_Excuted;
	}
}
