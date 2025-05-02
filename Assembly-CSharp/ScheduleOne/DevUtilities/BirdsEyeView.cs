using System;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006D8 RID: 1752
	public class BirdsEyeView : Singleton<BirdsEyeView>
	{
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x00045196 File Offset: 0x00043396
		private Transform playerCam
		{
			get
			{
				return PlayerSingleton<PlayerCamera>.Instance.transform;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002FBA RID: 12218 RVA: 0x000C6D27 File Offset: 0x000C4F27
		// (set) Token: 0x06002FBB RID: 12219 RVA: 0x000C6D2F File Offset: 0x000C4F2F
		public bool isEnabled { get; protected set; }

		// Token: 0x06002FBC RID: 12220 RVA: 0x000C6D38 File Offset: 0x000C4F38
		protected override void Awake()
		{
			base.Awake();
			this.targetTransform = new GameObject("_TargetCameraTransform").transform;
			this.targetTransform.SetParent(GameObject.Find("_Temp").transform);
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x000C6D6F File Offset: 0x000C4F6F
		protected virtual void Update()
		{
			if (this.isEnabled)
			{
				this.UpdateLateralMovement();
				this.UpdateRotation();
				this.UpdateScrollMovement();
			}
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x000C6D8B File Offset: 0x000C4F8B
		protected virtual void LateUpdate()
		{
			if (this.isEnabled)
			{
				this.FinalizeCameraMovement();
			}
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x000C6D9C File Offset: 0x000C4F9C
		public void Enable(Vector3 startPosition, Quaternion startRotation)
		{
			this.isEnabled = true;
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0f);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(startPosition, startRotation, 0f, false);
			Vector3 eulerAngles = startRotation.eulerAngles;
			this.x = eulerAngles.y;
			this.y = eulerAngles.x;
			this.targetTransform.position = startPosition;
			this.targetTransform.rotation = startRotation;
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x000C6E0E File Offset: 0x000C500E
		public void Disable(bool reenableCameraLook = true)
		{
			this.isEnabled = false;
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0f);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, reenableCameraLook, true);
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x000C6E38 File Offset: 0x000C5038
		protected void UpdateLateralMovement()
		{
			float num = GameInput.MotionAxis.y;
			float d = GameInput.MotionAxis.x;
			int num2 = 0;
			if (Input.GetKey(KeyCode.Space))
			{
				num2++;
			}
			if (Input.GetKey(KeyCode.LeftControl))
			{
				num2--;
			}
			if (num != 0f || num2 != 0)
			{
				this.CancelOriginSlide();
			}
			Vector3 forward = this.playerCam.forward;
			forward.y = 0f;
			forward.Normalize();
			Vector3 right = this.playerCam.right;
			right.y = 0f;
			right.Normalize();
			Vector3 b = forward * num * this.lateralMovementSpeed * Time.deltaTime;
			Vector3 b2 = right * d * this.lateralMovementSpeed * Time.deltaTime;
			Vector3 b3 = Vector3.up * (float)num2 * this.lateralMovementSpeed * Time.deltaTime * 0.5f;
			this.targetTransform.position += b;
			this.targetTransform.position += b2;
			this.targetTransform.position += b3;
			this.rotationOriginPoint += b;
			this.rotationOriginPoint += b2;
			this.rotationOriginPoint += b3;
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x000C6FB8 File Offset: 0x000C51B8
		protected void UpdateScrollMovement()
		{
			float num = Input.mouseScrollDelta.y;
			Vector3 normalized = this.playerCam.forward.normalized;
			if (GameInput.GetButton(GameInput.ButtonCode.TertiaryClick) || GameInput.GetButton(GameInput.ButtonCode.SecondaryClick))
			{
				this.distance += num * this.scrollMovementSpeed * Time.deltaTime;
				return;
			}
			this.targetTransform.position += normalized * num * this.scrollMovementSpeed * Time.deltaTime;
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x000C7044 File Offset: 0x000C5244
		protected void UpdateRotation()
		{
			if (GameInput.GetButtonDown(GameInput.ButtonCode.TertiaryClick) || GameInput.GetButtonDown(GameInput.ButtonCode.SecondaryClick))
			{
				Plane plane = new Plane(Vector3.up, new Vector3(0f, 0f, 0f));
				Ray ray = new Ray(this.targetTransform.position, this.targetTransform.forward);
				float num = 0f;
				plane.Raycast(ray, out num);
				this.distance = num;
				this.rotationOriginPoint = ray.GetPoint(num);
			}
			if (GameInput.GetButton(GameInput.ButtonCode.TertiaryClick) || GameInput.GetButton(GameInput.ButtonCode.SecondaryClick))
			{
				this.x += GameInput.MouseDelta.x * this.xSpeed * 0.02f;
				this.y -= GameInput.MouseDelta.y * this.ySpeed * 0.02f;
				this.y = BirdsEyeView.ClampAngle(this.y, this.yMinLimit, this.yMaxLimit);
				Quaternion rotation = Quaternion.Euler(this.y, this.x, 0f);
				Vector3 position = rotation * new Vector3(0f, 0f, -this.distance) + this.rotationOriginPoint;
				this.targetTransform.rotation = rotation;
				this.targetTransform.position = position;
			}
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x000C7198 File Offset: 0x000C5398
		private void FinalizeCameraMovement()
		{
			this.playerCam.position = Vector3.Lerp(this.playerCam.position, this.targetTransform.position, Time.deltaTime * this.targetFollowSpeed);
			this.playerCam.rotation = Quaternion.Lerp(this.playerCam.rotation, this.targetTransform.rotation, Time.deltaTime * this.targetFollowSpeed);
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x0000809D File Offset: 0x0000629D
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

		// Token: 0x06002FC6 RID: 12230 RVA: 0x000C7209 File Offset: 0x000C5409
		private void CancelOriginSlide()
		{
			if (this.originSlideRoutine != null)
			{
				base.StopCoroutine(this.originSlideRoutine);
				this.originSlideRoutine = null;
			}
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x000C7228 File Offset: 0x000C5428
		public void SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0f)
		{
			BirdsEyeView.<>c__DisplayClass33_0 CS$<>8__locals1 = new BirdsEyeView.<>c__DisplayClass33_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.position = position;
			CS$<>8__locals1.time = time;
			if (this.originSlideRoutine != null)
			{
				base.StopCoroutine(this.originSlideRoutine);
			}
			Plane plane = new Plane(Vector3.up, new Vector3(0f, 0f, 0f));
			Ray ray = new Ray(this.targetTransform.position, this.targetTransform.forward);
			float num = 0f;
			plane.Raycast(ray, out num);
			Vector3 point = ray.GetPoint(num);
			Vector3 vector = this.targetTransform.position - point;
			CS$<>8__locals1.position += vector.normalized * offsetDistance;
			this.originSlideRoutine = base.StartCoroutine(CS$<>8__locals1.<SlideCameraOrigin>g__Routine|0());
		}

		// Token: 0x040021D7 RID: 8663
		[Header("Settings")]
		public Vector3 bounds_Min;

		// Token: 0x040021D8 RID: 8664
		public Vector3 bounds_Max;

		// Token: 0x040021D9 RID: 8665
		[Header("Camera settings")]
		public float lateralMovementSpeed = 1f;

		// Token: 0x040021DA RID: 8666
		public float scrollMovementSpeed = 1f;

		// Token: 0x040021DB RID: 8667
		public float targetFollowSpeed = 1f;

		// Token: 0x040021DC RID: 8668
		[Header("Camera orbit settings")]
		public float xSpeed = 250f;

		// Token: 0x040021DD RID: 8669
		public float ySpeed = 120f;

		// Token: 0x040021DE RID: 8670
		public float yMinLimit = -20f;

		// Token: 0x040021DF RID: 8671
		public float yMaxLimit = 80f;

		// Token: 0x040021E0 RID: 8672
		private Vector3 rotationOriginPoint = Vector3.zero;

		// Token: 0x040021E1 RID: 8673
		private float distance = 10f;

		// Token: 0x040021E2 RID: 8674
		private float prevDistance;

		// Token: 0x040021E3 RID: 8675
		private float x;

		// Token: 0x040021E4 RID: 8676
		private float y;

		// Token: 0x040021E5 RID: 8677
		private Transform targetTransform;

		// Token: 0x040021E7 RID: 8679
		private Coroutine originSlideRoutine;
	}
}
