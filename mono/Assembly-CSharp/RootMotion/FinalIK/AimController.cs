using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000071 RID: 113
	public class AimController : MonoBehaviour
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x0001EFC8 File Offset: 0x0001D1C8
		private void Start()
		{
			this.lastPosition = this.ik.solver.IKPosition;
			this.dir = this.ik.solver.IKPosition - this.pivot;
			this.ik.solver.target = null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0001F020 File Offset: 0x0001D220
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
				Vector3 vector = this.ik.solver.IKPosition - this.pivot;
				if (this.slerpSpeed > 0f)
				{
					this.dir = Vector3.Slerp(this.dir, vector, Time.deltaTime * this.slerpSpeed);
				}
				if (this.maxRadiansDelta > 0f || this.maxMagnitudeDelta > 0f)
				{
					this.dir = Vector3.RotateTowards(this.dir, vector, Time.deltaTime * this.maxRadiansDelta, this.maxMagnitudeDelta);
				}
				if (this.smoothDampTime > 0f)
				{
					float yaw = V3Tools.GetYaw(this.dir);
					float yaw2 = V3Tools.GetYaw(vector);
					float y = Mathf.SmoothDampAngle(yaw, yaw2, ref this.yawV, this.smoothDampTime);
					float pitch = V3Tools.GetPitch(this.dir);
					float pitch2 = V3Tools.GetPitch(vector);
					float x = Mathf.SmoothDampAngle(pitch, pitch2, ref this.pitchV, this.smoothDampTime);
					float d = Mathf.SmoothDamp(this.dir.magnitude, vector.magnitude, ref this.dirMagV, this.smoothDampTime);
					this.dir = Quaternion.Euler(x, y, 0f) * Vector3.forward * d;
				}
				this.ik.solver.IKPosition = this.pivot + this.dir;
			}
			this.ApplyMinDistance();
			this.RootRotation();
			if (this.useAnimatedAimDirection)
			{
				this.ik.solver.axis = this.ik.solver.transform.InverseTransformVector(this.ik.transform.rotation * this.animatedAimDirection);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0001F462 File Offset: 0x0001D662
		private Vector3 pivot
		{
			get
			{
				return this.ik.transform.position + this.ik.transform.rotation * this.pivotOffsetFromRoot;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0001F494 File Offset: 0x0001D694
		private void ApplyMinDistance()
		{
			Vector3 pivot = this.pivot;
			Vector3 b = this.ik.solver.IKPosition - pivot;
			b = b.normalized * Mathf.Max(b.magnitude, this.minDistance);
			this.ik.solver.IKPosition = pivot + b;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		private void RootRotation()
		{
			float num = Mathf.Lerp(180f, this.maxRootAngle * this.turnToTargetMlp, this.ik.solver.IKPositionWeight);
			if (num < 180f)
			{
				Vector3 vector = Quaternion.Inverse(this.ik.transform.rotation) * (this.ik.solver.IKPosition - this.pivot);
				float num2 = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
				float angle = 0f;
				if (num2 > num)
				{
					angle = num2 - num;
					if (!this.turningToTarget && this.turnToTarget)
					{
						base.StartCoroutine(this.TurnToTarget());
					}
				}
				if (num2 < -num)
				{
					angle = num2 + num;
					if (!this.turningToTarget && this.turnToTarget)
					{
						base.StartCoroutine(this.TurnToTarget());
					}
				}
				this.ik.transform.rotation = Quaternion.AngleAxis(angle, this.ik.transform.up) * this.ik.transform.rotation;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001F612 File Offset: 0x0001D812
		private IEnumerator TurnToTarget()
		{
			this.turningToTarget = true;
			while (this.turnToTargetMlp > 0f)
			{
				this.turnToTargetMlp = Mathf.SmoothDamp(this.turnToTargetMlp, 0f, ref this.turnToTargetMlpV, this.turnToTargetTime);
				if (this.turnToTargetMlp < 0.01f)
				{
					this.turnToTargetMlp = 0f;
				}
				yield return null;
			}
			this.turnToTargetMlp = 1f;
			this.turningToTarget = false;
			yield break;
		}

		// Token: 0x04000379 RID: 889
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		// Token: 0x0400037A RID: 890
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x0400037B RID: 891
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		// Token: 0x0400037C RID: 892
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime = 0.3f;

		// Token: 0x0400037D RID: 893
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime = 0.3f;

		// Token: 0x0400037E RID: 894
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget = true;

		// Token: 0x0400037F RID: 895
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta = 3f;

		// Token: 0x04000380 RID: 896
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta = 3f;

		// Token: 0x04000381 RID: 897
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed = 3f;

		// Token: 0x04000382 RID: 898
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		// Token: 0x04000383 RID: 899
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot = Vector3.up;

		// Token: 0x04000384 RID: 900
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance = 1f;

		// Token: 0x04000385 RID: 901
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		// Token: 0x04000386 RID: 902
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle = 45f;

		// Token: 0x04000387 RID: 903
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		// Token: 0x04000388 RID: 904
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime = 0.2f;

		// Token: 0x04000389 RID: 905
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		// Token: 0x0400038A RID: 906
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection = Vector3.forward;

		// Token: 0x0400038B RID: 907
		private Transform lastTarget;

		// Token: 0x0400038C RID: 908
		private float switchWeight;

		// Token: 0x0400038D RID: 909
		private float switchWeightV;

		// Token: 0x0400038E RID: 910
		private float weightV;

		// Token: 0x0400038F RID: 911
		private Vector3 lastPosition;

		// Token: 0x04000390 RID: 912
		private Vector3 dir;

		// Token: 0x04000391 RID: 913
		private bool lastSmoothTowardsTarget;

		// Token: 0x04000392 RID: 914
		private bool turningToTarget;

		// Token: 0x04000393 RID: 915
		private float turnToTargetMlp = 1f;

		// Token: 0x04000394 RID: 916
		private float turnToTargetMlpV;

		// Token: 0x04000395 RID: 917
		private float yawV;

		// Token: 0x04000396 RID: 918
		private float pitchV;

		// Token: 0x04000397 RID: 919
		private float dirMagV;
	}
}
