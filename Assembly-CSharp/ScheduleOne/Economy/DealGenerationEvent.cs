using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Money;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x02000672 RID: 1650
	[Serializable]
	public class DealGenerationEvent
	{
		// Token: 0x06002D8D RID: 11661 RVA: 0x000BE8C4 File Offset: 0x000BCAC4
		public ContractInfo GenerateContractInfo(Customer customer)
		{
			return new ContractInfo(this.Payment, this.ProductList, this.DeliveryLocation.GUID.ToString(), this.DeliveryWindow, this.Expires, this.ExpiresAfter, this.PickupScheduleGroup, false);
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x000BE914 File Offset: 0x000BCB14
		public bool ShouldGenerate(Customer customer)
		{
			if (customer.NPC.RelationData.RelationDelta < this.RelationshipRequirement)
			{
				return false;
			}
			return this.ApplicableDays.Exists((DealGenerationEvent.DayContainer x) => x.Day == NetworkSingleton<TimeManager>.Instance.CurrentDay) && NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.GenerationTime, TimeManager.AddMinutesTo24HourTime(this.GenerationTime, this.GenerationWindowDuration));
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x000BE98F File Offset: 0x000BCB8F
		public MessageChain GetRandomRequestMessage()
		{
			return this.ProcessMessage(this.RequestMessageChains[Random.Range(0, this.RequestMessageChains.Length - 1)]);
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x000BE9B0 File Offset: 0x000BCBB0
		public MessageChain ProcessMessage(MessageChain messageChain)
		{
			MessageChain messageChain2 = new MessageChain();
			foreach (string text in messageChain.Messages)
			{
				string text2 = text.Replace("<PRICE>", "<color=#46CB4F>" + MoneyManager.FormatAmount(this.Payment, false, false) + "</color>");
				text2 = text2.Replace("<PRODUCT>", this.GetProductStringList());
				text2 = text2.Replace("<QUALITY>", this.GetQualityString());
				text2 = text2.Replace("<LOCATION>", this.DeliveryLocation.GetDescription());
				text2 = text2.Replace("<WINDOW_START>", TimeManager.Get12HourTime((float)this.DeliveryWindow.WindowStartTime, true));
				text2 = text2.Replace("<WINDOW_END>", TimeManager.Get12HourTime((float)this.DeliveryWindow.WindowEndTime, true));
				messageChain2.Messages.Add(text2);
			}
			return messageChain2;
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000BEAB4 File Offset: 0x000BCCB4
		public MessageChain GetRejectionMessage()
		{
			return this.ProcessMessage(this.ContractRejectedResponses[Random.Range(0, this.ContractRejectedResponses.Length - 1)]);
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x000BEAD3 File Offset: 0x000BCCD3
		public MessageChain GetAcceptanceMessage()
		{
			return this.ProcessMessage(this.ContractAcceptedResponses[Random.Range(0, this.ContractAcceptedResponses.Length - 1)]);
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x000BEAF2 File Offset: 0x000BCCF2
		public string GetProductStringList()
		{
			return this.ProductList.GetCommaSeperatedString();
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000BEAFF File Offset: 0x000BCCFF
		public string GetQualityString()
		{
			return this.ProductList.GetQualityString();
		}

		// Token: 0x04002040 RID: 8256
		[Header("Settings")]
		public bool Enabled = true;

		// Token: 0x04002041 RID: 8257
		public bool CanBeAccepted = true;

		// Token: 0x04002042 RID: 8258
		public bool CanBeRejected = true;

		// Token: 0x04002043 RID: 8259
		[Header("Timing Settings")]
		public List<DealGenerationEvent.DayContainer> ApplicableDays = new List<DealGenerationEvent.DayContainer>();

		// Token: 0x04002044 RID: 8260
		public int GenerationTime;

		// Token: 0x04002045 RID: 8261
		public int GenerationWindowDuration = 60;

		// Token: 0x04002046 RID: 8262
		[Header("Products and payment")]
		public ProductList ProductList;

		// Token: 0x04002047 RID: 8263
		public float Payment = 100f;

		// Token: 0x04002048 RID: 8264
		[Range(0f, 5f)]
		public float RelationshipRequirement = 1f;

		// Token: 0x04002049 RID: 8265
		[Header("Messages")]
		[SerializeField]
		private MessageChain[] RequestMessageChains;

		// Token: 0x0400204A RID: 8266
		public MessageChain[] ContractAcceptedResponses;

		// Token: 0x0400204B RID: 8267
		public MessageChain[] ContractRejectedResponses;

		// Token: 0x0400204C RID: 8268
		[Header("Location settings")]
		public DeliveryLocation DeliveryLocation;

		// Token: 0x0400204D RID: 8269
		public int PickupScheduleGroup;

		// Token: 0x0400204E RID: 8270
		[Header("Window/expiry settings")]
		public QuestWindowConfig DeliveryWindow;

		// Token: 0x0400204F RID: 8271
		public bool Expires = true;

		// Token: 0x04002050 RID: 8272
		[Tooltip("How many days after being accepted does this contract expire? Exact expiry is adjusted to match window end")]
		[Range(1f, 7f)]
		public int ExpiresAfter = 2;

		// Token: 0x02000673 RID: 1651
		[Serializable]
		public class DayContainer
		{
			// Token: 0x04002051 RID: 8273
			public EDay Day;
		}
	}
}
