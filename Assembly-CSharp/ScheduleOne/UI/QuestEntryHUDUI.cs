using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Quests;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000A3C RID: 2620
	public class QuestEntryHUDUI : MonoBehaviour
	{
		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x001284C6 File Offset: 0x001266C6
		// (set) Token: 0x060046A1 RID: 18081 RVA: 0x001284CE File Offset: 0x001266CE
		public QuestEntry QuestEntry { get; private set; }

		// Token: 0x060046A2 RID: 18082 RVA: 0x001284D8 File Offset: 0x001266D8
		public void Initialize(QuestEntry entry)
		{
			this.QuestEntry = entry;
			this.MainLabel.text = entry.Title;
			QuestHUDUI hudUI = this.QuestEntry.ParentQuest.hudUI;
			hudUI.onUpdateUI = (Action)Delegate.Combine(hudUI.onUpdateUI, new Action(this.UpdateUI));
			if (this.QuestEntry.State == EQuestState.Active)
			{
				this.FadeIn();
			}
			else
			{
				this.QuestEntry.onStart.AddListener(new UnityAction(this.FadeIn));
			}
			this.QuestEntry.onEnd.AddListener(new UnityAction(this.EntryEnded));
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x00128580 File Offset: 0x00126780
		public void Destroy()
		{
			QuestHUDUI hudUI = this.QuestEntry.ParentQuest.hudUI;
			hudUI.onUpdateUI = (Action)Delegate.Remove(hudUI.onUpdateUI, new Action(this.UpdateUI));
			this.QuestEntry.onStart.RemoveListener(new UnityAction(this.FadeIn));
			Object.Destroy(base.gameObject);
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x001285E8 File Offset: 0x001267E8
		public virtual void UpdateUI()
		{
			if (this.QuestEntry.State != EQuestState.Active)
			{
				if (!this.Animation.isPlaying)
				{
					base.gameObject.SetActive(false);
				}
				return;
			}
			if (this.QuestEntry.ParentQuest.ActiveEntryCount > 1)
			{
				this.MainLabel.text = "• " + this.QuestEntry.Title;
			}
			else
			{
				this.MainLabel.text = this.QuestEntry.Title;
			}
			base.gameObject.SetActive(true);
			this.MainLabel.ForceMeshUpdate(false, false);
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x00128681 File Offset: 0x00126881
		private void FadeIn()
		{
			this.QuestEntry.UpdateEntryUI();
			base.transform.SetAsLastSibling();
			this.Animation.Play("Quest entry enter");
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x001286AA File Offset: 0x001268AA
		private void EntryEnded()
		{
			if (this.QuestEntry.State == EQuestState.Completed)
			{
				this.Complete();
				return;
			}
			this.FadeOut();
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x001286C7 File Offset: 0x001268C7
		private void FadeOut()
		{
			this.Animation.Play("Quest entry exit");
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<FadeOut>g__Routine|11_0());
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x001286EB File Offset: 0x001268EB
		private void Complete()
		{
			if (!base.gameObject.activeSelf)
			{
				base.gameObject.SetActive(false);
				return;
			}
			this.Animation.Play("Quest entry complete");
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<Complete>g__Routine|12_0());
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x00128729 File Offset: 0x00126929
		[CompilerGenerated]
		private IEnumerator <FadeOut>g__Routine|11_0()
		{
			yield return new WaitForSeconds(this.Animation.GetClip("Quest entry exit").length);
			base.gameObject.SetActive(false);
			this.QuestEntry.UpdateEntryUI();
			yield break;
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x00128738 File Offset: 0x00126938
		[CompilerGenerated]
		private IEnumerator <Complete>g__Routine|12_0()
		{
			yield return new WaitForSeconds(3f);
			this.FadeOut();
			yield break;
		}

		// Token: 0x04003425 RID: 13349
		[Header("References")]
		public TextMeshProUGUI MainLabel;

		// Token: 0x04003426 RID: 13350
		public Animation Animation;
	}
}
