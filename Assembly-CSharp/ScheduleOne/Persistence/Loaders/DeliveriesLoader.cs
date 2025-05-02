using System;
using System.Collections.Generic;
using System.IO;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000385 RID: 901
	public class DeliveriesLoader : Loader
	{
		// Token: 0x06001475 RID: 5237 RVA: 0x0005B690 File Offset: 0x00059890
		public override void Load(string mainPath)
		{
			if (!Directory.Exists(mainPath))
			{
				return;
			}
			string text;
			if (base.TryLoadFile(Path.Combine(mainPath, "Deliveries"), out text, true))
			{
				DeliveriesData deliveriesData = null;
				try
				{
					deliveriesData = JsonUtility.FromJson<DeliveriesData>(text);
				}
				catch (Exception ex)
				{
					Debug.LogError("Error loading data: " + ex.Message);
				}
				if (deliveriesData != null && deliveriesData.ActiveDeliveries != null)
				{
					foreach (DeliveryInstance delivery in deliveriesData.ActiveDeliveries)
					{
						NetworkSingleton<DeliveryManager>.Instance.SendDelivery(delivery);
					}
				}
			}
			string parentPath = Path.Combine(mainPath, "DeliveryVehicles");
			List<DirectoryInfo> directories = base.GetDirectories(parentPath);
			for (int j = 0; j < directories.Count; j++)
			{
				this.LoadVehicle(directories[j].FullName);
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0005B768 File Offset: 0x00059968
		public void LoadVehicle(string vehiclePath)
		{
			Console.Log("Loading delivery vehicle: " + vehiclePath, null);
			string text;
			if (base.TryLoadFile(vehiclePath, "Vehicle", out text))
			{
				VehicleData vehicleData = null;
				try
				{
					vehicleData = JsonUtility.FromJson<VehicleData>(text);
				}
				catch (Exception ex)
				{
					Type type = base.GetType();
					string str = (type != null) ? type.ToString() : null;
					string str2 = " error reading data: ";
					Exception ex2 = ex;
					Console.LogError(str + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				}
				string str3 = "Data: ";
				VehicleData vehicleData2 = vehicleData;
				Console.Log(str3 + ((vehicleData2 != null) ? vehicleData2.ToString() : null), null);
				if (vehicleData != null)
				{
					NetworkSingleton<VehicleManager>.Instance.LoadVehicle(vehicleData, vehiclePath);
				}
			}
		}
	}
}
