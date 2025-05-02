using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000BB RID: 187
	public class VRIKCalibrationController : MonoBehaviour
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x0002886C File Offset: 0x00026A6C
		private void LateUpdate()
		{
			if (Input.GetKeyDown(KeyCode.C))
			{
				this.data = VRIKCalibrator.Calibrate(this.ik, this.settings, this.headTracker, this.bodyTracker, this.leftHandTracker, this.rightHandTracker, this.leftFootTracker, this.rightFootTracker);
			}
			if (Input.GetKeyDown(KeyCode.D))
			{
				if (this.data.scale == 0f)
				{
					Debug.LogError("No Calibration Data to calibrate to, please calibrate with settings first.");
				}
				else
				{
					VRIKCalibrator.Calibrate(this.ik, this.data, this.headTracker, this.bodyTracker, this.leftHandTracker, this.rightHandTracker, this.leftFootTracker, this.rightFootTracker);
				}
			}
			if (Input.GetKeyDown(KeyCode.S))
			{
				if (this.data.scale == 0f)
				{
					Debug.LogError("Avatar needs to be calibrated before RecalibrateScale is called.");
				}
				VRIKCalibrator.RecalibrateScale(this.ik, this.data, this.settings);
			}
		}

		// Token: 0x04000541 RID: 1345
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		// Token: 0x04000542 RID: 1346
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		// Token: 0x04000543 RID: 1347
		[Tooltip("The HMD.")]
		public Transform headTracker;

		// Token: 0x04000544 RID: 1348
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		// Token: 0x04000545 RID: 1349
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		// Token: 0x04000546 RID: 1350
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		// Token: 0x04000547 RID: 1351
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		// Token: 0x04000548 RID: 1352
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		// Token: 0x04000549 RID: 1353
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data = new VRIKCalibrator.CalibrationData();
	}
}
