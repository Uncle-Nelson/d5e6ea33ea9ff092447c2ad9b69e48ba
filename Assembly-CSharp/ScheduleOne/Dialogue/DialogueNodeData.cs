using System;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006CE RID: 1742
	[Serializable]
	public class DialogueNodeData
	{
		// Token: 0x06002FA3 RID: 12195 RVA: 0x000C6A34 File Offset: 0x000C4C34
		public DialogueNodeData GetCopy()
		{
			DialogueNodeData dialogueNodeData = new DialogueNodeData();
			dialogueNodeData.Guid = this.Guid;
			dialogueNodeData.DialogueText = this.DialogueText;
			dialogueNodeData.DialogueNodeLabel = this.DialogueNodeLabel;
			dialogueNodeData.Position = this.Position;
			for (int i = 0; i < this.choices.Length; i++)
			{
				this.choices.CopyTo(dialogueNodeData.choices, 0);
			}
			dialogueNodeData.VoiceLine = this.VoiceLine;
			return dialogueNodeData;
		}

		// Token: 0x040021C1 RID: 8641
		public string Guid;

		// Token: 0x040021C2 RID: 8642
		public string DialogueText;

		// Token: 0x040021C3 RID: 8643
		public string DialogueNodeLabel;

		// Token: 0x040021C4 RID: 8644
		public Vector2 Position;

		// Token: 0x040021C5 RID: 8645
		public DialogueChoiceData[] choices;

		// Token: 0x040021C6 RID: 8646
		public EVOLineType VoiceLine;
	}
}
