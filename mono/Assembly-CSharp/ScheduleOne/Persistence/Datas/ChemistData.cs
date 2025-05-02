using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200040C RID: 1036
	[Serializable]
	public class ChemistData : EmployeeData
	{
		// Token: 0x06001581 RID: 5505 RVA: 0x0005FC04 File Offset: 0x0005DE04
		public ChemistData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData) : base(id, assignedProperty, firstName, lastName, male, appearanceIndex, position, rotation, guid, paidForToday)
		{
			this.MoveItemData = moveItemData;
		}

		// Token: 0x040013E1 RID: 5089
		public MoveItemData MoveItemData;
	}
}
