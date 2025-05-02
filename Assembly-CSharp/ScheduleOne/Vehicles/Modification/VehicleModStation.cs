using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Vehicles.Modification
{
	// Token: 0x020007EA RID: 2026
	public class VehicleModStation : MonoBehaviour
	{
		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x000E8945 File Offset: 0x000E6B45
		// (set) Token: 0x06003745 RID: 14149 RVA: 0x000E894D File Offset: 0x000E6B4D
		public LandVehicle currentVehicle { get; protected set; }

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x000E8956 File Offset: 0x000E6B56
		public bool isOpen
		{
			get
			{
				return this.currentVehicle != null;
			}
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x000E8964 File Offset: 0x000E6B64
		public void Open(LandVehicle vehicle)
		{
			this.orbitCam.Enable();
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.currentVehicle = vehicle;
			vehicle.transform.rotation = this.vehiclePosition.rotation;
			vehicle.transform.position = this.vehiclePosition.position;
			vehicle.transform.position -= vehicle.transform.InverseTransformPoint(vehicle.boundingBox.transform.position);
			vehicle.transform.position += Vector3.up * vehicle.boundingBox.transform.localScale.y * 0.5f;
			Singleton<VehicleModMenu>.Instance.Open(this.currentVehicle);
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x000E8A75 File Offset: 0x000E6C75
		protected virtual void Update()
		{
			if (this.isOpen && GameInput.GetButtonDown(GameInput.ButtonCode.Escape))
			{
				this.Close();
			}
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x000E8A8E File Offset: 0x000E6C8E
		public void Close()
		{
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			this.orbitCam.Disable();
			Singleton<VehicleModMenu>.Instance.Close();
			this.currentVehicle = null;
		}

		// Token: 0x040027E6 RID: 10214
		[Header("References")]
		[SerializeField]
		protected Transform vehiclePosition;

		// Token: 0x040027E7 RID: 10215
		[SerializeField]
		protected OrbitCamera orbitCam;
	}
}
