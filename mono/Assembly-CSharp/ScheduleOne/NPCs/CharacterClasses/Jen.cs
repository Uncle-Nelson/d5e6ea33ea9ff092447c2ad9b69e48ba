using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004B6 RID: 1206
	public class Jen : NPC
	{
		// Token: 0x06001AB6 RID: 6838 RVA: 0x000717BB File Offset: 0x0006F9BB
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JenAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JenAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000717D4 File Offset: 0x0006F9D4
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JenAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JenAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x000717ED File Offset: 0x0006F9ED
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000717FB File Offset: 0x0006F9FB
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016A9 RID: 5801
		private bool dll_Excuted;

		// Token: 0x040016AA RID: 5802
		private bool dll_Excuted;
	}
}
