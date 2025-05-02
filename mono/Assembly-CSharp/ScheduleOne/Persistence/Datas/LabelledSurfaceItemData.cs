using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000419 RID: 1049
	public class LabelledSurfaceItemData : SurfaceItemData
	{
		// Token: 0x0600158E RID: 5518 RVA: 0x0005FEFD File Offset: 0x0005E0FD
		public LabelledSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, string message) : base(guid, item, loadOrder, parentSurfaceGUID, pos, rot)
		{
			this.Message = message;
		}

		// Token: 0x04001413 RID: 5139
		public string Message;
	}
}
