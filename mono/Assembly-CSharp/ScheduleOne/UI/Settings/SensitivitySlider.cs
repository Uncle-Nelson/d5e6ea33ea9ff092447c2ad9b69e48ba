using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A83 RID: 2691
	public class SensitivitySlider : SettingsSlider
	{
		// Token: 0x06004870 RID: 18544 RVA: 0x00130056 File Offset: 0x0012E256
		protected virtual void Start()
		{
			this.slider.SetValueWithoutNotify(Singleton<Settings>.Instance.InputSettings.MouseSensitivity / 0.033333335f);
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x00130078 File Offset: 0x0012E278
		protected override void OnValueChanged(float value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.InputSettings.MouseSensitivity = value * 0.033333335f;
			Singleton<Settings>.Instance.ReloadInputSettings();
			Singleton<Settings>.Instance.WriteInputSettings(Singleton<Settings>.Instance.InputSettings);
		}

		// Token: 0x0400359B RID: 13723
		public const float MULTIPLIER = 0.033333335f;
	}
}
