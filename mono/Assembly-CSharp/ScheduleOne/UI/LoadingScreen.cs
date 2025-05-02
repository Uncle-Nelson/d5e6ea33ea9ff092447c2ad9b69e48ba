using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Networking;
using ScheduleOne.Persistence;
using ScheduleOne.ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A02 RID: 2562
	public class LoadingScreen : PersistentSingleton<LoadingScreen>
	{
		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06004512 RID: 17682 RVA: 0x00121550 File Offset: 0x0011F750
		// (set) Token: 0x06004513 RID: 17683 RVA: 0x00121558 File Offset: 0x0011F758
		public bool IsOpen { get; protected set; }

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06004514 RID: 17684 RVA: 0x00121561 File Offset: 0x0011F761
		public Sprite[] ContextualBackgroundImages
		{
			get
			{
				if (!this.isLoadingTutorial)
				{
					return this.BackgroundImages;
				}
				return this.TutorialBackgroundImages;
			}
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00121578 File Offset: 0x0011F778
		protected override void Awake()
		{
			base.Awake();
			if (Singleton<LoadingScreen>.Instance == null || Singleton<LoadingScreen>.Instance != this)
			{
				return;
			}
			this.loadingMessages = this.LoadingMessagesDatabase.Strings;
			this.currentBackgroundImageIndex = Random.Range(0, this.ContextualBackgroundImages.Length);
			for (int i = 0; i < this.ContextualBackgroundImages.Length; i++)
			{
				int num = Random.Range(0, this.ContextualBackgroundImages.Length);
				Sprite sprite = this.ContextualBackgroundImages[i];
				this.ContextualBackgroundImages[i] = this.ContextualBackgroundImages[num];
				this.ContextualBackgroundImages[num] = sprite;
			}
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.Group.alpha = 0f;
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00121632 File Offset: 0x0011F832
		protected void Update()
		{
			if (this.IsOpen)
			{
				this.LoadStatusLabel.text = Singleton<LoadManager>.Instance.GetLoadStatusText();
			}
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00121654 File Offset: 0x0011F854
		public void Open(bool loadingTutorial = false)
		{
			if (this.IsOpen)
			{
				return;
			}
			this.isLoadingTutorial = loadingTutorial;
			this.TutorialContainer.gameObject.SetActive(loadingTutorial);
			if (loadingTutorial && Singleton<Lobby>.Instance.IsInLobby && Singleton<Lobby>.Instance.PlayerCount > 1)
			{
				this.CoopTutorialHint.gameObject.SetActive(true);
			}
			else
			{
				this.CoopTutorialHint.gameObject.SetActive(false);
			}
			this.LoadingMessageLabel.text = this.loadingMessages[Random.Range(0, this.loadingMessages.Length)];
			this.IsOpen = true;
			Singleton<MusicPlayer>.Instance.SetTrackEnabled("Loading Screen", true);
			this.Fade(1f);
			this.AnimateBackground();
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x0012170A File Offset: 0x0011F90A
		public void Close()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.IsOpen = false;
			Singleton<MusicPlayer>.Instance.SetTrackEnabled("Loading Screen", false);
			Singleton<MusicPlayer>.Instance.StopTrack("Loading Screen");
			this.Fade(0f);
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00121746 File Offset: 0x0011F946
		private void AnimateBackground()
		{
			if (this.animateBackgroundRoutine != null)
			{
				base.StopCoroutine(this.animateBackgroundRoutine);
			}
			if (this.scaleBackgroundRoutine != null)
			{
				base.StopCoroutine(this.scaleBackgroundRoutine);
			}
			this.animateBackgroundRoutine = base.StartCoroutine(this.<AnimateBackground>g__Routine|30_0());
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00121784 File Offset: 0x0011F984
		private void Fade(float endAlpha)
		{
			LoadingScreen.<>c__DisplayClass31_0 CS$<>8__locals1 = new LoadingScreen.<>c__DisplayClass31_0();
			CS$<>8__locals1.endAlpha = endAlpha;
			CS$<>8__locals1.<>4__this = this;
			if (this.fadeRoutine != null)
			{
				base.StopCoroutine(this.fadeRoutine);
			}
			this.fadeRoutine = base.StartCoroutine(CS$<>8__locals1.<Fade>g__Routine|0());
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x001217D3 File Offset: 0x0011F9D3
		[CompilerGenerated]
		private IEnumerator <AnimateBackground>g__Routine|30_0()
		{
			LoadingScreen.<>c__DisplayClass30_0 CS$<>8__locals1 = new LoadingScreen.<>c__DisplayClass30_0();
			this.currentBackgroundImageIndex++;
			this.BackgroundImage1.color = new Color(1f, 1f, 1f, 0f);
			this.BackgroundImage2.color = new Color(1f, 1f, 1f, 0f);
			Image prevImage = null;
			CS$<>8__locals1.nextImage = this.BackgroundImage1;
			while (this.IsOpen || this.Group.alpha > 0f)
			{
				this.currentBackgroundImageIndex %= this.ContextualBackgroundImages.Length;
				CS$<>8__locals1.nextImage.sprite = this.ContextualBackgroundImages[this.currentBackgroundImageIndex];
				this.scaleBackgroundRoutine = base.StartCoroutine(CS$<>8__locals1.<AnimateBackground>g__ScaleRoutine|1(CS$<>8__locals1.nextImage.transform, 10f));
				for (float i = 0f; i < 1f; i += Time.deltaTime)
				{
					if (prevImage != null)
					{
						prevImage.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, i / 1f));
					}
					CS$<>8__locals1.nextImage.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, i / 1f));
					yield return new WaitForEndOfFrame();
					if (prevImage != null)
					{
						prevImage.color = new Color(1f, 1f, 1f, 0f);
					}
					CS$<>8__locals1.nextImage.color = new Color(1f, 1f, 1f, 1f);
				}
				yield return new WaitForSeconds(8f);
				prevImage = CS$<>8__locals1.nextImage;
				CS$<>8__locals1.nextImage = ((CS$<>8__locals1.nextImage == this.BackgroundImage1) ? this.BackgroundImage2 : this.BackgroundImage1);
				this.currentBackgroundImageIndex++;
			}
			yield break;
		}

		// Token: 0x0400328A RID: 12938
		public const float FADE_TIME = 0.25f;

		// Token: 0x0400328B RID: 12939
		public const float BACKGROUND_IMAGE_TIME = 8f;

		// Token: 0x0400328C RID: 12940
		public const float BACKGROUND_IMAGE_FADE_TIME = 1f;

		// Token: 0x0400328E RID: 12942
		public StringDatabase LoadingMessagesDatabase;

		// Token: 0x0400328F RID: 12943
		public Sprite[] BackgroundImages;

		// Token: 0x04003290 RID: 12944
		public Sprite[] TutorialBackgroundImages;

		// Token: 0x04003291 RID: 12945
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003292 RID: 12946
		public CanvasGroup Group;

		// Token: 0x04003293 RID: 12947
		public TextMeshProUGUI LoadStatusLabel;

		// Token: 0x04003294 RID: 12948
		public TextMeshProUGUI LoadingMessageLabel;

		// Token: 0x04003295 RID: 12949
		public Image BackgroundImage1;

		// Token: 0x04003296 RID: 12950
		public Image BackgroundImage2;

		// Token: 0x04003297 RID: 12951
		public RectTransform TutorialContainer;

		// Token: 0x04003298 RID: 12952
		public RectTransform CoopTutorialHint;

		// Token: 0x04003299 RID: 12953
		private string[] loadingMessages;

		// Token: 0x0400329A RID: 12954
		private int currentBackgroundImageIndex;

		// Token: 0x0400329B RID: 12955
		private Coroutine fadeRoutine;

		// Token: 0x0400329C RID: 12956
		private Coroutine animateBackgroundRoutine;

		// Token: 0x0400329D RID: 12957
		private Coroutine scaleBackgroundRoutine;

		// Token: 0x0400329E RID: 12958
		private bool isLoadingTutorial;
	}
}
