using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004B1 RID: 1201
	public class Jack : NPC
	{
		// Token: 0x06001A9D RID: 6813 RVA: 0x00071617 File Offset: 0x0006F817
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JackAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JackAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00071630 File Offset: 0x0006F830
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JackAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JackAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00071649 File Offset: 0x0006F849
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00071657 File Offset: 0x0006F857
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400169F RID: 5791
		private bool dll_Excuted;

		// Token: 0x040016A0 RID: 5792
		private bool dll_Excuted;
	}
}
