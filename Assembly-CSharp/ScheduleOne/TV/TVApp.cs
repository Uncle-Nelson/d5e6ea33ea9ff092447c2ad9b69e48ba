using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x020002A2 RID: 674
	public class TVApp : MonoBehaviour
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0003EEE4 File Offset: 0x0003D0E4
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x0003EEEC File Offset: 0x0003D0EC
		public bool IsOpen { get; private set; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0003EEF5 File Offset: 0x0003D0F5
		public bool IsPaused
		{
			get
			{
				return this.PauseScreen != null && this.PauseScreen.IsPaused;
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0003EF12 File Offset: 0x0003D112
		protected virtual void Awake()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 3);
			this.CanvasGroup.alpha = 0f;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0003EF36 File Offset: 0x0003D136
		private void OnDestroy()
		{
			GameInput.DeregisterExitListener(new GameInput.ExitDelegate(this.Exit));
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0003EF4C File Offset: 0x0003D14C
		public virtual void Open()
		{
			this.IsOpen = true;
			this.Canvas.gameObject.SetActive(true);
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.ActiveMinPass));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.ActiveMinPass));
			this.Lerp(1f, 1f);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0003EFD0 File Offset: 0x0003D1D0
		public virtual void Close()
		{
			this.IsOpen = false;
			this.Canvas.gameObject.SetActive(false);
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.ActiveMinPass));
			if (this.PreviousScreen != null)
			{
				this.Lerp(0.67f, 0f);
			}
			else
			{
				this.Lerp(1.5f, 0f);
			}
			if (this.PreviousScreen != null)
			{
				this.PreviousScreen.Open();
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void Resume()
		{
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0003F065 File Offset: 0x0003D265
		private void Lerp(float endScale, float endAlpha)
		{
			if (this.lerpCoroutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.lerpCoroutine);
			}
			this.lerpCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.<Lerp>g__Lerp|23_0(endScale, endAlpha));
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void ActiveMinPass()
		{
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0003F098 File Offset: 0x0003D298
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (!this.CanClose && !this.Pauseable)
			{
				this.PreviousScreen.Open();
				return;
			}
			action.used = true;
			if (this.Pauseable && this.PauseScreen != null)
			{
				this.TryPause();
				return;
			}
			this.Close();
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0003F0FD File Offset: 0x0003D2FD
		protected virtual void TryPause()
		{
			this.PauseScreen.Pause();
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0003F120 File Offset: 0x0003D320
		[CompilerGenerated]
		private IEnumerator <Lerp>g__Lerp|23_0(float endScale, float endAlpha)
		{
			if (this.Canvas == null)
			{
				yield break;
			}
			this.Canvas.gameObject.SetActive(true);
			float startScale = this.Canvas.transform.localScale.x;
			float startAlpha = this.CanvasGroup.alpha;
			float lerpTime = Mathf.Abs(endScale - startScale) / 0.5f * 0.12f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				if (this.Canvas == null)
				{
					yield break;
				}
				this.Canvas.transform.localScale = Vector3.one * Mathf.Lerp(startScale, endScale, i / lerpTime);
				this.CanvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			if (this.Canvas != null)
			{
				this.Canvas.transform.localScale = Vector3.one * endScale;
				this.CanvasGroup.alpha = endAlpha;
				if (endAlpha == 0f)
				{
					this.Canvas.gameObject.SetActive(false);
				}
			}
			this.lerpCoroutine = null;
			yield break;
		}

		// Token: 0x04000EC3 RID: 3779
		public const float SCALE_MIN = 0.67f;

		// Token: 0x04000EC4 RID: 3780
		public const float SCALE_MAX = 1.5f;

		// Token: 0x04000EC5 RID: 3781
		public const float LERP_TIME = 0.12f;

		// Token: 0x04000EC7 RID: 3783
		[Header("Settings")]
		public bool CanClose = true;

		// Token: 0x04000EC8 RID: 3784
		public string AppName;

		// Token: 0x04000EC9 RID: 3785
		public Sprite Icon;

		// Token: 0x04000ECA RID: 3786
		public bool Pauseable = true;

		// Token: 0x04000ECB RID: 3787
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04000ECC RID: 3788
		[HideInInspector]
		public TVApp PreviousScreen;

		// Token: 0x04000ECD RID: 3789
		public CanvasGroup CanvasGroup;

		// Token: 0x04000ECE RID: 3790
		public TVPauseScreen PauseScreen;

		// Token: 0x04000ECF RID: 3791
		private Coroutine lerpCoroutine;
	}
}
