using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A0 RID: 1184
	public class Charles : NPC
	{
		// Token: 0x06001A3A RID: 6714 RVA: 0x00070D67 File Offset: 0x0006EF67
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.CharlesAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.CharlesAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00070D80 File Offset: 0x0006EF80
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.CharlesAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.CharlesAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00070D99 File Offset: 0x0006EF99
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00070DA7 File Offset: 0x0006EFA7
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001670 RID: 5744
		private bool dll_Excuted;

		// Token: 0x04001671 RID: 5745
		private bool dll_Excuted;
	}
}
