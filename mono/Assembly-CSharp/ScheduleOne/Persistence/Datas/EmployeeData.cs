using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200040F RID: 1039
	[Serializable]
	public class EmployeeData : NPCData
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x0005FC94 File Offset: 0x0005DE94
		public EmployeeData(string id, string assignedProperty, string firstName, string lastName, bool isMale, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday) : base(id)
		{
			this.AssignedProperty = assignedProperty;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.IsMale = isMale;
			this.AppearanceIndex = appearanceIndex;
			this.Position = position;
			this.Rotation = rotation;
			this.GUID = guid.ToString();
			this.PaidForToday = paidForToday;
		}

		// Token: 0x040013E9 RID: 5097
		public string AssignedProperty;

		// Token: 0x040013EA RID: 5098
		public string FirstName;

		// Token: 0x040013EB RID: 5099
		public string LastName;

		// Token: 0x040013EC RID: 5100
		public bool IsMale;

		// Token: 0x040013ED RID: 5101
		public int AppearanceIndex;

		// Token: 0x040013EE RID: 5102
		public Vector3 Position;

		// Token: 0x040013EF RID: 5103
		public Quaternion Rotation;

		// Token: 0x040013F0 RID: 5104
		public string GUID;

		// Token: 0x040013F1 RID: 5105
		public bool PaidForToday;
	}
}
