using System;
using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000700 RID: 1792
	public class VehicleSelector : Singleton<VehicleSelector>
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000CA65B File Offset: 0x000C885B
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x000CA663 File Offset: 0x000C8863
		public bool isSelecting { get; protected set; }

		// Token: 0x060030AB RID: 12459 RVA: 0x000CA66C File Offset: 0x000C886C
		protected override void Start()
		{
			base.Start();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 8);
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x000CA688 File Offset: 0x000C8888
		protected virtual void Update()
		{
			if (this.isSelecting)
			{
				this.hoveredVehicle = this.GetHoveredVehicle();
				if (this.hoveredVehicle != null)
				{
					Singleton<HUD>.Instance.ShowRadialIndicator(1f);
				}
				if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) && this.hoveredVehicle != null && (this.vehicleFilter == null || this.vehicleFilter(this.hoveredVehicle)))
				{
					if (this.selectedVehicles.Contains(this.hoveredVehicle))
					{
						Console.Log("Deselected: " + this.hoveredVehicle.VehicleName, null);
						this.selectedVehicles.Remove(this.hoveredVehicle);
						return;
					}
					if (this.selectedVehicles.Count < this.selectionLimit)
					{
						this.selectedVehicles.Add(this.hoveredVehicle);
						if (this.selectedVehicles.Count >= this.selectionLimit && this.exitOnSelectionLimit)
						{
							this.StopSelecting();
						}
					}
				}
			}
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x000CA78C File Offset: 0x000C898C
		protected virtual void LateUpdate()
		{
			if (this.isSelecting)
			{
				for (int i = 0; i < this.outlinedVehicles.Count; i++)
				{
					this.outlinedVehicles[i].HideOutline();
				}
				this.outlinedVehicles.Clear();
				for (int j = 0; j < this.selectedVehicles.Count; j++)
				{
					this.selectedVehicles[j].ShowOutline(BuildableItem.EOutlineColor.Blue);
					this.outlinedVehicles.Add(this.selectedVehicles[j]);
				}
				if (this.hoveredVehicle != null)
				{
					if (this.selectedVehicles.Contains(this.hoveredVehicle))
					{
						this.hoveredVehicle.ShowOutline(BuildableItem.EOutlineColor.LightBlue);
						return;
					}
					this.hoveredVehicle.ShowOutline(BuildableItem.EOutlineColor.White);
					this.outlinedVehicles.Add(this.hoveredVehicle);
				}
			}
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x000CA860 File Offset: 0x000C8A60
		private LandVehicle GetHoveredVehicle()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(this.detectionRange, out raycastHit, this.detectionMask, false, 0.1f))
			{
				LandVehicle componentInParent = raycastHit.collider.GetComponentInParent<LandVehicle>();
				if (componentInParent != null && (this.vehicleFilter == null || this.vehicleFilter(componentInParent)))
				{
					return componentInParent;
				}
			}
			return null;
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x000CA8BC File Offset: 0x000C8ABC
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (action.exitType == ExitType.Escape && this.isSelecting)
			{
				action.used = true;
				this.StopSelecting();
			}
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000CA8E8 File Offset: 0x000C8AE8
		public void StartSelecting(string selectionTitle, ref List<LandVehicle> initialSelection, int _selectionLimit, bool _exitOnSelectionLimit, Func<LandVehicle, bool> filter = null)
		{
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.selectedVehicles = initialSelection;
			for (int i = 0; i < this.selectedVehicles.Count; i++)
			{
				this.selectedVehicles[i].ShowOutline(BuildableItem.EOutlineColor.White);
				this.outlinedVehicles.Add(this.selectedVehicles[i]);
			}
			this.selectionLimit = _selectionLimit;
			this.vehicleFilter = filter;
			Singleton<HUD>.Instance.ShowTopScreenText(selectionTitle);
			this.isSelecting = true;
			this.exitOnSelectionLimit = _exitOnSelectionLimit;
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x000CA978 File Offset: 0x000C8B78
		public void StopSelecting()
		{
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			this.vehicleFilter = null;
			for (int i = 0; i < this.outlinedVehicles.Count; i++)
			{
				this.outlinedVehicles[i].HideOutline();
			}
			this.outlinedVehicles.Clear();
			if (this.onClose != null)
			{
				this.onClose();
			}
			Singleton<HUD>.Instance.HideTopScreenText();
			this.isSelecting = false;
		}

		// Token: 0x04002292 RID: 8850
		[Header("Settings")]
		[SerializeField]
		protected float detectionRange = 5f;

		// Token: 0x04002293 RID: 8851
		[SerializeField]
		protected LayerMask detectionMask;

		// Token: 0x04002295 RID: 8853
		private List<LandVehicle> selectedVehicles = new List<LandVehicle>();

		// Token: 0x04002296 RID: 8854
		public Action onClose;

		// Token: 0x04002297 RID: 8855
		private int selectionLimit;

		// Token: 0x04002298 RID: 8856
		private bool exitOnSelectionLimit;

		// Token: 0x04002299 RID: 8857
		private LandVehicle hoveredVehicle;

		// Token: 0x0400229A RID: 8858
		private List<LandVehicle> outlinedVehicles = new List<LandVehicle>();

		// Token: 0x0400229B RID: 8859
		private Func<LandVehicle, bool> vehicleFilter;
	}
}
