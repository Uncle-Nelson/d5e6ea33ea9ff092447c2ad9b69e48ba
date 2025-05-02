using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A74 RID: 2676
	public class AntiAliasingDropdown : SettingsDropdown
	{
		// Token: 0x0600482F RID: 18479 RVA: 0x0012F5A0 File Offset: 0x0012D7A0
		protected override void Awake()
		{
			base.Awake();
			GraphicsSettings.EAntiAliasingMode[] array = (GraphicsSettings.EAntiAliasingMode[])Enum.GetValues(typeof(GraphicsSettings.EAntiAliasingMode));
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].ToString();
				text = text.Replace("MSAAx2", "2x MSAA");
				text = text.Replace("MSAAx4", "4x MSAA");
				text = text.Replace("MSAAx8", "8x MSAA");
				base.AddOption(text);
			}
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x0012F623 File Offset: 0x0012D823
		protected virtual void Start()
		{
			this.dropdown.SetValueWithoutNotify((int)Singleton<Settings>.Instance.GraphicsSettings.AntiAliasingMode);
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x0012F63F File Offset: 0x0012D83F
		protected override void OnValueChanged(int value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.GraphicsSettings.AntiAliasingMode = (GraphicsSettings.EAntiAliasingMode)value;
			Singleton<Settings>.Instance.ReloadGraphicsSettings();
			Singleton<Settings>.Instance.WriteGraphicsSettings(Singleton<Settings>.Instance.GraphicsSettings);
		}
	}
}
