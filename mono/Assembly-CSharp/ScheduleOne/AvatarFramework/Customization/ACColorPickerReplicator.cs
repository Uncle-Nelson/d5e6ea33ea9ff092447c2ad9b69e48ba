using System;
using HSVPicker;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009B3 RID: 2483
	public class ACColorPickerReplicator : ACReplicator
	{
		// Token: 0x06004323 RID: 17187 RVA: 0x001198B0 File Offset: 0x00117AB0
		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			base.AvatarSettingsChanged(newSettings);
			this.picker.CurrentColor = (Color)newSettings[this.propertyName];
		}

		// Token: 0x040030C2 RID: 12482
		public ColorPicker picker;
	}
}
