using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004BB RID: 1211
	public class Joyce : NPC
	{
		// Token: 0x06001AD1 RID: 6865 RVA: 0x00071A4B File Offset: 0x0006FC4B
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JoyceAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JoyceAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00071A64 File Offset: 0x0006FC64
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JoyceAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JoyceAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00071A7D File Offset: 0x0006FC7D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00071A8B File Offset: 0x0006FC8B
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016B6 RID: 5814
		private bool dll_Excuted;

		// Token: 0x040016B7 RID: 5815
		private bool dll_Excuted;
	}
}
