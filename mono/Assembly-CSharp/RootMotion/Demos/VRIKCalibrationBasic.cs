using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000BA RID: 186
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x0002876C File Offset: 0x0002696C
		private void LateUpdate()
		{
			if (Input.GetKeyDown(KeyCode.C))
			{
				this.data = VRIKCalibrator.Calibrate(this.ik, this.centerEyeAnchor, this.leftHandAnchor, this.rightHandAnchor, this.headAnchorPositionOffset, this.headAnchorRotationOffset, this.handAnchorPositionOffset, this.handAnchorRotationOffset, this.scaleMlp);
			}
			if (Input.GetKeyDown(KeyCode.D))
			{
				if (this.data.scale == 0f)
				{
					Debug.LogError("No Calibration Data to calibrate to, please calibrate with 'C' first.");
				}
				else
				{
					VRIKCalibrator.Calibrate(this.ik, this.data, this.centerEyeAnchor, null, this.leftHandAnchor, this.rightHandAnchor, null, null);
				}
			}
			if (Input.GetKeyDown(KeyCode.S))
			{
				if (this.data.scale == 0f)
				{
					Debug.LogError("Avatar needs to be calibrated before RecalibrateScale is called.");
				}
				VRIKCalibrator.RecalibrateScale(this.ik, this.data, this.scaleMlp);
			}
		}

		// Token: 0x04000537 RID: 1335
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		// Token: 0x04000538 RID: 1336
		[Header("Head")]
		[Tooltip("HMD.")]
		public Transform centerEyeAnchor;

		// Token: 0x04000539 RID: 1337
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		// Token: 0x0400053A RID: 1338
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		// Token: 0x0400053B RID: 1339
		[Header("Hands")]
		[Tooltip("Left Hand Controller")]
		public Transform leftHandAnchor;

		// Token: 0x0400053C RID: 1340
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		// Token: 0x0400053D RID: 1341
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		// Token: 0x0400053E RID: 1342
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		// Token: 0x0400053F RID: 1343
		[Header("Scale")]
		[Tooltip("Multiplies the scale of the root.")]
		public float scaleMlp = 1f;

		// Token: 0x04000540 RID: 1344
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data = new VRIKCalibrator.CalibrationData();
	}
}
