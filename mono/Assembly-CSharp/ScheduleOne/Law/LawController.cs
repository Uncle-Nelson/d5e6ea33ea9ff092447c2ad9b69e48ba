using System;
using System.Collections.Generic;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Law
{
	// Token: 0x020005CC RID: 1484
	public class LawController : Singleton<LawController>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x00094054 File Offset: 0x00092254
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x0009405C File Offset: 0x0009225C
		public bool OverrideSettings { get; protected set; }

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x00094065 File Offset: 0x00092265
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x0009406D File Offset: 0x0009226D
		public LawActivitySettings OverriddenSettings { get; protected set; }

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x00094076 File Offset: 0x00092276
		// (set) Token: 0x060024B2 RID: 9394 RVA: 0x0009407E File Offset: 0x0009227E
		public LawActivitySettings CurrentSettings { get; protected set; }

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x00094087 File Offset: 0x00092287
		public string SaveFolderName
		{
			get
			{
				return "Law";
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x00094087 File Offset: 0x00092287
		public string SaveFileName
		{
			get
			{
				return "Law";
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x0009408E File Offset: 0x0009228E
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x00094096 File Offset: 0x00092296
		// (set) Token: 0x060024B8 RID: 9400 RVA: 0x0009409E File Offset: 0x0009229E
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x000940A7 File Offset: 0x000922A7
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x000940AF File Offset: 0x000922AF
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x000940B8 File Offset: 0x000922B8
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x000940C0 File Offset: 0x000922C0
		public bool HasChanged { get; set; }

		// Token: 0x060024BD RID: 9405 RVA: 0x000940C9 File Offset: 0x000922C9
		protected override void Awake()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x000940D8 File Offset: 0x000922D8
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onHourPass = (Action)Delegate.Combine(instance2.onHourPass, new Action(this.HourPass));
			TimeManager instance3 = NetworkSingleton<TimeManager>.Instance;
			instance3.onDayPass = (Action)Delegate.Combine(instance3.onDayPass, new Action(this.DayPass));
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.OnLoadComplete));
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00094178 File Offset: 0x00092378
		protected override void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
				TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
				instance2.onHourPass = (Action)Delegate.Remove(instance2.onHourPass, new Action(this.HourPass));
				TimeManager instance3 = NetworkSingleton<TimeManager>.Instance;
				instance3.onDayPass = (Action)Delegate.Remove(instance3.onDayPass, new Action(this.DayPass));
			}
			base.OnDestroy();
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00094204 File Offset: 0x00092404
		private void OnLoadComplete()
		{
			this.GetSettings().OnLoaded();
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00094214 File Offset: 0x00092414
		private void MinPass()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			LawActivitySettings settings = this.GetSettings();
			if (settings != this.CurrentSettings)
			{
				if (this.CurrentSettings != null)
				{
					this.CurrentSettings.End();
				}
				this.CurrentSettings = settings;
			}
			this.CurrentSettings.Evaluate();
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x0009425E File Offset: 0x0009245E
		private void HourPass()
		{
			bool isServer = InstanceFinder.IsServer;
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00094266 File Offset: 0x00092466
		private void DayPass()
		{
			if (InstanceFinder.IsServer)
			{
				this.ChangeInternalIntensity(this.IntensityIncreasePerDay / 10f);
			}
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00094281 File Offset: 0x00092481
		public LawActivitySettings GetSettings()
		{
			if (this.OverrideSettings && this.OverriddenSettings != null)
			{
				return this.OverriddenSettings;
			}
			return this.GetSettings(NetworkSingleton<TimeManager>.Instance.CurrentDay);
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x000942AC File Offset: 0x000924AC
		public LawActivitySettings GetSettings(EDay day)
		{
			switch (day)
			{
			case EDay.Monday:
				return this.MondaySettings;
			case EDay.Tuesday:
				return this.TuesdaySettings;
			case EDay.Wednesday:
				return this.WednesdaySettings;
			case EDay.Thursday:
				return this.ThursdaySettings;
			case EDay.Friday:
				return this.FridaySettings;
			case EDay.Saturday:
				return this.SaturdaySettings;
			case EDay.Sunday:
				return this.SundaySettings;
			default:
				return null;
			}
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0009430F File Offset: 0x0009250F
		public void OverrideSetings(LawActivitySettings settings)
		{
			this.OverrideSettings = true;
			this.OverriddenSettings = settings;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x0009431F File Offset: 0x0009251F
		public void EndOverride()
		{
			this.OverrideSettings = false;
			this.OverriddenSettings = null;
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0009432F File Offset: 0x0009252F
		public void ChangeInternalIntensity(float change)
		{
			this.internalLawIntensity = Mathf.Clamp01(this.internalLawIntensity + change);
			this.LE_Intensity = Mathf.RoundToInt(Mathf.Lerp(1f, 10f, this.internalLawIntensity));
			this.HasChanged = true;
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0009436B File Offset: 0x0009256B
		public void SetInternalIntensity(float intensity)
		{
			this.internalLawIntensity = Mathf.Clamp01(intensity);
			this.LE_Intensity = Mathf.RoundToInt(Mathf.Lerp(1f, 10f, this.internalLawIntensity));
			this.HasChanged = true;
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x000943A0 File Offset: 0x000925A0
		public virtual string GetSaveString()
		{
			return new LawData(this.internalLawIntensity).GetJson(true);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000943B3 File Offset: 0x000925B3
		public void Load(LawData data)
		{
			this.SetInternalIntensity(data.InternalLawIntensity);
		}

		// Token: 0x04001B44 RID: 6980
		public const float DAILY_INTENSITY_DRAIN = 0.05f;

		// Token: 0x04001B45 RID: 6981
		[Range(1f, 10f)]
		public int LE_Intensity = 1;

		// Token: 0x04001B46 RID: 6982
		private float internalLawIntensity;

		// Token: 0x04001B47 RID: 6983
		[Header("Settings")]
		public LawActivitySettings MondaySettings;

		// Token: 0x04001B48 RID: 6984
		public LawActivitySettings TuesdaySettings;

		// Token: 0x04001B49 RID: 6985
		public LawActivitySettings WednesdaySettings;

		// Token: 0x04001B4A RID: 6986
		public LawActivitySettings ThursdaySettings;

		// Token: 0x04001B4B RID: 6987
		public LawActivitySettings FridaySettings;

		// Token: 0x04001B4C RID: 6988
		public LawActivitySettings SaturdaySettings;

		// Token: 0x04001B4D RID: 6989
		public LawActivitySettings SundaySettings;

		// Token: 0x04001B4E RID: 6990
		[Header("Demo Settings")]
		public float IntensityIncreasePerDay = 1.5f;

		// Token: 0x04001B52 RID: 6994
		private LawLoader loader = new LawLoader();
	}
}
