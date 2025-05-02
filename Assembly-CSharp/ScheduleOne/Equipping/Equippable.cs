using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200091D RID: 2333
	public class Equippable : MonoBehaviour
	{
		// Token: 0x06003F1F RID: 16159 RVA: 0x0010A642 File Offset: 0x00108842
		public virtual void Equip(ItemInstance item)
		{
			this.itemInstance = item;
			PlayerSingleton<PlayerInventory>.Instance.SetEquippable(this);
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x0010A656 File Offset: 0x00108856
		public virtual void Unequip()
		{
			PlayerSingleton<PlayerInventory>.Instance.SetEquippable(null);
			Object.Destroy(base.gameObject);
		}

		// Token: 0x04002D4D RID: 11597
		protected ItemInstance itemInstance;

		// Token: 0x04002D4E RID: 11598
		public bool CanInteractWhenEquipped = true;

		// Token: 0x04002D4F RID: 11599
		public bool CanPickUpWhenEquipped = true;
	}
}
