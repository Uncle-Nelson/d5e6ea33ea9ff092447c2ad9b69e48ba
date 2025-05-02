using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000422 RID: 1058
	[Serializable]
	public class SurfaceItemData : BuildableItemData
	{
		// Token: 0x06001597 RID: 5527 RVA: 0x00060071 File Offset: 0x0005E271
		public SurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot) : base(guid, item, loadOrder)
		{
			this.ParentSurfaceGUID = parentSurfaceGUID;
			this.RelativePosition = pos;
			this.RelativeRotation = rot;
		}

		// Token: 0x0400142C RID: 5164
		public string ParentSurfaceGUID;

		// Token: 0x0400142D RID: 5165
		public Vector3 RelativePosition;

		// Token: 0x0400142E RID: 5166
		public Quaternion RelativeRotation;
	}
}
