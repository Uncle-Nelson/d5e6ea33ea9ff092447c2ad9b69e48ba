using System;
using System.Collections.Generic;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000694 RID: 1684
	public class ControlledDialogueHandler : DialogueHandler
	{
		// Token: 0x06002EAB RID: 11947 RVA: 0x000C3834 File Offset: 0x000C1A34
		protected override void Awake()
		{
			base.Awake();
			this.controller = base.GetComponent<DialogueController>();
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x000C3848 File Offset: 0x000C1A48
		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			dialogueText = this.controller.ModifyDialogueText(dialogueLabel, dialogueText);
			return base.ModifyDialogueText(dialogueLabel, dialogueText);
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x000C3861 File Offset: 0x000C1A61
		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			choiceText = this.controller.ModifyChoiceText(choiceLabel, choiceText);
			return base.ModifyChoiceText(choiceLabel, choiceText);
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x000C387A File Offset: 0x000C1A7A
		protected override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			this.controller.ModifyChoiceList(dialogueLabel, ref existingChoices);
			base.ModifyChoiceList(dialogueLabel, ref existingChoices);
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x000C3891 File Offset: 0x000C1A91
		protected override void ChoiceCallback(string choiceLabel)
		{
			this.controller.ChoiceCallback(choiceLabel);
			base.ChoiceCallback(choiceLabel);
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x000C38A8 File Offset: 0x000C1AA8
		protected override int CheckBranch(string branchLabel)
		{
			int result;
			if (this.controller.DecideBranch(branchLabel, out result))
			{
				return result;
			}
			return base.CheckBranch(branchLabel);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x000C38CE File Offset: 0x000C1ACE
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return this.controller.CheckChoice(choiceLabel, out invalidReason) && base.CheckChoice(choiceLabel, out invalidReason);
		}

		// Token: 0x04002127 RID: 8487
		private DialogueController controller;
	}
}
