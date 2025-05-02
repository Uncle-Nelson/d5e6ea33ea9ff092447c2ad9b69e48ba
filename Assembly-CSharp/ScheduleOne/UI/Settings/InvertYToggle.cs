using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A7D RID: 2685
	public class InvertYToggle : SettingsToggle
	{
		// Token: 0x06004853 RID: 18515 RVA: 0x0012FC2F File Offset: 0x0012DE2F
		protected virtual void Start()
		{
			this.toggle.SetIsOnWithoutNotify(Singleton<Settings>.Instance.InputSettings.InvertMouse);
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x0012FC4B File Offset: 0x0012DE4B
		protected override void OnValueChanged(bool value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.InputSettings.InvertMouse = value;
			Singleton<Settings>.Instance.ReloadInputSettings();
			Singleton<Settings>.Instance.WriteInputSettings(Singleton<Settings>.Instance.InputSettings);
		}
	}
}
