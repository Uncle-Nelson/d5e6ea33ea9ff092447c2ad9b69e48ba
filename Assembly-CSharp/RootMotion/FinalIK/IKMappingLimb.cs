using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004E RID: 78
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		// Token: 0x0600029E RID: 670 RVA: 0x0001038C File Offset: 0x0000E58C
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return base.IsValid(solver, ref message) && base.BoneIsValid(this.bone1, solver, ref message, null) && base.BoneIsValid(this.bone2, solver, ref message, null) && base.BoneIsValid(this.bone3, solver, ref message, null);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000103E0 File Offset: 0x0000E5E0
		public IKMapping.BoneMap GetBoneMap(IKMappingLimb.BoneMapType boneMap)
		{
			switch (boneMap)
			{
			case IKMappingLimb.BoneMapType.Parent:
				if (this.parentBone == null)
				{
					Warning.Log("This limb does not have a parent (shoulder) bone", this.bone1, false);
				}
				return this.boneMapParent;
			case IKMappingLimb.BoneMapType.Bone1:
				return this.boneMap1;
			case IKMappingLimb.BoneMapType.Bone2:
				return this.boneMap2;
			default:
				return this.boneMap3;
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001043C File Offset: 0x0000E63C
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
			this.boneMap1.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone1.rotation) * Quaternion.LookRotation(this.bone2.position - this.bone1.position, this.bone1.rotation * -upper));
			this.boneMap2.defaultLocalTargetRotation = Quaternion.Inverse(Quaternion.Inverse(this.bone2.rotation) * Quaternion.LookRotation(this.bone3.position - this.bone2.position, this.bone2.rotation * -lower));
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00010500 File Offset: 0x0000E700
		public IKMappingLimb()
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00010554 File Offset: 0x0000E754
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null)
		{
			this.SetBones(bone1, bone2, bone3, parentBone);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000105B0 File Offset: 0x0000E7B0
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null)
		{
			this.bone1 = bone1;
			this.bone2 = bone2;
			this.bone3 = bone3;
			this.parentBone = parentBone;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000105CF File Offset: 0x0000E7CF
		public void StoreDefaultLocalState()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.StoreDefaultLocalState();
			}
			this.boneMap1.StoreDefaultLocalState();
			this.boneMap2.StoreDefaultLocalState();
			this.boneMap3.StoreDefaultLocalState();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001060B File Offset: 0x0000E80B
		public void FixTransforms()
		{
			if (this.parentBone != null)
			{
				this.boneMapParent.FixTransform(false);
			}
			this.boneMap1.FixTransform(true);
			this.boneMap2.FixTransform(false);
			this.boneMap3.FixTransform(false);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0001064C File Offset: 0x0000E84C
		public override void Initiate(IKSolverFullBody solver)
		{
			if (this.boneMapParent == null)
			{
				this.boneMapParent = new IKMapping.BoneMap();
			}
			if (this.boneMap1 == null)
			{
				this.boneMap1 = new IKMapping.BoneMap();
			}
			if (this.boneMap2 == null)
			{
				this.boneMap2 = new IKMapping.BoneMap();
			}
			if (this.boneMap3 == null)
			{
				this.boneMap3 = new IKMapping.BoneMap();
			}
			if (this.parentBone != null)
			{
				this.boneMapParent.Initiate(this.parentBone, solver);
			}
			this.boneMap1.Initiate(this.bone1, solver);
			this.boneMap2.Initiate(this.bone2, solver);
			this.boneMap3.Initiate(this.bone3, solver);
			this.boneMap1.SetPlane(solver, this.boneMap1.transform, this.boneMap2.transform, this.boneMap3.transform);
			this.boneMap2.SetPlane(solver, this.boneMap2.transform, this.boneMap3.transform, this.boneMap1.transform);
			if (this.parentBone != null)
			{
				this.boneMapParent.SetLocalSwingAxis(this.boneMap1);
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00010774 File Offset: 0x0000E974
		public void ReadPose()
		{
			this.boneMap1.UpdatePlane(this.updatePlaneRotations, true);
			this.boneMap2.UpdatePlane(this.updatePlaneRotations, false);
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			this.boneMap3.MaintainRotation();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000107CC File Offset: 0x0000E9CC
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (fullBody)
			{
				if (this.parentBone != null)
				{
					this.boneMapParent.Swing(solver.GetNode(this.boneMap1.chainIndex, this.boneMap1.nodeIndex).solverPosition, this.weight);
				}
				this.boneMap1.FixToNode(solver, this.weight, null);
			}
			this.boneMap1.RotateToPlane(solver, this.weight);
			this.boneMap2.RotateToPlane(solver, this.weight);
			this.boneMap3.RotateToMaintain(this.maintainRotationWeight * this.weight * solver.IKPositionWeight);
			this.boneMap3.RotateToEffector(solver, this.weight);
		}

		// Token: 0x0400020E RID: 526
		public Transform parentBone;

		// Token: 0x0400020F RID: 527
		public Transform bone1;

		// Token: 0x04000210 RID: 528
		public Transform bone2;

		// Token: 0x04000211 RID: 529
		public Transform bone3;

		// Token: 0x04000212 RID: 530
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x04000213 RID: 531
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x04000214 RID: 532
		[NonSerialized]
		public bool updatePlaneRotations = true;

		// Token: 0x04000215 RID: 533
		private IKMapping.BoneMap boneMapParent = new IKMapping.BoneMap();

		// Token: 0x04000216 RID: 534
		private IKMapping.BoneMap boneMap1 = new IKMapping.BoneMap();

		// Token: 0x04000217 RID: 535
		private IKMapping.BoneMap boneMap2 = new IKMapping.BoneMap();

		// Token: 0x04000218 RID: 536
		private IKMapping.BoneMap boneMap3 = new IKMapping.BoneMap();

		// Token: 0x020000E3 RID: 227
		[Serializable]
		public enum BoneMapType
		{
			// Token: 0x04000672 RID: 1650
			Parent,
			// Token: 0x04000673 RID: 1651
			Bone1,
			// Token: 0x04000674 RID: 1652
			Bone2,
			// Token: 0x04000675 RID: 1653
			Bone3
		}
	}
}
