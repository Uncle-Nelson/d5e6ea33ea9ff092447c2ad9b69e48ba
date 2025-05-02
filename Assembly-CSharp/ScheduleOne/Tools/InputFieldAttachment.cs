using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Tools
{
	// Token: 0x02000841 RID: 2113
	public class InputFieldAttachment : MonoBehaviour
	{
		// Token: 0x06003A27 RID: 14887 RVA: 0x000F60E4 File Offset: 0x000F42E4
		private void Awake()
		{
			InputField inputField = base.GetComponent<InputField>();
			if (inputField != null)
			{
				EventTrigger eventTrigger = inputField.gameObject.AddComponent<EventTrigger>();
				EventTrigger.Entry entry = new EventTrigger.Entry();
				entry.eventID = 9;
				entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
				{
					this.EditStart(inputField.text);
				}));
				eventTrigger.triggers.Add(entry);
				inputField.onEndEdit.AddListener(new UnityAction<string>(this.EndEdit));
			}
			TMP_InputField component = base.GetComponent<TMP_InputField>();
			if (component != null)
			{
				component.onSelect.AddListener(new UnityAction<string>(this.EditStart));
				component.onEndEdit.AddListener(new UnityAction<string>(this.EndEdit));
			}
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x000AA0CB File Offset: 0x000A82CB
		private void EditStart(string newVal)
		{
			GameInput.IsTyping = true;
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x000AA0D3 File Offset: 0x000A82D3
		private void EndEdit(string newVal)
		{
			GameInput.IsTyping = false;
		}
	}
}
