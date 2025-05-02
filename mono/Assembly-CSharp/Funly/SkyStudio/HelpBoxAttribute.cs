using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001E7 RID: 487
	public class HelpBoxAttribute : PropertyAttribute
	{
		// Token: 0x06000AD0 RID: 2768 RVA: 0x0002FF87 File Offset: 0x0002E187
		public HelpBoxAttribute(string text, HelpBoxMessageType messageType = HelpBoxMessageType.None)
		{
			this.text = text;
			this.messageType = messageType;
		}

		// Token: 0x04000BBA RID: 3002
		public string text;

		// Token: 0x04000BBB RID: 3003
		public HelpBoxMessageType messageType;
	}
}
