using System;
using System.Collections.Generic;
using ScheduleOne.Dialogue;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.Money;
using ScheduleOne.Product;

namespace ScheduleOne.Quests
{
	// Token: 0x020002D8 RID: 728
	[Serializable]
	public class ContractInfo
	{
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00046A89 File Offset: 0x00044C89
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00046A91 File Offset: 0x00044C91
		public DeliveryLocation DeliveryLocation { get; private set; }

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00046A9C File Offset: 0x00044C9C
		public ContractInfo(float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, int expiresAfter, int pickupScheduleIndex, bool isCounterOffer)
		{
			this.Payment = payment;
			this.Products = products;
			this.DeliveryLocationGUID = deliveryLocationGUID;
			this.DeliveryWindow = deliveryWindow;
			this.Expires = expires;
			this.ExpiresAfter = expiresAfter;
			this.PickupScheduleIndex = pickupScheduleIndex;
			this.IsCounterOffer = isCounterOffer;
			if (GUIDManager.IsGUIDValid(deliveryLocationGUID))
			{
				this.DeliveryLocation = GUIDManager.GetObject<DeliveryLocation>(new Guid(deliveryLocationGUID));
			}
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0000494F File Offset: 0x00002B4F
		public ContractInfo()
		{
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00046B08 File Offset: 0x00044D08
		public DialogueChain ProcessMessage(DialogueChain messageChain)
		{
			if (this.DeliveryLocation == null && GUIDManager.IsGUIDValid(this.DeliveryLocationGUID))
			{
				this.DeliveryLocation = GUIDManager.GetObject<DeliveryLocation>(new Guid(this.DeliveryLocationGUID));
			}
			List<string> list = new List<string>();
			string[] lines = messageChain.Lines;
			for (int i = 0; i < lines.Length; i++)
			{
				string text = lines[i].Replace("<PRICE>", "<color=#46CB4F>" + MoneyManager.FormatAmount(this.Payment, false, false) + "</color>");
				text = text.Replace("<PRODUCT>", this.Products.GetCommaSeperatedString());
				text = text.Replace("<QUALITY>", this.Products.GetQualityString());
				text = text.Replace("<LOCATION>", "<b>" + this.DeliveryLocation.GetDescription() + "</b>");
				text = text.Replace("<WINDOW_START>", TimeManager.Get12HourTime((float)this.DeliveryWindow.WindowStartTime, true));
				text = text.Replace("<WINDOW_END>", TimeManager.Get12HourTime((float)this.DeliveryWindow.WindowEndTime, true));
				list.Add(text);
			}
			return new DialogueChain
			{
				Lines = list.ToArray()
			};
		}

		// Token: 0x0400106F RID: 4207
		public float Payment;

		// Token: 0x04001070 RID: 4208
		public ProductList Products;

		// Token: 0x04001071 RID: 4209
		public string DeliveryLocationGUID;

		// Token: 0x04001072 RID: 4210
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x04001073 RID: 4211
		public bool Expires;

		// Token: 0x04001074 RID: 4212
		public int ExpiresAfter;

		// Token: 0x04001075 RID: 4213
		public int PickupScheduleIndex;

		// Token: 0x04001076 RID: 4214
		public bool IsCounterOffer;
	}
}
