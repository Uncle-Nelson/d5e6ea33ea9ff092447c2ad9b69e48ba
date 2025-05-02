using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000018 RID: 24
	public class InspectorComment : PropertyAttribute
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00006765 File Offset: 0x00004965
		public InspectorComment(string name)
		{
			this.name = name;
			this.color = "white";
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000678A File Offset: 0x0000498A
		public InspectorComment(string name, string color)
		{
			this.name = name;
			this.color = color;
		}

		// Token: 0x040000AD RID: 173
		public string name;

		// Token: 0x040000AE RID: 174
		public string color = "white";
	}
}
