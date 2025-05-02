using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A6 RID: 166
	public class OffsetEffector : OffsetModifier
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x00026D2C File Offset: 0x00024F2C
		protected override void Start()
		{
			base.Start();
			if (this.anchor != null)
			{
				this.posRelToAnchor = this.anchor.InverseTransformPoint(base.transform.position);
				this.rotRelToAnchor = Quaternion.Inverse(this.anchor.rotation) * base.transform.rotation;
			}
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Transform bone = this.ik.solver.GetEffector(effectorLink.effectorType).bone;
				effectorLink.localPosition = base.transform.InverseTransformPoint(bone.position);
				if (effectorLink.effectorType == FullBodyBipedEffector.Body)
				{
					this.ik.solver.bodyEffector.effectChildNodes = false;
				}
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00026DFC File Offset: 0x00024FFC
		protected override void OnModifyOffset()
		{
			foreach (OffsetEffector.EffectorLink effectorLink in this.effectorLinks)
			{
				Vector3 a = base.transform.TransformPoint(effectorLink.localPosition);
				this.ik.solver.GetEffector(effectorLink.effectorType).positionOffset += (a - (this.ik.solver.GetEffector(effectorLink.effectorType).bone.position + this.ik.solver.GetEffector(effectorLink.effectorType).positionOffset)) * this.weight * effectorLink.weightMultiplier;
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00026EBC File Offset: 0x000250BC
		public void Anchor()
		{
			if (this.anchor == null)
			{
				return;
			}
			base.transform.position = this.anchor.TransformPoint(this.posRelToAnchor);
			base.transform.rotation = this.anchor.rotation * this.rotRelToAnchor;
		}

		// Token: 0x040004DB RID: 1243
		[Tooltip("Optional. Assign the bone Transform that is closest to this OffsetEffector to be able to call OffsetEffector.Anchor() in LateUpdate to match its position and rotation to animation.")]
		public Transform anchor;

		// Token: 0x040004DC RID: 1244
		public OffsetEffector.EffectorLink[] effectorLinks;

		// Token: 0x040004DD RID: 1245
		private Vector3 posRelToAnchor;

		// Token: 0x040004DE RID: 1246
		private Quaternion rotRelToAnchor = Quaternion.identity;

		// Token: 0x02000123 RID: 291
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x04000860 RID: 2144
			public FullBodyBipedEffector effectorType;

			// Token: 0x04000861 RID: 2145
			public float weightMultiplier = 1f;

			// Token: 0x04000862 RID: 2146
			[HideInInspector]
			public Vector3 localPosition;
		}
	}
}
