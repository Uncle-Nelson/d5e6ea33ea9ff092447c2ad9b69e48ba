using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000B4A RID: 2890
	public class CharacterCreatorSlider : CharacterCreatorField<float>
	{
		// Token: 0x06004CCC RID: 19660 RVA: 0x00143D61 File Offset: 0x00141F61
		protected override void Awake()
		{
			base.Awake();
			this.Slider.onValueChanged.AddListener(new UnityAction<float>(this.OnSliderChanged));
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x00143D85 File Offset: 0x00141F85
		public override void ApplyValue()
		{
			base.ApplyValue();
			this.Slider.SetValueWithoutNotify(base.value);
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x00143D9E File Offset: 0x00141F9E
		public void OnSliderChanged(float newValue)
		{
			base.value = newValue;
			this.WriteValue(false);
		}

		// Token: 0x040039E0 RID: 14816
		[Header("References")]
		public Slider Slider;
	}
}
