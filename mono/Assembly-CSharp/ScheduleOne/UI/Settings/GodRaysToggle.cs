using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A7B RID: 2683
	public class GodRaysToggle : SettingsToggle
	{
		// Token: 0x0600484C RID: 18508 RVA: 0x0012FB31 File Offset: 0x0012DD31
		protected virtual void Start()
		{
			this.toggle.SetIsOnWithoutNotify(Singleton<Settings>.Instance.GraphicsSettings.GodRays);
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x0012FB4D File Offset: 0x0012DD4D
		protected override void OnValueChanged(bool value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.GraphicsSettings.GodRays = value;
			Singleton<Settings>.Instance.ReloadGraphicsSettings();
			Singleton<Settings>.Instance.WriteGraphicsSettings(Singleton<Settings>.Instance.GraphicsSettings);
		}
	}
}
