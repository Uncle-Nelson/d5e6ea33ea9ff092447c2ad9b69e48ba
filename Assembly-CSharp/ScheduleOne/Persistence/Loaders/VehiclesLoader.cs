using System;
using System.Collections.Generic;
using System.IO;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x020003A0 RID: 928
	public class VehiclesLoader : Loader
	{
		// Token: 0x060014B4 RID: 5300 RVA: 0x0005CCE8 File Offset: 0x0005AEE8
		public override void Load(string mainPath)
		{
			if (!Directory.Exists(mainPath))
			{
				return;
			}
			List<DirectoryInfo> directories = base.GetDirectories(mainPath);
			VehicleLoader loader = new VehicleLoader();
			for (int i = 0; i < directories.Count; i++)
			{
				new LoadRequest(directories[i].FullName, loader);
			}
		}
	}
}
