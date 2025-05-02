using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004D8 RID: 1240
	public class Sam : NPC
	{
		// Token: 0x06001B7D RID: 7037 RVA: 0x000729D5 File Offset: 0x00070BD5
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SamAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SamAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x000729EE File Offset: 0x00070BEE
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SamAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SamAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00072A07 File Offset: 0x00070C07
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00072A15 File Offset: 0x00070C15
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001705 RID: 5893
		private bool dll_Excuted;

		// Token: 0x04001706 RID: 5894
		private bool dll_Excuted;
	}
}
