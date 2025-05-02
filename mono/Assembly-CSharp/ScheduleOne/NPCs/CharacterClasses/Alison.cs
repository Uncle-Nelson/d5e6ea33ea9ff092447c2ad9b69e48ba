using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200049A RID: 1178
	public class Alison : NPC
	{
		// Token: 0x06001A1A RID: 6682 RVA: 0x00070B2E File Offset: 0x0006ED2E
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.AlisonAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.AlisonAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00070B47 File Offset: 0x0006ED47
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.AlisonAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.AlisonAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00070B60 File Offset: 0x0006ED60
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00070B6E File Offset: 0x0006ED6E
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001664 RID: 5732
		private bool dll_Excuted;

		// Token: 0x04001665 RID: 5733
		private bool dll_Excuted;
	}
}
