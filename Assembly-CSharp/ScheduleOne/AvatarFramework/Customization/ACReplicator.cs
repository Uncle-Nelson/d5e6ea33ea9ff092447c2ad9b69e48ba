using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020009B5 RID: 2485
	public class ACReplicator : MonoBehaviour
	{
		// Token: 0x06004326 RID: 17190 RVA: 0x001198DD File Offset: 0x00117ADD
		private void Start()
		{
			CustomizationManager instance = Singleton<CustomizationManager>.Instance;
			instance.OnAvatarSettingsChanged = (CustomizationManager.AvatarSettingsChanged)Delegate.Combine(instance.OnAvatarSettingsChanged, new CustomizationManager.AvatarSettingsChanged(this.AvatarSettingsChanged));
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}

		// Token: 0x040030C3 RID: 12483
		public string propertyName = string.Empty;
	}
}
