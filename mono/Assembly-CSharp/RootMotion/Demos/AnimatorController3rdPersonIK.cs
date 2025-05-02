using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000093 RID: 147
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		// Token: 0x06000566 RID: 1382 RVA: 0x00024A30 File Offset: 0x00022C30
		protected override void Start()
		{
			base.Start();
			this.aim = base.GetComponent<AimIK>();
			this.ik = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreRead, new IKSolver.UpdateDelegate(this.OnPreRead));
			this.aim.enabled = false;
			this.ik.enabled = false;
			this.headLookAxis = this.ik.references.head.InverseTransformVector(this.ik.references.root.forward);
			this.animator.SetLayerWeight(1, 1f);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00024AE0 File Offset: 0x00022CE0
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
			base.Move(moveInput, isMoving, faceDirection, aimTarget);
			this.aimTarget = aimTarget;
			this.Read();
			this.AimIK();
			this.FBBIK();
			this.AimIK();
			this.HeadLookAt(aimTarget);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00024B18 File Offset: 0x00022D18
		private void Read()
		{
			this.leftHandPosRelToRightHand = this.ik.references.rightHand.InverseTransformPoint(this.ik.references.leftHand.position);
			this.leftHandRotRelToRightHand = Quaternion.Inverse(this.ik.references.rightHand.rotation) * this.ik.references.leftHand.rotation;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00024B8F File Offset: 0x00022D8F
		private void AimIK()
		{
			this.aim.solver.IKPosition = this.aimTarget;
			this.aim.solver.Update();
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00024BB8 File Offset: 0x00022DB8
		private void FBBIK()
		{
			this.rightHandRotation = this.ik.references.rightHand.rotation;
			Vector3 b = this.ik.references.rightHand.rotation * this.gunHoldOffset;
			this.ik.solver.rightHandEffector.positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.SetHandRotations(this.rightHandRotation * this.leftHandRotRelToRightHand, this.rightHandRotation);
			}
			this.ik.solver.Update();
			if (this.recoil != null)
			{
				this.ik.references.rightHand.rotation = this.recoil.rotationOffset * this.rightHandRotation;
				this.ik.references.leftHand.rotation = this.recoil.rotationOffset * this.rightHandRotation * this.leftHandRotRelToRightHand;
				return;
			}
			this.ik.references.rightHand.rotation = this.rightHandRotation;
			this.ik.references.leftHand.rotation = this.rightHandRotation * this.leftHandRotRelToRightHand;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00024D14 File Offset: 0x00022F14
		private void OnPreRead()
		{
			Quaternion rotation = (this.recoil != null) ? (this.recoil.rotationOffset * this.rightHandRotation) : this.rightHandRotation;
			Vector3 a = this.ik.references.rightHand.position + this.ik.solver.rightHandEffector.positionOffset + rotation * this.leftHandPosRelToRightHand;
			this.ik.solver.leftHandEffector.positionOffset += a - this.ik.references.leftHand.position - this.ik.solver.leftHandEffector.positionOffset + rotation * this.leftHandOffset;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00024DF8 File Offset: 0x00022FF8
		private void HeadLookAt(Vector3 lookAtTarget)
		{
			Quaternion b = Quaternion.FromToRotation(this.ik.references.head.rotation * this.headLookAxis, lookAtTarget - this.ik.references.head.position);
			this.ik.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.ik.references.head.rotation;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00024E86 File Offset: 0x00023086
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreRead, new IKSolver.UpdateDelegate(this.OnPreRead));
			}
		}

		// Token: 0x04000460 RID: 1120
		[Range(0f, 1f)]
		public float headLookWeight = 1f;

		// Token: 0x04000461 RID: 1121
		public Vector3 gunHoldOffset;

		// Token: 0x04000462 RID: 1122
		public Vector3 leftHandOffset;

		// Token: 0x04000463 RID: 1123
		public Recoil recoil;

		// Token: 0x04000464 RID: 1124
		private AimIK aim;

		// Token: 0x04000465 RID: 1125
		private FullBodyBipedIK ik;

		// Token: 0x04000466 RID: 1126
		private Vector3 headLookAxis;

		// Token: 0x04000467 RID: 1127
		private Vector3 leftHandPosRelToRightHand;

		// Token: 0x04000468 RID: 1128
		private Quaternion leftHandRotRelToRightHand;

		// Token: 0x04000469 RID: 1129
		private Vector3 aimTarget;

		// Token: 0x0400046A RID: 1130
		private Quaternion rightHandRotation;
	}
}
