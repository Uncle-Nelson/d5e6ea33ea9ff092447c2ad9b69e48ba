using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C5 RID: 1221
	public class Louis : NPC
	{
		// Token: 0x06001B06 RID: 6918 RVA: 0x00071DE1 File Offset: 0x0006FFE1
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LouisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LouisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00071DFA File Offset: 0x0006FFFA
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LouisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LouisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00071E13 File Offset: 0x00070013
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00071E21 File Offset: 0x00070021
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016CD RID: 5837
		private bool dll_Excuted;

		// Token: 0x040016CE RID: 5838
		private bool dll_Excuted;
	}
}
