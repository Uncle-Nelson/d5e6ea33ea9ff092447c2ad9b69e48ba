using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A2F RID: 2607
	public class SleepCanvas : Singleton<SleepCanvas>
	{
		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600464C RID: 17996 RVA: 0x001270FB File Offset: 0x001252FB
		// (set) Token: 0x0600464D RID: 17997 RVA: 0x00127103 File Offset: 0x00125303
		public bool IsMenuOpen { get; protected set; }

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x0600464E RID: 17998 RVA: 0x0012710C File Offset: 0x0012530C
		// (set) Token: 0x0600464F RID: 17999 RVA: 0x00127114 File Offset: 0x00125314
		public string QueuedSleepMessage { get; protected set; } = string.Empty;

		// Token: 0x06004650 RID: 18000 RVA: 0x00127120 File Offset: 0x00125320
		protected override void Awake()
		{
			base.Awake();
			this.IncreaseButton.onClick.AddListener(new UnityAction(delegate()
			{
				this.ChangeSleepAmount(1);
			}));
			this.DecreaseButton.onClick.AddListener(new UnityAction(delegate()
			{
				this.ChangeSleepAmount(-1);
			}));
			this.SleepButton.onClick.AddListener(new UnityAction(this.SleepButtonPressed));
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 1);
			TimeManager.onSleepStart = (Action)Delegate.Combine(TimeManager.onSleepStart, new Action(this.SleepStart));
			this.TimeLabel.enabled = false;
			this.WakeLabel.enabled = false;
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x001271D1 File Offset: 0x001253D1
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (this.IsMenuOpen && action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.SetIsOpen(false);
			}
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x001271FC File Offset: 0x001253FC
		public void SetIsOpen(bool open)
		{
			this.IsMenuOpen = open;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			if (open)
			{
				this.Update();
				NetworkSingleton<TimeManager>.Instance.SetWakeTime(this.ClampWakeTime(700));
				this.UpdateTimeLabels();
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
				PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
				PlayerSingleton<PlayerMovement>.Instance.canMove = false;
				Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
				this.Canvas.enabled = true;
				this.Container.gameObject.SetActive(true);
			}
			else
			{
				Player.Local.CurrentBed = null;
				Player.Local.SetReadyToSleep(false);
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
				PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, true, false);
				PlayerSingleton<PlayerCamera>.Instance.LockMouse();
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
				PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			}
			this.MenuContainer.gameObject.SetActive(open);
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x00127320 File Offset: 0x00125520
		public void Update()
		{
			if (this.IsMenuOpen)
			{
				this.UpdateHourSetting();
				this.UpdateTimeLabels();
				this.UpdateSleepButton();
			}
			if (this.Canvas.enabled)
			{
				this.CurrentTimeLabel.text = TimeManager.Get12HourTime((float)NetworkSingleton<TimeManager>.Instance.CurrentTime, true);
			}
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x00127370 File Offset: 0x00125570
		public void AddPostSleepEvent(IPostSleepEvent postSleepEvent)
		{
			Console.Log("Adding post sleep event: " + postSleepEvent.GetType().Name, null);
			this.queuedPostSleepEvents.Add(postSleepEvent);
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x00127399 File Offset: 0x00125599
		private void UpdateHourSetting()
		{
			this.IncreaseButton.interactable = true;
			this.DecreaseButton.interactable = true;
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x001273B3 File Offset: 0x001255B3
		private void UpdateTimeLabels()
		{
			this.EndTimeLabel.text = TimeManager.Get12HourTime(700f, true);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x001273CB File Offset: 0x001255CB
		private void UpdateSleepButton()
		{
			if (Player.Local.IsReadyToSleep)
			{
				this.SleepButtonLabel.text = "Waiting for other players";
				return;
			}
			this.SleepButtonLabel.text = "Sleep";
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x001273FC File Offset: 0x001255FC
		private void ChangeSleepAmount(int change)
		{
			int num = TimeManager.AddMinutesTo24HourTime(700, change * 60);
			num = this.ClampWakeTime(num);
			NetworkSingleton<TimeManager>.Instance.SetWakeTime(num);
			this.UpdateHourSetting();
			this.UpdateTimeLabels();
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x00127438 File Offset: 0x00125638
		private int ClampWakeTime(int time)
		{
			int currentTime = NetworkSingleton<TimeManager>.Instance.CurrentTime;
			int time2 = TimeManager.AddMinutesTo24HourTime(currentTime, 60 - currentTime % 100);
			int startTime = TimeManager.AddMinutesTo24HourTime(time2, 240);
			int endTime = TimeManager.AddMinutesTo24HourTime(time2, 720);
			return this.ClampTime(time, startTime, endTime);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x00127480 File Offset: 0x00125680
		private int ClampTime(int time, int startTime, int endTime)
		{
			if (endTime > startTime)
			{
				if (time < startTime)
				{
					return startTime;
				}
				if (time > endTime)
				{
					return endTime;
				}
			}
			else if (time < startTime && time > endTime)
			{
				int max = TimeManager.AddMinutesTo24HourTime(endTime, 720);
				if (TimeManager.IsGivenTimeWithinRange(time, endTime, max))
				{
					return endTime;
				}
				return startTime;
			}
			return time;
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x001274C0 File Offset: 0x001256C0
		private void SleepButtonPressed()
		{
			Player.Local.SetReadyToSleep(!Player.Local.IsReadyToSleep);
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x001274DC File Offset: 0x001256DC
		private void SleepStart()
		{
			Player.Local.SetReadyToSleep(false);
			this.MenuContainer.gameObject.SetActive(false);
			this.IsMenuOpen = false;
			int num = 700;
			this.WakeLabel.text = "Waking up at " + TimeManager.Get12HourTime((float)num, true);
			base.StartCoroutine(this.<SleepStart>g__Sleep|41_0());
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x0012753C File Offset: 0x0012573C
		private void LerpBlackOverlay(float transparency, float lerpTime)
		{
			SleepCanvas.<>c__DisplayClass42_0 CS$<>8__locals1 = new SleepCanvas.<>c__DisplayClass42_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.transparency = transparency;
			CS$<>8__locals1.lerpTime = lerpTime;
			if (CS$<>8__locals1.transparency > 0f)
			{
				this.BlackOverlay.enabled = true;
			}
			base.StartCoroutine(CS$<>8__locals1.<LerpBlackOverlay>g__Routine|0());
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x0012758C File Offset: 0x0012578C
		public void QueueSleepMessage(string message, float displayTime = 3f)
		{
			Console.Log(string.Concat(new string[]
			{
				"Queueing sleep message: ",
				message,
				" for ",
				displayTime.ToString(),
				" seconds"
			}), null);
			this.QueuedSleepMessage = message;
			this.QueuedMessageDisplayTime = displayTime;
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x0012760E File Offset: 0x0012580E
		[CompilerGenerated]
		private IEnumerator <SleepStart>g__Sleep|41_0()
		{
			this.BlackOverlay.enabled = true;
			this.SleepMessageLabel.text = string.Empty;
			if (InstanceFinder.IsServer)
			{
				Console.Log("Resetting host sleep done", null);
				NetworkSingleton<TimeManager>.Instance.ResetHostSleepDone();
			}
			Singleton<HUD>.Instance.canvas.enabled = false;
			this.LerpBlackOverlay(1f, 0.5f);
			yield return new WaitForSecondsRealtime(0.5f);
			if (this.onSleepFullyFaded != null)
			{
				this.onSleepFullyFaded.Invoke();
			}
			yield return new WaitForSecondsRealtime(0.5f);
			NetworkSingleton<DailySummary>.Instance.Open();
			yield return new WaitUntil(() => !NetworkSingleton<DailySummary>.Instance.IsOpen);
			this.queuedPostSleepEvents = (from x in this.queuedPostSleepEvents
			orderby x.Order
			select x).ToList<IPostSleepEvent>();
			using (List<IPostSleepEvent>.Enumerator enumerator = this.queuedPostSleepEvents.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					SleepCanvas.<>c__DisplayClass41_0 CS$<>8__locals1 = new SleepCanvas.<>c__DisplayClass41_0();
					CS$<>8__locals1.pse = enumerator.Current;
					yield return new WaitForSecondsRealtime(0.5f);
					Console.Log("Running post sleep event: " + CS$<>8__locals1.pse.GetType().Name, null);
					CS$<>8__locals1.pse.StartEvent();
					yield return new WaitUntil(() => !CS$<>8__locals1.pse.IsRunning);
					CS$<>8__locals1 = null;
				}
			}
			List<IPostSleepEvent>.Enumerator enumerator = default(List<IPostSleepEvent>.Enumerator);
			this.queuedPostSleepEvents.Clear();
			if (InstanceFinder.IsServer)
			{
				Console.Log("Marking host sleep done", null);
				NetworkSingleton<TimeManager>.Instance.MarkHostSleepDone();
			}
			else
			{
				this.WaitingForHostLabel.enabled = true;
				yield return new WaitUntil(() => NetworkSingleton<TimeManager>.Instance.HostDailySummaryDone);
				this.WaitingForHostLabel.enabled = false;
			}
			NetworkSingleton<TimeManager>.Instance.FastForwardToWakeTime();
			this.TimeLabel.enabled = true;
			if (InstanceFinder.IsServer)
			{
				Singleton<SaveManager>.Instance.DelayedSave();
			}
			yield return new WaitForSecondsRealtime(1f);
			this.TimeLabel.enabled = false;
			if (this.onSleepEndFade != null)
			{
				this.onSleepEndFade.Invoke();
			}
			if (!string.IsNullOrEmpty(this.QueuedSleepMessage))
			{
				yield return new WaitForSecondsRealtime(0.5f);
				this.SleepMessageLabel.text = this.QueuedSleepMessage;
				this.QueuedSleepMessage = string.Empty;
				this.SleepMessageGroup.alpha = 0f;
				float lerpTime = 0.5f;
				for (float i = 0f; i < lerpTime; i += Time.deltaTime)
				{
					this.SleepMessageGroup.alpha = i / lerpTime;
					yield return new WaitForEndOfFrame();
				}
				this.SleepMessageGroup.alpha = 1f;
				yield return new WaitForSecondsRealtime(this.QueuedMessageDisplayTime);
				for (float i = 0f; i < lerpTime; i += Time.deltaTime)
				{
					this.SleepMessageGroup.alpha = 1f - i / lerpTime;
					yield return new WaitForEndOfFrame();
				}
				this.SleepMessageGroup.alpha = 0f;
				yield return new WaitForSecondsRealtime(0.5f);
			}
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, false, true);
			this.TimeLabel.enabled = false;
			this.WakeLabel.enabled = false;
			if (!NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				Singleton<HUD>.Instance.canvas.enabled = true;
			}
			yield return new WaitForSecondsRealtime(0.1f);
			if (!NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				this.SetIsOpen(false);
			}
			this.LerpBlackOverlay(0f, 0.5f);
			yield break;
			yield break;
		}

		// Token: 0x040033E0 RID: 13280
		public const int MaxSleepTime = 12;

		// Token: 0x040033E1 RID: 13281
		public const int MinSleepTime = 4;

		// Token: 0x040033E4 RID: 13284
		private float QueuedMessageDisplayTime;

		// Token: 0x040033E5 RID: 13285
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040033E6 RID: 13286
		public RectTransform Container;

		// Token: 0x040033E7 RID: 13287
		public RectTransform MenuContainer;

		// Token: 0x040033E8 RID: 13288
		public TextMeshProUGUI CurrentTimeLabel;

		// Token: 0x040033E9 RID: 13289
		public Button IncreaseButton;

		// Token: 0x040033EA RID: 13290
		public Button DecreaseButton;

		// Token: 0x040033EB RID: 13291
		public TextMeshProUGUI EndTimeLabel;

		// Token: 0x040033EC RID: 13292
		public Button SleepButton;

		// Token: 0x040033ED RID: 13293
		public TextMeshProUGUI SleepButtonLabel;

		// Token: 0x040033EE RID: 13294
		public Image BlackOverlay;

		// Token: 0x040033EF RID: 13295
		public TextMeshProUGUI SleepMessageLabel;

		// Token: 0x040033F0 RID: 13296
		public CanvasGroup SleepMessageGroup;

		// Token: 0x040033F1 RID: 13297
		public TextMeshProUGUI TimeLabel;

		// Token: 0x040033F2 RID: 13298
		public TextMeshProUGUI WakeLabel;

		// Token: 0x040033F3 RID: 13299
		public TextMeshProUGUI WaitingForHostLabel;

		// Token: 0x040033F4 RID: 13300
		public UnityEvent onSleepFullyFaded;

		// Token: 0x040033F5 RID: 13301
		public UnityEvent onSleepEndFade;

		// Token: 0x040033F6 RID: 13302
		private List<IPostSleepEvent> queuedPostSleepEvents = new List<IPostSleepEvent>();
	}
}
