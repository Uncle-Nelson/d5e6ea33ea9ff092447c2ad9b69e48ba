using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000096 RID: 150
	public class EffectorOffset : OffsetModifier
	{
		// Token: 0x06000578 RID: 1400 RVA: 0x0002510C File Offset: 0x0002330C
		protected override void OnModifyOffset()
		{
			this.ik.solver.leftHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.leftShoulderEffector.positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.leftThighEffector.positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.leftHandEffector.positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.rightFootEffector.positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0400046E RID: 1134
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		// Token: 0x0400046F RID: 1135
		public Vector3 bodyOffset;

		// Token: 0x04000470 RID: 1136
		public Vector3 leftShoulderOffset;

		// Token: 0x04000471 RID: 1137
		public Vector3 rightShoulderOffset;

		// Token: 0x04000472 RID: 1138
		public Vector3 leftThighOffset;

		// Token: 0x04000473 RID: 1139
		public Vector3 rightThighOffset;

		// Token: 0x04000474 RID: 1140
		public Vector3 leftHandOffset;

		// Token: 0x04000475 RID: 1141
		public Vector3 rightHandOffset;

		// Token: 0x04000476 RID: 1142
		public Vector3 leftFootOffset;

		// Token: 0x04000477 RID: 1143
		public Vector3 rightFootOffset;
	}
}
