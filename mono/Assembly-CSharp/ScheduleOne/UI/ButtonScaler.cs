using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009C3 RID: 2499
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(EventTrigger))]
	public class ButtonScaler : MonoBehaviour
	{
		// Token: 0x0600436C RID: 17260 RVA: 0x0011A984 File Offset: 0x00118B84
		private void Awake()
		{
			this.button = base.GetComponent<Button>();
			EventTrigger component = base.GetComponent<EventTrigger>();
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = 0;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.Hovered();
			}));
			component.triggers.Add(entry);
			EventTrigger.Entry entry2 = new EventTrigger.Entry();
			entry2.eventID = 1;
			entry2.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.HoverEnd();
			}));
			component.triggers.Add(entry2);
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x0011AA02 File Offset: 0x00118C02
		private void Hovered()
		{
			if (!this.button.interactable)
			{
				return;
			}
			this.SetScale(this.HoverScale);
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x0011AA1E File Offset: 0x00118C1E
		private void HoverEnd()
		{
			if (!this.button.interactable)
			{
				return;
			}
			this.SetScale(1f);
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x0011AA3C File Offset: 0x00118C3C
		private void SetScale(float endScale)
		{
			ButtonScaler.<>c__DisplayClass8_0 CS$<>8__locals1 = new ButtonScaler.<>c__DisplayClass8_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.endScale = endScale;
			if (this.scaleCoroutine != null)
			{
				base.StopCoroutine(this.scaleCoroutine);
			}
			this.scaleCoroutine = base.StartCoroutine(CS$<>8__locals1.<SetScale>g__Routine|0());
		}

		// Token: 0x0400310D RID: 12557
		public RectTransform ScaleTarget;

		// Token: 0x0400310E RID: 12558
		public float HoverScale = 1.1f;

		// Token: 0x0400310F RID: 12559
		public float ScaleTime = 0.1f;

		// Token: 0x04003110 RID: 12560
		private Coroutine scaleCoroutine;

		// Token: 0x04003111 RID: 12561
		private Button button;
	}
}
