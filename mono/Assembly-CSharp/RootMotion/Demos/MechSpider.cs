using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200008D RID: 141
	public class MechSpider : MonoBehaviour
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00023968 File Offset: 0x00021B68
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00023970 File Offset: 0x00021B70
		public Vector3 velocity { get; private set; }

		// Token: 0x06000547 RID: 1351 RVA: 0x00023979 File Offset: 0x00021B79
		private void Start()
		{
			this.lastPosition = base.transform.position;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0002398C File Offset: 0x00021B8C
		private void Update()
		{
			this.velocity = (base.transform.position - this.lastPosition) / Time.deltaTime;
			this.lastPosition = base.transform.position;
			Vector3 legsPlaneNormal = this.GetLegsPlaneNormal();
			Quaternion lhs = Quaternion.FromToRotation(base.transform.up, legsPlaneNormal);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, lhs * base.transform.rotation, Time.deltaTime * this.rootRotationSpeed);
			Vector3 a = Vector3.Project(this.GetLegCentroid() + base.transform.up * this.height * this.scale - base.transform.position, base.transform.up);
			base.transform.position += a * Time.deltaTime * (this.rootPositionSpeed * this.scale);
			if (Physics.Raycast(base.transform.position + base.transform.up * this.raycastHeight * this.scale, -base.transform.up, out this.rootHit, this.raycastHeight * this.scale + this.raycastDistance * this.scale, this.raycastLayers))
			{
				this.rootHit.distance = this.rootHit.distance - (this.raycastHeight * this.scale + this.minHeight * this.scale);
				if (this.rootHit.distance < 0f)
				{
					Vector3 b = base.transform.position - base.transform.up * this.rootHit.distance;
					base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.rootPositionSpeed * this.scale);
				}
			}
			this.sine += Time.deltaTime * this.breatheSpeed;
			if (this.sine >= 6.2831855f)
			{
				this.sine -= 6.2831855f;
			}
			float d = Mathf.Sin(this.sine) * this.breatheMagnitude * this.scale;
			Vector3 b2 = base.transform.up * d;
			this.body.transform.position = base.transform.position + b2;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00023C3C File Offset: 0x00021E3C
		private Vector3 GetLegCentroid()
		{
			Vector3 vector = Vector3.zero;
			float d = 1f / (float)this.legs.Length;
			for (int i = 0; i < this.legs.Length; i++)
			{
				vector += this.legs[i].position * d;
			}
			return vector;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00023C90 File Offset: 0x00021E90
		private Vector3 GetLegsPlaneNormal()
		{
			Vector3 vector = base.transform.up;
			if (this.legRotationWeight <= 0f)
			{
				return vector;
			}
			float t = 1f / Mathf.Lerp((float)this.legs.Length, 1f, this.legRotationWeight);
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].position - (base.transform.position - base.transform.up * this.height * this.scale);
				Vector3 up = base.transform.up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref up, ref fromDirection);
				Quaternion quaternion = Quaternion.FromToRotation(fromDirection, vector2);
				quaternion = Quaternion.Lerp(Quaternion.identity, quaternion, t);
				vector = quaternion * vector;
			}
			return vector;
		}

		// Token: 0x04000425 RID: 1061
		public LayerMask raycastLayers;

		// Token: 0x04000426 RID: 1062
		public float scale = 1f;

		// Token: 0x04000427 RID: 1063
		public Transform body;

		// Token: 0x04000428 RID: 1064
		public MechSpiderLeg[] legs;

		// Token: 0x04000429 RID: 1065
		public float legRotationWeight = 1f;

		// Token: 0x0400042A RID: 1066
		public float rootPositionSpeed = 5f;

		// Token: 0x0400042B RID: 1067
		public float rootRotationSpeed = 30f;

		// Token: 0x0400042C RID: 1068
		public float breatheSpeed = 2f;

		// Token: 0x0400042D RID: 1069
		public float breatheMagnitude = 0.2f;

		// Token: 0x0400042E RID: 1070
		public float height = 3.5f;

		// Token: 0x0400042F RID: 1071
		public float minHeight = 2f;

		// Token: 0x04000430 RID: 1072
		public float raycastHeight = 10f;

		// Token: 0x04000431 RID: 1073
		public float raycastDistance = 5f;

		// Token: 0x04000433 RID: 1075
		private Vector3 lastPosition;

		// Token: 0x04000434 RID: 1076
		private Vector3 defaultBodyLocalPosition;

		// Token: 0x04000435 RID: 1077
		private float sine;

		// Token: 0x04000436 RID: 1078
		private RaycastHit rootHit;
	}
}
