using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009FD RID: 2557
	public class ItemSlotUI : MonoBehaviour
	{
		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x001204D3 File Offset: 0x0011E6D3
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x001204DB File Offset: 0x0011E6DB
		public ItemSlot assignedSlot { get; protected set; }

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x001204E4 File Offset: 0x0011E6E4
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x001204EC File Offset: 0x0011E6EC
		public ItemUI ItemUI { get; protected set; }

		// Token: 0x060044E4 RID: 17636 RVA: 0x001204F8 File Offset: 0x0011E6F8
		public virtual void AssignSlot(ItemSlot s)
		{
			if (s == null)
			{
				Console.LogWarning("AssignSlot passed null slot. Use ClearSlot() instead", null);
			}
			this.assignedSlot = s;
			ItemSlot assignedSlot = this.assignedSlot;
			assignedSlot.onItemInstanceChanged = (Action)Delegate.Combine(assignedSlot.onItemInstanceChanged, new Action(this.UpdateUI));
			ItemSlot assignedSlot2 = this.assignedSlot;
			assignedSlot2.onLocked = (Action)Delegate.Combine(assignedSlot2.onLocked, new Action(this.Lock));
			ItemSlot assignedSlot3 = this.assignedSlot;
			assignedSlot3.onUnlocked = (Action)Delegate.Combine(assignedSlot3.onUnlocked, new Action(this.Unlock));
			this.SetHighlighted(false);
			if (this.assignedSlot is HotbarSlot)
			{
				HotbarSlot hotbarSlot = this.assignedSlot as HotbarSlot;
				hotbarSlot.onEquipChanged = (HotbarSlot.EquipEvent)Delegate.Combine(hotbarSlot.onEquipChanged, new HotbarSlot.EquipEvent(this.SetHighlighted));
			}
			if (s.IsLocked)
			{
				this.SetLockVisible(true);
			}
			this.UpdateUI();
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x001205E8 File Offset: 0x0011E7E8
		public virtual void ClearSlot()
		{
			if (this.assignedSlot != null)
			{
				ItemSlot assignedSlot = this.assignedSlot;
				assignedSlot.onItemInstanceChanged = (Action)Delegate.Remove(assignedSlot.onItemInstanceChanged, new Action(this.UpdateUI));
				ItemSlot assignedSlot2 = this.assignedSlot;
				assignedSlot2.onLocked = (Action)Delegate.Remove(assignedSlot2.onLocked, new Action(this.Lock));
				ItemSlot assignedSlot3 = this.assignedSlot;
				assignedSlot3.onUnlocked = (Action)Delegate.Remove(assignedSlot3.onUnlocked, new Action(this.Unlock));
				if (this.assignedSlot is HotbarSlot)
				{
					HotbarSlot hotbarSlot = this.assignedSlot as HotbarSlot;
					hotbarSlot.onEquipChanged = (HotbarSlot.EquipEvent)Delegate.Remove(hotbarSlot.onEquipChanged, new HotbarSlot.EquipEvent(this.SetHighlighted));
				}
				this.assignedSlot = null;
				this.SetLockVisible(false);
				this.UpdateUI();
			}
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x001206C3 File Offset: 0x0011E8C3
		public void OnDestroy()
		{
			if (this.assignedSlot != null)
			{
				ItemSlot assignedSlot = this.assignedSlot;
				assignedSlot.onItemInstanceChanged = (Action)Delegate.Remove(assignedSlot.onItemInstanceChanged, new Action(this.UpdateUI));
			}
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x001206F8 File Offset: 0x0011E8F8
		public virtual void UpdateUI()
		{
			if (this.ItemUI != null)
			{
				this.ItemUI.Destroy();
				this.ItemUI = null;
			}
			if (this.assignedSlot != null && this.assignedSlot.ItemInstance != null)
			{
				ItemUI original = Singleton<ItemUIManager>.Instance.DefaultItemUIPrefab;
				if (this.assignedSlot.ItemInstance.Definition.CustomItemUI != null)
				{
					original = this.assignedSlot.ItemInstance.Definition.CustomItemUI;
				}
				this.ItemUI = Object.Instantiate<ItemUI>(original, this.ItemContainer).GetComponent<ItemUI>();
				this.ItemUI.transform.SetAsLastSibling();
				this.ItemUI.Setup(this.assignedSlot.ItemInstance);
			}
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x001207B8 File Offset: 0x0011E9B8
		public void SetHighlighted(bool h)
		{
			if (h)
			{
				this.Background.color = this.highlightColor;
				return;
			}
			this.Background.color = this.normalColor;
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x001207EA File Offset: 0x0011E9EA
		public void SetNormalColor(Color color)
		{
			this.normalColor = color;
			this.SetHighlighted(false);
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x001207FF File Offset: 0x0011E9FF
		public void SetHighlightColor(Color color)
		{
			this.highlightColor = color;
			this.SetHighlighted(false);
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x00120814 File Offset: 0x0011EA14
		private void Lock()
		{
			this.SetLockVisible(true);
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x0012081D File Offset: 0x0011EA1D
		private void Unlock()
		{
			this.SetLockVisible(false);
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00120826 File Offset: 0x0011EA26
		public void SetLockVisible(bool vis)
		{
			this.LockContainer.gameObject.SetActive(vis);
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00120839 File Offset: 0x0011EA39
		public RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			if (this.ItemUI == null)
			{
				return null;
			}
			return this.ItemUI.DuplicateIcon(parent, overriddenQuantity);
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00120858 File Offset: 0x0011EA58
		public void SetVisible(bool shown)
		{
			if (this.ItemUI != null)
			{
				this.ItemUI.SetVisible(shown);
			}
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00120874 File Offset: 0x0011EA74
		public void OverrideDisplayedQuantity(int quantity)
		{
			if (this.ItemUI == null)
			{
				return;
			}
			this.ItemUI.SetDisplayedQuantity(quantity);
		}

		// Token: 0x04003266 RID: 12902
		public Color32 normalColor = new Color32(140, 140, 140, 40);

		// Token: 0x04003267 RID: 12903
		public Color32 highlightColor = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 60);

		// Token: 0x04003269 RID: 12905
		[HideInInspector]
		public bool IsBeingDragged;

		// Token: 0x0400326A RID: 12906
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x0400326B RID: 12907
		public Image Background;

		// Token: 0x0400326C RID: 12908
		public GameObject LockContainer;

		// Token: 0x0400326D RID: 12909
		public RectTransform ItemContainer;
	}
}
