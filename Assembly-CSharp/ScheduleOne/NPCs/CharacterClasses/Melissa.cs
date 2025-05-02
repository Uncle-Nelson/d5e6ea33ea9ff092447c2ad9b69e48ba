using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004CA RID: 1226
	public class Melissa : NPC
	{
		// Token: 0x06001B2A RID: 6954 RVA: 0x0007227B File Offset: 0x0007047B
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MelissaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MelissaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00072294 File Offset: 0x00070494
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MelissaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MelissaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000722AD File Offset: 0x000704AD
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x000722BB File Offset: 0x000704BB
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016DC RID: 5852
		private bool dll_Excuted;

		// Token: 0x040016DD RID: 5853
		private bool dll_Excuted;
	}
}
