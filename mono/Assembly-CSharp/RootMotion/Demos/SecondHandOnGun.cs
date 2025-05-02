using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000089 RID: 137
	public class SecondHandOnGun : MonoBehaviour
	{
		// Token: 0x06000537 RID: 1335 RVA: 0x0002317C File Offset: 0x0002137C
		private void Start()
		{
			this.aim.enabled = false;
			this.leftArmIK.enabled = false;
			if (this.grounder != null)
			{
				this.grounder.ik.enabled = false;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000231B8 File Offset: 0x000213B8
		private void LateUpdate()
		{
			this.leftHandPosRelToRight = this.rightHand.InverseTransformPoint(this.leftHand.position);
			this.leftHandRotRelToRight = Quaternion.Inverse(this.rightHand.rotation) * this.leftHand.rotation;
			if (this.grounder != null)
			{
				this.grounder.ik.solver.Update();
			}
			this.aim.solver.Update();
			this.leftArmIK.solver.IKPosition = this.rightHand.TransformPoint(this.leftHandPosRelToRight + this.leftHandPositionOffset);
			this.leftArmIK.solver.IKRotation = this.rightHand.rotation * Quaternion.Euler(this.leftHandRotationOffset) * this.leftHandRotRelToRight;
			this.leftArmIK.solver.Update();
		}

		// Token: 0x040003F9 RID: 1017
		public AimIK aim;

		// Token: 0x040003FA RID: 1018
		public LimbIK leftArmIK;

		// Token: 0x040003FB RID: 1019
		public Transform leftHand;

		// Token: 0x040003FC RID: 1020
		public Transform rightHand;

		// Token: 0x040003FD RID: 1021
		public GrounderFBBIK grounder;

		// Token: 0x040003FE RID: 1022
		public Vector3 leftHandPositionOffset;

		// Token: 0x040003FF RID: 1023
		public Vector3 leftHandRotationOffset;

		// Token: 0x04000400 RID: 1024
		private Vector3 leftHandPosRelToRight;

		// Token: 0x04000401 RID: 1025
		private Quaternion leftHandRotRelToRight;
	}
}
