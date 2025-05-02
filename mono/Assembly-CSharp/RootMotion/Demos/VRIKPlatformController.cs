using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000BD RID: 189
	public class VRIKPlatformController : MonoBehaviour
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x00028A1C File Offset: 0x00026C1C
		private void LateUpdate()
		{
			if (this.platform != this.lastPlatform)
			{
				if (this.platform != null)
				{
					if (this.moveToPlatform)
					{
						this.lastPosition = this.ik.transform.position;
						this.lastRotation = this.ik.transform.rotation;
						this.ik.transform.position = this.platform.position;
						this.ik.transform.rotation = this.platform.rotation;
						this.trackingSpace.position = this.platform.position;
						this.trackingSpace.rotation = this.platform.rotation;
						this.ik.solver.AddPlatformMotion(this.platform.position - this.lastPosition, this.platform.rotation * Quaternion.Inverse(this.lastRotation), this.platform.position);
					}
					this.lastPosition = this.platform.position;
					this.lastRotation = this.platform.rotation;
				}
				this.ik.transform.parent = this.platform;
				this.trackingSpace.parent = this.platform;
				this.lastPlatform = this.platform;
			}
			if (this.platform != null)
			{
				this.ik.solver.AddPlatformMotion(this.platform.position - this.lastPosition, this.platform.rotation * Quaternion.Inverse(this.lastRotation), this.platform.position);
				this.lastRotation = this.platform.rotation;
				this.lastPosition = this.platform.position;
			}
		}

		// Token: 0x0400054D RID: 1357
		public VRIK ik;

		// Token: 0x0400054E RID: 1358
		public Transform trackingSpace;

		// Token: 0x0400054F RID: 1359
		public Transform platform;

		// Token: 0x04000550 RID: 1360
		public bool moveToPlatform = true;

		// Token: 0x04000551 RID: 1361
		private Transform lastPlatform;

		// Token: 0x04000552 RID: 1362
		private Vector3 lastPosition;

		// Token: 0x04000553 RID: 1363
		private Quaternion lastRotation = Quaternion.identity;
	}
}
