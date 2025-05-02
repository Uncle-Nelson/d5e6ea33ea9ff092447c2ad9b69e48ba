using System;

namespace ScheduleOne.Storage
{
	// Token: 0x020008A0 RID: 2208
	public class DisposalStorageEntity : StorageEntity
	{
		// Token: 0x06003B9C RID: 15260 RVA: 0x000FAC5A File Offset: 0x000F8E5A
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Storage.DisposalStorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Storage.DisposalStorageEntityAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x000FAC73 File Offset: 0x000F8E73
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Storage.DisposalStorageEntityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Storage.DisposalStorageEntityAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x000FAC8C File Offset: 0x000F8E8C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x000FAC9A File Offset: 0x000F8E9A
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002B32 RID: 11058
		private bool dll_Excuted;

		// Token: 0x04002B33 RID: 11059
		private bool dll_Excuted;
	}
}
