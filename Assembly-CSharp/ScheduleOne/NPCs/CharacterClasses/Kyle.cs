using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C1 RID: 1217
	public class Kyle : NPC
	{
		// Token: 0x06001AEF RID: 6895 RVA: 0x00071C43 File Offset: 0x0006FE43
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KyleAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KyleAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00071C5C File Offset: 0x0006FE5C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KyleAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KyleAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00071C75 File Offset: 0x0006FE75
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00071C83 File Offset: 0x0006FE83
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016C2 RID: 5826
		private bool dll_Excuted;

		// Token: 0x040016C3 RID: 5827
		private bool dll_Excuted;
	}
}
