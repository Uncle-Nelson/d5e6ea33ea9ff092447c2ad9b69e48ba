using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009DA RID: 2522
	[Serializable]
	public class DialogueChoiceEntry
	{
		// Token: 0x04003195 RID: 12693
		public GameObject gameObject;

		// Token: 0x04003196 RID: 12694
		public TextMeshProUGUI text;

		// Token: 0x04003197 RID: 12695
		public Button button;

		// Token: 0x04003198 RID: 12696
		public GameObject notPossibleGameObject;

		// Token: 0x04003199 RID: 12697
		public TextMeshProUGUI notPossibleText;

		// Token: 0x0400319A RID: 12698
		public CanvasGroup canvasGroup;
	}
}
