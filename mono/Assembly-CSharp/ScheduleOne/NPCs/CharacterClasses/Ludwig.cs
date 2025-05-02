using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C7 RID: 1223
	public class Ludwig : NPC
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x00071E89 File Offset: 0x00070089
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LudwigAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LudwigAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00071EA2 File Offset: 0x000700A2
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LudwigAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LudwigAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00071EBB File Offset: 0x000700BB
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00071EC9 File Offset: 0x000700C9
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016D1 RID: 5841
		private bool dll_Excuted;

		// Token: 0x040016D2 RID: 5842
		private bool dll_Excuted;
	}
}
