using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Audio;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	// Token: 0x02000AB1 RID: 2737
	public class DeliveryApp : App<DeliveryApp>
	{
		// Token: 0x0600499F RID: 18847 RVA: 0x0013488A File Offset: 0x00132A8A
		protected override void Awake()
		{
			base.Awake();
			this.deliveryShops = base.GetComponentsInChildren<DeliveryShop>(true).ToList<DeliveryShop>();
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x001348A4 File Offset: 0x00132AA4
		protected override void Start()
		{
			base.Start();
			if (!this.started)
			{
				this.started = true;
				NetworkSingleton<DeliveryManager>.Instance.onDeliveryCreated.AddListener(new UnityAction<DeliveryInstance>(this.CreateDeliveryStatusDisplay));
				NetworkSingleton<DeliveryManager>.Instance.onDeliveryCompleted.AddListener(new UnityAction<DeliveryInstance>(this.DeliveryCompleted));
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.OnMinPass));
				for (int i = 0; i < NetworkSingleton<DeliveryManager>.Instance.Deliveries.Count; i++)
				{
					this.CreateDeliveryStatusDisplay(NetworkSingleton<DeliveryManager>.Instance.Deliveries[i]);
				}
			}
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x00134955 File Offset: 0x00132B55
		protected override void Update()
		{
			base.Update();
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x00134960 File Offset: 0x00132B60
		public override void SetOpen(bool open)
		{
			base.SetOpen(open);
			if (open)
			{
				foreach (DeliveryShop deliveryShop in this.deliveryShops)
				{
					deliveryShop.RefreshShop();
				}
				foreach (DeliveryStatusDisplay deliveryStatusDisplay in this.statusDisplays)
				{
					deliveryStatusDisplay.RefreshStatus();
				}
				if (this.MainScrollRect.verticalNormalizedPosition > 1f)
				{
					this.MainScrollRect.verticalNormalizedPosition = 1f;
				}
				this.OrderSubmittedAnim.GetComponent<CanvasGroup>().alpha = 0f;
			}
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x00134A34 File Offset: 0x00132C34
		private void OnMinPass()
		{
			if (!base.isOpen)
			{
				return;
			}
			foreach (DeliveryStatusDisplay deliveryStatusDisplay in this.statusDisplays)
			{
				deliveryStatusDisplay.RefreshStatus();
			}
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x00134A90 File Offset: 0x00132C90
		public void RefreshContent(bool keepScrollPosition = true)
		{
			DeliveryApp.<>c__DisplayClass15_0 CS$<>8__locals1 = new DeliveryApp.<>c__DisplayClass15_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.keepScrollPosition = keepScrollPosition;
			CS$<>8__locals1.scrollPos = this.MainScrollRect.verticalNormalizedPosition;
			base.StartCoroutine(CS$<>8__locals1.<RefreshContent>g__Delay|0());
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x00134ACF File Offset: 0x00132CCF
		public void PlayOrderSubmittedAnim()
		{
			this.OrderSubmittedAnim.Play();
			this.OrderSubmittedSound.Play();
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x00134AE8 File Offset: 0x00132CE8
		private void CreateDeliveryStatusDisplay(DeliveryInstance instance)
		{
			DeliveryStatusDisplay deliveryStatusDisplay = Object.Instantiate<DeliveryStatusDisplay>(this.StatusDisplayPrefab, this.StatusDisplayContainer);
			deliveryStatusDisplay.AssignDelivery(instance);
			this.statusDisplays.Add(deliveryStatusDisplay);
			this.SortStatusDisplays();
			this.RefreshContent(true);
			this.RefreshNoDeliveriesIndicator();
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x00134B30 File Offset: 0x00132D30
		private void DeliveryCompleted(DeliveryInstance instance)
		{
			DeliveryStatusDisplay deliveryStatusDisplay = this.statusDisplays.FirstOrDefault((DeliveryStatusDisplay d) => d.DeliveryInstance.DeliveryID == instance.DeliveryID);
			if (deliveryStatusDisplay != null)
			{
				this.statusDisplays.Remove(deliveryStatusDisplay);
				Object.Destroy(deliveryStatusDisplay.gameObject);
			}
			this.RefreshNoDeliveriesIndicator();
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x00134B8C File Offset: 0x00132D8C
		private void SortStatusDisplays()
		{
			this.statusDisplays = (from d in this.statusDisplays
			orderby d.DeliveryInstance.GetTimeStatus()
			select d).ToList<DeliveryStatusDisplay>();
			for (int i = 0; i < this.statusDisplays.Count; i++)
			{
				this.statusDisplays[i].transform.SetSiblingIndex(i);
			}
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x00134BFB File Offset: 0x00132DFB
		private void RefreshNoDeliveriesIndicator()
		{
			this.NoDeliveriesIndicator.gameObject.SetActive(this.statusDisplays.Count == 0);
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x00134C1C File Offset: 0x00132E1C
		public static void RefreshLayoutGroupsImmediateAndRecursive(GameObject root)
		{
			LayoutGroup[] componentsInChildren = root.GetComponentsInChildren<LayoutGroup>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				LayoutRebuilder.ForceRebuildLayoutImmediate(componentsInChildren[i].GetComponent<RectTransform>());
			}
			LayoutRebuilder.ForceRebuildLayoutImmediate(root.GetComponent<LayoutGroup>().GetComponent<RectTransform>());
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x00134C5C File Offset: 0x00132E5C
		public DeliveryShop GetShop(ShopInterface matchingShop)
		{
			return this.deliveryShops.Find((DeliveryShop x) => x.MatchingShop == matchingShop);
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x00134C90 File Offset: 0x00132E90
		public DeliveryShop GetShop(string shopName)
		{
			return this.deliveryShops.Find((DeliveryShop x) => x.MatchingShop.ShopName == shopName);
		}

		// Token: 0x040036BF RID: 14015
		private List<DeliveryShop> deliveryShops = new List<DeliveryShop>();

		// Token: 0x040036C0 RID: 14016
		public DeliveryStatusDisplay StatusDisplayPrefab;

		// Token: 0x040036C1 RID: 14017
		[Header("References")]
		public Animation OrderSubmittedAnim;

		// Token: 0x040036C2 RID: 14018
		public AudioSourceController OrderSubmittedSound;

		// Token: 0x040036C3 RID: 14019
		public RectTransform StatusDisplayContainer;

		// Token: 0x040036C4 RID: 14020
		public RectTransform NoDeliveriesIndicator;

		// Token: 0x040036C5 RID: 14021
		public ScrollRect MainScrollRect;

		// Token: 0x040036C6 RID: 14022
		public LayoutGroup MainLayoutGroup;

		// Token: 0x040036C7 RID: 14023
		private List<DeliveryStatusDisplay> statusDisplays = new List<DeliveryStatusDisplay>();

		// Token: 0x040036C8 RID: 14024
		private bool started;
	}
}
