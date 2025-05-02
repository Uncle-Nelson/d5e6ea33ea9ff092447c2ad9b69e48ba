using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x0200080D RID: 2061
	public class Business : Property, ISaveable
	{
		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060037E5 RID: 14309 RVA: 0x000ED2A7 File Offset: 0x000EB4A7
		public float currentLaunderTotal
		{
			get
			{
				return this.LaunderingOperations.Sum((LaunderingOperation x) => x.amount);
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x000ED2D3 File Offset: 0x000EB4D3
		public float appliedLaunderLimit
		{
			get
			{
				return this.LaunderCapacity - this.currentLaunderTotal;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x000ED2E2 File Offset: 0x000EB4E2
		public new string SaveFileName
		{
			get
			{
				return "Business";
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x000ED2E9 File Offset: 0x000EB4E9
		public new Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x000ED2F1 File Offset: 0x000EB4F1
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Property.Business_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x000ED308 File Offset: 0x000EB508
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance2.onTimeSkip = (Action<int>)Delegate.Combine(instance2.onTimeSkip, new Action<int>(this.TimeSkipped));
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x000ED368 File Offset: 0x000EB568
		protected override void OnDestroy()
		{
			Business.Businesses.Remove(this);
			Business.UnownedBusinesses.Remove(this);
			Business.OwnedBusinesses.Remove(this);
			base.OnDestroy();
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x000ED394 File Offset: 0x000EB594
		protected override void GetNetworth(MoneyManager.FloatContainer container)
		{
			base.GetNetworth(container);
			container.ChangeValue(this.currentLaunderTotal);
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x000ED3AC File Offset: 0x000EB5AC
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			for (int i = 0; i < this.LaunderingOperations.Count; i++)
			{
				this.ReceiveLaunderingOperation(connection, this.LaunderingOperations[i].amount, this.LaunderingOperations[i].minutesSinceStarted);
			}
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x000ED3FF File Offset: 0x000EB5FF
		protected virtual void MinPass()
		{
			this.MinsPass(1);
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x000ED408 File Offset: 0x000EB608
		protected virtual void MinsPass(int mins)
		{
			for (int i = 0; i < this.LaunderingOperations.Count; i++)
			{
				this.LaunderingOperations[i].minutesSinceStarted += mins;
				if (this.LaunderingOperations[i].minutesSinceStarted >= this.LaunderingOperations[i].completionTime_Minutes)
				{
					this.CompleteOperation(this.LaunderingOperations[i]);
					i--;
				}
			}
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x000ED47E File Offset: 0x000EB67E
		private void TimeSkipped(int minsPassed)
		{
			this.MinsPass(minsPassed);
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x000ED488 File Offset: 0x000EB688
		public override string GetSaveString()
		{
			bool[] array = new bool[this.Switches.Count];
			for (int i = 0; i < this.Switches.Count; i++)
			{
				array[i] = this.Switches[i].isOn;
			}
			LaunderOperationData[] array2 = new LaunderOperationData[this.LaunderingOperations.Count];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = new LaunderOperationData(this.LaunderingOperations[j].amount, this.LaunderingOperations[j].minutesSinceStarted);
			}
			bool[] array3 = new bool[this.Toggleables.Count];
			for (int k = 0; k < this.Toggleables.Count; k++)
			{
				array3[k] = this.Toggleables[k].IsActivated;
			}
			return new BusinessData(this.propertyCode, base.IsOwned, array, array2, array3).GetJson(true);
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x000ED57C File Offset: 0x000EB77C
		public virtual void Load(BusinessData businessData, string containerPath)
		{
			if (businessData.IsOwned)
			{
				base.SetOwned();
			}
			for (int i = 0; i < businessData.LaunderingOperations.Length; i++)
			{
				this.StartLaunderingOperation(businessData.LaunderingOperations[i].Amount, businessData.LaunderingOperations[i].MinutesSinceStarted);
			}
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x000ED5CA File Offset: 0x000EB7CA
		protected override void RecieveOwned()
		{
			base.RecieveOwned();
			Business.UnownedBusinesses.Remove(this);
			if (!Business.OwnedBusinesses.Contains(this))
			{
				Business.OwnedBusinesses.Add(this);
			}
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x000ED5F6 File Offset: 0x000EB7F6
		[ServerRpc(RequireOwnership = false)]
		public void StartLaunderingOperation(float amount, int minutesSinceStarted = 0)
		{
			this.RpcWriter___Server_StartLaunderingOperation_1481775633(amount, minutesSinceStarted);
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x000ED608 File Offset: 0x000EB808
		[TargetRpc]
		[ObserversRpc]
		private void ReceiveLaunderingOperation(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(conn, amount, minutesSinceStarted);
			}
			else
			{
				this.RpcWriter___Target_ReceiveLaunderingOperation_1001022388(conn, amount, minutesSinceStarted);
			}
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x000ED644 File Offset: 0x000EB844
		protected void CompleteOperation(LaunderingOperation op)
		{
			if (InstanceFinder.IsServer)
			{
				NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Money laundering (" + this.propertyName + ")", op.amount, 1f, string.Empty);
				float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("LaunderingOperationsCompleted");
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("LaunderingOperationsCompleted", (value + 1f).ToString(), true);
			}
			Singleton<NotificationsManager>.Instance.SendNotification(this.propertyName, "<color=#16F01C>" + MoneyManager.FormatAmount(op.amount, false, false) + "</color> Laundered", NetworkSingleton<MoneyManager>.Instance.LaunderingNotificationIcon, 5f, true);
			this.LaunderingOperations.Remove(op);
			base.HasChanged = true;
			if (Business.onOperationFinished != null)
			{
				Business.onOperationFinished(op);
			}
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x000ED764 File Offset: 0x000EB964
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_StartLaunderingOperation_1481775633));
			base.RegisterTargetRpc(6U, new ClientRpcDelegate(this.RpcReader___Target_ReceiveLaunderingOperation_1001022388));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveLaunderingOperation_1001022388));
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x000ED7CD File Offset: 0x000EB9CD
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x000ED7E6 File Offset: 0x000EB9E6
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x000ED7F4 File Offset: 0x000EB9F4
		private void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
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
			writer.WriteSingle(amount, AutoPackType.Unpacked);
			writer.WriteInt32(minutesSinceStarted, AutoPackType.Packed);
			base.SendServerRpc(5U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x000ED8B2 File Offset: 0x000EBAB2
		public void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
			this.ReceiveLaunderingOperation(null, amount, minutesSinceStarted);
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x000ED8C0 File Offset: 0x000EBAC0
		private void RpcReader___Server_StartLaunderingOperation_1481775633(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float amount = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			int minutesSinceStarted = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___StartLaunderingOperation_1481775633(amount, minutesSinceStarted);
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x000ED90C File Offset: 0x000EBB0C
		private void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
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
			writer.WriteSingle(amount, AutoPackType.Unpacked);
			writer.WriteInt32(minutesSinceStarted, AutoPackType.Packed);
			base.SendTargetRpc(6U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x000ED9D8 File Offset: 0x000EBBD8
		private void RpcLogic___ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			LaunderingOperation launderingOperation = new LaunderingOperation(this, amount, minutesSinceStarted);
			this.LaunderingOperations.Add(launderingOperation);
			base.HasChanged = true;
			if (Business.onOperationStarted != null)
			{
				Business.onOperationStarted(launderingOperation);
			}
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x000EDA14 File Offset: 0x000EBC14
		private void RpcReader___Target_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			float amount = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			int minutesSinceStarted = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveLaunderingOperation_1001022388(base.LocalConnection, amount, minutesSinceStarted);
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x000EDA68 File Offset: 0x000EBC68
		private void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
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
			writer.WriteSingle(amount, AutoPackType.Unpacked);
			writer.WriteInt32(minutesSinceStarted, AutoPackType.Packed);
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x000EDB38 File Offset: 0x000EBD38
		private void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			float amount = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			int minutesSinceStarted = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveLaunderingOperation_1001022388(null, amount, minutesSinceStarted);
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x000EDB85 File Offset: 0x000EBD85
		protected virtual void dll()
		{
			base.Awake();
			Business.Businesses.Add(this);
			Business.UnownedBusinesses.Remove(this);
			Business.UnownedBusinesses.Add(this);
		}

		// Token: 0x040028C5 RID: 10437
		public static List<Business> Businesses = new List<Business>();

		// Token: 0x040028C6 RID: 10438
		public static List<Business> UnownedBusinesses = new List<Business>();

		// Token: 0x040028C7 RID: 10439
		public static List<Business> OwnedBusinesses = new List<Business>();

		// Token: 0x040028C8 RID: 10440
		[Header("Settings")]
		public float LaunderCapacity = 1000f;

		// Token: 0x040028C9 RID: 10441
		public List<LaunderingOperation> LaunderingOperations = new List<LaunderingOperation>();

		// Token: 0x040028CA RID: 10442
		public static Action<LaunderingOperation> onOperationStarted;

		// Token: 0x040028CB RID: 10443
		public static Action<LaunderingOperation> onOperationFinished;

		// Token: 0x040028CC RID: 10444
		private BusinessLoader loader = new BusinessLoader();

		// Token: 0x040028CD RID: 10445
		private bool dll_Excuted;

		// Token: 0x040028CE RID: 10446
		private bool dll_Excuted;
	}
}
