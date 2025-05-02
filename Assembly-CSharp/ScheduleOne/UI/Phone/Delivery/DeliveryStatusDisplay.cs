using System;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	// Token: 0x02000AB9 RID: 2745
	public class DeliveryStatusDisplay : MonoBehaviour
	{
		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060049DE RID: 18910 RVA: 0x001358AD File Offset: 0x00133AAD
		// (set) Token: 0x060049DF RID: 18911 RVA: 0x001358B5 File Offset: 0x00133AB5
		public DeliveryInstance DeliveryInstance { get; private set; }

		// Token: 0x060049E0 RID: 18912 RVA: 0x001358C0 File Offset: 0x00133AC0
		public void AssignDelivery(DeliveryInstance instance)
		{
			this.DeliveryInstance = instance;
			this.DestinationLabel.text = this.DeliveryInstance.Destination.PropertyName + " [" + (this.DeliveryInstance.LoadingDockIndex + 1).ToString() + "]";
			this.ShopLabel.text = this.DeliveryInstance.StoreName;
			foreach (StringIntPair stringIntPair in this.DeliveryInstance.Items)
			{
				Transform component = Object.Instantiate<GameObject>(this.ItemEntryPrefab, this.ItemEntryContainer).GetComponent<RectTransform>();
				ItemDefinition item = Registry.GetItem(stringIntPair.String);
				component.Find("Label").GetComponent<Text>().text = stringIntPair.Int.ToString() + "x " + item.Name;
			}
			int num = Mathf.CeilToInt((float)this.DeliveryInstance.Items.Length / 2f);
			this.Rect.sizeDelta = new Vector2(this.Rect.sizeDelta.x, (float)(70 + 20 * num));
			this.RefreshStatus();
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x001359E4 File Offset: 0x00133BE4
		public void RefreshStatus()
		{
			if (this.DeliveryInstance.Status == EDeliveryStatus.InTransit)
			{
				this.StatusImage.color = this.StatusColor_Transit;
				int timeUntilArrival = this.DeliveryInstance.TimeUntilArrival;
				int num = timeUntilArrival / 60;
				int num2 = timeUntilArrival % 60;
				this.StatusLabel.text = num.ToString() + "h " + num2.ToString() + "m";
				this.StatusTooltip.text = "This delivery is currently in transit.";
				return;
			}
			if (this.DeliveryInstance.Status == EDeliveryStatus.Waiting)
			{
				this.StatusImage.color = this.StatusColor_Waiting;
				this.StatusLabel.text = "Waiting";
				this.StatusTooltip.text = "This delivery is waiting for the loading dock " + (this.DeliveryInstance.LoadingDockIndex + 1).ToString() + " to be empty.";
				return;
			}
			if (this.DeliveryInstance.Status == EDeliveryStatus.Arrived)
			{
				this.StatusImage.color = this.StatusColor_Arrived;
				this.StatusLabel.text = "Arrived";
				this.StatusTooltip.text = "This delivery has arrived and is ready to be unloaded.";
			}
		}

		// Token: 0x040036F1 RID: 14065
		public GameObject ItemEntryPrefab;

		// Token: 0x040036F2 RID: 14066
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x040036F3 RID: 14067
		public Text DestinationLabel;

		// Token: 0x040036F4 RID: 14068
		public Text ShopLabel;

		// Token: 0x040036F5 RID: 14069
		public Image StatusImage;

		// Token: 0x040036F6 RID: 14070
		public Text StatusLabel;

		// Token: 0x040036F7 RID: 14071
		public Tooltip StatusTooltip;

		// Token: 0x040036F8 RID: 14072
		public RectTransform ItemEntryContainer;

		// Token: 0x040036F9 RID: 14073
		[Header("Settings")]
		public Color StatusColor_Transit;

		// Token: 0x040036FA RID: 14074
		public Color StatusColor_Waiting;

		// Token: 0x040036FB RID: 14075
		public Color StatusColor_Arrived;
	}
}
