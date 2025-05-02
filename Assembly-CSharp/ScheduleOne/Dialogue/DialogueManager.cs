using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006C0 RID: 1728
	public class DialogueManager : Singleton<DialogueManager>
	{
		// Token: 0x06002F81 RID: 12161 RVA: 0x000C66F0 File Offset: 0x000C48F0
		public DialogueModule Get(EDialogueModule moduleType)
		{
			DialogueModule dialogueModule = this.DefaultModules.Find((DialogueModule x) => x.ModuleType == moduleType);
			if (dialogueModule == null)
			{
				Debug.LogError("Generic module not found for: " + moduleType.ToString());
			}
			return dialogueModule;
		}

		// Token: 0x040021A2 RID: 8610
		public DialogueDatabase DefaultDatabase;

		// Token: 0x040021A3 RID: 8611
		public List<DialogueModule> DefaultModules = new List<DialogueModule>();
	}
}
