using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A87 RID: 2695
	public class SprintModeDropdown : SettingsDropdown
	{
		// Token: 0x0600487F RID: 18559 RVA: 0x00130228 File Offset: 0x0012E428
		protected override void Awake()
		{
			base.Awake();
			InputSettings.EActionMode[] array = (InputSettings.EActionMode[])Enum.GetValues(typeof(InputSettings.EActionMode));
			for (int i = 0; i < array.Length; i++)
			{
				string option = array[i].ToString();
				base.AddOption(option);
			}
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x00130278 File Offset: 0x0012E478
		protected virtual void Start()
		{
			this.dropdown.SetValueWithoutNotify((int)Singleton<Settings>.Instance.InputSettings.SprintMode);
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x00130294 File Offset: 0x0012E494
		protected override void OnValueChanged(int value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.InputSettings.SprintMode = (InputSettings.EActionMode)value;
			Singleton<Settings>.Instance.ReloadInputSettings();
			Singleton<Settings>.Instance.WriteInputSettings(Singleton<Settings>.Instance.InputSettings);
		}
	}
}
