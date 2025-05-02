using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A86 RID: 2694
	public class SettingsToggle : MonoBehaviour
	{
		// Token: 0x0600487C RID: 18556 RVA: 0x001301FD File Offset: 0x0012E3FD
		protected virtual void Awake()
		{
			this.toggle = base.GetComponent<Toggle>();
			this.toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnValueChanged));
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void OnValueChanged(bool value)
		{
		}

		// Token: 0x040035A3 RID: 13731
		protected Toggle toggle;
	}
}
