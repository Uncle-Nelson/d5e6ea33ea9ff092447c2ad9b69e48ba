using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000436 RID: 1078
	[Serializable]
	public class TextMessageData
	{
		// Token: 0x060015B0 RID: 5552 RVA: 0x000603DD File Offset: 0x0005E5DD
		public TextMessageData(int sender, int messageID, string text, bool endOfChain)
		{
			this.Sender = sender;
			this.MessageID = messageID;
			this.Text = text;
			this.EndOfChain = endOfChain;
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00060402 File Offset: 0x0005E602
		public TextMessageData()
		{
			this.Sender = 0;
			this.MessageID = 0;
			this.Text = "";
			this.EndOfChain = false;
		}

		// Token: 0x0400146A RID: 5226
		public int Sender;

		// Token: 0x0400146B RID: 5227
		public int MessageID;

		// Token: 0x0400146C RID: 5228
		public string Text;

		// Token: 0x0400146D RID: 5229
		public bool EndOfChain;
	}
}
