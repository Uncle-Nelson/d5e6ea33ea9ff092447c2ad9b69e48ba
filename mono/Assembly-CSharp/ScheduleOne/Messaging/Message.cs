using System;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000545 RID: 1349
	[Serializable]
	public class Message
	{
		// Token: 0x060020D2 RID: 8402 RVA: 0x00086CBC File Offset: 0x00084EBC
		public Message()
		{
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00086CCB File Offset: 0x00084ECB
		public Message(string _text, Message.ESenderType _type, bool _endOfGroup = false, int _messageId = -1)
		{
			this.text = _text;
			this.sender = _type;
			this.endOfGroup = _endOfGroup;
			if (_messageId == -1)
			{
				this.messageId = Random.Range(int.MinValue, int.MaxValue);
			}
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00086D09 File Offset: 0x00084F09
		public Message(TextMessageData data)
		{
			this.text = data.Text;
			this.sender = (Message.ESenderType)data.Sender;
			this.endOfGroup = data.EndOfChain;
			this.messageId = data.MessageID;
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00086D48 File Offset: 0x00084F48
		public TextMessageData GetSaveData()
		{
			return new TextMessageData((int)this.sender, this.messageId, this.text, this.endOfGroup);
		}

		// Token: 0x04001957 RID: 6487
		public int messageId = -1;

		// Token: 0x04001958 RID: 6488
		public string text;

		// Token: 0x04001959 RID: 6489
		public Message.ESenderType sender;

		// Token: 0x0400195A RID: 6490
		public bool endOfGroup;

		// Token: 0x02000546 RID: 1350
		public enum ESenderType
		{
			// Token: 0x0400195C RID: 6492
			Player,
			// Token: 0x0400195D RID: 6493
			Other
		}
	}
}
