using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A79 RID: 2681
	public class FOVSLider : SettingsSlider
	{
		// Token: 0x06004844 RID: 18500 RVA: 0x0012FA76 File Offset: 0x0012DC76
		protected virtual void Start()
		{
			this.slider.SetValueWithoutNotify(Singleton<Settings>.Instance.GraphicsSettings.FOV);
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x0012FA92 File Offset: 0x0012DC92
		protected override void OnValueChanged(float value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.GraphicsSettings.FOV = value;
			Singleton<Settings>.Instance.ReloadGraphicsSettings();
			Singleton<Settings>.Instance.WriteGraphicsSettings(Singleton<Settings>.Instance.GraphicsSettings);
		}
	}
}
