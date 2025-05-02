using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000A66 RID: 2662
	public class BrickPressCanvas : Singleton<BrickPressCanvas>
	{
		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x0012C132 File Offset: 0x0012A332
		// (set) Token: 0x060047A7 RID: 18343 RVA: 0x0012C13A File Offset: 0x0012A33A
		public bool isOpen { get; protected set; }

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x0012C143 File Offset: 0x0012A343
		// (set) Token: 0x060047A9 RID: 18345 RVA: 0x0012C14B File Offset: 0x0012A34B
		public BrickPress Press { get; protected set; }

		// Token: 0x060047AA RID: 18346 RVA: 0x0012C154 File Offset: 0x0012A354
		protected override void Awake()
		{
			base.Awake();
			this.BeginButton.onClick.AddListener(new UnityAction(this.BeginButtonPressed));
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x0012C178 File Offset: 0x0012A378
		protected override void Start()
		{
			base.Start();
			this.SetIsOpen(null, false, true);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x0012C18C File Offset: 0x0012A38C
		protected virtual void Update()
		{
			if (this.isOpen)
			{
				if (this.BeginButton.interactable && GameInput.GetButtonDown(GameInput.ButtonCode.Submit))
				{
					this.BeginButtonPressed();
					return;
				}
				PackagingStation.EState state = this.Press.GetState();
				if (state == PackagingStation.EState.CanBegin)
				{
					this.InstructionLabel.enabled = false;
					this.BeginButton.interactable = true;
					return;
				}
				if (state == PackagingStation.EState.InsufficentProduct)
				{
					this.InstructionLabel.text = "Drag 20x product into input slots";
				}
				else if (state == PackagingStation.EState.OutputSlotFull)
				{
					this.InstructionLabel.text = "Output slot is full!";
				}
				else if (state == PackagingStation.EState.Mismatch)
				{
					this.InstructionLabel.text = "Output slot is full!";
				}
				this.InstructionLabel.enabled = true;
				this.BeginButton.interactable = false;
			}
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x0012C244 File Offset: 0x0012A444
		public void SetIsOpen(BrickPress press, bool open, bool removeUI = true)
		{
			this.isOpen = open;
			this.Canvas.enabled = open;
			this.Container.gameObject.SetActive(open);
			this.Press = press;
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
				if (open)
				{
					PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
				}
			}
			if (press != null)
			{
				for (int i = 0; i < this.ProductSlotUIs.Length; i++)
				{
					this.ProductSlotUIs[i].AssignSlot(press.InputSlots[i]);
				}
				this.OutputSlotUI.AssignSlot(press.OutputSlot);
			}
			else
			{
				for (int j = 0; j < this.ProductSlotUIs.Length; j++)
				{
					this.ProductSlotUIs[j].ClearSlot();
				}
				this.OutputSlotUI.ClearSlot();
			}
			if (open)
			{
				Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
				this.Update();
			}
			else if (removeUI)
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(open, true);
			if (open)
			{
				List<ItemSlot> list = new List<ItemSlot>();
				list.AddRange(press.InputSlots);
				list.Add(press.OutputSlot);
				Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), list);
			}
			if (this.isOpen)
			{
				Singleton<CompassManager>.Instance.SetVisible(false);
			}
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x0012C3AC File Offset: 0x0012A5AC
		public void BeginButtonPressed()
		{
			if (this.Press.GetState() != PackagingStation.EState.CanBegin)
			{
				return;
			}
			ProductItemInstance product;
			if (!this.Press.HasSufficientProduct(out product))
			{
				return;
			}
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			new UseBrickPress(this.Press, product);
			this.SetIsOpen(null, false, false);
		}

		// Token: 0x04003510 RID: 13584
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003511 RID: 13585
		public RectTransform Container;

		// Token: 0x04003512 RID: 13586
		public ItemSlotUI[] ProductSlotUIs;

		// Token: 0x04003513 RID: 13587
		public ItemSlotUI OutputSlotUI;

		// Token: 0x04003514 RID: 13588
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x04003515 RID: 13589
		public Button BeginButton;
	}
}
