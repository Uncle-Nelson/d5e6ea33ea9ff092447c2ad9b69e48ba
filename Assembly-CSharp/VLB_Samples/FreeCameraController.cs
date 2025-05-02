using System;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x0200015F RID: 351
	public class FreeCameraController : MonoBehaviour
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0001E568 File Offset: 0x0001C768
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x0001E570 File Offset: 0x0001C770
		private bool useMouseView
		{
			get
			{
				return this.m_UseMouseView;
			}
			set
			{
				this.m_UseMouseView = value;
				Cursor.lockState = (value ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = !value;
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001E590 File Offset: 0x0001C790
		private void Start()
		{
			this.useMouseView = true;
			Vector3 eulerAngles = base.transform.rotation.eulerAngles;
			this.rotationH = eulerAngles.y;
			this.rotationV = eulerAngles.x;
			if (this.rotationV > 180f)
			{
				this.rotationV -= 360f;
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001E5F0 File Offset: 0x0001C7F0
		private void Update()
		{
			if (this.useMouseView)
			{
				this.rotationH += Input.GetAxis("Mouse X") * this.cameraSensitivity * Time.deltaTime;
				this.rotationV -= Input.GetAxis("Mouse Y") * this.cameraSensitivity * Time.deltaTime;
			}
			this.rotationV = Mathf.Clamp(this.rotationV, -90f, 90f);
			base.transform.rotation = Quaternion.AngleAxis(this.rotationH, Vector3.up);
			base.transform.rotation *= Quaternion.AngleAxis(this.rotationV, Vector3.right);
			float num = this.speedNormal;
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				num *= this.speedFactorFast;
			}
			else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
			{
				num *= this.speedFactorSlow;
			}
			base.transform.position += num * Input.GetAxis("Vertical") * Time.deltaTime * base.transform.forward;
			base.transform.position += num * Input.GetAxis("Horizontal") * Time.deltaTime * base.transform.right;
			if (Input.GetKey(KeyCode.Q))
			{
				base.transform.position += this.speedClimb * Time.deltaTime * Vector3.up;
			}
			if (Input.GetKey(KeyCode.E))
			{
				base.transform.position += this.speedClimb * Time.deltaTime * Vector3.down;
			}
			if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
			{
				this.useMouseView = !this.useMouseView;
			}
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				this.useMouseView = false;
			}
		}

		// Token: 0x04000784 RID: 1924
		public float cameraSensitivity = 90f;

		// Token: 0x04000785 RID: 1925
		public float speedNormal = 10f;

		// Token: 0x04000786 RID: 1926
		public float speedFactorSlow = 0.25f;

		// Token: 0x04000787 RID: 1927
		public float speedFactorFast = 3f;

		// Token: 0x04000788 RID: 1928
		public float speedClimb = 4f;

		// Token: 0x04000789 RID: 1929
		private float rotationH;

		// Token: 0x0400078A RID: 1930
		private float rotationV;

		// Token: 0x0400078B RID: 1931
		private bool m_UseMouseView = true;
	}
}
