using System;

namespace ScheduleOne.ConstructableScripts
{
	// Token: 0x0200092D RID: 2349
	public class EmployeeTrailer : Constructable_GridBased
	{
		// Token: 0x06003F90 RID: 16272 RVA: 0x0010C476 File Offset: 0x0010A676
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ConstructableScripts.EmployeeTrailerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ConstructableScripts.EmployeeTrailerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x0010C48F File Offset: 0x0010A68F
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ConstructableScripts.EmployeeTrailerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ConstructableScripts.EmployeeTrailerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x0010C4A8 File Offset: 0x0010A6A8
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0010C4B6 File Offset: 0x0010A6B6
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002DB9 RID: 11705
		private bool dll_Excuted;

		// Token: 0x04002DBA RID: 11706
		private bool dll_Excuted;
	}
}
