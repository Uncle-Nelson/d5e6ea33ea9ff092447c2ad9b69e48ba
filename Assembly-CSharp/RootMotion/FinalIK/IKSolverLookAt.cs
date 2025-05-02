using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005D RID: 93
	[Serializable]
	public class IKSolverLookAt : IKSolver
	{
		// Token: 0x06000375 RID: 885 RVA: 0x000168D1 File Offset: 0x00014AD1
		public void SetLookAtWeight(float weight)
		{
			this.IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000168E9 File Offset: 0x00014AE9
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
			this.IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00016918 File Offset: 0x00014B18
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
			this.IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
			this.headWeight = Mathf.Clamp(headWeight, 0f, 1f);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00016968 File Offset: 0x00014B68
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
			this.IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
			this.headWeight = Mathf.Clamp(headWeight, 0f, 1f);
			this.eyesWeight = Mathf.Clamp(eyesWeight, 0f, 1f);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000169D0 File Offset: 0x00014BD0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
			this.IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
			this.headWeight = Mathf.Clamp(headWeight, 0f, 1f);
			this.eyesWeight = Mathf.Clamp(eyesWeight, 0f, 1f);
			this.clampWeight = Mathf.Clamp(clampWeight, 0f, 1f);
			this.clampWeightHead = this.clampWeight;
			this.clampWeightEyes = this.clampWeight;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00016A68 File Offset: 0x00014C68
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
			this.IKPositionWeight = Mathf.Clamp(weight, 0f, 1f);
			this.bodyWeight = Mathf.Clamp(bodyWeight, 0f, 1f);
			this.headWeight = Mathf.Clamp(headWeight, 0f, 1f);
			this.eyesWeight = Mathf.Clamp(eyesWeight, 0f, 1f);
			this.clampWeight = Mathf.Clamp(clampWeight, 0f, 1f);
			this.clampWeightHead = Mathf.Clamp(clampWeightHead, 0f, 1f);
			this.clampWeightEyes = Mathf.Clamp(clampWeightEyes, 0f, 1f);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00016B14 File Offset: 0x00014D14
		public override void StoreDefaultLocalState()
		{
			for (int i = 0; i < this.spine.Length; i++)
			{
				this.spine[i].StoreDefaultLocalState();
			}
			for (int j = 0; j < this.eyes.Length; j++)
			{
				this.eyes[j].StoreDefaultLocalState();
			}
			if (this.head != null && this.head.transform != null)
			{
				this.head.StoreDefaultLocalState();
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00016B87 File Offset: 0x00014D87
		public void SetDirty()
		{
			this.isDirty = true;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00016B90 File Offset: 0x00014D90
		public override void FixTransforms()
		{
			if (!base.initiated)
			{
				return;
			}
			if (this.IKPositionWeight <= 0f && !this.isDirty)
			{
				return;
			}
			for (int i = 0; i < this.spine.Length; i++)
			{
				this.spine[i].FixTransform();
			}
			for (int j = 0; j < this.eyes.Length; j++)
			{
				this.eyes[j].FixTransform();
			}
			if (this.head != null && this.head.transform != null)
			{
				this.head.FixTransform();
			}
			this.isDirty = false;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00016C2C File Offset: 0x00014E2C
		public override bool IsValid(ref string message)
		{
			if (!this.spineIsValid)
			{
				message = "IKSolverLookAt spine setup is invalid. Can't initiate solver.";
				return false;
			}
			if (!this.headIsValid)
			{
				message = "IKSolverLookAt head transform is null. Can't initiate solver.";
				return false;
			}
			if (!this.eyesIsValid)
			{
				message = "IKSolverLookAt eyes setup is invalid. Can't initiate solver.";
				return false;
			}
			if (this.spineIsEmpty && this.headIsEmpty && this.eyesIsEmpty)
			{
				message = "IKSolverLookAt eyes setup is invalid. Can't initiate solver.";
				return false;
			}
			IKSolver.Bone[] bones = this.spine;
			Transform transform = IKSolver.ContainsDuplicateBone(bones);
			if (transform != null)
			{
				message = transform.name + " is represented multiple times in a single IK chain. Can't initiate solver.";
				return false;
			}
			bones = this.eyes;
			Transform transform2 = IKSolver.ContainsDuplicateBone(bones);
			if (transform2 != null)
			{
				message = transform2.name + " is represented multiple times in a single IK chain. Can't initiate solver.";
				return false;
			}
			return true;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00016CE4 File Offset: 0x00014EE4
		public override IKSolver.Point[] GetPoints()
		{
			IKSolver.Point[] array = new IKSolver.Point[this.spine.Length + this.eyes.Length + ((this.head.transform != null) ? 1 : 0)];
			for (int i = 0; i < this.spine.Length; i++)
			{
				array[i] = this.spine[i];
			}
			int num = 0;
			for (int j = this.spine.Length; j < this.spine.Length + this.eyes.Length; j++)
			{
				array[j] = this.eyes[num];
				num++;
			}
			if (this.head.transform != null)
			{
				array[array.Length - 1] = this.head;
			}
			return array;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00016D94 File Offset: 0x00014F94
		public override IKSolver.Point GetPoint(Transform transform)
		{
			foreach (IKSolverLookAt.LookAtBone lookAtBone in this.spine)
			{
				if (lookAtBone.transform == transform)
				{
					return lookAtBone;
				}
			}
			foreach (IKSolverLookAt.LookAtBone lookAtBone2 in this.eyes)
			{
				if (lookAtBone2.transform == transform)
				{
					return lookAtBone2;
				}
			}
			if (this.head.transform == transform)
			{
				return this.head;
			}
			return null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00016E0E File Offset: 0x0001500E
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			this.SetBones(spine, ref this.spine);
			this.head = new IKSolverLookAt.LookAtBone(head);
			this.SetBones(eyes, ref this.eyes);
			base.Initiate(root);
			return base.initiated;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00016E44 File Offset: 0x00015044
		protected override void OnInitiate()
		{
			if (this.firstInitiation || !Application.isPlaying)
			{
				if (this.spine.Length != 0)
				{
					this.IKPosition = this.spine[this.spine.Length - 1].transform.position + this.root.forward * 3f;
				}
				else if (this.head.transform != null)
				{
					this.IKPosition = this.head.transform.position + this.root.forward * 3f;
				}
				else if (this.eyes.Length != 0 && this.eyes[0].transform != null)
				{
					this.IKPosition = this.eyes[0].transform.position + this.root.forward * 3f;
				}
			}
			IKSolverLookAt.LookAtBone[] array = this.spine;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Initiate(this.root);
			}
			if (this.head != null)
			{
				this.head.Initiate(this.root);
			}
			array = this.eyes;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Initiate(this.root);
			}
			if (this.spineForwards == null || this.spineForwards.Length != this.spine.Length)
			{
				this.spineForwards = new Vector3[this.spine.Length];
			}
			if (this.headForwards == null)
			{
				this.headForwards = new Vector3[1];
			}
			if (this.eyeForward == null)
			{
				this.eyeForward = new Vector3[1];
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00016FF8 File Offset: 0x000151F8
		protected override void OnUpdate()
		{
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			this.SolveSpine();
			this.SolveHead();
			this.SolveEyes();
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00017060 File Offset: 0x00015260
		protected bool spineIsValid
		{
			get
			{
				if (this.spine == null)
				{
					return false;
				}
				if (this.spine.Length == 0)
				{
					return true;
				}
				for (int i = 0; i < this.spine.Length; i++)
				{
					if (this.spine[i] == null || this.spine[i].transform == null)
					{
						return false;
					}
				}
				return true;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000170B7 File Offset: 0x000152B7
		protected bool spineIsEmpty
		{
			get
			{
				return this.spine.Length == 0;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000170C4 File Offset: 0x000152C4
		protected void SolveSpine()
		{
			if (this.bodyWeight <= 0f)
			{
				return;
			}
			if (this.spineIsEmpty)
			{
				return;
			}
			Vector3 normalized = (this.IKPosition + this.spineTargetOffset - this.spine[this.spine.Length - 1].transform.position).normalized;
			this.GetForwards(ref this.spineForwards, this.spine[0].forward, normalized, this.spine.Length, this.clampWeight);
			for (int i = 0; i < this.spine.Length; i++)
			{
				this.spine[i].LookAt(this.spineForwards[i], this.bodyWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00017184 File Offset: 0x00015384
		protected bool headIsValid
		{
			get
			{
				return this.head != null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00017191 File Offset: 0x00015391
		protected bool headIsEmpty
		{
			get
			{
				return this.head.transform == null;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000171A4 File Offset: 0x000153A4
		protected void SolveHead()
		{
			if (this.headWeight <= 0f)
			{
				return;
			}
			if (this.headIsEmpty)
			{
				return;
			}
			Vector3 vector = (this.spine.Length != 0 && this.spine[this.spine.Length - 1].transform != null) ? this.spine[this.spine.Length - 1].forward : this.head.forward;
			Vector3 normalized = Vector3.Lerp(vector, (this.IKPosition - this.head.transform.position).normalized, this.headWeight * this.IKPositionWeight).normalized;
			this.GetForwards(ref this.headForwards, vector, normalized, 1, this.clampWeightHead);
			this.head.LookAt(this.headForwards[0], this.headWeight * this.IKPositionWeight);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0001728C File Offset: 0x0001548C
		protected bool eyesIsValid
		{
			get
			{
				if (this.eyes == null)
				{
					return false;
				}
				if (this.eyes.Length == 0)
				{
					return true;
				}
				for (int i = 0; i < this.eyes.Length; i++)
				{
					if (this.eyes[i] == null || this.eyes[i].transform == null)
					{
						return false;
					}
				}
				return true;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600038B RID: 907 RVA: 0x000172E3 File Offset: 0x000154E3
		protected bool eyesIsEmpty
		{
			get
			{
				return this.eyes.Length == 0;
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000172F0 File Offset: 0x000154F0
		protected void SolveEyes()
		{
			if (this.eyesWeight <= 0f)
			{
				return;
			}
			if (this.eyesIsEmpty)
			{
				return;
			}
			for (int i = 0; i < this.eyes.Length; i++)
			{
				Quaternion quaternion = (this.head.transform != null) ? this.head.transform.rotation : ((this.spine.Length != 0) ? this.spine[this.spine.Length - 1].transform.rotation : this.root.rotation);
				Vector3 point = (this.head.transform != null) ? this.head.axis : ((this.spine.Length != 0) ? this.spine[this.spine.Length - 1].axis : this.root.forward);
				if (this.eyes[i].baseForwardOffsetEuler != Vector3.zero)
				{
					quaternion *= Quaternion.Euler(this.eyes[i].baseForwardOffsetEuler);
				}
				Vector3 baseForward = quaternion * point;
				this.GetForwards(ref this.eyeForward, baseForward, (this.IKPosition - this.eyes[i].transform.position).normalized, 1, this.clampWeightEyes);
				this.eyes[i].LookAt(this.eyeForward[0], this.eyesWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001746C File Offset: 0x0001566C
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			if (clamp >= 1f || this.IKPositionWeight <= 0f)
			{
				for (int i = 0; i < forwards.Length; i++)
				{
					forwards[i] = baseForward;
				}
				return forwards;
			}
			float num = Vector3.Angle(baseForward, targetForward);
			float num2 = 1f - num / 180f;
			float num3 = (clamp > 0f) ? Mathf.Clamp(1f - (clamp - num2) / (1f - num2), 0f, 1f) : 1f;
			float num4 = (clamp > 0f) ? Mathf.Clamp(num2 / clamp, 0f, 1f) : 1f;
			for (int j = 0; j < this.clampSmoothing; j++)
			{
				num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
			}
			if (forwards.Length == 1)
			{
				forwards[0] = Vector3.Slerp(baseForward, targetForward, num4 * num3);
			}
			else
			{
				float num5 = 1f / (float)(forwards.Length - 1);
				for (int k = 0; k < forwards.Length; k++)
				{
					forwards[k] = Vector3.Slerp(baseForward, targetForward, this.spineWeightCurve.Evaluate(num5 * (float)k) * num4 * num3);
				}
			}
			return forwards;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000175A8 File Offset: 0x000157A8
		protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones)
		{
			if (array == null)
			{
				bones = new IKSolverLookAt.LookAtBone[0];
				return;
			}
			if (bones.Length != array.Length)
			{
				bones = new IKSolverLookAt.LookAtBone[array.Length];
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (bones[i] == null)
				{
					bones[i] = new IKSolverLookAt.LookAtBone(array[i]);
				}
				else
				{
					bones[i].transform = array[i];
				}
			}
		}

		// Token: 0x0400029A RID: 666
		public Transform target;

		// Token: 0x0400029B RID: 667
		public IKSolverLookAt.LookAtBone[] spine = new IKSolverLookAt.LookAtBone[0];

		// Token: 0x0400029C RID: 668
		public IKSolverLookAt.LookAtBone head = new IKSolverLookAt.LookAtBone();

		// Token: 0x0400029D RID: 669
		public IKSolverLookAt.LookAtBone[] eyes = new IKSolverLookAt.LookAtBone[0];

		// Token: 0x0400029E RID: 670
		[Range(0f, 1f)]
		public float bodyWeight = 0.5f;

		// Token: 0x0400029F RID: 671
		[Range(0f, 1f)]
		public float headWeight = 0.5f;

		// Token: 0x040002A0 RID: 672
		[Range(0f, 1f)]
		public float eyesWeight = 1f;

		// Token: 0x040002A1 RID: 673
		[Range(0f, 1f)]
		public float clampWeight = 0.5f;

		// Token: 0x040002A2 RID: 674
		[Range(0f, 1f)]
		public float clampWeightHead = 0.5f;

		// Token: 0x040002A3 RID: 675
		[Range(0f, 1f)]
		public float clampWeightEyes = 0.5f;

		// Token: 0x040002A4 RID: 676
		[Range(0f, 2f)]
		public int clampSmoothing = 2;

		// Token: 0x040002A5 RID: 677
		public AnimationCurve spineWeightCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0.3f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x040002A6 RID: 678
		public Vector3 spineTargetOffset;

		// Token: 0x040002A7 RID: 679
		protected Vector3[] spineForwards = new Vector3[0];

		// Token: 0x040002A8 RID: 680
		protected Vector3[] headForwards = new Vector3[1];

		// Token: 0x040002A9 RID: 681
		protected Vector3[] eyeForward = new Vector3[1];

		// Token: 0x040002AA RID: 682
		private bool isDirty;

		// Token: 0x020000EB RID: 235
		[Serializable]
		public class LookAtBone : IKSolver.Bone
		{
			// Token: 0x060006EF RID: 1775 RVA: 0x0002D38A File Offset: 0x0002B58A
			public LookAtBone()
			{
			}

			// Token: 0x060006F0 RID: 1776 RVA: 0x0002D392 File Offset: 0x0002B592
			public LookAtBone(Transform transform)
			{
				this.transform = transform;
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x0002D3A1 File Offset: 0x0002B5A1
			public void Initiate(Transform root)
			{
				if (this.transform == null)
				{
					return;
				}
				this.axis = Quaternion.Inverse(this.transform.rotation) * root.forward;
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x0002D3D4 File Offset: 0x0002B5D4
			public void LookAt(Vector3 direction, float weight)
			{
				Quaternion lhs = Quaternion.FromToRotation(this.forward, direction);
				Quaternion rotation = this.transform.rotation;
				this.transform.rotation = Quaternion.Lerp(rotation, lhs * rotation, weight);
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0002D413 File Offset: 0x0002B613
			public Vector3 forward
			{
				get
				{
					return this.transform.rotation * this.axis;
				}
			}

			// Token: 0x0400068E RID: 1678
			public Vector3 baseForwardOffsetEuler;
		}
	}
}
