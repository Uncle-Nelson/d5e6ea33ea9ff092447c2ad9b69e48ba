using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200040D RID: 1037
	[Serializable]
	public class CleanerData : EmployeeData
	{
		// Token: 0x06001582 RID: 5506 RVA: 0x0005FC30 File Offset: 0x0005DE30
		public CleanerData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData) : base(id, assignedProperty, firstName, lastName, male, appearanceIndex, position, rotation, guid, paidForToday)
		{
			this.MoveItemData = moveItemData;
		}

		// Token: 0x040013E2 RID: 5090
		public MoveItemData MoveItemData;
	}
}
