using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A85 RID: 2693
	public class SettingsSlider : MonoBehaviour
	{
		// Token: 0x06004877 RID: 18551 RVA: 0x00130128 File Offset: 0x0012E328
		protected virtual void Awake()
		{
			this.slider = base.GetComponent<Slider>();
			this.slider.onValueChanged.AddListener(new UnityAction<float>(this.OnValueChanged));
			this.valueLabel = this.slider.handleRect.Find("Value").GetComponent<TextMeshProUGUI>();
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x0013017E File Offset: 0x0012E37E
		protected virtual void Update()
		{
			if (this.DisplayValue && Time.time - this.timeOnValueChange > 2f)
			{
				this.valueLabel.enabled = false;
			}
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x001301A7 File Offset: 0x0012E3A7
		protected virtual void OnValueChanged(float value)
		{
			this.timeOnValueChange = Time.time;
			if (this.DisplayValue)
			{
				this.valueLabel.text = this.GetDisplayValue(value);
				this.valueLabel.enabled = true;
			}
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x001301DA File Offset: 0x0012E3DA
		protected virtual string GetDisplayValue(float value)
		{
			return value.ToString();
		}

		// Token: 0x0400359E RID: 13726
		private const float VALUE_DISPLAY_TIME = 2f;

		// Token: 0x0400359F RID: 13727
		public bool DisplayValue = true;

		// Token: 0x040035A0 RID: 13728
		protected Slider slider;

		// Token: 0x040035A1 RID: 13729
		protected TextMeshProUGUI valueLabel;

		// Token: 0x040035A2 RID: 13730
		protected float timeOnValueChange = -100f;
	}
}
