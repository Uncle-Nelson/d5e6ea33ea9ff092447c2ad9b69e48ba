using System;
using UnityEngine;

// Token: 0x02000046 RID: 70
[AddComponentMenu("Camera-Control/Smooth Mouse Orbit - Unluck Software")]
public class SmoothCameraOrbit : MonoBehaviour
{
	// Token: 0x06000161 RID: 353 RVA: 0x00007C3B File Offset: 0x00005E3B
	private void Start()
	{
		this.Init();
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00007C3B File Offset: 0x00005E3B
	private void OnEnable()
	{
		this.Init();
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00007C44 File Offset: 0x00005E44
	public void Init()
	{
		if (!this.target)
		{
			this.target = new GameObject("Cam Target")
			{
				transform = 
				{
					position = base.transform.position + base.transform.forward * this.distance
				}
			}.transform;
		}
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.position = base.transform.position;
		this.rotation = base.transform.rotation;
		this.currentRotation = base.transform.rotation;
		this.desiredRotation = base.transform.rotation;
		this.xDeg = Vector3.Angle(Vector3.right, base.transform.right);
		this.yDeg = Vector3.Angle(Vector3.up, base.transform.up);
		this.position = this.target.position - (this.rotation * Vector3.forward * this.currentDistance + this.targetOffset);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00007D74 File Offset: 0x00005F74
	private void LateUpdate()
	{
		if (Input.GetMouseButton(2) && Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.LeftControl))
		{
			this.desiredDistance -= Input.GetAxis("Mouse Y") * 0.02f * (float)this.zoomRate * 0.125f * Mathf.Abs(this.desiredDistance);
		}
		else if (Input.GetMouseButton(0))
		{
			this.xDeg += Input.GetAxis("Mouse X") * this.xSpeed * 0.02f;
			this.yDeg -= Input.GetAxis("Mouse Y") * this.ySpeed * 0.02f;
			this.yDeg = SmoothCameraOrbit.ClampAngle(this.yDeg, (float)this.yMinLimit, (float)this.yMaxLimit);
			this.desiredRotation = Quaternion.Euler(this.yDeg, this.xDeg, 0f);
			this.currentRotation = base.transform.rotation;
			this.rotation = Quaternion.Lerp(this.currentRotation, this.desiredRotation, 0.02f * this.zoomDampening);
			base.transform.rotation = this.rotation;
			this.idleTimer = 0f;
			this.idleSmooth = 0f;
		}
		else
		{
			this.idleTimer += 0.02f;
			if (this.idleTimer > this.autoRotate && this.autoRotate > 0f)
			{
				this.idleSmooth += (0.02f + this.idleSmooth) * 0.005f;
				this.idleSmooth = Mathf.Clamp(this.idleSmooth, 0f, 1f);
				this.xDeg += this.xSpeed * Time.deltaTime * this.idleSmooth * this.autoRotateSpeed;
			}
			this.yDeg = SmoothCameraOrbit.ClampAngle(this.yDeg, (float)this.yMinLimit, (float)this.yMaxLimit);
			this.desiredRotation = Quaternion.Euler(this.yDeg, this.xDeg, 0f);
			this.currentRotation = base.transform.rotation;
			this.rotation = Quaternion.Lerp(this.currentRotation, this.desiredRotation, 0.02f * this.zoomDampening * 2f);
			base.transform.rotation = this.rotation;
		}
		this.desiredDistance -= Input.GetAxis("Mouse ScrollWheel") * 0.02f * (float)this.zoomRate * Mathf.Abs(this.desiredDistance);
		this.desiredDistance = Mathf.Clamp(this.desiredDistance, this.minDistance, this.maxDistance);
		this.currentDistance = Mathf.Lerp(this.currentDistance, this.desiredDistance, 0.02f * this.zoomDampening);
		this.position = this.target.position - (this.rotation * Vector3.forward * this.currentDistance + this.targetOffset);
		base.transform.position = this.position;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0000809D File Offset: 0x0000629D
	private static float ClampAngle(float angle, float min, float max)
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

	// Token: 0x0400013E RID: 318
	public Transform target;

	// Token: 0x0400013F RID: 319
	public Vector3 targetOffset;

	// Token: 0x04000140 RID: 320
	public float distance = 5f;

	// Token: 0x04000141 RID: 321
	public float maxDistance = 20f;

	// Token: 0x04000142 RID: 322
	public float minDistance = 0.6f;

	// Token: 0x04000143 RID: 323
	public float xSpeed = 200f;

	// Token: 0x04000144 RID: 324
	public float ySpeed = 200f;

	// Token: 0x04000145 RID: 325
	public int yMinLimit = -80;

	// Token: 0x04000146 RID: 326
	public int yMaxLimit = 80;

	// Token: 0x04000147 RID: 327
	public int zoomRate = 40;

	// Token: 0x04000148 RID: 328
	public float panSpeed = 0.3f;

	// Token: 0x04000149 RID: 329
	public float zoomDampening = 5f;

	// Token: 0x0400014A RID: 330
	public float autoRotate = 1f;

	// Token: 0x0400014B RID: 331
	public float autoRotateSpeed = 0.1f;

	// Token: 0x0400014C RID: 332
	private float xDeg;

	// Token: 0x0400014D RID: 333
	private float yDeg;

	// Token: 0x0400014E RID: 334
	private float currentDistance;

	// Token: 0x0400014F RID: 335
	private float desiredDistance;

	// Token: 0x04000150 RID: 336
	private Quaternion currentRotation;

	// Token: 0x04000151 RID: 337
	private Quaternion desiredRotation;

	// Token: 0x04000152 RID: 338
	private Quaternion rotation;

	// Token: 0x04000153 RID: 339
	private Vector3 position;

	// Token: 0x04000154 RID: 340
	private float idleTimer;

	// Token: 0x04000155 RID: 341
	private float idleSmooth;
}
