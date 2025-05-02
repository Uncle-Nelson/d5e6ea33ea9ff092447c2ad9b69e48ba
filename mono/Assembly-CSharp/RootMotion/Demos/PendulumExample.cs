using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A7 RID: 167
	public class PendulumExample : MonoBehaviour
	{
		// Token: 0x060005B7 RID: 1463 RVA: 0x00026F28 File Offset: 0x00025128
		private void Start()
		{
			this.ik = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.rootRelativeToPelvis = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.pelvisToRoot = Quaternion.Inverse(this.ik.references.pelvis.rotation) * (base.transform.position - this.ik.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.lastWeight = this.weight;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00027034 File Offset: 0x00025234
		private void LateUpdate()
		{
			if (this.weight > 0f)
			{
				this.ik.solver.leftHandEffector.positionWeight = this.weight;
				this.ik.solver.leftHandEffector.rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.lastWeight > 0f)
				{
					this.ik.solver.leftHandEffector.positionWeight = 0f;
					this.ik.solver.leftHandEffector.rotationWeight = 0f;
				}
			}
			this.lastWeight = this.weight;
			if (this.weight <= 0f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.pelvisToRoot * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.rootRelativeToPelvis, this.weight);
			this.ik.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.ik.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.ik.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.ik.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.ik.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.ik.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.ik.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.ik.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.ik.references.rightThigh.rotation;
		}

		// Token: 0x040004DF RID: 1247
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x040004E0 RID: 1248
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp = 1.3f;

		// Token: 0x040004E1 RID: 1249
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		// Token: 0x040004E2 RID: 1250
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		// Token: 0x040004E3 RID: 1251
		public Transform target;

		// Token: 0x040004E4 RID: 1252
		public Transform leftHandTarget;

		// Token: 0x040004E5 RID: 1253
		public Transform rightHandTarget;

		// Token: 0x040004E6 RID: 1254
		public Transform leftFootTarget;

		// Token: 0x040004E7 RID: 1255
		public Transform rightFootTarget;

		// Token: 0x040004E8 RID: 1256
		public Transform pelvisTarget;

		// Token: 0x040004E9 RID: 1257
		public Transform bodyTarget;

		// Token: 0x040004EA RID: 1258
		public Transform headTarget;

		// Token: 0x040004EB RID: 1259
		public Vector3 pelvisDownAxis = Vector3.right;

		// Token: 0x040004EC RID: 1260
		private FullBodyBipedIK ik;

		// Token: 0x040004ED RID: 1261
		private Quaternion rootRelativeToPelvis;

		// Token: 0x040004EE RID: 1262
		private Vector3 pelvisToRoot;

		// Token: 0x040004EF RID: 1263
		private float lastWeight;
	}
}
