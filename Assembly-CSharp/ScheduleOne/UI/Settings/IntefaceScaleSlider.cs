using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.MainMenu;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A7C RID: 2684
	public class IntefaceScaleSlider : SettingsSlider
	{
		// Token: 0x0600484F RID: 18511 RVA: 0x0012FB8C File Offset: 0x0012DD8C
		protected virtual void OnEnable()
		{
			this.slider.minValue = 7f;
			this.slider.maxValue = 14f;
			this.slider.SetValueWithoutNotify(Singleton<Settings>.Instance.DisplaySettings.UIScale / 0.1f);
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x0012FBD9 File Offset: 0x0012DDD9
		protected override void OnValueChanged(float value)
		{
			base.OnValueChanged(value);
			Singleton<Settings>.Instance.UnappliedDisplaySettings.UIScale = value * 0.1f;
			base.GetComponentInParent<SettingsScreen>().DisplayChanged();
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x0012FC04 File Offset: 0x0012DE04
		protected override string GetDisplayValue(float value)
		{
			return Mathf.Round(value * 10f).ToString() + "%";
		}

		// Token: 0x04003595 RID: 13717
		public const float MULTIPLIER = 0.1f;

		// Token: 0x04003596 RID: 13718
		public const float MinScale = 0.7f;

		// Token: 0x04003597 RID: 13719
		public const float MaxScale = 1.4f;
	}
}
