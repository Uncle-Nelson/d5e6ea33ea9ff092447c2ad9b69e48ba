using System;
using ScheduleOne;
using UnityEngine;

namespace StylizedGrassDemo
{
	// Token: 0x02000166 RID: 358
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x060006D8 RID: 1752 RVA: 0x0001F264 File Offset: 0x0001D464
		private void Start()
		{
			this.cam = Camera.main.transform;
			this.cameraRotSide = base.transform.eulerAngles.y;
			this.cameraRotSideCur = base.transform.eulerAngles.y;
			this.cameraRotUp = base.transform.eulerAngles.x;
			this.cameraRotUpCur = base.transform.eulerAngles.x;
			this.distance = -this.cam.localPosition.z;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		private void LateUpdate()
		{
			Cursor.visible = false;
			if (!this.pivot)
			{
				return;
			}
			if (GameInput.GetButton(GameInput.ButtonCode.PrimaryClick) && this.enableMouse)
			{
				this.cameraRotSide += GameInput.MouseDelta.x * 5f;
				this.cameraRotUp -= GameInput.MouseDelta.y * 5f;
			}
			else
			{
				this.cameraRotSide += this.idleRotationSpeed;
			}
			this.cameraRotSideCur = Mathf.LerpAngle(this.cameraRotSideCur, this.cameraRotSide, Time.deltaTime * this.lookSmoothSpeed);
			this.cameraRotUpCur = Mathf.Lerp(this.cameraRotUpCur, this.cameraRotUp, Time.deltaTime * this.lookSmoothSpeed);
			if (GameInput.GetButton(GameInput.ButtonCode.SecondaryClick) && this.enableMouse)
			{
				this.distance *= 1f - 0.1f * GameInput.MouseDelta.y;
			}
			if (this.enableMouse)
			{
				this.distance *= 1f - 1f * GameInput.MouseScrollDelta;
			}
			Vector3 position = this.pivot.position;
			base.transform.position = Vector3.Lerp(base.transform.position, position, Time.deltaTime * this.moveSmoothSpeed);
			base.transform.rotation = Quaternion.Euler(this.cameraRotUpCur, this.cameraRotSideCur, 0f);
			float d = Mathf.Lerp(-this.cam.transform.localPosition.z, this.distance, Time.deltaTime * this.scrollSmoothSpeed);
			this.cam.localPosition = -Vector3.forward * d;
		}

		// Token: 0x040007B5 RID: 1973
		[Space]
		public Transform pivot;

		// Token: 0x040007B6 RID: 1974
		[Space]
		public bool enableMouse = true;

		// Token: 0x040007B7 RID: 1975
		public float idleRotationSpeed = 0.05f;

		// Token: 0x040007B8 RID: 1976
		public float lookSmoothSpeed = 5f;

		// Token: 0x040007B9 RID: 1977
		public float moveSmoothSpeed = 5f;

		// Token: 0x040007BA RID: 1978
		public float scrollSmoothSpeed = 5f;

		// Token: 0x040007BB RID: 1979
		private Transform cam;

		// Token: 0x040007BC RID: 1980
		private float cameraRotSide;

		// Token: 0x040007BD RID: 1981
		private float cameraRotUp;

		// Token: 0x040007BE RID: 1982
		private float cameraRotSideCur;

		// Token: 0x040007BF RID: 1983
		private float cameraRotUpCur;

		// Token: 0x040007C0 RID: 1984
		private float distance;
	}
}
