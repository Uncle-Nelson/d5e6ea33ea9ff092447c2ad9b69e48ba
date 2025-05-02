using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000069 RID: 105
	public sealed class GetSetAttribute : PropertyAttribute
	{
		// Token: 0x0600023F RID: 575 RVA: 0x0000D2E2 File Offset: 0x0000B4E2
		public GetSetAttribute(string name)
		{
			this.name = name;
		}

		// Token: 0x0400027C RID: 636
		public readonly string name;

		// Token: 0x0400027D RID: 637
		public bool dirty;
	}
}
