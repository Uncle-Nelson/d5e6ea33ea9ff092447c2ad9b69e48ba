using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.Property;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006B7 RID: 1719
	public class DialogueHandler_EstateAgent : ControlledDialogueHandler
	{
		// Token: 0x06002F5D RID: 12125 RVA: 0x000C5E00 File Offset: 0x000C4000
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			Property property = Property.UnownedProperties.Find((Property x) => x.PropertyCode.ToLower() == choiceLabel.ToLower());
			Business business = Business.UnownedBusinesses.Find((Business x) => x.PropertyCode.ToLower() == choiceLabel.ToLower());
			if (property != null && NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance < property.Price)
			{
				invalidReason = "Insufficient balance";
				return false;
			}
			if (business != null && NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance < business.Price)
			{
				invalidReason = "Insufficient balance";
				return false;
			}
			return base.CheckChoice(choiceLabel, out invalidReason);
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x000C5EA0 File Offset: 0x000C40A0
		public override bool ShouldChoiceBeShown(string choiceLabel)
		{
			Property property = Property.OwnedProperties.Find((Property x) => x.PropertyCode.ToLower() == choiceLabel.ToLower());
			Business business = Business.OwnedBusinesses.Find((Business x) => x.PropertyCode.ToLower() == choiceLabel.ToLower());
			return (!(property != null) || !property.IsOwned) && (!(business != null) || !business.IsOwned) && base.ShouldChoiceBeShown(choiceLabel);
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x000C5F1C File Offset: 0x000C411C
		protected override void ChoiceCallback(string choiceLabel)
		{
			Property x3 = Property.UnownedProperties.Find((Property x) => x.PropertyCode.ToLower() == choiceLabel.ToLower());
			Business x2 = Business.UnownedBusinesses.Find((Business x) => x.PropertyCode.ToLower() == choiceLabel.ToLower());
			if (x3 != null)
			{
				this.selectedProperty = x3;
			}
			if (x2 != null)
			{
				this.selectedBusiness = x2;
			}
			base.ChoiceCallback(choiceLabel);
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x000C5F90 File Offset: 0x000C4190
		protected override void DialogueCallback(string choiceLabel)
		{
			if (choiceLabel == "CONFIRM_BUY")
			{
				NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction(this.selectedProperty.PropertyName + " purchase", -this.selectedProperty.Price, 1f, string.Empty);
				this.selectedProperty.SetOwned();
			}
			if (choiceLabel == "CONFIRM_BUY_BUSINESS")
			{
				NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction(this.selectedBusiness.PropertyName + " purchase", -this.selectedBusiness.Price, 1f, string.Empty);
				this.selectedBusiness.SetOwned();
			}
			base.DialogueCallback(choiceLabel);
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x000C6040 File Offset: 0x000C4240
		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			if (dialogueLabel == "CONFIRM")
			{
				return dialogueText.Replace("<PROPERTY>", this.selectedProperty.PropertyName.ToLower());
			}
			if (dialogueLabel == "CONFIRM_BUSINESS")
			{
				return dialogueText.Replace("<BUSINESS>", this.selectedBusiness.PropertyName.ToLower());
			}
			return base.ModifyDialogueText(dialogueLabel, dialogueText);
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x000C60A8 File Offset: 0x000C42A8
		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			Property property = Property.UnownedProperties.Find((Property x) => x.PropertyCode.ToLower() == choiceLabel.ToLower());
			Business business = Business.UnownedBusinesses.Find((Business x) => x.PropertyCode.ToLower() == choiceLabel.ToLower());
			if (property != null)
			{
				return choiceText.Replace("(<PRICE>)", "<color=#19BEF0>(" + MoneyManager.FormatAmount(property.Price, false, false) + ")</color>");
			}
			if (business != null)
			{
				return choiceText.Replace("(<PRICE>)", "<color=#19BEF0>(" + MoneyManager.FormatAmount(business.Price, false, false) + ")</color>");
			}
			if (choiceLabel == "CONFIRM_CHOICE")
			{
				if (this.selectedProperty != null)
				{
					return choiceText.Replace("(<PRICE>)", "<color=#19BEF0>(" + MoneyManager.FormatAmount(this.selectedProperty.Price, false, false) + ")</color>");
				}
				if (this.selectedBusiness != null)
				{
					return choiceText.Replace("(<PRICE>)", "<color=#19BEF0>(" + MoneyManager.FormatAmount(this.selectedBusiness.Price, false, false) + ")</color>");
				}
			}
			return base.ModifyChoiceText(choiceLabel, choiceText);
		}

		// Token: 0x04002196 RID: 8598
		private Property selectedProperty;

		// Token: 0x04002197 RID: 8599
		private Business selectedBusiness;
	}
}
