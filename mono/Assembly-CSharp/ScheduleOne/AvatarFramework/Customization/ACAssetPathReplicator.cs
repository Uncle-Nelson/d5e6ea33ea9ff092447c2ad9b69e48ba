using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009B1 RID: 2481
	public class ACAssetPathReplicator<T> : ACReplicator where T : Object
	{
		// Token: 0x0600431F RID: 17183 RVA: 0x00119861 File Offset: 0x00117A61
		protected virtual void Awake()
		{
			this.selection = base.GetComponent<ACSelection<T>>();
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x0011986F File Offset: 0x00117A6F
		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			base.AvatarSettingsChanged(newSettings);
			this.selection.SelectOption(this.selection.GetAssetPathIndex((string)newSettings[this.propertyName]), false);
		}

		// Token: 0x040030C1 RID: 12481
		private ACSelection<T> selection;
	}
}
