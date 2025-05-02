using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000097 RID: 151
	public class ExplosionDemo : MonoBehaviour
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x000253A0 File Offset: 0x000235A0
		private void Start()
		{
			this.defaultScale = base.transform.localScale;
			this.r = this.character.GetComponent<Rigidbody>();
			this.ik = this.character.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000253D8 File Offset: 0x000235D8
		private void Update()
		{
			this.weight = Mathf.Clamp(this.weight - Time.deltaTime * this.weightFalloffSpeed, 0f, 1f);
			if (Input.GetKeyDown(KeyCode.E) && this.character.isGrounded)
			{
				this.ik.solver.IKPositionWeight = 1f;
				this.ik.solver.leftHandEffector.position = this.ik.solver.leftHandEffector.bone.position;
				this.ik.solver.rightHandEffector.position = this.ik.solver.rightHandEffector.bone.position;
				this.ik.solver.leftFootEffector.position = this.ik.solver.leftFootEffector.bone.position;
				this.ik.solver.rightFootEffector.position = this.ik.solver.rightFootEffector.bone.position;
				this.weight = 1f;
				Vector3 vector = this.r.position - base.transform.position;
				vector.y = 0f;
				float d = this.explosionForceByDistance.Evaluate(vector.magnitude);
				this.r.velocity = (vector.normalized + Vector3.up * this.upForce) * d * this.forceMlp;
			}
			if (this.weight < 0.5f && this.character.isGrounded)
			{
				this.weight = Mathf.Clamp(this.weight - Time.deltaTime * 3f, 0f, 1f);
			}
			this.SetEffectorWeights(this.weightFalloff.Evaluate(this.weight));
			base.transform.localScale = this.scale.Evaluate(this.weight) * this.defaultScale;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000255F8 File Offset: 0x000237F8
		private void SetEffectorWeights(float w)
		{
			this.ik.solver.leftHandEffector.positionWeight = w;
			this.ik.solver.rightHandEffector.positionWeight = w;
			this.ik.solver.leftFootEffector.positionWeight = w;
			this.ik.solver.rightFootEffector.positionWeight = w;
		}

		// Token: 0x04000478 RID: 1144
		public SimpleLocomotion character;

		// Token: 0x04000479 RID: 1145
		public float forceMlp = 1f;

		// Token: 0x0400047A RID: 1146
		public float upForce = 1f;

		// Token: 0x0400047B RID: 1147
		public float weightFalloffSpeed = 1f;

		// Token: 0x0400047C RID: 1148
		public AnimationCurve weightFalloff;

		// Token: 0x0400047D RID: 1149
		public AnimationCurve explosionForceByDistance;

		// Token: 0x0400047E RID: 1150
		public AnimationCurve scale;

		// Token: 0x0400047F RID: 1151
		private float weight;

		// Token: 0x04000480 RID: 1152
		private Vector3 defaultScale = Vector3.one;

		// Token: 0x04000481 RID: 1153
		private Rigidbody r;

		// Token: 0x04000482 RID: 1154
		private FullBodyBipedIK ik;
	}
}
