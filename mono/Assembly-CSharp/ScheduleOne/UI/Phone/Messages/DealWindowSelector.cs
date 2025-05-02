using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.Messaging;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000ABE RID: 2750
	public class DealWindowSelector : MonoBehaviour
	{
		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06004A04 RID: 18948 RVA: 0x00136466 File Offset: 0x00134666
		// (set) Token: 0x06004A05 RID: 18949 RVA: 0x0013646E File Offset: 0x0013466E
		public bool IsOpen { get; private set; }

		// Token: 0x06004A06 RID: 18950 RVA: 0x00136478 File Offset: 0x00134678
		private void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
			this.buttons = new WindowSelectorButton[]
			{
				this.MorningButton,
				this.AfternoonButton,
				this.NightButton,
				this.LateNightButton
			};
			WindowSelectorButton[] array = this.buttons;
			for (int i = 0; i < array.Length; i++)
			{
				WindowSelectorButton button = array[i];
				button.OnSelected.AddListener(new UnityAction(delegate()
				{
					this.ButtonClicked(button.WindowType);
				}));
			}
			this.SetIsOpen(false);
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00136515 File Offset: 0x00134715
		public void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			action.used = true;
			this.SetIsOpen(false);
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00136537 File Offset: 0x00134737
		public void SetIsOpen(bool open)
		{
			this.SetIsOpen(open, null, null);
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x00136544 File Offset: 0x00134744
		public void SetIsOpen(bool open, MSGConversation conversation, Action<EDealWindow> callback = null)
		{
			this.IsOpen = open;
			if (open)
			{
				this.UpdateTime();
				this.UpdateWindowValidity();
				conversation.onMessageRendered = (Action)Delegate.Combine(conversation.onMessageRendered, new Action(this.Close));
			}
			else
			{
				callback = null;
				if (conversation != null)
				{
					conversation.onMessageRendered = (Action)Delegate.Remove(conversation.onMessageRendered, new Action(this.Close));
				}
				WindowSelectorButton[] array = this.buttons;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].SetHoverIndicator(false);
				}
			}
			if (open && NetworkSingleton<GameManager>.Instance.IsTutorial && !this.hintShown)
			{
				this.hintShown = true;
				Singleton<HintDisplay>.Instance.ShowHint_20s("You can complete deals any time within the window you choose. For now, choose the morning window.");
			}
			this.Container.gameObject.SetActive(open);
			this.callback = callback;
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00136616 File Offset: 0x00134816
		public void Update()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.UpdateTime();
			this.UpdateWindowValidity();
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x00136630 File Offset: 0x00134830
		private void UpdateTime()
		{
			this.CurrentTimeLabel.text = TimeManager.Get12HourTime((float)NetworkSingleton<TimeManager>.Instance.CurrentTime, true);
			float t = (float)NetworkSingleton<TimeManager>.Instance.DailyMinTotal / 1440f;
			this.CurrentTimeArm.localRotation = Quaternion.Euler(0f, 0f, Mathf.Lerp(0f, -360f, t));
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x00136698 File Offset: 0x00134898
		private void UpdateWindowValidity()
		{
			if (NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				this.MorningButton.SetInteractable(true);
				this.AfternoonButton.SetInteractable(false);
				this.NightButton.SetInteractable(false);
				this.LateNightButton.SetInteractable(false);
				return;
			}
			int dailyMinTotal = NetworkSingleton<TimeManager>.Instance.DailyMinTotal;
			foreach (WindowSelectorButton windowSelectorButton in this.buttons)
			{
				int num = TimeManager.GetMinSumFrom24HourTime(DealWindowInfo.GetWindowInfo(windowSelectorButton.WindowType).EndTime);
				if (dailyMinTotal > num)
				{
					num += 1440;
				}
				windowSelectorButton.SetInteractable(num - dailyMinTotal > 120);
			}
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x00136733 File Offset: 0x00134933
		private void Close()
		{
			this.SetIsOpen(false);
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x0013673C File Offset: 0x0013493C
		private void ButtonClicked(EDealWindow window)
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (this.OnSelected != null)
			{
				this.OnSelected.Invoke(window);
			}
			if (this.callback != null)
			{
				this.callback(window);
			}
			this.SetIsOpen(false);
		}

		// Token: 0x0400371A RID: 14106
		public const float TIME_ARM_ROTATION_0000 = 0f;

		// Token: 0x0400371B RID: 14107
		public const float TIME_ARM_ROTATION_2400 = -360f;

		// Token: 0x0400371C RID: 14108
		public const int WINDOW_CUTOFF_MINS = 120;

		// Token: 0x0400371D RID: 14109
		public UnityEvent<EDealWindow> OnSelected;

		// Token: 0x0400371F RID: 14111
		[Header("References")]
		public GameObject Container;

		// Token: 0x04003720 RID: 14112
		public WindowSelectorButton MorningButton;

		// Token: 0x04003721 RID: 14113
		public WindowSelectorButton AfternoonButton;

		// Token: 0x04003722 RID: 14114
		public WindowSelectorButton NightButton;

		// Token: 0x04003723 RID: 14115
		public WindowSelectorButton LateNightButton;

		// Token: 0x04003724 RID: 14116
		public RectTransform CurrentTimeArm;

		// Token: 0x04003725 RID: 14117
		public Text CurrentTimeLabel;

		// Token: 0x04003726 RID: 14118
		private Action<EDealWindow> callback;

		// Token: 0x04003727 RID: 14119
		private WindowSelectorButton[] buttons;

		// Token: 0x04003728 RID: 14120
		private bool hintShown;
	}
}
