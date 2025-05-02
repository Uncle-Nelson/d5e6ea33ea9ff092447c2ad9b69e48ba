using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000785 RID: 1925
	public class BuildStart_Cash : BuildStart_StoredItem
	{
		// Token: 0x0600348C RID: 13452 RVA: 0x000DB58C File Offset: 0x000D978C
		public override void StartBuilding(ItemInstance itemInstance)
		{
			GameObject gameObject = this.CreateGhostModel(itemInstance as StorableItemInstance);
			if (gameObject == null)
			{
				return;
			}
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			base.gameObject.GetComponent<BuildUpdate_Cash>().itemInstance = (itemInstance as StorableItemInstance);
			base.gameObject.GetComponent<BuildUpdate_Cash>().ghostModel = gameObject;
			base.gameObject.GetComponent<BuildUpdate_Cash>().storedItemClass = gameObject.GetComponent<StoredItem>();
		}
	}
}
