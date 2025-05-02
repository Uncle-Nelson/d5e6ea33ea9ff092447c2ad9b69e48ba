using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A4C RID: 2636
	public class ButtonRequireInputFields : MonoBehaviour
	{
		// Token: 0x06004719 RID: 18201 RVA: 0x00129DE0 File Offset: 0x00127FE0
		public void Update()
		{
			this.Button.interactable = true;
			if (this.Dropdown != null && this.Dropdown.value == 0)
			{
				this.Button.interactable = false;
			}
			foreach (ButtonRequireInputFields.Input input in this.Inputs)
			{
				if (string.IsNullOrEmpty(input.InputField.text))
				{
					input.ErrorMessage.gameObject.SetActive(true);
					this.Button.interactable = false;
				}
				else
				{
					input.ErrorMessage.gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x04003481 RID: 13441
		public List<ButtonRequireInputFields.Input> Inputs;

		// Token: 0x04003482 RID: 13442
		public TMP_Dropdown Dropdown;

		// Token: 0x04003483 RID: 13443
		public Button Button;

		// Token: 0x02000A4D RID: 2637
		[Serializable]
		public class Input
		{
			// Token: 0x04003484 RID: 13444
			public TMP_InputField InputField;

			// Token: 0x04003485 RID: 13445
			public RectTransform ErrorMessage;
		}
	}
}
