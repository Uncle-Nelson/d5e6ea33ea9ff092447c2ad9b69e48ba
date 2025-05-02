using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200007F RID: 127
	public class OffsetPose : MonoBehaviour
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x00020A6C File Offset: 0x0001EC6C
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
			for (int i = 0; i < this.effectorLinks.Length; i++)
			{
				this.effectorLinks[i].Apply(solver, weight, solver.GetRoot().rotation);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
			for (int i = 0; i < this.effectorLinks.Length; i++)
			{
				this.effectorLinks[i].Apply(solver, weight, rotation);
			}
		}

		// Token: 0x040003CC RID: 972
		public OffsetPose.EffectorLink[] effectorLinks = new OffsetPose.EffectorLink[0];

		// Token: 0x02000115 RID: 277
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x06000804 RID: 2052 RVA: 0x00034818 File Offset: 0x00032A18
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
				solver.GetEffector(this.effector).positionOffset += rotation * this.offset * weight;
				Vector3 vector = solver.GetRoot().position + rotation * this.pin - solver.GetEffector(this.effector).bone.position;
				Vector3 vector2 = this.pinWeight * Mathf.Abs(weight);
				solver.GetEffector(this.effector).positionOffset = new Vector3(Mathf.Lerp(solver.GetEffector(this.effector).positionOffset.x, vector.x, vector2.x), Mathf.Lerp(solver.GetEffector(this.effector).positionOffset.y, vector.y, vector2.y), Mathf.Lerp(solver.GetEffector(this.effector).positionOffset.z, vector.z, vector2.z));
			}

			// Token: 0x04000807 RID: 2055
			public FullBodyBipedEffector effector;

			// Token: 0x04000808 RID: 2056
			public Vector3 offset;

			// Token: 0x04000809 RID: 2057
			public Vector3 pin;

			// Token: 0x0400080A RID: 2058
			public Vector3 pinWeight;
		}
	}
}
