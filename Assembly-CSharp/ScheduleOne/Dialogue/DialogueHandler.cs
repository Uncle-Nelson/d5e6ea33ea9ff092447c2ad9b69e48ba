using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006B1 RID: 1713
	public class DialogueHandler : MonoBehaviour
	{
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000C52B6 File Offset: 0x000C34B6
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x000C52BE File Offset: 0x000C34BE
		public bool IsPlaying { get; private set; }

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x000C52C7 File Offset: 0x000C34C7
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x000C52CF File Offset: 0x000C34CF
		public NPC NPC { get; protected set; }

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x000C52D8 File Offset: 0x000C34D8
		private DialogueCanvas canvas
		{
			get
			{
				return Singleton<DialogueCanvas>.Instance;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x000C52DF File Offset: 0x000C34DF
		// (set) Token: 0x06002F2C RID: 12076 RVA: 0x000C52E7 File Offset: 0x000C34E7
		public List<DialogueModule> runtimeModules { get; private set; } = new List<DialogueModule>();

		// Token: 0x06002F2D RID: 12077 RVA: 0x000C52F0 File Offset: 0x000C34F0
		protected virtual void Awake()
		{
			if (this.NPC == null)
			{
				this.NPC = base.GetComponentInParent<NPC>();
			}
			DialogueModule dialogueModule = base.gameObject.AddComponent<DialogueModule>();
			dialogueModule.ModuleType = EDialogueModule.Generic;
			dialogueModule.Entries = this.Database.GenericEntries;
			this.runtimeModules.Add(dialogueModule);
			this.runtimeModules.AddRange(this.Database.Modules);
			this.Database.Initialize(this);
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000C536C File Offset: 0x000C356C
		protected virtual void Start()
		{
			if (this.Database == null)
			{
				Console.LogWarning(this.NPC.fullName + " dialogue database isn't assigned! Using default database.", null);
				if (Singleton<DialogueManager>.Instance != null)
				{
					this.Database = Singleton<DialogueManager>.Instance.DefaultDatabase;
				}
				else
				{
					Console.LogError("DialogueManager instance is null. Cannot use default database.", null);
				}
			}
			if (this.VOEmitter == null && this.NPC != null)
			{
				this.VOEmitter = this.NPC.VoiceOverEmitter;
			}
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000C53F9 File Offset: 0x000C35F9
		public void InitializeDialogue(DialogueContainer container)
		{
			this.InitializeDialogue(container, true, "ENTRY");
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x000C5408 File Offset: 0x000C3608
		public void InitializeDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			DialogueHandler.<>c__DisplayClass35_0 CS$<>8__locals1 = new DialogueHandler.<>c__DisplayClass35_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.dialogueContainer = dialogueContainer;
			CS$<>8__locals1.entryNodeLabel = entryNodeLabel;
			if (CS$<>8__locals1.dialogueContainer == null)
			{
				Console.LogWarning("InitializeDialogue: provided dialogueContainer is null", null);
				return;
			}
			if (enableDialogueBehaviour)
			{
				this.NPC.behaviour.GenericDialogueBehaviour.SendTargetPlayer(Player.Local.NetworkObject);
				this.NPC.behaviour.GenericDialogueBehaviour.SendEnable();
				this.NPC.behaviour.Update();
			}
			if (this.WorldspaceRend.ShownText != null)
			{
				this.WorldspaceRend.HideText();
			}
			if (this.onConversationStart != null)
			{
				this.onConversationStart.Invoke();
			}
			CS$<>8__locals1.npc = base.GetComponentInParent<NPC>();
			if (CS$<>8__locals1.npc != null && CS$<>8__locals1.npc.Avatar.Anim.TimeSinceSitEnd < 0.5f && enableDialogueBehaviour)
			{
				base.StartCoroutine(CS$<>8__locals1.<InitializeDialogue>g__Wait|0());
				return;
			}
			CS$<>8__locals1.<InitializeDialogue>g__Open|1();
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x000C5510 File Offset: 0x000C3710
		public void InitializeDialogue(string dialogueContainerName, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			DialogueContainer dialogueContainer = this.dialogueContainers.Find((DialogueContainer x) => x.name.ToLower() == dialogueContainerName.ToLower());
			if (dialogueContainer == null)
			{
				Console.LogWarning("InitializeDialogue: Could not find DialogueContainer with name '" + dialogueContainerName + "'", null);
				return;
			}
			this.InitializeDialogue(dialogueContainer, enableDialogueBehaviour, entryNodeLabel);
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x000C5570 File Offset: 0x000C3770
		public virtual bool CanBeginConversation()
		{
			return this.NPC.SyncAccessor_PlayerConversant == null;
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x000C5583 File Offset: 0x000C3783
		public void OverrideShownDialogue(string _overrideText)
		{
			this.overrideText = _overrideText;
			this.canvas.OverrideText(this.overrideText);
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000C559D File Offset: 0x000C379D
		public void StopOverride()
		{
			this.overrideText = string.Empty;
			this.canvas.StopTextOverride();
			if (DialogueHandler.activeDialogueNode != null)
			{
				this.ShowNode(DialogueHandler.activeDialogueNode);
			}
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000C55C8 File Offset: 0x000C37C8
		public virtual void EndDialogue()
		{
			if (this.skipNextDialogueBehaviourEnd)
			{
				this.skipNextDialogueBehaviourEnd = false;
			}
			else
			{
				this.NPC.behaviour.GenericDialogueBehaviour.SendDisable();
			}
			foreach (DialogueEvent dialogueEvent in this.DialogueEvents)
			{
				if (!(dialogueEvent.Dialogue != DialogueHandler.activeDialogue) && dialogueEvent.onDialogueEnded != null)
				{
					dialogueEvent.onDialogueEnded.Invoke();
				}
			}
			this.canvas.EndDialogue();
			this.IsPlaying = false;
			DialogueHandler.activeDialogue = null;
			DialogueHandler.activeDialogueNode = null;
			this.NPC.SetConversant(null);
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x000C5663 File Offset: 0x000C3863
		public void SkipNextDialogueBehaviourEnd()
		{
			this.skipNextDialogueBehaviourEnd = true;
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000C566C File Offset: 0x000C386C
		protected virtual DialogueNodeData FinalizeDialogueNode(DialogueNodeData data)
		{
			return data;
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x000C5670 File Offset: 0x000C3870
		public void ShowNode(DialogueNodeData node)
		{
			node = this.FinalizeDialogueNode(node);
			DialogueHandler.activeDialogueNode = node;
			if (this.overrideText != string.Empty)
			{
				return;
			}
			string dialogueText = this.ModifyDialogueText(node.DialogueNodeLabel, node.DialogueText);
			this.CurrentChoices = new List<DialogueChoiceData>();
			foreach (DialogueChoiceData dialogueChoiceData in node.choices)
			{
				if (this.ShouldChoiceBeShown(dialogueChoiceData.ChoiceLabel))
				{
					this.CurrentChoices.Add(dialogueChoiceData);
				}
			}
			this.TempLinks.Clear();
			this.ModifyChoiceList(node.DialogueNodeLabel, ref this.CurrentChoices);
			List<string> list = new List<string>();
			foreach (DialogueChoiceData dialogueChoiceData2 in this.CurrentChoices)
			{
				list.Add(this.ModifyChoiceText(dialogueChoiceData2.ChoiceLabel, dialogueChoiceData2.ChoiceText));
			}
			this.DialogueCallback(node.DialogueNodeLabel);
			if (this.VOEmitter != null && node.VoiceLine != EVOLineType.None)
			{
				this.VOEmitter.Play(node.VoiceLine);
			}
			this.canvas.DisplayDialogueNode(this, DialogueHandler.activeDialogueNode, dialogueText, list);
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x000C57B8 File Offset: 0x000C39B8
		private void EvaluateBranch(BranchNodeData node)
		{
			int num = this.CheckBranch(node.BranchLabel);
			if (node.options.Length > num)
			{
				NodeLinkData link = this.GetLink(node.options[num].Guid);
				if (link != null)
				{
					if (DialogueHandler.activeDialogue.GetDialogueNodeByGUID(link.TargetNodeGuid) != null)
					{
						this.ShowNode(DialogueHandler.activeDialogue.GetDialogueNodeByGUID(link.TargetNodeGuid));
					}
					else if (DialogueHandler.activeDialogue.GetBranchNodeByGUID(link.TargetNodeGuid) != null)
					{
						this.EvaluateBranch(DialogueHandler.activeDialogue.GetBranchNodeByGUID(link.TargetNodeGuid));
					}
				}
				else
				{
					this.EndDialogue();
				}
			}
			else
			{
				Console.LogWarning("EvaluateBranch: optionIndex is out of range", null);
				this.EndDialogue();
			}
			this.TempLinks.Clear();
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000C586C File Offset: 0x000C3A6C
		public void ChoiceSelected(int choiceIndex)
		{
			DialogueNodeData dialogueNodeData = DialogueHandler.activeDialogueNode;
			this.ChoiceCallback(this.CurrentChoices[choiceIndex].ChoiceLabel);
			if (DialogueHandler.activeDialogueNode == dialogueNodeData && DialogueHandler.activeDialogueNode != null)
			{
				NodeLinkData link = this.GetLink(this.CurrentChoices[choiceIndex].Guid);
				if (link != null)
				{
					if (DialogueHandler.activeDialogue.GetDialogueNodeByGUID(link.TargetNodeGuid) != null)
					{
						this.ShowNode(DialogueHandler.activeDialogue.GetDialogueNodeByGUID(link.TargetNodeGuid));
						return;
					}
					if (DialogueHandler.activeDialogue.GetBranchNodeByGUID(link.TargetNodeGuid) != null)
					{
						this.EvaluateBranch(DialogueHandler.activeDialogue.GetBranchNodeByGUID(link.TargetNodeGuid));
						return;
					}
				}
				else
				{
					this.EndDialogue();
				}
			}
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000C5918 File Offset: 0x000C3B18
		public void ContinueSubmitted()
		{
			if (DialogueHandler.activeDialogueNode.choices.Length == 0)
			{
				this.EndDialogue();
				return;
			}
			NodeLinkData link = this.GetLink(DialogueHandler.activeDialogueNode.choices[0].Guid);
			if (link != null)
			{
				if (DialogueHandler.activeDialogue.GetDialogueNodeByGUID(link.TargetNodeGuid) != null)
				{
					this.ShowNode(DialogueHandler.activeDialogue.GetDialogueNodeByGUID(link.TargetNodeGuid));
					return;
				}
				if (DialogueHandler.activeDialogue.GetBranchNodeByGUID(link.TargetNodeGuid) != null)
				{
					this.EvaluateBranch(DialogueHandler.activeDialogue.GetBranchNodeByGUID(link.TargetNodeGuid));
					return;
				}
			}
			else
			{
				this.EndDialogue();
			}
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000C59AC File Offset: 0x000C3BAC
		public virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			if (choiceLabel == "CHOICE_TEST")
			{
				invalidReason = "IT JUST CAN'T BE DONE";
				return false;
			}
			invalidReason = string.Empty;
			return true;
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000022C9 File Offset: 0x000004C9
		public virtual bool ShouldChoiceBeShown(string choiceLabel)
		{
			return true;
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000C59CC File Offset: 0x000C3BCC
		protected virtual int CheckBranch(string branchLabel)
		{
			if (branchLabel == "BRANCH_REJECTION")
			{
				return Random.Range(0, 2);
			}
			if (!(branchLabel == "BRANCH_CHECKPASS"))
			{
				if (branchLabel != string.Empty)
				{
					Console.LogWarning("CheckBranch: branch label '" + branchLabel + "' not accounted for!", null);
				}
				return 0;
			}
			if (this.passChecked)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000C3E1B File Offset: 0x000C201B
		protected virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return dialogueText;
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x000C3E1B File Offset: 0x000C201B
		protected virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return choiceText;
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x000C5A2B File Offset: 0x000C3C2B
		protected virtual void ChoiceCallback(string choiceLabel)
		{
			if (this.onDialogueChoiceChosen != null)
			{
				this.onDialogueChoiceChosen.Invoke(choiceLabel);
			}
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x000C5A44 File Offset: 0x000C3C44
		protected virtual void DialogueCallback(string dialogueLabel)
		{
			if (this.onDialogueNodeDisplayed != null)
			{
				this.onDialogueNodeDisplayed.Invoke(dialogueLabel);
			}
			foreach (DialogueEvent dialogueEvent in this.DialogueEvents)
			{
				if (!(dialogueEvent.Dialogue != DialogueHandler.activeDialogue))
				{
					foreach (DialogueNodeEvent dialogueNodeEvent in dialogueEvent.NodeEvents)
					{
						if (dialogueNodeEvent.NodeLabel == dialogueLabel)
						{
							dialogueNodeEvent.onNodeDisplayed.Invoke();
						}
					}
				}
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x000C5ACC File Offset: 0x000C3CCC
		protected void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID)
		{
			NodeLinkData nodeLinkData = new NodeLinkData();
			nodeLinkData.BaseDialogueOrBranchNodeGuid = baseNodeGUID;
			nodeLinkData.BaseChoiceOrOptionGUID = baseOptionGUID;
			nodeLinkData.TargetNodeGuid = targetNodeGUID;
			this.TempLinks.Add(nodeLinkData);
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000C5B00 File Offset: 0x000C3D00
		private NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			NodeLinkData nodeLinkData = DialogueHandler.activeDialogue.GetLink(baseChoiceOrOptionGUID);
			if (nodeLinkData == null)
			{
				nodeLinkData = this.TempLinks.Find((NodeLinkData x) => x.BaseChoiceOrOptionGUID == baseChoiceOrOptionGUID);
			}
			return nodeLinkData;
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void Hovered()
		{
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void Interacted()
		{
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x000C5B47 File Offset: 0x000C3D47
		public virtual void PlayReaction_Local(string key)
		{
			this.PlayReaction(key, -1f, false);
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000C5B56 File Offset: 0x000C3D56
		public virtual void PlayReaction_Networked(string key)
		{
			this.PlayReaction(key, -1f, true);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x000C5B68 File Offset: 0x000C3D68
		public virtual void PlayReaction(string key, float duration, bool network)
		{
			if (!this.NPC.IsConscious)
			{
				return;
			}
			if (network)
			{
				this.NPC.SendWorldspaceDialogueKey(key, duration);
				return;
			}
			if (key == string.Empty)
			{
				this.HideWorldspaceDialogue();
				return;
			}
			string line = this.Database.GetLine(EDialogueModule.Reactions, key);
			if (duration == -1f)
			{
				duration = Mathf.Clamp((float)line.Length * 0.2f, 1.5f, 5f);
			}
			this.WorldspaceRend.ShowText(line, duration);
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x000C5BE9 File Offset: 0x000C3DE9
		public virtual void HideWorldspaceDialogue()
		{
			this.WorldspaceRend.HideText();
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x000C5BF6 File Offset: 0x000C3DF6
		public virtual void ShowWorldspaceDialogue(string text, float duration)
		{
			if (!this.NPC.IsConscious)
			{
				return;
			}
			this.WorldspaceRend.ShowText(text, duration);
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000C5C13 File Offset: 0x000C3E13
		public virtual void ShowWorldspaceDialogue_5s(string text)
		{
			this.ShowWorldspaceDialogue(text, 5f);
		}

		// Token: 0x04002177 RID: 8567
		public const float TimePerChar = 0.2f;

		// Token: 0x04002178 RID: 8568
		public const float WorldspaceDialogueMinDuration = 1.5f;

		// Token: 0x04002179 RID: 8569
		public const float WorldspaceDialogueMaxDuration = 5f;

		// Token: 0x0400217A RID: 8570
		public static DialogueContainer activeDialogue;

		// Token: 0x0400217B RID: 8571
		public static DialogueNodeData activeDialogueNode;

		// Token: 0x0400217D RID: 8573
		public DialogueDatabase Database;

		// Token: 0x0400217E RID: 8574
		[Header("References")]
		public Transform LookPosition;

		// Token: 0x0400217F RID: 8575
		public WorldspaceDialogueRenderer WorldspaceRend;

		// Token: 0x04002181 RID: 8577
		public VOEmitter VOEmitter;

		// Token: 0x04002182 RID: 8578
		[HideInInspector]
		public List<DialogueChoiceData> CurrentChoices = new List<DialogueChoiceData>();

		// Token: 0x04002183 RID: 8579
		[Header("Events")]
		public DialogueEvent[] DialogueEvents;

		// Token: 0x04002184 RID: 8580
		public UnityEvent onConversationStart;

		// Token: 0x04002185 RID: 8581
		public UnityEvent<string> onDialogueNodeDisplayed;

		// Token: 0x04002186 RID: 8582
		public UnityEvent<string> onDialogueChoiceChosen;

		// Token: 0x04002187 RID: 8583
		protected string overrideText = string.Empty;

		// Token: 0x04002188 RID: 8584
		[SerializeField]
		private List<DialogueContainer> dialogueContainers = new List<DialogueContainer>();

		// Token: 0x04002189 RID: 8585
		private List<NodeLinkData> TempLinks = new List<NodeLinkData>();

		// Token: 0x0400218A RID: 8586
		private bool skipNextDialogueBehaviourEnd;

		// Token: 0x0400218C RID: 8588
		private bool passChecked;
	}
}
