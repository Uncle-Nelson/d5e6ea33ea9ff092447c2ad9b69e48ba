using System;
using FishNet.Serializing.Helping;

namespace ScheduleOne.Messaging
{
	// Token: 0x02000554 RID: 1364
	[Serializable]
	public class Response
	{
		// Token: 0x06002174 RID: 8564 RVA: 0x00089E3E File Offset: 0x0008803E
		public Response(string _text, string _label, Action _callback = null, bool _disableDefaultResponseBehaviour = false)
		{
			this.text = _text;
			this.label = _label;
			this.callback = _callback;
			this.disableDefaultResponseBehaviour = _disableDefaultResponseBehaviour;
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0000494F File Offset: 0x00002B4F
		public Response()
		{
		}

		// Token: 0x040019A1 RID: 6561
		public string text;

		// Token: 0x040019A2 RID: 6562
		public string label;

		// Token: 0x040019A3 RID: 6563
		[CodegenExclude]
		public Action callback;

		// Token: 0x040019A4 RID: 6564
		public bool disableDefaultResponseBehaviour;
	}
}
