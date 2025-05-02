using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000051 RID: 81
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		// Token: 0x060002CC RID: 716 RVA: 0x0001158C File Offset: 0x0000F78C
		public float GetAngle()
		{
			return Vector3.Angle(this.transformAxis, this.IKPosition - this.transform.position);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060002CD RID: 717 RVA: 0x000115AF File Offset: 0x0000F7AF
		public Vector3 transformAxis
		{
			get
			{
				return this.transform.rotation * this.axis;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000115C7 File Offset: 0x0000F7C7
		public Vector3 transformPoleAxis
		{
			get
			{
				return this.transform.rotation * this.poleAxis;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000115E0 File Offset: 0x0000F7E0
		protected override void OnInitiate()
		{
			if ((this.firstInitiation || !Application.isPlaying) && this.transform != null)
			{
				this.IKPosition = this.transform.position + this.transformAxis * 3f;
				this.polePosition = this.transform.position + this.transformPoleAxis * 3f;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (this.bones[i].rotationLimit != null)
				{
					this.bones[i].rotationLimit.Disable();
				}
			}
			this.step = 1f / (float)this.bones.Length;
			if (Application.isPlaying)
			{
				this.axis = this.axis.normalized;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000116C0 File Offset: 0x0000F8C0
		protected override void OnUpdate()
		{
			if (this.axis == Vector3.zero)
			{
				if (!Warning.logged)
				{
					base.LogWarning("IKSolverAim axis is Vector3.zero.");
				}
				return;
			}
			if (this.poleAxis == Vector3.zero && this.poleWeight > 0f)
			{
				if (!Warning.logged)
				{
					base.LogWarning("IKSolverAim poleAxis is Vector3.zero.");
				}
				return;
			}
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.poleTarget != null)
			{
				this.polePosition = this.poleTarget.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			if (this.transform != this.lastTransform)
			{
				this.transformLimit = this.transform.GetComponent<RotationLimit>();
				if (this.transformLimit != null)
				{
					this.transformLimit.enabled = false;
				}
				this.lastTransform = this.transform;
			}
			if (this.transformLimit != null)
			{
				this.transformLimit.Apply();
			}
			if (this.transform == null)
			{
				if (!Warning.logged)
				{
					base.LogWarning("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition");
				}
				return;
			}
			this.clampWeight = Mathf.Clamp(this.clampWeight, 0f, 1f);
			this.clampedIKPosition = this.GetClampedIKPosition();
			Vector3 b = this.clampedIKPosition - this.transform.position;
			b = Vector3.Slerp(this.transformAxis * b.magnitude, b, this.IKPositionWeight);
			this.clampedIKPosition = this.transform.position + b;
			int num = 0;
			while (num < this.maxIterations && (num < 1 || this.tolerance <= 0f || this.GetAngle() >= this.tolerance))
			{
				this.lastLocalDirection = this.localDirection;
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.Solve();
				num++;
			}
			this.lastLocalDirection = this.localDirection;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00011910 File Offset: 0x0000FB10
		protected override int minBones
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00011914 File Offset: 0x0000FB14
		private void Solve()
		{
			for (int i = 0; i < this.bones.Length - 1; i++)
			{
				this.RotateToTarget(this.clampedIKPosition, this.bones[i], this.step * (float)(i + 1) * this.IKPositionWeight * this.bones[i].weight);
			}
			this.RotateToTarget(this.clampedIKPosition, this.bones[this.bones.Length - 1], this.IKPositionWeight * this.bones[this.bones.Length - 1].weight);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000119A4 File Offset: 0x0000FBA4
		private Vector3 GetClampedIKPosition()
		{
			if (this.clampWeight <= 0f)
			{
				return this.IKPosition;
			}
			if (this.clampWeight >= 1f)
			{
				return this.transform.position + this.transformAxis * (this.IKPosition - this.transform.position).magnitude;
			}
			float num = Vector3.Angle(this.transformAxis, this.IKPosition - this.transform.position);
			float num2 = 1f - num / 180f;
			float num3 = (this.clampWeight > 0f) ? Mathf.Clamp(1f - (this.clampWeight - num2) / (1f - num2), 0f, 1f) : 1f;
			float num4 = (this.clampWeight > 0f) ? Mathf.Clamp(num2 / this.clampWeight, 0f, 1f) : 1f;
			for (int i = 0; i < this.clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
			}
			return this.transform.position + Vector3.Slerp(this.transformAxis * 10f, this.IKPosition - this.transform.position, num4 * num3);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00011B0C File Offset: 0x0000FD0C
		private void RotateToTarget(Vector3 targetPosition, IKSolver.Bone bone, float weight)
		{
			if (this.XY)
			{
				if (weight >= 0f)
				{
					Vector3 transformAxis = this.transformAxis;
					Vector3 vector = targetPosition - this.transform.position;
					float current = Mathf.Atan2(transformAxis.x, transformAxis.y) * 57.29578f;
					float target = Mathf.Atan2(vector.x, vector.y) * 57.29578f;
					bone.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target), Vector3.back) * bone.transform.rotation;
				}
			}
			else
			{
				if (weight >= 0f)
				{
					Quaternion quaternion = Quaternion.FromToRotation(this.transformAxis, targetPosition - this.transform.position);
					if (weight >= 1f)
					{
						bone.transform.rotation = quaternion * bone.transform.rotation;
					}
					else
					{
						bone.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, weight) * bone.transform.rotation;
					}
				}
				if (this.poleWeight > 0f)
				{
					Vector3 toDirection = this.polePosition - this.transform.position;
					Vector3 transformAxis2 = this.transformAxis;
					Vector3.OrthoNormalize(ref transformAxis2, ref toDirection);
					Quaternion b = Quaternion.FromToRotation(this.transformPoleAxis, toDirection);
					bone.transform.rotation = Quaternion.Lerp(Quaternion.identity, b, weight * this.poleWeight) * bone.transform.rotation;
				}
			}
			if (this.useRotationLimits && bone.rotationLimit != null)
			{
				bone.rotationLimit.Apply();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00011CB4 File Offset: 0x0000FEB4
		protected override Vector3 localDirection
		{
			get
			{
				return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.forward);
			}
		}

		// Token: 0x04000231 RID: 561
		public Transform transform;

		// Token: 0x04000232 RID: 562
		public Vector3 axis = Vector3.forward;

		// Token: 0x04000233 RID: 563
		public Vector3 poleAxis = Vector3.up;

		// Token: 0x04000234 RID: 564
		public Vector3 polePosition;

		// Token: 0x04000235 RID: 565
		[Range(0f, 1f)]
		public float poleWeight;

		// Token: 0x04000236 RID: 566
		public Transform poleTarget;

		// Token: 0x04000237 RID: 567
		[Range(0f, 1f)]
		public float clampWeight = 0.1f;

		// Token: 0x04000238 RID: 568
		[Range(0f, 2f)]
		public int clampSmoothing = 2;

		// Token: 0x04000239 RID: 569
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x0400023A RID: 570
		private float step;

		// Token: 0x0400023B RID: 571
		private Vector3 clampedIKPosition;

		// Token: 0x0400023C RID: 572
		private RotationLimit transformLimit;

		// Token: 0x0400023D RID: 573
		private Transform lastTransform;
	}
}
