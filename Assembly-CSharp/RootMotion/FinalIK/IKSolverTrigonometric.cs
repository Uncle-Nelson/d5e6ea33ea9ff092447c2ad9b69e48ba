using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005E RID: 94
	[Serializable]
	public class IKSolverTrigonometric : IKSolver
	{
		// Token: 0x06000390 RID: 912 RVA: 0x000176E4 File Offset: 0x000158E4
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
			if (!base.initiated)
			{
				return;
			}
			if (weight <= 0f)
			{
				return;
			}
			Vector3 vector = Vector3.Cross(goalPosition - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
			if (vector != Vector3.zero)
			{
				if (weight >= 1f)
				{
					this.bendNormal = vector;
					return;
				}
				this.bendNormal = Vector3.Lerp(this.bendNormal, vector, weight);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0001776C File Offset: 0x0001596C
		public void SetBendPlaneToCurrent()
		{
			if (!base.initiated)
			{
				return;
			}
			Vector3 lhs = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (lhs != Vector3.zero)
			{
				this.bendNormal = lhs;
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000177E6 File Offset: 0x000159E6
		public void SetIKRotation(Quaternion rotation)
		{
			this.IKRotation = rotation;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000177EF File Offset: 0x000159EF
		public void SetIKRotationWeight(float weight)
		{
			this.IKRotationWeight = Mathf.Clamp(weight, 0f, 1f);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00017807 File Offset: 0x00015A07
		public Quaternion GetIKRotation()
		{
			return this.IKRotation;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001780F File Offset: 0x00015A0F
		public float GetIKRotationWeight()
		{
			return this.IKRotationWeight;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00017817 File Offset: 0x00015A17
		public override IKSolver.Point[] GetPoints()
		{
			return new IKSolver.Point[]
			{
				this.bone1,
				this.bone2,
				this.bone3
			};
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0001783C File Offset: 0x00015A3C
		public override IKSolver.Point GetPoint(Transform transform)
		{
			if (this.bone1.transform == transform)
			{
				return this.bone1;
			}
			if (this.bone2.transform == transform)
			{
				return this.bone2;
			}
			if (this.bone3.transform == transform)
			{
				return this.bone3;
			}
			return null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00017898 File Offset: 0x00015A98
		public override void StoreDefaultLocalState()
		{
			this.bone1.StoreDefaultLocalState();
			this.bone2.StoreDefaultLocalState();
			this.bone3.StoreDefaultLocalState();
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000178BB File Offset: 0x00015ABB
		public override void FixTransforms()
		{
			if (!base.initiated)
			{
				return;
			}
			this.bone1.FixTransform();
			this.bone2.FixTransform();
			this.bone3.FixTransform();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000178E8 File Offset: 0x00015AE8
		public override bool IsValid(ref string message)
		{
			if (this.bone1.transform == null || this.bone2.transform == null || this.bone3.transform == null)
			{
				message = "Please assign all Bones to the IK solver.";
				return false;
			}
			Object[] objects = new Transform[]
			{
				this.bone1.transform,
				this.bone2.transform,
				this.bone3.transform
			};
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in the Bones.";
				return false;
			}
			if (this.bone1.transform.position == this.bone2.transform.position)
			{
				message = "first bone position is the same as second bone position.";
				return false;
			}
			if (this.bone2.transform.position == this.bone3.transform.position)
			{
				message = "second bone position is the same as third bone position.";
				return false;
			}
			return true;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000179F2 File Offset: 0x00015BF2
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			this.bone1.transform = bone1;
			this.bone2.transform = bone2;
			this.bone3.transform = bone3;
			base.Initiate(root);
			return base.initiated;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00017A28 File Offset: 0x00015C28
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
			if (weight <= 0f)
			{
				return;
			}
			targetPosition = Vector3.Lerp(bone3.position, targetPosition, weight);
			Vector3 vector = targetPosition - bone1.position;
			float magnitude = vector.magnitude;
			if (magnitude == 0f)
			{
				return;
			}
			float sqrMagnitude = (bone2.position - bone1.position).sqrMagnitude;
			float sqrMagnitude2 = (bone3.position - bone2.position).sqrMagnitude;
			Vector3 bendDirection = Vector3.Cross(vector, bendNormal);
			Vector3 directionToBendPoint = IKSolverTrigonometric.GetDirectionToBendPoint(vector, magnitude, bendDirection, sqrMagnitude, sqrMagnitude2);
			Quaternion quaternion = Quaternion.FromToRotation(bone2.position - bone1.position, directionToBendPoint);
			if (weight < 1f)
			{
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, weight);
			}
			bone1.rotation = quaternion * bone1.rotation;
			Quaternion quaternion2 = Quaternion.FromToRotation(bone3.position - bone2.position, targetPosition - bone2.position);
			if (weight < 1f)
			{
				quaternion2 = Quaternion.Lerp(Quaternion.identity, quaternion2, weight);
			}
			bone2.rotation = quaternion2 * bone2.rotation;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00017B50 File Offset: 0x00015D50
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			float num = (directionMag * directionMag + (sqrMag1 - sqrMag2)) / 2f / directionMag;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(sqrMag1 - num * num, 0f, float.PositiveInfinity));
			if (direction == Vector3.zero)
			{
				return Vector3.zero;
			}
			return Quaternion.LookRotation(direction, bendDirection) * new Vector3(0f, y, num);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00017BB8 File Offset: 0x00015DB8
		protected override void OnInitiate()
		{
			if (this.bendNormal == Vector3.zero)
			{
				this.bendNormal = Vector3.right;
			}
			this.OnInitiateVirtual();
			this.IKPosition = this.bone3.transform.position;
			this.IKRotation = this.bone3.transform.rotation;
			this.InitiateBones();
			this.directHierarchy = this.IsDirectHierarchy();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00017C28 File Offset: 0x00015E28
		private bool IsDirectHierarchy()
		{
			return !(this.bone3.transform.parent != this.bone2.transform) && !(this.bone2.transform.parent != this.bone1.transform);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00017C80 File Offset: 0x00015E80
		public void InitiateBones()
		{
			this.bone1.Initiate(this.bone2.transform.position, this.bendNormal);
			this.bone2.Initiate(this.bone3.transform.position, this.bendNormal);
			this.SetBendPlaneToCurrent();
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00017CD8 File Offset: 0x00015ED8
		protected override void OnUpdate()
		{
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			this.IKRotationWeight = Mathf.Clamp(this.IKRotationWeight, 0f, 1f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
				this.IKRotation = this.target.rotation;
			}
			this.OnUpdateVirtual();
			if (this.IKPositionWeight > 0f)
			{
				if (!this.directHierarchy)
				{
					this.bone1.Initiate(this.bone2.transform.position, this.bendNormal);
					this.bone2.Initiate(this.bone3.transform.position, this.bendNormal);
				}
				this.bone1.sqrMag = (this.bone2.transform.position - this.bone1.transform.position).sqrMagnitude;
				this.bone2.sqrMag = (this.bone3.transform.position - this.bone2.transform.position).sqrMagnitude;
				if (this.bendNormal == Vector3.zero && !Warning.logged)
				{
					base.LogWarning("IKSolverTrigonometric Bend Normal is Vector3.zero.");
				}
				this.weightIKPosition = Vector3.Lerp(this.bone3.transform.position, this.IKPosition, this.IKPositionWeight);
				Vector3 vector = Vector3.Lerp(this.bone1.GetBendNormalFromCurrentRotation(), this.bendNormal, this.IKPositionWeight);
				Vector3 vector2 = Vector3.Lerp(this.bone2.transform.position - this.bone1.transform.position, this.GetBendDirection(this.weightIKPosition, vector), this.IKPositionWeight);
				if (vector2 == Vector3.zero)
				{
					vector2 = this.bone2.transform.position - this.bone1.transform.position;
				}
				this.bone1.transform.rotation = this.bone1.GetRotation(vector2, vector);
				this.bone2.transform.rotation = this.bone2.GetRotation(this.weightIKPosition - this.bone2.transform.position, this.bone2.GetBendNormalFromCurrentRotation());
			}
			if (this.IKRotationWeight > 0f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.IKRotation, this.IKRotationWeight);
			}
			this.OnPostSolveVirtual();
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00017F96 File Offset: 0x00016196
		protected virtual void OnInitiateVirtual()
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00017F98 File Offset: 0x00016198
		protected virtual void OnUpdateVirtual()
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00017F9A File Offset: 0x0001619A
		protected virtual void OnPostSolveVirtual()
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00017F9C File Offset: 0x0001619C
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			Vector3 vector = IKPosition - this.bone1.transform.position;
			if (vector == Vector3.zero)
			{
				return Vector3.zero;
			}
			float sqrMagnitude = vector.sqrMagnitude;
			float num = (float)Math.Sqrt((double)sqrMagnitude);
			float num2 = (sqrMagnitude + this.bone1.sqrMag - this.bone2.sqrMag) / 2f / num;
			float y = (float)Math.Sqrt((double)Mathf.Clamp(this.bone1.sqrMag - num2 * num2, 0f, float.PositiveInfinity));
			Vector3 upwards = Vector3.Cross(vector / num, bendNormal);
			return Quaternion.LookRotation(vector, upwards) * new Vector3(0f, y, num2);
		}

		// Token: 0x040002AB RID: 683
		public Transform target;

		// Token: 0x040002AC RID: 684
		[Range(0f, 1f)]
		public float IKRotationWeight = 1f;

		// Token: 0x040002AD RID: 685
		public Quaternion IKRotation = Quaternion.identity;

		// Token: 0x040002AE RID: 686
		public Vector3 bendNormal = Vector3.right;

		// Token: 0x040002AF RID: 687
		public IKSolverTrigonometric.TrigonometricBone bone1 = new IKSolverTrigonometric.TrigonometricBone();

		// Token: 0x040002B0 RID: 688
		public IKSolverTrigonometric.TrigonometricBone bone2 = new IKSolverTrigonometric.TrigonometricBone();

		// Token: 0x040002B1 RID: 689
		public IKSolverTrigonometric.TrigonometricBone bone3 = new IKSolverTrigonometric.TrigonometricBone();

		// Token: 0x040002B2 RID: 690
		protected Vector3 weightIKPosition;

		// Token: 0x040002B3 RID: 691
		protected bool directHierarchy = true;

		// Token: 0x020000EC RID: 236
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone
		{
			// Token: 0x060006F4 RID: 1780 RVA: 0x0002D42C File Offset: 0x0002B62C
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
				Quaternion rotation = Quaternion.LookRotation(childPosition - this.transform.position, bendNormal);
				this.targetToLocalSpace = QuaTools.RotationToLocalSpace(this.transform.rotation, rotation);
				this.defaultLocalBendNormal = Quaternion.Inverse(this.transform.rotation) * bendNormal;
			}

			// Token: 0x060006F5 RID: 1781 RVA: 0x0002D484 File Offset: 0x0002B684
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return Quaternion.LookRotation(direction, bendNormal) * this.targetToLocalSpace;
			}

			// Token: 0x060006F6 RID: 1782 RVA: 0x0002D498 File Offset: 0x0002B698
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return this.transform.rotation * this.defaultLocalBendNormal;
			}

			// Token: 0x0400068F RID: 1679
			private Quaternion targetToLocalSpace;

			// Token: 0x04000690 RID: 1680
			private Vector3 defaultLocalBendNormal;
		}
	}
}
