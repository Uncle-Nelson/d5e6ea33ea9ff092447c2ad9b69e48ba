using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A38 RID: 2616
	[RequireComponent(typeof(EventTrigger))]
	public class PropagateDrag : MonoBehaviour
	{
		// Token: 0x06004688 RID: 18056 RVA: 0x00128040 File Offset: 0x00126240
		private void Start()
		{
			if (this.ScrollView == null)
			{
				this.ScrollView = base.GetComponentInParent<ScrollRect>();
			}
			if (this.ScrollView == null)
			{
				return;
			}
			EventTrigger component = base.GetComponent<EventTrigger>();
			EventTrigger.Entry entry = new EventTrigger.Entry();
			EventTrigger.Entry entry2 = new EventTrigger.Entry();
			EventTrigger.Entry entry3 = new EventTrigger.Entry();
			EventTrigger.Entry entry4 = new EventTrigger.Entry();
			EventTrigger.Entry entry5 = new EventTrigger.Entry();
			entry.eventID = 13;
			entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.ScrollView.OnBeginDrag((PointerEventData)data);
			}));
			component.triggers.Add(entry);
			entry2.eventID = 5;
			entry2.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.ScrollView.OnDrag((PointerEventData)data);
			}));
			component.triggers.Add(entry2);
			entry3.eventID = 14;
			entry3.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.ScrollView.OnEndDrag((PointerEventData)data);
			}));
			component.triggers.Add(entry3);
			entry4.eventID = 12;
			entry4.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.ScrollView.OnInitializePotentialDrag((PointerEventData)data);
			}));
			component.triggers.Add(entry4);
			entry5.eventID = 7;
			entry5.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
			{
				this.ScrollView.OnScroll((PointerEventData)data);
			}));
			component.triggers.Add(entry5);
		}

		// Token: 0x0400341A RID: 13338
		public ScrollRect ScrollView;
	}
}
