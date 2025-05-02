using System;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006D2 RID: 1746
	public class AchievementUtility : MonoBehaviour
	{
		// Token: 0x06002FAB RID: 12203 RVA: 0x000C6B42 File Offset: 0x000C4D42
		public void UnlockAchievement()
		{
			Singleton<AchievementManager>.Instance.UnlockAchievement(this.Achievement);
		}

		// Token: 0x040021CD RID: 8653
		public AchievementManager.EAchievement Achievement;
	}
}
