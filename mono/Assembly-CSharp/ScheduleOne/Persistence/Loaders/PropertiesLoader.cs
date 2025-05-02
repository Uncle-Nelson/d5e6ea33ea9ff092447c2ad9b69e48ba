using System;
using System.Collections.Generic;
using System.IO;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000393 RID: 915
	public class PropertiesLoader : Loader
	{
		// Token: 0x0600149A RID: 5274 RVA: 0x0005C068 File Offset: 0x0005A268
		public override void Load(string mainPath)
		{
			if (!Directory.Exists(mainPath))
			{
				return;
			}
			List<DirectoryInfo> directories = base.GetDirectories(mainPath);
			PropertyLoader loader = new PropertyLoader();
			for (int i = 0; i < directories.Count; i++)
			{
				new LoadRequest(directories[i].FullName, loader);
			}
		}
	}
}
