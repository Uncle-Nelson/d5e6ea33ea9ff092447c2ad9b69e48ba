using System;
using ScheduleOne.Management.Presets;
using UnityEngine;

namespace ScheduleOne.Management.Objects
{
	// Token: 0x020005A1 RID: 1441
	public abstract class ManageableObject : MonoBehaviour
	{
		// Token: 0x060023BF RID: 9151
		public abstract ManageableObjectType GetObjectType();

		// Token: 0x060023C0 RID: 9152
		public abstract Preset GetCurrentPreset();

		// Token: 0x060023C1 RID: 9153 RVA: 0x0009168A File Offset: 0x0008F88A
		public void SetPreset(Preset newPreset)
		{
			if (this.GetCurrentPreset() != null)
			{
				Preset currentPreset = this.GetCurrentPreset();
				currentPreset.onDeleted = (Preset.PresetDeletion)Delegate.Remove(currentPreset.onDeleted, new Preset.PresetDeletion(this.ExistingPresetDeleted));
			}
			this.SetPreset_Internal(newPreset);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x000916C2 File Offset: 0x0008F8C2
		protected virtual void SetPreset_Internal(Preset preset)
		{
			preset.onDeleted = (Preset.PresetDeletion)Delegate.Combine(preset.onDeleted, new Preset.PresetDeletion(this.ExistingPresetDeleted));
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000916E6 File Offset: 0x0008F8E6
		public void ExistingPresetDeleted(Preset replacement)
		{
			this.SetPreset(replacement);
		}
	}
}
