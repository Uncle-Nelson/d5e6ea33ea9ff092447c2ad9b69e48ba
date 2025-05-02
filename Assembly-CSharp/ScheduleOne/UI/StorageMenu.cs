using System;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using ScheduleOne.UI.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A4A RID: 2634
	public class StorageMenu : Singleton<StorageMenu>
	{
		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x00129911 File Offset: 0x00127B11
		// (set) Token: 0x06004709 RID: 18185 RVA: 0x00129919 File Offset: 0x00127B19
		public bool IsOpen { get; protected set; }

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600470A RID: 18186 RVA: 0x00129922 File Offset: 0x00127B22
		// (set) Token: 0x0600470B RID: 18187 RVA: 0x0012992A File Offset: 0x00127B2A
		public StorageEntity OpenedStorageEntity { get; protected set; }

		// Token: 0x0600470C RID: 18188 RVA: 0x00129933 File Offset: 0x00127B33
		protected override void Awake()
		{
			base.Awake();
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 3);
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x0012996A File Offset: 0x00127B6A
		public virtual void Open(IItemSlotOwner owner, string title, string subtitle)
		{
			this.IsOpen = true;
			this.OpenedStorageEntity = null;
			this.SlotGridLayout.constraintCount = 1;
			this.Open(title, subtitle, owner);
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x0012998F File Offset: 0x00127B8F
		public virtual void Open(StorageEntity entity)
		{
			this.IsOpen = true;
			this.OpenedStorageEntity = entity;
			this.SlotGridLayout.constraintCount = entity.DisplayRowCount;
			this.Open(entity.StorageEntityName, entity.StorageEntitySubtitle, entity);
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x001299C4 File Offset: 0x00127BC4
		private void Open(string title, string subtitle, IItemSlotOwner owner)
		{
			this.IsOpen = true;
			this.TitleLabel.text = title;
			this.SubtitleLabel.text = subtitle;
			for (int i = 0; i < this.SlotsUIs.Length; i++)
			{
				if (owner.ItemSlots.Count > i)
				{
					this.SlotsUIs[i].gameObject.SetActive(true);
					this.SlotsUIs[i].AssignSlot(owner.ItemSlots[i]);
				}
				else
				{
					this.SlotsUIs[i].ClearSlot();
					this.SlotsUIs[i].gameObject.SetActive(false);
				}
			}
			int constraintCount = this.SlotGridLayout.constraintCount;
			this.CloseButton.anchoredPosition = new Vector2(0f, (float)constraintCount * -this.SlotGridLayout.cellSize.y - 60f);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0.06f);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(true, true);
			Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), owner.ItemSlots.ToList<ItemSlot>());
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x00129B47 File Offset: 0x00127D47
		public void Close()
		{
			if (this.OpenedStorageEntity != null)
			{
				this.OpenedStorageEntity.Close();
				return;
			}
			this.CloseMenu();
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x00129B6C File Offset: 0x00127D6C
		public virtual void CloseMenu()
		{
			this.IsOpen = false;
			this.OpenedStorageEntity = null;
			for (int i = 0; i < this.SlotsUIs.Length; i++)
			{
				this.SlotsUIs[i].ClearSlot();
				this.SlotsUIs[i].gameObject.SetActive(false);
			}
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0.06f);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(false, true);
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			if (this.onClosed != null)
			{
				this.onClosed.Invoke();
			}
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x00129C4C File Offset: 0x00127E4C
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				if (this.OpenedStorageEntity != null)
				{
					this.OpenedStorageEntity.Close();
					return;
				}
				this.CloseMenu();
			}
		}

		// Token: 0x04003473 RID: 13427
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003474 RID: 13428
		public RectTransform Container;

		// Token: 0x04003475 RID: 13429
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04003476 RID: 13430
		public TextMeshProUGUI SubtitleLabel;

		// Token: 0x04003477 RID: 13431
		public RectTransform SlotContainer;

		// Token: 0x04003478 RID: 13432
		public ItemSlotUI[] SlotsUIs;

		// Token: 0x04003479 RID: 13433
		public GridLayoutGroup SlotGridLayout;

		// Token: 0x0400347A RID: 13434
		public RectTransform CloseButton;

		// Token: 0x0400347B RID: 13435
		public UnityEvent onClosed;
	}
}
