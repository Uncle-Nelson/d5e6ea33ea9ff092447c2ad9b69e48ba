using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200038E RID: 910
	public class PlayerLoader : Loader
	{
		// Token: 0x0600148B RID: 5259 RVA: 0x0005BB68 File Offset: 0x00059D68
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, "Player", out text))
			{
				PlayerData playerData = null;
				try
				{
					playerData = JsonUtility.FromJson<PlayerData>(text);
				}
				catch (Exception ex)
				{
					Type type = base.GetType();
					string str = (type != null) ? type.ToString() : null;
					string str2 = " error reading data: ";
					Exception ex2 = ex;
					Console.LogError(str + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				}
				if (playerData != null)
				{
					Singleton<PlayerManager>.Instance.LoadPlayer(playerData, mainPath);
				}
			}
		}
	}
}
