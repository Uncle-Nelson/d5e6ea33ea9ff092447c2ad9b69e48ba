using System;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000544 RID: 1348
	public interface IMessageEntity
	{
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060020CE RID: 8398
		// (set) Token: 0x060020CF RID: 8399
		MSGConversation MsgConversation { get; set; }

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060020D0 RID: 8400
		// (remove) Token: 0x060020D1 RID: 8401
		event ResponseCallback onResponseChosen;
	}
}
