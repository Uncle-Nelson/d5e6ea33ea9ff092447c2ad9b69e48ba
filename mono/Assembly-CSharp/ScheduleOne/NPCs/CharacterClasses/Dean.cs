using System;
using ScheduleOne.Dialogue;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004A3 RID: 1187
	public class Dean : NPC
	{
		// Token: 0x06001A4A RID: 6730 RVA: 0x00070F06 File Offset: 0x0006F106
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.Dean_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00070B96 File Offset: 0x0006ED96
		public bool TattooChoiceValid(out string reason)
		{
			reason = string.Empty;
			return true;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00070F1A File Offset: 0x0006F11A
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.DeanAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.DeanAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00070F33 File Offset: 0x0006F133
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.DeanAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.DeanAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00070F4C File Offset: 0x0006F14C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00070F5A File Offset: 0x0006F15A
		protected virtual void dll()
		{
			base.Awake();
			this.dialogueHandler.GetComponent<DialogueController>().Choices[0].isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.TattooChoiceValid);
		}

		// Token: 0x04001679 RID: 5753
		private bool dll_Excuted;

		// Token: 0x0400167A RID: 5754
		private bool dll_Excuted;
	}
}
