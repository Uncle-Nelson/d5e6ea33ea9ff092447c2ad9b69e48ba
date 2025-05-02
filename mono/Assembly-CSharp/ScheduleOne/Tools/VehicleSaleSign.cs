using System;
using ScheduleOne.Money;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087B RID: 2171
	public class VehicleSaleSign : MonoBehaviour
	{
		// Token: 0x06003AF6 RID: 15094 RVA: 0x000F83E4 File Offset: 0x000F65E4
		private void Awake()
		{
			LandVehicle componentInParent = base.GetComponentInParent<LandVehicle>();
			if (componentInParent != null)
			{
				this.NameLabel.text = componentInParent.VehicleName;
				this.PriceLabel.text = MoneyManager.FormatAmount(componentInParent.VehiclePrice, false, false);
			}
		}

		// Token: 0x04002A76 RID: 10870
		public TextMeshPro NameLabel;

		// Token: 0x04002A77 RID: 10871
		public TextMeshPro PriceLabel;
	}
}
