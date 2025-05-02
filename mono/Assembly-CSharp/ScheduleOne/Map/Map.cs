using System;
using System.Collections;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using ScheduleOne.Persistence;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Map
{
	// Token: 0x02000C1F RID: 3103
	public class Map : Singleton<Map>
	{
		// Token: 0x06005720 RID: 22304 RVA: 0x0016E378 File Offset: 0x0016C578
		protected override void Awake()
		{
			base.Awake();
			if (!GameManager.IS_TUTORIAL)
			{
				using (IEnumerator enumerator = Enum.GetValues(typeof(EMapRegion)).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						EMapRegion region = (EMapRegion)enumerator.Current;
						if (this.Regions == null || Array.Find<MapRegionData>(this.Regions, (MapRegionData x) => x.Region == region) == null)
						{
							Console.LogError(string.Format("No region data found for {0}", region), null);
						}
					}
				}
			}
			if (this.TreeBounds != null)
			{
				this.TreeBounds.gameObject.SetActive(false);
			}
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x0016E44C File Offset: 0x0016C64C
		protected override void Start()
		{
			base.Start();
			LevelManager instance = NetworkSingleton<LevelManager>.Instance;
			instance.onRankUp = (Action<FullRank, FullRank>)Delegate.Combine(instance.onRankUp, new Action<FullRank, FullRank>(this.OnRankUp));
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.GameLoaded));
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x0016E4A0 File Offset: 0x0016C6A0
		protected override void OnDestroy()
		{
			if (Singleton<LoadManager>.InstanceExists)
			{
				Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.GameLoaded));
			}
			base.OnDestroy();
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x0016E4CC File Offset: 0x0016C6CC
		public MapRegionData GetRegionData(EMapRegion region)
		{
			return Array.Find<MapRegionData>(this.Regions, (MapRegionData x) => x.Region == region);
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x0016E500 File Offset: 0x0016C700
		private void GameLoaded()
		{
			foreach (MapRegionData mapRegionData in this.Regions)
			{
				if (mapRegionData.IsUnlocked)
				{
					mapRegionData.SetUnlocked();
				}
			}
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x0016E534 File Offset: 0x0016C734
		private void OnRankUp(FullRank oldRank, FullRank newRank)
		{
			foreach (MapRegionData mapRegionData in this.Regions)
			{
				if (oldRank < mapRegionData.RankRequirement && newRank >= mapRegionData.RankRequirement)
				{
					mapRegionData.SetUnlocked();
					if (!Singleton<LoadManager>.Instance.IsLoading)
					{
						Singleton<RegionUnlockedCanvas>.Instance.QueueUnlocked(mapRegionData.Region);
					}
				}
			}
		}

		// Token: 0x0400407F RID: 16511
		public MapRegionData[] Regions;

		// Token: 0x04004080 RID: 16512
		[Header("References")]
		public PoliceStation PoliceStation;

		// Token: 0x04004081 RID: 16513
		public MedicalCentre MedicalCentre;

		// Token: 0x04004082 RID: 16514
		public Transform TreeBounds;
	}
}
