using System;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006AF RID: 1711
	[Serializable]
	public class DialogueEvent
	{
		// Token: 0x04002172 RID: 8562
		public DialogueContainer Dialogue;

		// Token: 0x04002173 RID: 8563
		public UnityEvent onDialogueEnded;

		// Token: 0x04002174 RID: 8564
		public DialogueNodeEvent[] NodeEvents;
	}
}
