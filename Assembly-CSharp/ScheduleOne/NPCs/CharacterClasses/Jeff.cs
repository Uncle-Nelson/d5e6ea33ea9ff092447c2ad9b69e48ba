using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004B5 RID: 1205
	public class Jeff : NPC
	{
		// Token: 0x06001AB1 RID: 6833 RVA: 0x00071767 File Offset: 0x0006F967
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JeffAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JeffAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00071780 File Offset: 0x0006F980
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JeffAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JeffAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00071799 File Offset: 0x0006F999
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000717A7 File Offset: 0x0006F9A7
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016A7 RID: 5799
		private bool dll_Excuted;

		// Token: 0x040016A8 RID: 5800
		private bool dll_Excuted;
	}
}
