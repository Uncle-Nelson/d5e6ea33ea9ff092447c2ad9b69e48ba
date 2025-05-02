using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000082 RID: 130
	public class ShoulderRotator : MonoBehaviour
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x00021234 File Offset: 0x0001F434
		private void Start()
		{
			this.ik = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.RotateShoulders));
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00021270 File Offset: 0x0001F470
		private void RotateShoulders()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 0f)
			{
				return;
			}
			if (this.skip)
			{
				this.skip = false;
				return;
			}
			this.RotateShoulder(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.RotateShoulder(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.skip = true;
			this.ik.solver.Update();
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000212F4 File Offset: 0x0001F4F4
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
			Quaternion b = Quaternion.FromToRotation(this.GetParentBoneMap(chain).swingDirection, this.ik.solver.GetEndEffector(chain).position - this.GetParentBoneMap(chain).transform.position);
			Vector3 vector = this.ik.solver.GetEndEffector(chain).position - this.ik.solver.GetLimbMapping(chain).bone1.position;
			float num = this.ik.solver.GetChain(chain).nodes[0].length + this.ik.solver.GetChain(chain).nodes[1].length;
			float num2 = vector.magnitude / num - 1f + offset;
			num2 = Mathf.Clamp(num2 * weight, 0f, 1f);
			Quaternion lhs = Quaternion.Lerp(Quaternion.identity, b, num2 * this.ik.solver.GetEndEffector(chain).positionWeight * this.ik.solver.IKPositionWeight);
			this.ik.solver.GetLimbMapping(chain).parentBone.rotation = lhs * this.ik.solver.GetLimbMapping(chain).parentBone.rotation;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0002144A File Offset: 0x0001F64A
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return this.ik.solver.GetLimbMapping(chain).GetBoneMap(IKMappingLimb.BoneMapType.Parent);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00021463 File Offset: 0x0001F663
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.RotateShoulders));
			}
		}

		// Token: 0x040003E6 RID: 998
		[Tooltip("Weight of shoulder rotation")]
		public float weight = 1.5f;

		// Token: 0x040003E7 RID: 999
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset = 0.2f;

		// Token: 0x040003E8 RID: 1000
		private FullBodyBipedIK ik;

		// Token: 0x040003E9 RID: 1001
		private bool skip;
	}
}
