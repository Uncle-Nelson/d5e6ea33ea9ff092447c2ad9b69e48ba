using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000386 RID: 902
	public class GameDataLoader : Loader
	{
		// Token: 0x06001478 RID: 5240 RVA: 0x0005B810 File Offset: 0x00059A10
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, out text, true))
			{
				GameData gameData = JsonUtility.FromJson<GameData>(text);
				if (gameData != null)
				{
					NetworkSingleton<GameManager>.Instance.Load(gameData, mainPath);
				}
			}
		}
	}
}
