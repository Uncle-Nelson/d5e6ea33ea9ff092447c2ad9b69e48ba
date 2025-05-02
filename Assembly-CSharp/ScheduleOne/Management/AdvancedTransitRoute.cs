using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000561 RID: 1377
	public class AdvancedTransitRoute : TransitRoute
	{
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x0008A466 File Offset: 0x00088666
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x0008A46E File Offset: 0x0008866E
		public ManagementItemFilter Filter { get; private set; } = new ManagementItemFilter(ManagementItemFilter.EMode.Blacklist);

		// Token: 0x0600219C RID: 8604 RVA: 0x0008A477 File Offset: 0x00088677
		public AdvancedTransitRoute(ITransitEntity source, ITransitEntity destination) : base(source, destination)
		{
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x0008A490 File Offset: 0x00088690
		public AdvancedTransitRoute(AdvancedTransitRouteData data) : base((!string.IsNullOrEmpty(data.SourceGUID)) ? GUIDManager.GetObject<ITransitEntity>(new Guid(data.SourceGUID)) : null, (!string.IsNullOrEmpty(data.DestinationGUID)) ? GUIDManager.GetObject<ITransitEntity>(new Guid(data.DestinationGUID)) : null)
		{
			this.Filter.SetMode(data.FilterMode);
			for (int i = 0; i < data.FilterItemIDs.Count; i++)
			{
				ItemDefinition item = Registry.GetItem(data.FilterItemIDs[i]);
				if (item != null)
				{
					this.Filter.AddItem(item);
				}
			}
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0008A540 File Offset: 0x00088740
		public ItemInstance GetItemReadyToMove()
		{
			if (base.Source == null || base.Destination == null)
			{
				return null;
			}
			foreach (ItemSlot itemSlot in base.Source.OutputSlots)
			{
				if (itemSlot.ItemInstance != null && this.Filter.DoesItemMeetFilter(itemSlot.ItemInstance))
				{
					int inputCapacityForItem = base.Destination.GetInputCapacityForItem(itemSlot.ItemInstance, null);
					if (inputCapacityForItem > 0)
					{
						return itemSlot.ItemInstance.GetCopy(Mathf.Min(inputCapacityForItem, itemSlot.ItemInstance.Quantity));
					}
				}
			}
			return null;
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0008A5F8 File Offset: 0x000887F8
		public AdvancedTransitRouteData GetData()
		{
			List<string> list = new List<string>();
			foreach (ItemDefinition itemDefinition in this.Filter.Items)
			{
				list.Add(itemDefinition.ID);
			}
			string sourceGUID = string.Empty;
			string destinationGUID = string.Empty;
			if (base.Source != null)
			{
				sourceGUID = base.Source.GUID.ToString();
			}
			if (base.Destination != null)
			{
				destinationGUID = base.Destination.GUID.ToString();
			}
			return new AdvancedTransitRouteData(sourceGUID, destinationGUID, this.Filter.Mode, list);
		}
	}
}
