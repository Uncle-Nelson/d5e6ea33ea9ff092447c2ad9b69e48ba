using System;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004D6 RID: 1238
	public class Randy : NPC
	{
		// Token: 0x06001B6F RID: 7023 RVA: 0x0007281A File Offset: 0x00070A1A
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.RandyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.RandyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00072833 File Offset: 0x00070A33
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.RandyAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.RandyAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0007284C File Offset: 0x00070A4C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0007285A File Offset: 0x00070A5A
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x040016FA RID: 5882
		private bool dll_Excuted;

		// Token: 0x040016FB RID: 5883
		private bool dll_Excuted;
	}
}
