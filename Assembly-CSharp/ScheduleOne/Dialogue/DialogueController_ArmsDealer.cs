using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Levelling;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200069B RID: 1691
	public class DialogueController_ArmsDealer : DialogueController
	{
		// Token: 0x06002ED9 RID: 11993 RVA: 0x000C409A File Offset: 0x000C229A
		private void Awake()
		{
			this.allWeapons = new List<DialogueController_ArmsDealer.WeaponOption>();
			this.allWeapons.AddRange(this.MeleeWeapons);
			this.allWeapons.AddRange(this.RangedWeapons);
			this.allWeapons.AddRange(this.Ammo);
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000C40DC File Offset: 0x000C22DC
		public override void ChoiceCallback(string choiceLabel)
		{
			DialogueController_ArmsDealer.WeaponOption weaponOption = this.allWeapons.Find((DialogueController_ArmsDealer.WeaponOption x) => x.Name == choiceLabel);
			if (weaponOption != null)
			{
				this.chosenWeapon = weaponOption;
				this.handler.ShowNode(DialogueHandler.activeDialogue.GetDialogueNodeByLabel("FINALIZE"));
			}
			if (choiceLabel == "CONFIRM" && this.chosenWeapon != null)
			{
				NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.chosenWeapon.Price, true, false);
				PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.chosenWeapon.Item.GetDefaultInstance(1));
			}
			base.ChoiceCallback(choiceLabel);
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x000C418C File Offset: 0x000C238C
		public override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			if (dialogueLabel == "MELEE_SELECTION")
			{
				existingChoices.AddRange(this.GetWeaponChoices(this.MeleeWeapons));
			}
			if (dialogueLabel == "RANGED_SELECTION")
			{
				existingChoices.AddRange(this.GetWeaponChoices(this.RangedWeapons));
			}
			if (dialogueLabel == "AMMO_SELECTION")
			{
				existingChoices.AddRange(this.GetWeaponChoices(this.Ammo));
			}
			base.ModifyChoiceList(dialogueLabel, ref existingChoices);
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000C4204 File Offset: 0x000C2404
		private List<DialogueChoiceData> GetWeaponChoices(List<DialogueController_ArmsDealer.WeaponOption> options)
		{
			List<DialogueChoiceData> list = new List<DialogueChoiceData>();
			foreach (DialogueController_ArmsDealer.WeaponOption weaponOption in options)
			{
				list.Add(new DialogueChoiceData
				{
					ChoiceText = weaponOption.Name + "<color=#54E717> (" + MoneyManager.FormatAmount(weaponOption.Price, false, false) + ")</color>",
					ChoiceLabel = weaponOption.Name
				});
			}
			return list;
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x000C4294 File Offset: 0x000C2494
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			DialogueController_ArmsDealer.WeaponOption weaponOption = this.allWeapons.Find((DialogueController_ArmsDealer.WeaponOption x) => x.Name == choiceLabel);
			if (weaponOption != null)
			{
				if (!weaponOption.IsAvailable)
				{
					invalidReason = weaponOption.NotAvailableReason;
					return false;
				}
				if (weaponOption.Item.RequiresLevelToPurchase && NetworkSingleton<LevelManager>.Instance.GetFullRank() < weaponOption.Item.RequiredRank)
				{
					string str = "Available at ";
					FullRank requiredRank = weaponOption.Item.RequiredRank;
					invalidReason = str + requiredRank.ToString();
					return false;
				}
				if (NetworkSingleton<MoneyManager>.Instance.cashBalance < weaponOption.Price)
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

		// Token: 0x06002EDE RID: 11998 RVA: 0x000C438C File Offset: 0x000C258C
		public override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			if (dialogueLabel == "FINALIZE" && this.chosenWeapon != null)
			{
				dialogueText = dialogueText.Replace("<WEAPON>", this.chosenWeapon.Name);
				dialogueText = dialogueText.Replace("<PRICE>", "<color=#54E717>" + MoneyManager.FormatAmount(this.chosenWeapon.Price, false, false) + "</color>");
			}
			return base.ModifyDialogueText(dialogueLabel, dialogueText);
		}

		// Token: 0x04002143 RID: 8515
		public List<DialogueController_ArmsDealer.WeaponOption> MeleeWeapons;

		// Token: 0x04002144 RID: 8516
		public List<DialogueController_ArmsDealer.WeaponOption> RangedWeapons;

		// Token: 0x04002145 RID: 8517
		public List<DialogueController_ArmsDealer.WeaponOption> Ammo;

		// Token: 0x04002146 RID: 8518
		private List<DialogueController_ArmsDealer.WeaponOption> allWeapons;

		// Token: 0x04002147 RID: 8519
		private DialogueController_ArmsDealer.WeaponOption chosenWeapon;

		// Token: 0x0200069C RID: 1692
		[Serializable]
		public class WeaponOption
		{
			// Token: 0x04002148 RID: 8520
			public string Name;

			// Token: 0x04002149 RID: 8521
			public float Price;

			// Token: 0x0400214A RID: 8522
			public bool IsAvailable;

			// Token: 0x0400214B RID: 8523
			public string NotAvailableReason;

			// Token: 0x0400214C RID: 8524
			public StorableItemDefinition Item;
		}
	}
}
