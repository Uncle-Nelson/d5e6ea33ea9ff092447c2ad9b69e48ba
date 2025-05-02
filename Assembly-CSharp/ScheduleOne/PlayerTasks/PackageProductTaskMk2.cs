using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Packaging;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.UI;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200034F RID: 847
	public class PackageProductTaskMk2 : Task
	{
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x00054327 File Offset: 0x00052527
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x0005432F File Offset: 0x0005252F
		public override string TaskName { get; protected set; } = "Package product";

		// Token: 0x06001312 RID: 4882 RVA: 0x00054338 File Offset: 0x00052538
		public PackageProductTaskMk2(PackagingStationMk2 _station)
		{
			if (_station == null)
			{
				Console.LogError("Station is null!", null);
				return;
			}
			if (_station.GetState(PackagingStation.EMode.Package) != PackagingStation.EState.CanBegin)
			{
				Console.LogError("Station not ready to begin packaging!", null);
				return;
			}
			this.station = _station;
			this.ClickDetectionRadius = 0.01f;
			base.EnableMultiDragging(this.station.PackagingTool.ProductContainer, 0.08f);
			int quantity = _station.ProductSlot.Quantity;
			int quantity2 = _station.PackagingSlot.Quantity;
			int quantity3 = (_station.PackagingSlot.ItemInstance.Definition as PackagingDefinition).Quantity;
			int num = Mathf.Min(quantity, quantity2 * quantity3);
			num -= num % quantity3;
			int num2 = Mathf.CeilToInt((float)num / (float)quantity3);
			this.station.UpdatePackagingVisuals(this.station.PackagingSlot.Quantity - num2);
			this.station.UpdateProductVisuals(this.station.ProductSlot.Quantity - num2);
			this.station.SetVisualsLocked(true);
			FunctionalPackaging functionalPackaging = (_station.PackagingSlot.ItemInstance.Definition as PackagingDefinition).FunctionalPackaging;
			this.station.PackagingTool.Initialize(this, functionalPackaging, num2, _station.ProductSlot.ItemInstance as ProductItemInstance, num);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.station.CameraPosition_Task.position, this.station.CameraPosition_Task.rotation, 0.2f, false);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("packagingmk2");
			base.CurrentInstruction = "Insert product into packaging";
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x000544F4 File Offset: 0x000526F4
		public override void StopTask()
		{
			this.station.PackagingTool.Deinitialize();
			this.station.SetVisualsLocked(false);
			this.station.SetHatchOpen(false);
			this.station.UpdateProductVisuals();
			this.station.UpdatePackagingVisuals();
			base.StopTask();
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.station.CameraPosition.position, this.station.CameraPosition.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.2f);
			if (this.Outcome == Task.EOutcome.Success && this.station.GetState(PackagingStation.EMode.Package) == PackagingStation.EState.CanBegin)
			{
				new PackageProductTask(this.station);
				return;
			}
			Singleton<PackagingStationCanvas>.Instance.SetIsOpen(this.station, true, true);
		}

		// Token: 0x0400125B RID: 4699
		protected PackagingStationMk2 station;

		// Token: 0x0400125C RID: 4700
		protected FunctionalPackaging Packaging;

		// Token: 0x0400125D RID: 4701
		protected List<FunctionalProduct> Products = new List<FunctionalProduct>();
	}
}
