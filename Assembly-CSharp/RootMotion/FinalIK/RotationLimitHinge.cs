using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006E RID: 110
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x0001E609 File Offset: 0x0001C809
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page14.html");
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0001E615 File Offset: 0x0001C815
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_hinge.html");
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001E621 File Offset: 0x0001C821
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0001E62D File Offset: 0x0001C82D
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0001E639 File Offset: 0x0001C839
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return this.LimitHinge(rotation);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001E644 File Offset: 0x0001C844
		private Quaternion LimitHinge(Quaternion rotation)
		{
			if (this.min == 0f && this.max == 0f && this.useLimits)
			{
				return Quaternion.AngleAxis(0f, this.axis);
			}
			Quaternion quaternion = RotationLimit.Limit1DOF(rotation, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Vector3 vector = Quaternion.Inverse(Quaternion.AngleAxis(this.lastAngle, this.axis) * Quaternion.LookRotation(base.secondaryAxis, this.axis)) * quaternion * base.secondaryAxis;
			float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			this.lastAngle = Mathf.Clamp(this.lastAngle + num, this.min, this.max);
			return Quaternion.AngleAxis(this.lastAngle, this.axis);
		}

		// Token: 0x0400036D RID: 877
		public bool useLimits = true;

		// Token: 0x0400036E RID: 878
		public float min = -45f;

		// Token: 0x0400036F RID: 879
		public float max = 90f;

		// Token: 0x04000370 RID: 880
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		// Token: 0x04000371 RID: 881
		private float lastAngle;
	}
}
