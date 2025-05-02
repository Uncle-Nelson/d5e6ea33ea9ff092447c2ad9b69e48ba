using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000054 RID: 84
	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00012762 File Offset: 0x00010962
		public void SolveForward(Vector3 position)
		{
			if (!base.initiated)
			{
				if (!Warning.logged)
				{
					base.LogWarning("Trying to solve uninitiated FABRIK chain.");
				}
				return;
			}
			this.OnPreSolve();
			this.ForwardReach(position);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001278C File Offset: 0x0001098C
		public void SolveBackward(Vector3 position)
		{
			if (!base.initiated)
			{
				if (!Warning.logged)
				{
					base.LogWarning("Trying to solve uninitiated FABRIK chain.");
				}
				return;
			}
			this.BackwardReach(position);
			this.OnPostSolve();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000127B6 File Offset: 0x000109B6
		public override Vector3 GetIKPosition()
		{
			if (this.target != null)
			{
				return this.target.position;
			}
			return this.IKPosition;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000127D8 File Offset: 0x000109D8
		protected override void OnInitiate()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				this.IKPosition = this.bones[this.bones.Length - 1].transform.position;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.bones[i].transform.position;
				this.bones[i].solverRotation = this.bones[i].transform.rotation;
			}
			this.limitedBones = new bool[this.bones.Length];
			this.solverLocalPositions = new Vector3[this.bones.Length];
			base.InitiateBones();
			for (int j = 0; j < this.bones.Length; j++)
			{
				this.solverLocalPositions[j] = Quaternion.Inverse(this.GetParentSolverRotation(j)) * (this.bones[j].transform.position - this.GetParentSolverPosition(j));
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000128E0 File Offset: 0x00010AE0
		protected override void OnUpdate()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			this.OnPreSolve();
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			Vector3 vector = (this.maxIterations > 1) ? base.GetSingularityOffset() : Vector3.zero;
			int num = 0;
			while (num < this.maxIterations && (!(vector == Vector3.zero) || num < 1 || this.tolerance <= 0f || base.positionOffset >= this.tolerance * this.tolerance))
			{
				this.lastLocalDirection = this.localDirection;
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.Solve(this.IKPosition + ((num == 0) ? vector : Vector3.zero));
				num++;
			}
			this.OnPostSolve();
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00012A02 File Offset: 0x00010C02
		protected override bool boneLengthCanBeZero
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00012A08 File Offset: 0x00010C08
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			if (this.XY)
			{
				pos1.z = pos2.z;
			}
			return pos2 + (pos1 - pos2).normalized * length;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00012A48 File Offset: 0x00010C48
		private void OnPreSolve()
		{
			this.chainLength = 0f;
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.bones[i].transform.position;
				this.bones[i].solverRotation = this.bones[i].transform.rotation;
				if (i < this.bones.Length - 1)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 1].transform.position).magnitude;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[i + 1].transform.position - this.bones[i].transform.position);
					this.chainLength += this.bones[i].length;
				}
				if (this.useRotationLimits)
				{
					this.solverLocalPositions[i] = Quaternion.Inverse(this.GetParentSolverRotation(i)) * (this.bones[i].transform.position - this.GetParentSolverPosition(i));
				}
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00012BB8 File Offset: 0x00010DB8
		private void OnPostSolve()
		{
			if (!this.useRotationLimits)
			{
				this.MapToSolverPositions();
			}
			else
			{
				this.MapToSolverPositionsLimited();
			}
			this.lastLocalDirection = this.localDirection;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00012BDC File Offset: 0x00010DDC
		private void Solve(Vector3 targetPosition)
		{
			this.ForwardReach(targetPosition);
			this.BackwardReach(this.bones[0].transform.position);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00012C00 File Offset: 0x00010E00
		private void ForwardReach(Vector3 position)
		{
			this.bones[this.bones.Length - 1].solverPosition = Vector3.Lerp(this.bones[this.bones.Length - 1].solverPosition, position, this.IKPositionWeight);
			for (int i = 0; i < this.limitedBones.Length; i++)
			{
				this.limitedBones[i] = false;
			}
			for (int j = this.bones.Length - 2; j > -1; j--)
			{
				this.bones[j].solverPosition = this.SolveJoint(this.bones[j].solverPosition, this.bones[j + 1].solverPosition, this.bones[j].length);
				this.LimitForward(j, j + 1);
			}
			this.LimitForward(0, 0);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00012CC4 File Offset: 0x00010EC4
		private void SolverMove(int index, Vector3 offset)
		{
			for (int i = index; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition += offset;
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00012D00 File Offset: 0x00010F00
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
			for (int i = index; i < this.bones.Length; i++)
			{
				this.bones[i].solverRotation = rotation * this.bones[i].solverRotation;
				if (!recursive)
				{
					return;
				}
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00012D44 File Offset: 0x00010F44
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
			for (int i = index + 1; i < this.bones.Length; i++)
			{
				this.bones[i].solverRotation = rotation * this.bones[i].solverRotation;
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00012D88 File Offset: 0x00010F88
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
			for (int i = index + 1; i < this.bones.Length; i++)
			{
				Vector3 point = this.bones[i].solverPosition - this.bones[index].solverPosition;
				this.bones[i].solverPosition = this.bones[index].solverPosition + rotation * point;
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00012DF0 File Offset: 0x00010FF0
		private Quaternion GetParentSolverRotation(int index)
		{
			if (index > 0)
			{
				return this.bones[index - 1].solverRotation;
			}
			if (this.bones[0].transform.parent == null)
			{
				return Quaternion.identity;
			}
			return this.bones[0].transform.parent.rotation;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00012E48 File Offset: 0x00011048
		private Vector3 GetParentSolverPosition(int index)
		{
			if (index > 0)
			{
				return this.bones[index - 1].solverPosition;
			}
			if (this.bones[0].transform.parent == null)
			{
				return Vector3.zero;
			}
			return this.bones[0].transform.parent.position;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00012EA0 File Offset: 0x000110A0
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			changed = false;
			Quaternion parentSolverRotation = this.GetParentSolverRotation(index);
			Quaternion localRotation = Quaternion.Inverse(parentSolverRotation) * q;
			Quaternion limitedLocalRotation = this.bones[index].rotationLimit.GetLimitedLocalRotation(localRotation, out changed);
			if (!changed)
			{
				return q;
			}
			return parentSolverRotation * limitedLocalRotation;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00012EE8 File Offset: 0x000110E8
		private void LimitForward(int rotateBone, int limitBone)
		{
			if (!this.useRotationLimits)
			{
				return;
			}
			if (this.bones[limitBone].rotationLimit == null)
			{
				return;
			}
			Vector3 solverPosition = this.bones[this.bones.Length - 1].solverPosition;
			int num = rotateBone;
			while (num < this.bones.Length - 1 && !this.limitedBones[num])
			{
				Quaternion rotation = Quaternion.FromToRotation(this.bones[num].solverRotation * this.bones[num].axis, this.bones[num + 1].solverPosition - this.bones[num].solverPosition);
				this.SolverRotate(num, rotation, false);
				num++;
			}
			bool flag = false;
			Quaternion limitedRotation = this.GetLimitedRotation(limitBone, this.bones[limitBone].solverRotation, out flag);
			if (flag)
			{
				if (limitBone < this.bones.Length - 1)
				{
					Quaternion rotation2 = QuaTools.FromToRotation(this.bones[limitBone].solverRotation, limitedRotation);
					this.bones[limitBone].solverRotation = limitedRotation;
					this.SolverRotateChildren(limitBone, rotation2);
					this.SolverMoveChildrenAroundPoint(limitBone, rotation2);
					Quaternion rotation3 = Quaternion.FromToRotation(this.bones[this.bones.Length - 1].solverPosition - this.bones[rotateBone].solverPosition, solverPosition - this.bones[rotateBone].solverPosition);
					this.SolverRotate(rotateBone, rotation3, true);
					this.SolverMoveChildrenAroundPoint(rotateBone, rotation3);
					this.SolverMove(rotateBone, solverPosition - this.bones[this.bones.Length - 1].solverPosition);
				}
				else
				{
					this.bones[limitBone].solverRotation = limitedRotation;
				}
			}
			this.limitedBones[limitBone] = true;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00013090 File Offset: 0x00011290
		private void BackwardReach(Vector3 position)
		{
			if (this.useRotationLimits)
			{
				this.BackwardReachLimited(position);
				return;
			}
			this.BackwardReachUnlimited(position);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000130AC File Offset: 0x000112AC
		private void BackwardReachUnlimited(Vector3 position)
		{
			this.bones[0].solverPosition = position;
			for (int i = 1; i < this.bones.Length; i++)
			{
				this.bones[i].solverPosition = this.SolveJoint(this.bones[i].solverPosition, this.bones[i - 1].solverPosition, this.bones[i - 1].length);
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00013118 File Offset: 0x00011318
		private void BackwardReachLimited(Vector3 position)
		{
			this.bones[0].solverPosition = position;
			for (int i = 0; i < this.bones.Length - 1; i++)
			{
				Vector3 a = this.SolveJoint(this.bones[i + 1].solverPosition, this.bones[i].solverPosition, this.bones[i].length);
				Quaternion quaternion = Quaternion.FromToRotation(this.bones[i].solverRotation * this.bones[i].axis, a - this.bones[i].solverPosition) * this.bones[i].solverRotation;
				if (this.bones[i].rotationLimit != null)
				{
					bool flag = false;
					quaternion = this.GetLimitedRotation(i, quaternion, out flag);
				}
				Quaternion rotation = QuaTools.FromToRotation(this.bones[i].solverRotation, quaternion);
				this.bones[i].solverRotation = quaternion;
				this.SolverRotateChildren(i, rotation);
				this.bones[i + 1].solverPosition = this.bones[i].solverPosition + this.bones[i].solverRotation * this.solverLocalPositions[i + 1];
			}
			for (int j = 0; j < this.bones.Length; j++)
			{
				this.bones[j].solverRotation = Quaternion.LookRotation(this.bones[j].solverRotation * Vector3.forward, this.bones[j].solverRotation * Vector3.up);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000132B0 File Offset: 0x000114B0
		private void MapToSolverPositions()
		{
			this.bones[0].transform.position = this.bones[0].solverPosition;
			for (int i = 0; i < this.bones.Length - 1; i++)
			{
				if (this.XY)
				{
					this.bones[i].Swing2D(this.bones[i + 1].solverPosition, 1f);
				}
				else
				{
					this.bones[i].Swing(this.bones[i + 1].solverPosition, 1f);
				}
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00013340 File Offset: 0x00011540
		private void MapToSolverPositionsLimited()
		{
			this.bones[0].transform.position = this.bones[0].solverPosition;
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (i < this.bones.Length - 1)
				{
					this.bones[i].transform.rotation = this.bones[i].solverRotation;
				}
			}
		}

		// Token: 0x0400024A RID: 586
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x0400024B RID: 587
		private bool[] limitedBones = new bool[0];

		// Token: 0x0400024C RID: 588
		private Vector3[] solverLocalPositions = new Vector3[0];
	}
}
