using System;
using UnityEngine.UI;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009B6 RID: 2486
	public class ACSliderReplicator : ACReplicator
	{
		// Token: 0x06004329 RID: 17193 RVA: 0x00119919 File Offset: 0x00117B19
		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			base.AvatarSettingsChanged(newSettings);
			this.slider.SetValueWithoutNotify((float)newSettings[this.propertyName]);
		}

		// Token: 0x040030C4 RID: 12484
		public Slider slider;
	}
}
