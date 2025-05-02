using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000080 RID: 128
	public class PenetrationAvoidance : OffsetModifier
	{
		// Token: 0x06000500 RID: 1280 RVA: 0x00020AEC File Offset: 0x0001ECEC
		protected override void OnModifyOffset()
		{
			PenetrationAvoidance.Avoider[] array = this.avoiders;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Solve(this.ik.solver, this.weight);
			}
		}

		// Token: 0x040003CD RID: 973
		[Tooltip("Definitions of penetration avoidances.")]
		public PenetrationAvoidance.Avoider[] avoiders;

		// Token: 0x02000116 RID: 278
		[Serializable]
		public class Avoider
		{
			// Token: 0x06000806 RID: 2054 RVA: 0x00034930 File Offset: 0x00032B30
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
				this.offsetTarget = this.GetOffsetTarget(solver);
				float smoothTime = (this.offsetTarget.sqrMagnitude > this.offset.sqrMagnitude) ? this.smoothTimeIn : this.smoothTimeOut;
				this.offset = Vector3.SmoothDamp(this.offset, this.offsetTarget, ref this.offsetV, smoothTime);
				foreach (PenetrationAvoidance.Avoider.EffectorLink effectorLink in this.effectors)
				{
					solver.GetEffector(effectorLink.effector).positionOffset += this.offset * weight * effectorLink.weight;
				}
			}

			// Token: 0x06000807 RID: 2055 RVA: 0x000349DC File Offset: 0x00032BDC
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				Vector3 vector = Vector3.zero;
				foreach (Transform transform in this.raycastFrom)
				{
					vector += this.Raycast(transform.position, this.raycastTo.position + vector);
				}
				return vector;
			}

			// Token: 0x06000808 RID: 2056 RVA: 0x00034A30 File Offset: 0x00032C30
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				Vector3 direction = to - from;
				float magnitude = direction.magnitude;
				RaycastHit raycastHit;
				if (this.raycastRadius <= 0f)
				{
					Physics.Raycast(from, direction, out raycastHit, magnitude, this.layers);
				}
				else
				{
					Physics.SphereCast(from, this.raycastRadius, direction, out raycastHit, magnitude, this.layers);
				}
				if (raycastHit.collider == null)
				{
					return Vector3.zero;
				}
				return Vector3.Project(-direction.normalized * (magnitude - raycastHit.distance), raycastHit.normal);
			}

			// Token: 0x0400080B RID: 2059
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			// Token: 0x0400080C RID: 2060
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			// Token: 0x0400080D RID: 2061
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			// Token: 0x0400080E RID: 2062
			[Tooltip("Linking this to FBBIK effectors.")]
			public PenetrationAvoidance.Avoider.EffectorLink[] effectors;

			// Token: 0x0400080F RID: 2063
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn = 0.1f;

			// Token: 0x04000810 RID: 2064
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut = 0.3f;

			// Token: 0x04000811 RID: 2065
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			// Token: 0x04000812 RID: 2066
			private Vector3 offset;

			// Token: 0x04000813 RID: 2067
			private Vector3 offsetTarget;

			// Token: 0x04000814 RID: 2068
			private Vector3 offsetV;

			// Token: 0x02000140 RID: 320
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040008D6 RID: 2262
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				// Token: 0x040008D7 RID: 2263
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;
			}
		}
	}
}
