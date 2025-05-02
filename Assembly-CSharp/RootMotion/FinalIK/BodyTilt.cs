using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000074 RID: 116
	public class BodyTilt : OffsetModifier
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x0001F7EF File Offset: 0x0001D9EF
		protected override void Start()
		{
			base.Start();
			this.lastForward = base.transform.forward;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0001F808 File Offset: 0x0001DA08
		protected override void OnModifyOffset()
		{
			Quaternion quaternion = Quaternion.FromToRotation(this.lastForward, base.transform.forward);
			float num = 0f;
			Vector3 zero = Vector3.zero;
			quaternion.ToAngleAxis(out num, out zero);
			if (zero.y > 0f)
			{
				num = -num;
			}
			num *= this.tiltSensitivity * 0.01f;
			num /= base.deltaTime;
			num = Mathf.Clamp(num, -1f, 1f);
			this.tiltAngle = Mathf.Lerp(this.tiltAngle, num, base.deltaTime * this.tiltSpeed);
			float weight = Mathf.Abs(this.tiltAngle) / 1f;
			if (this.tiltAngle < 0f)
			{
				this.poseRight.Apply(this.ik.solver, weight);
			}
			else
			{
				this.poseLeft.Apply(this.ik.solver, weight);
			}
			this.lastForward = base.transform.forward;
		}

		// Token: 0x0400039B RID: 923
		[Tooltip("Speed of tilting")]
		public float tiltSpeed = 6f;

		// Token: 0x0400039C RID: 924
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity = 0.07f;

		// Token: 0x0400039D RID: 925
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		// Token: 0x0400039E RID: 926
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		// Token: 0x0400039F RID: 927
		private float tiltAngle;

		// Token: 0x040003A0 RID: 928
		private Vector3 lastForward;
	}
}
