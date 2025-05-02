using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000073 RID: 115
	public class Amplifier : OffsetModifier
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x0001F780 File Offset: 0x0001D980
		protected override void OnModifyOffset()
		{
			if (!this.ik.fixTransforms)
			{
				if (!Warning.logged)
				{
					Warning.Log("Amplifier needs the Fix Transforms option of the FBBIK to be set to true. Otherwise it might amplify to infinity, should the animator of the character stop because of culling.", base.transform, false);
				}
				return;
			}
			Amplifier.Body[] array = this.bodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Update(this.ik.solver, this.weight, base.deltaTime);
			}
		}

		// Token: 0x0400039A RID: 922
		[Tooltip("The amplified bodies.")]
		public Amplifier.Body[] bodies;

		// Token: 0x0200010A RID: 266
		[Serializable]
		public class Body
		{
			// Token: 0x060007C3 RID: 1987 RVA: 0x00033950 File Offset: 0x00031B50
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
				if (this.transform == null || this.relativeTo == null)
				{
					return;
				}
				Vector3 a = this.relativeTo.InverseTransformDirection(this.transform.position - this.relativeTo.position);
				if (this.firstUpdate)
				{
					this.lastRelativePos = a;
					this.firstUpdate = false;
				}
				Vector3 vector = (a - this.lastRelativePos) / deltaTime;
				this.smoothDelta = ((this.speed <= 0f) ? vector : Vector3.Lerp(this.smoothDelta, vector, deltaTime * this.speed));
				Vector3 v = this.relativeTo.TransformDirection(this.smoothDelta);
				Vector3 a2 = V3Tools.ExtractVertical(v, solver.GetRoot().up, this.verticalWeight) + V3Tools.ExtractHorizontal(v, solver.GetRoot().up, this.horizontalWeight);
				for (int i = 0; i < this.effectorLinks.Length; i++)
				{
					solver.GetEffector(this.effectorLinks[i].effector).positionOffset += a2 * w * this.effectorLinks[i].weight;
				}
				this.lastRelativePos = a;
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x00033A96 File Offset: 0x00031C96
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				v1.x *= v2.x;
				v1.y *= v2.y;
				v1.z *= v2.z;
				return v1;
			}

			// Token: 0x040007C2 RID: 1986
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			// Token: 0x040007C3 RID: 1987
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			// Token: 0x040007C4 RID: 1988
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public Amplifier.Body.EffectorLink[] effectorLinks;

			// Token: 0x040007C5 RID: 1989
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight = 1f;

			// Token: 0x040007C6 RID: 1990
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight = 1f;

			// Token: 0x040007C7 RID: 1991
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed = 3f;

			// Token: 0x040007C8 RID: 1992
			private Vector3 lastRelativePos;

			// Token: 0x040007C9 RID: 1993
			private Vector3 smoothDelta;

			// Token: 0x040007CA RID: 1994
			private bool firstUpdate;

			// Token: 0x0200013A RID: 314
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040008C2 RID: 2242
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x040008C3 RID: 2243
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}
	}
}
