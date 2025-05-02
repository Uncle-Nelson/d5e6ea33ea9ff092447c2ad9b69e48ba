using System;
using System.Collections.Generic;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x02000680 RID: 1664
	public class SupplierLocation : MonoBehaviour
	{
		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x000C0AF7 File Offset: 0x000BECF7
		public bool IsOccupied
		{
			get
			{
				return this.ActiveSupplier != null;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x000C0B05 File Offset: 0x000BED05
		// (set) Token: 0x06002DFD RID: 11773 RVA: 0x000C0B0D File Offset: 0x000BED0D
		public Supplier ActiveSupplier { get; private set; }

		// Token: 0x06002DFE RID: 11774 RVA: 0x000C0B18 File Offset: 0x000BED18
		public void Awake()
		{
			SupplierLocation.AllLocations.Add(this);
			this.GenericContainer.gameObject.SetActive(false);
			WorldStorageEntity[] deliveryBays = this.DeliveryBays;
			for (int i = 0; i < deliveryBays.Length; i++)
			{
				deliveryBays[i].transform.Find("Container").gameObject.SetActive(false);
			}
			this.configs = base.GetComponentsInChildren<SupplierLocationConfiguration>();
			SupplierLocationConfiguration[] array = this.configs;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Deactivate();
			}
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x000C0B9C File Offset: 0x000BED9C
		private void OnDestroy()
		{
			SupplierLocation.AllLocations.Remove(this);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x000C0BAC File Offset: 0x000BEDAC
		public void SetActiveSupplier(Supplier supplier)
		{
			this.ActiveSupplier = supplier;
			this.GenericContainer.gameObject.SetActive(this.ActiveSupplier != null);
			WorldStorageEntity[] deliveryBays = this.DeliveryBays;
			for (int i = 0; i < deliveryBays.Length; i++)
			{
				deliveryBays[i].transform.Find("Container").gameObject.SetActive(this.ActiveSupplier != null);
			}
			if (supplier != null)
			{
				this.PoI.SetMainText("Supplier Meeting\n(" + supplier.fullName + ")");
			}
			foreach (SupplierLocationConfiguration supplierLocationConfiguration in this.configs)
			{
				if (this.ActiveSupplier != null && supplierLocationConfiguration.SupplierID == this.ActiveSupplier.ID)
				{
					supplierLocationConfiguration.Activate();
				}
				else
				{
					supplierLocationConfiguration.Deactivate();
				}
			}
		}

		// Token: 0x0400209D RID: 8349
		public static List<SupplierLocation> AllLocations = new List<SupplierLocation>();

		// Token: 0x0400209F RID: 8351
		[Header("Settings")]
		public string LocationName;

		// Token: 0x040020A0 RID: 8352
		public string LocationDescription;

		// Token: 0x040020A1 RID: 8353
		[Header("References")]
		public Transform GenericContainer;

		// Token: 0x040020A2 RID: 8354
		public Transform SupplierStandPoint;

		// Token: 0x040020A3 RID: 8355
		public WorldStorageEntity[] DeliveryBays;

		// Token: 0x040020A4 RID: 8356
		public POI PoI;

		// Token: 0x040020A5 RID: 8357
		private SupplierLocationConfiguration[] configs;
	}
}
