using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000703 RID: 1795
	[Serializable]
	public struct DisplaySettings
	{
		// Token: 0x060030B6 RID: 12470 RVA: 0x000CAA44 File Offset: 0x000C8C44
		public static List<Resolution> GetResolutions()
		{
			Resolution[] resolutions = Screen.resolutions;
			RefreshRate refreshRateRatio = resolutions[resolutions.Length - 1].refreshRateRatio;
			float num = refreshRateRatio.numerator / refreshRateRatio.denominator;
			List<Resolution> list = new List<Resolution>();
			int i;
			Predicate<Resolution> <>9__0;
			int j;
			for (i = 0; i < resolutions.Length; i = j + 1)
			{
				List<Resolution> list2 = list;
				Predicate<Resolution> match;
				if ((match = <>9__0) == null)
				{
					match = (<>9__0 = ((Resolution x) => x.width == resolutions[i].width && x.height == resolutions[i].height));
				}
				if (!list2.Exists(match))
				{
					Resolution item = resolutions[i];
					if (item.refreshRateRatio.numerator / item.refreshRateRatio.denominator >= num - 0.1f)
					{
						list.Add(item);
					}
				}
				j = i;
			}
			return list;
		}

		// Token: 0x040022A3 RID: 8867
		public int ResolutionIndex;

		// Token: 0x040022A4 RID: 8868
		public DisplaySettings.EDisplayMode DisplayMode;

		// Token: 0x040022A5 RID: 8869
		public bool VSync;

		// Token: 0x040022A6 RID: 8870
		public int TargetFPS;

		// Token: 0x040022A7 RID: 8871
		public float UIScale;

		// Token: 0x040022A8 RID: 8872
		public float CameraBobbing;

		// Token: 0x040022A9 RID: 8873
		public int ActiveDisplayIndex;

		// Token: 0x02000704 RID: 1796
		public enum EDisplayMode
		{
			// Token: 0x040022AB RID: 8875
			Windowed,
			// Token: 0x040022AC RID: 8876
			FullscreenWindow,
			// Token: 0x040022AD RID: 8877
			ExclusiveFullscreen
		}
	}
}
