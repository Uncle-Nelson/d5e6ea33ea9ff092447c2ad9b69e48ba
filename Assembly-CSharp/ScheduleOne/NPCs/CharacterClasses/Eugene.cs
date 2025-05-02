using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A6 RID: 1190
	public class Eugene : NPC
	{
		// Token: 0x06001A5C RID: 6748 RVA: 0x00071031 File Offset: 0x0006F231
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.EugeneAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.EugeneAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0007104A File Offset: 0x0006F24A
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.EugeneAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.EugeneAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00071063 File Offset: 0x0006F263
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00071071 File Offset: 0x0006F271
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400167F RID: 5759
		private bool dll_Excuted;

		// Token: 0x04001680 RID: 5760
		private bool dll_Excuted;
	}
}
