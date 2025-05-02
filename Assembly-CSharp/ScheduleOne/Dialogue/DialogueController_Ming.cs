using System;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006A2 RID: 1698
	public class DialogueController_Ming : DialogueController
	{
		// Token: 0x06002EF7 RID: 12023 RVA: 0x000C4A70 File Offset: 0x000C2C70
		protected override void Start()
		{
			base.Start();
			DialogueController.DialogueChoice dialogueChoice = new DialogueController.DialogueChoice();
			dialogueChoice.ChoiceText = this.BuyText;
			dialogueChoice.Conversation = this.BuyDialogue;
			dialogueChoice.Enabled = true;
			dialogueChoice.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.CanBuyRoom);
			DialogueController.DialogueChoice dialogueChoice2 = new DialogueController.DialogueChoice();
			dialogueChoice2.ChoiceText = this.RemindText;
			dialogueChoice2.Conversation = this.RemindLocationDialogue;
			dialogueChoice2.Enabled = true;
			dialogueChoice2.shouldShowCheck = ((bool enabled) => this.Property.IsOwned);
			this.AddDialogueChoice(dialogueChoice, 0);
			this.AddDialogueChoice(dialogueChoice2, 0);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x000C4B04 File Offset: 0x000C2D04
		private bool CanBuyRoom(bool enabled)
		{
			if (this.Property.IsOwned)
			{
				return false;
			}
			if (this.PurchaseRoomQuests.Length != 0)
			{
				return this.PurchaseRoomQuests.FirstOrDefault((QuestEntry q) => q.State == EQuestState.Active) != null;
			}
			return true;
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000C4B5B File Offset: 0x000C2D5B
		public override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			if (choiceLabel == "CHOICE_CONFIRM")
			{
				choiceText = choiceText.Replace("<PRICE>", "<color=#54E717>(" + MoneyManager.FormatAmount(this.Price, false, false) + ")</color>");
			}
			return base.ModifyChoiceText(choiceLabel, choiceText);
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000C4B9B File Offset: 0x000C2D9B
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			if (dialogueLabel == "ENTRY")
			{
				dialogueText = dialogueText.Replace("<PRICE>", "<color=#54E717>" + MoneyManager.FormatAmount(this.Price, false, false) + "</color>");
			}
			return base.ModifyDialogueText(dialogueLabel, dialogueText);
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000C4BDB File Offset: 0x000C2DDB
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			if (choiceLabel == "CHOICE_CONFIRM" && NetworkSingleton<MoneyManager>.Instance.cashBalance < this.Price)
			{
				invalidReason = "Insufficient cash";
				return false;
			}
			return base.CheckChoice(choiceLabel, out invalidReason);
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x000C4C10 File Offset: 0x000C2E10
		public override void ChoiceCallback(string choiceLabel)
		{
			if (choiceLabel == "CHOICE_CONFIRM")
			{
				NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.Price, true, false);
				this.npc.Inventory.InsertItem(NetworkSingleton<MoneyManager>.Instance.GetCashInstance(this.Price), true);
				this.Property.SetOwned();
				if (this.onPurchase != null)
				{
					this.onPurchase.Invoke();
				}
			}
			base.ChoiceCallback(choiceLabel);
		}

		// Token: 0x04002154 RID: 8532
		public Property Property;

		// Token: 0x04002155 RID: 8533
		public float Price = 500f;

		// Token: 0x04002156 RID: 8534
		public DialogueContainer BuyDialogue;

		// Token: 0x04002157 RID: 8535
		public string BuyText = "I'd like to buy the room";

		// Token: 0x04002158 RID: 8536
		public string RemindText = "Where is my room?";

		// Token: 0x04002159 RID: 8537
		public DialogueContainer RemindLocationDialogue;

		// Token: 0x0400215A RID: 8538
		public QuestEntry[] PurchaseRoomQuests;

		// Token: 0x0400215B RID: 8539
		public UnityEvent onPurchase;
	}
}
