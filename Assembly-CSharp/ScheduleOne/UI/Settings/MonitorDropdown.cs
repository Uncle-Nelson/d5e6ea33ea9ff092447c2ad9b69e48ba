using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.MainMenu;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A80 RID: 2688
	public class MonitorDropdown : SettingsDropdown
	{
		// Token: 0x06004863 RID: 18531 RVA: 0x0012FE24 File Offset: 0x0012E024
		protected override void Awake()
		{
			base.Awake();
			Display[] displays = Display.displays;
			for (int i = 0; i < displays.Length; i++)
			{
				base.AddOption("Monitor " + (i + 1).ToString());
			}
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x0012FE68 File Offset: 0x0012E068
		protected virtual void OnEnable()
		{
			Display[] displays = Display.displays;
			for (int i = 0; i < displays.Length; i++)
			{
				bool active = displays[i].active;
			}
			this.dropdown.SetValueWithoutNotify(Mathf.Clamp(MonitorDropdown.GetCurrentDisplayNumber(), 0, this.dropdown.options.Count - 1));
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x0012FEBA File Offset: 0x0012E0BA
		protected override void OnValueChanged(int value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.UnappliedDisplaySettings.ActiveDisplayIndex = value;
			base.GetComponentInParent<SettingsScreen>().DisplayChanged();
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x0012FEDE File Offset: 0x0012E0DE
		public static int GetCurrentDisplayNumber()
		{
			List<DisplayInfo> list = new List<DisplayInfo>();
			Screen.GetDisplayLayout(list);
			return list.IndexOf(Screen.mainWindowDisplayInfo);
		}
	}
}
