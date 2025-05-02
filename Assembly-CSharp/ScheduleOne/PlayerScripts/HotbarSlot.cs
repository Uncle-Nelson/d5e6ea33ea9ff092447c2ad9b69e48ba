using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005D4 RID: 1492
	public class HotbarSlot : ItemSlot
	{
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x00094D55 File Offset: 0x00092F55
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x00094D5D File Offset: 0x00092F5D
		public bool IsEquipped { get; protected set; }

		// Token: 0x060024EC RID: 9452 RVA: 0x00094D68 File Offset: 0x00092F68
		public override void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			if ((_internal || base.SlotOwner == null) && this.IsEquipped && this.Equippable != null)
			{
				this.Equippable.Unequip();
				this.Equippable = null;
			}
			base.SetStoredItem(instance, _internal);
			if ((_internal || base.SlotOwner == null) && this.IsEquipped && instance != null && instance.Equippable != null)
			{
				if (PlayerSingleton<PlayerInventory>.Instance.onPreItemEquipped != null)
				{
					PlayerSingleton<PlayerInventory>.Instance.onPreItemEquipped.Invoke();
				}
				this.Equippable = Object.Instantiate<GameObject>(instance.Equippable.gameObject, PlayerSingleton<PlayerInventory>.Instance.equipContainer).GetComponent<Equippable>();
				this.Equippable.Equip(instance);
			}
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00094E20 File Offset: 0x00093020
		public override void ClearStoredInstance(bool _internal = false)
		{
			if ((_internal || base.SlotOwner == null) && this.IsEquipped && this.Equippable != null)
			{
				this.Equippable.Unequip();
				this.Equippable = null;
			}
			base.ClearStoredInstance(_internal);
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00094E5C File Offset: 0x0009305C
		public virtual void Equip()
		{
			this.IsEquipped = true;
			if (base.ItemInstance != null && base.ItemInstance.Equippable != null)
			{
				if (PlayerSingleton<PlayerInventory>.Instance.onPreItemEquipped != null)
				{
					PlayerSingleton<PlayerInventory>.Instance.onPreItemEquipped.Invoke();
				}
				this.Equippable = Object.Instantiate<GameObject>(base.ItemInstance.Equippable.gameObject, PlayerSingleton<PlayerInventory>.Instance.equipContainer).GetComponent<Equippable>();
				this.Equippable.Equip(base.ItemInstance);
			}
			if (this.onEquipChanged != null)
			{
				this.onEquipChanged(true);
			}
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00094EF5 File Offset: 0x000930F5
		public virtual void Unequip()
		{
			if (this.Equippable != null)
			{
				this.Equippable.Unequip();
				this.Equippable = null;
			}
			this.IsEquipped = false;
			if (this.onEquipChanged != null)
			{
				this.onEquipChanged(false);
			}
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x000141BA File Offset: 0x000123BA
		public override bool CanSlotAcceptCash()
		{
			return false;
		}

		// Token: 0x04001B80 RID: 7040
		public Equippable Equippable;

		// Token: 0x04001B81 RID: 7041
		public HotbarSlot.EquipEvent onEquipChanged;

		// Token: 0x020005D5 RID: 1493
		// (Invoke) Token: 0x060024F3 RID: 9459
		public delegate void EquipEvent(bool equipped);
	}
}
