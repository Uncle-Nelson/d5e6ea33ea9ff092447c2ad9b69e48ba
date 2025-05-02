using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000BC RID: 188
	public class VRIKPlatform : MonoBehaviour
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x00028968 File Offset: 0x00026B68
		private void OnEnable()
		{
			this.lastPosition = base.transform.position;
			this.lastRotation = base.transform.rotation;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0002898C File Offset: 0x00026B8C
		private void LateUpdate()
		{
			this.ik.solver.AddPlatformMotion(base.transform.position - this.lastPosition, base.transform.rotation * Quaternion.Inverse(this.lastRotation), base.transform.position);
			this.lastRotation = base.transform.rotation;
			this.lastPosition = base.transform.position;
		}

		// Token: 0x0400054A RID: 1354
		public VRIK ik;

		// Token: 0x0400054B RID: 1355
		private Vector3 lastPosition;

		// Token: 0x0400054C RID: 1356
		private Quaternion lastRotation = Quaternion.identity;
	}
}
