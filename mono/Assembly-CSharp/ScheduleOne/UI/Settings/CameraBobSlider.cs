using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.MainMenu;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A76 RID: 2678
	public class CameraBobSlider : SettingsSlider
	{
		// Token: 0x06004836 RID: 18486 RVA: 0x0012F7F0 File Offset: 0x0012D9F0
		protected virtual void Start()
		{
			this.slider.SetValueWithoutNotify(Singleton<Settings>.Instance.DisplaySettings.CameraBobbing * 10f);
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x0012F812 File Offset: 0x0012DA12
		protected override void OnValueChanged(float value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.UnappliedDisplaySettings.CameraBobbing = value / 10f;
			base.GetComponentInParent<SettingsScreen>().DisplayChanged();
		}
	}
}
