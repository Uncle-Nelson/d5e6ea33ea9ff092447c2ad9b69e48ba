using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005A RID: 90
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		// Token: 0x0600034C RID: 844 RVA: 0x00015430 File Offset: 0x00013630
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			if (this.bones == null || this.bones.Length != hierarchy.Length)
			{
				this.bones = new IKSolver.Bone[hierarchy.Length];
			}
			for (int i = 0; i < hierarchy.Length; i++)
			{
				if (this.bones[i] == null)
				{
					this.bones[i] = new IKSolver.Bone();
				}
				this.bones[i].transform = hierarchy[i];
			}
			base.Initiate(root);
			return base.initiated;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000154A4 File Offset: 0x000136A4
		public void AddBone(Transform bone)
		{
			Transform[] array = new Transform[this.bones.Length + 1];
			for (int i = 0; i < this.bones.Length; i++)
			{
				array[i] = this.bones[i].transform;
			}
			array[array.Length - 1] = bone;
			this.SetChain(array, this.root);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000154FC File Offset: 0x000136FC
		public override void StoreDefaultLocalState()
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].StoreDefaultLocalState();
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001552C File Offset: 0x0001372C
		public override void FixTransforms()
		{
			if (!base.initiated)
			{
				return;
			}
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				this.bones[i].FixTransform();
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00015570 File Offset: 0x00013770
		public override bool IsValid(ref string message)
		{
			if (this.bones.Length == 0)
			{
				message = "IK chain has no Bones.";
				return false;
			}
			if (this.bones.Length < this.minBones)
			{
				message = "IK chain has less than " + this.minBones.ToString() + " Bones.";
				return false;
			}
			IKSolver.Bone[] array = this.bones;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].transform == null)
				{
					message = "One of the Bones is null.";
					return false;
				}
			}
			Transform transform = IKSolver.ContainsDuplicateBone(this.bones);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in the Bones.";
				return false;
			}
			if (!this.allowCommonParent && !IKSolver.HierarchyIsValid(this.bones))
			{
				message = "Invalid bone hierarchy detected. IK requires for its bones to be parented to each other in descending order.";
				return false;
			}
			if (!this.boneLengthCanBeZero)
			{
				for (int j = 0; j < this.bones.Length - 1; j++)
				{
					if ((this.bones[j].transform.position - this.bones[j + 1].transform.position).magnitude == 0f)
					{
						message = "Bone " + j.ToString() + " length is zero.";
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000156A8 File Offset: 0x000138A8
		public override IKSolver.Point[] GetPoints()
		{
			return this.bones;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000156C0 File Offset: 0x000138C0
		public override IKSolver.Point GetPoint(Transform transform)
		{
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (this.bones[i].transform == transform)
				{
					return this.bones[i];
				}
			}
			return null;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000353 RID: 851 RVA: 0x000156FF File Offset: 0x000138FF
		protected virtual int minBones
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00015702 File Offset: 0x00013902
		protected virtual bool boneLengthCanBeZero
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00015705 File Offset: 0x00013905
		protected virtual bool allowCommonParent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00015708 File Offset: 0x00013908
		protected override void OnInitiate()
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0001570A File Offset: 0x0001390A
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001570C File Offset: 0x0001390C
		protected void InitiateBones()
		{
			this.chainLength = 0f;
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (i < this.bones.Length - 1)
				{
					this.bones[i].length = (this.bones[i].transform.position - this.bones[i + 1].transform.position).magnitude;
					this.chainLength += this.bones[i].length;
					Vector3 position = this.bones[i + 1].transform.position;
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (position - this.bones[i].transform.position);
					if (this.bones[i].rotationLimit != null)
					{
						if (this.XY && !(this.bones[i].rotationLimit is RotationLimitHinge))
						{
							Warning.Log("Only Hinge Rotation Limits should be used on 2D IK solvers.", this.bones[i].transform, false);
						}
						this.bones[i].rotationLimit.Disable();
					}
				}
				else
				{
					this.bones[i].axis = Quaternion.Inverse(this.bones[i].transform.rotation) * (this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000359 RID: 857 RVA: 0x000158B8 File Offset: 0x00013AB8
		protected virtual Vector3 localDirection
		{
			get
			{
				return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00015909 File Offset: 0x00013B09
		protected float positionOffset
		{
			get
			{
				return Vector3.SqrMagnitude(this.localDirection - this.lastLocalDirection);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00015924 File Offset: 0x00013B24
		protected Vector3 GetSingularityOffset()
		{
			if (!this.SingularityDetected())
			{
				return Vector3.zero;
			}
			Vector3 normalized = (this.IKPosition - this.bones[0].transform.position).normalized;
			Vector3 rhs = new Vector3(normalized.y, normalized.z, normalized.x);
			if (this.useRotationLimits && this.bones[this.bones.Length - 2].rotationLimit != null && this.bones[this.bones.Length - 2].rotationLimit is RotationLimitHinge)
			{
				rhs = this.bones[this.bones.Length - 2].transform.rotation * this.bones[this.bones.Length - 2].rotationLimit.axis;
			}
			return Vector3.Cross(normalized, rhs) * this.bones[this.bones.Length - 2].length * 0.5f;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00015A2C File Offset: 0x00013C2C
		private bool SingularityDetected()
		{
			if (!base.initiated)
			{
				return false;
			}
			Vector3 a = this.bones[this.bones.Length - 1].transform.position - this.bones[0].transform.position;
			Vector3 a2 = this.IKPosition - this.bones[0].transform.position;
			float magnitude = a.magnitude;
			float magnitude2 = a2.magnitude;
			return magnitude >= magnitude2 && magnitude >= this.chainLength - this.bones[this.bones.Length - 2].length * 0.1f && magnitude != 0f && magnitude2 != 0f && magnitude2 <= magnitude && Vector3.Dot(a / magnitude, a2 / magnitude2) >= 0.999f;
		}

		// Token: 0x04000277 RID: 631
		public Transform target;

		// Token: 0x04000278 RID: 632
		public float tolerance;

		// Token: 0x04000279 RID: 633
		public int maxIterations = 4;

		// Token: 0x0400027A RID: 634
		public bool useRotationLimits = true;

		// Token: 0x0400027B RID: 635
		public bool XY;

		// Token: 0x0400027C RID: 636
		public IKSolver.Bone[] bones = new IKSolver.Bone[0];

		// Token: 0x0400027D RID: 637
		protected Vector3 lastLocalDirection;

		// Token: 0x0400027E RID: 638
		protected float chainLength;
	}
}
