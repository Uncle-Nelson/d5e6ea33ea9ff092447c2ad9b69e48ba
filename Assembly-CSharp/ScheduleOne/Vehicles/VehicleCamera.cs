using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007D3 RID: 2003
	public class VehicleCamera : MonoBehaviour
	{
		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x00045196 File Offset: 0x00043396
		private Transform cam
		{
			get
			{
				return PlayerSingleton<PlayerCamera>.Instance.transform;
			}
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x000E668C File Offset: 0x000E488C
		protected virtual void Start()
		{
			this.targetTransform = new GameObject("VehicleCameraTargetTransform").transform;
			this.targetTransform.SetParent(NetworkSingleton<GameManager>.Instance.Temp);
			this.cameraDolly = new GameObject("VehicleCameraDolly").transform;
			this.cameraDolly.SetParent(NetworkSingleton<GameManager>.Instance.Temp);
			if (Player.Local != null)
			{
				this.Subscribe();
				return;
			}
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.Subscribe));
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x000E6721 File Offset: 0x000E4921
		private void Subscribe()
		{
			Player local = Player.Local;
			local.onEnterVehicle = (Player.VehicleEvent)Delegate.Combine(local.onEnterVehicle, new Player.VehicleEvent(this.PlayerEnteredVehicle));
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x000E6749 File Offset: 0x000E4949
		protected virtual void Update()
		{
			this.timeSinceCameraManuallyAdjusted += Time.deltaTime;
			this.CheckForClick();
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x000E6764 File Offset: 0x000E4964
		private void PlayerEnteredVehicle(LandVehicle veh)
		{
			if (veh != this.vehicle)
			{
				return;
			}
			this.timeSinceCameraManuallyAdjusted = 100f;
			this.LateUpdate();
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.targetTransform.position, this.targetTransform.rotation, 0f, false);
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x000E67B8 File Offset: 0x000E49B8
		private void CheckForClick()
		{
			if (this.vehicle.localPlayerIsInVehicle && GameInput.GetButton(GameInput.ButtonCode.SecondaryClick))
			{
				if (GameInput.GetButtonDown(GameInput.ButtonCode.SecondaryClick) && this.timeSinceCameraManuallyAdjusted > 0.01f)
				{
					Vector3 eulerAngles = this.cam.rotation.eulerAngles;
					this.x = eulerAngles.y;
					this.y = eulerAngles.x;
					this.orbitDistance = Mathf.Sqrt(Mathf.Pow(this.lateralOffset, 2f) + Mathf.Pow(this.verticalOffset, 2f));
				}
				this.timeSinceCameraManuallyAdjusted = 0f;
			}
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x000E6858 File Offset: 0x000E4A58
		protected virtual void LateUpdate()
		{
			if (this.vehicle.localPlayerIsInVehicle)
			{
				if (this.vehicle.speed_Kmh > 2f)
				{
					this.cameraReversed = false;
				}
				else if (this.vehicle.speed_Kmh < -15f)
				{
					this.cameraReversed = true;
				}
				this.targetTransform.position = this.LimitCameraPosition(this.GetTargetCameraPosition());
				this.targetTransform.LookAt(this.cameraOrigin);
				this.cameraDolly.position = Vector3.Lerp(this.cameraDolly.position, this.targetTransform.position, Time.deltaTime * 10f);
				this.cameraDolly.rotation = Quaternion.Lerp(this.cameraDolly.rotation, this.targetTransform.rotation, Time.deltaTime * 10f);
				this.orbitDistance = Mathf.Clamp(Vector3.Distance(this.cameraOrigin.position, this.cameraDolly.position), Mathf.Sqrt(Mathf.Pow(this.lateralOffset, 2f) + Mathf.Pow(this.verticalOffset, 2f)), 100f);
				if (this.timeSinceCameraManuallyAdjusted <= 0.01f)
				{
					if (GameInput.GetButton(GameInput.ButtonCode.SecondaryClick))
					{
						this.x += GameInput.MouseDelta.x * 60f * 0.02f * Singleton<Settings>.Instance.LookSensitivity;
						this.y -= GameInput.MouseDelta.y * 40f * 0.02f * Singleton<Settings>.Instance.LookSensitivity;
						this.y = VehicleCamera.ClampAngle(this.y, -20f, 89f);
						Quaternion rotation = Quaternion.Euler(this.y, this.x, 0f);
						Vector3 targetPosition = rotation * new Vector3(0f, 0f, -this.orbitDistance) + this.cameraOrigin.position;
						this.cam.rotation = rotation;
						this.cam.position = this.LimitCameraPosition(targetPosition);
					}
					else
					{
						Vector3 normalized = (this.cameraOrigin.TransformPoint(this.lastFrameCameraOffset) - this.cameraOrigin.position).normalized;
						Vector3 targetPosition2 = this.cameraOrigin.position + normalized * this.orbitDistance;
						this.cam.position = this.LimitCameraPosition(targetPosition2);
						this.cam.LookAt(this.cameraOrigin);
						Vector3 eulerAngles = this.cam.rotation.eulerAngles;
						this.x = eulerAngles.y;
						this.y = eulerAngles.x;
					}
					this.lastManualOffset = this.cameraOrigin.InverseTransformPoint(this.cam.position);
				}
				else if (this.timeSinceCameraManuallyAdjusted < 0.61f)
				{
					this.targetTransform.position = Vector3.Lerp(this.cameraOrigin.TransformPoint(this.lastManualOffset), this.targetTransform.position, (this.timeSinceCameraManuallyAdjusted - 0.01f) / 0.6f);
					this.targetTransform.LookAt(this.cameraOrigin);
					this.cam.position = Vector3.Lerp(this.cam.position, this.targetTransform.position, Time.deltaTime * 10f);
					this.cam.rotation = Quaternion.Lerp(this.cam.rotation, this.targetTransform.rotation, Time.deltaTime * 10f);
				}
				else
				{
					this.cam.position = Vector3.Lerp(this.cam.position, this.targetTransform.position, Time.deltaTime * 10f);
					this.cam.rotation = Quaternion.Lerp(this.cam.rotation, this.targetTransform.rotation, Time.deltaTime * 10f);
				}
				this.lastFrameCameraOffset = this.cameraOrigin.InverseTransformPoint(this.cam.position);
			}
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x0000809D File Offset: 0x0000629D
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

		// Token: 0x060036CB RID: 14027 RVA: 0x000E6C7C File Offset: 0x000E4E7C
		private Vector3 GetTargetCameraPosition()
		{
			Vector3 a = -base.transform.forward;
			a.y = 0f;
			a.Normalize();
			if (this.cameraReversed)
			{
				a *= -1f;
			}
			return base.transform.position + a * this.lateralOffset + Vector3.up * this.verticalOffset;
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x000E6CF4 File Offset: 0x000E4EF4
		private Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			Vector3 vector = targetPosition;
			default(LayerMask) | 1 << LayerMask.NameToLayer("Default") | 1 << LayerMask.NameToLayer("Terrain");
			float num = 0.45f;
			Vector3 vector2 = Vector3.Normalize(vector - this.cameraOrigin.position);
			RaycastHit raycastHit;
			if (Physics.Raycast(this.cameraOrigin.position, vector2, ref raycastHit, Vector3.Distance(base.transform.position, vector) + num, 1 << LayerMask.NameToLayer("Default")))
			{
				vector = raycastHit.point - vector2 * num;
			}
			return vector;
		}

		// Token: 0x04002741 RID: 10049
		private const float followDelta = 10f;

		// Token: 0x04002742 RID: 10050
		private const float yMinLimit = -20f;

		// Token: 0x04002743 RID: 10051
		private const float manualOverrideTime = 0.01f;

		// Token: 0x04002744 RID: 10052
		private const float manualOverrideReturnTime = 0.6f;

		// Token: 0x04002745 RID: 10053
		private const float xSpeed = 60f;

		// Token: 0x04002746 RID: 10054
		private const float ySpeed = 40f;

		// Token: 0x04002747 RID: 10055
		private const float yMaxLimit = 89f;

		// Token: 0x04002748 RID: 10056
		[Header("References")]
		public LandVehicle vehicle;

		// Token: 0x04002749 RID: 10057
		[Header("Camera Settings")]
		[SerializeField]
		protected Transform cameraOrigin;

		// Token: 0x0400274A RID: 10058
		[SerializeField]
		protected float lateralOffset = 4f;

		// Token: 0x0400274B RID: 10059
		[SerializeField]
		protected float verticalOffset = 1.5f;

		// Token: 0x0400274C RID: 10060
		protected bool cameraReversed;

		// Token: 0x0400274D RID: 10061
		protected float timeSinceCameraManuallyAdjusted = float.MaxValue;

		// Token: 0x0400274E RID: 10062
		protected float orbitDistance;

		// Token: 0x0400274F RID: 10063
		protected Vector3 lastFrameCameraOffset = Vector3.zero;

		// Token: 0x04002750 RID: 10064
		protected Vector3 lastManualOffset = Vector3.zero;

		// Token: 0x04002751 RID: 10065
		private Transform targetTransform;

		// Token: 0x04002752 RID: 10066
		private Transform cameraDolly;

		// Token: 0x04002753 RID: 10067
		private float x;

		// Token: 0x04002754 RID: 10068
		private float y;
	}
}
