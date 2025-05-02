using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004B7 RID: 1207
	public class Jennifer : NPC
	{
		// Token: 0x06001ABB RID: 6843 RVA: 0x0007180F File Offset: 0x0006FA0F
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JenniferAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JenniferAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00071828 File Offset: 0x0006FA28
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JenniferAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JenniferAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00071841 File Offset: 0x0006FA41
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0007184F File Offset: 0x0006FA4F
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016AB RID: 5803
		private bool dll_Excuted;

		// Token: 0x040016AC RID: 5804
		private bool dll_Excuted;
	}
}
