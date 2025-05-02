using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.FX;
using ScheduleOne.Tools;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005E3 RID: 1507
	public class PlayerCamera : PlayerSingleton<PlayerCamera>
	{
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x0009D42A File Offset: 0x0009B62A
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x0009D431 File Offset: 0x0009B631
		public static ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode { get; private set; }

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x0009D439 File Offset: 0x0009B639
		// (set) Token: 0x060026AB RID: 9899 RVA: 0x0009D441 File Offset: 0x0009B641
		public bool canLook { get; protected set; } = true;

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x0009D44A File Offset: 0x0009B64A
		public int activeUIElementCount
		{
			get
			{
				return this.activeUIElements.Count;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x0009D457 File Offset: 0x0009B657
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x0009D45F File Offset: 0x0009B65F
		public bool transformOverriden { get; protected set; }

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x0009D468 File Offset: 0x0009B668
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x0009D470 File Offset: 0x0009B670
		public bool fovOverriden { get; protected set; }

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x0009D479 File Offset: 0x0009B679
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x0009D481 File Offset: 0x0009B681
		public bool FreeCamEnabled { get; private set; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x0009D48A File Offset: 0x0009B68A
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x0009D492 File Offset: 0x0009B692
		public bool ViewingAvatar { get; private set; }

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x0009D49B File Offset: 0x0009B69B
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x0009D4A3 File Offset: 0x0009B6A3
		public PlayerCamera.ECameraMode CameraMode { get; protected set; }

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x0009D4AC File Offset: 0x0009B6AC
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x0009D4B4 File Offset: 0x0009B6B4
		public bool MethVisuals { get; set; }

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x0009D4BD File Offset: 0x0009B6BD
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x0009D4C5 File Offset: 0x0009B6C5
		public bool CocaineVisuals { get; set; }

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x0009D4CE File Offset: 0x0009B6CE
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x0009D4D6 File Offset: 0x0009B6D6
		public float FovJitter { get; private set; }

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x0009D4DF File Offset: 0x0009B6DF
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x0009D4E7 File Offset: 0x0009B6E7
		public List<string> activeUIElements { get; protected set; } = new List<string>();

		// Token: 0x060026BF RID: 9919 RVA: 0x0009D4F0 File Offset: 0x0009B6F0
		protected override void Awake()
		{
			base.Awake();
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 100);
			this.ApplyAASettings();
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x0009D55C File Offset: 0x0009B75C
		public override void OnStartClient(bool IsOwner)
		{
			base.OnStartClient(IsOwner);
			if (!IsOwner)
			{
				Object.Destroy(base.gameObject);
				return;
			}
			this.Camera.enabled = true;
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0009D580 File Offset: 0x0009B780
		protected override void Start()
		{
			base.Start();
			if (Singleton<Settings>.InstanceExists)
			{
				this.Camera.fieldOfView = Singleton<Settings>.Instance.CameraFOV;
			}
			if (GameObject.Find("GlobalVolume") != null)
			{
				this.globalVolume = GameObject.Find("GlobalVolume").GetComponent<Volume>();
				this.globalVolume.sharedProfile.TryGet<DepthOfField>(ref this.DoF);
				this.DoF.active = false;
			}
			this.cameralocalPos_PriorOverride = base.transform.localPosition;
			Singleton<EnvironmentFX>.Instance.HeightFog.mainCamera = this.Camera;
			this.FoVChangeSmoother.Initialize();
			this.FoVChangeSmoother.SetDefault(0f);
			this.SmoothLookSmoother.Initialize();
			this.SmoothLookSmoother.SetDefault(0f);
			this.SmoothLookSmoother.SetSmoothingSpeed(0.5f);
			this.LockMouse();
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0009D66B File Offset: 0x0009B86B
		private void PlayerSpawned()
		{
			Player.Local.onTased.AddListener(new UnityAction(delegate()
			{
				this.StartCameraShake(1f, 2f, true);
			}));
			Player.Local.onTasedEnd.AddListener(new UnityAction(this.StopCameraShake));
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x0009D6A3 File Offset: 0x0009B8A3
		public static void SetAntialiasingMode(ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode mode)
		{
			PlayerCamera.AntiAliasingMode = mode;
			if (PlayerSingleton<PlayerCamera>.Instance != null)
			{
				PlayerSingleton<PlayerCamera>.Instance.ApplyAASettings();
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0009D6C4 File Offset: 0x0009B8C4
		public void ApplyAASettings()
		{
			AntialiasingMode antialiasing;
			switch (PlayerCamera.AntiAliasingMode)
			{
			case ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode.Off:
				antialiasing = 0;
				break;
			case ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode.FXAA:
				antialiasing = 1;
				break;
			case ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode.SMAA:
				antialiasing = 2;
				break;
			default:
				antialiasing = 0;
				break;
			}
			this.Camera.GetComponent<UniversalAdditionalCameraData>().antialiasing = antialiasing;
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x0009D70C File Offset: 0x0009B90C
		protected virtual void Update()
		{
			this.UpdateCameraBob();
			if (this.canLook)
			{
				this.RotateCamera();
			}
			if (this.MethVisuals)
			{
				this.MethRumble.VolumeMultiplier = Mathf.MoveTowards(this.MethRumble.VolumeMultiplier, 1f, Time.deltaTime * 0.5f);
				if (!this.MethRumble.isPlaying)
				{
					this.MethRumble.Play();
				}
			}
			else
			{
				this.MethRumble.VolumeMultiplier = Mathf.MoveTowards(this.MethRumble.VolumeMultiplier, 0f, Time.deltaTime * 0.5f);
				if (this.MethRumble.VolumeMultiplier == 0f && this.MethRumble.isPlaying)
				{
					this.MethRumble.Stop();
				}
			}
			if (this.FreeCamEnabled)
			{
				this.RotateFreeCam();
				this.UpdateFreeCamInput();
				this.MoveFreeCam();
			}
			if (Player.Local.Schizophrenic)
			{
				this.timeUntilNextSchizoVoice -= Time.deltaTime;
				if (this.timeUntilNextSchizoVoice <= 0f)
				{
					this.timeUntilNextSchizoVoice = Random.Range(5f, 20f);
					this.SchizoVoices.VolumeMultiplier = Random.Range(0.5f, 1f);
					this.SchizoVoices.PitchMultiplier = Random.Range(0.4f, 1f);
					this.SchizoVoices.transform.localPosition = Random.insideUnitSphere * 1f;
					this.SchizoVoices.Play();
				}
			}
			if (GameInput.GetButton(GameInput.ButtonCode.ViewAvatar))
			{
				if (!this.ViewingAvatar && this.activeUIElementCount == 0 && this.canLook && !GameInput.IsTyping)
				{
					this.ViewAvatar();
				}
				if (this.ViewingAvatar)
				{
					Vector3 worldPos = this.ViewAvatarCameraPosition.position;
					Vector3 vector = PlayerSingleton<PlayerMovement>.Instance.transform.TransformPoint(new Vector3(0f, this.GetTargetLocalY(), 0f));
					RaycastHit raycastHit;
					if (Physics.Raycast(vector, (this.ViewAvatarCameraPosition.position - vector).normalized, ref raycastHit, Vector3.Distance(vector, this.ViewAvatarCameraPosition.position), 1 << LayerMask.NameToLayer("Default"), 1))
					{
						worldPos = raycastHit.point;
					}
					this.OverrideTransform(worldPos, this.ViewAvatarCameraPosition.rotation, 0f, true);
					base.transform.LookAt(Player.Local.Avatar.LowestSpine.transform);
				}
			}
			else if (this.ViewingAvatar)
			{
				this.StopViewingAvatar();
			}
			if ((this.FreeCamEnabled || Application.isEditor) && Input.GetKeyDown(KeyCode.F12))
			{
				this.Screenshot();
			}
			this.UpdateMovementEvents();
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x0009D9B1 File Offset: 0x0009BBB1
		private void Screenshot()
		{
			base.StartCoroutine(PlayerCamera.<Screenshot>g__Routine|96_0());
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x0009D9C0 File Offset: 0x0009BBC0
		protected virtual void LateUpdate()
		{
			if (this.Camera == null || base.transform == null)
			{
				return;
			}
			if (!PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				return;
			}
			if (!this.transformOverriden && this.ILerpCamera_Coroutine == null)
			{
				base.transform.localPosition = new Vector3(0f, this.GetTargetLocalY(), 0f);
			}
			if (!this.fovOverriden && this.ILerpCameraFOV_Coroutine == null)
			{
				float num = Singleton<Settings>.Instance.CameraFOV * (PlayerSingleton<PlayerMovement>.Instance.isSprinting ? this.SprintFoVBoost : 1f);
				if (this.MethVisuals)
				{
					this.FovJitter = Mathf.Lerp(this.FovJitter, Random.Range(0f, 1f), Time.deltaTime * 10f);
				}
				else if (this.CocaineVisuals)
				{
					this.FovJitter = Mathf.Lerp(this.FovJitter, 1f, Time.deltaTime * 0.5f);
				}
				else
				{
					this.FovJitter = Mathf.Lerp(this.FovJitter, 0f, Time.deltaTime * 3f);
				}
				if (Player.Local.Schizophrenic)
				{
					this.schizoFoV = -Mathf.Lerp(this.schizoFoV, Mathf.Sin(Time.time * 0.5f) * 20f, Time.deltaTime);
				}
				else
				{
					this.schizoFoV = Mathf.Lerp(this.schizoFoV, 0f, Time.deltaTime);
				}
				num += this.FovJitter * 6f;
				num += this.schizoFoV;
				num += this.FoVChangeSmoother.CurrentValue;
				this.Camera.fieldOfView = Mathf.MoveTowards(this.Camera.fieldOfView, num, Time.deltaTime * this.FoVChangeRate);
			}
			this.Camera.transform.localPosition = this.cameraLocalPos;
			this.cameraLocalPos = Vector3.zero;
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0009DBA4 File Offset: 0x0009BDA4
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (this.FreeCamEnabled && action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.SetFreeCam(false, true);
			}
			if (this.ViewingAvatar && action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.StopViewingAvatar();
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0009DBF8 File Offset: 0x0009BDF8
		public float GetTargetLocalY()
		{
			if (!PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				return 0f;
			}
			return PlayerSingleton<PlayerMovement>.Instance.Controller.height / 2f + this.cameraOffsetFromTop;
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0009DC23 File Offset: 0x0009BE23
		public void SetCameraMode(PlayerCamera.ECameraMode mode)
		{
			this.CameraMode = mode;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0009DC2C File Offset: 0x0009BE2C
		private void RotateCamera()
		{
			float num = GameInput.MouseDelta.x * (Singleton<Settings>.InstanceExists ? Singleton<Settings>.Instance.LookSensitivity : 1f);
			float num2 = GameInput.MouseDelta.y * (Singleton<Settings>.InstanceExists ? Singleton<Settings>.Instance.LookSensitivity : 1f);
			if (Player.Local.Disoriented)
			{
				num2 = -num2;
			}
			if (Player.Local.Seizure)
			{
				Vector2 b = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
				this.seizureJitter = Vector2.Lerp(this.seizureJitter, b, Time.deltaTime * 10f);
				num += this.seizureJitter.x;
				num2 += this.seizureJitter.y;
			}
			if (Player.Local.Schizophrenic)
			{
				num += Mathf.Sin(Time.time * 0.4f) * 0.01f;
				num2 += Mathf.Sin(Time.time * 0.3f) * 0.01f;
			}
			if (this.SmoothLook)
			{
				this.mouseX = Mathf.Lerp(this.mouseX, num, this.SmoothLookSpeed * Time.deltaTime);
				this.mouseY = Mathf.Lerp(this.mouseY, num2, this.SmoothLookSpeed * Time.deltaTime);
			}
			else if (this.SmoothLookSmoother.CurrentValue <= 0.01f)
			{
				this.mouseX = num;
				this.mouseY = num2;
			}
			else
			{
				float num3 = Mathf.Lerp(50f, 1f, this.SmoothLookSmoother.CurrentValue);
				this.mouseX = Mathf.Lerp(this.mouseX, num, num3 * Time.deltaTime);
				this.mouseY = Mathf.Lerp(this.mouseY, num2, num3 * Time.deltaTime);
			}
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			Vector3 eulerAngles2 = Player.Local.transform.rotation.eulerAngles;
			if (Singleton<Settings>.InstanceExists && Singleton<Settings>.Instance.InvertMouse)
			{
				this.mouseY = -this.mouseY;
			}
			this.mouseX += this.focusMouseX;
			this.mouseY += this.focusMouseY;
			eulerAngles.x -= Mathf.Clamp(this.mouseY, -89f, 89f);
			eulerAngles2.y += this.mouseX;
			eulerAngles.z = 0f;
			if (eulerAngles.x >= 180f)
			{
				if (eulerAngles.x < 271f)
				{
					eulerAngles.x = 271f;
				}
			}
			else if (eulerAngles.x > 89f)
			{
				eulerAngles.x = 89f;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, 0f, 0f);
			Player.Local.transform.rotation = Quaternion.Euler(eulerAngles2);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0009DF33 File Offset: 0x0009C133
		public void LockMouse()
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			if (Singleton<HUD>.InstanceExists)
			{
				Singleton<HUD>.Instance.SetCrosshairVisible(true);
			}
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0009DF53 File Offset: 0x0009C153
		public void FreeMouse()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			if (Singleton<HUD>.InstanceExists)
			{
				Singleton<HUD>.Instance.SetCrosshairVisible(false);
			}
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x0009DF74 File Offset: 0x0009C174
		public bool LookRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			if (radius == 0f)
			{
				return Physics.Raycast(base.transform.position, base.transform.forward, ref hit, range, layerMask, includeTriggers ? 2 : 1);
			}
			return Physics.SphereCast(base.transform.position, radius, base.transform.forward, ref hit, range, layerMask, includeTriggers ? 2 : 1);
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0009DFE4 File Offset: 0x0009C1E4
		public bool LookRaycast_ExcludeBuildables(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true)
		{
			RaycastHit[] array = Physics.RaycastAll(base.transform.position, base.transform.forward, range, layerMask, includeTriggers ? 2 : 1);
			RaycastHit raycastHit = default(RaycastHit);
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].collider.GetComponentInParent<BuildableItem>() && (raycastHit.collider == null || Vector3.Distance(base.transform.position, array[i].point) < Vector3.Distance(base.transform.position, raycastHit.point)))
				{
					raycastHit = array[i];
				}
			}
			if (raycastHit.collider != null)
			{
				hit = raycastHit;
				return true;
			}
			hit = default(RaycastHit);
			return false;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0009E0B8 File Offset: 0x0009C2B8
		private void OnDrawGizmosSelected()
		{
			for (int i = 0; i < this.gizmos.Count; i++)
			{
				Gizmos.DrawSphere(this.gizmos[i], 0.05f);
			}
			this.gizmos.Clear();
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0009E0FC File Offset: 0x0009C2FC
		public bool Raycast_ExcludeBuildables(Vector3 origin, Vector3 direction, float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = false, float radius = 0f, float maxAngleDifference = 0f)
		{
			RaycastHit[] array;
			if (radius == 0f)
			{
				array = Physics.RaycastAll(origin, direction, range, layerMask, includeTriggers ? 2 : 1);
			}
			else
			{
				array = Physics.SphereCastAll(origin, radius, direction, range, layerMask, includeTriggers ? 2 : 1);
			}
			RaycastHit raycastHit = default(RaycastHit);
			for (int i = 0; i < array.Length; i++)
			{
				if (!(array[i].point == Vector3.zero) && !array[i].collider.GetComponentInParent<BuildableItem>() && (maxAngleDifference == 0f || Vector3.Angle(direction, -array[i].normal) < maxAngleDifference) && (raycastHit.collider == null || Vector3.Distance(base.transform.position, array[i].point) < Vector3.Distance(base.transform.position, raycastHit.point)))
				{
					raycastHit = array[i];
				}
			}
			if (raycastHit.collider != null)
			{
				hit = raycastHit;
				return true;
			}
			hit = default(RaycastHit);
			return false;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0009E230 File Offset: 0x0009C430
		public bool MouseRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			Ray ray = PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenPointToRay(Input.mousePosition);
			if (radius == 0f)
			{
				return Physics.Raycast(ray, ref hit, range, layerMask, includeTriggers ? 2 : 1);
			}
			return Physics.SphereCast(ray, radius, ref hit, range, layerMask, includeTriggers ? 2 : 1);
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x0009E28A File Offset: 0x0009C48A
		public bool LookSpherecast(float range, float radius, out RaycastHit hit, LayerMask layerMask)
		{
			return Physics.SphereCast(base.transform.position, radius, base.transform.forward, ref hit, range, layerMask);
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0009E2B4 File Offset: 0x0009C4B4
		public void OverrideTransform(Vector3 worldPos, Quaternion rot, float lerpTime, bool keepParented = false)
		{
			this.canLook = false;
			if (this.ILerpCamera_Coroutine != null)
			{
				base.StopCoroutine(this.ILerpCamera_Coroutine);
				this.ILerpCamera_Coroutine = null;
			}
			else if (!this.transformOverriden)
			{
				this.cameralocalPos_PriorOverride = base.transform.localPosition;
				this.cameraLocalRot_PriorOverride = base.transform.localRotation;
			}
			this.transformOverriden = true;
			if (!keepParented)
			{
				base.transform.SetParent(null);
			}
			this.ILerpCamera_Coroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.ILerpCamera(worldPos, rot, lerpTime, true, false, false));
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x0009E342 File Offset: 0x0009C542
		protected IEnumerator ILerpCamera(Vector3 endPos, Quaternion endRot, float lerpTime, bool worldSpace, bool returnToRestingPosition = false, bool reenableLook = false)
		{
			Vector3 startPos = base.transform.localPosition;
			Quaternion startRot = base.transform.rotation;
			if (worldSpace)
			{
				startPos = base.transform.position;
			}
			float elapsed = 0f;
			while (elapsed < lerpTime)
			{
				if (returnToRestingPosition)
				{
					base.transform.localPosition = Vector3.Lerp(startPos, new Vector3(0f, this.GetTargetLocalY(), 0f), elapsed / lerpTime);
				}
				else if (worldSpace)
				{
					base.transform.position = Vector3.Lerp(startPos, endPos, elapsed / lerpTime);
				}
				else
				{
					base.transform.localPosition = Vector3.Lerp(startPos, endPos, elapsed / lerpTime);
				}
				base.transform.rotation = Quaternion.Lerp(startRot, endRot, elapsed / lerpTime);
				elapsed += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			if (returnToRestingPosition)
			{
				base.transform.localPosition = new Vector3(0f, this.GetTargetLocalY(), 0f);
			}
			else if (worldSpace)
			{
				base.transform.position = endPos;
			}
			else
			{
				base.transform.localPosition = endPos;
			}
			if (reenableLook)
			{
				this.SetCanLook(true);
			}
			base.transform.rotation = endRot;
			this.ILerpCamera_Coroutine = null;
			yield break;
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x0009E380 File Offset: 0x0009C580
		public void StopTransformOverride(float lerpTime, bool reenableCameraLook = true, bool returnToOriginalRotation = true)
		{
			if (this.blockNextStopTransformOverride)
			{
				this.blockNextStopTransformOverride = false;
				return;
			}
			if (this.ILerpCamera_Coroutine != null)
			{
				base.StopCoroutine(this.ILerpCamera_Coroutine);
				this.ILerpCamera_Coroutine = null;
			}
			this.transformOverriden = false;
			base.transform.SetParent(PlayerSingleton<PlayerMovement>.Instance.transform);
			if (this.ILerpCamera_Coroutine != null)
			{
				base.StopCoroutine(this.ILerpCamera_Coroutine);
			}
			Quaternion quaternion = PlayerSingleton<PlayerMovement>.Instance.transform.rotation * this.cameraLocalRot_PriorOverride;
			if (!returnToOriginalRotation)
			{
				quaternion = base.transform.rotation;
			}
			if (lerpTime == 0f)
			{
				base.transform.rotation = quaternion;
				base.transform.localPosition = new Vector3(0f, this.GetTargetLocalY(), 0f);
				if (reenableCameraLook)
				{
					this.SetCanLook_True();
					return;
				}
			}
			else
			{
				this.ILerpCamera_Coroutine = base.StartCoroutine(this.ILerpCamera(this.cameralocalPos_PriorOverride, quaternion, lerpTime, false, true, reenableCameraLook));
			}
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0009E470 File Offset: 0x0009C670
		public void LookAt(Vector3 point, float duration = 0.25f)
		{
			PlayerCamera.<>c__DisplayClass118_0 CS$<>8__locals1 = new PlayerCamera.<>c__DisplayClass118_0();
			CS$<>8__locals1.point = point;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.duration = duration;
			if (this.lookRoutine != null)
			{
				base.StopCoroutine(this.lookRoutine);
			}
			base.StartCoroutine(CS$<>8__locals1.<LookAt>g__Look|0());
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x0009E4B9 File Offset: 0x0009C6B9
		private void SetCanLook_True()
		{
			this.SetCanLook(true);
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x0009E4C2 File Offset: 0x0009C6C2
		public void SetCanLook(bool c)
		{
			this.canLook = c;
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x0009E4CB File Offset: 0x0009C6CB
		public void SetDoFActive(bool active, float lerpTime)
		{
			if (this.DoFCoroutine != null)
			{
				base.StopCoroutine(this.DoFCoroutine);
			}
			this.DoFCoroutine = base.StartCoroutine(this.LerpDoF(active, lerpTime));
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x0009E4F5 File Offset: 0x0009C6F5
		private IEnumerator LerpDoF(bool active, float lerpTime)
		{
			if (active)
			{
				this.DoF.active = true;
			}
			float startFocusDist = this.DoF.focusDistance.value;
			float endFocusDist = 0f;
			if (active)
			{
				endFocusDist = 0.1f;
			}
			else
			{
				endFocusDist = 5f;
			}
			for (float i = 0f; i < lerpTime; i += Time.unscaledDeltaTime)
			{
				this.DoF.focusDistance.value = Mathf.Lerp(startFocusDist, endFocusDist, i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			this.DoF.focusDistance.value = endFocusDist;
			if (!active)
			{
				this.DoF.active = false;
			}
			this.DoFCoroutine = null;
			yield break;
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x0009E514 File Offset: 0x0009C714
		public void OverrideFOV(float fov, float lerpTime)
		{
			if (this.ILerpCameraFOV_Coroutine != null)
			{
				base.StopCoroutine(this.ILerpCameraFOV_Coroutine);
			}
			this.fovOverriden = true;
			if (fov == -1f)
			{
				fov = Singleton<Settings>.Instance.CameraFOV;
			}
			this.ILerpCameraFOV_Coroutine = base.StartCoroutine(this.ILerpFOV(fov, lerpTime));
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0009E564 File Offset: 0x0009C764
		protected IEnumerator ILerpFOV(float endFov, float lerpTime)
		{
			float startFov = this.Camera.fieldOfView;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				this.Camera.fieldOfView = Mathf.Lerp(startFov, endFov, i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			this.Camera.fieldOfView = endFov;
			this.ILerpCameraFOV_Coroutine = null;
			yield break;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x0009E581 File Offset: 0x0009C781
		public void StopFOVOverride(float lerpTime)
		{
			this.OverrideFOV(-1f, lerpTime);
			this.fovOverriden = false;
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0009E596 File Offset: 0x0009C796
		public void AddActiveUIElement(string name)
		{
			if (!this.activeUIElements.Contains(name))
			{
				this.activeUIElements.Add(name);
			}
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x0009E5B2 File Offset: 0x0009C7B2
		public void RemoveActiveUIElement(string name)
		{
			if (this.activeUIElements.Contains(name))
			{
				this.activeUIElements.Remove(name);
			}
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x0009E5D0 File Offset: 0x0009C7D0
		public void RegisterMovementEvent(int threshold, Action action)
		{
			if (threshold < 1)
			{
				Console.LogWarning("Movement events min. threshold is 1m!", null);
				return;
			}
			if (!this.movementEvents.ContainsKey(threshold))
			{
				this.movementEvents.Add(threshold, new PlayerMovement.MovementEvent());
			}
			this.movementEvents[threshold].actions.Add(action);
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x0009E624 File Offset: 0x0009C824
		public void DeregisterMovementEvent(Action action)
		{
			foreach (int key in this.movementEvents.Keys)
			{
				PlayerMovement.MovementEvent movementEvent = this.movementEvents[key];
				if (movementEvent.actions.Contains(action))
				{
					movementEvent.actions.Remove(action);
					break;
				}
			}
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x0009E6A0 File Offset: 0x0009C8A0
		private void UpdateMovementEvents()
		{
			foreach (int num in this.movementEvents.Keys.ToList<int>())
			{
				PlayerMovement.MovementEvent movementEvent = this.movementEvents[num];
				if (Vector3.Distance(base.transform.position, movementEvent.LastUpdatedDistance) > (float)num)
				{
					movementEvent.Update(base.transform.position);
				}
			}
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x0009E730 File Offset: 0x0009C930
		private void ViewAvatar()
		{
			this.ViewingAvatar = true;
			this.AddActiveUIElement("View avatar");
			Vector3 worldPos = this.ViewAvatarCameraPosition.position;
			Vector3 vector = PlayerSingleton<PlayerMovement>.Instance.transform.TransformPoint(new Vector3(0f, this.GetTargetLocalY(), 0f));
			RaycastHit raycastHit;
			if (Physics.Raycast(vector, (this.ViewAvatarCameraPosition.position - vector).normalized, ref raycastHit, Vector3.Distance(vector, this.ViewAvatarCameraPosition.position), 1 << LayerMask.NameToLayer("Default"), 1))
			{
				worldPos = raycastHit.point;
			}
			this.OverrideTransform(worldPos, this.ViewAvatarCameraPosition.rotation, 0f, true);
			base.transform.LookAt(Player.Local.Avatar.LowestSpine.transform);
			Singleton<HUD>.Instance.canvas.enabled = false;
			PlayerSingleton<PlayerInventory>.Instance.SetViewmodelVisible(false);
			Player.Local.SetVisibleToLocalPlayer(true);
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x0009E82C File Offset: 0x0009CA2C
		private void StopViewingAvatar()
		{
			this.ViewingAvatar = false;
			this.RemoveActiveUIElement("View avatar");
			this.StopTransformOverride(0f, true, true);
			Singleton<HUD>.Instance.canvas.enabled = true;
			PlayerSingleton<PlayerInventory>.Instance.SetViewmodelVisible(true);
			Player.Local.SetVisibleToLocalPlayer(false);
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0009E880 File Offset: 0x0009CA80
		public void JoltCamera()
		{
			AnimationClip animationClip = this.JoltClips[Random.Range(0, this.JoltClips.Length)];
			this.Animator.Play(animationClip.name, 0, 0f);
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x0009E8BC File Offset: 0x0009CABC
		public bool PointInCameraView(Vector3 point)
		{
			Vector3 vector = this.Camera.WorldToViewportPoint(point);
			bool flag = this.Is01(vector.x) && this.Is01(vector.y);
			bool flag2 = vector.z > 0f;
			bool flag3 = false;
			Vector3 normalized = (point - this.Camera.transform.position).normalized;
			float num = Vector3.Distance(this.Camera.transform.position, point);
			RaycastHit raycastHit;
			if (Physics.Raycast(this.Camera.transform.position, normalized, ref raycastHit, num + 0.05f, 1 << LayerMask.NameToLayer("Default")) && raycastHit.point != point)
			{
				flag3 = true;
			}
			return flag && flag2 && !flag3;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x0009E989 File Offset: 0x0009CB89
		public bool Is01(float a)
		{
			return a > 0f && a < 1f;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0009E99D File Offset: 0x0009CB9D
		public void ResetRotation()
		{
			base.transform.localRotation = Quaternion.identity;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0009E9B0 File Offset: 0x0009CBB0
		public void FocusCameraOnTarget(Transform target)
		{
			PlayerCamera.<>c__DisplayClass139_0 CS$<>8__locals1 = new PlayerCamera.<>c__DisplayClass139_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.target = target;
			if (this.focusRoutine != null)
			{
				base.StopCoroutine(this.focusRoutine);
			}
			this.focusRoutine = base.StartCoroutine(CS$<>8__locals1.<FocusCameraOnTarget>g__FocusRoutine|0());
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x0009E9F7 File Offset: 0x0009CBF7
		public void StopFocus()
		{
			if (this.focusRoutine != null)
			{
				base.StopCoroutine(this.focusRoutine);
			}
			this.focusMouseX = 0f;
			this.focusMouseY = 0f;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x0009EA24 File Offset: 0x0009CC24
		public void StartCameraShake(float intensity, float duration = -1f, bool decreaseOverTime = true)
		{
			PlayerCamera.<>c__DisplayClass141_0 CS$<>8__locals1 = new PlayerCamera.<>c__DisplayClass141_0();
			CS$<>8__locals1.duration = duration;
			CS$<>8__locals1.intensity = intensity;
			CS$<>8__locals1.decreaseOverTime = decreaseOverTime;
			CS$<>8__locals1.<>4__this = this;
			this.StopCameraShake();
			this.cameraShakeCoroutine = base.StartCoroutine(CS$<>8__locals1.<StartCameraShake>g__Shake|0());
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x0009EA6B File Offset: 0x0009CC6B
		public void StopCameraShake()
		{
			if (this.cameraShakeCoroutine != null)
			{
				base.StopCoroutine(this.cameraShakeCoroutine);
				this.Camera.transform.localPosition = Vector3.zero;
			}
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x0009EA98 File Offset: 0x0009CC98
		public void UpdateCameraBob()
		{
			float num = 1f;
			if (PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				num = PlayerSingleton<PlayerMovement>.Instance.CurrentSprintMultiplier - 1f;
			}
			num *= Singleton<Settings>.Instance.CameraBobIntensity;
			this.cameraLocalPos.x = this.cameraLocalPos.x + this.HorizontalBobCurve.Evaluate(Time.time * this.BobRate % 1f) * num * this.HorizontalCameraBob;
			this.cameraLocalPos.y = this.cameraLocalPos.y + this.VerticalBobCurve.Evaluate(Time.time * this.BobRate % 1f) * num * this.VerticalCameraBob;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x0009EB3C File Offset: 0x0009CD3C
		public void SetFreeCam(bool enable, bool reenableLook = true)
		{
			this.FreeCamEnabled = enable;
			Singleton<HUD>.Instance.canvas.enabled = !enable;
			PlayerSingleton<PlayerMovement>.Instance.canMove = !enable;
			Player.Local.SetVisibleToLocalPlayer(enable);
			if (enable)
			{
				this.OverrideTransform(base.transform.position, base.transform.rotation, 0f, false);
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
				return;
			}
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			this.StopTransformOverride(0f, reenableLook, true);
			this.freeCamMovement = Vector3.zero;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x0009EBDC File Offset: 0x0009CDDC
		private void RotateFreeCam()
		{
			this.mouseX = Mathf.Lerp(this.mouseX, GameInput.MouseDelta.x * (Singleton<Settings>.InstanceExists ? Singleton<Settings>.Instance.LookSensitivity : 1f), this.SmoothLookSpeed * Time.deltaTime);
			this.mouseY = Mathf.Lerp(this.mouseY, GameInput.MouseDelta.y * (Singleton<Settings>.InstanceExists ? Singleton<Settings>.Instance.LookSensitivity : 1f), this.SmoothLookSpeed * Time.deltaTime);
			Vector3 eulerAngles = base.transform.localRotation.eulerAngles;
			Vector3 eulerAngles2 = base.transform.localRotation.eulerAngles;
			if (Singleton<Settings>.InstanceExists && Singleton<Settings>.Instance.InvertMouse)
			{
				this.mouseY = -this.mouseY;
			}
			eulerAngles.x -= Mathf.Clamp(this.mouseY, -89f, 89f);
			eulerAngles.y += this.mouseX;
			eulerAngles.z = 0f;
			if (eulerAngles.x >= 180f)
			{
				if (eulerAngles.x < 271f)
				{
					eulerAngles.x = 271f;
				}
			}
			else if (eulerAngles.x > 89f)
			{
				eulerAngles.x = 89f;
			}
			base.transform.localRotation = Quaternion.Euler(eulerAngles);
			base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, 0f);
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x0009ED78 File Offset: 0x0009CF78
		private void UpdateFreeCamInput()
		{
			int num = Mathf.RoundToInt(GameInput.MotionAxis.x);
			int num2 = Mathf.RoundToInt(GameInput.MotionAxis.y);
			int num3 = 0;
			if (GameInput.GetButton(GameInput.ButtonCode.Jump))
			{
				num3 = 1;
			}
			else if (GameInput.GetButton(GameInput.ButtonCode.Crouch))
			{
				num3 = -1;
			}
			if (GameInput.IsTyping)
			{
				num = 0;
				num2 = 0;
				num3 = 0;
			}
			this.freeCamSpeed += Input.mouseScrollDelta.y * Time.deltaTime;
			this.freeCamSpeed = Mathf.Clamp(this.freeCamSpeed, 0f, 10f);
			this.freeCamMovement = new Vector3(Mathf.MoveTowards(this.freeCamMovement.x, (float)num, Time.unscaledDeltaTime * this.FreeCamAcceleration), Mathf.MoveTowards(this.freeCamMovement.y, (float)num3, Time.unscaledDeltaTime * this.FreeCamAcceleration), Mathf.MoveTowards(this.freeCamMovement.z, (float)num2, Time.unscaledDeltaTime * this.FreeCamAcceleration));
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x0009EE68 File Offset: 0x0009D068
		private void MoveFreeCam()
		{
			base.transform.position += base.transform.TransformVector(this.freeCamMovement) * this.FreeCamSpeed * this.freeCamSpeed * Time.unscaledDeltaTime * (GameInput.GetButton(GameInput.ButtonCode.Sprint) ? 3f : 1f);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0009EFD6 File Offset: 0x0009D1D6
		[CompilerGenerated]
		internal static IEnumerator <Screenshot>g__Routine|96_0()
		{
			yield return new WaitForEndOfFrame();
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			text = Path.Combine(text, "Screenshot_" + DateTime.Now.ToString("HH-mm-ss") + ".png");
			Console.Log("Screenshot saved to: " + text, null);
			ScreenCapture.CaptureScreenshot(text, 2);
			yield return new WaitForEndOfFrame();
			yield break;
		}

		// Token: 0x04001C0B RID: 7179
		public const float CAMERA_SHAKE_MULTIPLIER = 0.1f;

		// Token: 0x04001C0D RID: 7181
		[Header("Settings")]
		public float cameraOffsetFromTop = -0.15f;

		// Token: 0x04001C0E RID: 7182
		public float SprintFoVBoost = 1.15f;

		// Token: 0x04001C0F RID: 7183
		public float FoVChangeRate = 4f;

		// Token: 0x04001C10 RID: 7184
		public float HorizontalCameraBob = 1f;

		// Token: 0x04001C11 RID: 7185
		public float VerticalCameraBob = 1f;

		// Token: 0x04001C12 RID: 7186
		public float BobRate = 10f;

		// Token: 0x04001C13 RID: 7187
		public AnimationCurve HorizontalBobCurve;

		// Token: 0x04001C14 RID: 7188
		public AnimationCurve VerticalBobCurve;

		// Token: 0x04001C15 RID: 7189
		public float FreeCamSpeed = 1f;

		// Token: 0x04001C16 RID: 7190
		public float FreeCamAcceleration = 2f;

		// Token: 0x04001C17 RID: 7191
		public bool SmoothLook;

		// Token: 0x04001C18 RID: 7192
		public float SmoothLookSpeed = 1f;

		// Token: 0x04001C19 RID: 7193
		public FloatSmoother FoVChangeSmoother;

		// Token: 0x04001C1A RID: 7194
		public FloatSmoother SmoothLookSmoother;

		// Token: 0x04001C1B RID: 7195
		[Header("References")]
		public Transform CameraContainer;

		// Token: 0x04001C1C RID: 7196
		public Camera Camera;

		// Token: 0x04001C1D RID: 7197
		public Camera OverlayCamera;

		// Token: 0x04001C1E RID: 7198
		public Animator Animator;

		// Token: 0x04001C1F RID: 7199
		public AnimationClip[] JoltClips;

		// Token: 0x04001C20 RID: 7200
		public UniversalRenderPipelineAsset[] URPAssets;

		// Token: 0x04001C21 RID: 7201
		public Transform ViewAvatarCameraPosition;

		// Token: 0x04001C22 RID: 7202
		public HeartbeatSoundController HeartbeatSoundController;

		// Token: 0x04001C23 RID: 7203
		public ParticleSystem Flies;

		// Token: 0x04001C24 RID: 7204
		public AudioSourceController MethRumble;

		// Token: 0x04001C25 RID: 7205
		public RandomizedAudioSourceController SchizoVoices;

		// Token: 0x04001C29 RID: 7209
		[HideInInspector]
		public bool blockNextStopTransformOverride;

		// Token: 0x04001C30 RID: 7216
		private Volume globalVolume;

		// Token: 0x04001C31 RID: 7217
		private DepthOfField DoF;

		// Token: 0x04001C33 RID: 7219
		private Coroutine cameraShakeCoroutine;

		// Token: 0x04001C34 RID: 7220
		private Vector3 cameraLocalPos = Vector3.zero;

		// Token: 0x04001C35 RID: 7221
		private Vector3 freeCamMovement = Vector3.zero;

		// Token: 0x04001C36 RID: 7222
		private Coroutine focusRoutine;

		// Token: 0x04001C37 RID: 7223
		private float focusMouseX;

		// Token: 0x04001C38 RID: 7224
		private float focusMouseY;

		// Token: 0x04001C39 RID: 7225
		private Dictionary<int, PlayerMovement.MovementEvent> movementEvents = new Dictionary<int, PlayerMovement.MovementEvent>();

		// Token: 0x04001C3A RID: 7226
		private float freeCamSpeed = 1f;

		// Token: 0x04001C3B RID: 7227
		private float mouseX;

		// Token: 0x04001C3C RID: 7228
		private float mouseY;

		// Token: 0x04001C3D RID: 7229
		private Vector2 seizureJitter = Vector2.zero;

		// Token: 0x04001C3E RID: 7230
		private float schizoFoV;

		// Token: 0x04001C3F RID: 7231
		private float timeUntilNextSchizoVoice = 15f;

		// Token: 0x04001C40 RID: 7232
		private List<Vector3> gizmos = new List<Vector3>();

		// Token: 0x04001C41 RID: 7233
		private Vector3 cameralocalPos_PriorOverride = Vector3.zero;

		// Token: 0x04001C42 RID: 7234
		private Quaternion cameraLocalRot_PriorOverride = Quaternion.identity;

		// Token: 0x04001C43 RID: 7235
		public Coroutine ILerpCamera_Coroutine;

		// Token: 0x04001C44 RID: 7236
		private Coroutine lookRoutine;

		// Token: 0x04001C45 RID: 7237
		private Coroutine DoFCoroutine;

		// Token: 0x04001C46 RID: 7238
		private Coroutine ILerpCameraFOV_Coroutine;

		// Token: 0x020005E4 RID: 1508
		public enum ECameraMode
		{
			// Token: 0x04001C48 RID: 7240
			Default,
			// Token: 0x04001C49 RID: 7241
			Vehicle,
			// Token: 0x04001C4A RID: 7242
			Skateboard
		}
	}
}
