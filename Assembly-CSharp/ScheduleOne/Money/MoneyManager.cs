using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Money
{
	// Token: 0x02000B8D RID: 2957
	public class MoneyManager : NetworkSingleton<MoneyManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06004EC5 RID: 20165 RVA: 0x0014C5B3 File Offset: 0x0014A7B3
		public float LifetimeEarnings
		{
			get
			{
				return this.SyncAccessor_lifetimeEarnings;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x0014C5BB File Offset: 0x0014A7BB
		// (set) Token: 0x06004EC7 RID: 20167 RVA: 0x0014C5C3 File Offset: 0x0014A7C3
		public float LastCalculatedNetworth { get; protected set; }

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06004EC8 RID: 20168 RVA: 0x0014C5CC File Offset: 0x0014A7CC
		public float cashBalance
		{
			get
			{
				return this.cashInstance.Balance;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06004EC9 RID: 20169 RVA: 0x0014C5D9 File Offset: 0x0014A7D9
		protected CashInstance cashInstance
		{
			get
			{
				return PlayerSingleton<PlayerInventory>.Instance.cashInstance;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06004ECA RID: 20170 RVA: 0x0014C5E5 File Offset: 0x0014A7E5
		public string SaveFolderName
		{
			get
			{
				return "Money";
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06004ECB RID: 20171 RVA: 0x0014C5E5 File Offset: 0x0014A7E5
		public string SaveFileName
		{
			get
			{
				return "Money";
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06004ECC RID: 20172 RVA: 0x0014C5EC File Offset: 0x0014A7EC
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06004ECD RID: 20173 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x0014C5F4 File Offset: 0x0014A7F4
		// (set) Token: 0x06004ECF RID: 20175 RVA: 0x0014C5FC File Offset: 0x0014A7FC
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06004ED0 RID: 20176 RVA: 0x0014C605 File Offset: 0x0014A805
		// (set) Token: 0x06004ED1 RID: 20177 RVA: 0x0014C60D File Offset: 0x0014A80D
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06004ED2 RID: 20178 RVA: 0x0014C616 File Offset: 0x0014A816
		// (set) Token: 0x06004ED3 RID: 20179 RVA: 0x0014C61E File Offset: 0x0014A81E
		public bool HasChanged { get; set; }

		// Token: 0x06004ED4 RID: 20180 RVA: 0x0014C627 File Offset: 0x0014A827
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Money.MoneyManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x0014C63C File Offset: 0x0014A83C
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.Loaded));
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onDayPass = (Action)Delegate.Combine(instance2.onDayPass, new Action(this.CheckNetworthAchievements));
			Singleton<HUD>.Instance.OnlineBalanceDisplay.SetBalance(this.SyncAccessor_onlineBalance);
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x0014C6CB File Offset: 0x0014A8CB
		public override void OnStartServer()
		{
			base.OnStartServer();
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("LifetimeEarnings", this.lifetimeEarnings.ToString(), true);
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x0014C6EE File Offset: 0x0014A8EE
		public override void OnStartClient()
		{
			base.OnStartClient();
			Singleton<HUD>.Instance.OnlineBalanceDisplay.SetBalance(this.SyncAccessor_onlineBalance);
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x0014C70C File Offset: 0x0014A90C
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
				TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
				instance2.onDayPass = (Action)Delegate.Remove(instance2.onDayPass, new Action(this.CheckNetworthAchievements));
			}
			if (Singleton<LoadManager>.InstanceExists)
			{
				Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.Loaded));
			}
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x0014C794 File Offset: 0x0014A994
		private void Loaded()
		{
			this.GetNetWorth();
			Singleton<HUD>.Instance.OnlineBalanceDisplay.SetBalance(this.SyncAccessor_onlineBalance);
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x0014C7B2 File Offset: 0x0014A9B2
		private void Update()
		{
			this.HasChanged = true;
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x0014C7BC File Offset: 0x0014A9BC
		private void MinPass()
		{
			if (NetworkSingleton<VariableDatabase>.InstanceExists)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Online_Balance", this.onlineBalance.ToString(), false);
				if (PlayerSingleton<PlayerInventory>.InstanceExists)
				{
					NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Cash_Balance", this.cashBalance.ToString(), false);
					NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Total_Money", (this.SyncAccessor_onlineBalance + this.cashBalance).ToString(), false);
				}
			}
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x0014C835 File Offset: 0x0014AA35
		public CashInstance GetCashInstance(float amount)
		{
			CashInstance cashInstance = Registry.GetItem<CashDefinition>("cash").GetDefaultInstance(1) as CashInstance;
			cashInstance.SetBalance(amount, false);
			return cashInstance;
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x0014C854 File Offset: 0x0014AA54
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			this.RpcWriter___Server_CreateOnlineTransaction_1419830531(_transaction_Name, _unit_Amount, _quantity, _transaction_Note);
			this.RpcLogic___CreateOnlineTransaction_1419830531(_transaction_Name, _unit_Amount, _quantity, _transaction_Note);
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x0014C884 File Offset: 0x0014AA84
		[ObserversRpc]
		private void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			this.RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(_transaction_Name, _unit_Amount, _quantity, _transaction_Note);
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x0014C8A7 File Offset: 0x0014AAA7
		protected IEnumerator ShowOnlineBalanceChange(RectTransform changeDisplay)
		{
			TextMeshProUGUI text = changeDisplay.GetComponent<TextMeshProUGUI>();
			float startVert = changeDisplay.anchoredPosition.y;
			float lerpTime = 2.5f;
			float vertOffset = startVert + 60f;
			for (float i = 0f; i < lerpTime; i += Time.unscaledDeltaTime)
			{
				text.color = new Color(text.color.r, text.color.g, text.color.b, Mathf.Lerp(1f, 0f, i / lerpTime));
				changeDisplay.anchoredPosition = new Vector2(changeDisplay.anchoredPosition.x, Mathf.Lerp(startVert, vertOffset, i / lerpTime));
				yield return new WaitForEndOfFrame();
			}
			Object.Destroy(changeDisplay.gameObject);
			yield break;
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x0014C8B6 File Offset: 0x0014AAB6
		[ServerRpc(RequireOwnership = false)]
		public void ChangeLifetimeEarnings(float change)
		{
			this.RpcWriter___Server_ChangeLifetimeEarnings_431000436(change);
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x0014C8C4 File Offset: 0x0014AAC4
		public void ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)
		{
			float num = Mathf.Clamp(this.cashInstance.Balance + change, 0f, float.MaxValue) - this.cashInstance.Balance;
			this.cashInstance.ChangeBalance(change);
			if (playCashSound && num != 0f)
			{
				Console.Log("Playing cash sound: " + num.ToString(), null);
				this.CashSound.Play();
			}
			if (visualizeChange && num != 0f)
			{
				RectTransform component = Object.Instantiate<GameObject>(this.cashChangePrefab, Singleton<HUD>.Instance.cashSlotContainer).GetComponent<RectTransform>();
				component.position = new Vector3(Singleton<HUD>.Instance.cashSlotUI.position.x, component.position.y);
				component.anchoredPosition = new Vector2(component.anchoredPosition.x, 10f);
				TextMeshProUGUI component2 = component.GetComponent<TextMeshProUGUI>();
				if (num > 0f)
				{
					component2.text = "+ " + MoneyManager.FormatAmount(num, false, false);
					component2.color = new Color32(25, 240, 30, byte.MaxValue);
				}
				else
				{
					component2.text = MoneyManager.FormatAmount(num, false, false);
					component2.color = new Color32(176, 63, 59, byte.MaxValue);
				}
				Singleton<CoroutineService>.Instance.StartCoroutine(this.ShowCashChange(component));
			}
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x0014CA29 File Offset: 0x0014AC29
		protected IEnumerator ShowCashChange(RectTransform changeDisplay)
		{
			TextMeshProUGUI text = changeDisplay.GetComponent<TextMeshProUGUI>();
			float startVert = changeDisplay.anchoredPosition.y;
			float lerpTime = 2.5f;
			float vertOffset = startVert + 60f;
			for (float i = 0f; i < lerpTime; i += Time.unscaledDeltaTime)
			{
				text.color = new Color(text.color.r, text.color.g, text.color.b, Mathf.Lerp(1f, 0f, i / lerpTime));
				changeDisplay.anchoredPosition = new Vector2(changeDisplay.anchoredPosition.x, Mathf.Lerp(startVert, vertOffset, i / lerpTime));
				yield return new WaitForEndOfFrame();
			}
			Object.Destroy(changeDisplay.gameObject);
			yield break;
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x0014CA38 File Offset: 0x0014AC38
		public static string FormatAmount(float amount, bool showDecimals = false, bool includeColor = false)
		{
			string text = string.Empty;
			if (includeColor)
			{
				text += "<color=#54E717>";
			}
			if (amount < 0f)
			{
				text = "-";
			}
			if (showDecimals)
			{
				text += string.Format(new CultureInfo("en-US"), "{0:C}", Mathf.Abs(amount));
			}
			else
			{
				text += string.Format(new CultureInfo("en-US"), "{0:C0}", Mathf.RoundToInt(Mathf.Abs(amount)));
			}
			if (includeColor)
			{
				text += "</color>";
			}
			return text;
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x0014CACE File Offset: 0x0014ACCE
		public virtual string GetSaveString()
		{
			return new MoneyData(this.SyncAccessor_onlineBalance, this.GetNetWorth(), this.SyncAccessor_lifetimeEarnings, ATM.WeeklyDepositSum).GetJson(true);
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x0014CAF4 File Offset: 0x0014ACF4
		public void Load(MoneyData data)
		{
			this.sync___set_value_onlineBalance(Mathf.Clamp(data.OnlineBalance, 0f, float.MaxValue), true);
			this.sync___set_value_lifetimeEarnings(Mathf.Clamp(data.LifetimeEarnings, 0f, float.MaxValue), true);
			Singleton<HUD>.Instance.OnlineBalanceDisplay.SetBalance(this.SyncAccessor_onlineBalance);
			ATM.WeeklyDepositSum = data.WeeklyDepositSum;
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x0014CB59 File Offset: 0x0014AD59
		public void CheckNetworthAchievements()
		{
			float netWorth = this.GetNetWorth();
			if (netWorth >= 100000f)
			{
				Singleton<AchievementManager>.Instance.UnlockAchievement(AchievementManager.EAchievement.BUSINESSMAN);
			}
			if (netWorth >= 1000000f)
			{
				Singleton<AchievementManager>.Instance.UnlockAchievement(AchievementManager.EAchievement.BIGWIG);
			}
			if (netWorth >= 10000000f)
			{
				Singleton<AchievementManager>.Instance.UnlockAchievement(AchievementManager.EAchievement.MAGNATE);
			}
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x0014CB9C File Offset: 0x0014AD9C
		public float GetNetWorth()
		{
			float num = 0f;
			num += this.SyncAccessor_onlineBalance;
			if (this.onNetworthCalculation != null)
			{
				MoneyManager.FloatContainer floatContainer = new MoneyManager.FloatContainer();
				this.onNetworthCalculation(floatContainer);
				num += floatContainer.value;
			}
			this.LastCalculatedNetworth = num;
			return num;
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x0014CC18 File Offset: 0x0014AE18
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___lifetimeEarnings = new SyncVar<float>(this, 1U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.lifetimeEarnings);
			this.syncVar___onlineBalance = new SyncVar<float>(this, 0U, WritePermission.ClientUnsynchronized, ReadPermission.Observers, -1f, Channel.Reliable, this.onlineBalance);
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_CreateOnlineTransaction_1419830531));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveOnlineTransaction_1419830531));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_ChangeLifetimeEarnings_431000436));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Money.MoneyManager));
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x0014CCE9 File Offset: 0x0014AEE9
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___lifetimeEarnings.SetRegistered();
			this.syncVar___onlineBalance.SetRegistered();
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x0014CD18 File Offset: 0x0014AF18
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x0014CD28 File Offset: 0x0014AF28
		private void RpcWriter___Server_CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
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
			writer.WriteString(_transaction_Name);
			writer.WriteSingle(_unit_Amount, AutoPackType.Unpacked);
			writer.WriteSingle(_quantity, AutoPackType.Unpacked);
			writer.WriteString(_transaction_Note);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x0014CE00 File Offset: 0x0014B000
		public void RpcLogic___CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			this.ReceiveOnlineTransaction(_transaction_Name, _unit_Amount, _quantity, _transaction_Note);
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x0014CE10 File Offset: 0x0014B010
		private void RpcReader___Server_CreateOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			string transaction_Name = PooledReader0.ReadString();
			float unit_Amount = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			float quantity = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			string transaction_Note = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___CreateOnlineTransaction_1419830531(transaction_Name, unit_Amount, quantity, transaction_Note);
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x0014CE8C File Offset: 0x0014B08C
		private void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
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
			writer.WriteString(_transaction_Name);
			writer.WriteSingle(_unit_Amount, AutoPackType.Unpacked);
			writer.WriteSingle(_quantity, AutoPackType.Unpacked);
			writer.WriteString(_transaction_Note);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x0014CF74 File Offset: 0x0014B174
		private void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			Transaction transaction = new Transaction(_transaction_Name, _unit_Amount, _quantity, _transaction_Note);
			this.ledger.Add(transaction);
			this.sync___set_value_onlineBalance(this.SyncAccessor_onlineBalance + transaction.total_Amount, true);
			Singleton<HUD>.Instance.OnlineBalanceDisplay.SetBalance(this.SyncAccessor_onlineBalance);
			Singleton<HUD>.Instance.OnlineBalanceDisplay.Show();
			RectTransform component = Object.Instantiate<GameObject>(this.moneyChangePrefab, Singleton<HUD>.Instance.cashSlotContainer).GetComponent<RectTransform>();
			component.position = new Vector3(Singleton<HUD>.Instance.onlineBalanceSlotUI.position.x, component.position.y);
			component.anchoredPosition = new Vector2(component.anchoredPosition.x, 10f);
			TextMeshProUGUI component2 = component.GetComponent<TextMeshProUGUI>();
			if (transaction.total_Amount > 0f)
			{
				component2.text = "+ " + MoneyManager.FormatAmount(transaction.total_Amount, false, false);
				component2.color = new Color32(25, 190, 240, byte.MaxValue);
			}
			else
			{
				component2.text = MoneyManager.FormatAmount(transaction.total_Amount, false, false);
				component2.color = new Color32(176, 63, 59, byte.MaxValue);
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(this.ShowOnlineBalanceChange(component));
			this.HasChanged = true;
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x0014D0D0 File Offset: 0x0014B2D0
		private void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel)
		{
			string transaction_Name = PooledReader0.ReadString();
			float unit_Amount = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			float quantity = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			string transaction_Note = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveOnlineTransaction_1419830531(transaction_Name, unit_Amount, quantity, transaction_Note);
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x0014D140 File Offset: 0x0014B340
		private void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change)
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
			writer.WriteSingle(change, AutoPackType.Unpacked);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x0014D1EC File Offset: 0x0014B3EC
		public void RpcLogic___ChangeLifetimeEarnings_431000436(float change)
		{
			this.sync___set_value_lifetimeEarnings(Mathf.Clamp(this.SyncAccessor_lifetimeEarnings + change, 0f, float.MaxValue), true);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("LifetimeEarnings", this.lifetimeEarnings.ToString(), true);
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x0014D228 File Offset: 0x0014B428
		private void RpcReader___Server_ChangeLifetimeEarnings_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float change = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___ChangeLifetimeEarnings_431000436(change);
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x0014D25E File Offset: 0x0014B45E
		// (set) Token: 0x06004EF7 RID: 20215 RVA: 0x0014D266 File Offset: 0x0014B466
		public float SyncAccessor_onlineBalance
		{
			get
			{
				return this.onlineBalance;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.onlineBalance = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___onlineBalance.SetValue(value, value);
				}
			}
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x0014D2A4 File Offset: 0x0014B4A4
		public virtual bool MoneyManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 == 1U)
			{
				if (PooledReader0 == null)
				{
					this.sync___set_value_lifetimeEarnings(this.syncVar___lifetimeEarnings.GetValue(true), true);
					return true;
				}
				float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_lifetimeEarnings(value, Boolean2);
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
					this.sync___set_value_onlineBalance(this.syncVar___onlineBalance.GetValue(true), true);
					return true;
				}
				float value2 = PooledReader0.ReadSingle(AutoPackType.Unpacked);
				this.sync___set_value_onlineBalance(value2, Boolean2);
				return true;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x0014D344 File Offset: 0x0014B544
		// (set) Token: 0x06004EFA RID: 20218 RVA: 0x0014D34C File Offset: 0x0014B54C
		public float SyncAccessor_lifetimeEarnings
		{
			get
			{
				return this.lifetimeEarnings;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.lifetimeEarnings = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___lifetimeEarnings.SetValue(value, value);
				}
			}
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x0014D388 File Offset: 0x0014B588
		protected virtual void dll()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x04003B78 RID: 15224
		public const string MONEY_TEXT_COLOR = "#54E717";

		// Token: 0x04003B79 RID: 15225
		public const string MONEY_TEXT_COLOR_DARKER = "#46CB4F";

		// Token: 0x04003B7A RID: 15226
		public const string ONLINE_BALANCE_COLOR = "#4CBFFF";

		// Token: 0x04003B7B RID: 15227
		public List<Transaction> ledger = new List<Transaction>();

		// Token: 0x04003B7C RID: 15228
		[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public float onlineBalance;

		// Token: 0x04003B7D RID: 15229
		[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public float lifetimeEarnings;

		// Token: 0x04003B7F RID: 15231
		public AudioSourceController CashSound;

		// Token: 0x04003B80 RID: 15232
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject moneyChangePrefab;

		// Token: 0x04003B81 RID: 15233
		[SerializeField]
		protected GameObject cashChangePrefab;

		// Token: 0x04003B82 RID: 15234
		public Sprite LaunderingNotificationIcon;

		// Token: 0x04003B83 RID: 15235
		public Action<MoneyManager.FloatContainer> onNetworthCalculation;

		// Token: 0x04003B84 RID: 15236
		private MoneyLoader loader = new MoneyLoader();

		// Token: 0x04003B88 RID: 15240
		public SyncVar<float> syncVar___onlineBalance;

		// Token: 0x04003B89 RID: 15241
		public SyncVar<float> syncVar___lifetimeEarnings;

		// Token: 0x04003B8A RID: 15242
		private bool dll_Excuted;

		// Token: 0x04003B8B RID: 15243
		private bool dll_Excuted;

		// Token: 0x02000B8E RID: 2958
		public class FloatContainer
		{
			// Token: 0x17000AE0 RID: 2784
			// (get) Token: 0x06004EFC RID: 20220 RVA: 0x0014D396 File Offset: 0x0014B596
			// (set) Token: 0x06004EFD RID: 20221 RVA: 0x0014D39E File Offset: 0x0014B59E
			public float value { get; private set; }

			// Token: 0x06004EFE RID: 20222 RVA: 0x0014D3A7 File Offset: 0x0014B5A7
			public void ChangeValue(float value)
			{
				this.value += value;
			}
		}
	}
}
