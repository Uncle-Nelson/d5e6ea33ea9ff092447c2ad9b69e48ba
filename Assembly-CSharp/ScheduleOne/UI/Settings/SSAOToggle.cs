using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A88 RID: 2696
	public class SSAOToggle : SettingsToggle
	{
		// Token: 0x06004883 RID: 18563 RVA: 0x001302CB File Offset: 0x0012E4CB
		protected virtual void Start()
		{
			this.toggle.SetIsOnWithoutNotify(Singleton<Settings>.Instance.GraphicsSettings.SSAO);
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x001302E7 File Offset: 0x0012E4E7
		protected override void OnValueChanged(bool value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.GraphicsSettings.SSAO = value;
			Singleton<Settings>.Instance.ReloadGraphicsSettings();
			Singleton<Settings>.Instance.WriteGraphicsSettings(Singleton<Settings>.Instance.GraphicsSettings);
		}
	}
}
