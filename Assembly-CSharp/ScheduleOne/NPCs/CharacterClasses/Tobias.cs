using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004DC RID: 1244
	public class Tobias : NPC
	{
		// Token: 0x06001BA6 RID: 7078 RVA: 0x00072FEC File Offset: 0x000711EC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.TobiasAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.TobiasAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00073005 File Offset: 0x00071205
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.TobiasAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.TobiasAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0007301E File Offset: 0x0007121E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0007302C File Offset: 0x0007122C
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001717 RID: 5911
		private bool dll_Excuted;

		// Token: 0x04001718 RID: 5912
		private bool dll_Excuted;
	}
}
