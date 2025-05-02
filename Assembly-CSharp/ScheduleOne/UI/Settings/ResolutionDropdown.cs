using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.MainMenu;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A82 RID: 2690
	public class ResolutionDropdown : SettingsDropdown
	{
		// Token: 0x0600486C RID: 18540 RVA: 0x0012FF9C File Offset: 0x0012E19C
		protected override void Awake()
		{
			base.Awake();
			foreach (Resolution resolution in DisplaySettings.GetResolutions().ToArray())
			{
				base.AddOption(resolution.width.ToString() + "x" + resolution.height.ToString());
			}
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x0012FFFE File Offset: 0x0012E1FE
		protected virtual void OnEnable()
		{
			this.dropdown.SetValueWithoutNotify(Mathf.Clamp(Singleton<Settings>.Instance.DisplaySettings.ResolutionIndex, 0, this.dropdown.options.Count - 1));
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x00130032 File Offset: 0x0012E232
		protected override void OnValueChanged(int value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.UnappliedDisplaySettings.ResolutionIndex = value;
			base.GetComponentInParent<SettingsScreen>().DisplayChanged();
		}
	}
}
