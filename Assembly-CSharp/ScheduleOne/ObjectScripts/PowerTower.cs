using System;
using ScheduleOne.ConstructableScripts;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BF2 RID: 3058
	public class PowerTower : Constructable_GridBased
	{
		// Token: 0x060055F4 RID: 22004 RVA: 0x00169D9E File Offset: 0x00167F9E
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.PowerTowerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.PowerTowerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x00169DB7 File Offset: 0x00167FB7
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.PowerTowerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.PowerTowerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x00169DD0 File Offset: 0x00167FD0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060055F7 RID: 22007 RVA: 0x00169DDE File Offset: 0x00167FDE
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003F94 RID: 16276
		private bool dll_Excuted;

		// Token: 0x04003F95 RID: 16277
		private bool dll_Excuted;
	}
}
