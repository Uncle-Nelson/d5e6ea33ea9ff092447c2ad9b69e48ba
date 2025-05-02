using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200009F RID: 159
	public class HoldingHands : MonoBehaviour
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x00026468 File Offset: 0x00024668
		private void Start()
		{
			this.rightHandRotation = Quaternion.Inverse(this.rightHandChar.solver.rightHandEffector.bone.rotation) * base.transform.rotation;
			this.leftHandRotation = Quaternion.Inverse(this.leftHandChar.solver.leftHandEffector.bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000264E0 File Offset: 0x000246E0
		private void LateUpdate()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.rightHandEffector.bone.position, this.leftHandChar.solver.leftHandEffector.bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.rightHandEffector.bone.rotation * this.rightHandRotation, this.leftHandChar.solver.leftHandEffector.bone.rotation * this.leftHandRotation, this.crossFade);
			this.rightHandChar.solver.rightHandEffector.position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.leftHandChar.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x040004B1 RID: 1201
		public FullBodyBipedIK rightHandChar;

		// Token: 0x040004B2 RID: 1202
		public FullBodyBipedIK leftHandChar;

		// Token: 0x040004B3 RID: 1203
		public Transform rightHandTarget;

		// Token: 0x040004B4 RID: 1204
		public Transform leftHandTarget;

		// Token: 0x040004B5 RID: 1205
		public float crossFade;

		// Token: 0x040004B6 RID: 1206
		public float speed = 10f;

		// Token: 0x040004B7 RID: 1207
		private Quaternion rightHandRotation;

		// Token: 0x040004B8 RID: 1208
		private Quaternion leftHandRotation;
	}
}
