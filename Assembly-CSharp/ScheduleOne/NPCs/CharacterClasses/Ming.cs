using System;
using ScheduleOne.Property;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004CD RID: 1229
	public class Ming : NPC
	{
		// Token: 0x06001B3A RID: 6970 RVA: 0x000611D3 File Offset: 0x0005F3D3
		public override string GetNameAddress()
		{
			return base.fullName;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000723CA File Offset: 0x000705CA
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MingAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MingAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000723E3 File Offset: 0x000705E3
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MingAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MingAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000723FC File Offset: 0x000705FC
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0007240A File Offset: 0x0007060A
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016E2 RID: 5858
		public Property Property;

		// Token: 0x040016E3 RID: 5859
		private bool dll_Excuted;

		// Token: 0x040016E4 RID: 5860
		private bool dll_Excuted;
	}
}
