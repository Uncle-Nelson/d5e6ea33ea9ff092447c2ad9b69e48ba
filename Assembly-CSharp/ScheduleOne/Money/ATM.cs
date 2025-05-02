using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using ScheduleOne.UI.ATM;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ScheduleOne.Money
{
	// Token: 0x02000B8A RID: 2954
	public class ATM : NetworkBehaviour, IGUIDRegisterable, IGenericSaveable
	{
		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06004E8D RID: 20109 RVA: 0x0014BB1A File Offset: 0x00149D1A
		// (set) Token: 0x06004E8E RID: 20110 RVA: 0x0014BB22 File Offset: 0x00149D22
		public bool IsBroken { get; protected set; }

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x0014BB2B File Offset: 0x00149D2B
		// (set) Token: 0x06004E90 RID: 20112 RVA: 0x0014BB33 File Offset: 0x00149D33
		public int DaysUntilRepair { get; protected set; }

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06004E91 RID: 20113 RVA: 0x0014BB3C File Offset: 0x00149D3C
		// (set) Token: 0x06004E92 RID: 20114 RVA: 0x0014BB44 File Offset: 0x00149D44
		public bool isInUse { get; protected set; }

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06004E93 RID: 20115 RVA: 0x0014BB4D File Offset: 0x00149D4D
		// (set) Token: 0x06004E94 RID: 20116 RVA: 0x0014BB55 File Offset: 0x00149D55
		public Guid GUID { get; protected set; }

		// Token: 0x06004E95 RID: 20117 RVA: 0x0014BB60 File Offset: 0x00149D60
		[Button]
		public void RegenerateGUID()
		{
			this.BakedGUID = Guid.NewGuid().ToString();
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x0014BB86 File Offset: 0x00149D86
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Money.ATM_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x0014BB9C File Offset: 0x00149D9C
		protected virtual void Start()
		{
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.DayPass));
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.DayPass));
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onWeekPass = (Action)Delegate.Combine(instance.onWeekPass, new Action(this.WeekPass));
			((IGenericSaveable)this).InitializeSaveable();
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x0014BC0B File Offset: 0x00149E0B
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.IsBroken)
			{
				this.Break(connection);
			}
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x0014BC23 File Offset: 0x00149E23
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x0014BC34 File Offset: 0x00149E34
		public void DayPass()
		{
			if (InstanceFinder.IsServer && this.IsBroken)
			{
				int daysUntilRepair = this.DaysUntilRepair;
				this.DaysUntilRepair = daysUntilRepair - 1;
				if (this.DaysUntilRepair <= 0)
				{
					this.Repair();
				}
			}
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x0014BC6F File Offset: 0x00149E6F
		public void WeekPass()
		{
			ATM.WeeklyDepositSum = 0f;
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x0014BC7B File Offset: 0x00149E7B
		public void Hovered()
		{
			if (this.isInUse || this.IsBroken)
			{
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			this.intObj.SetMessage("Use ATM");
			this.intObj.SetInteractableState(InteractableObject.EInteractableState.Default);
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x0014BCB6 File Offset: 0x00149EB6
		public void Interacted()
		{
			if (this.isInUse || this.IsBroken)
			{
				return;
			}
			this.Enter();
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x0014BCD0 File Offset: 0x00149ED0
		public void Enter()
		{
			this.isInUse = true;
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, ATM.viewLerpTime);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.camPos.position, this.camPos.rotation, ATM.viewLerpTime, false);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			this.interfaceATM.SetIsOpen(true);
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x0014BD50 File Offset: 0x00149F50
		public void Exit()
		{
			this.isInUse = false;
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(ATM.viewLerpTime);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(ATM.viewLerpTime, true, true);
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x0014BDA4 File Offset: 0x00149FA4
		private void Impacted(Impact impact)
		{
			if (this.IsBroken)
			{
				return;
			}
			if (impact.ImpactForce >= 165f)
			{
				this.SendBreak();
				if (impact.ImpactSource == Player.Local.NetworkObject)
				{
					Player.Local.VisualState.ApplyState("vandalism", PlayerVisualState.EVisualState.Vandalizing, 0f);
					Player.Local.VisualState.RemoveState("vandalism", 2f);
				}
				base.StartCoroutine(this.<Impacted>g__BreakRoutine|45_0());
			}
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x0014BE24 File Offset: 0x0014A024
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBreak()
		{
			this.RpcWriter___Server_SendBreak_2166136261();
			this.RpcLogic___SendBreak_2166136261();
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x0014BE32 File Offset: 0x0014A032
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void Break(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_Break_328543758(conn);
				this.RpcLogic___Break_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_Break_328543758(conn);
			}
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x0014BE5C File Offset: 0x0014A05C
		[ObserversRpc]
		private void Repair()
		{
			this.RpcWriter___Observers_Repair_2166136261();
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x0014BE64 File Offset: 0x0014A064
		[ServerRpc(RequireOwnership = false)]
		private void DropCash()
		{
			this.RpcWriter___Server_DropCash_2166136261();
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x0014BE77 File Offset: 0x0014A077
		public void Load(GenericSaveData data)
		{
			this.IsBroken = data.GetBool("broken", false);
			this.DaysUntilRepair = data.GetInt("daysUntilRepair", 0);
			if (this.IsBroken)
			{
				this.Break(null);
			}
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x0014BEAC File Offset: 0x0014A0AC
		public GenericSaveData GetSaveData()
		{
			GenericSaveData genericSaveData = new GenericSaveData(this.GUID.ToString());
			genericSaveData.Add("broken", this.IsBroken);
			genericSaveData.Add("daysUntilRepair", this.DaysUntilRepair);
			return genericSaveData;
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x0014BF1D File Offset: 0x0014A11D
		[CompilerGenerated]
		private IEnumerator <Impacted>g__BreakRoutine|45_0()
		{
			int cashDrop = Random.Range(2, 9);
			int num;
			for (int i = 0; i < cashDrop; i = num + 1)
			{
				this.DropCash();
				yield return new WaitForSeconds(0.2f);
				num = i;
			}
			yield break;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x0014BF2C File Offset: 0x0014A12C
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendBreak_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_Break_328543758));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_Break_328543758));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_Repair_2166136261));
			base.RegisterServerRpc(4U, new ServerRpcDelegate(this.RpcReader___Server_DropCash_2166136261));
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x0014BFBD File Offset: 0x0014A1BD
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x0014BFD0 File Offset: 0x0014A1D0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x0014BFE0 File Offset: 0x0014A1E0
		private void RpcWriter___Server_SendBreak_2166136261()
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
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x0014C07A File Offset: 0x0014A27A
		private void RpcLogic___SendBreak_2166136261()
		{
			this.DaysUntilRepair = 2;
			this.Break(null);
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x0014C08C File Offset: 0x0014A28C
		private void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendBreak_2166136261();
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x0014C0BC File Offset: 0x0014A2BC
		private void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
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
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x0014C165 File Offset: 0x0014A365
		private void RpcLogic___Break_328543758(NetworkConnection conn)
		{
			if (this.IsBroken)
			{
				return;
			}
			this.IsBroken = true;
			UnityEvent unityEvent = this.onBreak;
			if (unityEvent == null)
			{
				return;
			}
			unityEvent.Invoke();
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x0014C188 File Offset: 0x0014A388
		private void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___Break_328543758(null);
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x0014C1B4 File Offset: 0x0014A3B4
		private void RpcWriter___Target_Break_328543758(NetworkConnection conn)
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
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x0014C25C File Offset: 0x0014A45C
		private void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Break_328543758(base.LocalConnection);
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x0014C284 File Offset: 0x0014A484
		private void RpcWriter___Observers_Repair_2166136261()
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
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x0014C32D File Offset: 0x0014A52D
		private void RpcLogic___Repair_2166136261()
		{
			if (!this.IsBroken)
			{
				return;
			}
			this.IsBroken = false;
			UnityEvent unityEvent = this.onRepair;
			if (unityEvent == null)
			{
				return;
			}
			unityEvent.Invoke();
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x0014C350 File Offset: 0x0014A550
		private void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Repair_2166136261();
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x0014C370 File Offset: 0x0014A570
		private void RpcWriter___Server_DropCash_2166136261()
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
			base.SendServerRpc(4U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x0014C40C File Offset: 0x0014A60C
		private void RpcLogic___DropCash_2166136261()
		{
			GameObject gameObject = Object.Instantiate<GameObject>(this.CashPrefab.gameObject, this.CashSpawnPoint.position, this.CashSpawnPoint.rotation);
			gameObject.GetComponent<Rigidbody>().AddForce(this.CashSpawnPoint.forward * Random.Range(1.5f, 2.5f), 2);
			gameObject.GetComponent<Rigidbody>().AddTorque(Random.insideUnitSphere * 2f, 2);
			base.Spawn(gameObject.gameObject, null, default(Scene));
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x0014C49C File Offset: 0x0014A69C
		private void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___DropCash_2166136261();
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x0014C4BC File Offset: 0x0014A6BC
		private void dll()
		{
			PhysicsDamageable damageable = this.Damageable;
			damageable.onImpacted = (Action<Impact>)Delegate.Combine(damageable.onImpacted, new Action<Impact>(this.Impacted));
			this.GUID = new Guid(this.BakedGUID);
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x04003B5A RID: 15194
		public const bool DepositLimitEnabled = true;

		// Token: 0x04003B5B RID: 15195
		public const float WEEKLY_DEPOSIT_LIMIT = 10000f;

		// Token: 0x04003B5C RID: 15196
		public const float IMPACT_THRESHOLD_BREAK = 165f;

		// Token: 0x04003B5D RID: 15197
		public const int REPAIR_TIME_DAYS = 2;

		// Token: 0x04003B5E RID: 15198
		public const int MIN_CASH_DROP = 2;

		// Token: 0x04003B5F RID: 15199
		public const int MAX_CASH_DROP = 8;

		// Token: 0x04003B60 RID: 15200
		public static float WeeklyDepositSum = 0f;

		// Token: 0x04003B63 RID: 15203
		public CashPickup CashPrefab;

		// Token: 0x04003B64 RID: 15204
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x04003B65 RID: 15205
		[SerializeField]
		protected Transform camPos;

		// Token: 0x04003B66 RID: 15206
		[SerializeField]
		protected ATMInterface interfaceATM;

		// Token: 0x04003B67 RID: 15207
		public Transform AccessPoint;

		// Token: 0x04003B68 RID: 15208
		public Transform CashSpawnPoint;

		// Token: 0x04003B69 RID: 15209
		public PhysicsDamageable Damageable;

		// Token: 0x04003B6A RID: 15210
		[Header("Settings")]
		public static float viewLerpTime = 0.15f;

		// Token: 0x04003B6D RID: 15213
		[SerializeField]
		protected string BakedGUID = string.Empty;

		// Token: 0x04003B6E RID: 15214
		public UnityEvent onBreak;

		// Token: 0x04003B6F RID: 15215
		public UnityEvent onRepair;

		// Token: 0x04003B70 RID: 15216
		private bool dll_Excuted;

		// Token: 0x04003B71 RID: 15217
		private bool dll_Excuted;
	}
}
