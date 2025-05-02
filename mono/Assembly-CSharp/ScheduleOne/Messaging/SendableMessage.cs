using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000555 RID: 1365
	public class SendableMessage
	{
		// Token: 0x06002176 RID: 8566 RVA: 0x00089E63 File Offset: 0x00088063
		public SendableMessage(string text, MSGConversation conversation)
		{
			this.Text = text;
			this.conversation = conversation;
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x00089E84 File Offset: 0x00088084
		public virtual bool ShouldShow()
		{
			return this.ShouldShowCheck == null || this.ShouldShowCheck(this);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00089E9C File Offset: 0x0008809C
		public virtual bool IsValid(out string invalidReason)
		{
			if (this.IsValidCheck != null)
			{
				return this.IsValidCheck(this, out invalidReason);
			}
			invalidReason = "";
			return true;
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00089EBC File Offset: 0x000880BC
		public virtual void Send(bool network, int id = -1)
		{
			if (id != -1)
			{
				if (this.sentIDs.Contains(id))
				{
					return;
				}
			}
			else
			{
				id = Random.Range(0, int.MaxValue);
			}
			if (this.onSelected != null)
			{
				this.onSelected();
			}
			if (this.disableDefaultSendBehaviour)
			{
				return;
			}
			if (network)
			{
				this.conversation.SendPlayerMessage(this.conversation.Sendables.IndexOf(this), id, true);
				return;
			}
			this.sentIDs.Add(id);
			this.conversation.RenderPlayerMessage(this);
			if (this.onSent != null)
			{
				this.onSent();
			}
		}

		// Token: 0x040019A5 RID: 6565
		public string Text;

		// Token: 0x040019A6 RID: 6566
		public SendableMessage.BoolCheck ShouldShowCheck;

		// Token: 0x040019A7 RID: 6567
		public SendableMessage.ValidityCheck IsValidCheck;

		// Token: 0x040019A8 RID: 6568
		public Action onSelected;

		// Token: 0x040019A9 RID: 6569
		public Action onSent;

		// Token: 0x040019AA RID: 6570
		private MSGConversation conversation;

		// Token: 0x040019AB RID: 6571
		public bool disableDefaultSendBehaviour;

		// Token: 0x040019AC RID: 6572
		private List<int> sentIDs = new List<int>();

		// Token: 0x02000556 RID: 1366
		// (Invoke) Token: 0x0600217B RID: 8571
		public delegate bool BoolCheck(SendableMessage message);

		// Token: 0x02000557 RID: 1367
		// (Invoke) Token: 0x0600217F RID: 8575
		public delegate bool ValidityCheck(SendableMessage message, out string invalidReason);
	}
}
