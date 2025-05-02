using System;
using System.Collections;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200008F RID: 143
	public class MechSpiderLeg : MonoBehaviour
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00023EE3 File Offset: 0x000220E3
		public bool isStepping
		{
			get
			{
				return this.stepProgress < 1f;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00023EF2 File Offset: 0x000220F2
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00023F04 File Offset: 0x00022104
		public Vector3 position
		{
			get
			{
				return this.ik.GetIKSolver().GetIKPosition();
			}
			set
			{
				this.ik.GetIKSolver().SetIKPosition(value);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00023F18 File Offset: 0x00022118
		private void Awake()
		{
			this.ik = base.GetComponent<IK>();
			if (this.foot != null)
			{
				if (this.footUpAxis == Vector3.zero)
				{
					this.footUpAxis = Quaternion.Inverse(this.foot.rotation) * Vector3.up;
				}
				this.lastFootLocalRotation = this.foot.localRotation;
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterIK));
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00023FB0 File Offset: 0x000221B0
		private void AfterIK()
		{
			if (this.foot == null)
			{
				return;
			}
			this.foot.localRotation = this.lastFootLocalRotation;
			this.smoothHitNormal = Vector3.Slerp(this.smoothHitNormal, this.hit.normal, Time.deltaTime * this.footRotationSpeed);
			Quaternion lhs = Quaternion.FromToRotation(this.foot.rotation * this.footUpAxis, this.smoothHitNormal);
			this.foot.rotation = lhs * this.foot.rotation;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00024044 File Offset: 0x00022244
		private void Start()
		{
			this.stepProgress = 1f;
			this.hit = default(RaycastHit);
			IKSolver.Point[] points = this.ik.GetIKSolver().GetPoints();
			this.position = points[points.Length - 1].transform.position;
			this.lastStepPosition = this.position;
			this.hit.point = this.position;
			this.defaultPosition = this.mechSpider.transform.InverseTransformPoint(this.position + this.offset * this.mechSpider.scale);
			base.StartCoroutine(this.Step(this.position, this.position));
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00024100 File Offset: 0x00022300
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			stepFound = false;
			Vector3 a = this.mechSpider.transform.TransformPoint(this.defaultPosition) + this.mechSpider.velocity * this.velocityPrediction;
			Vector3 vector = this.mechSpider.transform.up;
			Vector3 rhs = this.mechSpider.body.position - this.position;
			Vector3 axis = Vector3.Cross(vector, rhs);
			vector = Quaternion.AngleAxis(focus, axis) * vector;
			if (Physics.Raycast(a + vector * this.mechSpider.raycastHeight * this.mechSpider.scale, -vector, out this.hit, this.mechSpider.raycastHeight * this.mechSpider.scale + distance, this.mechSpider.raycastLayers))
			{
				stepFound = true;
			}
			return this.hit.point + this.hit.normal * this.footHeight * this.mechSpider.scale;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00024220 File Offset: 0x00022420
		private void UpdatePosition(float distance)
		{
			Vector3 up = this.mechSpider.transform.up;
			if (Physics.Raycast(this.lastStepPosition + up * this.mechSpider.raycastHeight * this.mechSpider.scale, -up, out this.hit, this.mechSpider.raycastHeight * this.mechSpider.scale + distance, this.mechSpider.raycastLayers))
			{
				this.position = this.hit.point + this.hit.normal * this.footHeight * this.mechSpider.scale;
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000242E4 File Offset: 0x000224E4
		private void Update()
		{
			this.UpdatePosition(this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (this.isStepping)
			{
				return;
			}
			if (Time.time < this.lastStepTime + this.minDelay)
			{
				return;
			}
			if (this.unSync != null && this.unSync.isStepping)
			{
				return;
			}
			bool flag = false;
			Vector3 stepTarget = this.GetStepTarget(out flag, this.raycastFocus, this.mechSpider.raycastDistance * this.mechSpider.scale);
			if (!flag)
			{
				stepTarget = this.GetStepTarget(out flag, -this.raycastFocus, this.mechSpider.raycastDistance * 3f * this.mechSpider.scale);
			}
			if (!flag)
			{
				return;
			}
			if (Vector3.Distance(this.position, stepTarget) < this.maxOffset * this.mechSpider.scale * Random.Range(0.9f, 1.2f))
			{
				return;
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.Step(this.position, stepTarget));
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000243EF File Offset: 0x000225EF
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			this.stepProgress = 0f;
			while (this.stepProgress < 1f)
			{
				this.stepProgress += Time.deltaTime * this.stepSpeed;
				this.position = Vector3.Lerp(stepStartPosition, targetPosition, this.stepProgress);
				this.position += this.mechSpider.transform.up * this.yOffset.Evaluate(this.stepProgress) * this.mechSpider.scale;
				this.lastStepPosition = this.position;
				yield return null;
			}
			this.position = targetPosition;
			this.lastStepPosition = this.position;
			if (this.sand != null)
			{
				this.sand.transform.position = this.position - this.mechSpider.transform.up * this.footHeight * this.mechSpider.scale;
				this.sand.Emit(20);
			}
			this.lastStepTime = Time.time;
			yield break;
		}

		// Token: 0x0400043B RID: 1083
		public MechSpider mechSpider;

		// Token: 0x0400043C RID: 1084
		public MechSpiderLeg unSync;

		// Token: 0x0400043D RID: 1085
		public Vector3 offset;

		// Token: 0x0400043E RID: 1086
		public float minDelay = 0.2f;

		// Token: 0x0400043F RID: 1087
		public float maxOffset = 1f;

		// Token: 0x04000440 RID: 1088
		public float stepSpeed = 5f;

		// Token: 0x04000441 RID: 1089
		public float footHeight = 0.15f;

		// Token: 0x04000442 RID: 1090
		public float velocityPrediction = 0.2f;

		// Token: 0x04000443 RID: 1091
		public float raycastFocus = 0.1f;

		// Token: 0x04000444 RID: 1092
		public AnimationCurve yOffset;

		// Token: 0x04000445 RID: 1093
		public Transform foot;

		// Token: 0x04000446 RID: 1094
		public Vector3 footUpAxis;

		// Token: 0x04000447 RID: 1095
		public float footRotationSpeed = 10f;

		// Token: 0x04000448 RID: 1096
		public ParticleSystem sand;

		// Token: 0x04000449 RID: 1097
		private IK ik;

		// Token: 0x0400044A RID: 1098
		private float stepProgress = 1f;

		// Token: 0x0400044B RID: 1099
		private float lastStepTime;

		// Token: 0x0400044C RID: 1100
		private Vector3 defaultPosition;

		// Token: 0x0400044D RID: 1101
		private RaycastHit hit;

		// Token: 0x0400044E RID: 1102
		private Quaternion lastFootLocalRotation;

		// Token: 0x0400044F RID: 1103
		private Vector3 smoothHitNormal = Vector3.up;

		// Token: 0x04000450 RID: 1104
		private Vector3 lastStepPosition;
	}
}
