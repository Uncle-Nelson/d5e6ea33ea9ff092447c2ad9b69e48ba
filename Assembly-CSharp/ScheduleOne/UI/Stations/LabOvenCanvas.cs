using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000A70 RID: 2672
	public class LabOvenCanvas : Singleton<LabOvenCanvas>
	{
		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060047EF RID: 18415 RVA: 0x0012D9DB File Offset: 0x0012BBDB
		// (set) Token: 0x060047F0 RID: 18416 RVA: 0x0012D9E3 File Offset: 0x0012BBE3
		public bool isOpen { get; protected set; }

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x0012D9EC File Offset: 0x0012BBEC
		// (set) Token: 0x060047F2 RID: 18418 RVA: 0x0012D9F4 File Offset: 0x0012BBF4
		public LabOven Oven { get; protected set; }

		// Token: 0x060047F3 RID: 18419 RVA: 0x0012D9FD File Offset: 0x0012BBFD
		protected override void Awake()
		{
			base.Awake();
			this.BeginButton.onClick.AddListener(new UnityAction(this.BeginButtonPressed));
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x0012DA21 File Offset: 0x0012BC21
		protected override void Start()
		{
			base.Start();
			this.SetIsOpen(null, false, true);
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x0012DA34 File Offset: 0x0012BC34
		protected virtual void Update()
		{
			if (this.isOpen)
			{
				this.BeginButton.interactable = this.CanBegin();
				if (this.BeginButton.interactable && GameInput.GetButtonDown(GameInput.ButtonCode.Submit))
				{
					this.BeginButtonPressed();
					return;
				}
				if (this.Oven.CurrentOperation != null)
				{
					this.ProgressImg.fillAmount = Mathf.Clamp01((float)this.Oven.CurrentOperation.CookProgress / (float)this.Oven.CurrentOperation.GetCookDuration());
					this.BeginButtonLabel.text = "COLLECT";
					if (this.Oven.CurrentOperation.CookProgress < this.Oven.CurrentOperation.GetCookDuration())
					{
						this.InstructionLabel.text = "Cooking in progress...";
						this.InstructionLabel.enabled = true;
						this.ErrorLabel.enabled = false;
						return;
					}
					if (this.DoesOvenOutputHaveSpace())
					{
						this.InstructionLabel.text = "Ready to collect product";
						this.InstructionLabel.enabled = true;
						this.ErrorLabel.enabled = false;
						return;
					}
					this.ErrorLabel.text = "Not enough space in output slot";
					this.ErrorLabel.enabled = true;
					this.InstructionLabel.enabled = false;
					return;
				}
				else
				{
					this.ProgressContainer.gameObject.SetActive(false);
					this.BeginButtonLabel.text = "BEGIN";
					if (this.Oven.IngredientSlot.ItemInstance != null)
					{
						if (this.Oven.IsIngredientCookable())
						{
							this.InstructionLabel.text = "Ready to begin cooking";
							this.InstructionLabel.enabled = true;
							return;
						}
						this.InstructionLabel.enabled = false;
						this.ErrorLabel.enabled = true;
						this.ErrorLabel.text = "Ingredient is not cookable";
						return;
					}
					else
					{
						this.InstructionLabel.text = "Place cookable item in ingredient slot";
						this.InstructionLabel.enabled = true;
						this.ErrorLabel.enabled = false;
					}
				}
			}
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x0012DC20 File Offset: 0x0012BE20
		public void SetIsOpen(LabOven oven, bool open, bool removeUI = true)
		{
			this.isOpen = open;
			this.Canvas.enabled = open;
			this.Container.gameObject.SetActive(open);
			this.Oven = oven;
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
				if (open)
				{
					PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
				}
			}
			if (oven != null)
			{
				this.IngredientSlotUI.AssignSlot(oven.IngredientSlot);
				this.OutputSlotUI.AssignSlot(oven.OutputSlot);
			}
			else
			{
				this.IngredientSlotUI.ClearSlot();
				this.OutputSlotUI.ClearSlot();
			}
			if (open)
			{
				this.RefreshActiveOperation();
				this.Update();
				Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			}
			else if (removeUI)
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(open, true);
			if (open)
			{
				Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), new List<ItemSlot>
				{
					this.Oven.IngredientSlot,
					this.Oven.OutputSlot
				});
			}
			if (this.isOpen)
			{
				Singleton<CompassManager>.Instance.SetVisible(false);
			}
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x0012DD68 File Offset: 0x0012BF68
		public void BeginButtonPressed()
		{
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			if (this.Oven.CurrentOperation != null)
			{
				new FinalizeLabOven(this.Oven);
			}
			else if ((this.Oven.IngredientSlot.ItemInstance.Definition as StorableItemDefinition).StationItem.GetModule<CookableModule>().CookType == CookableModule.ECookableType.Liquid)
			{
				new StartLabOvenTask(this.Oven);
			}
			else
			{
				new LabOvenSolidTask(this.Oven);
			}
			this.SetIsOpen(null, false, false);
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x0012DDEC File Offset: 0x0012BFEC
		public bool CanBegin()
		{
			if (this.Oven == null)
			{
				return false;
			}
			if (this.Oven.CurrentOperation != null)
			{
				return this.Oven.CurrentOperation.CookProgress >= this.Oven.CurrentOperation.GetCookDuration() && this.DoesOvenOutputHaveSpace();
			}
			return this.Oven.IsIngredientCookable();
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x0012DE54 File Offset: 0x0012C054
		private bool DoesOvenOutputHaveSpace()
		{
			return this.Oven.OutputSlot.GetCapacityForItem(this.Oven.CurrentOperation.Product.GetDefaultInstance(1)) >= this.Oven.CurrentOperation.Cookable.ProductQuantity;
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x0012DEA4 File Offset: 0x0012C0A4
		private void RefreshActiveOperation()
		{
			if (this.Oven.CurrentOperation != null)
			{
				this.IngredientIcon.sprite = this.Oven.CurrentOperation.Ingredient.Icon;
				this.ProductIcon.sprite = this.Oven.CurrentOperation.Product.Icon;
			}
		}

		// Token: 0x04003552 RID: 13650
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003553 RID: 13651
		public GameObject Container;

		// Token: 0x04003554 RID: 13652
		public ItemSlotUI IngredientSlotUI;

		// Token: 0x04003555 RID: 13653
		public ItemSlotUI OutputSlotUI;

		// Token: 0x04003556 RID: 13654
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x04003557 RID: 13655
		public TextMeshProUGUI ErrorLabel;

		// Token: 0x04003558 RID: 13656
		public Button BeginButton;

		// Token: 0x04003559 RID: 13657
		public TextMeshProUGUI BeginButtonLabel;

		// Token: 0x0400355A RID: 13658
		public RectTransform ProgressContainer;

		// Token: 0x0400355B RID: 13659
		public Image IngredientIcon;

		// Token: 0x0400355C RID: 13660
		public Image ProgressImg;

		// Token: 0x0400355D RID: 13661
		public Image ProductIcon;
	}
}
