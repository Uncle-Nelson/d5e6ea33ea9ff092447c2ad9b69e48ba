using System;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006B0 RID: 1712
	[Serializable]
	public class DialogueNodeEvent
	{
		// Token: 0x04002175 RID: 8565
		public string NodeLabel;

		// Token: 0x04002176 RID: 8566
		public UnityEvent onNodeDisplayed;
	}
}
