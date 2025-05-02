using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000AC2 RID: 2754
	[Serializable]
	public class MessageChain
	{
		// Token: 0x06004A18 RID: 18968 RVA: 0x00136C07 File Offset: 0x00134E07
		public static MessageChain Combine(MessageChain a, MessageChain b)
		{
			MessageChain messageChain = new MessageChain();
			messageChain.Messages.AddRange(a.Messages);
			messageChain.Messages.AddRange(b.Messages);
			return messageChain;
		}

		// Token: 0x04003745 RID: 14149
		[TextArea(2, 10)]
		public List<string> Messages = new List<string>();

		// Token: 0x04003746 RID: 14150
		[HideInInspector]
		public int id = -1;
	}
}
