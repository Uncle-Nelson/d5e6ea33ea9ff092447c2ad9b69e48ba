using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200007B RID: 123
	public class Inertia : OffsetModifier
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x0002026C File Offset: 0x0001E46C
		public void ResetBodies()
		{
			this.lastTime = Time.time;
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Reset();
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000202A4 File Offset: 0x0001E4A4
		protected override void OnModifyOffset()
		{
			Inertia.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Update(this.ik.solver, this.weight, base.deltaTime);
			}
			base.ApplyLimits(this.limits);
		}

		// Token: 0x040003B0 RID: 944
		[Tooltip("The array of Bodies")]
		public Inertia.Body[] bodies;

		// Token: 0x040003B1 RID: 945
		[Tooltip("The array of OffsetLimits")]
		public OffsetModifier.OffsetLimits[] limits;

		// Token: 0x02000111 RID: 273
		[Serializable]
		public class Body
		{
			// Token: 0x060007F1 RID: 2033 RVA: 0x00034361 File Offset: 0x00032561
			public void Reset()
			{
				if (this.transform == null)
				{
					return;
				}
				this.lazyPoint = this.transform.position;
				this.lastPosition = this.transform.position;
				this.direction = Vector3.zero;
			}

			// Token: 0x060007F2 RID: 2034 RVA: 0x000343A0 File Offset: 0x000325A0
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
				if (this.transform == null)
				{
					return;
				}
				if (this.firstUpdate)
				{
					this.Reset();
					this.firstUpdate = false;
				}
				this.direction = Vector3.Lerp(this.direction, (this.transform.position - this.lazyPoint) / deltaTime * 0.01f, deltaTime * this.acceleration);
				this.lazyPoint += this.direction * deltaTime * this.speed;
				this.delta = this.transform.position - this.lastPosition;
				this.lazyPoint += this.delta * this.matchVelocity;
				this.lazyPoint.y = this.lazyPoint.y + this.gravity * deltaTime;
				foreach (Inertia.Body.EffectorLink effectorLink in this.effectorLinks)
				{
					solver.GetEffector(effectorLink.effector).positionOffset += (this.lazyPoint - this.transform.position) * effectorLink.weight * weight;
				}
				this.lastPosition = this.transform.position;
			}

			// Token: 0x040007EB RID: 2027
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			// Token: 0x040007EC RID: 2028
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public Inertia.Body.EffectorLink[] effectorLinks;

			// Token: 0x040007ED RID: 2029
			[Tooltip("The speed to follow the Transform")]
			public float speed = 10f;

			// Token: 0x040007EE RID: 2030
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration = 3f;

			// Token: 0x040007EF RID: 2031
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			// Token: 0x040007F0 RID: 2032
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			// Token: 0x040007F1 RID: 2033
			private Vector3 delta;

			// Token: 0x040007F2 RID: 2034
			private Vector3 lazyPoint;

			// Token: 0x040007F3 RID: 2035
			private Vector3 direction;

			// Token: 0x040007F4 RID: 2036
			private Vector3 lastPosition;

			// Token: 0x040007F5 RID: 2037
			private bool firstUpdate = true;

			// Token: 0x0200013F RID: 319
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040008D4 RID: 2260
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x040008D5 RID: 2261
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}
	}
}
