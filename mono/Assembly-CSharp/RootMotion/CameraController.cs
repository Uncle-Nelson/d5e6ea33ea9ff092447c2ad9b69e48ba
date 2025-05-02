using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000E RID: 14
	public class CameraController : MonoBehaviour
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00004200 File Offset: 0x00002400
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00004208 File Offset: 0x00002408
		public float x { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00004211 File Offset: 0x00002411
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00004219 File Offset: 0x00002419
		public float y { get; private set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00004222 File Offset: 0x00002422
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000422A File Offset: 0x0000242A
		public float distanceTarget { get; private set; }

		// Token: 0x06000061 RID: 97 RVA: 0x00004234 File Offset: 0x00002434
		public void SetAngles(Quaternion rotation)
		{
			Vector3 eulerAngles = rotation.eulerAngles;
			this.x = eulerAngles.y;
			this.y = eulerAngles.x;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004261 File Offset: 0x00002461
		public void SetAngles(float yaw, float pitch)
		{
			this.x = yaw;
			this.y = pitch;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004274 File Offset: 0x00002474
		protected virtual void Awake()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.x = eulerAngles.y;
			this.y = eulerAngles.x;
			this.distanceTarget = this.distance;
			this.smoothPosition = base.transform.position;
			this.cam = base.GetComponent<Camera>();
			this.lastUp = ((this.rotationSpace != null) ? this.rotationSpace.up : Vector3.up);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000042F4 File Offset: 0x000024F4
		protected virtual void Update()
		{
			if (this.updateMode == CameraController.UpdateMode.Update)
			{
				this.UpdateTransform();
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004304 File Offset: 0x00002504
		protected virtual void FixedUpdate()
		{
			this.fixedFrame = true;
			this.fixedDeltaTime += Time.deltaTime;
			if (this.updateMode == CameraController.UpdateMode.FixedUpdate)
			{
				this.UpdateTransform();
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004330 File Offset: 0x00002530
		protected virtual void LateUpdate()
		{
			this.UpdateInput();
			if (this.updateMode == CameraController.UpdateMode.LateUpdate)
			{
				this.UpdateTransform();
			}
			if (this.updateMode == CameraController.UpdateMode.FixedLateUpdate && this.fixedFrame)
			{
				this.UpdateTransform(this.fixedDeltaTime);
				this.fixedDeltaTime = 0f;
				this.fixedFrame = false;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004384 File Offset: 0x00002584
		public void UpdateInput()
		{
			if (!this.cam.enabled)
			{
				return;
			}
			Cursor.lockState = (this.lockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = !this.lockCursor;
			if (this.rotateAlways || (this.rotateOnLeftButton && Input.GetMouseButton(0)) || (this.rotateOnRightButton && Input.GetMouseButton(1)) || (this.rotateOnMiddleButton && Input.GetMouseButton(2)))
			{
				this.x += Input.GetAxis("Mouse X") * this.rotationSensitivity;
				this.y = this.ClampAngle(this.y - Input.GetAxis("Mouse Y") * this.rotationSensitivity, this.yMinLimit, this.yMaxLimit);
			}
			this.distanceTarget = Mathf.Clamp(this.distanceTarget + this.zoomAdd, this.minDistance, this.maxDistance);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004471 File Offset: 0x00002671
		public void UpdateTransform()
		{
			this.UpdateTransform(Time.deltaTime);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004480 File Offset: 0x00002680
		public void UpdateTransform(float deltaTime)
		{
			if (!this.cam.enabled)
			{
				return;
			}
			this.rotation = Quaternion.AngleAxis(this.x, Vector3.up) * Quaternion.AngleAxis(this.y, Vector3.right);
			if (this.rotationSpace != null)
			{
				this.r = Quaternion.FromToRotation(this.lastUp, this.rotationSpace.up) * this.r;
				this.rotation = this.r * this.rotation;
				this.lastUp = this.rotationSpace.up;
			}
			if (this.target != null)
			{
				this.distance += (this.distanceTarget - this.distance) * this.zoomSpeed * deltaTime;
				if (!this.smoothFollow)
				{
					this.smoothPosition = this.target.position;
				}
				else
				{
					this.smoothPosition = Vector3.Lerp(this.smoothPosition, this.target.position, deltaTime * this.followSpeed);
				}
				Vector3 a = this.smoothPosition + this.rotation * this.offset;
				Vector3 vector = this.rotation * -Vector3.forward;
				if (this.blockingLayers != -1)
				{
					RaycastHit raycastHit;
					if (Physics.SphereCast(a - vector * this.blockingOriginOffset, this.blockingRadius, vector, out raycastHit, this.blockingOriginOffset + this.distanceTarget - this.blockingRadius, this.blockingLayers))
					{
						this.blockedDistance = Mathf.SmoothDamp(this.blockedDistance, raycastHit.distance + this.blockingRadius * (1f - this.blockedOffset) - this.blockingOriginOffset, ref this.blockedDistanceV, this.blockingSmoothTime);
					}
					else
					{
						this.blockedDistance = this.distanceTarget;
					}
					this.distance = Mathf.Min(this.distance, this.blockedDistance);
				}
				this.position = a + vector * this.distance;
				base.transform.position = this.position;
			}
			base.transform.rotation = this.rotation;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000046BC File Offset: 0x000028BC
		private float zoomAdd
		{
			get
			{
				float axis = Input.GetAxis("Mouse ScrollWheel");
				if (axis > 0f)
				{
					return -this.zoomSensitivity;
				}
				if (axis < 0f)
				{
					return this.zoomSensitivity;
				}
				return 0f;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000046F8 File Offset: 0x000028F8
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

		// Token: 0x04000054 RID: 84
		public Transform target;

		// Token: 0x04000055 RID: 85
		public Transform rotationSpace;

		// Token: 0x04000056 RID: 86
		public CameraController.UpdateMode updateMode = CameraController.UpdateMode.LateUpdate;

		// Token: 0x04000057 RID: 87
		public bool lockCursor = true;

		// Token: 0x04000058 RID: 88
		[Header("Position")]
		public bool smoothFollow;

		// Token: 0x04000059 RID: 89
		public Vector3 offset = new Vector3(0f, 1.5f, 0.5f);

		// Token: 0x0400005A RID: 90
		public float followSpeed = 10f;

		// Token: 0x0400005B RID: 91
		[Header("Rotation")]
		public float rotationSensitivity = 3.5f;

		// Token: 0x0400005C RID: 92
		public float yMinLimit = -20f;

		// Token: 0x0400005D RID: 93
		public float yMaxLimit = 80f;

		// Token: 0x0400005E RID: 94
		public bool rotateAlways = true;

		// Token: 0x0400005F RID: 95
		public bool rotateOnLeftButton;

		// Token: 0x04000060 RID: 96
		public bool rotateOnRightButton;

		// Token: 0x04000061 RID: 97
		public bool rotateOnMiddleButton;

		// Token: 0x04000062 RID: 98
		[Header("Distance")]
		public float distance = 10f;

		// Token: 0x04000063 RID: 99
		public float minDistance = 4f;

		// Token: 0x04000064 RID: 100
		public float maxDistance = 10f;

		// Token: 0x04000065 RID: 101
		public float zoomSpeed = 10f;

		// Token: 0x04000066 RID: 102
		public float zoomSensitivity = 1f;

		// Token: 0x04000067 RID: 103
		[Header("Blocking")]
		public LayerMask blockingLayers;

		// Token: 0x04000068 RID: 104
		public float blockingRadius = 1f;

		// Token: 0x04000069 RID: 105
		public float blockingSmoothTime = 0.1f;

		// Token: 0x0400006A RID: 106
		public float blockingOriginOffset;

		// Token: 0x0400006B RID: 107
		[Range(0f, 1f)]
		public float blockedOffset = 0.5f;

		// Token: 0x0400006F RID: 111
		private Vector3 targetDistance;

		// Token: 0x04000070 RID: 112
		private Vector3 position;

		// Token: 0x04000071 RID: 113
		private Quaternion rotation = Quaternion.identity;

		// Token: 0x04000072 RID: 114
		private Vector3 smoothPosition;

		// Token: 0x04000073 RID: 115
		private Camera cam;

		// Token: 0x04000074 RID: 116
		private bool fixedFrame;

		// Token: 0x04000075 RID: 117
		private float fixedDeltaTime;

		// Token: 0x04000076 RID: 118
		private Quaternion r = Quaternion.identity;

		// Token: 0x04000077 RID: 119
		private Vector3 lastUp;

		// Token: 0x04000078 RID: 120
		private float blockedDistance = 10f;

		// Token: 0x04000079 RID: 121
		private float blockedDistanceV;

		// Token: 0x020000CE RID: 206
		[Serializable]
		public enum UpdateMode
		{
			// Token: 0x040005F5 RID: 1525
			Update,
			// Token: 0x040005F6 RID: 1526
			FixedUpdate,
			// Token: 0x040005F7 RID: 1527
			LateUpdate,
			// Token: 0x040005F8 RID: 1528
			FixedLateUpdate
		}
	}
}
