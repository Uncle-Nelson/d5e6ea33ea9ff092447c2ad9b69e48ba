using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Quests;
using ScheduleOne.UI.Relations;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009D3 RID: 2515
	public class DealCompletionPopup : Singleton<DealCompletionPopup>
	{
		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x060043E8 RID: 17384 RVA: 0x0011C78B File Offset: 0x0011A98B
		// (set) Token: 0x060043E9 RID: 17385 RVA: 0x0011C793 File Offset: 0x0011A993
		public bool IsPlaying { get; protected set; }

		// Token: 0x060043EA RID: 17386 RVA: 0x0011C79C File Offset: 0x0011A99C
		protected override void Awake()
		{
			base.Awake();
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x0011C7C4 File Offset: 0x0011A9C4
		public void PlayPopup(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses)
		{
			DealCompletionPopup.<>c__DisplayClass18_0 CS$<>8__locals1 = new DealCompletionPopup.<>c__DisplayClass18_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.customer = customer;
			CS$<>8__locals1.bonuses = bonuses;
			CS$<>8__locals1.originalRelationshipDelta = originalRelationshipDelta;
			CS$<>8__locals1.basePayment = basePayment;
			CS$<>8__locals1.satisfaction = satisfaction;
			this.IsPlaying = true;
			if (this.routine != null)
			{
				base.StopCoroutine(this.routine);
			}
			this.routine = base.StartCoroutine(CS$<>8__locals1.<PlayPopup>g__Routine|0());
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x0011C830 File Offset: 0x0011AA30
		private void SetRelationshipLabel(float delta)
		{
			ERelationshipCategory category = RelationshipCategory.GetCategory(delta);
			this.RelationshipLabel.text = category.ToString();
			this.RelationshipLabel.color = RelationshipCategory.GetColor(category);
		}

		// Token: 0x04003163 RID: 12643
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003164 RID: 12644
		public RectTransform Container;

		// Token: 0x04003165 RID: 12645
		public CanvasGroup Group;

		// Token: 0x04003166 RID: 12646
		public Animation Anim;

		// Token: 0x04003167 RID: 12647
		public TextMeshProUGUI Title;

		// Token: 0x04003168 RID: 12648
		public TextMeshProUGUI PaymentLabel;

		// Token: 0x04003169 RID: 12649
		public TextMeshProUGUI SatisfactionValueLabel;

		// Token: 0x0400316A RID: 12650
		public RelationCircle RelationCircle;

		// Token: 0x0400316B RID: 12651
		public TextMeshProUGUI RelationshipLabel;

		// Token: 0x0400316C RID: 12652
		public Gradient SatisfactionGradient;

		// Token: 0x0400316D RID: 12653
		public AudioSourceController SoundEffect;

		// Token: 0x0400316E RID: 12654
		public TextMeshProUGUI[] BonusLabels;

		// Token: 0x0400316F RID: 12655
		private Coroutine routine;
	}
}
