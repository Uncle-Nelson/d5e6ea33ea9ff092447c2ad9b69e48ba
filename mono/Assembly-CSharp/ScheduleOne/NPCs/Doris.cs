using System;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200044F RID: 1103
	public class Doris : NPC
	{
		// Token: 0x060015F0 RID: 5616 RVA: 0x00060EA3 File Offset: 0x0005F0A3
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.DorisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.DorisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00060EBC File Offset: 0x0005F0BC
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.DorisAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.DorisAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00060ED5 File Offset: 0x0005F0D5
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00060EE3 File Offset: 0x0005F0E3
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400148C RID: 5260
		private bool dll_Excuted;

		// Token: 0x0400148D RID: 5261
		private bool dll_Excuted;
	}
}
