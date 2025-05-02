using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006AC RID: 1708
	[CreateAssetMenu(fileName = "New Dialogue Database", menuName = "Dialogue/Dialogue Database")]
	[Serializable]
	public class DialogueDatabase : ScriptableObject
	{
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000C5107 File Offset: 0x000C3307
		private List<DialogueModule> runtimeModules
		{
			get
			{
				return this.handler.runtimeModules;
			}
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x000C5114 File Offset: 0x000C3314
		public void Initialize(DialogueHandler _handler)
		{
			this.handler = _handler;
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x000C5120 File Offset: 0x000C3320
		public DialogueModule GetModule(EDialogueModule moduleType)
		{
			if (this.runtimeModules == null)
			{
				Console.LogWarning("DialogueDatabase not initialized", null);
				return null;
			}
			DialogueModule dialogueModule = this.runtimeModules.Find((DialogueModule module) => module.ModuleType == moduleType);
			if (dialogueModule != null)
			{
				return dialogueModule;
			}
			return Singleton<DialogueManager>.Instance.Get(moduleType);
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000C5184 File Offset: 0x000C3384
		public DialogueChain GetChain(EDialogueModule moduleType, string key)
		{
			DialogueModule module = this.GetModule(moduleType);
			if (module == null)
			{
				Console.LogWarning("Could not find module: " + moduleType.ToString(), null);
				return null;
			}
			return module.GetChain(key);
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x000C51C8 File Offset: 0x000C33C8
		public bool HasChain(EDialogueModule moduleType, string key)
		{
			DialogueModule module = this.GetModule(moduleType);
			if (module == null)
			{
				Console.LogWarning("Could not find module: " + moduleType.ToString(), null);
				return false;
			}
			return module.HasChain(key);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x000C520C File Offset: 0x000C340C
		public string GetLine(EDialogueModule moduleType, string key)
		{
			DialogueModule module = this.GetModule(moduleType);
			if (module == null)
			{
				Console.LogWarning("Could not find module: " + moduleType.ToString(), null);
				return string.Empty;
			}
			return module.GetLine(key);
		}

		// Token: 0x0400216C RID: 8556
		public List<DialogueModule> Modules;

		// Token: 0x0400216D RID: 8557
		public List<Entry> GenericEntries = new List<Entry>();

		// Token: 0x0400216E RID: 8558
		private DialogueHandler handler;
	}
}
