using System;
using ScheduleOne.Delivery;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D5 RID: 981
	public class DeliveriesData : SaveData
	{
		// Token: 0x0600153A RID: 5434 RVA: 0x0005F5B0 File Offset: 0x0005D7B0
		public DeliveriesData(DeliveryInstance[] deliveries)
		{
			this.ActiveDeliveries = deliveries;
		}

		// Token: 0x04001380 RID: 4992
		public DeliveryInstance[] ActiveDeliveries;
	}
}
