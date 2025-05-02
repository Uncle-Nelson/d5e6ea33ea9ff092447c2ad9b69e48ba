using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C8 RID: 1224
	public class Mac : NPC
	{
		// Token: 0x06001B15 RID: 6933 RVA: 0x00071EDD File Offset: 0x000700DD
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MacAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MacAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x00071EF6 File Offset: 0x000700F6
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MacAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MacAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00071F0F File Offset: 0x0007010F
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00071F1D File Offset: 0x0007011D
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016D3 RID: 5843
		private bool dll_Excuted;

		// Token: 0x040016D4 RID: 5844
		private bool dll_Excuted;
	}
}
