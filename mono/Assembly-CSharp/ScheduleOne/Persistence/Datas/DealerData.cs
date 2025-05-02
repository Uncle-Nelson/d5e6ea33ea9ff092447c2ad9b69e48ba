using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200040E RID: 1038
	public class DealerData : NPCData
	{
		// Token: 0x06001583 RID: 5507 RVA: 0x0005FC5C File Offset: 0x0005DE5C
		public DealerData(string id, bool recruited, string[] assignedCustomerIDs, string[] activeContractGUIDs, float cash, ItemSet overflowItems, bool hasBeenRecommended) : base(id)
		{
			this.Recruited = recruited;
			this.AssignedCustomerIDs = assignedCustomerIDs;
			this.ActiveContractGUIDs = activeContractGUIDs;
			this.Cash = cash;
			this.OverflowItems = overflowItems;
			this.HasBeenRecommended = hasBeenRecommended;
		}

		// Token: 0x040013E3 RID: 5091
		public bool Recruited;

		// Token: 0x040013E4 RID: 5092
		public string[] AssignedCustomerIDs;

		// Token: 0x040013E5 RID: 5093
		public string[] ActiveContractGUIDs;

		// Token: 0x040013E6 RID: 5094
		public float Cash;

		// Token: 0x040013E7 RID: 5095
		public ItemSet OverflowItems;

		// Token: 0x040013E8 RID: 5096
		public bool HasBeenRecommended;
	}
}
