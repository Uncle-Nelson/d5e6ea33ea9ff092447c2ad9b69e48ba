using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200034C RID: 844
	public class LabOvenSolidTask : Task
	{
		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00053997 File Offset: 0x00051B97
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x0005399F File Offset: 0x00051B9F
		public LabOven Oven { get; private set; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x000539A8 File Offset: 0x00051BA8
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x000539B0 File Offset: 0x00051BB0
		public LabOvenSolidTask.EStep CurrentStep { get; protected set; }

		// Token: 0x060012FD RID: 4861 RVA: 0x000539BC File Offset: 0x00051BBC
		public LabOvenSolidTask(LabOven oven)
		{
			this.Oven = oven;
			this.ingredientQuantity = Mathf.Min(this.Oven.IngredientSlot.Quantity, 10);
			this.stationItems = oven.CreateStationItems(this.ingredientQuantity);
			this.stationDraggables = new Draggable[this.stationItems.Length];
			for (int i = 0; i < this.stationItems.Length; i++)
			{
				this.stationDraggables[i] = this.stationItems[i].GetComponentInChildren<Draggable>();
			}
			this.ingredient = this.Oven.IngredientSlot.ItemInstance.GetCopy(this.ingredientQuantity);
			this.Oven.IngredientSlot.ChangeQuantity(-this.ingredientQuantity, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.Oven.CameraPosition_PlaceItems.position, this.Oven.CameraPosition_PlaceItems.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.2f);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			base.EnableMultiDragging(oven.ItemContainer, 0.12f);
			oven.Door.SetInteractable(true);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00053AEC File Offset: 0x00051CEC
		public override void Update()
		{
			base.Update();
			this.CheckProgress();
			base.CurrentInstruction = LabOvenSolidTask.GetStepInstruction(this.CurrentStep);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00053B0C File Offset: 0x00051D0C
		public override void Success()
		{
			string id = (this.ingredient.Definition as StorableItemDefinition).StationItem.GetModule<CookableModule>().Product.ID;
			EQuality ingredientQuality = EQuality.Standard;
			if (this.ingredient is QualityItemInstance)
			{
				ingredientQuality = (this.ingredient as QualityItemInstance).Quality;
			}
			this.Oven.SendCookOperation(new OvenCookOperation(this.ingredient.ID, ingredientQuality, this.ingredientQuantity, id));
			base.Success();
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00053B88 File Offset: 0x00051D88
		public override void StopTask()
		{
			base.StopTask();
			if (this.Outcome != Task.EOutcome.Success)
			{
				this.Oven.IngredientSlot.AddItem(this.ingredient, false);
				this.Oven.LiquidMesh.gameObject.SetActive(false);
			}
			for (int i = 0; i < this.stationItems.Length; i++)
			{
				this.stationItems[i].Destroy();
			}
			this.Oven.ClearDecals();
			this.Oven.Door.SetPosition(0f);
			this.Oven.Door.SetInteractable(false);
			this.Oven.WireTray.SetPosition(0f);
			this.Oven.Button.SetInteractable(false);
			Singleton<LabOvenCanvas>.Instance.SetIsOpen(this.Oven, true, true);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.Oven.CameraPosition_Default.position, this.Oven.CameraPosition_Default.rotation, 0.2f, false);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00053CA0 File Offset: 0x00051EA0
		private void CheckProgress()
		{
			switch (this.CurrentStep)
			{
			case LabOvenSolidTask.EStep.OpenDoor:
				this.CheckStep_OpenDoor();
				return;
			case LabOvenSolidTask.EStep.PlaceItems:
				this.CheckStep_PlaceItems();
				return;
			case LabOvenSolidTask.EStep.CloseDoor:
				this.CheckStep_CloseDoor();
				return;
			case LabOvenSolidTask.EStep.PressButton:
				this.CheckStep_PressButton();
				return;
			default:
				return;
			}
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00053CE8 File Offset: 0x00051EE8
		private void ProgressStep()
		{
			if (this.CurrentStep == LabOvenSolidTask.EStep.PressButton)
			{
				this.Success();
				return;
			}
			LabOvenSolidTask.EStep currentStep = this.CurrentStep;
			this.CurrentStep = currentStep + 1;
			if (this.CurrentStep == LabOvenSolidTask.EStep.PlaceItems)
			{
				this.Oven.WireTray.SetPosition(1f);
			}
			if (this.CurrentStep == LabOvenSolidTask.EStep.CloseDoor)
			{
				this.Oven.Door.SetInteractable(true);
				for (int i = 0; i < this.stationDraggables.Length; i++)
				{
					this.stationDraggables[i].ClickableEnabled = false;
					Object.Destroy(this.stationDraggables[i].Rb);
					this.stationItems[i].transform.SetParent(this.Oven.SquareTray);
				}
			}
			if (this.CurrentStep == LabOvenSolidTask.EStep.PressButton)
			{
				this.Oven.Button.SetInteractable(true);
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00053DB8 File Offset: 0x00051FB8
		private void CheckStep_OpenDoor()
		{
			if (this.Oven.Door.TargetPosition > 0.9f)
			{
				this.ProgressStep();
				this.Oven.Door.SetInteractable(false);
				this.Oven.Door.SetPosition(1f);
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00053E08 File Offset: 0x00052008
		private void CheckStep_PlaceItems()
		{
			for (int i = 0; i < this.stationDraggables.Length; i++)
			{
				if (this.stationDraggables[i].IsHeld)
				{
					return;
				}
				if (this.stationDraggables[i].Rb.velocity.magnitude > 0.02f)
				{
					return;
				}
				if (!this.Oven.TrayDetectionArea.bounds.Contains(this.stationDraggables[i].transform.position))
				{
					return;
				}
			}
			this.ProgressStep();
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00053E90 File Offset: 0x00052090
		private void CheckStep_CloseDoor()
		{
			if (this.Oven.Door.TargetPosition < 0.05f)
			{
				this.ProgressStep();
				this.Oven.Door.SetInteractable(false);
				this.Oven.Door.SetPosition(0f);
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00053EE0 File Offset: 0x000520E0
		private void CheckStep_PressButton()
		{
			if (this.Oven.Button.Pressed)
			{
				this.ProgressStep();
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00053EFA File Offset: 0x000520FA
		public static string GetStepInstruction(LabOvenSolidTask.EStep step)
		{
			switch (step)
			{
			case LabOvenSolidTask.EStep.OpenDoor:
				return "Open oven door";
			case LabOvenSolidTask.EStep.PlaceItems:
				return "Place items onto tray";
			case LabOvenSolidTask.EStep.CloseDoor:
				return "Close oven door";
			case LabOvenSolidTask.EStep.PressButton:
				return "Start oven";
			default:
				return string.Empty;
			}
		}

		// Token: 0x0400124D RID: 4685
		private ItemInstance ingredient;

		// Token: 0x0400124E RID: 4686
		private int ingredientQuantity = 1;

		// Token: 0x0400124F RID: 4687
		private StationItem[] stationItems;

		// Token: 0x04001250 RID: 4688
		private Draggable[] stationDraggables;

		// Token: 0x0200034D RID: 845
		public enum EStep
		{
			// Token: 0x04001252 RID: 4690
			OpenDoor,
			// Token: 0x04001253 RID: 4691
			PlaceItems,
			// Token: 0x04001254 RID: 4692
			CloseDoor,
			// Token: 0x04001255 RID: 4693
			PressButton
		}
	}
}
