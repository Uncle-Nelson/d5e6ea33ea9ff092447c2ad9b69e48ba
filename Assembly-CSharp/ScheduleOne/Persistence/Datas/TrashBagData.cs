using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000439 RID: 1081
	public class TrashBagData : TrashItemData
	{
		// Token: 0x060015B5 RID: 5557 RVA: 0x0006047B File Offset: 0x0005E67B
		public TrashBagData(string trashID, string guid, Vector3 position, Quaternion rotation, TrashContentData contents) : base(trashID, guid, position, rotation)
		{
			this.Contents = contents;
		}
	}
}
