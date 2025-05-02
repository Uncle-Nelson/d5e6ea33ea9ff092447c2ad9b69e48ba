using System;
using System.Collections.Generic;
using System.IO;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000382 RID: 898
	public class BusinessesLoader : Loader
	{
		// Token: 0x0600146F RID: 5231 RVA: 0x0005B540 File Offset: 0x00059740
		public override void Load(string mainPath)
		{
			if (!Directory.Exists(mainPath))
			{
				return;
			}
			List<DirectoryInfo> directories = base.GetDirectories(mainPath);
			BusinessLoader loader = new BusinessLoader();
			for (int i = 0; i < directories.Count; i++)
			{
				new LoadRequest(directories[i].FullName, loader);
			}
		}
	}
}
