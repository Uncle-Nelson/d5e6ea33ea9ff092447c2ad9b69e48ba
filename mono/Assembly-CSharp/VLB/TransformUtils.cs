using System;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000150 RID: 336
	public static class TransformUtils
	{
		// Token: 0x06000652 RID: 1618 RVA: 0x0001CC00 File Offset: 0x0001AE00
		public static TransformUtils.Packed GetWorldPacked(this Transform self)
		{
			return new TransformUtils.Packed
			{
				position = self.position,
				rotation = self.rotation,
				lossyScale = self.lossyScale
			};
		}

		// Token: 0x02000151 RID: 337
		public struct Packed
		{
			// Token: 0x06000653 RID: 1619 RVA: 0x0001CC3D File Offset: 0x0001AE3D
			public bool IsSame(Transform transf)
			{
				return transf.position == this.position && transf.rotation == this.rotation && transf.lossyScale == this.lossyScale;
			}

			// Token: 0x0400074C RID: 1868
			public Vector3 position;

			// Token: 0x0400074D RID: 1869
			public Quaternion rotation;

			// Token: 0x0400074E RID: 1870
			public Vector3 lossyScale;
		}
	}
}
