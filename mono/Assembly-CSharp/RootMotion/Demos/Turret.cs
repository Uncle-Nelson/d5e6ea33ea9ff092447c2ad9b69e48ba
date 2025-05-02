using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B6 RID: 182
	public class Turret : MonoBehaviour
	{
		// Token: 0x060005F3 RID: 1523 RVA: 0x000282D4 File Offset: 0x000264D4
		private void Update()
		{
			Turret.Part[] array = this.parts;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].AimAt(this.target);
			}
		}

		// Token: 0x04000526 RID: 1318
		public Transform target;

		// Token: 0x04000527 RID: 1319
		public Turret.Part[] parts;

		// Token: 0x02000128 RID: 296
		[Serializable]
		public class Part
		{
			// Token: 0x0600083F RID: 2111 RVA: 0x00035C80 File Offset: 0x00033E80
			public void AimAt(Transform target)
			{
				this.transform.LookAt(target.position, this.transform.up);
				if (this.rotationLimit == null)
				{
					this.rotationLimit = this.transform.GetComponent<RotationLimit>();
					this.rotationLimit.Disable();
				}
				this.rotationLimit.Apply();
			}

			// Token: 0x04000882 RID: 2178
			public Transform transform;

			// Token: 0x04000883 RID: 2179
			private RotationLimit rotationLimit;
		}
	}
}
