using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000959 RID: 2393
	[CreateAssetMenu(fileName = "StorableItemDefinition", menuName = "ScriptableObjects/StorableItemDefinition", order = 1)]
	[Serializable]
	public class StorableItemDefinition : ItemDefinition
	{
		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060040D2 RID: 16594 RVA: 0x00110150 File Offset: 0x0010E350
		public bool IsPurchasable
		{
			get
			{
				return !this.RequiresLevelToPurchase || NetworkSingleton<LevelManager>.Instance.GetFullRank() >= this.RequiredRank;
			}
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x00110171 File Offset: 0x0010E371
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return new StorableItemInstance(this, quantity);
		}

		// Token: 0x04002E68 RID: 11880
		[Header("Purchasing")]
		public float BasePurchasePrice = 10f;

		// Token: 0x04002E69 RID: 11881
		public List<ShopListing.CategoryInstance> ShopCategories = new List<ShopListing.CategoryInstance>();

		// Token: 0x04002E6A RID: 11882
		public bool RequiresLevelToPurchase;

		// Token: 0x04002E6B RID: 11883
		public FullRank RequiredRank;

		// Token: 0x04002E6C RID: 11884
		[Header("Reselling")]
		[Range(0f, 1f)]
		public float ResellMultiplier = 0.5f;

		// Token: 0x04002E6D RID: 11885
		[Header("Storable Item")]
		public StoredItem StoredItem;

		// Token: 0x04002E6E RID: 11886
		[Tooltip("Optional station item if this item can be used at a station.")]
		public StationItem StationItem;
	}
}
