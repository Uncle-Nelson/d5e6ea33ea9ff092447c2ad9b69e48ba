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
	// Token: 0x0200034E RID: 846
	public class PackageProductTask : Task
	{
		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00053F31 File Offset: 0x00052131
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x00053F39 File Offset: 0x00052139
		public override string TaskName { get; protected set; } = "Package product";

		// Token: 0x0600130A RID: 4874 RVA: 0x00053F44 File Offset: 0x00052144
		public PackageProductTask(PackagingStation _station)
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
			this.ClickDetectionRadius = 0.02f;
			this.Packaging = Object.Instantiate<FunctionalPackaging>((this.station.PackagingSlot.ItemInstance.Definition as PackagingDefinition).FunctionalPackaging, this.station.Container);
			this.Packaging.Initialize(this.station, this.station.ActivePackagingAlignent, true);
			base.EnableMultiDragging(this.station.Container, 0.08f);
			int quantity = (this.station.PackagingSlot.ItemInstance.Definition as PackagingDefinition).Quantity;
			for (int i = 0; i < quantity; i++)
			{
				FunctionalProduct functionalProduct = Object.Instantiate<FunctionalProduct>((this.station.ProductSlot.ItemInstance.Definition as ProductDefinition).FunctionalProduct, this.station.Container);
				functionalProduct.Initialize(this.station, this.station.ProductSlot.ItemInstance, this.station.ActiveProductAlignments[i], true);
				functionalProduct.ClampZ = true;
				functionalProduct.DragProjectionMode = Draggable.EDragProjectionMode.FlatCameraForward;
				this.Products.Add(functionalProduct);
			}
			FunctionalPackaging packaging = this.Packaging;
			packaging.onFullyPacked = (Action)Delegate.Combine(packaging.onFullyPacked, new Action(this.FullyPacked));
			FunctionalPackaging packaging2 = this.Packaging;
			packaging2.onSealed = (Action)Delegate.Combine(packaging2.onSealed, new Action(this.Sealed));
			FunctionalPackaging packaging3 = this.Packaging;
			packaging3.onReachOutput = (Action)Delegate.Combine(packaging3.onReachOutput, new Action(this.ReachedOutput));
			this.station.UpdatePackagingVisuals(this.station.PackagingSlot.Quantity - 1);
			this.station.UpdateProductVisuals(this.station.ProductSlot.Quantity - this.Packaging.Definition.Quantity);
			this.station.SetVisualsLocked(true);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.station.CameraPosition_Task.position, this.station.CameraPosition_Task.rotation, 0.2f, false);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("packaging");
			base.CurrentInstruction = "Place product into packaging";
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000541E4 File Offset: 0x000523E4
		public override void StopTask()
		{
			this.Packaging.Destroy();
			for (int i = 0; i < this.Products.Count; i++)
			{
				Object.Destroy(this.Products[i].gameObject);
			}
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

		// Token: 0x0600130C RID: 4876 RVA: 0x000542E0 File Offset: 0x000524E0
		public override void Success()
		{
			this.station.PackSingleInstance();
			base.Success();
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000542F3 File Offset: 0x000524F3
		private void FullyPacked()
		{
			base.CurrentInstruction = this.Packaging.SealInstruction;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00054306 File Offset: 0x00052506
		private void Sealed()
		{
			base.CurrentInstruction = "Place packaging in hopper";
			this.station.SetHatchOpen(true);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0005431F File Offset: 0x0005251F
		private void ReachedOutput()
		{
			this.Success();
		}

		// Token: 0x04001257 RID: 4695
		protected PackagingStation station;

		// Token: 0x04001258 RID: 4696
		protected FunctionalPackaging Packaging;

		// Token: 0x04001259 RID: 4697
		protected List<FunctionalProduct> Products = new List<FunctionalProduct>();
	}
}
