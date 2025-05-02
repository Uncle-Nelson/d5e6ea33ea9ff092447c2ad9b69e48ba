using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x020004C9 RID: 1225
	public class Marco : NPC
	{
		// Token: 0x06001B19 RID: 6937 RVA: 0x00071F34 File Offset: 0x00070134
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.Marco_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00071F53 File Offset: 0x00070153
		protected override void Start()
		{
			base.Start();
			Singleton<VehicleModMenu>.Instance.onPaintPurchased.AddListener(new UnityAction(delegate()
			{
				this.dialogueHandler.ShowWorldspaceDialogue_5s("Thanks buddy");
			}));
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.Loaded));
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00071F91 File Offset: 0x00070191
		private bool ShouldShowRecoverVehicle(bool enabled)
		{
			return Player.Local.LastDrivenVehicle != null;
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00071FA3 File Offset: 0x000701A3
		private bool RecoverVehicleValid(out string reason)
		{
			if (Player.Local.LastDrivenVehicle == null)
			{
				reason = "You have no vehicle to recover";
				return false;
			}
			if (Player.Local.LastDrivenVehicle.isOccupied)
			{
				reason = "Someone is in the vehicle";
				return false;
			}
			reason = string.Empty;
			return true;
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00071FE4 File Offset: 0x000701E4
		private bool RepaintVehicleValid(out string reason)
		{
			if (this.VehicleDetector.closestVehicle == null)
			{
				reason = "Vehicle must be parked inside the shop";
				return false;
			}
			if (this.VehicleDetector.closestVehicle.isOccupied)
			{
				reason = "Someone is in the vehicle";
				return false;
			}
			reason = string.Empty;
			return true;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00072030 File Offset: 0x00070230
		private void RecoverVehicle()
		{
			LandVehicle lastDrivenVehicle = Player.Local.LastDrivenVehicle;
			if (lastDrivenVehicle == null)
			{
				return;
			}
			lastDrivenVehicle.AlignTo(this.VehicleRecoveryPoint, EParkingAlignment.RearToKerb, true);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00072060 File Offset: 0x00070260
		private void Loaded()
		{
			Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.Loaded));
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>(this.GreetedVariable))
			{
				this.EnableGreeting();
			}
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00072095 File Offset: 0x00070295
		private void EnableGreeting()
		{
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = this.GreetingDialogue;
			this.dialogueHandler.onConversationStart.AddListener(new UnityAction(this.SetGreeted));
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000720CC File Offset: 0x000702CC
		private void SetGreeted()
		{
			this.dialogueHandler.onConversationStart.RemoveListener(new UnityAction(this.SetGreeted));
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.GreetedVariable, true.ToString(), true);
			this.dialogueHandler.GetComponent<DialogueController>().OverrideContainer = null;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0007215C File Offset: 0x0007035C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00072175 File Offset: 0x00070375
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.MarcoAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0007218E File Offset: 0x0007038E
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0007219C File Offset: 0x0007039C
		protected virtual void dll()
		{
			base.Awake();
			DialogueController.DialogueChoice dialogueChoice = new DialogueController.DialogueChoice();
			dialogueChoice.ChoiceText = "My vehicle is stuck";
			dialogueChoice.Enabled = true;
			dialogueChoice.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.ShouldShowRecoverVehicle);
			dialogueChoice.isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.RecoverVehicleValid);
			dialogueChoice.Conversation = this.RecoveryConversation;
			dialogueChoice.onChoosen.AddListener(new UnityAction(this.RecoverVehicle));
			DialogueController.DialogueChoice dialogueChoice2 = new DialogueController.DialogueChoice();
			dialogueChoice2.ChoiceText = "I'd like to repaint my vehicle";
			dialogueChoice2.Enabled = true;
			dialogueChoice2.isValidCheck = new DialogueController.DialogueChoice.IsChoiceValid(this.RepaintVehicleValid);
			dialogueChoice2.onChoosen.AddListener(new UnityAction(delegate()
			{
				Singleton<VehicleModMenu>.Instance.Open(this.VehicleDetector.closestVehicle);
			}));
			this.dialogueHandler.GetComponent<DialogueController>().Choices.Add(dialogueChoice2);
			this.dialogueHandler.GetComponent<DialogueController>().Choices.Add(dialogueChoice);
		}

		// Token: 0x040016D5 RID: 5845
		public Transform VehicleRecoveryPoint;

		// Token: 0x040016D6 RID: 5846
		public VehicleDetector VehicleDetector;

		// Token: 0x040016D7 RID: 5847
		public DialogueContainer RecoveryConversation;

		// Token: 0x040016D8 RID: 5848
		public DialogueContainer GreetingDialogue;

		// Token: 0x040016D9 RID: 5849
		public string GreetedVariable = "MarcoGreeted";

		// Token: 0x040016DA RID: 5850
		private bool dll_Excuted;

		// Token: 0x040016DB RID: 5851
		private bool dll_Excuted;
	}
}
