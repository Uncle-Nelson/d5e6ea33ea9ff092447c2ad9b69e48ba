using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000408 RID: 1032
	[Serializable]
	public class MSGConversationData : SaveData
	{
		// Token: 0x0600157C RID: 5500 RVA: 0x0005FB47 File Offset: 0x0005DD47
		public MSGConversationData(int conversationIndex, bool read, TextMessageData[] messageHistory, TextResponseData[] activeResponses, bool isHidden)
		{
			this.ConversationIndex = conversationIndex;
			this.Read = read;
			this.MessageHistory = messageHistory;
			this.ActiveResponses = activeResponses;
			this.IsHidden = isHidden;
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0005FB74 File Offset: 0x0005DD74
		public MSGConversationData()
		{
			this.ConversationIndex = 0;
			this.Read = false;
			this.MessageHistory = new TextMessageData[0];
			this.ActiveResponses = new TextResponseData[0];
			this.IsHidden = false;
		}

		// Token: 0x040013D7 RID: 5079
		public int ConversationIndex;

		// Token: 0x040013D8 RID: 5080
		public bool Read;

		// Token: 0x040013D9 RID: 5081
		public TextMessageData[] MessageHistory;

		// Token: 0x040013DA RID: 5082
		public TextResponseData[] ActiveResponses;

		// Token: 0x040013DB RID: 5083
		public bool IsHidden;
	}
}
