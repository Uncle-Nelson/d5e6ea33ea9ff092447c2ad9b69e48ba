using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200049C RID: 1180
	public class Austin : NPC
	{
		// Token: 0x06001A26 RID: 6694 RVA: 0x00070C0F File Offset: 0x0006EE0F
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.AustinAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.AustinAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00070C28 File Offset: 0x0006EE28
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.AustinAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.AustinAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00070C41 File Offset: 0x0006EE41
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00070C4F File Offset: 0x0006EE4F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001668 RID: 5736
		private bool dll_Excuted;

		// Token: 0x04001669 RID: 5737
		private bool dll_Excuted;
	}
}
