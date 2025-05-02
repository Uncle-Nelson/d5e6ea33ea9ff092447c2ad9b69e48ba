using System;
using ScheduleOne.Management.Presets;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.Management.Objects
{
	// Token: 0x020005A2 RID: 1442
	[RequireComponent(typeof(Pot))]
	public class ManageablePot : ManageableObject
	{
		// Token: 0x060023C5 RID: 9157 RVA: 0x000916EF File Offset: 0x0008F8EF
		protected virtual void Awake()
		{
			this.CurrentPreset = PotPreset.GetDefaultPreset();
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x000141BA File Offset: 0x000123BA
		public override ManageableObjectType GetObjectType()
		{
			return ManageableObjectType.Pot;
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x000916FC File Offset: 0x0008F8FC
		public override Preset GetCurrentPreset()
		{
			return this.CurrentPreset;
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00091704 File Offset: 0x0008F904
		protected override void SetPreset_Internal(Preset newPreset)
		{
			base.SetPreset_Internal(newPreset);
			PotPreset potPreset = (PotPreset)newPreset;
			if (potPreset == null)
			{
				Console.LogWarning("SetPreset_Internal: preset is not the right type", null);
				return;
			}
			this.CurrentPreset = potPreset;
		}

		// Token: 0x04001AA6 RID: 6822
		public PotPreset CurrentPreset;
	}
}
