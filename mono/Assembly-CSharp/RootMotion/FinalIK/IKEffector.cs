using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004B RID: 75
	[Serializable]
	public class IKEffector
	{
		// Token: 0x06000282 RID: 642 RVA: 0x0000F773 File Offset: 0x0000D973
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return solver.chain[this.chainIndex].nodes[this.nodeIndex];
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000F78E File Offset: 0x0000D98E
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0000F796 File Offset: 0x0000D996
		public bool isEndEffector { get; private set; }

		// Token: 0x06000285 RID: 645 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
		public void PinToBone(float positionWeight, float rotationWeight)
		{
			this.position = this.bone.position;
			this.positionWeight = Mathf.Clamp(positionWeight, 0f, 1f);
			this.rotation = this.bone.rotation;
			this.rotationWeight = Mathf.Clamp(rotationWeight, 0f, 1f);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public IKEffector()
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		public IKEffector(Transform bone, Transform[] childBones)
		{
			this.bone = bone;
			this.childBones = childBones;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000F95C File Offset: 0x0000DB5C
		public bool IsValid(IKSolver solver, ref string message)
		{
			if (this.bone == null)
			{
				message = "IK Effector bone is null.";
				return false;
			}
			if (solver.GetPoint(this.bone) == null)
			{
				message = "IK Effector is referencing to a bone '" + this.bone.name + "' that does not excist in the Node Chain.";
				return false;
			}
			Transform[] array = this.childBones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == null)
				{
					message = "IK Effector contains a null reference.";
					return false;
				}
			}
			foreach (Transform transform in this.childBones)
			{
				if (solver.GetPoint(transform) == null)
				{
					message = "IK Effector is referencing to a bone '" + transform.name + "' that does not excist in the Node Chain.";
					return false;
				}
			}
			if (this.planeBone1 != null && solver.GetPoint(this.planeBone1) == null)
			{
				message = "IK Effector is referencing to a bone '" + this.planeBone1.name + "' that does not excist in the Node Chain.";
				return false;
			}
			if (this.planeBone2 != null && solver.GetPoint(this.planeBone2) == null)
			{
				message = "IK Effector is referencing to a bone '" + this.planeBone2.name + "' that does not excist in the Node Chain.";
				return false;
			}
			if (this.planeBone3 != null && solver.GetPoint(this.planeBone3) == null)
			{
				message = "IK Effector is referencing to a bone '" + this.planeBone3.name + "' that does not excist in the Node Chain.";
				return false;
			}
			return true;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000FAC0 File Offset: 0x0000DCC0
		public void Initiate(IKSolverFullBody solver)
		{
			this.position = this.bone.position;
			this.rotation = this.bone.rotation;
			this.animatedPlaneRotation = Quaternion.identity;
			solver.GetChainAndNodeIndexes(this.bone, out this.chainIndex, out this.nodeIndex);
			this.childChainIndexes = new int[this.childBones.Length];
			this.childNodeIndexes = new int[this.childBones.Length];
			for (int i = 0; i < this.childBones.Length; i++)
			{
				solver.GetChainAndNodeIndexes(this.childBones[i], out this.childChainIndexes[i], out this.childNodeIndexes[i]);
			}
			this.localPositions = new Vector3[this.childBones.Length];
			this.usePlaneNodes = false;
			if (this.planeBone1 != null)
			{
				solver.GetChainAndNodeIndexes(this.planeBone1, out this.plane1ChainIndex, out this.plane1NodeIndex);
				if (this.planeBone2 != null)
				{
					solver.GetChainAndNodeIndexes(this.planeBone2, out this.plane2ChainIndex, out this.plane2NodeIndex);
					if (this.planeBone3 != null)
					{
						solver.GetChainAndNodeIndexes(this.planeBone3, out this.plane3ChainIndex, out this.plane3NodeIndex);
						this.usePlaneNodes = true;
					}
				}
				this.isEndEffector = true;
				return;
			}
			this.isEndEffector = false;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000FC14 File Offset: 0x0000DE14
		public void ResetOffset(IKSolverFullBody solver)
		{
			solver.GetNode(this.chainIndex, this.nodeIndex).offset = Vector3.zero;
			for (int i = 0; i < this.childChainIndexes.Length; i++)
			{
				solver.GetNode(this.childChainIndexes[i], this.childNodeIndexes[i]).offset = Vector3.zero;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000FC70 File Offset: 0x0000DE70
		public void SetToTarget()
		{
			if (this.target == null)
			{
				return;
			}
			this.position = this.target.position;
			this.rotation = this.target.rotation;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		public void OnPreSolve(IKSolverFullBody solver)
		{
			this.positionWeight = Mathf.Clamp(this.positionWeight, 0f, 1f);
			this.rotationWeight = Mathf.Clamp(this.rotationWeight, 0f, 1f);
			this.maintainRelativePositionWeight = Mathf.Clamp(this.maintainRelativePositionWeight, 0f, 1f);
			this.posW = this.positionWeight * solver.IKPositionWeight;
			this.rotW = this.rotationWeight * solver.IKPositionWeight;
			solver.GetNode(this.chainIndex, this.nodeIndex).effectorPositionWeight = this.posW;
			solver.GetNode(this.chainIndex, this.nodeIndex).effectorRotationWeight = this.rotW;
			solver.GetNode(this.chainIndex, this.nodeIndex).solverRotation = this.rotation;
			if (float.IsInfinity(this.positionOffset.x) || float.IsInfinity(this.positionOffset.y) || float.IsInfinity(this.positionOffset.z))
			{
				Debug.LogError("Invalid IKEffector.positionOffset (contains Infinity)! Please make sure not to set IKEffector.positionOffset to infinite values.", this.bone);
			}
			if (float.IsNaN(this.positionOffset.x) || float.IsNaN(this.positionOffset.y) || float.IsNaN(this.positionOffset.z))
			{
				Debug.LogError("Invalid IKEffector.positionOffset (contains NaN)! Please make sure not to set IKEffector.positionOffset to NaN values.", this.bone);
			}
			if (this.positionOffset.sqrMagnitude > 1E+10f)
			{
				Debug.LogError("Additive effector positionOffset detected in Full Body IK (extremely large value). Make sure you are not circularily adding to effector positionOffset each frame.", this.bone);
			}
			if (float.IsInfinity(this.position.x) || float.IsInfinity(this.position.y) || float.IsInfinity(this.position.z))
			{
				Debug.LogError("Invalid IKEffector.position (contains Infinity)!");
			}
			solver.GetNode(this.chainIndex, this.nodeIndex).offset += this.positionOffset * solver.IKPositionWeight;
			if (this.effectChildNodes && solver.iterations > 0)
			{
				for (int i = 0; i < this.childBones.Length; i++)
				{
					this.localPositions[i] = this.childBones[i].transform.position - this.bone.transform.position;
					solver.GetNode(this.childChainIndexes[i], this.childNodeIndexes[i]).offset += this.positionOffset * solver.IKPositionWeight;
				}
			}
			if (this.usePlaneNodes && this.maintainRelativePositionWeight > 0f)
			{
				this.animatedPlaneRotation = Quaternion.LookRotation(this.planeBone2.position - this.planeBone1.position, this.planeBone3.position - this.planeBone1.position);
			}
			this.firstUpdate = true;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000FF8E File Offset: 0x0000E18E
		public void OnPostWrite()
		{
			this.positionOffset = Vector3.zero;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000FF9C File Offset: 0x0000E19C
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			Vector3 solverPosition = solver.GetNode(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition;
			Vector3 solverPosition2 = solver.GetNode(this.plane2ChainIndex, this.plane2NodeIndex).solverPosition;
			Vector3 solverPosition3 = solver.GetNode(this.plane3ChainIndex, this.plane3NodeIndex).solverPosition;
			Vector3 vector = solverPosition2 - solverPosition;
			Vector3 upwards = solverPosition3 - solverPosition;
			if (vector == Vector3.zero)
			{
				Warning.Log("Make sure you are not placing 2 or more FBBIK effectors of the same chain to exactly the same position.", this.bone, false);
				return Quaternion.identity;
			}
			return Quaternion.LookRotation(vector, upwards);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001002C File Offset: 0x0000E22C
		public void Update(IKSolverFullBody solver)
		{
			if (this.firstUpdate)
			{
				this.animatedPosition = this.bone.position + solver.GetNode(this.chainIndex, this.nodeIndex).offset;
				this.firstUpdate = false;
			}
			solver.GetNode(this.chainIndex, this.nodeIndex).solverPosition = Vector3.Lerp(this.GetPosition(solver, out this.planeRotationOffset), this.position, this.posW);
			if (!this.effectChildNodes)
			{
				return;
			}
			for (int i = 0; i < this.childBones.Length; i++)
			{
				solver.GetNode(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition = Vector3.Lerp(solver.GetNode(this.childChainIndexes[i], this.childNodeIndexes[i]).solverPosition, solver.GetNode(this.chainIndex, this.nodeIndex).solverPosition + this.localPositions[i], this.posW);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00010130 File Offset: 0x0000E330
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			planeRotationOffset = Quaternion.identity;
			if (!this.isEndEffector)
			{
				return solver.GetNode(this.chainIndex, this.nodeIndex).solverPosition;
			}
			if (this.maintainRelativePositionWeight <= 0f)
			{
				return this.animatedPosition;
			}
			Vector3 a = this.bone.position;
			Vector3 point = a - this.planeBone1.position;
			planeRotationOffset = this.GetPlaneRotation(solver) * Quaternion.Inverse(this.animatedPlaneRotation);
			a = solver.GetNode(this.plane1ChainIndex, this.plane1NodeIndex).solverPosition + planeRotationOffset * point;
			planeRotationOffset = Quaternion.Lerp(Quaternion.identity, planeRotationOffset, this.maintainRelativePositionWeight);
			return Vector3.Lerp(this.animatedPosition, a + solver.GetNode(this.chainIndex, this.nodeIndex).offset, this.maintainRelativePositionWeight);
		}

		// Token: 0x040001EB RID: 491
		public Transform bone;

		// Token: 0x040001EC RID: 492
		public Transform target;

		// Token: 0x040001ED RID: 493
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x040001EE RID: 494
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x040001EF RID: 495
		public Vector3 position = Vector3.zero;

		// Token: 0x040001F0 RID: 496
		public Quaternion rotation = Quaternion.identity;

		// Token: 0x040001F1 RID: 497
		public Vector3 positionOffset;

		// Token: 0x040001F3 RID: 499
		public bool effectChildNodes = true;

		// Token: 0x040001F4 RID: 500
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		// Token: 0x040001F5 RID: 501
		public Transform[] childBones = new Transform[0];

		// Token: 0x040001F6 RID: 502
		public Transform planeBone1;

		// Token: 0x040001F7 RID: 503
		public Transform planeBone2;

		// Token: 0x040001F8 RID: 504
		public Transform planeBone3;

		// Token: 0x040001F9 RID: 505
		public Quaternion planeRotationOffset = Quaternion.identity;

		// Token: 0x040001FA RID: 506
		private float posW;

		// Token: 0x040001FB RID: 507
		private float rotW;

		// Token: 0x040001FC RID: 508
		private Vector3[] localPositions = new Vector3[0];

		// Token: 0x040001FD RID: 509
		private bool usePlaneNodes;

		// Token: 0x040001FE RID: 510
		private Quaternion animatedPlaneRotation = Quaternion.identity;

		// Token: 0x040001FF RID: 511
		private Vector3 animatedPosition;

		// Token: 0x04000200 RID: 512
		private bool firstUpdate;

		// Token: 0x04000201 RID: 513
		private int chainIndex = -1;

		// Token: 0x04000202 RID: 514
		private int nodeIndex = -1;

		// Token: 0x04000203 RID: 515
		private int plane1ChainIndex;

		// Token: 0x04000204 RID: 516
		private int plane1NodeIndex = -1;

		// Token: 0x04000205 RID: 517
		private int plane2ChainIndex = -1;

		// Token: 0x04000206 RID: 518
		private int plane2NodeIndex = -1;

		// Token: 0x04000207 RID: 519
		private int plane3ChainIndex = -1;

		// Token: 0x04000208 RID: 520
		private int plane3NodeIndex = -1;

		// Token: 0x04000209 RID: 521
		private int[] childChainIndexes = new int[0];

		// Token: 0x0400020A RID: 522
		private int[] childNodeIndexes = new int[0];
	}
}
