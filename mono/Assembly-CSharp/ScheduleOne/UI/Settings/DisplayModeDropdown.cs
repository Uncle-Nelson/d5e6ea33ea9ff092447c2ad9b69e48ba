using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.MainMenu;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A78 RID: 2680
	public class DisplayModeDropdown : SettingsDropdown
	{
		// Token: 0x06004840 RID: 18496 RVA: 0x0012F9C4 File Offset: 0x0012DBC4
		protected override void Awake()
		{
			base.Awake();
			DisplaySettings.EDisplayMode[] array = (DisplaySettings.EDisplayMode[])Enum.GetValues(typeof(DisplaySettings.EDisplayMode));
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].ToString();
				text = text.Replace("ExclusiveFullscreen", "Exclusive Fullscreen");
				text = text.Replace("FullscreenWindow", "Fullscreen Window");
				base.AddOption(text);
			}
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x0012FA36 File Offset: 0x0012DC36
		protected virtual void OnEnable()
		{
			this.dropdown.SetValueWithoutNotify((int)Singleton<Settings>.Instance.DisplaySettings.DisplayMode);
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x0012FA52 File Offset: 0x0012DC52
		protected override void OnValueChanged(int value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.UnappliedDisplaySettings.DisplayMode = (DisplaySettings.EDisplayMode)value;
			base.GetComponentInParent<SettingsScreen>().DisplayChanged();
		}
	}
}
