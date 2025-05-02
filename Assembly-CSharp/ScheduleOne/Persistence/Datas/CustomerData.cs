using System;
using ScheduleOne.GameTime;
using ScheduleOne.Quests;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D3 RID: 979
	public class CustomerData : SaveData
	{
		// Token: 0x06001536 RID: 5430 RVA: 0x0005F4A4 File Offset: 0x0005D6A4
		public CustomerData(float dependence, string[] purchaseableProducts, float[] productAffinities, int timeSinceLastDealCompleted, int timeSinceLastDealOffered, int offeredDeals, int completedDeals, bool isContractOffered, ContractInfo offeredContract, GameDateTime offeredTime, int timeSincePlayerApproached, int timeSinceInstantDealOffered, bool hasBeenRecommended)
		{
			this.Dependence = dependence;
			this.PurchaseableProducts = purchaseableProducts;
			this.ProductAffinities = productAffinities;
			this.TimeSinceLastDealCompleted = timeSinceLastDealCompleted;
			this.TimeSinceLastDealOffered = timeSinceLastDealOffered;
			this.OfferedDeals = offeredDeals;
			this.CompletedDeals = completedDeals;
			this.IsContractOffered = isContractOffered;
			this.OfferedContract = offeredContract;
			this.OfferedContractTime = offeredTime;
			this.TimeSincePlayerApproached = timeSincePlayerApproached;
			this.TimeSinceInstantDealOffered = timeSinceInstantDealOffered;
			this.HasBeenRecommended = hasBeenRecommended;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0005F51C File Offset: 0x0005D71C
		public CustomerData()
		{
		}

		// Token: 0x0400136D RID: 4973
		public float Dependence;

		// Token: 0x0400136E RID: 4974
		public string[] PurchaseableProducts;

		// Token: 0x0400136F RID: 4975
		public float[] ProductAffinities;

		// Token: 0x04001370 RID: 4976
		public int TimeSinceLastDealCompleted;

		// Token: 0x04001371 RID: 4977
		public int TimeSinceLastDealOffered;

		// Token: 0x04001372 RID: 4978
		public int OfferedDeals;

		// Token: 0x04001373 RID: 4979
		public int CompletedDeals;

		// Token: 0x04001374 RID: 4980
		public bool IsContractOffered;

		// Token: 0x04001375 RID: 4981
		public ContractInfo OfferedContract;

		// Token: 0x04001376 RID: 4982
		public GameDateTime OfferedContractTime;

		// Token: 0x04001377 RID: 4983
		public int TimeSincePlayerApproached;

		// Token: 0x04001378 RID: 4984
		public int TimeSinceInstantDealOffered;

		// Token: 0x04001379 RID: 4985
		public bool HasBeenRecommended;
	}
}
