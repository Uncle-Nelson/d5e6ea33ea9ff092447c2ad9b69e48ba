using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000049 RID: 73
	[Serializable]
	public class FBIKChain
	{
		// Token: 0x06000262 RID: 610 RVA: 0x0000E1E4 File Offset: 0x0000C3E4
		public FBIKChain()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000E24C File Offset: 0x0000C44C
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
			this.pin = pin;
			this.pull = pull;
			this.SetNodes(nodeTransforms);
			this.children = new int[0];
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		public void SetNodes(params Transform[] boneTransforms)
		{
			this.nodes = new IKSolver.Node[boneTransforms.Length];
			for (int i = 0; i < boneTransforms.Length; i++)
			{
				this.nodes[i] = new IKSolver.Node(boneTransforms[i]);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000E310 File Offset: 0x0000C510
		public int GetNodeIndex(Transform boneTransform)
		{
			for (int i = 0; i < this.nodes.Length; i++)
			{
				if (this.nodes[i].transform == boneTransform)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000E348 File Offset: 0x0000C548
		public bool IsValid(ref string message)
		{
			if (this.nodes.Length == 0)
			{
				message = "FBIK chain contains no nodes.";
				return false;
			}
			IKSolver.Node[] array = this.nodes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					message = "Node transform is null in FBIK chain.";
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000E398 File Offset: 0x0000C598
		public void Initiate(IKSolverFullBody solver)
		{
			this.initiated = false;
			foreach (IKSolver.Node node in this.nodes)
			{
				node.solverPosition = node.transform.position;
			}
			this.CalculateBoneLengths(solver);
			FBIKChain.ChildConstraint[] array2 = this.childConstraints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Initiate(solver);
			}
			if (this.nodes.Length == 3)
			{
				this.bendConstraint.SetBones(this.nodes[0].transform, this.nodes[1].transform, this.nodes[2].transform);
				this.bendConstraint.Initiate(solver);
			}
			this.crossFades = new float[this.children.Length];
			this.initiated = true;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000E45C File Offset: 0x0000C65C
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.nodes.Length; i++)
			{
				this.nodes[i].solverPosition = this.nodes[i].transform.position + this.nodes[i].offset;
			}
			this.CalculateBoneLengths(solver);
			if (fullBody)
			{
				for (int j = 0; j < this.childConstraints.Length; j++)
				{
					this.childConstraints[j].OnPreSolve(solver);
				}
				if (this.children.Length != 0)
				{
					float num = this.nodes[this.nodes.Length - 1].effectorPositionWeight;
					for (int k = 0; k < this.children.Length; k++)
					{
						num += solver.chain[this.children[k]].nodes[0].effectorPositionWeight * solver.chain[this.children[k]].pull;
					}
					num = Mathf.Clamp(num, 1f, float.PositiveInfinity);
					for (int l = 0; l < this.children.Length; l++)
					{
						this.crossFades[l] = solver.chain[this.children[l]].nodes[0].effectorPositionWeight * solver.chain[this.children[l]].pull / num;
					}
				}
				this.pullParentSum = 0f;
				for (int m = 0; m < this.children.Length; m++)
				{
					this.pullParentSum += solver.chain[this.children[m]].pull;
				}
				this.pullParentSum = Mathf.Clamp(this.pullParentSum, 1f, float.PositiveInfinity);
				if (this.nodes.Length == 3)
				{
					this.reachForce = this.reach * Mathf.Clamp(this.nodes[2].effectorPositionWeight, 0f, 1f);
				}
				else
				{
					this.reachForce = 0f;
				}
				if (this.push > 0f && this.nodes.Length > 1)
				{
					this.distance = Vector3.Distance(this.nodes[0].transform.position, this.nodes[this.nodes.Length - 1].transform.position);
				}
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000E6A4 File Offset: 0x0000C8A4
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
			this.length = 0f;
			for (int i = 0; i < this.nodes.Length - 1; i++)
			{
				this.nodes[i].length = Vector3.Distance(this.nodes[i].transform.position, this.nodes[i + 1].transform.position);
				this.length += this.nodes[i].length;
				if (this.nodes[i].length == 0f)
				{
					Warning.Log(string.Concat(new string[]
					{
						"Bone ",
						this.nodes[i].transform.name,
						" - ",
						this.nodes[i + 1].transform.name,
						" length is zero, can not solve."
					}), this.nodes[i].transform, false);
					return;
				}
			}
			for (int j = 0; j < this.children.Length; j++)
			{
				solver.chain[this.children[j]].rootLength = (solver.chain[this.children[j]].nodes[0].transform.position - this.nodes[this.nodes.Length - 1].transform.position).magnitude;
				if (solver.chain[this.children[j]].rootLength == 0f)
				{
					return;
				}
			}
			if (this.nodes.Length == 3)
			{
				this.sqrMag1 = this.nodes[0].length * this.nodes[0].length;
				this.sqrMag2 = this.nodes[1].length * this.nodes[1].length;
				this.sqrMagDif = this.sqrMag1 - this.sqrMag2;
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000E890 File Offset: 0x0000CA90
		public void Reach(IKSolverFullBody solver)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.children.Length; i++)
			{
				solver.chain[this.children[i]].Reach(solver);
			}
			if (this.reachForce <= 0f)
			{
				return;
			}
			Vector3 vector = this.nodes[2].solverPosition - this.nodes[0].solverPosition;
			if (vector == Vector3.zero)
			{
				return;
			}
			float magnitude = vector.magnitude;
			Vector3 a = vector / magnitude * this.length;
			float num = Mathf.Clamp(magnitude / this.length, 1f - this.reachForce, 1f + this.reachForce) - 1f;
			num = Mathf.Clamp(num + this.reachForce, -1f, 1f);
			FBIKChain.Smoothing smoothing = this.reachSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == FBIKChain.Smoothing.Cubic)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = a * Mathf.Clamp(num, 0f, magnitude);
			this.nodes[0].solverPosition += vector2 * (1f - this.nodes[0].effectorPositionWeight);
			this.nodes[2].solverPosition += vector2;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
		public Vector3 Push(IKSolverFullBody solver)
		{
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < this.children.Length; i++)
			{
				vector += solver.chain[this.children[i]].Push(solver) * solver.chain[this.children[i]].pushParent;
			}
			this.nodes[this.nodes.Length - 1].solverPosition += vector;
			if (this.nodes.Length < 2)
			{
				return Vector3.zero;
			}
			if (this.push <= 0f)
			{
				return Vector3.zero;
			}
			Vector3 a = this.nodes[2].solverPosition - this.nodes[0].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 0f)
			{
				return Vector3.zero;
			}
			float num = 1f - magnitude / this.distance;
			if (num <= 0f)
			{
				return Vector3.zero;
			}
			FBIKChain.Smoothing smoothing = this.pushSmoothing;
			if (smoothing != FBIKChain.Smoothing.Exponential)
			{
				if (smoothing == FBIKChain.Smoothing.Cubic)
				{
					num *= num * num;
				}
			}
			else
			{
				num *= num;
			}
			Vector3 vector2 = -a * num * this.push;
			this.nodes[0].solverPosition += vector2;
			return vector2;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000EB40 File Offset: 0x0000CD40
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
			if (!this.initiated)
			{
				return;
			}
			for (int i = 0; i < this.children.Length; i++)
			{
				solver.chain[this.children[i]].SolveTrigonometric(solver, calculateBendDirection);
			}
			if (this.nodes.Length != 3)
			{
				return;
			}
			Vector3 a = this.nodes[2].solverPosition - this.nodes[0].solverPosition;
			float magnitude = a.magnitude;
			if (magnitude == 0f)
			{
				return;
			}
			float num = Mathf.Clamp(magnitude, 0f, this.length * 0.99999f);
			Vector3 direction = a / magnitude * num;
			Vector3 bendDirection = (calculateBendDirection && this.bendConstraint.initiated) ? this.bendConstraint.GetDir(solver) : (this.nodes[1].solverPosition - this.nodes[0].solverPosition);
			Vector3 dirToBendPoint = this.GetDirToBendPoint(direction, bendDirection, num);
			this.nodes[1].solverPosition = this.nodes[0].solverPosition + dirToBendPoint;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000EC54 File Offset: 0x0000CE54
		public void Stage1(IKSolverFullBody solver)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				solver.chain[this.children[i]].Stage1(solver);
			}
			if (this.children.Length == 0)
			{
				this.ForwardReach(this.nodes[this.nodes.Length - 1].solverPosition);
				return;
			}
			Vector3 a = this.nodes[this.nodes.Length - 1].solverPosition;
			this.SolveChildConstraints(solver);
			for (int j = 0; j < this.children.Length; j++)
			{
				Vector3 a2 = solver.chain[this.children[j]].nodes[0].solverPosition;
				if (solver.chain[this.children[j]].rootLength > 0f)
				{
					a2 = this.SolveFABRIKJoint(this.nodes[this.nodes.Length - 1].solverPosition, solver.chain[this.children[j]].nodes[0].solverPosition, solver.chain[this.children[j]].rootLength);
				}
				if (this.pullParentSum > 0f)
				{
					a += (a2 - this.nodes[this.nodes.Length - 1].solverPosition) * (solver.chain[this.children[j]].pull / this.pullParentSum);
				}
			}
			this.ForwardReach(Vector3.Lerp(a, this.nodes[this.nodes.Length - 1].solverPosition, this.pin));
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000EDE4 File Offset: 0x0000CFE4
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
			this.BackwardReach(position);
			int num = Mathf.Clamp(solver.iterations, 2, 4);
			if (this.childConstraints.Length != 0)
			{
				for (int i = 0; i < num; i++)
				{
					this.SolveConstraintSystems(solver);
				}
			}
			for (int j = 0; j < this.children.Length; j++)
			{
				solver.chain[this.children[j]].Stage2(solver, this.nodes[this.nodes.Length - 1].solverPosition);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000EE60 File Offset: 0x0000D060
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
			this.SolveChildConstraints(solver);
			for (int i = 0; i < this.children.Length; i++)
			{
				this.SolveLinearConstraint(this.nodes[this.nodes.Length - 1], solver.chain[this.children[i]].nodes[0], this.crossFades[i], solver.chain[this.children[i]].rootLength);
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000EED0 File Offset: 0x0000D0D0
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return pos2 + (pos1 - pos2).normalized * length;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			float num = (directionMagnitude * directionMagnitude + this.sqrMagDif) / 2f / directionMagnitude;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.sqrMag1 - num * num, 0f, float.PositiveInfinity));
			if (direction == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(direction, bendDirection) * new Vector3(0f, y, num);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000EF64 File Offset: 0x0000D164
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
			for (int i = 0; i < this.childConstraints.Length; i++)
			{
				this.childConstraints[i].Solve(solver);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000EF94 File Offset: 0x0000D194
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
			Vector3 a = node2.solverPosition - node1.solverPosition;
			float magnitude = a.magnitude;
			if (distance == magnitude)
			{
				return;
			}
			if (magnitude == 0f)
			{
				return;
			}
			Vector3 a2 = a * (1f - distance / magnitude);
			node1.solverPosition += a2 * crossFade;
			node2.solverPosition -= a2 * (1f - crossFade);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000F014 File Offset: 0x0000D214
		public void ForwardReach(Vector3 position)
		{
			this.nodes[this.nodes.Length - 1].solverPosition = position;
			for (int i = this.nodes.Length - 2; i > -1; i--)
			{
				this.nodes[i].solverPosition = this.SolveFABRIKJoint(this.nodes[i].solverPosition, this.nodes[i + 1].solverPosition, this.nodes[i].length);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000F08C File Offset: 0x0000D28C
		private void BackwardReach(Vector3 position)
		{
			if (this.rootLength > 0f)
			{
				position = this.SolveFABRIKJoint(this.nodes[0].solverPosition, position, this.rootLength);
			}
			this.nodes[0].solverPosition = position;
			for (int i = 1; i < this.nodes.Length; i++)
			{
				this.nodes[i].solverPosition = this.SolveFABRIKJoint(this.nodes[i].solverPosition, this.nodes[i - 1].solverPosition, this.nodes[i - 1].length);
			}
		}

		// Token: 0x040001C2 RID: 450
		[Range(0f, 1f)]
		public float pin;

		// Token: 0x040001C3 RID: 451
		[Range(0f, 1f)]
		public float pull = 1f;

		// Token: 0x040001C4 RID: 452
		[Range(0f, 1f)]
		public float push;

		// Token: 0x040001C5 RID: 453
		[Range(-1f, 1f)]
		public float pushParent;

		// Token: 0x040001C6 RID: 454
		[Range(0f, 1f)]
		public float reach = 0.1f;

		// Token: 0x040001C7 RID: 455
		public FBIKChain.Smoothing reachSmoothing = FBIKChain.Smoothing.Exponential;

		// Token: 0x040001C8 RID: 456
		public FBIKChain.Smoothing pushSmoothing = FBIKChain.Smoothing.Exponential;

		// Token: 0x040001C9 RID: 457
		public IKSolver.Node[] nodes = new IKSolver.Node[0];

		// Token: 0x040001CA RID: 458
		public int[] children = new int[0];

		// Token: 0x040001CB RID: 459
		public FBIKChain.ChildConstraint[] childConstraints = new FBIKChain.ChildConstraint[0];

		// Token: 0x040001CC RID: 460
		public IKConstraintBend bendConstraint = new IKConstraintBend();

		// Token: 0x040001CD RID: 461
		private float rootLength;

		// Token: 0x040001CE RID: 462
		private bool initiated;

		// Token: 0x040001CF RID: 463
		private float length;

		// Token: 0x040001D0 RID: 464
		private float distance;

		// Token: 0x040001D1 RID: 465
		private IKSolver.Point p;

		// Token: 0x040001D2 RID: 466
		private float reachForce;

		// Token: 0x040001D3 RID: 467
		private float pullParentSum;

		// Token: 0x040001D4 RID: 468
		private float[] crossFades;

		// Token: 0x040001D5 RID: 469
		private float sqrMag1;

		// Token: 0x040001D6 RID: 470
		private float sqrMag2;

		// Token: 0x040001D7 RID: 471
		private float sqrMagDif;

		// Token: 0x040001D8 RID: 472
		private const float maxLimbLength = 0.99999f;

		// Token: 0x020000E0 RID: 224
		[Serializable]
		public class ChildConstraint
		{
			// Token: 0x17000094 RID: 148
			// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0002C6FF File Offset: 0x0002A8FF
			// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0002C707 File Offset: 0x0002A907
			public float nominalDistance { get; private set; }

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0002C710 File Offset: 0x0002A910
			// (set) Token: 0x060006B4 RID: 1716 RVA: 0x0002C718 File Offset: 0x0002A918
			public bool isRigid { get; private set; }

			// Token: 0x060006B5 RID: 1717 RVA: 0x0002C721 File Offset: 0x0002A921
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
				this.bone1 = bone1;
				this.bone2 = bone2;
				this.pushElasticity = pushElasticity;
				this.pullElasticity = pullElasticity;
			}

			// Token: 0x060006B6 RID: 1718 RVA: 0x0002C746 File Offset: 0x0002A946
			public void Initiate(IKSolverFullBody solver)
			{
				this.chain1Index = solver.GetChainIndex(this.bone1);
				this.chain2Index = solver.GetChainIndex(this.bone2);
				this.OnPreSolve(solver);
			}

			// Token: 0x060006B7 RID: 1719 RVA: 0x0002C774 File Offset: 0x0002A974
			public void OnPreSolve(IKSolverFullBody solver)
			{
				this.nominalDistance = Vector3.Distance(solver.chain[this.chain1Index].nodes[0].transform.position, solver.chain[this.chain2Index].nodes[0].transform.position);
				this.isRigid = (this.pushElasticity <= 0f && this.pullElasticity <= 0f);
				if (this.isRigid)
				{
					float num = solver.chain[this.chain1Index].pull - solver.chain[this.chain2Index].pull;
					this.crossFade = 1f - (0.5f + num * 0.5f);
				}
				else
				{
					this.crossFade = 0.5f;
				}
				this.inverseCrossFade = 1f - this.crossFade;
			}

			// Token: 0x060006B8 RID: 1720 RVA: 0x0002C854 File Offset: 0x0002AA54
			public void Solve(IKSolverFullBody solver)
			{
				if (this.pushElasticity >= 1f && this.pullElasticity >= 1f)
				{
					return;
				}
				Vector3 a = solver.chain[this.chain2Index].nodes[0].solverPosition - solver.chain[this.chain1Index].nodes[0].solverPosition;
				float magnitude = a.magnitude;
				if (magnitude == this.nominalDistance)
				{
					return;
				}
				if (magnitude == 0f)
				{
					return;
				}
				float num = 1f;
				if (!this.isRigid)
				{
					float num2 = (magnitude > this.nominalDistance) ? this.pullElasticity : this.pushElasticity;
					num = 1f - num2;
				}
				num *= 1f - this.nominalDistance / magnitude;
				Vector3 a2 = a * num;
				solver.chain[this.chain1Index].nodes[0].solverPosition += a2 * this.crossFade;
				solver.chain[this.chain2Index].nodes[0].solverPosition -= a2 * this.inverseCrossFade;
			}

			// Token: 0x0400064D RID: 1613
			public float pushElasticity;

			// Token: 0x0400064E RID: 1614
			public float pullElasticity;

			// Token: 0x0400064F RID: 1615
			[SerializeField]
			private Transform bone1;

			// Token: 0x04000650 RID: 1616
			[SerializeField]
			private Transform bone2;

			// Token: 0x04000653 RID: 1619
			private float crossFade;

			// Token: 0x04000654 RID: 1620
			private float inverseCrossFade;

			// Token: 0x04000655 RID: 1621
			private int chain1Index;

			// Token: 0x04000656 RID: 1622
			private int chain2Index;
		}

		// Token: 0x020000E1 RID: 225
		[Serializable]
		public enum Smoothing
		{
			// Token: 0x04000658 RID: 1624
			None,
			// Token: 0x04000659 RID: 1625
			Exponential,
			// Token: 0x0400065A RID: 1626
			Cubic
		}
	}
}
