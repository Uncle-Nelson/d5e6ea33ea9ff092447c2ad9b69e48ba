using System;
using System.Collections.Generic;
using System.IO;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200038F RID: 911
	public class PlayersLoader : Loader
	{
		// Token: 0x0600148D RID: 5261 RVA: 0x0005BBE4 File Offset: 0x00059DE4
		public override void Load(string mainPath)
		{
			PlayersLoader.<>c__DisplayClass1_0 CS$<>8__locals1 = new PlayersLoader.<>c__DisplayClass1_0();
			List<DirectoryInfo> directories = base.GetDirectories(mainPath);
			Console.Log("Loading players", null);
			CS$<>8__locals1.lastLoadRequest = null;
			PlayerLoader loader = new PlayerLoader();
			for (int i = 0; i < directories.Count; i++)
			{
				CS$<>8__locals1.lastLoadRequest = new LoadRequest(directories[i].FullName, loader);
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<Load>g__Wait|0());
		}
	}
}
