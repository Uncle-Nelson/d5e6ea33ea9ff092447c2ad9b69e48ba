using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004D RID: 77
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		// Token: 0x06000296 RID: 662 RVA: 0x000102BC File Offset: 0x0000E4BC
		public override bool IsValid(IKSolver solver, ref string message)
		{
			if (!base.IsValid(solver, ref message))
			{
				return false;
			}
			if (this.bone == null)
			{
				message = "IKMappingBone's bone is null.";
				return false;
			}
			return true;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000102E2 File Offset: 0x0000E4E2
		public IKMappingBone()
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00010300 File Offset: 0x0000E500
		public IKMappingBone(Transform bone)
		{
			this.bone = bone;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00010325 File Offset: 0x0000E525
		public void StoreDefaultLocalState()
		{
			this.boneMap.StoreDefaultLocalState();
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00010332 File Offset: 0x0000E532
		public void FixTransforms()
		{
			this.boneMap.FixTransform(false);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00010340 File Offset: 0x0000E540
		public override void Initiate(IKSolverFullBody solver)
		{
			if (this.boneMap == null)
			{
				this.boneMap = new IKMapping.BoneMap();
			}
			this.boneMap.Initiate(this.bone, solver);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00010367 File Offset: 0x0000E567
		public void ReadPose()
		{
			this.boneMap.MaintainRotation();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00010374 File Offset: 0x0000E574
		public void WritePose(float solverWeight)
		{
			this.boneMap.RotateToMaintain(solverWeight * this.maintainRotationWeight);
		}

		// Token: 0x0400020B RID: 523
		public Transform bone;

		// Token: 0x0400020C RID: 524
		[Range(0f, 1f)]
		public float maintainRotationWeight = 1f;

		// Token: 0x0400020D RID: 525
		private IKMapping.BoneMap boneMap = new IKMapping.BoneMap();
	}
}
