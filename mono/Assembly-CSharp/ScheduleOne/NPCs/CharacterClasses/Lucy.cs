using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C6 RID: 1222
	public class Lucy : NPC
	{
		// Token: 0x06001B0B RID: 6923 RVA: 0x00071E35 File Offset: 0x00070035
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LucyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LucyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00071E4E File Offset: 0x0007004E
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LucyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LucyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00071E67 File Offset: 0x00070067
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00071E75 File Offset: 0x00070075
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016CF RID: 5839
		private bool dll_Excuted;

		// Token: 0x040016D0 RID: 5840
		private bool dll_Excuted;
	}
}
