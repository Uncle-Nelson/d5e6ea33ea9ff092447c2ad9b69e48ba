using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Levelling;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A43 RID: 2627
	public class RankUpCanvas : MonoBehaviour, IPostSleepEvent
	{
		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x00128CC4 File Offset: 0x00126EC4
		// (set) Token: 0x060046DC RID: 18140 RVA: 0x00128CCC File Offset: 0x00126ECC
		public bool IsRunning { get; private set; }

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060046DD RID: 18141 RVA: 0x00128CD5 File Offset: 0x00126ED5
		// (set) Token: 0x060046DE RID: 18142 RVA: 0x00128CDD File Offset: 0x00126EDD
		public int Order { get; private set; }

		// Token: 0x060046DF RID: 18143 RVA: 0x00128CE8 File Offset: 0x00126EE8
		public void Start()
		{
			this.Canvas.enabled = false;
			LevelManager instance = NetworkSingleton<LevelManager>.Instance;
			instance.onRankUp = (Action<FullRank, FullRank>)Delegate.Combine(instance.onRankUp, new Action<FullRank, FullRank>(this.RankUp));
			NetworkSingleton<TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.QueuePostSleepEvent));
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x00128D42 File Offset: 0x00126F42
		private void QueuePostSleepEvent()
		{
			if (!GameManager.IS_TUTORIAL)
			{
				Singleton<SleepCanvas>.Instance.AddPostSleepEvent(this);
			}
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x00128D58 File Offset: 0x00126F58
		public void StartEvent()
		{
			RankUpCanvas.<>c__DisplayClass25_0 CS$<>8__locals1 = new RankUpCanvas.<>c__DisplayClass25_0();
			CS$<>8__locals1.<>4__this = this;
			this.IsRunning = true;
			this.OpenCloseAnim.Play("Rank up open");
			int xpGained = NetworkSingleton<DailySummary>.Instance.xpGained;
			int num = NetworkSingleton<LevelManager>.Instance.TotalXP - xpGained;
			FullRank fullRank = NetworkSingleton<LevelManager>.Instance.GetFullRank(num);
			int num2 = num - NetworkSingleton<LevelManager>.Instance.GetTotalXPForRank(fullRank);
			int i = xpGained;
			CS$<>8__locals1.progressDisplays = new List<Tuple<FullRank, int, int>>();
			FullRank fullRank2 = fullRank;
			while (i > 0)
			{
				int num3 = Mathf.Min(i, NetworkSingleton<LevelManager>.Instance.GetXPForTier(fullRank2.Rank));
				if (fullRank2 == fullRank)
				{
					num3 = Mathf.Min(num3, NetworkSingleton<LevelManager>.Instance.GetXPForTier(fullRank2.Rank) - num2);
					CS$<>8__locals1.progressDisplays.Add(new Tuple<FullRank, int, int>(fullRank2, num2, num3 + num2));
				}
				else
				{
					CS$<>8__locals1.progressDisplays.Add(new Tuple<FullRank, int, int>(fullRank2, 0, num3));
				}
				i -= num3;
				fullRank2 = fullRank2.NextRank();
			}
			this.ProgressSlider.value = (float)num2 / (float)NetworkSingleton<LevelManager>.Instance.GetXPForTier(fullRank.Rank);
			this.ProgressLabel.text = num2.ToString() + " / " + NetworkSingleton<LevelManager>.Instance.GetXPForTier(fullRank.Rank).ToString() + " XP";
			this.OldRankLabel.text = FullRank.GetString(fullRank);
			this.coroutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<StartEvent>g__Routine|0());
			this.queuedRankUps.Clear();
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x00128EE8 File Offset: 0x001270E8
		public void EndEvent()
		{
			if (!this.IsRunning)
			{
				return;
			}
			this.IsRunning = false;
			if (this.coroutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.coroutine);
				this.coroutine = null;
			}
			this.OpenCloseAnim.Play();
			this.OpenCloseAnim.Play("Rank up close");
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00128F41 File Offset: 0x00127141
		public void RankUp(FullRank oldRank, FullRank newRank)
		{
			this.queuedRankUps.Add(new Tuple<FullRank, FullRank>(oldRank, newRank));
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00128F58 File Offset: 0x00127158
		private void PlayRankupAnimation(FullRank oldRank, FullRank newRank, bool playSound)
		{
			this.Canvas.enabled = true;
			this.OldRankLabel.text = FullRank.GetString(oldRank);
			this.NewRankLabel.text = FullRank.GetString(newRank);
			List<Unlockable> list = new List<Unlockable>();
			if (NetworkSingleton<LevelManager>.Instance.Unlockables.ContainsKey(newRank))
			{
				list = NetworkSingleton<LevelManager>.Instance.Unlockables[newRank];
			}
			this.UnlockedItemsContainer.gameObject.SetActive(list.Count > 0);
			for (int i = 0; i < this.UnlockedItems.Length; i++)
			{
				if (i < list.Count)
				{
					this.UnlockedItems[i].Find("Icon").GetComponent<Image>().sprite = list[i].Icon;
					this.UnlockedItems[i].GetComponentInChildren<TextMeshProUGUI>().text = list[i].Title;
					this.UnlockedItems[i].gameObject.SetActive(true);
				}
				else
				{
					this.UnlockedItems[i].gameObject.SetActive(false);
				}
			}
			this.ExtraUnlocksLabel.text = ((list.Count > this.UnlockedItems.Length) ? ("+" + (list.Count - this.UnlockedItems.Length).ToString() + " more") : "");
			this.RankUpAnim.Play();
			if (playSound)
			{
				this.SoundEffect.Play();
			}
		}

		// Token: 0x04003440 RID: 13376
		public Animation OpenCloseAnim;

		// Token: 0x04003441 RID: 13377
		public Animation RankUpAnim;

		// Token: 0x04003442 RID: 13378
		public TextMeshProUGUI OldRankLabel;

		// Token: 0x04003443 RID: 13379
		public TextMeshProUGUI NewRankLabel;

		// Token: 0x04003444 RID: 13380
		public Canvas Canvas;

		// Token: 0x04003445 RID: 13381
		public GameObject UnlockedItemsContainer;

		// Token: 0x04003446 RID: 13382
		public RectTransform[] UnlockedItems;

		// Token: 0x04003447 RID: 13383
		public TextMeshProUGUI ExtraUnlocksLabel;

		// Token: 0x04003448 RID: 13384
		public AudioSourceController SoundEffect;

		// Token: 0x04003449 RID: 13385
		public Slider ProgressSlider;

		// Token: 0x0400344A RID: 13386
		public TextMeshProUGUI ProgressLabel;

		// Token: 0x0400344B RID: 13387
		public AudioSourceController BlipSound;

		// Token: 0x0400344C RID: 13388
		public AudioSourceController ClickSound;

		// Token: 0x0400344D RID: 13389
		private Coroutine coroutine;

		// Token: 0x0400344E RID: 13390
		private List<Tuple<FullRank, FullRank>> queuedRankUps = new List<Tuple<FullRank, FullRank>>();
	}
}
