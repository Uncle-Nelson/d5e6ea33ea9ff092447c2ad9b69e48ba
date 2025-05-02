using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008B2 RID: 2226
	public class StorageVisualizer : MonoBehaviour
	{
		// Token: 0x06003C80 RID: 15488 RVA: 0x000FEC78 File Offset: 0x000FCE78
		protected virtual void Awake()
		{
			for (int i = 0; i < this.StorageGrids.Length; i++)
			{
				this.totalFootprintCapacity += this.StorageGrids[i].GetTotalFootprintSize();
			}
			this.RefreshVisuals();
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x000FECB8 File Offset: 0x000FCEB8
		protected virtual void FixedUpdate()
		{
			if (Singleton<LoadManager>.InstanceExists && Singleton<LoadManager>.Instance.IsLoading)
			{
				return;
			}
			if (this.updateVisuals)
			{
				this.updateVisuals = false;
				if (this.BlockRefreshes)
				{
					return;
				}
				this.RefreshVisuals();
			}
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x000FECEC File Offset: 0x000FCEEC
		public void AddSlot(ItemSlot slot, bool update = false)
		{
			if (!this.itemSlots.Contains(slot))
			{
				this.itemSlots.Add(slot);
				slot.onItemDataChanged = (Action)Delegate.Combine(slot.onItemDataChanged, new Action(delegate()
				{
					this.updateVisuals = true;
				}));
			}
			if (update)
			{
				this.updateVisuals = true;
			}
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x000FED3F File Offset: 0x000FCF3F
		public Dictionary<StorableItemInstance, int> GetVisualRepresentation()
		{
			return StorageVisualizationUtility.GetVisualRepresentation(this.GetContentsDictionary(), this.totalFootprintCapacity);
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x000FED54 File Offset: 0x000FCF54
		public virtual void RefreshVisuals()
		{
			Dictionary<StorableItemInstance, int> visualRepresentation = this.GetVisualRepresentation();
			List<StorableItemInstance> list = visualRepresentation.Keys.ToList<StorableItemInstance>();
			List<StorableItemInstance> list2 = this.activeStoredItems.Keys.ToList<StorableItemInstance>();
			for (int i = 0; i < list2.Count; i++)
			{
				int quantityRequirement = 0;
				if (visualRepresentation.ContainsKey(list2[i]))
				{
					quantityRequirement = visualRepresentation[list2[i]];
				}
				this.DestroyExcessStoredItems(list2[i], quantityRequirement);
			}
			int num = 0;
			for (int j = 0; j < list.Count; j++)
			{
				num += this.EnsureSufficientStoredItems(list[j], visualRepresentation[list[j]]).Count;
			}
			List<StoredItem> list3 = new List<StoredItem>();
			if (num > 0 || num == 0 || this.FullRefreshOnItemRemoved)
			{
				foreach (StorableItemInstance key in list)
				{
					for (int k = 0; k < this.activeStoredItems[key].Count; k++)
					{
						this.activeStoredItems[key][k].ClearFootprintOccupancy();
					}
				}
				foreach (StorableItemInstance storableItemInstance in list)
				{
					List<StoredItem> list4 = this.activeStoredItems[storableItemInstance];
					int num2 = list4[0].FootprintX * list4[0].FootprintY;
					List<StoredItem> list5 = new List<StoredItem>();
					list5.AddRange(list4);
					foreach (StoredItem storedItem in list4)
					{
						bool flag = false;
						for (int l = 0; l < this.StorageGrids.Length; l++)
						{
							Coordinate c;
							float rotation;
							if (this.StorageGrids[l].freeTiles.Count >= num2 && this.StorageGrids[l].TryFitItem(storedItem.FootprintX, storedItem.FootprintY, new List<Coordinate>(), out c, out rotation))
							{
								storedItem.InitializeStoredItem(storableItemInstance, this.StorageGrids[l], c, rotation);
								list5.Remove(storedItem);
								flag = true;
								break;
							}
						}
						if (!flag)
						{
							break;
						}
					}
					list3.AddRange(list5);
				}
			}
			if (list3.Count > 0)
			{
				Console.LogWarning("Failed to fit " + list3.Count.ToString() + " stored items into the storage entity. Deleting them.", null);
				for (int m = 0; m < list3.Count; m++)
				{
					if (!(list3[m] == null))
					{
						Object.Destroy(list3[m].gameObject);
					}
				}
			}
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x000FF070 File Offset: 0x000FD270
		private List<StoredItem> EnsureSufficientStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			int num = 0;
			if (this.activeStoredItems.ContainsKey(item))
			{
				num = this.activeStoredItems[item].Count;
			}
			List<StoredItem> list = new List<StoredItem>();
			if (num < quantityRequirement)
			{
				if (!this.activeStoredItems.ContainsKey(item))
				{
					this.activeStoredItems.Add(item, new List<StoredItem>());
				}
				int num2 = quantityRequirement - num;
				for (int i = 0; i < num2; i++)
				{
					StoredItem component = Object.Instantiate<StoredItem>(item.StoredItem, (this.ItemContainer != null) ? this.ItemContainer : base.transform).GetComponent<StoredItem>();
					component.transform.localScale = Vector3.one;
					this.activeStoredItems[item].Add(component);
					list.Add(component);
					Collider[] componentsInChildren = component.GetComponentsInChildren<Collider>();
					for (int j = 0; j < componentsInChildren.Length; j++)
					{
						componentsInChildren[j].enabled = false;
					}
				}
			}
			return list;
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x000FF164 File Offset: 0x000FD364
		private void DestroyExcessStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			int num = 0;
			if (this.activeStoredItems.ContainsKey(item))
			{
				num = this.activeStoredItems[item].Count;
			}
			if (num > quantityRequirement)
			{
				int num2 = num - quantityRequirement;
				for (int i = 0; i < num2; i++)
				{
					this.activeStoredItems[item][this.activeStoredItems[item].Count - 1].DestroyStoredItem();
					this.activeStoredItems[item].RemoveAt(this.activeStoredItems[item].Count - 1);
				}
			}
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x000FF1F4 File Offset: 0x000FD3F4
		public Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			Dictionary<StorableItemInstance, int> dictionary = new Dictionary<StorableItemInstance, int>();
			for (int i = 0; i < this.itemSlots.Count; i++)
			{
				if (this.itemSlots[i].ItemInstance != null && this.itemSlots[i].ItemInstance is StorableItemInstance && this.itemSlots[i].Quantity > 0 && !dictionary.ContainsKey(this.itemSlots[i].ItemInstance as StorableItemInstance))
				{
					dictionary.Add(this.itemSlots[i].ItemInstance as StorableItemInstance, this.itemSlots[i].Quantity);
				}
			}
			return dictionary;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x000FF2AE File Offset: 0x000FD4AE
		protected void QueueRefresh()
		{
			this.updateVisuals = true;
		}

		// Token: 0x04002B7D RID: 11133
		[Header("References")]
		public StorageGrid[] StorageGrids;

		// Token: 0x04002B7E RID: 11134
		public Transform ItemContainer;

		// Token: 0x04002B7F RID: 11135
		[Header("Settings")]
		[Tooltip("Should storage visuals be fully recalculated when item(s) are removed?")]
		public bool FullRefreshOnItemRemoved;

		// Token: 0x04002B80 RID: 11136
		protected List<ItemSlot> itemSlots = new List<ItemSlot>();

		// Token: 0x04002B81 RID: 11137
		protected int totalFootprintCapacity;

		// Token: 0x04002B82 RID: 11138
		protected Dictionary<StorableItemInstance, List<StoredItem>> activeStoredItems = new Dictionary<StorableItemInstance, List<StoredItem>>();

		// Token: 0x04002B83 RID: 11139
		public bool BlockRefreshes;

		// Token: 0x04002B84 RID: 11140
		protected bool updateVisuals;
	}
}
