using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006D RID: 109
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		// Token: 0x06000494 RID: 1172 RVA: 0x0001E517 File Offset: 0x0001C717
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page14.html");
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001E523 File Offset: 0x0001C723
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html");
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001E52F File Offset: 0x0001C72F
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001E53B File Offset: 0x0001C73B
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001E547 File Offset: 0x0001C747
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return RotationLimit.LimitTwist(this.LimitSwing(rotation), this.axis, base.secondaryAxis, this.twistLimit);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001E568 File Offset: 0x0001C768
		private Quaternion LimitSwing(Quaternion rotation)
		{
			if (this.axis == Vector3.zero)
			{
				return rotation;
			}
			if (rotation == Quaternion.identity)
			{
				return rotation;
			}
			if (this.limit >= 180f)
			{
				return rotation;
			}
			Vector3 vector = rotation * this.axis;
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation2 = Quaternion.RotateTowards(Quaternion.identity, to, this.limit);
			return Quaternion.FromToRotation(vector, rotation2 * this.axis) * rotation;
		}

		// Token: 0x0400036B RID: 875
		[Range(0f, 180f)]
		public float limit = 45f;

		// Token: 0x0400036C RID: 876
		[Range(0f, 180f)]
		public float twistLimit = 180f;
	}
}
