using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000021 RID: 33
	public class LargeHeader : PropertyAttribute
	{
		// Token: 0x060000FD RID: 253 RVA: 0x000073BA File Offset: 0x000055BA
		public LargeHeader(string name)
		{
			this.name = name;
			this.color = "white";
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000073DF File Offset: 0x000055DF
		public LargeHeader(string name, string color)
		{
			this.name = name;
			this.color = color;
		}

		// Token: 0x040000D8 RID: 216
		public string name;

		// Token: 0x040000D9 RID: 217
		public string color = "white";
	}
}
