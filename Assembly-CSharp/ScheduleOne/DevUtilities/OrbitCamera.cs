using System;
using EasyButtons;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006ED RID: 1773
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600304B RID: 12363 RVA: 0x000C8FCF File Offset: 0x000C71CF
		// (set) Token: 0x0600304C RID: 12364 RVA: 0x000C8FD7 File Offset: 0x000C71D7
		public bool isEnabled { get; protected set; }

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600304D RID: 12365 RVA: 0x00045196 File Offset: 0x00043396
		protected Transform cam
		{
			get
			{
				return PlayerSingleton<PlayerCamera>.Instance.transform;
			}
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x000C8FE0 File Offset: 0x000C71E0
		protected virtual void Awake()
		{
			this.targetTransform = new GameObject("_OrbitCamTarget").transform;
			this.targetTransform.SetParent(GameObject.Find("_Temp").transform);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Start()
		{
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x000C9011 File Offset: 0x000C7211
		protected virtual void Update()
		{
			if (this.isEnabled)
			{
				this.UpdateRotation();
			}
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000C9021 File Offset: 0x000C7221
		protected virtual void LateUpdate()
		{
			if (this.isEnabled)
			{
				this.FinalizeCameraMovement();
			}
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000C9034 File Offset: 0x000C7234
		[Button]
		public void Enable()
		{
			this.isEnabled = true;
			this.cameraStartPoint.LookAt(this.centrePoint);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(80f, 0.25f);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.cam.position, this.cam.rotation, 0f, false);
			PlayerSingleton<PlayerCamera>.Instance.blockNextStopTransformOverride = true;
			Vector3 eulerAngles = this.cameraStartPoint.eulerAngles;
			this.x = eulerAngles.y;
			this.y = eulerAngles.x;
			this.targetTransform.position = this.cameraStartPoint.position;
			this.targetTransform.rotation = this.cameraStartPoint.rotation;
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x000C90EE File Offset: 0x000C72EE
		public void Disable()
		{
			this.isEnabled = false;
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.25f);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.25f, false, true);
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x000C9118 File Offset: 0x000C7318
		protected void UpdateRotation()
		{
			if (GameInput.GetButtonDown(GameInput.ButtonCode.TertiaryClick))
			{
				this.distance = Vector3.Distance(this.centrePoint.position, this.targetTransform.position);
				this.rotationOriginPoint = this.centrePoint.position;
			}
			if (GameInput.GetButton(GameInput.ButtonCode.TertiaryClick))
			{
				this.x += GameInput.MouseDelta.x * OrbitCamera.xSpeed * 0.02f;
				this.y -= GameInput.MouseDelta.y * OrbitCamera.ySpeed * 0.02f;
				this.y = OrbitCamera.ClampAngle(this.y, this.yMinLimit, this.yMaxLimit);
				Quaternion rotation = Quaternion.Euler(this.y, this.x, 0f);
				Vector3 position = rotation * new Vector3(0f, 0f, -this.distance) + this.rotationOriginPoint;
				this.targetTransform.rotation = rotation;
				this.targetTransform.position = position;
			}
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x0000809D File Offset: 0x0000629D
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

		// Token: 0x06003056 RID: 12374 RVA: 0x000C9224 File Offset: 0x000C7424
		private void FinalizeCameraMovement()
		{
			this.cam.position = Vector3.Lerp(this.cam.position, this.targetTransform.position, Time.deltaTime * this.targetFollowSpeed);
			this.cam.rotation = Quaternion.Lerp(this.cam.rotation, this.targetTransform.rotation, Time.deltaTime * this.targetFollowSpeed);
		}

		// Token: 0x0400224D RID: 8781
		[Header("References")]
		[SerializeField]
		protected Transform cameraStartPoint;

		// Token: 0x0400224E RID: 8782
		[SerializeField]
		protected Transform centrePoint;

		// Token: 0x0400224F RID: 8783
		[Header("Settings")]
		public float targetFollowSpeed = 1f;

		// Token: 0x04002250 RID: 8784
		public float yMinLimit = -20f;

		// Token: 0x04002251 RID: 8785
		public float yMaxLimit = 80f;

		// Token: 0x04002252 RID: 8786
		public static float xSpeed = 200f;

		// Token: 0x04002253 RID: 8787
		public static float ySpeed = 100f;

		// Token: 0x04002255 RID: 8789
		private Vector3 rotationOriginPoint = Vector3.zero;

		// Token: 0x04002256 RID: 8790
		private float distance = 10f;

		// Token: 0x04002257 RID: 8791
		private float prevDistance;

		// Token: 0x04002258 RID: 8792
		private float x;

		// Token: 0x04002259 RID: 8793
		private float y;

		// Token: 0x0400225A RID: 8794
		private Transform targetTransform;
	}
}
