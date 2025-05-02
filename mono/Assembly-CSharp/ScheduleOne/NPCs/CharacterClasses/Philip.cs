using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004D5 RID: 1237
	public class Philip : NPC
	{
		// Token: 0x06001B6A RID: 7018 RVA: 0x000727C6 File Offset: 0x000709C6
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.PhilipAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.PhilipAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x000727DF File Offset: 0x000709DF
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.PhilipAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.PhilipAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x000727F8 File Offset: 0x000709F8
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x00072806 File Offset: 0x00070A06
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016F8 RID: 5880
		private bool dll_Excuted;

		// Token: 0x040016F9 RID: 5881
		private bool dll_Excuted;
	}
}
