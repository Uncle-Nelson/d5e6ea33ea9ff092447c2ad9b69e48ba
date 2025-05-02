using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000397 RID: 919
	public class RankLoader : Loader
	{
		// Token: 0x060014A2 RID: 5282 RVA: 0x0005C5B4 File Offset: 0x0005A7B4
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, out text, true))
			{
				RankData rankData = null;
				try
				{
					rankData = JsonUtility.FromJson<RankData>(text);
				}
				catch (Exception ex)
				{
					Debug.LogError("Failed to load rank data: " + ex.Message);
				}
				if (rankData != null)
				{
					NetworkSingleton<LevelManager>.Instance.SetData(null, (ERank)rankData.Rank, rankData.Tier, rankData.XP, rankData.TotalXP);
				}
			}
		}
	}
}
