using System;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x02000C48 RID: 3144
	[Serializable]
	public struct RenderLayer
	{
		// Token: 0x06005832 RID: 22578 RVA: 0x00171E10 File Offset: 0x00170010
		public RenderLayer(LayerMask mask, Color color)
		{
			this.mask = mask;
			this.color = color;
		}

		// Token: 0x04004150 RID: 16720
		public LayerMask mask;

		// Token: 0x04004151 RID: 16721
		public Color color;
	}
}
