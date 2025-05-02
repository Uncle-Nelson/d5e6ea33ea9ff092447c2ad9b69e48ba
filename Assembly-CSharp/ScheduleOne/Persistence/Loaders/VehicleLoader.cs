using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200039F RID: 927
	public class VehicleLoader : Loader
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x0005CC6C File Offset: 0x0005AE6C
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, "Vehicle", out text))
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
				if (vehicleData != null)
				{
					NetworkSingleton<VehicleManager>.Instance.SpawnAndLoadVehicle(vehicleData, mainPath, true);
				}
			}
		}
	}
}
