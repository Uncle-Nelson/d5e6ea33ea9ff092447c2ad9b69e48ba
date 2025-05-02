using System;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000451 RID: 1105
	public class Meg : NPC
	{
		// Token: 0x060015FA RID: 5626 RVA: 0x00060F4B File Offset: 0x0005F14B
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.MegAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.MegAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00060F64 File Offset: 0x0005F164
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.MegAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.MegAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00060F7D File Offset: 0x0005F17D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00060F8B File Offset: 0x0005F18B
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001490 RID: 5264
		private bool dll_Excuted;

		// Token: 0x04001491 RID: 5265
		private bool dll_Excuted;
	}
}
