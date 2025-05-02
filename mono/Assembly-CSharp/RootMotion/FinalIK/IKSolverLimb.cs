using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005C RID: 92
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		// Token: 0x0600036B RID: 875 RVA: 0x0001615B File Offset: 0x0001435B
		public void MaintainRotation()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00016183 File Offset: 0x00014383
		public void MaintainBend()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.GetBendNormalFromCurrentRotation();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000161A8 File Offset: 0x000143A8
		protected override void OnInitiateVirtual()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.rotationLimit != null)
			{
				this.bone3.rotationLimit.Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.StoreAxisDirections(ref this.axisDirectionsLeft);
			this.StoreAxisDirections(ref this.axisDirectionsRight);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000162CC File Offset: 0x000144CC
		protected override void OnUpdateVirtual()
		{
			if (this.IKPositionWeight > 0f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 0f, 1f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 0f, 1f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.GetModifiedBendNormal();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 0f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = false;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00016378 File Offset: 0x00014578
		protected override void OnPostSolveVirtual()
		{
			if (this.IKPositionWeight > 0f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 0f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000163EA File Offset: 0x000145EA
		public IKSolverLimb()
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00016415 File Offset: 0x00014615
		public IKSolverLimb(AvatarIKGoal goal)
		{
			this.goal = goal;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00016447 File Offset: 0x00014647
		private IKSolverLimb.AxisDirection[] axisDirections
		{
			get
			{
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					return this.axisDirectionsLeft;
				}
				return this.axisDirectionsRight;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00016460 File Offset: 0x00014660
		private void StoreAxisDirections(ref IKSolverLimb.AxisDirection[] axisDirections)
		{
			axisDirections[0] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(-1f, 0f, 0f));
			axisDirections[1] = new IKSolverLimb.AxisDirection(new Vector3(0.5f, 0f, -0.2f), new Vector3(-0.5f, -1f, 1f));
			axisDirections[2] = new IKSolverLimb.AxisDirection(new Vector3(-0.5f, -1f, -0.2f), new Vector3(0f, 0.5f, -1f));
			axisDirections[3] = new IKSolverLimb.AxisDirection(new Vector3(-0.5f, -0.5f, 1f), new Vector3(-1f, -1f, -1f));
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00016534 File Offset: 0x00014734
		private Vector3 GetModifiedBendNormal()
		{
			float num = this.bendModifierWeight;
			if (num <= 0f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.MaintainBend();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!Warning.logged)
					{
						base.LogWarning("Trying to use the 'Arm' bend modifier on a leg.");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					vector.x = -vector.x;
				}
				for (int i = 1; i < this.axisDirections.Length; i++)
				{
					this.axisDirections[i].dot = Mathf.Clamp(Vector3.Dot(this.axisDirections[i].direction, vector), 0f, 1f);
					this.axisDirections[i].dot = Interp.Float(this.axisDirections[i].dot, InterpolationMode.InOutQuintic);
				}
				Vector3 vector2 = this.axisDirections[0].axis;
				for (int j = 1; j < this.axisDirections.Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.axisDirections[j].axis, this.axisDirections[j].dot);
				}
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!Warning.logged)
					{
						base.LogWarning("Trying to use the 'Goal' Bend Modifier, but the Bend Goal is unassigned.");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0400028A RID: 650
		public AvatarIKGoal goal;

		// Token: 0x0400028B RID: 651
		public IKSolverLimb.BendModifier bendModifier;

		// Token: 0x0400028C RID: 652
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x0400028D RID: 653
		[Range(0f, 1f)]
		public float bendModifierWeight = 1f;

		// Token: 0x0400028E RID: 654
		public Transform bendGoal;

		// Token: 0x0400028F RID: 655
		private bool maintainBendFor1Frame;

		// Token: 0x04000290 RID: 656
		private bool maintainRotationFor1Frame;

		// Token: 0x04000291 RID: 657
		private Quaternion defaultRootRotation;

		// Token: 0x04000292 RID: 658
		private Quaternion parentDefaultRotation;

		// Token: 0x04000293 RID: 659
		private Quaternion bone3RotationBeforeSolve;

		// Token: 0x04000294 RID: 660
		private Quaternion maintainRotation;

		// Token: 0x04000295 RID: 661
		private Quaternion bone3DefaultRotation;

		// Token: 0x04000296 RID: 662
		private Vector3 _bendNormal;

		// Token: 0x04000297 RID: 663
		private Vector3 animationNormal;

		// Token: 0x04000298 RID: 664
		private IKSolverLimb.AxisDirection[] axisDirectionsLeft = new IKSolverLimb.AxisDirection[4];

		// Token: 0x04000299 RID: 665
		private IKSolverLimb.AxisDirection[] axisDirectionsRight = new IKSolverLimb.AxisDirection[4];

		// Token: 0x020000E9 RID: 233
		[Serializable]
		public enum BendModifier
		{
			// Token: 0x04000686 RID: 1670
			Animation,
			// Token: 0x04000687 RID: 1671
			Target,
			// Token: 0x04000688 RID: 1672
			Parent,
			// Token: 0x04000689 RID: 1673
			Arm,
			// Token: 0x0400068A RID: 1674
			Goal
		}

		// Token: 0x020000EA RID: 234
		[Serializable]
		public struct AxisDirection
		{
			// Token: 0x060006EE RID: 1774 RVA: 0x0002D363 File Offset: 0x0002B563
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
				this.direction = direction.normalized;
				this.axis = axis.normalized;
				this.dot = 0f;
			}

			// Token: 0x0400068B RID: 1675
			public Vector3 direction;

			// Token: 0x0400068C RID: 1676
			public Vector3 axis;

			// Token: 0x0400068D RID: 1677
			public float dot;
		}
	}
}
