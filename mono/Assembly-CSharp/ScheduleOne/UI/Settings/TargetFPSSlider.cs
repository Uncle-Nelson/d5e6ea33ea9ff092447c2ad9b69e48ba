using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.MainMenu;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A89 RID: 2697
	public class TargetFPSSlider : SettingsSlider
	{
		// Token: 0x06004886 RID: 18566 RVA: 0x0013031E File Offset: 0x0012E51E
		protected virtual void OnEnable()
		{
			this.slider.SetValueWithoutNotify((float)Singleton<Settings>.Instance.DisplaySettings.TargetFPS);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x0013033B File Offset: 0x0012E53B
		protected override void OnValueChanged(float value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.UnappliedDisplaySettings.TargetFPS = Mathf.RoundToInt(value);
			base.GetComponentInParent<SettingsScreen>().DisplayChanged();
		}
	}
}
