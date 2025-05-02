using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004AA RID: 1194
	public class Genghis : NPC
	{
		// Token: 0x06001A78 RID: 6776 RVA: 0x00071350 File Offset: 0x0006F550
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.GenghisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.GenghisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00071369 File Offset: 0x0006F569
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.GenghisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.GenghisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00071382 File Offset: 0x0006F582
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00071390 File Offset: 0x0006F590
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400168F RID: 5775
		private bool dll_Excuted;

		// Token: 0x04001690 RID: 5776
		private bool dll_Excuted;
	}
}
