using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x0200039C RID: 924
	public class TimeLoader : Loader
	{
		// Token: 0x060014AC RID: 5292 RVA: 0x0005C804 File Offset: 0x0005AA04
		public override void Load(string mainPath)
		{
			string text;
			if (base.TryLoadFile(mainPath, out text, true))
			{
				TimeData timeData = JsonUtility.FromJson<TimeData>(text);
				if (timeData != null)
				{
					NetworkSingleton<TimeManager>.Instance.SetTime(timeData.TimeOfDay, false);
					NetworkSingleton<TimeManager>.Instance.SetElapsedDays(timeData.ElapsedDays);
					NetworkSingleton<TimeManager>.Instance.SetPlaytime((float)timeData.Playtime);
				}
			}
		}
	}
}
