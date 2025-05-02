using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A84 RID: 2692
	public class SettingsDropdown : MonoBehaviour
	{
		// Token: 0x06004873 RID: 18547 RVA: 0x001300B8 File Offset: 0x0012E2B8
		protected virtual void Awake()
		{
			this.dropdown = base.GetComponent<TMP_Dropdown>();
			this.dropdown.onValueChanged.AddListener(new UnityAction<int>(this.OnValueChanged));
			foreach (string option in this.DefaultOptions)
			{
				this.AddOption(option);
			}
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void OnValueChanged(int value)
		{
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x0013010E File Offset: 0x0012E30E
		protected void AddOption(string option)
		{
			this.dropdown.options.Add(new TMP_Dropdown.OptionData(option));
		}

		// Token: 0x0400359C RID: 13724
		public string[] DefaultOptions;

		// Token: 0x0400359D RID: 13725
		protected TMP_Dropdown dropdown;
	}
}
