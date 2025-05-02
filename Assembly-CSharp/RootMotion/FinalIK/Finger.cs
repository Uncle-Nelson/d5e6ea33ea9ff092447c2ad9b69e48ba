using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000031 RID: 49
	[Serializable]
	public class Finger
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00008F6F File Offset: 0x0000716F
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00008F77 File Offset: 0x00007177
		public bool initiated { get; private set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00008F80 File Offset: 0x00007180
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00008F8D File Offset: 0x0000718D
		public Vector3 IKPosition
		{
			get
			{
				return this.solver.IKPosition;
			}
			set
			{
				this.solver.IKPosition = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00008F9B File Offset: 0x0000719B
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00008FA8 File Offset: 0x000071A8
		public Quaternion IKRotation
		{
			get
			{
				return this.solver.IKRotation;
			}
			set
			{
				this.solver.IKRotation = value;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008FB6 File Offset: 0x000071B6
		public bool IsValid(ref string errorMessage)
		{
			if (this.bone1 == null || this.bone2 == null || this.tip == null)
			{
				errorMessage = "One of the bones in the Finger Rig is null, can not initiate solvers.";
				return false;
			}
			return true;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00008FEC File Offset: 0x000071EC
		public void Initiate(Transform hand, int index)
		{
			this.initiated = false;
			string empty = string.Empty;
			if (!this.IsValid(ref empty))
			{
				Warning.Log(empty, hand, false);
				return;
			}
			this.solver = new IKSolverLimb();
			this.solver.IKPositionWeight = this.weight;
			this.solver.bendModifier = IKSolverLimb.BendModifier.Target;
			this.solver.bendModifierWeight = 1f;
			this.defaultBendNormal = -Vector3.Cross(this.tip.position - this.bone1.position, this.bone2.position - this.bone1.position).normalized;
			this.solver.bendNormal = this.defaultBendNormal;
			Vector3 point = Vector3.Cross(this.bone2.position - this.bone1.position, this.tip.position - this.bone1.position);
			this.bone1Axis = Quaternion.Inverse(this.bone1.rotation) * point;
			this.tipAxis = Quaternion.Inverse(this.tip.rotation) * point;
			Vector3 vector = this.bone2.position - this.bone1.position;
			Vector3 point2 = -Vector3.Cross(this.tip.position - this.bone1.position, this.bone2.position - this.bone1.position);
			Vector3.OrthoNormalize(ref vector, ref point2);
			this.bone1TwistAxis = Quaternion.Inverse(this.bone1.rotation) * point2;
			this.IKPosition = this.tip.position;
			this.IKRotation = this.tip.rotation;
			if (this.bone3 != null)
			{
				this.bone3RelativeToTarget = Quaternion.Inverse(this.IKRotation) * this.bone3.rotation;
				this.bone3DefaultLocalPosition = this.bone3.localPosition;
				this.bone3DefaultLocalRotation = this.bone3.localRotation;
			}
			this.solver.SetChain(this.bone1, this.bone2, this.tip, hand);
			this.solver.Initiate(hand);
			this.initiated = true;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000924C File Offset: 0x0000744C
		public void FixTransforms()
		{
			if (!this.initiated)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				return;
			}
			this.solver.FixTransforms();
			if (this.bone3 != null)
			{
				this.bone3.localPosition = this.bone3DefaultLocalPosition;
				this.bone3.localRotation = this.bone3DefaultLocalRotation;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000092AC File Offset: 0x000074AC
		public void StoreDefaultLocalState()
		{
			if (!this.initiated)
			{
				return;
			}
			this.solver.StoreDefaultLocalState();
			if (this.bone3 != null)
			{
				this.bone3DefaultLocalPosition = this.bone3.localPosition;
				this.bone3DefaultLocalRotation = this.bone3.localRotation;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00009300 File Offset: 0x00007500
		public void Update(float masterWeight)
		{
			if (!this.initiated)
			{
				return;
			}
			float num = this.weight * masterWeight;
			if (num <= 0f)
			{
				return;
			}
			this.solver.target = this.target;
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.IKRotation = this.target.rotation;
			}
			if (this.rotationDOF == Finger.DOF.One)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.IKRotation * this.tipAxis, this.bone1.rotation * this.bone1Axis);
				this.IKRotation = lhs * this.IKRotation;
			}
			if (this.bone3 != null)
			{
				if (num * this.rotationWeight >= 1f)
				{
					this.bone3.rotation = this.IKRotation * this.bone3RelativeToTarget;
				}
				else
				{
					this.bone3.rotation = Quaternion.Lerp(this.bone3.rotation, this.IKRotation * this.bone3RelativeToTarget, num * this.rotationWeight);
				}
			}
			this.solver.IKPositionWeight = num;
			this.solver.IKRotationWeight = this.rotationWeight;
			this.solver.Update();
			if (this.fixBone1Twist)
			{
				Quaternion rotation = this.bone2.rotation;
				Vector3 vector = Quaternion.Inverse(Quaternion.LookRotation(this.bone1.rotation * this.bone1TwistAxis, this.bone2.position - this.bone1.position)) * this.solver.bendNormal;
				float angle = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
				this.bone1.rotation = Quaternion.AngleAxis(angle, this.bone2.position - this.bone1.position) * this.bone1.rotation;
				this.bone2.rotation = rotation;
			}
		}

		// Token: 0x04000107 RID: 263
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x04000108 RID: 264
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight = 1f;

		// Token: 0x04000109 RID: 265
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public Finger.DOF rotationDOF;

		// Token: 0x0400010A RID: 266
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		// Token: 0x0400010B RID: 267
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		// Token: 0x0400010C RID: 268
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		// Token: 0x0400010D RID: 269
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		// Token: 0x0400010E RID: 270
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		// Token: 0x0400010F RID: 271
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		// Token: 0x04000111 RID: 273
		private IKSolverLimb solver;

		// Token: 0x04000112 RID: 274
		private Quaternion bone3RelativeToTarget;

		// Token: 0x04000113 RID: 275
		private Vector3 bone3DefaultLocalPosition;

		// Token: 0x04000114 RID: 276
		private Quaternion bone3DefaultLocalRotation;

		// Token: 0x04000115 RID: 277
		private Vector3 bone1Axis;

		// Token: 0x04000116 RID: 278
		private Vector3 tipAxis;

		// Token: 0x04000117 RID: 279
		private Vector3 bone1TwistAxis;

		// Token: 0x04000118 RID: 280
		private Vector3 defaultBendNormal;

		// Token: 0x020000D4 RID: 212
		[Serializable]
		public enum DOF
		{
			// Token: 0x0400060B RID: 1547
			One,
			// Token: 0x0400060C RID: 1548
			Three
		}
	}
}
