using System;
using System.Collections.Generic;
using System.IO;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200038D RID: 909
	public class NPCsLoader : Loader
	{
		// Token: 0x06001489 RID: 5257 RVA: 0x0005BB28 File Offset: 0x00059D28
		public override void Load(string mainPath)
		{
			List<DirectoryInfo> directories = base.GetDirectories(mainPath);
			NPCLoader loader = new NPCLoader();
			for (int i = 0; i < directories.Count; i++)
			{
				new LoadRequest(directories[i].FullName, loader);
			}
		}
	}
}
