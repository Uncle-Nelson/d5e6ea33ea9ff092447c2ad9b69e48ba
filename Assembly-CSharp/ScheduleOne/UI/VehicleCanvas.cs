using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A56 RID: 2646
	public class VehicleCanvas : Singleton<VehicleCanvas>
	{
		// Token: 0x0600473E RID: 18238 RVA: 0x0012A5F8 File Offset: 0x001287F8
		protected override void Start()
		{
			base.Start();
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.Subscribe));
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0012A620 File Offset: 0x00128820
		private void Subscribe()
		{
			Player local = Player.Local;
			local.onEnterVehicle = (Player.VehicleEvent)Delegate.Combine(local.onEnterVehicle, new Player.VehicleEvent(this.VehicleEntered));
			Player local2 = Player.Local;
			local2.onExitVehicle = (Player.VehicleTransformEvent)Delegate.Combine(local2.onExitVehicle, new Player.VehicleTransformEvent(this.VehicleExited));
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x0012A679 File Offset: 0x00128879
		private void Update()
		{
			if (Player.Local == null)
			{
				return;
			}
			if (Player.Local.CurrentVehicle != null)
			{
				this.Canvas.enabled = !Singleton<GameplayMenu>.Instance.IsOpen;
			}
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x0012A6B3 File Offset: 0x001288B3
		private void LateUpdate()
		{
			if (this.currentVehicle != null)
			{
				this.UpdateSpeedText();
			}
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x0012A6C9 File Offset: 0x001288C9
		private void VehicleEntered(LandVehicle veh)
		{
			this.currentVehicle = veh;
			this.UpdateSpeedText();
			this.Canvas.enabled = true;
			this.DriverPromptsContainer.SetActive(this.currentVehicle.localPlayerIsDriver);
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x0012A6FA File Offset: 0x001288FA
		private void VehicleExited(LandVehicle veh, Transform exitPoint)
		{
			this.Canvas.enabled = false;
			this.currentVehicle = null;
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x0012A710 File Offset: 0x00128910
		private void UpdateSpeedText()
		{
			if (this.SpeedText == null)
			{
				return;
			}
			if (Singleton<Settings>.Instance.unitType == Settings.UnitType.Metric)
			{
				this.SpeedText.text = Mathf.Abs(this.currentVehicle.VelocityCalculator.Velocity.magnitude * 3.6f * 1.4f).ToString("0") + " km/h";
				return;
			}
			this.SpeedText.text = Mathf.Abs(this.currentVehicle.VelocityCalculator.Velocity.magnitude * 2.23694f * 1.4f).ToString("0") + " mph";
		}

		// Token: 0x040034AB RID: 13483
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040034AC RID: 13484
		public TextMeshProUGUI SpeedText;

		// Token: 0x040034AD RID: 13485
		public GameObject DriverPromptsContainer;

		// Token: 0x040034AE RID: 13486
		private LandVehicle currentVehicle;
	}
}
