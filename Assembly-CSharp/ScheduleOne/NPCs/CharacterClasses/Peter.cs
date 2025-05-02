using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004D4 RID: 1236
	public class Peter : NPC
	{
		// Token: 0x06001B65 RID: 7013 RVA: 0x00072772 File Offset: 0x00070972
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.PeterAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.PeterAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0007278B File Offset: 0x0007098B
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.PeterAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.PeterAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x000727A4 File Offset: 0x000709A4
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000727B2 File Offset: 0x000709B2
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016F6 RID: 5878
		private bool dll_Excuted;

		// Token: 0x040016F7 RID: 5879
		private bool dll_Excuted;
	}
}
