using System;
using UnityEngine;

namespace VolumetricFogAndMist2.Demos
{
	// Token: 0x02000164 RID: 356
	public class FPS_Controller : MonoBehaviour
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x0001EDEC File Offset: 0x0001CFEC
		private void Start()
		{
			this.characterController = base.gameObject.AddComponent<CharacterController>();
			this.mainCamera = Camera.main.transform;
			this.characterController.height = this.characterHeight;
			this.characterController.center = Vector3.up * this.characterHeight / 2f;
			this.mainCamera.position = base.transform.position + Vector3.up * this.characterHeight;
			this.mainCamera.rotation = Quaternion.identity;
			this.mainCamera.parent = base.transform;
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
		private void Update()
		{
			Vector3 mousePosition = Input.mousePosition;
			if (mousePosition.x < 0f || mousePosition.x >= (float)Screen.width || mousePosition.y < 0f || mousePosition.y >= (float)Screen.height)
			{
				return;
			}
			this.isGrounded = this.characterController.isGrounded;
			this.inputHor = Input.GetAxis("Horizontal");
			this.inputVert = Input.GetAxis("Vertical");
			this.mouseHor = Input.GetAxis("Mouse X");
			this.mouseVert = Input.GetAxis("Mouse Y");
			base.transform.Rotate(0f, this.mouseHor * this.rotationSpeed * this.mouseSensitivity * this.mouseInvertX, 0f);
			Vector3 a = base.transform.forward * this.inputVert + base.transform.right * this.inputHor;
			a *= this.speed;
			if (this.isGrounded)
			{
				if (Input.GetKey(KeyCode.LeftShift))
				{
					if (this.sprint < this.sprintMax)
					{
						this.sprint += 10f * Time.deltaTime;
					}
				}
				else if (this.sprint > 1f)
				{
					this.sprint -= 10f * Time.deltaTime;
				}
				if (Input.GetKeyDown(KeyCode.Space))
				{
					this.jumpDirection.y = this.jumpHeight;
				}
				else
				{
					this.jumpDirection.y = -1f;
				}
			}
			else
			{
				a *= this.airControl;
			}
			this.jumpDirection.y = this.jumpDirection.y - this.gravity * Time.deltaTime;
			this.characterController.Move(a * this.sprint * Time.deltaTime);
			this.characterController.Move(this.jumpDirection * Time.deltaTime);
			this.camVertAngle += this.mouseVert * this.rotationSpeed * this.mouseSensitivity * this.mouseInvertY;
			this.camVertAngle = Mathf.Clamp(this.camVertAngle, -85f, 85f);
			this.mainCamera.localEulerAngles = new Vector3(this.camVertAngle, 0f, 0f);
		}

		// Token: 0x0400079D RID: 1949
		private CharacterController characterController;

		// Token: 0x0400079E RID: 1950
		private Transform mainCamera;

		// Token: 0x0400079F RID: 1951
		private float inputHor;

		// Token: 0x040007A0 RID: 1952
		private float inputVert;

		// Token: 0x040007A1 RID: 1953
		private float mouseHor;

		// Token: 0x040007A2 RID: 1954
		private float mouseVert;

		// Token: 0x040007A3 RID: 1955
		private float mouseInvertX = 1f;

		// Token: 0x040007A4 RID: 1956
		private float mouseInvertY = -1f;

		// Token: 0x040007A5 RID: 1957
		private float camVertAngle;

		// Token: 0x040007A6 RID: 1958
		private bool isGrounded;

		// Token: 0x040007A7 RID: 1959
		private Vector3 jumpDirection = Vector3.zero;

		// Token: 0x040007A8 RID: 1960
		private float sprint = 1f;

		// Token: 0x040007A9 RID: 1961
		public float sprintMax = 2f;

		// Token: 0x040007AA RID: 1962
		public float airControl = 1.5f;

		// Token: 0x040007AB RID: 1963
		public float jumpHeight = 10f;

		// Token: 0x040007AC RID: 1964
		public float gravity = 20f;

		// Token: 0x040007AD RID: 1965
		public float characterHeight = 1.8f;

		// Token: 0x040007AE RID: 1966
		public float cameraHeight = 1.7f;

		// Token: 0x040007AF RID: 1967
		public float speed = 15f;

		// Token: 0x040007B0 RID: 1968
		public float rotationSpeed = 2f;

		// Token: 0x040007B1 RID: 1969
		public float mouseSensitivity = 1f;
	}
}
