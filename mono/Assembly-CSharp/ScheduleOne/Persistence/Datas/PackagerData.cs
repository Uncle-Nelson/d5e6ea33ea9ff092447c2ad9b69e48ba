using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000411 RID: 1041
	[Serializable]
	public class PackagerData : EmployeeData
	{
		// Token: 0x06001586 RID: 5510 RVA: 0x0005FD50 File Offset: 0x0005DF50
		public PackagerData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData) : base(id, assignedProperty, firstName, lastName, male, appearanceIndex, position, rotation, guid, paidForToday)
		{
			this.MoveItemData = moveItemData;
		}

		// Token: 0x040013F6 RID: 5110
		public MoveItemData MoveItemData;
	}
}
