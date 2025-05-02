using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006BD RID: 1725
	public class DialogueHandler_VehicleSalesman : ControlledDialogueHandler
	{
		// Token: 0x06002F76 RID: 12150 RVA: 0x000C63A0 File Offset: 0x000C45A0
		protected override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			Jeremy.DealershipListing dealershipListing = this.Salesman.Listings.Find((Jeremy.DealershipListing x) => x.vehicleCode.ToLower() == choiceLabel.ToLower());
			if (choiceLabel == "BUY_CASH")
			{
				if (this.selectedVehicle != null)
				{
					choiceText = choiceText.Replace("(<PRICE>)", "<color=#19BEF0>(" + MoneyManager.FormatAmount(this.selectedVehicle.price, false, false) + ")</color>");
				}
			}
			else if (choiceLabel == "BUY_ONLINE")
			{
				if (this.selectedVehicle != null)
				{
					choiceText = choiceText.Replace("(<PRICE>)", "<color=#19BEF0>(" + MoneyManager.FormatAmount(this.selectedVehicle.price, false, false) + ")</color>");
				}
			}
			else if (dealershipListing != null)
			{
				choiceText = choiceText.Replace("(<PRICE>)", "<color=#19BEF0>(" + MoneyManager.FormatAmount(dealershipListing.price, false, false) + ")</color>");
			}
			return base.ModifyChoiceText(choiceLabel, choiceText);
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x000C64A8 File Offset: 0x000C46A8
		public override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			if (choiceLabel == "BUY_CASH")
			{
				if (NetworkSingleton<MoneyManager>.Instance.cashBalance < this.selectedVehicle.price)
				{
					invalidReason = "Insufficient cash";
					return false;
				}
			}
			else if (choiceLabel == "BUY_ONLINE" && NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance < this.selectedVehicle.price)
			{
				invalidReason = "Insufficient balance";
				return false;
			}
			return base.CheckChoice(choiceLabel, out invalidReason);
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x000C6518 File Offset: 0x000C4718
		protected override void ChoiceCallback(string choiceLabel)
		{
			if (choiceLabel == "BUY_CASH")
			{
				if (NetworkSingleton<MoneyManager>.Instance.cashBalance >= this.selectedVehicle.price)
				{
					NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.selectedVehicle.price, true, false);
					this.Salesman.Dealership.SpawnVehicle(this.selectedVehicle.vehicleCode);
					return;
				}
			}
			else if (choiceLabel == "BUY_ONLINE")
			{
				if (NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= this.selectedVehicle.price)
				{
					NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction(this.selectedVehicle.vehicleCode + " purchase", -this.selectedVehicle.price, 1f, string.Empty);
					this.Salesman.Dealership.SpawnVehicle(this.selectedVehicle.vehicleCode);
					return;
				}
			}
			else
			{
				Jeremy.DealershipListing dealershipListing = this.Salesman.Listings.Find((Jeremy.DealershipListing x) => x.vehicleCode.ToLower() == choiceLabel.ToLower());
				if (dealershipListing != null)
				{
					this.selectedVehicle = dealershipListing;
				}
				base.ChoiceCallback(choiceLabel);
			}
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x000C6642 File Offset: 0x000C4842
		protected override int CheckBranch(string branchLabel)
		{
			if (!(branchLabel == "BRANCH_CAN_AFFORD"))
			{
				return base.CheckBranch(branchLabel);
			}
			if (this.selectedVehicle == null)
			{
				return 0;
			}
			if (NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= this.selectedVehicle.price)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x000C667D File Offset: 0x000C487D
		protected override void DialogueCallback(string choiceLabel)
		{
			base.DialogueCallback(choiceLabel);
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x000C6686 File Offset: 0x000C4886
		protected override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			if (dialogueLabel == "CONFIRM")
			{
				return dialogueText.Replace("<VEHICLE>", this.selectedVehicle.vehicleName);
			}
			return base.ModifyDialogueText(dialogueLabel, dialogueText);
		}

		// Token: 0x0400219E RID: 8606
		public Jeremy Salesman;

		// Token: 0x0400219F RID: 8607
		public Jeremy.DealershipListing selectedVehicle;
	}
}
