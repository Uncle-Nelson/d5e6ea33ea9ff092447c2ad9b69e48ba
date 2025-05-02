using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200006A RID: 106
	public sealed class MinAttribute : PropertyAttribute
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0000D2F1 File Offset: 0x0000B4F1
		public MinAttribute(float min)
		{
			this.min = min;
		}

		// Token: 0x0400027E RID: 638
		public readonly float min;
	}
}
