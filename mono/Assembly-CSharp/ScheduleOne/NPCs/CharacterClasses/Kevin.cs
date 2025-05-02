using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004BF RID: 1215
	public class Kevin : NPC
	{
		// Token: 0x06001AE5 RID: 6885 RVA: 0x00071B9B File Offset: 0x0006FD9B
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KevinAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.KevinAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00071BB4 File Offset: 0x0006FDB4
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KevinAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.KevinAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00071BCD File Offset: 0x0006FDCD
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00071BDB File Offset: 0x0006FDDB
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016BE RID: 5822
		private bool dll_Excuted;

		// Token: 0x040016BF RID: 5823
		private bool dll_Excuted;
	}
}
