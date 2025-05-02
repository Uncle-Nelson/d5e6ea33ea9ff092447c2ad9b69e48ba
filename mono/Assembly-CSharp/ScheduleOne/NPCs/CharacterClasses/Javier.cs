using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004B4 RID: 1204
	public class Javier : NPC
	{
		// Token: 0x06001AAC RID: 6828 RVA: 0x00071713 File Offset: 0x0006F913
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JavierAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JavierAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0007172C File Offset: 0x0006F92C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JavierAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JavierAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00071745 File Offset: 0x0006F945
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00071753 File Offset: 0x0006F953
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016A5 RID: 5797
		private bool dll_Excuted;

		// Token: 0x040016A6 RID: 5798
		private bool dll_Excuted;
	}
}
