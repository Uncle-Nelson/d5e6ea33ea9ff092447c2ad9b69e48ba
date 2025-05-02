using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product.Packaging;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000A72 RID: 2674
	public class PackagingStationCanvas : Singleton<PackagingStationCanvas>
	{
		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06004816 RID: 18454 RVA: 0x0012ED97 File Offset: 0x0012CF97
		// (set) Token: 0x06004817 RID: 18455 RVA: 0x0012ED9F File Offset: 0x0012CF9F
		public bool isOpen { get; protected set; }

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x0012EDA8 File Offset: 0x0012CFA8
		// (set) Token: 0x06004819 RID: 18457 RVA: 0x0012EDB0 File Offset: 0x0012CFB0
		public PackagingStation PackagingStation { get; protected set; }

		// Token: 0x0600481A RID: 18458 RVA: 0x0012EDB9 File Offset: 0x0012CFB9
		protected override void Awake()
		{
			base.Awake();
			this.BeginButton.onClick.AddListener(new UnityAction(this.BeginButtonPressed));
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x0012EDDD File Offset: 0x0012CFDD
		protected override void Start()
		{
			base.Start();
			this.SetIsOpen(null, false, true);
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x0012EDF0 File Offset: 0x0012CFF0
		protected virtual void Update()
		{
			if (this.isOpen)
			{
				if (this.CurrentMode == PackagingStation.EMode.Package)
				{
					this.ButtonLabel.text = "PACK";
				}
				else
				{
					this.ButtonLabel.text = "UNPACK";
				}
				if (this.BeginButton.interactable && GameInput.GetButtonDown(GameInput.ButtonCode.Submit))
				{
					this.BeginButtonPressed();
					return;
				}
				PackagingStation.EState state = this.PackagingStation.GetState(this.CurrentMode);
				if (state == PackagingStation.EState.CanBegin)
				{
					this.InstructionLabel.enabled = false;
					this.InstructionShadow.enabled = false;
					this.BeginButton.interactable = true;
					return;
				}
				if (this.CurrentMode == PackagingStation.EMode.Package)
				{
					if (state == PackagingStation.EState.MissingItems)
					{
						this.InstructionLabel.text = "Drag product + packaging into slots";
						this.InstructionLabel.color = Color.white;
					}
					else if (state == PackagingStation.EState.InsufficentProduct)
					{
						this.InstructionLabel.text = "This packaging type requires <color=#FFC73D>" + (this.PackagingStation.PackagingSlot.ItemInstance.Definition as PackagingDefinition).Quantity.ToString() + "x</color> product";
						this.InstructionLabel.color = Color.white;
					}
					else if (state == PackagingStation.EState.OutputSlotFull)
					{
						this.InstructionLabel.text = "Output slot is full!";
						this.InstructionLabel.color = this.InstructionWarningColor;
					}
					else if (state == PackagingStation.EState.Mismatch)
					{
						this.InstructionLabel.text = "Output slot is full!";
						this.InstructionLabel.color = this.InstructionWarningColor;
					}
				}
				else if (state == PackagingStation.EState.MissingItems)
				{
					this.InstructionLabel.text = "Drag packaged product into output";
					this.InstructionLabel.color = Color.white;
				}
				else if (state == PackagingStation.EState.PackageSlotFull)
				{
					this.InstructionLabel.text = "Unpackaged items won't fit!";
					this.InstructionLabel.color = this.InstructionWarningColor;
				}
				else if (state == PackagingStation.EState.ProductSlotFull)
				{
					this.InstructionLabel.text = "Unpackaged items won't fit!";
					this.InstructionLabel.color = this.InstructionWarningColor;
				}
				this.InstructionLabel.enabled = true;
				this.InstructionShadow.enabled = true;
				this.BeginButton.interactable = false;
			}
		}

		// Token: 0x0600481D RID: 18461 RVA: 0x0012F000 File Offset: 0x0012D200
		public void SetIsOpen(PackagingStation station, bool open, bool removeUI = true)
		{
			this.isOpen = open;
			this.Canvas.enabled = open;
			this.Container.gameObject.SetActive(open);
			this.PackagingStation = station;
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
				if (open)
				{
					PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
				}
			}
			if (station != null)
			{
				this.PackagingSlotUI.AssignSlot(station.PackagingSlot);
				this.ProductSlotUI.AssignSlot(station.ProductSlot);
				this.OutputSlotUI.AssignSlot(station.OutputSlot);
			}
			else
			{
				this.PackagingSlotUI.ClearSlot();
				this.ProductSlotUI.ClearSlot();
				this.OutputSlotUI.ClearSlot();
			}
			if (open)
			{
				Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
				if (this.ShowShiftClickHint && station.OutputSlot.Quantity > 0)
				{
					Singleton<HintDisplay>.Instance.ShowHint_20s("<Input_QuickMove><h1> + click</h> an item to quickly move it");
				}
			}
			else if (removeUI)
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(open, true);
			if (open)
			{
				if (this.CurrentMode == PackagingStation.EMode.Package)
				{
					Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), new List<ItemSlot>
					{
						station.ProductSlot,
						station.PackagingSlot,
						station.OutputSlot
					});
				}
				else
				{
					Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), new List<ItemSlot>
					{
						station.OutputSlot,
						station.PackagingSlot,
						station.ProductSlot
					});
				}
			}
			if (this.isOpen)
			{
				Singleton<CompassManager>.Instance.SetVisible(false);
			}
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x0012F1C8 File Offset: 0x0012D3C8
		public void BeginButtonPressed()
		{
			if (this.PackagingStation == null)
			{
				return;
			}
			if (this.PackagingStation.GetState(this.CurrentMode) != PackagingStation.EState.CanBegin)
			{
				return;
			}
			if (this.CurrentMode == PackagingStation.EMode.Unpackage)
			{
				this.PackagingStation.Unpack();
				Singleton<TaskManager>.Instance.PlayTaskCompleteSound();
				return;
			}
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			this.PackagingStation.StartTask();
			if (this.ShowHintOnOpen)
			{
				Singleton<HintDisplay>.Instance.ShowHint_20s("When performing tasks at stations, click and drag items to move them.");
			}
			this.SetIsOpen(null, false, false);
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x0012F250 File Offset: 0x0012D450
		private void UpdateSlotPositions()
		{
			if (this.PackagingStation != null)
			{
				this.PackagingSlotUI.Rect.position = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(this.PackagingStation.PackagingSlotPosition.position);
				this.ProductSlotUI.Rect.position = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(this.PackagingStation.ProductSlotPosition.position);
				this.OutputSlotUI.Rect.position = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(this.PackagingStation.OutputSlotPosition.position);
			}
		}

		// Token: 0x06004820 RID: 18464 RVA: 0x0012F2FB File Offset: 0x0012D4FB
		public void ToggleMode()
		{
			this.SetMode((this.CurrentMode == PackagingStation.EMode.Package) ? PackagingStation.EMode.Unpackage : PackagingStation.EMode.Package);
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x0012F310 File Offset: 0x0012D510
		public void SetMode(PackagingStation.EMode mode)
		{
			this.CurrentMode = mode;
			if (mode == PackagingStation.EMode.Package)
			{
				this.ModeAnimation.Play("Packaging station switch to package");
			}
			else
			{
				this.ModeAnimation.Play("Packaging station switch to unpackage");
			}
			if (this.CurrentMode == PackagingStation.EMode.Package)
			{
				Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), new List<ItemSlot>
				{
					this.PackagingStation.ProductSlot,
					this.PackagingStation.PackagingSlot,
					this.PackagingStation.OutputSlot
				});
				return;
			}
			Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), new List<ItemSlot>
			{
				this.PackagingStation.OutputSlot,
				this.PackagingStation.PackagingSlot,
				this.PackagingStation.ProductSlot
			});
		}

		// Token: 0x04003576 RID: 13686
		public bool ShowHintOnOpen;

		// Token: 0x04003577 RID: 13687
		public bool ShowShiftClickHint;

		// Token: 0x04003578 RID: 13688
		public PackagingStation.EMode CurrentMode;

		// Token: 0x04003579 RID: 13689
		public Color InstructionWarningColor;

		// Token: 0x0400357A RID: 13690
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400357B RID: 13691
		public GameObject Container;

		// Token: 0x0400357C RID: 13692
		public ItemSlotUI PackagingSlotUI;

		// Token: 0x0400357D RID: 13693
		public ItemSlotUI ProductSlotUI;

		// Token: 0x0400357E RID: 13694
		public ItemSlotUI OutputSlotUI;

		// Token: 0x0400357F RID: 13695
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x04003580 RID: 13696
		public Image InstructionShadow;

		// Token: 0x04003581 RID: 13697
		public Button BeginButton;

		// Token: 0x04003582 RID: 13698
		public Animation ModeAnimation;

		// Token: 0x04003583 RID: 13699
		public TextMeshProUGUI ButtonLabel;
	}
}
