using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using Steamworks;

namespace ScheduleOne
{
	// Token: 0x02000271 RID: 625
	public class AchievementManager : PersistentSingleton<AchievementManager>
	{
		// Token: 0x06000D16 RID: 3350 RVA: 0x0003A380 File Offset: 0x00038580
		protected override void Awake()
		{
			base.Awake();
			if (Singleton<AchievementManager>.Instance == null || Singleton<AchievementManager>.Instance != this)
			{
				return;
			}
			this.achievements = (AchievementManager.EAchievement[])Enum.GetValues(typeof(AchievementManager.EAchievement));
			foreach (AchievementManager.EAchievement key in this.achievements)
			{
				this.achievementUnlocked.Add(key, false);
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0003A3EE File Offset: 0x000385EE
		protected override void Start()
		{
			base.Start();
			if (Singleton<AchievementManager>.Instance == null || Singleton<AchievementManager>.Instance != this)
			{
				return;
			}
			this.PullAchievements();
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0003A418 File Offset: 0x00038618
		private void PullAchievements()
		{
			if (!SteamManager.Initialized)
			{
				Console.LogWarning("Steamworks not initialized, cannot pull achievement stats", null);
				return;
			}
			foreach (AchievementManager.EAchievement key in this.achievements)
			{
				bool value;
				SteamUserStats.GetAchievement(key.ToString(), out value);
				this.achievementUnlocked[key] = value;
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0003A474 File Offset: 0x00038674
		public void UnlockAchievement(AchievementManager.EAchievement achievement)
		{
			if (!SteamManager.Initialized)
			{
				Console.LogWarning("Steamworks not initialized, cannot unlock achievement", null);
				return;
			}
			if (this.achievementUnlocked[achievement])
			{
				return;
			}
			Console.Log(string.Format("Unlocking achievement: {0}", achievement), null);
			SteamUserStats.SetAchievement(achievement.ToString());
			SteamUserStats.StoreStats();
			this.achievementUnlocked[achievement] = true;
		}

		// Token: 0x04000D99 RID: 3481
		private AchievementManager.EAchievement[] achievements;

		// Token: 0x04000D9A RID: 3482
		private Dictionary<AchievementManager.EAchievement, bool> achievementUnlocked = new Dictionary<AchievementManager.EAchievement, bool>();

		// Token: 0x02000272 RID: 626
		public enum EAchievement
		{
			// Token: 0x04000D9C RID: 3484
			COMPLETE_PROLOGUE,
			// Token: 0x04000D9D RID: 3485
			RV_DESTROYED,
			// Token: 0x04000D9E RID: 3486
			DEALER_RECRUITED,
			// Token: 0x04000D9F RID: 3487
			MASTER_CHEF,
			// Token: 0x04000DA0 RID: 3488
			BUSINESSMAN,
			// Token: 0x04000DA1 RID: 3489
			BIGWIG,
			// Token: 0x04000DA2 RID: 3490
			MAGNATE,
			// Token: 0x04000DA3 RID: 3491
			UPSTANDING_CITIZEN,
			// Token: 0x04000DA4 RID: 3492
			ROLLING_IN_STYLE,
			// Token: 0x04000DA5 RID: 3493
			LONG_ARM_OF_THE_LAW,
			// Token: 0x04000DA6 RID: 3494
			INDIAN_DEALER
		}
	}
}
