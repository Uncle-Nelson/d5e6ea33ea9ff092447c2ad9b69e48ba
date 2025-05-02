using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200007C RID: 124
	public class LookAtController : MonoBehaviour
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x000202F9 File Offset: 0x0001E4F9
		private void Start()
		{
			this.lastPosition = this.ik.solver.IKPosition;
			this.dir = this.ik.solver.IKPosition - this.pivot;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00020334 File Offset: 0x0001E534
		private void LateUpdate()
		{
			if (this.target != this.lastTarget)
			{
				if (this.lastTarget == null && this.target != null && this.ik.solver.IKPositionWeight <= 0f)
				{
					this.lastPosition = this.target.position;
					this.dir = this.target.position - this.pivot;
					this.ik.solver.IKPosition = this.target.position + this.offset;
				}
				else
				{
					this.lastPosition = this.ik.solver.IKPosition;
					this.dir = this.ik.solver.IKPosition - this.pivot;
				}
				this.switchWeight = 0f;
				this.lastTarget = this.target;
			}
			float num = (this.target != null) ? this.weight : 0f;
			this.ik.solver.IKPositionWeight = Mathf.SmoothDamp(this.ik.solver.IKPositionWeight, num, ref this.weightV, this.weightSmoothTime);
			if (this.ik.solver.IKPositionWeight >= 0.999f && num > this.ik.solver.IKPositionWeight)
			{
				this.ik.solver.IKPositionWeight = 1f;
			}
			if (this.ik.solver.IKPositionWeight <= 0.001f && num < this.ik.solver.IKPositionWeight)
			{
				this.ik.solver.IKPositionWeight = 0f;
			}
			if (this.ik.solver.IKPositionWeight <= 0f)
			{
				return;
			}
			this.switchWeight = Mathf.SmoothDamp(this.switchWeight, 1f, ref this.switchWeightV, this.targetSwitchSmoothTime);
			if (this.switchWeight >= 0.999f)
			{
				this.switchWeight = 1f;
			}
			if (this.target != null)
			{
				this.ik.solver.IKPosition = Vector3.Lerp(this.lastPosition, this.target.position + this.offset, this.switchWeight);
			}
			if (this.smoothTurnTowardsTarget != this.lastSmoothTowardsTarget)
			{
				this.dir = this.ik.solver.IKPosition - this.pivot;
				this.lastSmoothTowardsTarget = this.smoothTurnTowardsTarget;
			}
			if (this.smoothTurnTowardsTarget)
			{
				Vector3 b = this.ik.solver.IKPosition - this.pivot;
				this.dir = Vector3.Slerp(this.dir, b, Time.deltaTime * this.slerpSpeed);
				this.dir = Vector3.RotateTowards(this.dir, b, Time.deltaTime * this.maxRadiansDelta, this.maxMagnitudeDelta);
				this.ik.solver.IKPosition = this.pivot + this.dir;
			}
			this.ApplyMinDistance();
			this.RootRotation();
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x0002065E File Offset: 0x0001E85E
		private Vector3 pivot
		{
			get
			{
				return this.ik.transform.position + this.ik.transform.rotation * this.pivotOffsetFromRoot;
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00020690 File Offset: 0x0001E890
		private void ApplyMinDistance()
		{
			Vector3 pivot = this.pivot;
			Vector3 b = this.ik.solver.IKPosition - pivot;
			b = b.normalized * Mathf.Max(b.magnitude, this.minDistance);
			this.ik.solver.IKPosition = pivot + b;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000206F4 File Offset: 0x0001E8F4
		private void RootRotation()
		{
			float num = Mathf.Lerp(180f, this.maxRootAngle, this.ik.solver.IKPositionWeight);
			if (num < 180f)
			{
				Vector3 vector = Quaternion.Inverse(this.ik.transform.rotation) * (this.ik.solver.IKPosition - this.pivot);
				float num2 = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
				float angle = 0f;
				if (num2 > num)
				{
					angle = num2 - num;
				}
				if (num2 < -num)
				{
					angle = num2 + num;
				}
				this.ik.transform.rotation = Quaternion.AngleAxis(angle, this.ik.transform.up) * this.ik.transform.rotation;
			}
		}

		// Token: 0x040003B2 RID: 946
		public LookAtIK ik;

		// Token: 0x040003B3 RID: 947
		[Header("Target Smoothing")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		public Transform target;

		// Token: 0x040003B4 RID: 948
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x040003B5 RID: 949
		public Vector3 offset;

		// Token: 0x040003B6 RID: 950
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime = 0.3f;

		// Token: 0x040003B7 RID: 951
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime = 0.3f;

		// Token: 0x040003B8 RID: 952
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget = true;

		// Token: 0x040003B9 RID: 953
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta = 3f;

		// Token: 0x040003BA RID: 954
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta = 3f;

		// Token: 0x040003BB RID: 955
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed = 3f;

		// Token: 0x040003BC RID: 956
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot = Vector3.up;

		// Token: 0x040003BD RID: 957
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance = 1f;

		// Token: 0x040003BE RID: 958
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle = 45f;

		// Token: 0x040003BF RID: 959
		private Transform lastTarget;

		// Token: 0x040003C0 RID: 960
		private float switchWeight;

		// Token: 0x040003C1 RID: 961
		private float switchWeightV;

		// Token: 0x040003C2 RID: 962
		private float weightV;

		// Token: 0x040003C3 RID: 963
		private Vector3 lastPosition;

		// Token: 0x040003C4 RID: 964
		private Vector3 dir;

		// Token: 0x040003C5 RID: 965
		private bool lastSmoothTowardsTarget;
	}
}
