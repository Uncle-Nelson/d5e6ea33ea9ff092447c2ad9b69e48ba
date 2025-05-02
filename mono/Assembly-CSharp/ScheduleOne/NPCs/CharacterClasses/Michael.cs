using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004CB RID: 1227
	public class Michael : NPC
	{
		// Token: 0x06001B2F RID: 6959 RVA: 0x000722CF File Offset: 0x000704CF
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MichaelAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MichaelAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x000722E8 File Offset: 0x000704E8
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MichaelAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MichaelAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00072301 File Offset: 0x00070501
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0007230F File Offset: 0x0007050F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016DE RID: 5854
		private bool dll_Excuted;

		// Token: 0x040016DF RID: 5855
		private bool dll_Excuted;
	}
}
