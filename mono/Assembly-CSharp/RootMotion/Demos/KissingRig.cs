using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A3 RID: 163
	public class KissingRig : MonoBehaviour
	{
		// Token: 0x060005A6 RID: 1446 RVA: 0x000269D0 File Offset: 0x00024BD0
		private void Start()
		{
			this.partner1.Initiate();
			this.partner2.Initiate();
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000269E8 File Offset: 0x00024BE8
		private void LateUpdate()
		{
			for (int i = 0; i < this.iterations; i++)
			{
				this.partner1.Update(this.weight);
				this.partner2.Update(this.weight);
			}
		}

		// Token: 0x040004C8 RID: 1224
		public KissingRig.Partner partner1;

		// Token: 0x040004C9 RID: 1225
		public KissingRig.Partner partner2;

		// Token: 0x040004CA RID: 1226
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x040004CB RID: 1227
		[Range(1f, 4f)]
		public int iterations = 3;

		// Token: 0x02000120 RID: 288
		[Serializable]
		public class Partner
		{
			// Token: 0x06000819 RID: 2073 RVA: 0x00034EA1 File Offset: 0x000330A1
			public void Initiate()
			{
				this.ik.enabled = false;
			}

			// Token: 0x0600081A RID: 2074 RVA: 0x00034EB0 File Offset: 0x000330B0
			public void Update(float weight)
			{
				this.ik.solver.leftShoulderEffector.positionWeight = weight;
				this.ik.solver.rightShoulderEffector.positionWeight = weight;
				this.ik.solver.leftHandEffector.positionWeight = weight;
				this.ik.solver.rightHandEffector.positionWeight = weight;
				this.ik.solver.leftHandEffector.rotationWeight = weight;
				this.ik.solver.rightHandEffector.rotationWeight = weight;
				this.ik.solver.bodyEffector.positionWeight = weight;
				this.InverseTransformEffector(FullBodyBipedEffector.LeftShoulder, this.mouth, this.mouthTarget.position, weight);
				this.InverseTransformEffector(FullBodyBipedEffector.RightShoulder, this.mouth, this.mouthTarget.position, weight);
				this.InverseTransformEffector(FullBodyBipedEffector.Body, this.mouth, this.mouthTarget.position, weight);
				this.ik.solver.bodyEffector.position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.position.x, this.ik.solver.bodyEffector.bone.position.y, this.ik.solver.bodyEffector.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightVertical * weight);
				this.ik.solver.bodyEffector.position = Vector3.Lerp(new Vector3(this.ik.solver.bodyEffector.bone.position.x, this.ik.solver.bodyEffector.position.y, this.ik.solver.bodyEffector.bone.position.z), this.ik.solver.bodyEffector.position, this.bodyWeightHorizontal * weight);
				this.ik.solver.leftHandEffector.position = this.touchTargetLeftHand.position;
				this.ik.solver.rightHandEffector.position = this.touchTargetRightHand.position;
				this.ik.solver.leftHandEffector.rotation = this.touchTargetLeftHand.rotation;
				this.ik.solver.rightHandEffector.rotation = this.touchTargetRightHand.rotation;
				this.neckRotation = this.neck.rotation;
				this.ik.solver.Update();
				this.neck.rotation = Quaternion.Slerp(this.neck.rotation, this.neckRotation, this.neckRotationWeight * weight);
				this.ik.references.head.localRotation = Quaternion.AngleAxis(this.headTiltAngle * weight, this.headTiltAxis) * this.ik.references.head.localRotation;
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x0600081B RID: 2075 RVA: 0x000351D1 File Offset: 0x000333D1
			private Transform neck
			{
				get
				{
					return this.ik.solver.spineMapping.spineBones[this.ik.solver.spineMapping.spineBones.Length - 1];
				}
			}

			// Token: 0x0600081C RID: 2076 RVA: 0x00035204 File Offset: 0x00033404
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
				Vector3 b = this.ik.solver.GetEffector(effector).bone.position - target.position;
				this.ik.solver.GetEffector(effector).position = Vector3.Lerp(this.ik.solver.GetEffector(effector).bone.position, targetPosition + b, weight);
			}

			// Token: 0x0400084D RID: 2125
			public FullBodyBipedIK ik;

			// Token: 0x0400084E RID: 2126
			public Transform mouth;

			// Token: 0x0400084F RID: 2127
			public Transform mouthTarget;

			// Token: 0x04000850 RID: 2128
			public Transform touchTargetLeftHand;

			// Token: 0x04000851 RID: 2129
			public Transform touchTargetRightHand;

			// Token: 0x04000852 RID: 2130
			public float bodyWeightHorizontal = 0.4f;

			// Token: 0x04000853 RID: 2131
			public float bodyWeightVertical = 1f;

			// Token: 0x04000854 RID: 2132
			public float neckRotationWeight = 0.3f;

			// Token: 0x04000855 RID: 2133
			public float headTiltAngle = 10f;

			// Token: 0x04000856 RID: 2134
			public Vector3 headTiltAxis;

			// Token: 0x04000857 RID: 2135
			private Quaternion neckRotation;
		}
	}
}
