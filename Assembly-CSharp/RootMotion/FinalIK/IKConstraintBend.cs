using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004A RID: 74
	[Serializable]
	public class IKConstraintBend
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0000F124 File Offset: 0x0000D324
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			if (this.bone1 == null || this.bone2 == null || this.bone3 == null)
			{
				if (logger != null)
				{
					logger("Bend Constraint contains a null reference.");
				}
				return false;
			}
			if (solver.GetPoint(this.bone1) == null)
			{
				if (logger != null)
				{
					logger("Bend Constraint is referencing to a bone '" + this.bone1.name + "' that does not excist in the Node Chain.");
				}
				return false;
			}
			if (solver.GetPoint(this.bone2) == null)
			{
				if (logger != null)
				{
					logger("Bend Constraint is referencing to a bone '" + this.bone2.name + "' that does not excist in the Node Chain.");
				}
				return false;
			}
			if (solver.GetPoint(this.bone3) == null)
			{
				if (logger != null)
				{
					logger("Bend Constraint is referencing to a bone '" + this.bone3.name + "' that does not excist in the Node Chain.");
				}
				return false;
			}
			return true;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000F205 File Offset: 0x0000D405
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0000F20D File Offset: 0x0000D40D
		public bool initiated { get; private set; }

		// Token: 0x06000279 RID: 633 RVA: 0x0000F216 File Offset: 0x0000D416
		public IKConstraintBend()
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000F234 File Offset: 0x0000D434
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
			this.SetBones(bone1, bone2, bone3);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000F25B File Offset: 0x0000D45B
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
			this.bone1 = bone1;
			this.bone2 = bone2;
			this.bone3 = bone3;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000F274 File Offset: 0x0000D474
		public void Initiate(IKSolverFullBody solver)
		{
			solver.GetChainAndNodeIndexes(this.bone1, out this.chainIndex1, out this.nodeIndex1);
			solver.GetChainAndNodeIndexes(this.bone2, out this.chainIndex2, out this.nodeIndex2);
			solver.GetChainAndNodeIndexes(this.bone3, out this.chainIndex3, out this.nodeIndex3);
			this.direction = this.OrthoToBone1(solver, this.OrthoToLimb(solver, this.bone2.position - this.bone1.position));
			if (!this.limbOrientationsSet)
			{
				this.defaultLocalDirection = Quaternion.Inverse(this.bone1.rotation) * this.direction;
				Vector3 point = Vector3.Cross((this.bone3.position - this.bone1.position).normalized, this.direction);
				this.defaultChildDirection = Quaternion.Inverse(this.bone3.rotation) * point;
			}
			this.initiated = true;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000F374 File Offset: 0x0000D574
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
			if (upper == Vector3.zero)
			{
				Debug.LogError("Attempting to set limb orientation to Vector3.zero axis");
			}
			if (lower == Vector3.zero)
			{
				Debug.LogError("Attempting to set limb orientation to Vector3.zero axis");
			}
			if (last == Vector3.zero)
			{
				Debug.LogError("Attempting to set limb orientation to Vector3.zero axis");
			}
			this.defaultLocalDirection = upper.normalized;
			this.defaultChildDirection = last.normalized;
			this.limbOrientationsSet = true;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000F3E8 File Offset: 0x0000D5E8
		public void LimitBend(float solverWeight, float positionWeight)
		{
			if (!this.initiated)
			{
				return;
			}
			Vector3 vector = this.bone1.rotation * -this.defaultLocalDirection;
			Vector3 fromDirection = this.bone3.position - this.bone2.position;
			bool flag = false;
			Vector3 toDirection = V3Tools.ClampDirection(fromDirection, vector, this.clampF * solverWeight, 0, out flag);
			Quaternion rotation = this.bone3.rotation;
			if (flag)
			{
				Quaternion lhs = Quaternion.FromToRotation(fromDirection, toDirection);
				this.bone2.rotation = lhs * this.bone2.rotation;
			}
			if (positionWeight > 0f)
			{
				Vector3 vector2 = this.bone2.position - this.bone1.position;
				Vector3 fromDirection2 = this.bone3.position - this.bone2.position;
				Vector3.OrthoNormalize(ref vector2, ref fromDirection2);
				Quaternion lhs2 = Quaternion.FromToRotation(fromDirection2, vector);
				this.bone2.rotation = Quaternion.Lerp(this.bone2.rotation, lhs2 * this.bone2.rotation, positionWeight * solverWeight);
			}
			if (flag || positionWeight > 0f)
			{
				this.bone3.rotation = rotation;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000F520 File Offset: 0x0000D720
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			if (!this.initiated)
			{
				return Vector3.zero;
			}
			float num = this.weight * solver.IKPositionWeight;
			if (this.bendGoal != null)
			{
				Vector3 lhs = this.bendGoal.position - solver.GetNode(this.chainIndex1, this.nodeIndex1).solverPosition;
				if (lhs != Vector3.zero)
				{
					this.direction = lhs;
				}
			}
			if (num >= 1f)
			{
				return this.direction.normalized;
			}
			Vector3 vector = solver.GetNode(this.chainIndex3, this.nodeIndex3).solverPosition - solver.GetNode(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3 vector2 = Quaternion.FromToRotation(this.bone3.position - this.bone1.position, vector) * (this.bone2.position - this.bone1.position);
			if (solver.GetNode(this.chainIndex3, this.nodeIndex3).effectorRotationWeight > 0f)
			{
				Vector3 b = -Vector3.Cross(vector, solver.GetNode(this.chainIndex3, this.nodeIndex3).solverRotation * this.defaultChildDirection);
				vector2 = Vector3.Lerp(vector2, b, solver.GetNode(this.chainIndex3, this.nodeIndex3).effectorRotationWeight);
			}
			if (this.rotationOffset != Quaternion.identity)
			{
				vector2 = Quaternion.FromToRotation(this.rotationOffset * vector, vector) * this.rotationOffset * vector2;
			}
			if (num <= 0f)
			{
				return vector2;
			}
			return Vector3.Lerp(vector2, this.direction.normalized, num);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000F6DC File Offset: 0x0000D8DC
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			Vector3 vector = solver.GetNode(this.chainIndex3, this.nodeIndex3).solverPosition - solver.GetNode(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			return tangent;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000F728 File Offset: 0x0000D928
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			Vector3 vector = solver.GetNode(this.chainIndex2, this.nodeIndex2).solverPosition - solver.GetNode(this.chainIndex1, this.nodeIndex1).solverPosition;
			Vector3.OrthoNormalize(ref vector, ref tangent);
			return tangent;
		}

		// Token: 0x040001D9 RID: 473
		public Transform bone1;

		// Token: 0x040001DA RID: 474
		public Transform bone2;

		// Token: 0x040001DB RID: 475
		public Transform bone3;

		// Token: 0x040001DC RID: 476
		public Transform bendGoal;

		// Token: 0x040001DD RID: 477
		public Vector3 direction = Vector3.right;

		// Token: 0x040001DE RID: 478
		public Quaternion rotationOffset;

		// Token: 0x040001DF RID: 479
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x040001E0 RID: 480
		public Vector3 defaultLocalDirection;

		// Token: 0x040001E1 RID: 481
		public Vector3 defaultChildDirection;

		// Token: 0x040001E2 RID: 482
		[NonSerialized]
		public float clampF = 0.505f;

		// Token: 0x040001E3 RID: 483
		private int chainIndex1;

		// Token: 0x040001E4 RID: 484
		private int nodeIndex1;

		// Token: 0x040001E5 RID: 485
		private int chainIndex2;

		// Token: 0x040001E6 RID: 486
		private int nodeIndex2;

		// Token: 0x040001E7 RID: 487
		private int chainIndex3;

		// Token: 0x040001E8 RID: 488
		private int nodeIndex3;

		// Token: 0x040001EA RID: 490
		private bool limbOrientationsSet;
	}
}
