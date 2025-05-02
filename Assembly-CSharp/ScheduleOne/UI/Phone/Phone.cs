using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.ScriptableObjects;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000AA3 RID: 2723
	public class Phone : PlayerSingleton<Phone>
	{
		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x001331FC File Offset: 0x001313FC
		// (set) Token: 0x06004947 RID: 18759 RVA: 0x00133204 File Offset: 0x00131404
		public bool IsOpen { get; protected set; }

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06004948 RID: 18760 RVA: 0x0013320D File Offset: 0x0013140D
		// (set) Token: 0x06004949 RID: 18761 RVA: 0x00133215 File Offset: 0x00131415
		public bool isHorizontal { get; protected set; }

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600494A RID: 18762 RVA: 0x0013321E File Offset: 0x0013141E
		// (set) Token: 0x0600494B RID: 18763 RVA: 0x00133226 File Offset: 0x00131426
		public bool isOpenable { get; protected set; } = true;

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x0013322F File Offset: 0x0013142F
		// (set) Token: 0x0600494D RID: 18765 RVA: 0x00133237 File Offset: 0x00131437
		public bool FlashlightOn { get; protected set; }

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x0600494E RID: 18766 RVA: 0x00133240 File Offset: 0x00131440
		public float ScaledLookOffset
		{
			get
			{
				return Mathf.Lerp(this.LookOffsetMax, this.LookOffsetMin, CanvasScaler.NormalizedCanvasScaleFactor);
			}
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x00133258 File Offset: 0x00131458
		protected override void Awake()
		{
			base.Awake();
			this.eventSystem = EventSystem.current;
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x0013326B File Offset: 0x0013146B
		public override void OnStartClient(bool IsOwner)
		{
			base.OnStartClient(IsOwner);
			if (!IsOwner)
			{
				Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x00133284 File Offset: 0x00131484
		protected override void Start()
		{
			base.Start();
			if (this.flashlightVisibility == null)
			{
				this.flashlightVisibility = new VisibilityAttribute("Flashlight", 0f, 1f, -1);
			}
			base.transform.localRotation = this.orientation_Vertical.localRotation;
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x001332D0 File Offset: 0x001314D0
		protected virtual void Update()
		{
			if (this.IsOpen)
			{
				Singleton<HUD>.Instance.OnlineBalanceDisplay.Show();
			}
			if (!GameInput.IsTyping && !Singleton<PauseMenu>.Instance.IsPaused && (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount == 0 || this.IsOpen) && GameInput.GetButtonDown(GameInput.ButtonCode.ToggleFlashlight))
			{
				this.ToggleFlashlight();
			}
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x0013332A File Offset: 0x0013152A
		protected override void OnDestroy()
		{
			base.OnDestroy();
			Phone.ActiveApp = null;
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00133338 File Offset: 0x00131538
		private void ToggleFlashlight()
		{
			this.FlashlightOn = !this.FlashlightOn;
			this.PhoneFlashlight.SetActive(this.FlashlightOn);
			this.FlashlightToggleSound.PitchMultiplier = (this.FlashlightOn ? 1f : 0.9f);
			this.FlashlightToggleSound.Play();
			this.flashlightVisibility.pointsChange = (this.FlashlightOn ? 10f : 0f);
			this.flashlightVisibility.multiplier = (this.FlashlightOn ? 1.5f : 1f);
			Player.Local.SendFlashlightOn(this.FlashlightOn);
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x001333DD File Offset: 0x001315DD
		public void SetOpenable(bool o)
		{
			this.isOpenable = o;
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x001333E8 File Offset: 0x001315E8
		public void SetIsOpen(bool o)
		{
			this.IsOpen = o;
			if (this.IsOpen)
			{
				if (this.onPhoneOpened != null)
				{
					this.onPhoneOpened();
				}
				if (Phone.ActiveApp == null)
				{
					this.SetLookOffsetMultiplier(1f);
					return;
				}
			}
			else if (this.onPhoneClosed != null)
			{
				this.onPhoneClosed();
			}
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x00133443 File Offset: 0x00131643
		public void SetIsHorizontal(bool h)
		{
			this.isHorizontal = h;
			if (this.rotationCoroutine != null)
			{
				base.StopCoroutine(this.rotationCoroutine);
			}
			this.rotationCoroutine = base.StartCoroutine(this.SetIsHorizontal_Process(h));
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x00133473 File Offset: 0x00131673
		protected IEnumerator SetIsHorizontal_Process(bool h)
		{
			float adjustedRotationTime = this.rotationTime;
			Quaternion startRotation = base.transform.localRotation;
			Quaternion endRotation = Quaternion.identity;
			if (h)
			{
				endRotation = this.orientation_Horizontal.localRotation;
				adjustedRotationTime *= Quaternion.Angle(base.transform.localRotation, this.orientation_Horizontal.localRotation) / 90f;
			}
			else
			{
				endRotation = this.orientation_Vertical.localRotation;
				adjustedRotationTime *= Quaternion.Angle(base.transform.localRotation, this.orientation_Vertical.localRotation) / 90f;
			}
			for (float i = 0f; i < adjustedRotationTime; i += Time.deltaTime)
			{
				base.transform.localRotation = Quaternion.Lerp(startRotation, endRotation, i / adjustedRotationTime);
				yield return new WaitForEndOfFrame();
			}
			base.transform.localRotation = endRotation;
			this.rotationCoroutine = null;
			yield break;
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x0013348C File Offset: 0x0013168C
		public void SetLookOffsetMultiplier(float multiplier)
		{
			float lookOffset_Process = this.ScaledLookOffset * multiplier;
			if (this.lookOffsetCoroutine != null)
			{
				base.StopCoroutine(this.lookOffsetCoroutine);
			}
			this.lookOffsetCoroutine = base.StartCoroutine(this.SetLookOffset_Process(lookOffset_Process));
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x001334C9 File Offset: 0x001316C9
		public void RequestCloseApp()
		{
			if (Phone.ActiveApp != null && this.closeApps != null)
			{
				this.closeApps();
			}
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x001334EB File Offset: 0x001316EB
		protected IEnumerator SetLookOffset_Process(float lookOffset)
		{
			float startOffset = base.transform.localPosition.z;
			float moveTime = 0.1f;
			for (float i = 0f; i < moveTime; i += Time.deltaTime)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y, Mathf.Lerp(startOffset, lookOffset, i / moveTime));
				yield return new WaitForEndOfFrame();
			}
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, base.transform.localPosition.y, lookOffset);
			this.rotationCoroutine = null;
			yield break;
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x00133504 File Offset: 0x00131704
		public bool MouseRaycast(out RaycastResult result)
		{
			PointerEventData pointerEventData = new PointerEventData(this.eventSystem);
			pointerEventData.position = Input.mousePosition;
			List<RaycastResult> list = new List<RaycastResult>();
			this.raycaster.Raycast(pointerEventData, list);
			if (list.Count > 0)
			{
				result = list[0];
			}
			else
			{
				result = default(RaycastResult);
			}
			return list.Count > 0;
		}

		// Token: 0x0400365D RID: 13917
		public static GameObject ActiveApp;

		// Token: 0x04003662 RID: 13922
		public PhoneCallData testData;

		// Token: 0x04003663 RID: 13923
		public CallerID testCalller;

		// Token: 0x04003664 RID: 13924
		[Header("References")]
		[SerializeField]
		protected GameObject phoneModel;

		// Token: 0x04003665 RID: 13925
		[SerializeField]
		protected Transform orientation_Vertical;

		// Token: 0x04003666 RID: 13926
		[SerializeField]
		protected Transform orientation_Horizontal;

		// Token: 0x04003667 RID: 13927
		[SerializeField]
		protected GraphicRaycaster raycaster;

		// Token: 0x04003668 RID: 13928
		[SerializeField]
		protected GameObject PhoneFlashlight;

		// Token: 0x04003669 RID: 13929
		[SerializeField]
		protected AudioSourceController FlashlightToggleSound;

		// Token: 0x0400366A RID: 13930
		[Header("Settings")]
		public float rotationTime = 0.1f;

		// Token: 0x0400366B RID: 13931
		public float LookOffsetMax = 0.45f;

		// Token: 0x0400366C RID: 13932
		public float LookOffsetMin = 0.29f;

		// Token: 0x0400366D RID: 13933
		public float OpenVerticalOffset = 0.1f;

		// Token: 0x0400366E RID: 13934
		public Action onPhoneOpened;

		// Token: 0x0400366F RID: 13935
		public Action onPhoneClosed;

		// Token: 0x04003670 RID: 13936
		public Action closeApps;

		// Token: 0x04003671 RID: 13937
		private EventSystem eventSystem;

		// Token: 0x04003672 RID: 13938
		private VisibilityAttribute flashlightVisibility;

		// Token: 0x04003673 RID: 13939
		private Coroutine rotationCoroutine;

		// Token: 0x04003674 RID: 13940
		private Coroutine lookOffsetCoroutine;
	}
}
