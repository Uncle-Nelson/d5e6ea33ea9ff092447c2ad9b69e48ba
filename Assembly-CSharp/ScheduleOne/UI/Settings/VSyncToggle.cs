using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.MainMenu;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A8A RID: 2698
	public class VSyncToggle : SettingsToggle
	{
		// Token: 0x06004889 RID: 18569 RVA: 0x00130364 File Offset: 0x0012E564
		protected virtual void OnEnable()
		{
			this.toggle.SetIsOnWithoutNotify(Singleton<Settings>.Instance.DisplaySettings.VSync);
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x00130380 File Offset: 0x0012E580
		protected override void OnValueChanged(bool value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.UnappliedDisplaySettings.VSync = value;
			base.GetComponentInParent<SettingsScreen>().DisplayChanged();
		}
	}
}
