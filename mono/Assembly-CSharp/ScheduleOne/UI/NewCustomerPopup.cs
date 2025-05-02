using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A09 RID: 2569
	public class NewCustomerPopup : Singleton<NewCustomerPopup>
	{
		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x00121DF2 File Offset: 0x0011FFF2
		// (set) Token: 0x06004538 RID: 17720 RVA: 0x00121DFA File Offset: 0x0011FFFA
		public bool IsPlaying { get; protected set; }

		// Token: 0x06004539 RID: 17721 RVA: 0x00121E03 File Offset: 0x00120003
		protected override void Awake()
		{
			base.Awake();
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			this.DisableEntries();
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00121E30 File Offset: 0x00120030
		public void PlayPopup(Customer customer)
		{
			this.IsPlaying = true;
			RectTransform rectTransform = null;
			int num = 0;
			for (int i = 0; i < this.Entries.Length; i++)
			{
				num++;
				if (!this.Entries[i].gameObject.activeSelf)
				{
					rectTransform = this.Entries[i];
					break;
				}
			}
			if (rectTransform == null)
			{
				return;
			}
			rectTransform.Find("Mask/Icon").GetComponent<Image>().sprite = customer.NPC.MugshotSprite;
			rectTransform.Find("Name").GetComponent<TextMeshProUGUI>().text = customer.NPC.FirstName + "\n" + customer.NPC.LastName;
			rectTransform.gameObject.SetActive(true);
			if (num == 1)
			{
				this.Title.text = "New Customer Unlocked!";
			}
			else
			{
				this.Title.text = "New Customers Unlocked!";
			}
			if (this.routine != null)
			{
				base.StopCoroutine(this.routine);
				this.Anim.Stop();
				this.routine = null;
			}
			this.routine = base.StartCoroutine(this.<PlayPopup>g__Routine|13_0());
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00121F48 File Offset: 0x00120148
		private void DisableEntries()
		{
			for (int i = 0; i < this.Entries.Length; i++)
			{
				this.Entries[i].gameObject.SetActive(false);
			}
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00121F83 File Offset: 0x00120183
		[CompilerGenerated]
		private IEnumerator <PlayPopup>g__Routine|13_0()
		{
			yield return new WaitUntil(() => !Singleton<DealCompletionPopup>.Instance.IsPlaying);
			this.Group.alpha = 0.01f;
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			this.SoundEffect.Play();
			this.Anim.Play();
			yield return new WaitForSeconds(0.1f);
			yield return new WaitUntil(() => this.Group.alpha == 0f);
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			this.routine = null;
			this.IsPlaying = false;
			this.DisableEntries();
			yield break;
		}

		// Token: 0x040032BF RID: 12991
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040032C0 RID: 12992
		public RectTransform Container;

		// Token: 0x040032C1 RID: 12993
		public CanvasGroup Group;

		// Token: 0x040032C2 RID: 12994
		public Animation Anim;

		// Token: 0x040032C3 RID: 12995
		public TextMeshProUGUI Title;

		// Token: 0x040032C4 RID: 12996
		public RectTransform[] Entries;

		// Token: 0x040032C5 RID: 12997
		public AudioSourceController SoundEffect;

		// Token: 0x040032C6 RID: 12998
		private Coroutine routine;
	}
}
