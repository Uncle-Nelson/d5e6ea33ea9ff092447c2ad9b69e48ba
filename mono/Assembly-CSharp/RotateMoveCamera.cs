using System;
using UnityEngine;

// Token: 0x02000034 RID: 52
public class RotateMoveCamera : MonoBehaviour
{
	// Token: 0x0600010B RID: 267 RVA: 0x00006604 File Offset: 0x00004804
	private void Update()
	{
		float axis = Input.GetAxis("Mouse X");
		float axis2 = Input.GetAxis("Mouse Y");
		if (axis != this.MouseX || axis2 != this.MouseY)
		{
			this.rotationX += axis * this.sensX * Time.deltaTime;
			this.rotationY += axis2 * this.sensY * Time.deltaTime;
			this.rotationY = Mathf.Clamp(this.rotationY, this.minY, this.maxY);
			this.MouseX = axis;
			this.MouseY = axis2;
			this.Camera.transform.localEulerAngles = new Vector3(-this.rotationY, this.rotationX, 0f);
		}
		if (Input.GetKey(KeyCode.W))
		{
			base.transform.Translate(new Vector3(0f, 0f, 0.1f));
		}
		else if (Input.GetKey(KeyCode.S))
		{
			base.transform.Translate(new Vector3(0f, 0f, -0.1f));
		}
		if (Input.GetKey(KeyCode.D))
		{
			base.transform.Translate(new Vector3(0.1f, 0f, 0f));
			return;
		}
		if (Input.GetKey(KeyCode.A))
		{
			base.transform.Translate(new Vector3(-0.1f, 0f, 0f));
		}
	}

	// Token: 0x040000EE RID: 238
	public GameObject Camera;

	// Token: 0x040000EF RID: 239
	public float minX = -360f;

	// Token: 0x040000F0 RID: 240
	public float maxX = 360f;

	// Token: 0x040000F1 RID: 241
	public float minY = -45f;

	// Token: 0x040000F2 RID: 242
	public float maxY = 45f;

	// Token: 0x040000F3 RID: 243
	public float sensX = 100f;

	// Token: 0x040000F4 RID: 244
	public float sensY = 100f;

	// Token: 0x040000F5 RID: 245
	private float rotationY;

	// Token: 0x040000F6 RID: 246
	private float rotationX;

	// Token: 0x040000F7 RID: 247
	private float MouseX;

	// Token: 0x040000F8 RID: 248
	private float MouseY;
}
