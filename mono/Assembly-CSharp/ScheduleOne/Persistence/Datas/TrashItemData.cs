using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200043C RID: 1084
	[Serializable]
	public class TrashItemData : SaveData
	{
		// Token: 0x060015B8 RID: 5560 RVA: 0x000604B5 File Offset: 0x0005E6B5
		public TrashItemData(string trashID, string guid, Vector3 position, Quaternion rotation)
		{
			this.TrashID = trashID;
			this.GUID = guid;
			this.Position = position;
			this.Rotation = rotation;
		}

		// Token: 0x04001476 RID: 5238
		public string TrashID;

		// Token: 0x04001477 RID: 5239
		public string GUID;

		// Token: 0x04001478 RID: 5240
		public Vector3 Position;

		// Token: 0x04001479 RID: 5241
		public Quaternion Rotation;

		// Token: 0x0400147A RID: 5242
		public TrashContentData Contents;
	}
}
