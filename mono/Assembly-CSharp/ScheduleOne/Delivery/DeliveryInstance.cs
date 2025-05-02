using System;
using FishNet.Serializing.Helping;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Property;
using ScheduleOne.UI.Phone.Delivery;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Delivery
{
	// Token: 0x02000716 RID: 1814
	[Serializable]
	public class DeliveryInstance
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x000CBC20 File Offset: 0x000C9E20
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x000CBC28 File Offset: 0x000C9E28
		[CodegenExclude]
		public DeliveryVehicle ActiveVehicle { get; private set; }

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060030FB RID: 12539 RVA: 0x000CBC31 File Offset: 0x000C9E31
		[CodegenExclude]
		public Property Destination
		{
			get
			{
				return Singleton<PropertyManager>.Instance.GetProperty(this.DestinationCode);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x000CBC43 File Offset: 0x000C9E43
		[CodegenExclude]
		public LoadingDock LoadingDock
		{
			get
			{
				return this.Destination.LoadingDocks[this.LoadingDockIndex];
			}
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000CBC57 File Offset: 0x000C9E57
		public DeliveryInstance(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, StringIntPair[] items, EDeliveryStatus status, int timeUntilArrival)
		{
			this.DeliveryID = deliveryID;
			this.StoreName = storeName;
			this.DestinationCode = destinationCode;
			this.LoadingDockIndex = loadingDockIndex;
			this.Items = items;
			this.Status = status;
			this.TimeUntilArrival = timeUntilArrival;
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x0000494F File Offset: 0x00002B4F
		public DeliveryInstance()
		{
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000CBC94 File Offset: 0x000C9E94
		public int GetTimeStatus()
		{
			if (this.Status == EDeliveryStatus.Arrived)
			{
				return -1;
			}
			if (this.Status == EDeliveryStatus.Waiting)
			{
				return 0;
			}
			return this.TimeUntilArrival;
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x000CBCB4 File Offset: 0x000C9EB4
		public void SetStatus(EDeliveryStatus status)
		{
			Console.Log("Setting delivery status to " + status.ToString() + " for delivery " + this.DeliveryID, null);
			this.Status = status;
			if (this.Status == EDeliveryStatus.Arrived)
			{
				this.ActiveVehicle = NetworkSingleton<DeliveryManager>.Instance.GetShopInterface(this.StoreName).DeliveryVehicle;
				this.ActiveVehicle.Activate(this);
			}
			if (this.Status == EDeliveryStatus.Completed)
			{
				if (this.ActiveVehicle != null)
				{
					this.ActiveVehicle.Deactivate();
				}
				if (this.onDeliveryCompleted != null)
				{
					this.onDeliveryCompleted.Invoke();
				}
			}
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000CBD58 File Offset: 0x000C9F58
		public void AddItemsToDeliveryVehicle()
		{
			DeliveryVehicle deliveryVehicle = PlayerSingleton<DeliveryApp>.Instance.GetShop(this.StoreName).MatchingShop.DeliveryVehicle;
			foreach (StringIntPair stringIntPair in this.Items)
			{
				ItemDefinition item = Registry.GetItem(stringIntPair.String);
				int j = stringIntPair.Int;
				while (j > 0)
				{
					int num = Mathf.Min(j, item.StackLimit);
					j -= num;
					ItemInstance defaultInstance = Registry.GetItem(stringIntPair.String).GetDefaultInstance(num);
					deliveryVehicle.Vehicle.Storage.InsertItem(defaultInstance, true);
				}
			}
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x000CBDF3 File Offset: 0x000C9FF3
		public void OnMinPass()
		{
			this.TimeUntilArrival = Mathf.Max(0, this.TimeUntilArrival - 1);
		}

		// Token: 0x040022F9 RID: 8953
		public string DeliveryID;

		// Token: 0x040022FA RID: 8954
		public string StoreName;

		// Token: 0x040022FB RID: 8955
		public string DestinationCode;

		// Token: 0x040022FC RID: 8956
		public int LoadingDockIndex;

		// Token: 0x040022FD RID: 8957
		public StringIntPair[] Items;

		// Token: 0x040022FE RID: 8958
		public EDeliveryStatus Status;

		// Token: 0x040022FF RID: 8959
		public int TimeUntilArrival;

		// Token: 0x04002301 RID: 8961
		[CodegenExclude]
		[NonSerialized]
		public UnityEvent onDeliveryCompleted;
	}
}
