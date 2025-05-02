using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Law;
using ScheduleOne.Levelling;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.Police;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005F0 RID: 1520
	public class PlayerCrimeData : NetworkBehaviour
	{
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000A0D2C File Offset: 0x0009EF2C
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x000A0D34 File Offset: 0x0009EF34
		public PlayerCrimeData.EPursuitLevel CurrentPursuitLevel
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<CurrentPursuitLevel>k__BackingField;
			}
			[CompilerGenerated]
			[ServerRpc(RunLocally = true)]
			protected set
			{
				this.RpcWriter___Server_set_CurrentPursuitLevel_2979171596(value);
				this.RpcLogic___set_CurrentPursuitLevel_2979171596(value);
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x000A0D4A File Offset: 0x0009EF4A
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x000A0D52 File Offset: 0x0009EF52
		public Vector3 LastKnownPosition
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<LastKnownPosition>k__BackingField;
			}
			[CompilerGenerated]
			[ServerRpc(RunLocally = true)]
			protected set
			{
				this.RpcWriter___Server_set_LastKnownPosition_4276783012(value);
				this.RpcLogic___set_LastKnownPosition_4276783012(value);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x000A0D68 File Offset: 0x0009EF68
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x000A0D70 File Offset: 0x0009EF70
		public float CurrentArrestProgress { get; protected set; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x000A0D79 File Offset: 0x0009EF79
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x000A0D81 File Offset: 0x0009EF81
		public float CurrentBodySearchProgress { get; protected set; }

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x000A0D8A File Offset: 0x0009EF8A
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x000A0D92 File Offset: 0x0009EF92
		public float TimeSinceLastBodySearch { get; set; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x000A0D9B File Offset: 0x0009EF9B
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x000A0DA3 File Offset: 0x0009EFA3
		public bool EvadedArrest { get; protected set; }

		// Token: 0x0600275E RID: 10078 RVA: 0x000A0DAC File Offset: 0x0009EFAC
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.PlayerScripts.PlayerCrimeData_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000A0DCB File Offset: 0x0009EFCB
		private void Start()
		{
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.OnSleepStart));
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.OnSleepStart));
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000A0E03 File Offset: 0x0009F003
		private void OnDestroy()
		{
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.InstanceExists)
			{
				NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.OnSleepStart));
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000A0E28 File Offset: 0x0009F028
		protected virtual void Update()
		{
			this.CurrentPursuitLevelDuration += Time.deltaTime;
			this.TimeSincePursuitStart += Time.deltaTime;
			this.TimeSinceSighted += Time.deltaTime;
			this.timeSinceLastShot += Time.deltaTime;
			this.TimeSinceLastBodySearch += Time.deltaTime;
			if (!this.Player.IsOwner)
			{
				return;
			}
			if (this.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None && this.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.Lethal)
			{
				this.UpdateEscalation();
			}
			if (this.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
			{
				this.UpdateTimeout();
				this.UpdateMusic();
			}
			if (this.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None && this.TimeSinceSighted > 2f)
			{
				this.Player.VisualState.ApplyState("SearchedFor", PlayerVisualState.EVisualState.SearchedFor, 0f);
			}
			else
			{
				this.Player.VisualState.RemoveState("SearchedFor", 0f);
			}
			for (int i = 0; i < this.Collisions.Count; i++)
			{
				this.Collisions[i].TimeSince += Time.deltaTime;
				if (this.Collisions[i].TimeSince > 30f)
				{
					this.Collisions.RemoveAt(i);
					i--;
				}
			}
			Singleton<HUD>.Instance.CrimeStatusUI.UpdateStatus();
			if ((float)this.Collisions.Count >= 3f)
			{
				this.RecordLastKnownPosition(true);
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Investigating);
				this.AddCrime(new VehicularAssault(), this.Collisions.Count - 1);
				Singleton<LawManager>.Instance.PoliceCalled(this.Player, new VehicularAssault());
				this.Collisions.Clear();
			}
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000A0FD8 File Offset: 0x0009F1D8
		protected virtual void LateUpdate()
		{
			if (this.CurrentArrestProgress > 0f)
			{
				Singleton<ProgressSlider>.Instance.Configure("Cuffing...", new Color32(75, 165, byte.MaxValue, byte.MaxValue));
				Singleton<ProgressSlider>.Instance.ShowProgress(this.CurrentArrestProgress);
			}
			else if (this.CurrentBodySearchProgress > 0f)
			{
				Singleton<ProgressSlider>.Instance.Configure("Being searched...", new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
				Singleton<ProgressSlider>.Instance.ShowProgress(this.CurrentBodySearchProgress);
			}
			this.CurrentArrestProgress = 0f;
			this.CurrentBodySearchProgress = 0f;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000A1090 File Offset: 0x0009F290
		public void SetPursuitLevel(PlayerCrimeData.EPursuitLevel level)
		{
			if (GameManager.IS_TUTORIAL)
			{
				return;
			}
			Debug.Log("New pursuit level: " + level.ToString());
			PlayerCrimeData.EPursuitLevel currentPursuitLevel = this.CurrentPursuitLevel;
			this.CurrentPursuitLevel = level;
			if (level != PlayerCrimeData.EPursuitLevel.None)
			{
				this.BodySearchPending = false;
			}
			if (currentPursuitLevel == PlayerCrimeData.EPursuitLevel.None && level != PlayerCrimeData.EPursuitLevel.None)
			{
				this.TimeSincePursuitStart = 0f;
				this.TimeSinceSighted = 0f;
				this.Player.VisualState.ApplyState("Wanted", PlayerVisualState.EVisualState.Wanted, 0f);
				if (this.Player.Owner.IsLocalClient)
				{
					this._lightCombatTrack.Enable();
				}
			}
			if (level == PlayerCrimeData.EPursuitLevel.Lethal && this.Player.Owner.IsLocalClient)
			{
				this._lightCombatTrack.Stop();
				this._heavyCombatTrack.Enable();
			}
			if (currentPursuitLevel != PlayerCrimeData.EPursuitLevel.None && level == PlayerCrimeData.EPursuitLevel.None)
			{
				this.ClearCrimes();
				this.Player.VisualState.RemoveState("Wanted", 0f);
				if (this.Player.Owner.IsLocalClient)
				{
					this._lightCombatTrack.Disable();
					this._lightCombatTrack.Stop();
					this._heavyCombatTrack.Disable();
					this._heavyCombatTrack.Stop();
				}
			}
			this.CurrentPursuitLevelDuration = 0f;
			if (this.Player.IsOwner)
			{
				Singleton<HUD>.Instance.CrimeStatusUI.UpdateStatus();
			}
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x000A11E4 File Offset: 0x0009F3E4
		public void Escalate()
		{
			if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None)
			{
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Investigating);
				return;
			}
			if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.Investigating)
			{
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				return;
			}
			if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.Arresting)
			{
				this.SetEvaded();
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.NonLethal);
				if (PoliceStation.GetClosestPoliceStation(this.Player.Avatar.MiddleSpineRB.position).TimeSinceLastDispatch > 10f)
				{
					PoliceStation.GetClosestPoliceStation(this.Player.Avatar.MiddleSpineRB.position).Dispatch(1, this.Player, PoliceStation.EDispatchType.Auto, true);
					return;
				}
			}
			else if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.NonLethal)
			{
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Lethal);
				PoliceStation.GetClosestPoliceStation(this.Player.Avatar.MiddleSpineRB.position);
				PoliceStation.GetClosestPoliceStation(this.Player.Avatar.MiddleSpineRB.position).Dispatch(1, this.Player, PoliceStation.EDispatchType.Auto, true);
			}
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000A12CC File Offset: 0x0009F4CC
		public void Deescalate()
		{
			if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.Investigating)
			{
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.None);
				return;
			}
			if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.Arresting)
			{
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Investigating);
				return;
			}
			if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.NonLethal)
			{
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.Arresting);
				return;
			}
			if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.Lethal)
			{
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.NonLethal);
			}
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x000A131C File Offset: 0x0009F51C
		[ObserversRpc(RunLocally = true)]
		public void RecordLastKnownPosition(bool resetTimeSinceSighted)
		{
			this.RpcWriter___Observers_RecordLastKnownPosition_1140765316(resetTimeSinceSighted);
			this.RpcLogic___RecordLastKnownPosition_1140765316(resetTimeSinceSighted);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000A1332 File Offset: 0x0009F532
		public void SetArrestProgress(float progress)
		{
			this.CurrentArrestProgress = progress;
			if (progress >= 1f)
			{
				this.Player.Arrest();
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.None);
			}
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x000A1355 File Offset: 0x0009F555
		public void ResetBodysearchCooldown()
		{
			this.TimeSinceLastBodySearch = 0f;
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x000A1362 File Offset: 0x0009F562
		public void SetBodySearchProgress(float progress)
		{
			this.CurrentBodySearchProgress = progress;
			if (this.CurrentBodySearchProgress >= 1f)
			{
				this.TimeSinceLastBodySearch = 0f;
				this.BodySearchPending = false;
			}
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000A138A File Offset: 0x0009F58A
		private void OnDie()
		{
			if (this.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
			{
				this.SetArrestProgress(1f);
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x000A13A0 File Offset: 0x0009F5A0
		public void AddCrime(Crime crime, int quantity = 1)
		{
			if (crime == null)
			{
				return;
			}
			Debug.Log("Adding crime: " + ((crime != null) ? crime.ToString() : null));
			Crime[] array = this.Crimes.Keys.ToArray<Crime>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].GetType() == crime.GetType())
				{
					Dictionary<Crime, int> crimes = this.Crimes;
					Crime key = array[i];
					crimes[key] += quantity;
					return;
				}
			}
			this.Crimes.Add(crime, quantity);
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x000A142A File Offset: 0x0009F62A
		public void ClearCrimes()
		{
			this.Crimes.Clear();
			this.EvadedArrest = false;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x000A1440 File Offset: 0x0009F640
		public bool IsCrimeOnRecord(Type crime)
		{
			Crime[] array = this.Crimes.Keys.ToArray<Crime>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].GetType() == crime)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x000A147F File Offset: 0x0009F67F
		public void SetEvaded()
		{
			this.EvadedArrest = true;
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x000A1488 File Offset: 0x0009F688
		private void OnSleepStart()
		{
			if (this.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
			{
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.None);
				this.ClearCrimes();
			}
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000A14A0 File Offset: 0x0009F6A0
		private void UpdateEscalation()
		{
			if (this.TimeSinceSighted > 1f)
			{
				return;
			}
			if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.Arresting)
			{
				if (this.CurrentPursuitLevelDuration > 25f)
				{
					this.Escalate();
					return;
				}
			}
			else if (this.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.NonLethal && this.CurrentPursuitLevelDuration > 120f)
			{
				this.Escalate();
			}
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000A14F4 File Offset: 0x0009F6F4
		private void UpdateTimeout()
		{
			if (!this.Player.IsOwner)
			{
				return;
			}
			if (this.TimeSinceSighted > this.GetSearchTime() + 3f)
			{
				this.TimeoutPursuit();
			}
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x000A1520 File Offset: 0x0009F720
		private void UpdateMusic()
		{
			if (!this.Player.Owner.IsLocalClient)
			{
				return;
			}
			float num = this._lightCombatTrack.VolumeMultiplier;
			if (this.TimeSinceSighted > this.outOfSightTimeToDipMusic)
			{
				num -= this.musicChangeRate_Down * Time.deltaTime;
			}
			else
			{
				num += this.musicChangeRate_Up * Time.deltaTime;
			}
			num = Mathf.Clamp(num, this.minMusicVolume, 1f);
			this._lightCombatTrack.VolumeMultiplier = num;
			this._heavyCombatTrack.VolumeMultiplier = num;
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x000A15A4 File Offset: 0x0009F7A4
		private void TimeoutPursuit()
		{
			switch (this.CurrentPursuitLevel)
			{
			case PlayerCrimeData.EPursuitLevel.Arresting:
				NetworkSingleton<LevelManager>.Instance.AddXP(20);
				break;
			case PlayerCrimeData.EPursuitLevel.NonLethal:
				NetworkSingleton<LevelManager>.Instance.AddXP(40);
				break;
			case PlayerCrimeData.EPursuitLevel.Lethal:
				NetworkSingleton<LevelManager>.Instance.AddXP(60);
				break;
			}
			this.onPursuitEscapedSound.Play();
			this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.None);
			this.ClearCrimes();
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000A1614 File Offset: 0x0009F814
		public float GetSearchTime()
		{
			switch (this.CurrentPursuitLevel)
			{
			case PlayerCrimeData.EPursuitLevel.Investigating:
				return 60f;
			case PlayerCrimeData.EPursuitLevel.Arresting:
				return 25f;
			case PlayerCrimeData.EPursuitLevel.NonLethal:
				return 30f;
			case PlayerCrimeData.EPursuitLevel.Lethal:
				return 40f;
			default:
				return 0f;
			}
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000A165F File Offset: 0x0009F85F
		public void ResetShotAccuracy()
		{
			this.timeSinceLastShot = 0f;
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000A166C File Offset: 0x0009F86C
		public float GetShotAccuracyMultiplier()
		{
			float num = 1f;
			if (this.timeSinceLastShot < 2f)
			{
				num = 0f;
			}
			if (this.timeSinceLastShot < 8f)
			{
				num = 1f - (this.timeSinceLastShot - 2f) / 6f;
			}
			float t = Mathf.Clamp01(Mathf.InverseLerp(0f, PlayerMovement.WalkSpeed * PlayerMovement.SprintMultiplier, this.Player.VelocityCalculator.Velocity.magnitude));
			float num2 = Mathf.Lerp(2f, 0.5f, t);
			int num3 = 0;
			for (int i = 0; i < PoliceOfficer.Officers.Count; i++)
			{
				if (PoliceOfficer.Officers[i].PursuitBehaviour.Active && PoliceOfficer.Officers[i].TargetPlayerNOB == this.Player.NetworkObject && Vector3.Distance(PoliceOfficer.Officers[i].transform.position, this.Player.Avatar.CenterPoint) < 20f)
				{
					num3++;
				}
			}
			float num4 = Mathf.Lerp(1f, 0.6f, Mathf.Clamp01((float)num3 / 3f));
			return num * num2 * num4;
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x000A17AC File Offset: 0x0009F9AC
		public void RecordVehicleCollision(NPC victim)
		{
			PlayerCrimeData.VehicleCollisionInstance item = new PlayerCrimeData.VehicleCollisionInstance(victim, 0f);
			this.Collisions.Add(item);
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x000A17D1 File Offset: 0x0009F9D1
		private void CheckNearestOfficer()
		{
			if (this.Player == null)
			{
				return;
			}
			this.NearestOfficer = (from x in PoliceOfficer.Officers
			orderby Vector3.Distance(x.Avatar.CenterPoint, this.Player.Avatar.CenterPoint)
			select x).FirstOrDefault<PoliceOfficer>();
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x000A1804 File Offset: 0x0009FA04
		public PlayerCrimeData()
		{
			this.<LastKnownPosition>k__BackingField = Vector3.zero;
			this.Pursuers = new List<PoliceOfficer>();
			this.TimeSinceSighted = 100000f;
			this.Crimes = new Dictionary<Crime, int>();
			this.TimeSinceLastBodySearch = 100000f;
			this.timeSinceLastShot = 1000f;
			this.Collisions = new List<PlayerCrimeData.VehicleCollisionInstance>();
			this.outOfSightTimeToDipMusic = 8f;
			this.minMusicVolume = 0.6f;
			this.musicChangeRate_Down = 0.04f;
			this.musicChangeRate_Up = 2f;
			base..ctor();
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000A18BC File Offset: 0x0009FABC
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<LastKnownPosition>k__BackingField = new SyncVar<Vector3>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, 0.5f, Channel.Reliable, this.<LastKnownPosition>k__BackingField);
			this.syncVar___<CurrentPursuitLevel>k__BackingField = new SyncVar<PlayerCrimeData.EPursuitLevel>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, 0.5f, Channel.Reliable, this.<CurrentPursuitLevel>k__BackingField);
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_set_CurrentPursuitLevel_2979171596));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_set_LastKnownPosition_4276783012));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_RecordLastKnownPosition_1140765316));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.PlayerScripts.PlayerCrimeData));
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000A1987 File Offset: 0x0009FB87
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<LastKnownPosition>k__BackingField.SetRegistered();
			this.syncVar___<CurrentPursuitLevel>k__BackingField.SetRegistered();
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000A19B0 File Offset: 0x0009FBB0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000A19C0 File Offset: 0x0009FBC0
		private void RpcWriter___Server_set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
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
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				if (networkManager2 == null)
				{
					networkManager2 = InstanceFinder.NetworkManager;
				}
				if (networkManager2 != null)
				{
					networkManager2.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.PlayerScripts.PlayerCrimeData/EPursuitLevelFishNet.Serializing.Generated(value);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000A1AC1 File Offset: 0x0009FCC1
		protected void RpcLogic___set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
		{
			this.sync___set_value_<CurrentPursuitLevel>k__BackingField(value, true);
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000A1ACC File Offset: 0x0009FCCC
		private void RpcReader___Server_set_CurrentPursuitLevel_2979171596(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			PlayerCrimeData.EPursuitLevel value = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.PlayerScripts.PlayerCrimeData/EPursuitLevelFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(conn))
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___set_CurrentPursuitLevel_2979171596(value);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000A1B1C File Offset: 0x0009FD1C
		private void RpcWriter___Server_set_LastKnownPosition_4276783012(Vector3 value)
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
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				if (networkManager2 == null)
				{
					networkManager2 = InstanceFinder.NetworkManager;
				}
				if (networkManager2 != null)
				{
					networkManager2.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteVector3(value);
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000A1C1D File Offset: 0x0009FE1D
		protected void RpcLogic___set_LastKnownPosition_4276783012(Vector3 value)
		{
			this.sync___set_value_<LastKnownPosition>k__BackingField(value, true);
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x000A1C28 File Offset: 0x0009FE28
		private void RpcReader___Server_set_LastKnownPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Vector3 value = PooledReader0.ReadVector3();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(conn))
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___set_LastKnownPosition_4276783012(value);
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000A1C78 File Offset: 0x0009FE78
		private void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
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
			writer.WriteBoolean(resetTimeSinceSighted);
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x000A1D2E File Offset: 0x0009FF2E
		public void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
			this.LastKnownPosition = this.Player.Avatar.CenterPoint;
			if (resetTimeSinceSighted)
			{
				this.TimeSinceSighted = 0f;
			}
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000A1D54 File Offset: 0x0009FF54
		private void RpcReader___Observers_RecordLastKnownPosition_1140765316(PooledReader PooledReader0, Channel channel)
		{
			bool resetTimeSinceSighted = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___RecordLastKnownPosition_1140765316(resetTimeSinceSighted);
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x000A1D8F File Offset: 0x0009FF8F
		// (set) Token: 0x06002789 RID: 10121 RVA: 0x000A1D97 File Offset: 0x0009FF97
		public PlayerCrimeData.EPursuitLevel SyncAccessor_<CurrentPursuitLevel>k__BackingField
		{
			get
			{
				return this.<CurrentPursuitLevel>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<CurrentPursuitLevel>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<CurrentPursuitLevel>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000A1DD4 File Offset: 0x0009FFD4
		public virtual bool PlayerCrimeData(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_<LastKnownPosition>k__BackingField(this.syncVar___<LastKnownPosition>k__BackingField.GetValue(true), true);
					return true;
				}
				Vector3 value = PooledReader0.ReadVector3();
				this.sync___set_value_<LastKnownPosition>k__BackingField(value, Boolean2);
				return true;
			}
			else
			{
				if (UInt321 != 0U)
				{
					return false;
				}
				if (PooledReader0 == null)
				{
					this.sync___set_value_<CurrentPursuitLevel>k__BackingField(this.syncVar___<CurrentPursuitLevel>k__BackingField.GetValue(true), true);
					return true;
				}
				PlayerCrimeData.EPursuitLevel value2 = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.PlayerScripts.PlayerCrimeData/EPursuitLevelFishNet.Serializing.Generateds(PooledReader0);
				this.sync___set_value_<CurrentPursuitLevel>k__BackingField(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x000A1E6A File Offset: 0x000A006A
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x000A1E72 File Offset: 0x000A0072
		public Vector3 SyncAccessor_<LastKnownPosition>k__BackingField
		{
			get
			{
				return this.<LastKnownPosition>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<LastKnownPosition>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<LastKnownPosition>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x000A1EB0 File Offset: 0x000A00B0
		private void dll()
		{
			this.Player.Health.onDie.AddListener(new UnityAction(this.OnDie));
			this.Player.onFreed.AddListener(new UnityAction(this.ClearCrimes));
			this.Player.onFreed.AddListener(new UnityAction(delegate()
			{
				this.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.None);
			}));
			base.InvokeRepeating("CheckNearestOfficer", 0f, 0.2f);
			this._lightCombatTrack = Singleton<MusicPlayer>.Instance.Tracks.Find((MusicTrack t) => t.TrackName == "Light Combat");
			this._heavyCombatTrack = Singleton<MusicPlayer>.Instance.Tracks.Find((MusicTrack t) => t.TrackName == "Heavy Combat");
		}

		// Token: 0x04001C87 RID: 7303
		public const float SEARCH_TIME_INVESTIGATING = 60f;

		// Token: 0x04001C88 RID: 7304
		public const float SEARCH_TIME_ARRESTING = 25f;

		// Token: 0x04001C89 RID: 7305
		public const float SEARCH_TIME_NONLETHAL = 30f;

		// Token: 0x04001C8A RID: 7306
		public const float SEARCH_TIME_LETHAL = 40f;

		// Token: 0x04001C8B RID: 7307
		public const float ESCALATION_TIME_ARRESTING = 25f;

		// Token: 0x04001C8C RID: 7308
		public const float ESCALATION_TIME_NONLETHAL = 120f;

		// Token: 0x04001C8D RID: 7309
		public const float SHOT_COOLDOWN_MIN = 2f;

		// Token: 0x04001C8E RID: 7310
		public const float SHOT_COOLDOWN_MAX = 8f;

		// Token: 0x04001C8F RID: 7311
		public const float VEHICLE_COLLISION_LIFETIME = 30f;

		// Token: 0x04001C90 RID: 7312
		public const float VEHICLE_COLLISION_LIMIT = 3f;

		// Token: 0x04001C91 RID: 7313
		public PoliceOfficer NearestOfficer;

		// Token: 0x04001C92 RID: 7314
		public Player Player;

		// Token: 0x04001C93 RID: 7315
		public AudioSourceController onPursuitEscapedSound;

		// Token: 0x04001C96 RID: 7318
		public List<PoliceOfficer> Pursuers;

		// Token: 0x04001C99 RID: 7321
		public float TimeSincePursuitStart;

		// Token: 0x04001C9A RID: 7322
		public float CurrentPursuitLevelDuration;

		// Token: 0x04001C9B RID: 7323
		public float TimeSinceSighted;

		// Token: 0x04001C9C RID: 7324
		public Dictionary<Crime, int> Crimes;

		// Token: 0x04001C9D RID: 7325
		public bool BodySearchPending;

		// Token: 0x04001CA0 RID: 7328
		public float timeSinceLastShot;

		// Token: 0x04001CA1 RID: 7329
		protected List<PlayerCrimeData.VehicleCollisionInstance> Collisions;

		// Token: 0x04001CA2 RID: 7330
		private MusicTrack _lightCombatTrack;

		// Token: 0x04001CA3 RID: 7331
		private MusicTrack _heavyCombatTrack;

		// Token: 0x04001CA4 RID: 7332
		private float outOfSightTimeToDipMusic;

		// Token: 0x04001CA5 RID: 7333
		private float minMusicVolume;

		// Token: 0x04001CA6 RID: 7334
		private float musicChangeRate_Down;

		// Token: 0x04001CA7 RID: 7335
		private float musicChangeRate_Up;

		// Token: 0x04001CA8 RID: 7336
		public SyncVar<PlayerCrimeData.EPursuitLevel> syncVar___<CurrentPursuitLevel>k__BackingField;

		// Token: 0x04001CA9 RID: 7337
		public SyncVar<Vector3> syncVar___<LastKnownPosition>k__BackingField;

		// Token: 0x04001CAA RID: 7338
		private bool dll_Excuted;

		// Token: 0x04001CAB RID: 7339
		private bool dll_Excuted;

		// Token: 0x020005F1 RID: 1521
		public class VehicleCollisionInstance
		{
			// Token: 0x0600278E RID: 10126 RVA: 0x000A1F93 File Offset: 0x000A0193
			public VehicleCollisionInstance(NPC victim, float timeSince)
			{
				this.Victim = victim;
				this.TimeSince = timeSince;
			}

			// Token: 0x04001CAC RID: 7340
			public NPC Victim;

			// Token: 0x04001CAD RID: 7341
			public float TimeSince;
		}

		// Token: 0x020005F2 RID: 1522
		public enum EPursuitLevel
		{
			// Token: 0x04001CAF RID: 7343
			None,
			// Token: 0x04001CB0 RID: 7344
			Investigating,
			// Token: 0x04001CB1 RID: 7345
			Arresting,
			// Token: 0x04001CB2 RID: 7346
			NonLethal,
			// Token: 0x04001CB3 RID: 7347
			Lethal
		}
	}
}
