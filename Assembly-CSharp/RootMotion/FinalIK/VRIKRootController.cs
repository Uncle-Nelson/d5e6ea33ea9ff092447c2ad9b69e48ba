using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000085 RID: 133
	public class VRIKRootController : MonoBehaviour
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00022CA4 File Offset: 0x00020EA4
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00022CAC File Offset: 0x00020EAC
		public Vector3 pelvisTargetRight { get; private set; }

		// Token: 0x06000529 RID: 1321 RVA: 0x00022CB5 File Offset: 0x00020EB5
		private void Awake()
		{
			this.ik = base.GetComponent<VRIK>();
			IKSolverVR solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.OnPreUpdate));
			this.Calibrate();
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00022CF8 File Offset: 0x00020EF8
		public void Calibrate()
		{
			if (this.ik == null)
			{
				Debug.LogError("No VRIK found on VRIKRootController's GameObject.", base.transform);
				return;
			}
			this.pelvisTarget = this.ik.solver.spine.pelvisTarget;
			this.leftFootTarget = this.ik.solver.leftLeg.target;
			this.rightFootTarget = this.ik.solver.rightLeg.target;
			if (this.pelvisTarget != null)
			{
				this.pelvisTargetRight = Quaternion.Inverse(this.pelvisTarget.rotation) * this.ik.references.root.right;
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00022DB4 File Offset: 0x00020FB4
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
			if (this.ik == null)
			{
				Debug.LogError("No VRIK found on VRIKRootController's GameObject.", base.transform);
				return;
			}
			this.pelvisTarget = this.ik.solver.spine.pelvisTarget;
			this.leftFootTarget = this.ik.solver.leftLeg.target;
			this.rightFootTarget = this.ik.solver.rightLeg.target;
			if (this.pelvisTarget != null)
			{
				this.pelvisTargetRight = data.pelvisTargetRight;
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00022E4C File Offset: 0x0002104C
		private void OnPreUpdate()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.pelvisTarget != null)
			{
				this.ik.references.root.position = new Vector3(this.pelvisTarget.position.x, this.ik.references.root.position.y, this.pelvisTarget.position.z);
				Vector3 forward = Vector3.Cross(this.pelvisTarget.rotation * this.pelvisTargetRight, this.ik.references.root.up);
				forward.y = 0f;
				this.ik.references.root.rotation = Quaternion.LookRotation(forward);
				this.ik.references.pelvis.position = Vector3.Lerp(this.ik.references.pelvis.position, this.pelvisTarget.position, this.ik.solver.spine.pelvisPositionWeight);
				this.ik.references.pelvis.rotation = Quaternion.Slerp(this.ik.references.pelvis.rotation, this.pelvisTarget.rotation, this.ik.solver.spine.pelvisRotationWeight);
				return;
			}
			if (this.leftFootTarget != null && this.rightFootTarget != null)
			{
				this.ik.references.root.position = Vector3.Lerp(this.leftFootTarget.position, this.rightFootTarget.position, 0.5f);
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0002300F File Offset: 0x0002120F
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverVR solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.OnPreUpdate));
			}
		}

		// Token: 0x040003EF RID: 1007
		private Transform pelvisTarget;

		// Token: 0x040003F0 RID: 1008
		private Transform leftFootTarget;

		// Token: 0x040003F1 RID: 1009
		private Transform rightFootTarget;

		// Token: 0x040003F2 RID: 1010
		private VRIK ik;
	}
}
