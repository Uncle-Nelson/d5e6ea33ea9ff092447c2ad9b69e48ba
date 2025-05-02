using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.TV
{
	// Token: 0x020002A4 RID: 676
	public class TVHomeScreen : TVApp
	{
		// Token: 0x06000E22 RID: 3618 RVA: 0x0003F318 File Offset: 0x0003D518
		protected override void Awake()
		{
			base.Awake();
			TVApp[] apps = this.Apps;
			for (int i = 0; i < apps.Length; i++)
			{
				TVApp app = apps[i];
				app.PreviousScreen = this;
				app.CanvasGroup.alpha = 0f;
				GameObject gameObject = Object.Instantiate<GameObject>(this.AppButtonPrefab, this.AppButtonContainer);
				gameObject.transform.Find("Icon").GetComponent<Image>().sprite = app.Icon;
				gameObject.transform.Find("Name").GetComponent<TextMeshProUGUI>().text = app.AppName;
				gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
				{
					this.AppSelected(app);
				}));
				app.Close();
			}
			this.Interface.onPlayerAdded.AddListener(new UnityAction<Player>(this.PlayerChange));
			this.Interface.onPlayerRemoved.AddListener(new UnityAction<Player>(this.PlayerChange));
			this.Close();
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0003F43C File Offset: 0x0003D63C
		public override void Open()
		{
			base.Open();
			this.UpdateTimeLabel();
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0003F44A File Offset: 0x0003D64A
		public override void Close()
		{
			base.Close();
			if (this.skipExit)
			{
				this.skipExit = false;
				return;
			}
			this.Interface.Close();
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0003F46D File Offset: 0x0003D66D
		protected override void ActiveMinPass()
		{
			base.ActiveMinPass();
			this.UpdateTimeLabel();
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0003F47B File Offset: 0x0003D67B
		private void UpdateTimeLabel()
		{
			this.TimeLabel.text = TimeManager.Get12HourTime((float)NetworkSingleton<TimeManager>.Instance.CurrentTime, true);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0003F499 File Offset: 0x0003D699
		private void AppSelected(TVApp app)
		{
			this.skipExit = true;
			this.Close();
			app.Open();
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0003F4B0 File Offset: 0x0003D6B0
		private void PlayerChange(Player player)
		{
			for (int i = 0; i < this.PlayerDisplays.Length; i++)
			{
				if (this.Interface.Players.Count > i)
				{
					this.PlayerDisplays[i].Find("Name").GetComponent<TextMeshProUGUI>().text = this.Interface.Players[i].PlayerName;
					this.PlayerDisplays[i].gameObject.SetActive(true);
				}
				else
				{
					this.PlayerDisplays[i].gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x04000ED9 RID: 3801
		[Header("References")]
		public TVInterface Interface;

		// Token: 0x04000EDA RID: 3802
		public TVApp[] Apps;

		// Token: 0x04000EDB RID: 3803
		public RectTransform AppButtonContainer;

		// Token: 0x04000EDC RID: 3804
		public RectTransform[] PlayerDisplays;

		// Token: 0x04000EDD RID: 3805
		public TextMeshProUGUI TimeLabel;

		// Token: 0x04000EDE RID: 3806
		[Header("Prefabs")]
		public GameObject AppButtonPrefab;

		// Token: 0x04000EDF RID: 3807
		private bool skipExit;
	}
}
