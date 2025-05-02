using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000A67 RID: 2663
	public class CauldronCanvas : Singleton<CauldronCanvas>
	{
		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x060047B0 RID: 18352 RVA: 0x0012C400 File Offset: 0x0012A600
		// (set) Token: 0x060047B1 RID: 18353 RVA: 0x0012C408 File Offset: 0x0012A608
		public bool isOpen { get; protected set; }

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x060047B2 RID: 18354 RVA: 0x0012C411 File Offset: 0x0012A611
		// (set) Token: 0x060047B3 RID: 18355 RVA: 0x0012C419 File Offset: 0x0012A619
		public Cauldron Cauldron { get; protected set; }

		// Token: 0x060047B4 RID: 18356 RVA: 0x0012C422 File Offset: 0x0012A622
		protected override void Awake()
		{
			base.Awake();
			this.BeginButton.onClick.AddListener(new UnityAction(this.BeginButtonPressed));
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x0012C446 File Offset: 0x0012A646
		protected override void Start()
		{
			base.Start();
			this.SetIsOpen(null, false, true);
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x0012C458 File Offset: 0x0012A658
		protected virtual void Update()
		{
			if (this.isOpen)
			{
				if (this.BeginButton.interactable && GameInput.GetButtonDown(GameInput.ButtonCode.Submit))
				{
					this.BeginButtonPressed();
				}
				Cauldron.EState state = this.Cauldron.GetState();
				if (state == Cauldron.EState.Ready)
				{
					this.InstructionLabel.enabled = false;
					this.BeginButton.interactable = true;
					return;
				}
				if (state == Cauldron.EState.Cooking)
				{
					this.InstructionLabel.text = "Cooking in progress...";
				}
				else if (state == Cauldron.EState.MissingIngredients)
				{
					this.InstructionLabel.text = "Insert <color=#FFC73D>" + 20.ToString() + "x</color> coca leaves and <color=#FFC73D>1x</color> gasoline";
				}
				else if (state == Cauldron.EState.OutputFull)
				{
					this.InstructionLabel.text = "Output is full";
				}
				this.InstructionLabel.enabled = true;
				this.BeginButton.interactable = false;
			}
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x0012C520 File Offset: 0x0012A720
		public void SetIsOpen(Cauldron cauldron, bool open, bool removeUI = true)
		{
			this.isOpen = open;
			this.Canvas.enabled = open;
			this.Container.SetActive(open);
			this.Cauldron = cauldron;
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
				if (open)
				{
					PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
				}
			}
			if (cauldron != null)
			{
				for (int i = 0; i < this.IngredientSlotUIs.Count; i++)
				{
					this.IngredientSlotUIs[i].AssignSlot(cauldron.IngredientSlots[i]);
				}
				this.LiquidSlotUI.AssignSlot(this.Cauldron.LiquidSlot);
				this.OutputSlotUI.AssignSlot(this.Cauldron.OutputSlot);
			}
			else
			{
				foreach (ItemSlotUI itemSlotUI in this.IngredientSlotUIs)
				{
					itemSlotUI.ClearSlot();
				}
				this.LiquidSlotUI.ClearSlot();
				this.OutputSlotUI.ClearSlot();
			}
			if (open)
			{
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
				List<ItemSlot> list = new List<ItemSlot>();
				list.AddRange(cauldron.IngredientSlots);
				list.Add(cauldron.LiquidSlot);
				list.Add(cauldron.OutputSlot);
				Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), list);
			}
			if (this.isOpen)
			{
				this.Update();
				Singleton<CompassManager>.Instance.SetVisible(false);
			}
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x0012C6DC File Offset: 0x0012A8DC
		public void BeginButtonPressed()
		{
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			new CauldronTask(this.Cauldron);
			this.SetIsOpen(null, false, false);
		}

		// Token: 0x04003518 RID: 13592
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003519 RID: 13593
		public GameObject Container;

		// Token: 0x0400351A RID: 13594
		public List<ItemSlotUI> IngredientSlotUIs;

		// Token: 0x0400351B RID: 13595
		public ItemSlotUI LiquidSlotUI;

		// Token: 0x0400351C RID: 13596
		public ItemSlotUI OutputSlotUI;

		// Token: 0x0400351D RID: 13597
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x0400351E RID: 13598
		public Button BeginButton;
	}
}
