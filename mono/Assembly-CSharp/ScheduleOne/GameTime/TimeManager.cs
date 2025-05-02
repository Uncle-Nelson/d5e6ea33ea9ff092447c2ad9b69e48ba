using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Networking;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002AB RID: 683
	public class TimeManager : NetworkSingleton<TimeManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0003FB2A File Offset: 0x0003DD2A
		public bool IsEndOfDay
		{
			get
			{
				return this.CurrentTime == 400;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0003FB39 File Offset: 0x0003DD39
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x0003FB41 File Offset: 0x0003DD41
		public bool SleepInProgress { get; protected set; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0003FB4A File Offset: 0x0003DD4A
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x0003FB52 File Offset: 0x0003DD52
		public int ElapsedDays { get; protected set; }

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003FB5B File Offset: 0x0003DD5B
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x0003FB63 File Offset: 0x0003DD63
		public int CurrentTime { get; protected set; }

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0003FB6C File Offset: 0x0003DD6C
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x0003FB74 File Offset: 0x0003DD74
		public float TimeOnCurrentMinute { get; protected set; }

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0003FB7D File Offset: 0x0003DD7D
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x0003FB85 File Offset: 0x0003DD85
		public int DailyMinTotal { get; protected set; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0003FB8E File Offset: 0x0003DD8E
		public bool IsNight
		{
			get
			{
				return this.CurrentTime < 600 || this.CurrentTime >= 1800;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0003FBAF File Offset: 0x0003DDAF
		public int DayIndex
		{
			get
			{
				return this.ElapsedDays % 7;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0003FBB9 File Offset: 0x0003DDB9
		public float NormalizedTime
		{
			get
			{
				return (float)this.DailyMinTotal / 1440f;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x0003FBC8 File Offset: 0x0003DDC8
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0003FBD0 File Offset: 0x0003DDD0
		public float Playtime { get; protected set; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0003FBD9 File Offset: 0x0003DDD9
		public EDay CurrentDay
		{
			get
			{
				return (EDay)this.DayIndex;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0003FBE1 File Offset: 0x0003DDE1
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x0003FBE9 File Offset: 0x0003DDE9
		public bool TimeOverridden { get; protected set; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0003FBF2 File Offset: 0x0003DDF2
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x0003FBFA File Offset: 0x0003DDFA
		public bool HostDailySummaryDone { get; private set; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0003FC03 File Offset: 0x0003DE03
		public string SaveFolderName
		{
			get
			{
				return "Time";
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0003FC03 File Offset: 0x0003DE03
		public string SaveFileName
		{
			get
			{
				return "Time";
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0003FC0A File Offset: 0x0003DE0A
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0003FC12 File Offset: 0x0003DE12
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x0003FC1A File Offset: 0x0003DE1A
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0003FC23 File Offset: 0x0003DE23
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x0003FC2B File Offset: 0x0003DE2B
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0003FC34 File Offset: 0x0003DE34
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x0003FC3C File Offset: 0x0003DE3C
		public bool HasChanged { get; set; }

		// Token: 0x06000E69 RID: 3689 RVA: 0x0003FC48 File Offset: 0x0003DE48
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.GameTime.TimeManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0003FC67 File Offset: 0x0003DE67
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (!connection.IsHost)
			{
				this.SendTimeData(connection);
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0003FC7F File Offset: 0x0003DE7F
		public override void OnStartClient()
		{
			base.OnStartClient();
			base.StartCoroutine(this.TimeLoop());
			base.StartCoroutine(this.TickLoop());
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0003FCA1 File Offset: 0x0003DEA1
		private void Clean()
		{
			ScheduleOne.GameTime.TimeManager.onSleepStart = null;
			ScheduleOne.GameTime.TimeManager.onSleepEnd = null;
			ScheduleOne.GameTime.TimeManager.onSleepStart = null;
			ScheduleOne.GameTime.TimeManager.onSleepEnd = null;
			this.onMinutePass = null;
			this.onHourPass = null;
			this.onDayPass = null;
			this.onTimeChanged = null;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0003FCD8 File Offset: 0x0003DED8
		public void SendTimeData(NetworkConnection connection)
		{
			TimeManager.<>c__DisplayClass94_0 CS$<>8__locals1 = new TimeManager.<>c__DisplayClass94_0();
			CS$<>8__locals1.connection = connection;
			CS$<>8__locals1.<>4__this = this;
			base.StartCoroutine(CS$<>8__locals1.<SendTimeData>g__WaitForPlayerReady|0());
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0003FD08 File Offset: 0x0003DF08
		[ObserversRpc(RunLocally = true, ExcludeServer = true)]
		[TargetRpc]
		private void SetData(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetData_2661156041(conn, _elapsedDays, _time, sendTime);
				this.RpcLogic___SetData_2661156041(conn, _elapsedDays, _time, sendTime);
			}
			else
			{
				this.RpcWriter___Target_SetData_2661156041(conn, _elapsedDays, _time, sendTime);
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0003FD64 File Offset: 0x0003DF64
		protected virtual void Update()
		{
			if (this.CurrentTime != 400)
			{
				this.TimeOnCurrentMinute += Time.deltaTime * this.TimeProgressionMultiplier;
			}
			this.Playtime += Time.unscaledDeltaTime;
			if (Time.timeScale >= 1f)
			{
				Time.fixedDeltaTime = this.defaultFixedTimeScale * Time.timeScale;
			}
			else
			{
				Time.fixedDeltaTime = this.defaultFixedTimeScale;
			}
			if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.RightArrow) && InstanceFinder.IsServer && (Application.isEditor || Debug.isDebugBuild))
			{
				for (int i = 0; i < 60; i++)
				{
					this.Tick();
				}
				this.SetData(null, this.ElapsedDays, this.CurrentTime, (float)(DateTime.UtcNow.Ticks / 10000000L));
			}
			if (InstanceFinder.IsHost)
			{
				if (this.SleepInProgress)
				{
					if (this.IsCurrentTimeWithinRange(this.sleepEndTime, ScheduleOne.GameTime.TimeManager.AddMinutesTo24HourTime(this.sleepEndTime, 60)))
					{
						this.EndSleep();
					}
				}
				else if (Player.AreAllPlayersReadyToSleep())
				{
					this.StartSleep();
				}
			}
			if (this.onUpdate != null)
			{
				this.onUpdate();
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0003FE8D File Offset: 0x0003E08D
		protected virtual void FixedUpdate()
		{
			if (this.onFixedUpdate != null)
			{
				this.onFixedUpdate();
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0003FEA2 File Offset: 0x0003E0A2
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void ResetHostSleepDone()
		{
			this.RpcWriter___Server_ResetHostSleepDone_2166136261();
			this.RpcLogic___ResetHostSleepDone_2166136261();
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0003FEB0 File Offset: 0x0003E0B0
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void MarkHostSleepDone()
		{
			this.RpcWriter___Server_MarkHostSleepDone_2166136261();
			this.RpcLogic___MarkHostSleepDone_2166136261();
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0003FEBE File Offset: 0x0003E0BE
		[ObserversRpc(RunLocally = true)]
		private void SetHostSleepDone(bool done)
		{
			this.RpcWriter___Observers_SetHostSleepDone_1140765316(done);
			this.RpcLogic___SetHostSleepDone_1140765316(done);
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0003FED4 File Offset: 0x0003E0D4
		private IEnumerator TickLoop()
		{
			float lastWaitExcess = 0f;
			while (base.gameObject != null)
			{
				if (Time.timeScale == 0f)
				{
					yield return new WaitUntil(() => Time.timeScale > 0f);
				}
				float timeToWait = 1f / Time.timeScale - lastWaitExcess;
				if (timeToWait > 0f)
				{
					float timeOnWaitStart = Time.realtimeSinceStartup;
					yield return new WaitForSecondsRealtime(timeToWait);
					float num = Time.realtimeSinceStartup - timeOnWaitStart;
					lastWaitExcess = Mathf.Max(num - timeToWait, 0f);
				}
				else
				{
					lastWaitExcess -= 1f;
				}
				try
				{
					if (this.onTick != null)
					{
						this.onTick();
					}
				}
				catch (Exception ex)
				{
					Console.LogError("Error invoking onTick: " + ex.Message + "\nSite:" + ex.StackTrace, null);
				}
				yield return null;
			}
			yield break;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0003FEE3 File Offset: 0x0003E0E3
		private IEnumerator TimeLoop()
		{
			float lastWaitExcess = 0f;
			while (base.gameObject != null)
			{
				if (this.TimeProgressionMultiplier <= 0f)
				{
					yield return new WaitUntil(() => this.TimeProgressionMultiplier > 0f);
				}
				if (Time.timeScale == 0f)
				{
					yield return new WaitUntil(() => Time.timeScale > 0f);
				}
				float timeToWait = 1f / (this.TimeProgressionMultiplier * Time.timeScale) - lastWaitExcess;
				if (timeToWait > 0f)
				{
					float timeOnWaitStart = Time.realtimeSinceStartup;
					yield return new WaitForSecondsRealtime(timeToWait);
					float num = Time.realtimeSinceStartup - timeOnWaitStart;
					lastWaitExcess = Mathf.Max(num - timeToWait, 0f);
				}
				else
				{
					lastWaitExcess -= 1f / this.TimeProgressionMultiplier;
				}
				this.Tick();
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0003FEF2 File Offset: 0x0003E0F2
		private IEnumerator StaggeredMinPass(float staggerTime)
		{
			if (this.onMinutePass == null)
			{
				yield break;
			}
			Delegate[] listeners = this.onMinutePass.GetInvocationList();
			float perDelay = staggerTime / (float)listeners.Length;
			float startTime = Time.timeSinceLevelLoad;
			float waitOverflow = 0f;
			float timeOnWaitStart = Time.timeSinceLevelLoad;
			int loopsSinceLastWait = 0;
			int num;
			for (int i = 0; i < listeners.Length; i = num + 1)
			{
				num = loopsSinceLastWait;
				loopsSinceLastWait = num + 1;
				float num2 = perDelay - waitOverflow;
				timeOnWaitStart = Time.timeSinceLevelLoad;
				if (num2 > 0f)
				{
					loopsSinceLastWait = 0;
					yield return new WaitForSeconds(num2);
				}
				float num3 = Time.timeSinceLevelLoad - timeOnWaitStart - perDelay;
				waitOverflow += num3;
				if (listeners[i] != null)
				{
					try
					{
						listeners[i].DynamicInvoke(Array.Empty<object>());
					}
					catch (Exception ex)
					{
						Console.LogError("Error invoking onMinutePass: " + ex.Message + "\nSite:" + ex.StackTrace, null);
					}
				}
				num = i;
			}
			float timeSinceLevelLoad = Time.timeSinceLevelLoad;
			yield break;
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0003FF08 File Offset: 0x0003E108
		private void Tick()
		{
			if (Player.Local == null)
			{
				Console.LogWarning("Local player does not exist. Waiting for player to spawn.", null);
				return;
			}
			this.TimeOnCurrentMinute = 0f;
			try
			{
				base.StartCoroutine(this.StaggeredMinPass(1f / (this.TimeProgressionMultiplier * Time.timeScale)));
			}
			catch (Exception ex)
			{
				string[] array = new string[8];
				array[0] = "Error invoking onMinutePass: ";
				array[1] = ex.Message;
				array[2] = "\nStack Trace: ";
				array[3] = ex.StackTrace;
				array[4] = "\nSource: ";
				array[5] = ex.Source;
				array[6] = "\nTarget Site: ";
				int num = 7;
				MethodBase targetSite = ex.TargetSite;
				array[num] = ((targetSite != null) ? targetSite.ToString() : null);
				Console.LogError(string.Concat(array), null);
			}
			if (this.CurrentTime == 400 || (this.IsCurrentTimeWithinRange(400, 600) && !GameManager.IS_TUTORIAL))
			{
				return;
			}
			if (this.CurrentTime == 2359)
			{
				int num2 = this.ElapsedDays;
				this.ElapsedDays = num2 + 1;
				this.CurrentTime = 0;
				this.DailyMinTotal = 0;
				if (this.onDayPass != null)
				{
					this.onDayPass();
				}
				if (this.onHourPass != null)
				{
					this.onHourPass();
				}
				if (this.CurrentDay == EDay.Monday && this.onWeekPass != null)
				{
					this.onWeekPass();
				}
			}
			else if (this.CurrentTime % 100 >= 59)
			{
				this.CurrentTime += 41;
				if (this.onHourPass != null)
				{
					this.onHourPass();
				}
			}
			else
			{
				int num2 = this.CurrentTime;
				this.CurrentTime = num2 + 1;
			}
			this.DailyMinTotal = ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.CurrentTime);
			this.HasChanged = true;
			if (this.ElapsedDays == 0 && this.CurrentTime == 2000 && this.onFirstNight != null)
			{
				this.onFirstNight.Invoke();
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x000400E4 File Offset: 0x0003E2E4
		public void SetTime(int _time, bool local = false)
		{
			if (!InstanceFinder.IsHost && InstanceFinder.NetworkManager != null && !local)
			{
				Console.LogWarning("SetTime can only be called by host", null);
				return;
			}
			Console.Log("Setting time to: " + _time.ToString(), null);
			this.CurrentTime = _time;
			this.TimeOnCurrentMinute = 0f;
			this.DailyMinTotal = ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.CurrentTime);
			this.SetData(null, this.ElapsedDays, this.CurrentTime, (float)(DateTime.UtcNow.Ticks / 10000000L));
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00040178 File Offset: 0x0003E378
		public void SetElapsedDays(int days)
		{
			if (!InstanceFinder.IsHost && InstanceFinder.NetworkManager != null)
			{
				Console.LogWarning("SetElapsedDays can only be called by host", null);
				return;
			}
			this.ElapsedDays = days;
			this.SetData(null, this.ElapsedDays, this.CurrentTime, (float)(DateTime.UtcNow.Ticks / 10000000L));
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000401D4 File Offset: 0x0003E3D4
		public static string Get12HourTime(float _time, bool appendDesignator = true)
		{
			string text = _time.ToString();
			while (text.Length < 4)
			{
				text = "0" + text;
			}
			int num = Convert.ToInt32(text.Substring(0, 2));
			int num2 = Convert.ToInt32(text.Substring(2, 2));
			string str = "AM";
			if (num == 0)
			{
				num = 12;
			}
			else if (num == 12)
			{
				str = "PM";
			}
			else if (num > 12)
			{
				num -= 12;
				str = "PM";
			}
			string text2 = string.Format("{0}:{1:00}", num, num2);
			if (appendDesignator)
			{
				text2 = text2 + " " + str;
			}
			return text2;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00040274 File Offset: 0x0003E474
		public static int Get24HourTimeFromMinSum(int minSum)
		{
			if (minSum < 0)
			{
				minSum = 1440 - minSum;
			}
			minSum %= 1440;
			int num = (int)((float)minSum / 60f);
			int num2 = minSum - 60 * num;
			return num * 100 + num2;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000402B0 File Offset: 0x0003E4B0
		public static int GetMinSumFrom24HourTime(int _time)
		{
			int num = (int)((float)_time / 100f);
			int num2 = _time - num * 100;
			return num * 60 + num2;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x000402D4 File Offset: 0x0003E4D4
		public bool IsCurrentTimeWithinRange(int min, int max)
		{
			return ScheduleOne.GameTime.TimeManager.IsGivenTimeWithinRange(this.CurrentTime, min, max);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x000402E3 File Offset: 0x0003E4E3
		public static bool IsGivenTimeWithinRange(int givenTime, int min, int max)
		{
			if (max > min)
			{
				return givenTime >= min && givenTime <= max;
			}
			return givenTime >= min || givenTime <= max;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00040304 File Offset: 0x0003E504
		public static bool IsValid24HourTime(string input)
		{
			string pattern = "^([01]?[0-9]|2[0-3])[0-5][0-9]$";
			return Regex.IsMatch(input, pattern);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00040320 File Offset: 0x0003E520
		public bool IsCurrentDateWithinRange(GameDateTime start, GameDateTime end)
		{
			int totalMinSum = this.GetTotalMinSum();
			return totalMinSum >= start.GetMinSum() && totalMinSum <= end.GetMinSum();
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0004034D File Offset: 0x0003E54D
		[ObserversRpc]
		private void InvokeDayPassClientSide()
		{
			this.RpcWriter___Observers_InvokeDayPassClientSide_2166136261();
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00040355 File Offset: 0x0003E555
		[ObserversRpc]
		private void InvokeWeekPassClientSide()
		{
			this.RpcWriter___Observers_InvokeWeekPassClientSide_2166136261();
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00040360 File Offset: 0x0003E560
		public void FastForwardToWakeTime()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			Console.Log("Fast forwarding to wake time: " + 700.ToString(), null);
			if (this.CurrentTime > 1200)
			{
				int elapsedDays = this.ElapsedDays;
				this.ElapsedDays = elapsedDays + 1;
				this.DailyMinTotal = ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.CurrentTime);
				this.HasChanged = true;
				if (this.onDayPass != null)
				{
					this.onDayPass();
				}
				this.InvokeDayPassClientSide();
				if (this.CurrentDay == EDay.Monday)
				{
					if (this.onWeekPass != null)
					{
						this.onWeekPass();
					}
					this.InvokeWeekPassClientSide();
				}
			}
			int minSumFrom24HourTime = ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.CurrentTime);
			int obj = Mathf.Abs(ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(700) - minSumFrom24HourTime);
			int time = 700;
			if (GameManager.IS_TUTORIAL)
			{
				time = 300;
			}
			this.SetTime(time, false);
			try
			{
				if (this.onTimeSkip != null)
				{
					this.onTimeSkip(obj);
				}
			}
			catch (Exception ex)
			{
				Console.LogError("Error invoking onTimeSkip: " + ex.Message + "\nSite:" + ex.StackTrace, null);
			}
			try
			{
				if (ScheduleOne.GameTime.TimeManager.onSleepEnd != null)
				{
					ScheduleOne.GameTime.TimeManager.onSleepEnd(obj);
				}
			}
			catch (Exception ex2)
			{
				Console.LogError("Error invoking onSleepEnd: " + ex2.Message + "\nSite:" + ex2.StackTrace, null);
			}
			try
			{
				if (this._onSleepEnd != null)
				{
					this._onSleepEnd.Invoke();
				}
			}
			catch (Exception ex3)
			{
				Console.LogError("Error invoking _onSleepEnd: " + ex3.Message + "\nSite:" + ex3.StackTrace, null);
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00040518 File Offset: 0x0003E718
		public GameDateTime GetDateTime()
		{
			return new GameDateTime(this.ElapsedDays, this.CurrentTime);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0004052B File Offset: 0x0003E72B
		public int GetTotalMinSum()
		{
			return this.ElapsedDays * 1440 + this.DailyMinTotal;
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00040540 File Offset: 0x0003E740
		public static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			int num = ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(time) + minsToAdd;
			if (num < 0)
			{
				num = 1440 + num;
			}
			return ScheduleOne.GameTime.TimeManager.Get24HourTimeFromMinSum(num);
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00040568 File Offset: 0x0003E768
		public static List<int> GetAllTimeInRange(int min, int max)
		{
			List<int> list = new List<int>();
			int num = min;
			while (num != max)
			{
				list.Add(num);
				num++;
				if (num >= 2360)
				{
					num = 0;
				}
				else if (num % 100 >= 60)
				{
					num += 40;
				}
			}
			list.Add(max);
			return list;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000405AF File Offset: 0x0003E7AF
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetWakeTime(int amount)
		{
			this.RpcWriter___Server_SetWakeTime_3316948804(amount);
			this.RpcLogic___SetWakeTime_3316948804(amount);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000405C8 File Offset: 0x0003E7C8
		[ObserversRpc(RunLocally = true)]
		private void StartSleep()
		{
			this.RpcWriter___Observers_StartSleep_2166136261();
			this.RpcLogic___StartSleep_2166136261();
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000405E4 File Offset: 0x0003E7E4
		[ObserversRpc(RunLocally = true)]
		private void EndSleep()
		{
			this.RpcWriter___Observers_EndSleep_2166136261();
			this.RpcLogic___EndSleep_2166136261();
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x000405FD File Offset: 0x0003E7FD
		public virtual string GetSaveString()
		{
			return new TimeData(this.CurrentTime, this.ElapsedDays, Mathf.RoundToInt(this.Playtime)).GetJson(true);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00040621 File Offset: 0x0003E821
		public void SetPlaytime(float time)
		{
			this.Playtime = time;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0004062C File Offset: 0x0003E82C
		public void SetTimeOverridden(bool overridden, int time = 1200)
		{
			if (overridden && this.TimeOverridden)
			{
				Console.LogWarning("Time already overridden.", null);
				return;
			}
			this.TimeOverridden = overridden;
			if (overridden)
			{
				this.savedTime = this.CurrentTime;
				this.SetTime(time, false);
			}
			else
			{
				this.SetTime(this.savedTime, false);
			}
			if (this.onMinutePass != null)
			{
				this.onMinutePass();
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00040690 File Offset: 0x0003E890
		private void SetRandomTime()
		{
			int minSum = Random.Range(0, 1440);
			this.SetTime(ScheduleOne.GameTime.TimeManager.Get24HourTimeFromMinSum(minSum), false);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00040704 File Offset: 0x0003E904
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_SetData_2661156041));
			base.RegisterTargetRpc(1U, new ClientRpcDelegate(this.RpcReader___Target_SetData_2661156041));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_ResetHostSleepDone_2166136261));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_MarkHostSleepDone_2166136261));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_SetHostSleepDone_1140765316));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_InvokeDayPassClientSide_2166136261));
			base.RegisterObserversRpc(6U, new ClientRpcDelegate(this.RpcReader___Observers_InvokeWeekPassClientSide_2166136261));
			base.RegisterServerRpc(7U, new ServerRpcDelegate(this.RpcReader___Server_SetWakeTime_3316948804));
			base.RegisterObserversRpc(8U, new ClientRpcDelegate(this.RpcReader___Observers_StartSleep_2166136261));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_EndSleep_2166136261));
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0004080E File Offset: 0x0003EA0E
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00040827 File Offset: 0x0003EA27
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00040838 File Offset: 0x0003EA38
		private void RpcWriter___Observers_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(_elapsedDays, AutoPackType.Packed);
			writer.WriteInt32(_time, AutoPackType.Packed);
			writer.WriteSingle(sendTime, AutoPackType.Unpacked);
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, true, false);
			writer.Store();
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00040918 File Offset: 0x0003EB18
		private void RpcLogic___SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			this.ElapsedDays = _elapsedDays;
			this.CurrentTime = _time;
			this.DailyMinTotal = ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.CurrentTime);
			this.HasChanged = true;
			try
			{
				if (this.onTimeChanged != null)
				{
					this.onTimeChanged();
				}
			}
			catch (Exception ex)
			{
				Console.LogError("Error invoking onTimeChanged: " + ex.Message + "\nSite:" + ex.StackTrace, null);
			}
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00040994 File Offset: 0x0003EB94
		private void RpcReader___Observers_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
			int elapsedDays = PooledReader0.ReadInt32(AutoPackType.Packed);
			int time = PooledReader0.ReadInt32(AutoPackType.Packed);
			float sendTime = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetData_2661156041(null, elapsedDays, time, sendTime);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00040A04 File Offset: 0x0003EC04
		private void RpcWriter___Target_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(_elapsedDays, AutoPackType.Packed);
			writer.WriteInt32(_time, AutoPackType.Packed);
			writer.WriteSingle(sendTime, AutoPackType.Unpacked);
			base.SendTargetRpc(1U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00040AE4 File Offset: 0x0003ECE4
		private void RpcReader___Target_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
			int elapsedDays = PooledReader0.ReadInt32(AutoPackType.Packed);
			int time = PooledReader0.ReadInt32(AutoPackType.Packed);
			float sendTime = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetData_2661156041(base.LocalConnection, elapsedDays, time, sendTime);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00040B4C File Offset: 0x0003ED4C
		private void RpcWriter___Server_ResetHostSleepDone_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00040BE6 File Offset: 0x0003EDE6
		public void RpcLogic___ResetHostSleepDone_2166136261()
		{
			this.SetHostSleepDone(false);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00040BF0 File Offset: 0x0003EDF0
		private void RpcReader___Server_ResetHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___ResetHostSleepDone_2166136261();
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00040C20 File Offset: 0x0003EE20
		private void RpcWriter___Server_MarkHostSleepDone_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00040CBA File Offset: 0x0003EEBA
		public void RpcLogic___MarkHostSleepDone_2166136261()
		{
			this.SetHostSleepDone(true);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00040CC4 File Offset: 0x0003EEC4
		private void RpcReader___Server_MarkHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___MarkHostSleepDone_2166136261();
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00040CF4 File Offset: 0x0003EEF4
		private void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteBoolean(done);
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00040DAA File Offset: 0x0003EFAA
		private void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
			this.HostDailySummaryDone = done;
			Console.Log("Host daily summary done: " + done.ToString(), null);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00040DCC File Offset: 0x0003EFCC
		private void RpcReader___Observers_SetHostSleepDone_1140765316(PooledReader PooledReader0, Channel channel)
		{
			bool done = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetHostSleepDone_1140765316(done);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00040E08 File Offset: 0x0003F008
		private void RpcWriter___Observers_InvokeDayPassClientSide_2166136261()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00040EB1 File Offset: 0x0003F0B1
		private void RpcLogic___InvokeDayPassClientSide_2166136261()
		{
			if (InstanceFinder.IsServer)
			{
				return;
			}
			if (this.onDayPass != null)
			{
				this.onDayPass();
			}
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00040ED0 File Offset: 0x0003F0D0
		private void RpcReader___Observers_InvokeDayPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___InvokeDayPassClientSide_2166136261();
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00040EF0 File Offset: 0x0003F0F0
		private void RpcWriter___Observers_InvokeWeekPassClientSide_2166136261()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(6U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00040F99 File Offset: 0x0003F199
		private void RpcLogic___InvokeWeekPassClientSide_2166136261()
		{
			if (InstanceFinder.IsServer)
			{
				return;
			}
			if (this.onWeekPass != null)
			{
				this.onWeekPass();
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00040FB8 File Offset: 0x0003F1B8
		private void RpcReader___Observers_InvokeWeekPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___InvokeWeekPassClientSide_2166136261();
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00040FD8 File Offset: 0x0003F1D8
		private void RpcWriter___Server_SetWakeTime_3316948804(int amount)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(amount, AutoPackType.Packed);
			base.SendServerRpc(7U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x000045B1 File Offset: 0x000027B1
		public void RpcLogic___SetWakeTime_3316948804(int amount)
		{
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00041084 File Offset: 0x0003F284
		private void RpcReader___Server_SetWakeTime_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int amount = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetWakeTime_3316948804(amount);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x000410C8 File Offset: 0x0003F2C8
		private void RpcWriter___Observers_StartSleep_2166136261()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(8U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00041174 File Offset: 0x0003F374
		private void RpcLogic___StartSleep_2166136261()
		{
			if (this.SleepInProgress)
			{
				return;
			}
			Debug.Log("Start sleep");
			this.sleepStartTime = this.GetDateTime();
			this.sleepEndTime = 700;
			if (NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				this.sleepEndTime = 100;
			}
			this.SleepInProgress = true;
			Time.timeScale = 1f;
			if (ScheduleOne.GameTime.TimeManager.onSleepStart != null)
			{
				ScheduleOne.GameTime.TimeManager.onSleepStart();
			}
			if (this._onSleepStart != null)
			{
				this._onSleepStart.Invoke();
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x000411F4 File Offset: 0x0003F3F4
		private void RpcReader___Observers_StartSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartSleep_2166136261();
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00041220 File Offset: 0x0003F420
		private void RpcWriter___Observers_EndSleep_2166136261()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x000412CC File Offset: 0x0003F4CC
		private void RpcLogic___EndSleep_2166136261()
		{
			if (!this.SleepInProgress)
			{
				return;
			}
			Debug.Log("End sleep");
			this.SleepInProgress = false;
			Time.timeScale = 1f;
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsHost)
			{
				this.SendTimeData(null);
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Sleep_Count", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Sleep_Count") + 1f).ToString(), false);
			if (ScheduleOne.GameTime.TimeManager.onSleepEnd != null)
			{
				ScheduleOne.GameTime.TimeManager.onSleepEnd(this.GetDateTime().GetMinSum() - this.sleepStartTime.GetMinSum());
			}
			if (this._onSleepEnd != null)
			{
				this._onSleepEnd.Invoke();
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0004137C File Offset: 0x0003F57C
		private void RpcReader___Observers_EndSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___EndSleep_2166136261();
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000413A8 File Offset: 0x0003F5A8
		protected virtual void dll()
		{
			base.Awake();
			this.defaultFixedTimeScale = Time.fixedDeltaTime;
			if (!Singleton<Lobby>.InstanceExists || !Singleton<Lobby>.Instance.IsInLobby || Singleton<Lobby>.Instance.IsHost || GameManager.IS_TUTORIAL)
			{
				this.SetTime(this.DefaultTime, true);
				this.ElapsedDays = (int)this.DefaultDay;
				this.DailyMinTotal = ScheduleOne.GameTime.TimeManager.GetMinSumFrom24HourTime(this.CurrentTime);
			}
			this.InitializeSaveable();
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(this.Clean));
			this.SetWakeTime(700);
		}

		// Token: 0x04000EFE RID: 3838
		public const float CYCLE_DURATION_MINS = 24f;

		// Token: 0x04000EFF RID: 3839
		public const float MINUTE_TIME = 1f;

		// Token: 0x04000F00 RID: 3840
		public const int DEFAULT_WAKE_TIME = 700;

		// Token: 0x04000F01 RID: 3841
		public const int END_OF_DAY = 400;

		// Token: 0x04000F06 RID: 3846
		public int DefaultTime = 900;

		// Token: 0x04000F07 RID: 3847
		public EDay DefaultDay;

		// Token: 0x04000F08 RID: 3848
		public float TimeProgressionMultiplier = 1f;

		// Token: 0x04000F0B RID: 3851
		private int savedTime;

		// Token: 0x04000F0D RID: 3853
		public Action onMinutePass;

		// Token: 0x04000F0E RID: 3854
		public Action onHourPass;

		// Token: 0x04000F0F RID: 3855
		public Action onDayPass;

		// Token: 0x04000F10 RID: 3856
		public Action onWeekPass;

		// Token: 0x04000F11 RID: 3857
		public Action onUpdate;

		// Token: 0x04000F12 RID: 3858
		public Action onFixedUpdate;

		// Token: 0x04000F13 RID: 3859
		public Action<int> onTimeSkip;

		// Token: 0x04000F14 RID: 3860
		public Action onTick;

		// Token: 0x04000F15 RID: 3861
		public static Action onSleepStart;

		// Token: 0x04000F16 RID: 3862
		public UnityEvent _onSleepStart;

		// Token: 0x04000F17 RID: 3863
		public static Action<int> onSleepEnd;

		// Token: 0x04000F18 RID: 3864
		public UnityEvent _onSleepEnd;

		// Token: 0x04000F19 RID: 3865
		public UnityEvent onFirstNight;

		// Token: 0x04000F1A RID: 3866
		public Action onTimeChanged;

		// Token: 0x04000F1B RID: 3867
		public const int SelectedWakeTime = 700;

		// Token: 0x04000F1C RID: 3868
		private GameDateTime sleepStartTime;

		// Token: 0x04000F1D RID: 3869
		private int sleepEndTime;

		// Token: 0x04000F1F RID: 3871
		private float defaultFixedTimeScale;

		// Token: 0x04000F20 RID: 3872
		private TimeLoader loader = new TimeLoader();

		// Token: 0x04000F24 RID: 3876
		private bool dll_Excuted;

		// Token: 0x04000F25 RID: 3877
		private bool dll_Excuted;
	}
}
