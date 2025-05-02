using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A0D RID: 2573
	public class NotificationsManager : Singleton<NotificationsManager>
	{
		// Token: 0x06004554 RID: 17748 RVA: 0x000045B1 File Offset: 0x000027B1
		private void Update()
		{
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x0012261C File Offset: 0x0012081C
		public void SendNotification(string title, string subtitle, Sprite icon, float duration = 5f, bool playSound = true)
		{
			NotificationsManager.<>c__DisplayClass7_0 CS$<>8__locals1 = new NotificationsManager.<>c__DisplayClass7_0();
			CS$<>8__locals1.duration = duration;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.newEntry = Object.Instantiate<GameObject>(this.NotificationPrefab, this.EntryContainer).GetComponent<RectTransform>();
			CS$<>8__locals1.newEntry.SetAsLastSibling();
			CS$<>8__locals1.container = CS$<>8__locals1.newEntry.Find("Container").GetComponent<RectTransform>();
			CS$<>8__locals1.container.Find("Title").GetComponent<TextMeshProUGUI>().text = title;
			CS$<>8__locals1.container.Find("Subtitle").GetComponent<TextMeshProUGUI>().text = subtitle;
			CS$<>8__locals1.container.Find("AppIcon/Mask/Image").GetComponent<Image>().sprite = icon;
			CS$<>8__locals1.startX = -200f;
			CS$<>8__locals1.endX = 0f;
			CS$<>8__locals1.lerpTime = 0.15f;
			CS$<>8__locals1.container.anchoredPosition = new Vector2(CS$<>8__locals1.startX, CS$<>8__locals1.container.anchoredPosition.y);
			if (playSound)
			{
				this.Sound.Play();
			}
			if (this.entries.Count >= 6)
			{
				RectTransform rectTransform = this.entries[0];
				if (rectTransform != null)
				{
					base.StopCoroutine(this.coroutines[rectTransform]);
					this.coroutines.Remove(rectTransform);
					Object.Destroy(rectTransform.gameObject);
				}
				this.entries.RemoveAt(0);
			}
			this.coroutines.Add(CS$<>8__locals1.container, base.StartCoroutine(CS$<>8__locals1.<SendNotification>g__Routine|0()));
			this.entries.Add(CS$<>8__locals1.container);
		}

		// Token: 0x040032DB RID: 13019
		public const int MAX_NOTIFICATIONS = 6;

		// Token: 0x040032DC RID: 13020
		[Header("References")]
		public RectTransform EntryContainer;

		// Token: 0x040032DD RID: 13021
		public AudioSourceController Sound;

		// Token: 0x040032DE RID: 13022
		[Header("Prefab")]
		public GameObject NotificationPrefab;

		// Token: 0x040032DF RID: 13023
		private Dictionary<RectTransform, Coroutine> coroutines = new Dictionary<RectTransform, Coroutine>();

		// Token: 0x040032E0 RID: 13024
		private List<RectTransform> entries = new List<RectTransform>();
	}
}
