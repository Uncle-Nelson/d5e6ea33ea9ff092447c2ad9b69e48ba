using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.GameTime;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Employees
{
	// Token: 0x02000649 RID: 1609
	public class Employee : NPC
	{
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000B193A File Offset: 0x000AFB3A
		// (set) Token: 0x06002B29 RID: 11049 RVA: 0x000B1942 File Offset: 0x000AFB42
		public Property AssignedProperty { get; protected set; }

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000B194B File Offset: 0x000AFB4B
		// (set) Token: 0x06002B2B RID: 11051 RVA: 0x000B1953 File Offset: 0x000AFB53
		public int EmployeeIndex { get; protected set; }

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000B195C File Offset: 0x000AFB5C
		// (set) Token: 0x06002B2D RID: 11053 RVA: 0x000B1964 File Offset: 0x000AFB64
		public bool PaidForToday
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<PaidForToday>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.sync___set_value_<PaidForToday>k__BackingField(value, true);
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000B196E File Offset: 0x000AFB6E
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x000B1976 File Offset: 0x000AFB76
		public bool Fired { get; private set; }

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x000B197F File Offset: 0x000AFB7F
		public bool IsWaitingOutside
		{
			get
			{
				return this.WaitOutside.Active;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x000B198C File Offset: 0x000AFB8C
		// (set) Token: 0x06002B32 RID: 11058 RVA: 0x000B1994 File Offset: 0x000AFB94
		public bool IsMale { get; private set; } = true;

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x000B199D File Offset: 0x000AFB9D
		// (set) Token: 0x06002B34 RID: 11060 RVA: 0x000B19A5 File Offset: 0x000AFBA5
		private protected int AppearanceIndex { protected get; private set; }

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000B19AE File Offset: 0x000AFBAE
		public EEmployeeType EmployeeType
		{
			get
			{
				return this.Type;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x000B19B6 File Offset: 0x000AFBB6
		// (set) Token: 0x06002B37 RID: 11063 RVA: 0x000B19BE File Offset: 0x000AFBBE
		public int TimeSinceLastWorked { get; private set; }

		// Token: 0x06002B38 RID: 11064 RVA: 0x000B19C8 File Offset: 0x000AFBC8
		protected override void Start()
		{
			base.Start();
			DialogueController.DialogueChoice dialogueChoice = new DialogueController.DialogueChoice();
			dialogueChoice.ChoiceText = "Why aren't you working?";
			dialogueChoice.Enabled = true;
			dialogueChoice.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.ShouldShowNoWorkDialogue);
			dialogueChoice.onChoosen.AddListener(new UnityAction(this.OnNotWorkingDialogue));
			this.dialogueHandler.GetComponent<DialogueController>().AddDialogueChoice(dialogueChoice, 0);
			DialogueController.DialogueChoice dialogueChoice2 = new DialogueController.DialogueChoice();
			dialogueChoice2.ChoiceText = "Your services are no longer required.";
			dialogueChoice2.Enabled = true;
			dialogueChoice2.shouldShowCheck = new DialogueController.DialogueChoice.ShouldShowCheck(this.ShouldShowFireDialogue);
			dialogueChoice2.Conversation = this.FireDialogue;
			this.dialogueHandler.GetComponent<DialogueController>().AddDialogueChoice(dialogueChoice2, 0);
			this.dialogueHandler.onDialogueChoiceChosen.AddListener(new UnityAction<string>(this.CheckDialogueChoice));
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000B1A95 File Offset: 0x000AFC95
		public override void OnStartServer()
		{
			base.OnStartServer();
			this.Health.onDie.AddListener(new UnityAction(this.SendFire));
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000B1ABC File Offset: 0x000AFCBC
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (connection.IsLocalClient)
			{
				return;
			}
			this.Initialize(connection, this.FirstName, this.LastName, this.ID, base.GUID.ToString(), this.AssignedProperty.PropertyCode, this.IsMale, this.AppearanceIndex);
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x000B1B20 File Offset: 0x000AFD20
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Initialize_2260823878(conn, firstName, lastName, id, guid, propertyID, male, appearanceIndex);
				this.RpcLogic___Initialize_2260823878(conn, firstName, lastName, id, guid, propertyID, male, appearanceIndex);
			}
			else
			{
				this.RpcWriter___Target_Initialize_2260823878(conn, firstName, lastName, id, guid, propertyID, male, appearanceIndex);
			}
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x000B1BAC File Offset: 0x000AFDAC
		protected virtual void AssignProperty(Property prop)
		{
			this.AssignedProperty = prop;
			this.EmployeeIndex = this.AssignedProperty.RegisterEmployee(this);
			this.movement.Warp(prop.NPCSpawnPoint.position);
			this.WaitOutside.IdlePoint = prop.EmployeeIdlePoints[this.EmployeeIndex];
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x000B1C00 File Offset: 0x000AFE00
		protected virtual void InitializeInfo(string firstName, string lastName, string id)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.ID = id;
			NetworkSingleton<EmployeeManager>.Instance.RegisterName(firstName + " " + lastName);
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x000B1C30 File Offset: 0x000AFE30
		protected virtual void InitializeAppearance(bool male, int index)
		{
			this.IsMale = male;
			this.AppearanceIndex = index;
			EmployeeManager.EmployeeAppearance appearance = NetworkSingleton<EmployeeManager>.Instance.GetAppearance(male, index);
			appearance.Settings.BodyLayerSettings.Clear();
			this.Avatar.LoadNakedSettings(appearance.Settings, 100);
			this.MugshotSprite = appearance.Mugshot;
			this.VoiceOverEmitter.SetDatabase(NetworkSingleton<EmployeeManager>.Instance.GetVoice(male, index), true);
			int num = (this.FirstName + this.LastName).GetHashCode() / 1000;
			this.VoiceOverEmitter.PitchMultiplier = 0.9f + (float)(num % 10) / 10f * 0.2f;
			NetworkSingleton<EmployeeManager>.Instance.RegisterAppearance(male, index);
			float num2 = male ? 0.8f : 1.3f;
			float num3 = 0.2f;
			float num4 = -num3 / 2f + Mathf.Clamp01((float)(this.FirstName.GetHashCode() % 10) / 10f) * num3;
			num2 += num4;
			this.VoiceOverEmitter.PitchMultiplier = num2;
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x000B1D38 File Offset: 0x000AFF38
		protected virtual void CheckDialogueChoice(string choiceLabel)
		{
			if (choiceLabel == "CONFIRM_FIRE")
			{
				this.SendFire();
			}
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000B1D4D File Offset: 0x000AFF4D
		[ServerRpc(RequireOwnership = false)]
		public void SendFire()
		{
			this.RpcWriter___Server_SendFire_2166136261();
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x000B1D55 File Offset: 0x000AFF55
		[ObserversRpc]
		private void ReceiveFire()
		{
			this.RpcWriter___Observers_ReceiveFire_2166136261();
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000B1D60 File Offset: 0x000AFF60
		protected virtual void Fire()
		{
			Console.Log("Firing employee " + this.FirstName + " " + this.LastName, null);
			this.AssignedProperty.DeregisterEmployee(this);
			this.Avatar.EmotionManager.AddEmotionOverride("Concerned", "fired", 0f, 0);
			this.SetWaitOutside(false);
			this.Fired = true;
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000B1DC8 File Offset: 0x000AFFC8
		protected bool CanWork()
		{
			return this.GetBed() != null && this.PaidForToday && !NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsEndOfDay;
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000B1DF0 File Offset: 0x000AFFF0
		protected new virtual void OnDestroy()
		{
			if (InstanceFinder.IsServer)
			{
				ScheduleOne.GameTime.TimeManager.onSleepEnd = (Action<int>)Delegate.Remove(ScheduleOne.GameTime.TimeManager.onSleepEnd, new Action<int>(this.OnSleepEnd));
			}
			if (NetworkSingleton<EmployeeManager>.InstanceExists)
			{
				NetworkSingleton<EmployeeManager>.Instance.AllEmployees.Remove(this);
			}
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000B1E3C File Offset: 0x000B003C
		protected virtual void UpdateBehaviour()
		{
			if (this.Fired)
			{
				return;
			}
			if (this.behaviour.activeBehaviour == null || this.behaviour.activeBehaviour == this.WaitOutside)
			{
				bool flag = false;
				bool flag2 = false;
				if (this.GetBed() == null)
				{
					flag = true;
					this.SubmitNoWorkReason("I haven't been assigned a bed", "You can use your management clipboard to assign me a bed.", 0);
				}
				else if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsEndOfDay)
				{
					flag = true;
					this.SubmitNoWorkReason("Sorry boss, my shift ends at 4AM.", string.Empty, 0);
				}
				else if (!this.PaidForToday)
				{
					if (this.IsPayAvailable())
					{
						flag2 = true;
					}
					else
					{
						flag = true;
						this.SubmitNoWorkReason("I haven't been paid yet", "You can place cash in my briefcase on my bed.", 0);
					}
				}
				if (flag)
				{
					this.SetWaitOutside(true);
					return;
				}
				if (InstanceFinder.IsServer && flag2 && this.IsPayAvailable())
				{
					this.RemoveDailyWage();
					this.SetIsPaid();
				}
			}
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000B1F17 File Offset: 0x000B0117
		protected void MarkIsWorking()
		{
			this.TimeSinceLastWorked = 0;
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000B1F20 File Offset: 0x000B0120
		private void SetWaitOutside(bool wait)
		{
			if (wait)
			{
				if (!this.WaitOutside.Enabled)
				{
					this.WaitOutside.Enable_Networked(null);
					return;
				}
			}
			else if (this.WaitOutside.Enabled || this.WaitOutside.Active)
			{
				this.WaitOutside.Disable_Networked(null);
				this.WaitOutside.End_Networked(null);
			}
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000141BA File Offset: 0x000123BA
		protected virtual bool ShouldIdle()
		{
			return false;
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x000141BA File Offset: 0x000123BA
		protected override bool ShouldNoticeGeneralCrime(Player player)
		{
			return false;
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x000B1F7C File Offset: 0x000B017C
		protected override void MinPass()
		{
			base.MinPass();
			int timeSinceLastWorked = this.TimeSinceLastWorked;
			this.TimeSinceLastWorked = timeSinceLastWorked + 1;
			this.WorkIssues.Clear();
			this.UpdateBehaviour();
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x000B1FB0 File Offset: 0x000B01B0
		private void OnSleepEnd(int sleepTime)
		{
			this.PaidForToday = false;
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x000B1FB9 File Offset: 0x000B01B9
		public void SetIsPaid()
		{
			this.PaidForToday = true;
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x000141BA File Offset: 0x000123BA
		public override bool ShouldSave()
		{
			return false;
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000B1FC4 File Offset: 0x000B01C4
		public override string GetSaveString()
		{
			return new EmployeeData(this.ID, this.AssignedProperty.PropertyCode, this.FirstName, this.LastName, this.IsMale, this.AppearanceIndex, base.transform.position, base.transform.rotation, base.GUID, this.PaidForToday).GetJson(true);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000B2027 File Offset: 0x000B0227
		public virtual BedItem GetBed()
		{
			Console.LogError("GETBED NOT IMPLEMENTED", null);
			return null;
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x000B2038 File Offset: 0x000B0238
		public bool IsPayAvailable()
		{
			BedItem bed = this.GetBed();
			return !(bed == null) && bed.GetCashSum() >= this.DailyWage;
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000B2068 File Offset: 0x000B0268
		public void RemoveDailyWage()
		{
			Console.Log("Removing daily wage", null);
			BedItem bed = this.GetBed();
			if (bed == null)
			{
				return;
			}
			if (bed.GetCashSum() >= this.DailyWage)
			{
				bed.RemoveCash(this.DailyWage);
			}
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000B20AC File Offset: 0x000B02AC
		public virtual bool GetWorkIssue(out DialogueContainer notWorkingReason)
		{
			if (this.GetBed() == null)
			{
				notWorkingReason = this.BedNotAssignedDialogue;
				return true;
			}
			if (!this.PaidForToday)
			{
				notWorkingReason = this.NotPaidDialogue;
				return true;
			}
			if (this.TimeSinceLastWorked >= 5 && this.WorkIssues.Count > 0)
			{
				notWorkingReason = Object.Instantiate<DialogueContainer>(this.WorkIssueDialogueTemplate);
				notWorkingReason.GetDialogueNodeByLabel("ENTRY").DialogueText = this.WorkIssues[0].Reason;
				if (!string.IsNullOrEmpty(this.WorkIssues[0].Fix))
				{
					notWorkingReason.GetDialogueNodeByLabel("FIX").DialogueText = this.WorkIssues[0].Fix;
				}
				else
				{
					notWorkingReason.GetDialogueNodeByLabel("ENTRY").choices = new DialogueChoiceData[0];
				}
				return true;
			}
			notWorkingReason = null;
			return false;
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x000B2188 File Offset: 0x000B0388
		public virtual void SetIdle(bool idle)
		{
			this.SetWaitOutside(idle);
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x000B2194 File Offset: 0x000B0394
		protected void LeavePropertyAndDespawn()
		{
			if (this.movement.IsMoving)
			{
				return;
			}
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.movement.IsAsCloseAsPossible(this.AssignedProperty.NPCSpawnPoint.position, 1f))
			{
				base.Despawn(base.NetworkObject, null);
				return;
			}
			this.movement.SetDestination(this.AssignedProperty.NPCSpawnPoint.position);
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x000B220C File Offset: 0x000B040C
		[ObserversRpc(RunLocally = true)]
		public void SubmitNoWorkReason(string reason, string fix, int priority = 0)
		{
			this.RpcWriter___Observers_SubmitNoWorkReason_15643032(reason, fix, priority);
			this.RpcLogic___SubmitNoWorkReason_15643032(reason, fix, priority);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x000B2240 File Offset: 0x000B0440
		private bool ShouldShowNoWorkDialogue(bool enabled)
		{
			DialogueContainer dialogueContainer;
			return !this.Fired && this.WaitOutside.Active && this.GetWorkIssue(out dialogueContainer);
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000B2270 File Offset: 0x000B0470
		private void OnNotWorkingDialogue()
		{
			DialogueContainer container;
			if (!this.GetWorkIssue(out container))
			{
				return;
			}
			this.dialogueHandler.InitializeDialogue(container);
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000B2294 File Offset: 0x000B0494
		private bool ShouldShowFireDialogue(bool enabled)
		{
			return !this.Fired;
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x000B22D4 File Offset: 0x000B04D4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___<PaidForToday>k__BackingField = new SyncVar<bool>(this, 1U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.<PaidForToday>k__BackingField);
			base.RegisterObserversRpc(35U, new ClientRpcDelegate(this.RpcReader___Observers_Initialize_2260823878));
			base.RegisterTargetRpc(36U, new ClientRpcDelegate(this.RpcReader___Target_Initialize_2260823878));
			base.RegisterServerRpc(37U, new ServerRpcDelegate(this.RpcReader___Server_SendFire_2166136261));
			base.RegisterObserversRpc(38U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveFire_2166136261));
			base.RegisterObserversRpc(39U, new ClientRpcDelegate(this.RpcReader___Observers_SubmitNoWorkReason_15643032));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Employees.Employee));
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x000B23A8 File Offset: 0x000B05A8
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___<PaidForToday>k__BackingField.SetRegistered();
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x000B23CC File Offset: 0x000B05CC
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000B23DC File Offset: 0x000B05DC
		private void RpcWriter___Observers_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
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
			writer.WriteString(firstName);
			writer.WriteString(lastName);
			writer.WriteString(id);
			writer.WriteString(guid);
			writer.WriteString(propertyID);
			writer.WriteBoolean(male);
			writer.WriteInt32(appearanceIndex, AutoPackType.Packed);
			base.SendObserversRpc(35U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x000B24E8 File Offset: 0x000B06E8
		public virtual void RpcLogic___Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			if (this.initialized)
			{
				return;
			}
			NetworkSingleton<EmployeeManager>.Instance.AllEmployees.Add(this);
			this.initialized = true;
			base.SetGUID(new Guid(guid));
			this.InitializeInfo(firstName, lastName, id);
			this.InitializeAppearance(male, appearanceIndex);
			this.AssignProperty(Singleton<PropertyManager>.Instance.GetProperty(propertyID));
			this.movement.Agent.avoidancePriority = 10 + appearanceIndex;
			if (InstanceFinder.IsServer)
			{
				ScheduleOne.GameTime.TimeManager.onSleepEnd = (Action<int>)Delegate.Combine(ScheduleOne.GameTime.TimeManager.onSleepEnd, new Action<int>(this.OnSleepEnd));
			}
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000B2584 File Offset: 0x000B0784
		private void RpcReader___Observers_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			string firstName = PooledReader0.ReadString();
			string lastName = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			string guid = PooledReader0.ReadString();
			string propertyID = PooledReader0.ReadString();
			bool male = PooledReader0.ReadBoolean();
			int appearanceIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Initialize_2260823878(null, firstName, lastName, id, guid, propertyID, male, appearanceIndex);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000B262C File Offset: 0x000B082C
		private void RpcWriter___Target_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
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
			writer.WriteString(firstName);
			writer.WriteString(lastName);
			writer.WriteString(id);
			writer.WriteString(guid);
			writer.WriteString(propertyID);
			writer.WriteBoolean(male);
			writer.WriteInt32(appearanceIndex, AutoPackType.Packed);
			base.SendTargetRpc(36U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x000B2734 File Offset: 0x000B0934
		private void RpcReader___Target_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			string firstName = PooledReader0.ReadString();
			string lastName = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			string guid = PooledReader0.ReadString();
			string propertyID = PooledReader0.ReadString();
			bool male = PooledReader0.ReadBoolean();
			int appearanceIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Initialize_2260823878(base.LocalConnection, firstName, lastName, id, guid, propertyID, male, appearanceIndex);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000B27D8 File Offset: 0x000B09D8
		private void RpcWriter___Server_SendFire_2166136261()
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
			base.SendServerRpc(37U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000B2872 File Offset: 0x000B0A72
		public void RpcLogic___SendFire_2166136261()
		{
			this.ReceiveFire();
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000B287C File Offset: 0x000B0A7C
		private void RpcReader___Server_SendFire_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendFire_2166136261();
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000B289C File Offset: 0x000B0A9C
		private void RpcWriter___Observers_ReceiveFire_2166136261()
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
			base.SendObserversRpc(38U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x000B2945 File Offset: 0x000B0B45
		private void RpcLogic___ReceiveFire_2166136261()
		{
			this.Fire();
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000B2950 File Offset: 0x000B0B50
		private void RpcReader___Observers_ReceiveFire_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveFire_2166136261();
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000B2970 File Offset: 0x000B0B70
		private void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
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
			writer.WriteString(reason);
			writer.WriteString(fix);
			writer.WriteInt32(priority, AutoPackType.Packed);
			base.SendObserversRpc(39U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000B2A48 File Offset: 0x000B0C48
		public void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
			Employee.NoWorkReason noWorkReason = new Employee.NoWorkReason(reason, fix, priority);
			for (int i = 0; i < this.WorkIssues.Count; i++)
			{
				if (this.WorkIssues[i].Priority < noWorkReason.Priority)
				{
					this.WorkIssues.Insert(i, noWorkReason);
					return;
				}
			}
			this.WorkIssues.Add(noWorkReason);
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000B2AA8 File Offset: 0x000B0CA8
		private void RpcReader___Observers_SubmitNoWorkReason_15643032(PooledReader PooledReader0, Channel channel)
		{
			string reason = PooledReader0.ReadString();
			string fix = PooledReader0.ReadString();
			int priority = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SubmitNoWorkReason_15643032(reason, fix, priority);
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x000B2B0A File Offset: 0x000B0D0A
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x000B2B12 File Offset: 0x000B0D12
		public bool SyncAccessor_<PaidForToday>k__BackingField
		{
			get
			{
				return this.<PaidForToday>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<PaidForToday>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<PaidForToday>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x000B2B50 File Offset: 0x000B0D50
		public virtual bool Employee(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 != 1U)
			{
				return false;
			}
			if (PooledReader0 == null)
			{
				this.sync___set_value_<PaidForToday>k__BackingField(this.syncVar___<PaidForToday>k__BackingField.GetValue(true), true);
				return true;
			}
			bool value = PooledReader0.ReadBoolean();
			this.sync___set_value_<PaidForToday>k__BackingField(value, Boolean2);
			return true;
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x000B2BA2 File Offset: 0x000B0DA2
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001F3A RID: 7994
		public bool DEBUG;

		// Token: 0x04001F41 RID: 8001
		[SerializeField]
		protected EEmployeeType Type;

		// Token: 0x04001F42 RID: 8002
		[Header("Payment")]
		public float SigningFee = 500f;

		// Token: 0x04001F43 RID: 8003
		public float DailyWage = 100f;

		// Token: 0x04001F44 RID: 8004
		[Header("References")]
		public IdleBehaviour WaitOutside;

		// Token: 0x04001F45 RID: 8005
		public MoveItemBehaviour MoveItemBehaviour;

		// Token: 0x04001F46 RID: 8006
		public DialogueContainer BedNotAssignedDialogue;

		// Token: 0x04001F47 RID: 8007
		public DialogueContainer NotPaidDialogue;

		// Token: 0x04001F48 RID: 8008
		public DialogueContainer WorkIssueDialogueTemplate;

		// Token: 0x04001F49 RID: 8009
		public DialogueContainer FireDialogue;

		// Token: 0x04001F4A RID: 8010
		private List<Employee.NoWorkReason> WorkIssues = new List<Employee.NoWorkReason>();

		// Token: 0x04001F4C RID: 8012
		protected bool initialized;

		// Token: 0x04001F4D RID: 8013
		public SyncVar<bool> syncVar___<PaidForToday>k__BackingField;

		// Token: 0x04001F4E RID: 8014
		private bool dll_Excuted;

		// Token: 0x04001F4F RID: 8015
		private bool dll_Excuted;

		// Token: 0x0200064A RID: 1610
		public class NoWorkReason
		{
			// Token: 0x06002B6F RID: 11119 RVA: 0x000B2BB6 File Offset: 0x000B0DB6
			public NoWorkReason(string reason, string fix, int priority)
			{
				this.Reason = reason;
				this.Fix = fix;
				this.Priority = priority;
			}

			// Token: 0x04001F50 RID: 8016
			public string Reason;

			// Token: 0x04001F51 RID: 8017
			public string Fix;

			// Token: 0x04001F52 RID: 8018
			public int Priority;
		}
	}
}
