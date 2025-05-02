using System;
using System.Collections;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000351 RID: 849
	public class StartLabOvenTask : Task
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x00054C9D File Offset: 0x00052E9D
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x00054CA5 File Offset: 0x00052EA5
		public LabOven Oven { get; private set; }

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x00054CAE File Offset: 0x00052EAE
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00054CB6 File Offset: 0x00052EB6
		public StartLabOvenTask.EStep CurrentStep { get; protected set; }

		// Token: 0x06001320 RID: 4896 RVA: 0x00054CC0 File Offset: 0x00052EC0
		public StartLabOvenTask(LabOven oven)
		{
			this.Oven = oven;
			oven.ResetPourableContainer();
			this.stationItem = oven.CreateStationItems(1)[0];
			this.stationItem.ActivateModule<PourableModule>();
			this.pourableModule = this.stationItem.GetModule<PourableModule>();
			ConfigurableJoint componentInChildren = this.stationItem.GetComponentInChildren<ConfigurableJoint>();
			if (componentInChildren != null)
			{
				Object.Destroy(componentInChildren);
			}
			Rigidbody componentInChildren2 = this.stationItem.GetComponentInChildren<Rigidbody>();
			if (componentInChildren2 != null)
			{
				Object.Destroy(componentInChildren2);
			}
			Draggable componentInChildren3 = this.stationItem.GetComponentInChildren<Draggable>();
			if (componentInChildren3 != null)
			{
				componentInChildren3.ClickableEnabled = false;
			}
			this.ingredient = this.Oven.IngredientSlot.ItemInstance.GetCopy(1);
			this.Oven.IngredientSlot.ItemInstance.ChangeQuantity(-1);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.2f);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			oven.Door.SetInteractable(true);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00054DBA File Offset: 0x00052FBA
		public override void Update()
		{
			base.Update();
			this.CheckProgress();
			base.CurrentInstruction = StartLabOvenTask.GetStepInstruction(this.CurrentStep);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00054DDC File Offset: 0x00052FDC
		public override void Success()
		{
			string id = (this.ingredient.Definition as StorableItemDefinition).StationItem.GetModule<CookableModule>().Product.ID;
			EQuality ingredientQuality = EQuality.Standard;
			if (this.ingredient is QualityItemInstance)
			{
				ingredientQuality = (this.ingredient as QualityItemInstance).Quality;
			}
			this.Oven.SendCookOperation(new OvenCookOperation(this.ingredient.ID, ingredientQuality, 1, id));
			base.Success();
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00054E54 File Offset: 0x00053054
		public override void StopTask()
		{
			base.StopTask();
			if (this.Outcome != Task.EOutcome.Success)
			{
				this.Oven.IngredientSlot.AddItem(this.ingredient, false);
				this.Oven.LiquidMesh.gameObject.SetActive(false);
			}
			this.stationItem.Destroy();
			if (this.pourRoutine != null)
			{
				this.Oven.PourAnimation.Stop();
				this.Oven.StopCoroutine(this.pourRoutine);
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

		// Token: 0x06001324 RID: 4900 RVA: 0x00054F80 File Offset: 0x00053180
		private void CheckProgress()
		{
			switch (this.CurrentStep)
			{
			case StartLabOvenTask.EStep.OpenDoor:
				this.CheckStep_OpenDoor();
				return;
			case StartLabOvenTask.EStep.Pour:
				this.CheckStep_Pour();
				return;
			case StartLabOvenTask.EStep.CloseDoor:
				this.CheckStep_CloseDoor();
				return;
			case StartLabOvenTask.EStep.PressButton:
				this.CheckStep_PressButton();
				return;
			default:
				return;
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00054FC8 File Offset: 0x000531C8
		private void ProgressStep()
		{
			if (this.CurrentStep == StartLabOvenTask.EStep.PressButton)
			{
				this.Success();
				return;
			}
			StartLabOvenTask.EStep currentStep = this.CurrentStep;
			this.CurrentStep = currentStep + 1;
			if (this.CurrentStep == StartLabOvenTask.EStep.Pour)
			{
				this.Oven.WireTray.SetPosition(1f);
			}
			if (this.CurrentStep == StartLabOvenTask.EStep.CloseDoor)
			{
				this.Oven.Door.SetInteractable(true);
			}
			if (this.CurrentStep == StartLabOvenTask.EStep.Pour)
			{
				this.pourRoutine = this.Oven.StartCoroutine(this.PlayPourAnimation());
			}
			if (this.CurrentStep == StartLabOvenTask.EStep.PressButton)
			{
				this.Oven.Button.SetInteractable(true);
			}
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00055068 File Offset: 0x00053268
		private void CheckStep_OpenDoor()
		{
			if (this.Oven.Door.TargetPosition > 0.9f)
			{
				this.ProgressStep();
				this.Oven.Door.SetInteractable(false);
				this.Oven.Door.SetPosition(1f);
			}
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000550B8 File Offset: 0x000532B8
		private void CheckStep_Pour()
		{
			if (this.pourAnimDone)
			{
				this.ProgressStep();
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000550C8 File Offset: 0x000532C8
		private void CheckStep_CloseDoor()
		{
			if (this.Oven.Door.TargetPosition < 0.05f)
			{
				this.ProgressStep();
				this.Oven.Door.SetInteractable(false);
				this.Oven.Door.SetPosition(0f);
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00055118 File Offset: 0x00053318
		private void CheckStep_PressButton()
		{
			if (this.Oven.Button.Pressed)
			{
				this.ProgressStep();
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00055132 File Offset: 0x00053332
		private IEnumerator PlayPourAnimation()
		{
			this.Oven.SetLiquidColor(this.stationItem.GetModule<CookableModule>().LiquidColor);
			this.Oven.PourAnimation.Play();
			yield return new WaitForSeconds(0.6f);
			float pourTime = 1f;
			for (float i = 0f; i < pourTime; i += Time.deltaTime)
			{
				this.pourableModule.LiquidContainer.SetLiquidLevel(1f - i / pourTime, false);
				yield return null;
			}
			this.pourableModule.LiquidContainer.SetLiquidLevel(0f, false);
			this.pourAnimDone = true;
			yield break;
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00055141 File Offset: 0x00053341
		public static string GetStepInstruction(StartLabOvenTask.EStep step)
		{
			switch (step)
			{
			case StartLabOvenTask.EStep.OpenDoor:
				return "Open oven door";
			case StartLabOvenTask.EStep.Pour:
				return "Pour liquid into tray";
			case StartLabOvenTask.EStep.CloseDoor:
				return "Close oven door";
			case StartLabOvenTask.EStep.PressButton:
				return "Start oven";
			default:
				return string.Empty;
			}
		}

		// Token: 0x04001269 RID: 4713
		private ItemInstance ingredient;

		// Token: 0x0400126A RID: 4714
		private Coroutine pourRoutine;

		// Token: 0x0400126B RID: 4715
		private StationItem stationItem;

		// Token: 0x0400126C RID: 4716
		private PourableModule pourableModule;

		// Token: 0x0400126D RID: 4717
		private bool pourAnimDone;

		// Token: 0x02000352 RID: 850
		public enum EStep
		{
			// Token: 0x0400126F RID: 4719
			OpenDoor,
			// Token: 0x04001270 RID: 4720
			Pour,
			// Token: 0x04001271 RID: 4721
			CloseDoor,
			// Token: 0x04001272 RID: 4722
			PressButton
		}
	}
}
