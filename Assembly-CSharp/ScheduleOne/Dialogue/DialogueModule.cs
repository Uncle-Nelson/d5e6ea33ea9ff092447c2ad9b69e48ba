using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006C2 RID: 1730
	public class DialogueModule : MonoBehaviour
	{
		// Token: 0x06002F85 RID: 12165 RVA: 0x000C6770 File Offset: 0x000C4970
		public Entry GetEntry(string key)
		{
			return this.Entries.Find((Entry x) => x.Key == key);
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x000C67A4 File Offset: 0x000C49A4
		public DialogueChain GetChain(string key)
		{
			Entry entry = this.GetEntry(key);
			if (entry.Chains == null || entry.Chains.Length == 0)
			{
				Debug.LogError("DialogueModule.Get: No lines found for key: " + key);
			}
			return entry.GetRandomChain();
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x000C67E1 File Offset: 0x000C49E1
		public bool HasChain(string key)
		{
			return this.GetEntry(key).Chains != null;
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x000C67F4 File Offset: 0x000C49F4
		public string GetLine(string key)
		{
			Entry entry = this.GetEntry(key);
			if (entry.Chains == null || entry.Chains.Length == 0)
			{
				Debug.LogError("DialogueModule.Get: No lines found for key: " + key);
				return string.Empty;
			}
			return entry.GetRandomLine();
		}

		// Token: 0x040021A5 RID: 8613
		public EDialogueModule ModuleType;

		// Token: 0x040021A6 RID: 8614
		public List<Entry> Entries = new List<Entry>();
	}
}
