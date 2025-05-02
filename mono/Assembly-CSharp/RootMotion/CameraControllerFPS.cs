using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000F RID: 15
	public class CameraControllerFPS : MonoBehaviour
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000480C File Offset: 0x00002A0C
		private void Awake()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.x = eulerAngles.y;
			this.y = eulerAngles.x;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004840 File Offset: 0x00002A40
		public void LateUpdate()
		{
			Cursor.lockState = CursorLockMode.Locked;
			this.x += Input.GetAxis("Mouse X") * this.rotationSensitivity;
			this.y = this.ClampAngle(this.y - Input.GetAxis("Mouse Y") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(this.x, Vector3.up) * Quaternion.AngleAxis(this.y, Vector3.right);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000048D1 File Offset: 0x00002AD1
		private float ClampAngle(float angle, float min, float max)
		{
			if (angle < -360f)
			{
				angle += 360f;
			}
			if (angle > 360f)
			{
				angle -= 360f;
			}
			return Mathf.Clamp(angle, min, max);
		}

		// Token: 0x0400007A RID: 122
		public float rotationSensitivity = 3f;

		// Token: 0x0400007B RID: 123
		public float yMinLimit = -89f;

		// Token: 0x0400007C RID: 124
		public float yMaxLimit = 89f;

		// Token: 0x0400007D RID: 125
		private float x;

		// Token: 0x0400007E RID: 126
		private float y;
	}
}
