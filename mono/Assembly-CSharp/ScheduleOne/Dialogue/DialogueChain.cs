using System;
using System.Linq;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006AB RID: 1707
	[Serializable]
	public class DialogueChain
	{
		// Token: 0x06002F17 RID: 12055 RVA: 0x000C50EF File Offset: 0x000C32EF
		public MessageChain GetMessageChain()
		{
			return new MessageChain
			{
				Messages = this.Lines.ToList<string>()
			};
		}

		// Token: 0x0400216B RID: 8555
		[TextArea(1, 10)]
		public string[] Lines;
	}
}
