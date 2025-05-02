using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006A5 RID: 1701
	public class DialogueController_SkateboardSeller : DialogueController
	{
		// Token: 0x06002F05 RID: 12037 RVA: 0x000045B1 File Offset: 0x000027B1
		private void Awake()
		{
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x000C4D58 File Offset: 0x000C2F58
		public override void ChoiceCallback(string choiceLabel)
		{
			DialogueController_SkateboardSeller.Option option = this.Options.Find((DialogueController_SkateboardSeller.Option x) => x.Name == choiceLabel);
			if (option != null)
			{
				this.chosenWeapon = option;
				this.handler.ShowNode(DialogueHandler.activeDialogue.GetDialogueNodeByLabel("FINALIZE"));
			}
			if (choiceLabel == "CONFIRM" && this.chosenWeapon != null)
			{
				NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.chosenWeapon.Price, true, false);
				PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.chosenWeapon.Item.GetDefaultInstance(1));
				this.npc.Inventory.InsertItem(NetworkSingleton<MoneyManager>.Instance.GetCashInstance(this.chosenWeapon.Price), true);
				if (this.chosenWeapon.Item.ID == "goldenskateboard")
				{
					Singleton<AchievementManager>.Instance.UnlockAchievement(AchievementManager.EAchievement.ROLLING_IN_STYLE);
				}
				if (this.onPurchase != null)
				{
					this.onPurchase.Invoke();
				}
			}
			base.ChoiceCallback(choiceLabel);
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x000C4E6D File Offset: 0x000C306D
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			if (dialogueLabel == "ENTRY" && DialogueHandler.activeDialogue.name == "Skateboard_Sell")
			{
				existingChoices.AddRange(this.GetChoices(this.Options));
			}
			base.ModifyChoiceList(dialogueLabel, ref existingChoices);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000C4EB0 File Offset: 0x000C30B0
		private List<DialogueChoiceData> GetChoices(List<DialogueController_SkateboardSeller.Option> options)
		{
			List<DialogueChoiceData> list = new List<DialogueChoiceData>();
			foreach (DialogueController_SkateboardSeller.Option option in options)
			{
				list.Add(new DialogueChoiceData
				{
					ChoiceText = option.Name + "<color=#54E717> (" + MoneyManager.FormatAmount(option.Price, false, false) + ")</color>",
					ChoiceLabel = option.Name
				});
			}
			return list;
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x000C4F40 File Offset: 0x000C3140
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			DialogueController_SkateboardSeller.Option option = this.Options.Find((DialogueController_SkateboardSeller.Option x) => x.Name == choiceLabel);
			if (option != null)
			{
				if (!option.IsAvailable)
				{
					invalidReason = option.NotAvailableReason;
					return false;
				}
				if (NetworkSingleton<MoneyManager>.Instance.cashBalance < option.Price)
				{
					invalidReason = "Insufficient cash";
					return false;
				}
			}
			if (choiceLabel == "CONFIRM" && !PlayerSingleton<PlayerInventory>.Instance.CanItemFitInInventory(this.chosenWeapon.Item.GetDefaultInstance(1), 1))
			{
				invalidReason = "Inventory full";
				return false;
			}
			return base.CheckChoice(choiceLabel, out invalidReason);
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x000C4FE8 File Offset: 0x000C31E8
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			if (dialogueLabel == "FINALIZE" && this.chosenWeapon != null)
			{
				dialogueText = dialogueText.Replace("<NAME>", this.chosenWeapon.Name);
				dialogueText = dialogueText.Replace("<PRICE>", "<color=#54E717>" + MoneyManager.FormatAmount(this.chosenWeapon.Price, false, false) + "</color>");
			}
			return base.ModifyDialogueText(dialogueLabel, dialogueText);
		}

		// Token: 0x0400215F RID: 8543
		public List<DialogueController_SkateboardSeller.Option> Options = new List<DialogueController_SkateboardSeller.Option>();

		// Token: 0x04002160 RID: 8544
		private DialogueController_SkateboardSeller.Option chosenWeapon;

		// Token: 0x04002161 RID: 8545
		public UnityEvent onPurchase;

		// Token: 0x020006A6 RID: 1702
		[Serializable]
		public class Option
		{
			// Token: 0x04002162 RID: 8546
			public string Name;

			// Token: 0x04002163 RID: 8547
			public float Price;

			// Token: 0x04002164 RID: 8548
			public bool IsAvailable;

			// Token: 0x04002165 RID: 8549
			public string NotAvailableReason;

			// Token: 0x04002166 RID: 8550
			public ItemDefinition Item;
		}
	}
}
