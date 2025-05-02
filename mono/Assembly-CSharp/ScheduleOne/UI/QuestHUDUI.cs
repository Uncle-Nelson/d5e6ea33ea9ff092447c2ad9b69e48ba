using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Quests;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A3F RID: 2623
	public class QuestHUDUI : MonoBehaviour
	{
		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x0012883F File Offset: 0x00126A3F
		// (set) Token: 0x060046B9 RID: 18105 RVA: 0x00128847 File Offset: 0x00126A47
		public Quest Quest { get; private set; }

		// Token: 0x060046BA RID: 18106 RVA: 0x00128850 File Offset: 0x00126A50
		public void Initialize(Quest quest)
		{
			this.Quest = quest;
			Quest quest2 = this.Quest;
			quest2.onSubtitleChanged = (Action)Delegate.Combine(quest2.onSubtitleChanged, new Action(this.UpdateMainLabel));
			Object.Instantiate<RectTransform>(this.Quest.IconPrefab, base.transform.Find("Title/IconContainer")).GetComponent<RectTransform>().sizeDelta = new Vector2(20f, 20f);
			this.UpdateUI();
			if (this.Quest.QuestState == EQuestState.Active)
			{
				this.FadeIn();
			}
			else
			{
				this.Quest.onQuestBegin.AddListener(new UnityAction(this.FadeIn));
				base.gameObject.SetActive(false);
			}
			this.Quest.onQuestEnd.AddListener(new UnityAction<EQuestState>(this.EntryEnded));
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x00128924 File Offset: 0x00126B24
		public void Destroy()
		{
			Quest quest = this.Quest;
			quest.onSubtitleChanged = (Action)Delegate.Remove(quest.onSubtitleChanged, new Action(this.UpdateMainLabel));
			QuestEntryHUDUI[] componentsInChildren = base.GetComponentsInChildren<QuestEntryHUDUI>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].Destroy();
			}
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x00128978 File Offset: 0x00126B78
		public void UpdateUI()
		{
			this.UpdateMainLabel();
			this.UpdateExpiry();
			if (this.onUpdateUI != null)
			{
				this.onUpdateUI();
			}
			this.hudUILayout.CalculateLayoutInputVertical();
			this.hudUILayout.SetLayoutVertical();
			LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)this.hudUILayout.transform);
			this.hudUILayout.enabled = false;
			this.hudUILayout.enabled = true;
			this.UpdateShade();
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<UpdateUI>g__DelayFix|13_0());
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x001289FE File Offset: 0x00126BFE
		public void UpdateMainLabel()
		{
			this.MainLabel.text = this.Quest.GetQuestTitle() + this.Quest.Subtitle;
			this.MainLabel.ForceMeshUpdate(false, false);
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x000045B1 File Offset: 0x000027B1
		public void UpdateExpiry()
		{
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x00128A33 File Offset: 0x00126C33
		public void UpdateShade()
		{
			this.Shade.sizeDelta = new Vector2(550f, this.hudUILayout.preferredHeight + 120f);
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x00128A5B File Offset: 0x00126C5B
		public void BopIcon()
		{
			base.transform.Find("Title/IconContainer").GetComponent<Animation>().Play();
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x00128A78 File Offset: 0x00126C78
		private void FadeIn()
		{
			if (this.Quest.IsTracked)
			{
				base.gameObject.SetActive(true);
			}
			this.Animation.Play("Quest enter");
		}

		// Token: 0x060046C2 RID: 18114 RVA: 0x00128AA4 File Offset: 0x00126CA4
		private void EntryEnded(EQuestState endState)
		{
			if (endState == EQuestState.Completed)
			{
				this.Complete();
				return;
			}
			this.FadeOut();
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x00128AB7 File Offset: 0x00126CB7
		private void FadeOut()
		{
			this.Animation.Play("Quest exit");
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<FadeOut>g__Routine|20_0());
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x00128ADB File Offset: 0x00126CDB
		private void Complete()
		{
			this.Animation.Play("Quest complete");
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<Complete>g__Routine|21_0());
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x00128B12 File Offset: 0x00126D12
		[CompilerGenerated]
		private IEnumerator <UpdateUI>g__DelayFix|13_0()
		{
			yield return new WaitForEndOfFrame();
			this.hudUILayout.CalculateLayoutInputVertical();
			this.hudUILayout.SetLayoutVertical();
			LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)this.hudUILayout.transform);
			this.hudUILayout.enabled = false;
			this.hudUILayout.enabled = true;
			this.UpdateShade();
			yield break;
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x00128B21 File Offset: 0x00126D21
		[CompilerGenerated]
		private IEnumerator <FadeOut>g__Routine|20_0()
		{
			yield return new WaitForSeconds(0.5f);
			base.gameObject.SetActive(false);
			yield break;
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x00128B30 File Offset: 0x00126D30
		[CompilerGenerated]
		private IEnumerator <Complete>g__Routine|21_0()
		{
			yield return new WaitForSeconds(3f);
			this.FadeOut();
			yield break;
		}

		// Token: 0x0400342D RID: 13357
		public string CriticalTimeColor = "FF7A7A";

		// Token: 0x0400342F RID: 13359
		[Header("References")]
		public RectTransform EntryContainer;

		// Token: 0x04003430 RID: 13360
		public TextMeshProUGUI MainLabel;

		// Token: 0x04003431 RID: 13361
		public VerticalLayoutGroup hudUILayout;

		// Token: 0x04003432 RID: 13362
		public Animation Animation;

		// Token: 0x04003433 RID: 13363
		public RectTransform Shade;

		// Token: 0x04003434 RID: 13364
		public Action onUpdateUI;
	}
}
