using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A81 RID: 2689
	public class QualityDropdown : SettingsDropdown
	{
		// Token: 0x06004868 RID: 18536 RVA: 0x0012FEF8 File Offset: 0x0012E0F8
		protected override void Awake()
		{
			base.Awake();
			GraphicsSettings.EGraphicsQuality[] array = (GraphicsSettings.EGraphicsQuality[])Enum.GetValues(typeof(GraphicsSettings.EGraphicsQuality));
			for (int i = 0; i < array.Length; i++)
			{
				string option = array[i].ToString();
				base.AddOption(option);
			}
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x0012FF48 File Offset: 0x0012E148
		protected virtual void Start()
		{
			this.dropdown.SetValueWithoutNotify((int)Singleton<Settings>.Instance.GraphicsSettings.GraphicsQuality);
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x0012FF64 File Offset: 0x0012E164
		protected override void OnValueChanged(int value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.GraphicsSettings.GraphicsQuality = (GraphicsSettings.EGraphicsQuality)value;
			Singleton<Settings>.Instance.ReloadGraphicsSettings();
			Singleton<Settings>.Instance.WriteGraphicsSettings(Singleton<Settings>.Instance.GraphicsSettings);
		}
	}
}
