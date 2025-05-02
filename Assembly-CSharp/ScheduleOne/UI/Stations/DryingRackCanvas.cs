using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Items;
using ScheduleOne.UI.Stations.Drying_rack;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000A6E RID: 2670
	public class DryingRackCanvas : Singleton<DryingRackCanvas>
	{
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x0012D455 File Offset: 0x0012B655
		// (set) Token: 0x060047DE RID: 18398 RVA: 0x0012D45D File Offset: 0x0012B65D
		public bool isOpen { get; protected set; }

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x0012D466 File Offset: 0x0012B666
		// (set) Token: 0x060047E0 RID: 18400 RVA: 0x0012D46E File Offset: 0x0012B66E
		public DryingRack Rack { get; protected set; }

		// Token: 0x060047E1 RID: 18401 RVA: 0x0012D477 File Offset: 0x0012B677
		protected override void Awake()
		{
			base.Awake();
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x0012D47F File Offset: 0x0012B67F
		protected override void Start()
		{
			base.Start();
			this.SetIsOpen(null, false);
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x0012D4B5 File Offset: 0x0012B6B5
		private void MinPass()
		{
			if (!this.isOpen)
			{
				return;
			}
			this.UpdateDryingOperations();
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x0012D4C6 File Offset: 0x0012B6C6
		protected virtual void Update()
		{
			if (!this.isOpen)
			{
				return;
			}
			this.UpdateUI();
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x0012D4D8 File Offset: 0x0012B6D8
		private void UpdateUI()
		{
			this.InsertButton.interactable = this.Rack.CanStartOperation();
			this.CapacityLabel.text = this.Rack.GetTotalDryingItems().ToString() + " / " + this.Rack.ItemCapacity.ToString();
			this.CapacityLabel.color = ((this.Rack.GetTotalDryingItems() >= this.Rack.ItemCapacity) ? new Color32(byte.MaxValue, 50, 50, byte.MaxValue) : Color.white);
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x0012D578 File Offset: 0x0012B778
		private void UpdateDryingOperations()
		{
			foreach (DryingOperationUI dryingOperationUI in this.operationUIs)
			{
				RectTransform alignment = null;
				DryingOperation assignedOperation = dryingOperationUI.AssignedOperation;
				if (assignedOperation.StartQuality == EQuality.Trash)
				{
					alignment = this.IndicatorAlignments[0];
				}
				else if (assignedOperation.StartQuality == EQuality.Poor)
				{
					alignment = this.IndicatorAlignments[1];
				}
				else if (assignedOperation.StartQuality == EQuality.Standard)
				{
					alignment = this.IndicatorAlignments[2];
				}
				else if (assignedOperation.StartQuality == EQuality.Premium)
				{
					alignment = this.IndicatorAlignments[3];
				}
				else
				{
					Console.LogWarning("Alignment not found for quality: " + assignedOperation.StartQuality.ToString(), null);
				}
				dryingOperationUI.SetAlignment(alignment);
			}
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x0012D648 File Offset: 0x0012B848
		private void UpdateQuantities()
		{
			foreach (DryingOperationUI dryingOperationUI in this.operationUIs)
			{
				dryingOperationUI.RefreshQuantity();
			}
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x0012D698 File Offset: 0x0012B898
		public void SetIsOpen(DryingRack rack, bool open)
		{
			this.isOpen = open;
			this.Canvas.enabled = open;
			this.Container.gameObject.SetActive(open);
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			}
			if (open)
			{
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
				this.InputSlotUI.AssignSlot(rack.InputSlot);
				this.OutputSlotUI.AssignSlot(rack.OutputSlot);
				Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
				for (int i = 0; i < rack.DryingOperations.Count; i++)
				{
					this.CreateOperationUI(rack.DryingOperations[i]);
				}
				rack.onOperationStart = (Action<DryingOperation>)Delegate.Combine(rack.onOperationStart, new Action<DryingOperation>(this.CreateOperationUI));
				rack.onOperationComplete = (Action<DryingOperation>)Delegate.Combine(rack.onOperationComplete, new Action<DryingOperation>(this.DestroyOperationUI));
				rack.onOperationsChanged = (Action)Delegate.Combine(rack.onOperationsChanged, new Action(this.UpdateQuantities));
			}
			else
			{
				this.InputSlotUI.ClearSlot();
				this.OutputSlotUI.ClearSlot();
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
				if (this.Rack != null)
				{
					DryingRack rack2 = this.Rack;
					rack2.onOperationStart = (Action<DryingOperation>)Delegate.Remove(rack2.onOperationStart, new Action<DryingOperation>(this.CreateOperationUI));
					DryingRack rack3 = this.Rack;
					rack3.onOperationComplete = (Action<DryingOperation>)Delegate.Remove(rack3.onOperationComplete, new Action<DryingOperation>(this.DestroyOperationUI));
					DryingRack rack4 = this.Rack;
					rack4.onOperationsChanged = (Action)Delegate.Remove(rack4.onOperationsChanged, new Action(this.UpdateQuantities));
				}
				foreach (DryingOperationUI dryingOperationUI in this.operationUIs)
				{
					Object.Destroy(dryingOperationUI.gameObject);
				}
				this.operationUIs.Clear();
			}
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(open, true);
			if (open)
			{
				List<ItemSlot> list = new List<ItemSlot>();
				list.AddRange(rack.InputSlots);
				list.Add(rack.OutputSlot);
				Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), list);
			}
			this.Rack = rack;
			if (open)
			{
				this.UpdateUI();
				this.MinPass();
			}
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x0012D920 File Offset: 0x0012BB20
		private void CreateOperationUI(DryingOperation operation)
		{
			DryingOperationUI dryingOperationUI = Object.Instantiate<DryingOperationUI>(this.IndicatorPrefab, this.IndicatorContainer);
			dryingOperationUI.SetOperation(operation);
			this.operationUIs.Add(dryingOperationUI);
			this.UpdateDryingOperations();
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x0012D958 File Offset: 0x0012BB58
		private void DestroyOperationUI(DryingOperation operation)
		{
			DryingOperationUI dryingOperationUI = this.operationUIs.FirstOrDefault((DryingOperationUI x) => x.AssignedOperation == operation);
			if (dryingOperationUI != null)
			{
				this.operationUIs.Remove(dryingOperationUI);
				Object.Destroy(dryingOperationUI.gameObject);
			}
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x0012D9AB File Offset: 0x0012BBAB
		public void Insert()
		{
			this.Rack.StartOperation();
		}

		// Token: 0x04003544 RID: 13636
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003545 RID: 13637
		public RectTransform Container;

		// Token: 0x04003546 RID: 13638
		public ItemSlotUI InputSlotUI;

		// Token: 0x04003547 RID: 13639
		public ItemSlotUI OutputSlotUI;

		// Token: 0x04003548 RID: 13640
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x04003549 RID: 13641
		public TextMeshProUGUI CapacityLabel;

		// Token: 0x0400354A RID: 13642
		public Button InsertButton;

		// Token: 0x0400354B RID: 13643
		public RectTransform IndicatorContainer;

		// Token: 0x0400354C RID: 13644
		public RectTransform[] IndicatorAlignments;

		// Token: 0x0400354D RID: 13645
		[Header("Prefabs")]
		public DryingOperationUI IndicatorPrefab;

		// Token: 0x0400354E RID: 13646
		private List<DryingOperationUI> operationUIs = new List<DryingOperationUI>();
	}
}
