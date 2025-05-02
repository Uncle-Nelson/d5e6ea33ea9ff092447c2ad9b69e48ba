using System;

namespace VLB
{
	// Token: 0x02000133 RID: 307
	public class MinMaxRangeAttribute : Attribute
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x000195FE File Offset: 0x000177FE
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00019606 File Offset: 0x00017806
		public float minValue { get; private set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001960F File Offset: 0x0001780F
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00019617 File Offset: 0x00017817
		public float maxValue { get; private set; }

		// Token: 0x06000538 RID: 1336 RVA: 0x00019620 File Offset: 0x00017820
		public MinMaxRangeAttribute(float min, float max)
		{
			this.minValue = min;
			this.maxValue = max;
		}
	}
}
