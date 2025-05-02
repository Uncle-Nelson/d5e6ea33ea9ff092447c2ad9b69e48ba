using System;
using System.Collections.Generic;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006C8 RID: 1736
	[Serializable]
	public class DialogueContainer : ScriptableObject
	{
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x000C685D File Offset: 0x000C4A5D
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x000C6865 File Offset: 0x000C4A65
		public bool allowExit { get; private set; } = true;

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x000C686E File Offset: 0x000C4A6E
		public bool AllowExit
		{
			get
			{
				return this.allowExit || Player.Local.IsArrested || !Player.Local.Health.IsAlive;
			}
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x000C6898 File Offset: 0x000C4A98
		public DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel)
		{
			return this.DialogueNodeData.Find((DialogueNodeData x) => x.DialogueNodeLabel == dialogueNodeLabel);
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x000C68CC File Offset: 0x000C4ACC
		public BranchNodeData GetBranchNodeByLabel(string branchLabel)
		{
			return this.BranchNodeData.Find((BranchNodeData x) => x.BranchLabel == branchLabel);
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x000C6900 File Offset: 0x000C4B00
		public DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID)
		{
			return this.DialogueNodeData.Find((DialogueNodeData x) => x.Guid == dialogueNodeGUID);
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x000C6934 File Offset: 0x000C4B34
		public BranchNodeData GetBranchNodeByGUID(string branchGUID)
		{
			return this.BranchNodeData.Find((BranchNodeData x) => x.Guid == branchGUID);
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x000C6968 File Offset: 0x000C4B68
		public NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			return this.NodeLinks.Find((NodeLinkData x) => x.BaseChoiceOrOptionGUID == baseChoiceOrOptionGUID);
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x000C6999 File Offset: 0x000C4B99
		public void SetAllowExit(bool allowed)
		{
			this.allowExit = allowed;
		}

		// Token: 0x040021B9 RID: 8633
		public List<NodeLinkData> NodeLinks = new List<NodeLinkData>();

		// Token: 0x040021BA RID: 8634
		public List<DialogueNodeData> DialogueNodeData = new List<DialogueNodeData>();

		// Token: 0x040021BB RID: 8635
		public List<BranchNodeData> BranchNodeData = new List<BranchNodeData>();
	}
}
