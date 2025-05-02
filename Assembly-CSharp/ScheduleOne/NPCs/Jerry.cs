using System;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000450 RID: 1104
	public class Jerry : NPC
	{
		// Token: 0x060015F5 RID: 5621 RVA: 0x00060EF7 File Offset: 0x0005F0F7
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.JerryAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.JerryAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00060F10 File Offset: 0x0005F110
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.JerryAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.JerryAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00060F29 File Offset: 0x0005F129
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00060F37 File Offset: 0x0005F137
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0400148E RID: 5262
		private bool dll_Excuted;

		// Token: 0x0400148F RID: 5263
		private bool dll_Excuted;
	}
}
