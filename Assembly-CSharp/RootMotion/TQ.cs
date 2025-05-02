using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000007 RID: 7
	public class TQ
	{
		// Token: 0x06000028 RID: 40 RVA: 0x0000256E File Offset: 0x0000076E
		public TQ()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002576 File Offset: 0x00000776
		public TQ(Vector3 translation, Quaternion rotation)
		{
			this.t = translation;
			this.q = rotation;
		}

		// Token: 0x04000020 RID: 32
		public Vector3 t;

		// Token: 0x04000021 RID: 33
		public Quaternion q;
	}
}
