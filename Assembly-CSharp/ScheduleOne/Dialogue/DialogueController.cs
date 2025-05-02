using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000695 RID: 1685
	public class DialogueController : MonoBehaviour
	{
		// Token: 0x06002EB3 RID: 11955 RVA: 0x000C38F4 File Offset: 0x000C1AF4
		protected virtual void Start()
		{
			this.handler = base.GetComponent<DialogueHandler>();
			this.npc = this.handler.NPC;
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x000C3956 File Offset: 0x000C1B56
		private void Update()
		{
			this.lastGreetingTime += Time.deltaTime;
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x000C396C File Offset: 0x000C1B6C
		private void Hovered()
		{
			if (this.CanStartDialogue() && (((this.GetActiveChoices().Count > 0 || this.lastGreetingTime > DialogueController.GREETING_COOLDOWN) && this.DialogueEnabled) || this.OverrideContainer != null))
			{
				this.IntObj.SetMessage("Talk to " + this.npc.GetNameAddress());
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x000C39EB File Offset: 0x000C1BEB
		public void StartGenericDialogue(bool allowExit = true)
		{
			this.Interacted();
			this.GenericDialogue.SetAllowExit(allowExit);
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x000C3A00 File Offset: 0x000C1C00
		private void Interacted()
		{
			this.GenericDialogue.SetAllowExit(true);
			this.dialogueQueued = true;
			base.Invoke("Unqueue", 1f);
			if (this.OverrideContainer != null)
			{
				this.handler.InitializeDialogue(this.OverrideContainer, this.UseDialogueBehaviour, "ENTRY");
				return;
			}
			if (this.GetActiveChoices().Count > 0)
			{
				this.shownChoices = this.GetActiveChoices();
				bool flag;
				EVOLineType evolineType;
				this.cachedGreeting = this.GetActiveGreeting(out flag, out evolineType);
				this.handler.InitializeDialogue(this.GenericDialogue, this.UseDialogueBehaviour, "ENTRY");
				if (flag && evolineType != EVOLineType.None)
				{
					this.npc.PlayVO(evolineType);
					return;
				}
			}
			else
			{
				bool flag2;
				EVOLineType lineType;
				this.handler.ShowWorldspaceDialogue(this.GetActiveGreeting(out flag2, out lineType), 5f);
				this.lastGreetingTime = 0f;
				if (flag2)
				{
					this.npc.PlayVO(lineType);
				}
			}
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x000C3AE8 File Offset: 0x000C1CE8
		private void Unqueue()
		{
			this.dialogueQueued = false;
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x000C3AF4 File Offset: 0x000C1CF4
		private string GetActiveGreeting(out bool playVO, out EVOLineType voLineType)
		{
			playVO = false;
			string result;
			if (this.GetCustomGreeting(out result, out playVO, out voLineType))
			{
				return result;
			}
			playVO = true;
			voLineType = EVOLineType.Greeting;
			if (NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(400, 1200))
			{
				return this.handler.Database.GetLine(EDialogueModule.Greetings, "morning_greeting");
			}
			if (NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(1200, 1800))
			{
				return this.handler.Database.GetLine(EDialogueModule.Greetings, "afternoon_greeting");
			}
			return this.handler.Database.GetLine(EDialogueModule.Greetings, "night_greeting");
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x000C3B88 File Offset: 0x000C1D88
		private List<DialogueController.DialogueChoice> GetActiveChoices()
		{
			List<DialogueController.DialogueChoice> list = new List<DialogueController.DialogueChoice>();
			foreach (DialogueController.DialogueChoice dialogueChoice in this.Choices)
			{
				if (dialogueChoice.ShouldShow())
				{
					list.Add(dialogueChoice);
				}
			}
			list.Sort((DialogueController.DialogueChoice a, DialogueController.DialogueChoice b) => b.Priority.CompareTo(a.Priority));
			return list;
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x000C3C10 File Offset: 0x000C1E10
		protected virtual bool GetCustomGreeting(out string greeting, out bool playVO, out EVOLineType voLineType)
		{
			greeting = string.Empty;
			playVO = false;
			voLineType = EVOLineType.Greeting;
			for (int i = 0; i < this.GreetingOverrides.Count; i++)
			{
				if (this.GreetingOverrides[i].ShouldShow)
				{
					greeting = this.GreetingOverrides[i].Greeting;
					playVO = this.GreetingOverrides[i].PlayVO;
					voLineType = this.GreetingOverrides[i].VOType;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x000C3C8F File Offset: 0x000C1E8F
		public virtual int AddDialogueChoice(DialogueController.DialogueChoice data, int priority = 0)
		{
			data.Priority = priority;
			this.Choices.Add(data);
			return this.Choices.Count - 1;
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x000C3CB1 File Offset: 0x000C1EB1
		public virtual int AddGreetingOverride(DialogueController.GreetingOverride data)
		{
			this.GreetingOverrides.Add(data);
			return this.Choices.Count - 1;
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x000C3CCC File Offset: 0x000C1ECC
		public virtual bool CanStartDialogue()
		{
			return (Player.Local.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None || Player.Local.CrimeData.TimeSinceSighted >= 5f) && !Singleton<ManagementClipboard>.Instance.IsEquipped && !this.npc.behaviour.CallPoliceBehaviour.Active && !this.npc.behaviour.CombatBehaviour.Active && !this.npc.behaviour.CoweringBehaviour.Active && !this.npc.behaviour.RagdollBehaviour.Active && !this.npc.behaviour.HeavyFlinchBehaviour.Active && !this.npc.behaviour.ConsumeProductBehaviour.Active && !this.npc.behaviour.FleeBehaviour.Active && !this.npc.behaviour.GenericDialogueBehaviour.Active && this.npc.IsConscious && !this.dialogueQueued;
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x000C3DF2 File Offset: 0x000C1FF2
		public virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			if (DialogueHandler.activeDialogue == this.GenericDialogue && dialogueLabel == "ENTRY")
			{
				return this.cachedGreeting;
			}
			return dialogueText;
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x000C3E1B File Offset: 0x000C201B
		public virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return choiceText;
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x000C3E20 File Offset: 0x000C2020
		public virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			if (DialogueHandler.activeDialogue == this.GenericDialogue && dialogueLabel == "ENTRY")
			{
				List<DialogueController.DialogueChoice> list = this.shownChoices;
				for (int i = 0; i < list.Count; i++)
				{
					DialogueChoiceData dialogueChoiceData = new DialogueChoiceData();
					dialogueChoiceData.ChoiceText = list[i].ChoiceText;
					dialogueChoiceData.ChoiceLabel = "GENERIC_CHOICE_" + i.ToString();
					existingChoices.Add(dialogueChoiceData);
				}
			}
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000C3E9C File Offset: 0x000C209C
		public virtual void ChoiceCallback(string choiceLabel)
		{
			if (DialogueHandler.activeDialogue == this.GenericDialogue && choiceLabel.Contains("GENERIC_CHOICE_"))
			{
				int num = int.Parse(choiceLabel.Substring("GENERIC_CHOICE_".Length));
				List<DialogueController.DialogueChoice> list = this.shownChoices;
				if (num >= 0 && num < list.Count)
				{
					DialogueController.DialogueChoice dialogueChoice = list[num];
					if (dialogueChoice.onChoosen != null)
					{
						dialogueChoice.onChoosen.Invoke();
					}
					if (dialogueChoice.Conversation != null)
					{
						this.handler.InitializeDialogue(dialogueChoice.Conversation);
					}
				}
			}
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000C3F2C File Offset: 0x000C212C
		public virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			if (DialogueHandler.activeDialogue == this.GenericDialogue && choiceLabel.Contains("GENERIC_CHOICE_"))
			{
				int num = int.Parse(choiceLabel.Substring("GENERIC_CHOICE_".Length));
				List<DialogueController.DialogueChoice> list = this.shownChoices;
				if (num >= 0 && num < list.Count)
				{
					return list[num].IsValid(out invalidReason);
				}
			}
			invalidReason = string.Empty;
			return true;
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x000C3F98 File Offset: 0x000C2198
		public void SetOverrideContainer(DialogueContainer container)
		{
			this.OverrideContainer = container;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x000C3FA1 File Offset: 0x000C21A1
		public void ClearOverrideContainer()
		{
			this.OverrideContainer = null;
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x000C3FAA File Offset: 0x000C21AA
		public virtual bool DecideBranch(string branchLabel, out int index)
		{
			index = 0;
			return false;
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x000C3FB0 File Offset: 0x000C21B0
		public void SetDialogueEnabled(bool enabled)
		{
			this.DialogueEnabled = enabled;
		}

		// Token: 0x04002128 RID: 8488
		public static float GREETING_COOLDOWN = 5f;

		// Token: 0x04002129 RID: 8489
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x0400212A RID: 8490
		public DialogueContainer GenericDialogue;

		// Token: 0x0400212B RID: 8491
		[Header("Settings")]
		public bool DialogueEnabled = true;

		// Token: 0x0400212C RID: 8492
		public bool UseDialogueBehaviour = true;

		// Token: 0x0400212D RID: 8493
		public List<DialogueController.DialogueChoice> Choices = new List<DialogueController.DialogueChoice>();

		// Token: 0x0400212E RID: 8494
		public List<DialogueController.GreetingOverride> GreetingOverrides = new List<DialogueController.GreetingOverride>();

		// Token: 0x0400212F RID: 8495
		public DialogueContainer OverrideContainer;

		// Token: 0x04002130 RID: 8496
		protected NPC npc;

		// Token: 0x04002131 RID: 8497
		protected DialogueHandler handler;

		// Token: 0x04002132 RID: 8498
		private float lastGreetingTime = 20f;

		// Token: 0x04002133 RID: 8499
		private List<DialogueController.DialogueChoice> shownChoices = new List<DialogueController.DialogueChoice>();

		// Token: 0x04002134 RID: 8500
		private bool dialogueQueued;

		// Token: 0x04002135 RID: 8501
		private string cachedGreeting = string.Empty;

		// Token: 0x02000696 RID: 1686
		[Serializable]
		public class DialogueChoice
		{
			// Token: 0x06002ECA RID: 11978 RVA: 0x000C4020 File Offset: 0x000C2220
			public bool ShouldShow()
			{
				if (this.shouldShowCheck != null)
				{
					return this.shouldShowCheck(this.Enabled);
				}
				return this.Enabled;
			}

			// Token: 0x06002ECB RID: 11979 RVA: 0x000C4042 File Offset: 0x000C2242
			public bool IsValid(out string invalidReason)
			{
				if (this.isValidCheck != null)
				{
					return this.isValidCheck(out invalidReason);
				}
				invalidReason = string.Empty;
				return true;
			}

			// Token: 0x04002136 RID: 8502
			public bool Enabled = true;

			// Token: 0x04002137 RID: 8503
			public string ChoiceText;

			// Token: 0x04002138 RID: 8504
			public DialogueContainer Conversation;

			// Token: 0x04002139 RID: 8505
			public UnityEvent onChoosen = new UnityEvent();

			// Token: 0x0400213A RID: 8506
			public DialogueController.DialogueChoice.ShouldShowCheck shouldShowCheck;

			// Token: 0x0400213B RID: 8507
			public DialogueController.DialogueChoice.IsChoiceValid isValidCheck;

			// Token: 0x0400213C RID: 8508
			public int Priority;

			// Token: 0x02000697 RID: 1687
			// (Invoke) Token: 0x06002ECE RID: 11982
			public delegate bool ShouldShowCheck(bool enabled);

			// Token: 0x02000698 RID: 1688
			// (Invoke) Token: 0x06002ED2 RID: 11986
			public delegate bool IsChoiceValid(out string invalidReason);
		}

		// Token: 0x02000699 RID: 1689
		[Serializable]
		public class GreetingOverride
		{
			// Token: 0x0400213D RID: 8509
			public string Greeting;

			// Token: 0x0400213E RID: 8510
			public bool ShouldShow;

			// Token: 0x0400213F RID: 8511
			public bool PlayVO;

			// Token: 0x04002140 RID: 8512
			public EVOLineType VOType;
		}
	}
}
