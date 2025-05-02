using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004BC RID: 1212
	public class Karen : NPC
	{
		// Token: 0x06001AD6 RID: 6870 RVA: 0x00071A9F File Offset: 0x0006FC9F
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KarenAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KarenAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00071AB8 File Offset: 0x0006FCB8
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KarenAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KarenAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00071AD1 File Offset: 0x0006FCD1
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00071ADF File Offset: 0x0006FCDF
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016B8 RID: 5816
		private bool dll_Excuted;

		// Token: 0x040016B9 RID: 5817
		private bool dll_Excuted;
	}
}
