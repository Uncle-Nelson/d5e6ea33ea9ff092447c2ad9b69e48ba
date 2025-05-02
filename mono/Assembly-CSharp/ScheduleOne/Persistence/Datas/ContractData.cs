using System;
using ScheduleOne.Product;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200042F RID: 1071
	[Serializable]
	public class ContractData : QuestData
	{
		// Token: 0x060015A5 RID: 5541 RVA: 0x0006022C File Offset: 0x0005E42C
		public ContractData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, QuestEntryData[] entries, string customerGUID, float payment, ProductList productList, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTimeData acceptTime) : base(guid, state, isTracked, title, desc, isTimed, expiry, entries)
		{
			this.CustomerGUID = customerGUID;
			this.Payment = payment;
			this.ProductList = productList;
			this.DeliveryLocationGUID = deliveryLocationGUID;
			this.DeliveryWindow = deliveryWindow;
			this.PickupScheduleIndex = pickupScheduleIndex;
			this.AcceptTime = acceptTime;
		}

		// Token: 0x0400144F RID: 5199
		public string CustomerGUID;

		// Token: 0x04001450 RID: 5200
		public float Payment;

		// Token: 0x04001451 RID: 5201
		public ProductList ProductList;

		// Token: 0x04001452 RID: 5202
		public string DeliveryLocationGUID;

		// Token: 0x04001453 RID: 5203
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x04001454 RID: 5204
		public int PickupScheduleIndex;

		// Token: 0x04001455 RID: 5205
		public GameDateTimeData AcceptTime;
	}
}
