using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004C RID: 76
	[Serializable]
	public class IKMapping
	{
		// Token: 0x06000291 RID: 657 RVA: 0x0001022A File Offset: 0x0000E42A
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return true;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001022D File Offset: 0x0000E42D
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00010230 File Offset: 0x0000E430
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null)
		{
			if (bone == null)
			{
				message = "IKMappingLimb contains a null reference.";
				if (logger != null)
				{
					logger(message);
				}
				return false;
			}
			if (solver.GetPoint(bone) == null)
			{
				message = "IKMappingLimb is referencing to a bone '" + bone.name + "' that does not excist in the Node Chain.";
				if (logger != null)
				{
					logger(message);
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001028C File Offset: 0x0000E48C
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return pos2 + (pos1 - pos2).normalized * length;
		}

		// Token: 0x020000E2 RID: 226
		[Serializable]
		public class BoneMap
		{
			// Token: 0x060006B9 RID: 1721 RVA: 0x0002C978 File Offset: 0x0002AB78
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
				this.transform = transform;
				solver.GetChainAndNodeIndexes(transform, out this.chainIndex, out this.nodeIndex);
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060006BA RID: 1722 RVA: 0x0002C994 File Offset: 0x0002AB94
			public Vector3 swingDirection
			{
				get
				{
					return this.transform.rotation * this.localSwingAxis;
				}
			}

			// Token: 0x060006BB RID: 1723 RVA: 0x0002C9AC File Offset: 0x0002ABAC
			public void StoreDefaultLocalState()
			{
				this.defaultLocalPosition = this.transform.localPosition;
				this.defaultLocalRotation = this.transform.localRotation;
			}

			// Token: 0x060006BC RID: 1724 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
			public void FixTransform(bool position)
			{
				if (position)
				{
					this.transform.localPosition = this.defaultLocalPosition;
				}
				this.transform.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060006BD RID: 1725 RVA: 0x0002C9F7 File Offset: 0x0002ABF7
			public bool isNodeBone
			{
				get
				{
					return this.nodeIndex != -1;
				}
			}

			// Token: 0x060006BE RID: 1726 RVA: 0x0002CA05 File Offset: 0x0002AC05
			public void SetLength(IKMapping.BoneMap nextBone)
			{
				this.length = Vector3.Distance(this.transform.position, nextBone.transform.position);
			}

			// Token: 0x060006BF RID: 1727 RVA: 0x0002CA28 File Offset: 0x0002AC28
			public void SetLocalSwingAxis(IKMapping.BoneMap swingTarget)
			{
				this.SetLocalSwingAxis(swingTarget, this);
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x0002CA32 File Offset: 0x0002AC32
			public void SetLocalSwingAxis(IKMapping.BoneMap bone1, IKMapping.BoneMap bone2)
			{
				this.localSwingAxis = Quaternion.Inverse(this.transform.rotation) * (bone1.transform.position - bone2.transform.position);
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x0002CA6A File Offset: 0x0002AC6A
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
				Vector3.OrthoNormalize(ref normalDirection, ref twistDirection);
				this.localTwistAxis = Quaternion.Inverse(this.transform.rotation) * twistDirection;
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x0002CA94 File Offset: 0x0002AC94
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
				this.planeBone1 = planeBone1;
				this.planeBone2 = planeBone2;
				this.planeBone3 = planeBone3;
				solver.GetChainAndNodeIndexes(planeBone1, out this.plane1ChainIndex, out this.plane1NodeIndex);
				solver.GetChainAndNodeIndexes(planeBone2, out this.plane2ChainIndex, out this.plane2NodeIndex);
				solver.GetChainAndNodeIndexes(planeBone3, out this.plane3ChainIndex, out this.plane3NodeIndex);
				this.UpdatePlane(true, true);
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x0002CAFC File Offset: 0x0002ACFC
			public void UpdatePlane(bool rotation, bool position)
			{
				Quaternion lastAnimatedTargetRotation = this.lastAnimatedTargetRotation;
				if (rotation)
				{
					this.defaultLocalTargetRotation = QuaTools.RotationToLocalSpace(this.transform.rotation, lastAnimatedTargetRotation);
				}
				if (position)
				{
					this.planePosition = Quaternion.Inverse(lastAnimatedTargetRotation) * (this.transform.position - this.planeBone1.position);
				}
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x0002CB59 File Offset: 0x0002AD59
			public void SetIKPosition()
			{
				this.ikPosition = this.transform.position;
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x0002CB6C File Offset: 0x0002AD6C
			public void MaintainRotation()
			{
				this.maintainRotation = this.transform.rotation;
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x0002CB7F File Offset: 0x0002AD7F
			public void SetToIKPosition()
			{
				this.transform.position = this.ikPosition;
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x0002CB94 File Offset: 0x0002AD94
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null)
			{
				if (fixNode == null)
				{
					fixNode = solver.GetNode(this.chainIndex, this.nodeIndex);
				}
				if (weight >= 1f)
				{
					this.transform.position = fixNode.solverPosition;
					return;
				}
				this.transform.position = Vector3.Lerp(this.transform.position, fixNode.solverPosition, weight);
			}

			// Token: 0x060006C8 RID: 1736 RVA: 0x0002CBF4 File Offset: 0x0002ADF4
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return solver.GetNode(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + this.GetTargetRotation(solver) * this.planePosition;
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x0002CC24 File Offset: 0x0002AE24
			public void PositionToPlane(IKSolverFullBody solver)
			{
				this.transform.position = this.GetPlanePosition(solver);
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x0002CC38 File Offset: 0x0002AE38
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
				Quaternion quaternion = this.GetTargetRotation(solver) * this.defaultLocalTargetRotation;
				if (weight >= 1f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, weight);
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x0002CC8A File Offset: 0x0002AE8A
			public void Swing(Vector3 swingTarget, float weight)
			{
				this.Swing(swingTarget, this.transform.position, weight);
			}

			// Token: 0x060006CC RID: 1740 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localSwingAxis, pos1 - pos2) * this.transform.rotation;
				if (weight >= 1f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, weight);
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x0002CD14 File Offset: 0x0002AF14
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
				Vector3.OrthoNormalize(ref normalDirection, ref twistDirection);
				Quaternion quaternion = Quaternion.FromToRotation(this.transform.rotation * this.localTwistAxis, twistDirection) * this.transform.rotation;
				if (weight >= 1f)
				{
					this.transform.rotation = quaternion;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, quaternion, weight);
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x0002CD89 File Offset: 0x0002AF89
			public void RotateToMaintain(float weight)
			{
				if (weight <= 0f)
				{
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, this.maintainRotation, weight);
			}

			// Token: 0x060006CF RID: 1743 RVA: 0x0002CDB8 File Offset: 0x0002AFB8
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
				if (!this.isNodeBone)
				{
					return;
				}
				float num = weight * solver.GetNode(this.chainIndex, this.nodeIndex).effectorRotationWeight;
				if (num <= 0f)
				{
					return;
				}
				if (num >= 1f)
				{
					this.transform.rotation = solver.GetNode(this.chainIndex, this.nodeIndex).solverRotation;
					return;
				}
				this.transform.rotation = Quaternion.Lerp(this.transform.rotation, solver.GetNode(this.chainIndex, this.nodeIndex).solverRotation, num);
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x0002CE50 File Offset: 0x0002B050
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				Vector3 solverPosition = solver.GetNode(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
				Vector3 solverPosition2 = solver.GetNode(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
				Vector3 solverPosition3 = solver.GetNode(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
				if (solverPosition == solverPosition3)
				{
					return Quaternion.identity;
				}
				return Quaternion.LookRotation(solverPosition2 - solverPosition, solverPosition3 - solverPosition);
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0002CEC8 File Offset: 0x0002B0C8
			private Quaternion lastAnimatedTargetRotation
			{
				get
				{
					if (this.planeBone1.position == this.planeBone3.position)
					{
						return Quaternion.identity;
					}
					return Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
				}
			}

			// Token: 0x0400065B RID: 1627
			public Transform transform;

			// Token: 0x0400065C RID: 1628
			public int chainIndex = -1;

			// Token: 0x0400065D RID: 1629
			public int nodeIndex = -1;

			// Token: 0x0400065E RID: 1630
			public Vector3 defaultLocalPosition;

			// Token: 0x0400065F RID: 1631
			public Quaternion defaultLocalRotation;

			// Token: 0x04000660 RID: 1632
			public Vector3 localSwingAxis;

			// Token: 0x04000661 RID: 1633
			public Vector3 localTwistAxis;

			// Token: 0x04000662 RID: 1634
			public Vector3 planePosition;

			// Token: 0x04000663 RID: 1635
			public Vector3 ikPosition;

			// Token: 0x04000664 RID: 1636
			public Quaternion defaultLocalTargetRotation;

			// Token: 0x04000665 RID: 1637
			private Quaternion maintainRotation;

			// Token: 0x04000666 RID: 1638
			public float length;

			// Token: 0x04000667 RID: 1639
			public Quaternion animatedRotation;

			// Token: 0x04000668 RID: 1640
			private Transform planeBone1;

			// Token: 0x04000669 RID: 1641
			private Transform planeBone2;

			// Token: 0x0400066A RID: 1642
			private Transform planeBone3;

			// Token: 0x0400066B RID: 1643
			private int plane1ChainIndex = -1;

			// Token: 0x0400066C RID: 1644
			private int plane1NodeIndex = -1;

			// Token: 0x0400066D RID: 1645
			private int plane2ChainIndex = -1;

			// Token: 0x0400066E RID: 1646
			private int plane2NodeIndex = -1;

			// Token: 0x0400066F RID: 1647
			private int plane3ChainIndex = -1;

			// Token: 0x04000670 RID: 1648
			private int plane3NodeIndex = -1;
		}
	}
}
