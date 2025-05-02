using System;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006AE RID: 1710
	[Serializable]
	public struct Entry
	{
		// Token: 0x06002F22 RID: 12066 RVA: 0x000C5278 File Offset: 0x000C3478
		public DialogueChain GetRandomChain()
		{
			if (this.Chains.Length == 0)
			{
				return null;
			}
			int num = Random.Range(0, this.Chains.Length);
			return this.Chains[num];
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x000C52A7 File Offset: 0x000C34A7
		public string GetRandomLine()
		{
			return this.GetRandomChain().Lines[0];
		}

		// Token: 0x04002170 RID: 8560
		public string Key;

		// Token: 0x04002171 RID: 8561
		public DialogueChain[] Chains;
	}
}
