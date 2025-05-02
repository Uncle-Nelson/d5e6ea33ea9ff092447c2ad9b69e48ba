using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000788 RID: 1928
	public class BuildStart_StoredItem : BuildStart_Base
	{
		// Token: 0x06003494 RID: 13460 RVA: 0x000DB91C File Offset: 0x000D9B1C
		public override void StartBuilding(ItemInstance itemInstance)
		{
			GameObject gameObject = this.CreateGhostModel(itemInstance as StorableItemInstance);
			if (gameObject == null)
			{
				return;
			}
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			base.gameObject.GetComponent<BuildUpdate_StoredItem>().itemInstance = (itemInstance as StorableItemInstance);
			base.gameObject.GetComponent<BuildUpdate_StoredItem>().ghostModel = gameObject;
			base.gameObject.GetComponent<BuildUpdate_StoredItem>().storedItemClass = gameObject.GetComponent<StoredItem>();
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x000DB988 File Offset: 0x000D9B88
		protected virtual GameObject CreateGhostModel(StorableItemInstance item)
		{
			if (item == null)
			{
				Console.LogError("StoredItem CreateGhostModel called but item is null!", null);
				return null;
			}
			GameObject gameObject = item.StoredItem.CreateGhostModel(item, base.transform);
			StoredItem component = gameObject.GetComponent<StoredItem>();
			if (component == null)
			{
				Console.LogWarning("CreateGhostModel: asset path is not a storeableItem!", null);
				return null;
			}
			component.enabled = false;
			Singleton<BuildManager>.Instance.DisableColliders(gameObject);
			Singleton<BuildManager>.Instance.ApplyMaterial(gameObject, Singleton<BuildManager>.Instance.ghostMaterial_White, true);
			Singleton<BuildManager>.Instance.DisableSpriteRenderers(gameObject);
			component.SetFootprintTileVisiblity(false);
			return gameObject;
		}
	}
}
