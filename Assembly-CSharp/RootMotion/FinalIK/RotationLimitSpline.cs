using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000070 RID: 112
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x0001EE9F File Offset: 0x0001D09F
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page14.html");
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0001EEAB File Offset: 0x0001D0AB
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_spline.html");
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001EEB7 File Offset: 0x0001D0B7
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001EEC3 File Offset: 0x0001D0C3
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0001EECF File Offset: 0x0001D0CF
		public void SetSpline(Keyframe[] keyframes)
		{
			this.spline.keys = keyframes;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001EEDD File Offset: 0x0001D0DD
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return RotationLimit.LimitTwist(this.LimitSwing(rotation), this.axis, base.secondaryAxis, this.twistLimit);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001EF00 File Offset: 0x0001D100
		public Quaternion LimitSwing(Quaternion rotation)
		{
			if (this.axis == Vector3.zero)
			{
				return rotation;
			}
			if (rotation == Quaternion.identity)
			{
				return rotation;
			}
			Vector3 vector = rotation * this.axis;
			float num = RotationLimit.GetOrthogonalAngle(vector, base.secondaryAxis, this.axis);
			if (Vector3.Dot(vector, base.crossAxis) < 0f)
			{
				num = 180f + (180f - num);
			}
			float maxDegreesDelta = this.spline.Evaluate(num);
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation2 = Quaternion.RotateTowards(Quaternion.identity, to, maxDegreesDelta);
			return Quaternion.FromToRotation(vector, rotation2 * this.axis) * rotation;
		}

		// Token: 0x04000377 RID: 887
		[Range(0f, 180f)]
		public float twistLimit = 180f;

		// Token: 0x04000378 RID: 888
		[HideInInspector]
		public AnimationCurve spline;
	}
}
