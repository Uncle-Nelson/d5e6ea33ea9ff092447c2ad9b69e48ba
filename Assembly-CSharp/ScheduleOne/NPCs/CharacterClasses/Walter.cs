using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004DF RID: 1247
	public class Walter : NPC
	{
		// Token: 0x06001BB6 RID: 7094 RVA: 0x00073180 File Offset: 0x00071380
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.WalterAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.WalterAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00073199 File Offset: 0x00071399
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.WalterAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.WalterAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x000731B2 File Offset: 0x000713B2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000731C0 File Offset: 0x000713C0
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400171F RID: 5919
		private bool dll_Excuted;

		// Token: 0x04001720 RID: 5920
		private bool dll_Excuted;
	}
}
