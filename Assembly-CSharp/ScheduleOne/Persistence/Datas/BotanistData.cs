using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200040B RID: 1035
	[Serializable]
	public class BotanistData : EmployeeData
	{
		// Token: 0x06001580 RID: 5504 RVA: 0x0005FBD8 File Offset: 0x0005DDD8
		public BotanistData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData) : base(id, assignedProperty, firstName, lastName, male, appearanceIndex, position, rotation, guid, paidForToday)
		{
			this.MoveItemData = moveItemData;
		}

		// Token: 0x040013E0 RID: 5088
		public MoveItemData MoveItemData;
	}
}
