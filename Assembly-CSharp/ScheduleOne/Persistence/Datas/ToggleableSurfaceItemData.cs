using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000424 RID: 1060
	public class ToggleableSurfaceItemData : SurfaceItemData
	{
		// Token: 0x06001599 RID: 5529 RVA: 0x000600AD File Offset: 0x0005E2AD
		public ToggleableSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, bool isOn) : base(guid, item, loadOrder, parentSurfaceGUID, pos, rot)
		{
			this.IsOn = isOn;
		}

		// Token: 0x04001430 RID: 5168
		public bool IsOn;
	}
}
