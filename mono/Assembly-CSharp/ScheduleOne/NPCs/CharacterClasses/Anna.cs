using System;
using ScheduleOne.Dialogue;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200049B RID: 1179
	public class Anna : NPC
	{
		// Token: 0x06001A1E RID: 6686 RVA: 0x00070B82 File Offset: 0x0006ED82
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.Anna_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00070B96 File Offset: 0x0006ED96
		public bool HairCutChoiceValid(out string reason)
		{
			reason = string.Empty;
			return true;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00070BA0 File Offset: 0x0006EDA0
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.AnnaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.AnnaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00070BB9 File Offset: 0x0006EDB9
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.AnnaAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.AnnaAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00070BD2 File Offset: 0x0006EDD2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00070BE0 File Offset: 0x0006EDE0
		protected virtual void dll()
		{
			base.Awake();
			this.dialogueHandler.GetComponent<DialogueController>().Choices[0].isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.HairCutChoiceValid);
		}

		// Token: 0x04001666 RID: 5734
		private bool dll_Excuted;

		// Token: 0x04001667 RID: 5735
		private bool dll_Excuted;
	}
}
