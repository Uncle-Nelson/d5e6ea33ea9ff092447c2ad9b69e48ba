using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.ConstructableScripts
{
	// Token: 0x0200092E RID: 2350
	public class LoadingDock : Constructable_GridBased
	{
		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06003F94 RID: 16276 RVA: 0x0010C4CA File Offset: 0x0010A6CA
		public bool isOccupied
		{
			get
			{
				return this.vehicleDetector.vehicles.Count > 0;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06003F95 RID: 16277 RVA: 0x0010C4DF File Offset: 0x0010A6DF
		// (set) Token: 0x06003F96 RID: 16278 RVA: 0x0010C4E7 File Offset: 0x0010A6E7
		public LandVehicle reservant { get; protected set; }

		// Token: 0x06003F97 RID: 16279 RVA: 0x0010C4F0 File Offset: 0x0010A6F0
		private void Start()
		{
			this.reservationBlocker.gameObject.SetActive(false);
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x0010C504 File Offset: 0x0010A704
		protected virtual void Update()
		{
			if (this.vehicleDetector.vehicles.Count > 0 && !this.vehicleDetector.closestVehicle.isOccupied)
			{
				this.wallsOpen = true;
			}
			else
			{
				this.wallsOpen = false;
			}
			bool isOccupied = this.isOccupied;
			if (this.vehicleDetector.closestVehicle != null)
			{
				if (this.currentOccupant != this.vehicleDetector.closestVehicle && this.currentOccupant != null)
				{
					this.currentOccupant = this.vehicleDetector.closestVehicle;
					return;
				}
			}
			else if (this.currentOccupant != null)
			{
				this.currentOccupant = null;
			}
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x0010C5B0 File Offset: 0x0010A7B0
		protected virtual void LateUpdate()
		{
			if (this.isOccupied)
			{
				MeshRenderer[] array = this.redLightMeshes;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].material = this.redLightMat_On;
				}
				array = this.greenLightMeshes;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].material = this.greenLightMat_Off;
				}
			}
			else
			{
				MeshRenderer[] array = this.redLightMeshes;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].material = this.redLightMat_Off;
				}
				array = this.greenLightMeshes;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].material = this.greenLightMat_On;
				}
			}
			float max = 0.387487f;
			float min = -0.35f;
			if (this.wallsOpen)
			{
				foreach (Transform transform in this.sideWalls)
				{
					transform.transform.localPosition = new Vector3(transform.transform.localPosition.x, Mathf.Clamp(transform.transform.localPosition.y - Time.deltaTime, min, max), transform.transform.localPosition.z);
				}
				return;
			}
			foreach (Transform transform2 in this.sideWalls)
			{
				transform2.transform.localPosition = new Vector3(transform2.transform.localPosition.x, Mathf.Clamp(transform2.transform.localPosition.y + Time.deltaTime, min, max), transform2.transform.localPosition.z);
			}
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x0010C744 File Offset: 0x0010A944
		public override bool CanBeDestroyed(out string reason)
		{
			if (this.reservant != null)
			{
				reason = "Reserved for dealer";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x0010C764 File Offset: 0x0010A964
		public override void DestroyConstructable(bool callOnServer = true)
		{
			if (this.isOccupied && this.vehicleDetector.closestVehicle != null)
			{
				this.vehicleDetector.closestVehicle.Rb.isKinematic = false;
			}
			base.DestroyConstructable(callOnServer);
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x0010C7A0 File Offset: 0x0010A9A0
		public void SetReservant(LandVehicle _res)
		{
			if (this.reservant != null)
			{
				Collider[] componentsInChildren = this.reservant.GetComponentsInChildren<Collider>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					Physics.IgnoreCollision(componentsInChildren[i], this.reservationBlocker, false);
				}
			}
			this.reservant = _res;
			if (this.reservant != null)
			{
				this.gateAnim.Play("LoadingDock_Gate_Close");
			}
			else
			{
				this.gateAnim.Play("LoadingDock_Gate_Open");
			}
			if (this.reservant != null)
			{
				Collider[] componentsInChildren2 = this.reservant.GetComponentsInChildren<Collider>();
				for (int j = 0; j < componentsInChildren2.Length; j++)
				{
					Physics.IgnoreCollision(componentsInChildren2[j], this.reservationBlocker, true);
				}
			}
			this.reservationBlocker.gameObject.SetActive(this.reservant != null);
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x0010C870 File Offset: 0x0010AA70
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x0010C889 File Offset: 0x0010AA89
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x0010C8A2 File Offset: 0x0010AAA2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0010C8B0 File Offset: 0x0010AAB0
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002DBB RID: 11707
		[Header("References")]
		[SerializeField]
		protected VehicleDetector vehicleDetector;

		// Token: 0x04002DBC RID: 11708
		[SerializeField]
		protected MeshRenderer[] redLightMeshes;

		// Token: 0x04002DBD RID: 11709
		[SerializeField]
		protected MeshRenderer[] greenLightMeshes;

		// Token: 0x04002DBE RID: 11710
		[SerializeField]
		protected Transform[] sideWalls;

		// Token: 0x04002DBF RID: 11711
		[SerializeField]
		protected Animation gateAnim;

		// Token: 0x04002DC0 RID: 11712
		[SerializeField]
		protected Collider reservationBlocker;

		// Token: 0x04002DC1 RID: 11713
		public Transform vehiclePosition;

		// Token: 0x04002DC2 RID: 11714
		[Header("Materials")]
		[SerializeField]
		protected Material redLightMat_On;

		// Token: 0x04002DC3 RID: 11715
		[SerializeField]
		protected Material redLightMat_Off;

		// Token: 0x04002DC4 RID: 11716
		[SerializeField]
		protected Material greenLightMat_On;

		// Token: 0x04002DC5 RID: 11717
		[SerializeField]
		protected Material greenLightMat_Off;

		// Token: 0x04002DC6 RID: 11718
		private bool wallsOpen;

		// Token: 0x04002DC7 RID: 11719
		private LandVehicle currentOccupant;

		// Token: 0x04002DC9 RID: 11721
		private bool dll_Excuted;

		// Token: 0x04002DCA RID: 11722
		private bool dll_Excuted;
	}
}
