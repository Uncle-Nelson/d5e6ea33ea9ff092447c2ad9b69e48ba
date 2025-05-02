using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006B RID: 107
	public sealed class TrackballAttribute : PropertyAttribute
	{
		// Token: 0x06000241 RID: 577 RVA: 0x0000D300 File Offset: 0x0000B500
		public TrackballAttribute(string method)
		{
			this.method = method;
		}

		// Token: 0x0400027F RID: 639
		public readonly string method;
	}
}
