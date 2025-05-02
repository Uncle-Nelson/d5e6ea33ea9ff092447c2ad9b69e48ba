using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Money;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006A0 RID: 1696
	public class DialogueController_Dealer : DialogueController
	{
		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x000C4485 File Offset: 0x000C2685
		// (set) Token: 0x06002EE9 RID: 12009 RVA: 0x000C448D File Offset: 0x000C268D
		public Dealer Dealer { get; private set; }

		// Token: 0x06002EEA RID: 12010 RVA: 0x000C4496 File Offset: 0x000C2696
		protected override void Start()
		{
			base.Start();
			this.Dealer = (this.npc as Dealer);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x000C44B0 File Offset: 0x000C26B0
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			if (DialogueHandler.activeDialogue.name == "Supplier_Recruitment" && dialogueLabel == "ENTRY")
			{
				dialogueText = dialogueText.Replace("<SIGNING_FEE>", "<color=#54E717>" + MoneyManager.FormatAmount(this.Dealer.SigningFee, false, false) + "</color>");
				dialogueText = dialogueText.Replace("<CUT>", "<color=#54E717>" + Mathf.RoundToInt(this.Dealer.Cut * 100f).ToString() + "%</color>");
			}
			return base.ModifyDialogueText(dialogueLabel, dialogueText);
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x000C4550 File Offset: 0x000C2750
		public override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			if (DialogueHandler.activeDialogue.name == "Supplier_Recruitment" && choiceLabel == "CONFIRM")
			{
				choiceText = choiceText.Replace("<SIGNING_FEE>", "<color=#54E717>" + MoneyManager.FormatAmount(this.Dealer.SigningFee, false, false) + "</color>");
			}
			return base.ModifyChoiceText(choiceLabel, choiceText);
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x000C45B8 File Offset: 0x000C27B8
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			if (DialogueHandler.activeDialogue.name == "Supplier_Recruitment" && choiceLabel == "CONFIRM" && NetworkSingleton<MoneyManager>.Instance.cashBalance < this.Dealer.SigningFee)
			{
				invalidReason = "Insufficient cash";
				return false;
			}
			return base.CheckChoice(choiceLabel, out invalidReason);
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x000C4610 File Offset: 0x000C2810
		public override void ChoiceCallback(string choiceLabel)
		{
			if (DialogueHandler.activeDialogue.name == "Supplier_Recruitment" && choiceLabel == "CONFIRM")
			{
				NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.Dealer.SigningFee, true, false);
				this.Dealer.InitialRecruitment();
			}
			base.ChoiceCallback(choiceLabel);
		}
	}
}
