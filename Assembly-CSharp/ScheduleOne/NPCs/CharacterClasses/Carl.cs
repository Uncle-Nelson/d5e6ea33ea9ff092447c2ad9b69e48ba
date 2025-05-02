using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200049F RID: 1183
	public class Carl : NPC
	{
		// Token: 0x06001A35 RID: 6709 RVA: 0x00070D13 File Offset: 0x0006EF13
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.CarlAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.CarlAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00070D2C File Offset: 0x0006EF2C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.CarlAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.CarlAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00070D45 File Offset: 0x0006EF45
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00070D53 File Offset: 0x0006EF53
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400166E RID: 5742
		private bool dll_Excuted;

		// Token: 0x0400166F RID: 5743
		private bool dll_Excuted;
	}
}
