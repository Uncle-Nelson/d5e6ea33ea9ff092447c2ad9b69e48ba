using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C4 RID: 1220
	public class Lisa : NPC
	{
		// Token: 0x06001B01 RID: 6913 RVA: 0x00071D8D File Offset: 0x0006FF8D
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LisaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.LisaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00071DA6 File Offset: 0x0006FFA6
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LisaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.LisaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00071DBF File Offset: 0x0006FFBF
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00071DCD File Offset: 0x0006FFCD
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016CB RID: 5835
		private bool dll_Excuted;

		// Token: 0x040016CC RID: 5836
		private bool dll_Excuted;
	}
}
