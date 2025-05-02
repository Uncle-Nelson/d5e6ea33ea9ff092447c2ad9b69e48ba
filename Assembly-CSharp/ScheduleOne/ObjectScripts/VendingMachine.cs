using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000B98 RID: 2968
	public class VendingMachine : NetworkBehaviour, IGUIDRegisterable, IGenericSaveable
	{
		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06004F4E RID: 20302 RVA: 0x0014EA68 File Offset: 0x0014CC68
		// (set) Token: 0x06004F4F RID: 20303 RVA: 0x0014EA70 File Offset: 0x0014CC70
		public bool IsBroken { get; protected set; }

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06004F50 RID: 20304 RVA: 0x0014EA79 File Offset: 0x0014CC79
		// (set) Token: 0x06004F51 RID: 20305 RVA: 0x0014EA81 File Offset: 0x0014CC81
		public int DaysUntilRepair { get; protected set; }

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06004F52 RID: 20306 RVA: 0x0014EA8A File Offset: 0x0014CC8A
		// (set) Token: 0x06004F53 RID: 20307 RVA: 0x0014EA92 File Offset: 0x0014CC92
		public ItemPickup lastDroppedItem { get; protected set; }

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06004F54 RID: 20308 RVA: 0x0014EA9B File Offset: 0x0014CC9B
		// (set) Token: 0x06004F55 RID: 20309 RVA: 0x0014EAA3 File Offset: 0x0014CCA3
		public Guid GUID { get; protected set; }

		// Token: 0x06004F56 RID: 20310 RVA: 0x0014EAAC File Offset: 0x0014CCAC
		[Button]
		public void RegenerateGUID()
		{
			this.BakedGUID = Guid.NewGuid().ToString();
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x0014EAD4 File Offset: 0x0014CCD4
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.VendingMachine_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x0014EAF4 File Offset: 0x0014CCF4
		private void Start()
		{
			TimeManager instance = NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.DayPass));
			NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.DayPass));
			this.SetLit(false);
			((IGenericSaveable)this).InitializeSaveable();
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x0014EB6A File Offset: 0x0014CD6A
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.IsBroken)
			{
				this.Break(connection);
			}
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x0014EB82 File Offset: 0x0014CD82
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x0014EB91 File Offset: 0x0014CD91
		private void OnDestroy()
		{
			if (VendingMachine.AllMachines.Contains(this))
			{
				VendingMachine.AllMachines.Remove(this);
			}
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.InstanceExists)
			{
				NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance._onSleepStart.RemoveListener(new UnityAction(this.DayPass));
			}
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x0014EBD0 File Offset: 0x0014CDD0
		private void MinPass()
		{
			if (NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(this.LitStartTime, this.LitOnEndTime) && !this.IsBroken)
			{
				if (!this.isLit)
				{
					this.SetLit(true);
					return;
				}
			}
			else if (this.isLit)
			{
				this.SetLit(false);
			}
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x0014EC1C File Offset: 0x0014CE1C
		public void DayPass()
		{
			if (this.IsBroken)
			{
				int daysUntilRepair = this.DaysUntilRepair;
				this.DaysUntilRepair = daysUntilRepair - 1;
				if (this.DaysUntilRepair <= 0)
				{
					this.Repair();
				}
			}
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x0014EC50 File Offset: 0x0014CE50
		public void Hovered()
		{
			if (this.purchaseInProgress)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			if (this.IsBroken)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			if (NetworkSingleton<MoneyManager>.Instance.cashBalance >= 2f)
			{
				this.IntObj.SetMessage("Purchase Cuke");
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.IntObj.SetMessage("Not enough cash");
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x0014ECD1 File Offset: 0x0014CED1
		public void Interacted()
		{
			if (this.purchaseInProgress)
			{
				return;
			}
			if (this.IsBroken)
			{
				return;
			}
			if (NetworkSingleton<MoneyManager>.Instance.cashBalance >= 2f)
			{
				this.LocalPurchase();
			}
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x0014ECFC File Offset: 0x0014CEFC
		private void LocalPurchase()
		{
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-2f, true, false);
			this.SendPurchase();
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x0014ED15 File Offset: 0x0014CF15
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPurchase()
		{
			this.RpcWriter___Server_SendPurchase_2166136261();
			this.RpcLogic___SendPurchase_2166136261();
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x0014ED23 File Offset: 0x0014CF23
		[ObserversRpc(RunLocally = true)]
		public void PurchaseRoutine()
		{
			this.RpcWriter___Observers_PurchaseRoutine_2166136261();
			this.RpcLogic___PurchaseRoutine_2166136261();
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x0014ED34 File Offset: 0x0014CF34
		[ServerRpc(RequireOwnership = false)]
		public void DropItem()
		{
			this.RpcWriter___Server_DropItem_2166136261();
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x0014ED47 File Offset: 0x0014CF47
		public void RemoveLastDropped()
		{
			if (this.lastDroppedItem != null && this.lastDroppedItem.gameObject != null)
			{
				this.lastDroppedItem.Destroy();
				this.lastDroppedItem = null;
			}
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x0014ED7C File Offset: 0x0014CF7C
		private void Impacted(Impact impact)
		{
			if (impact.ImpactForce < 50f)
			{
				return;
			}
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
				base.StartCoroutine(this.<Impacted>g__BreakRoutine|64_0());
				return;
			}
			if (Random.value < 0.33f && Time.time - this.timeOnLastFreeItem > 10f)
			{
				this.timeOnLastFreeItem = Time.time;
				base.StartCoroutine(this.<Impacted>g__Drop|64_1());
			}
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x0014EE44 File Offset: 0x0014D044
		private void SetLit(bool lit)
		{
			this.isLit = lit;
			if (this.isLit)
			{
				Material[] materials = this.DoorMesh.materials;
				materials[1] = this.DoorOnMat;
				this.DoorMesh.materials = materials;
				Material[] materials2 = this.BodyMesh.materials;
				materials2[1] = this.BodyOnMat;
				this.BodyMesh.materials = materials2;
			}
			else
			{
				Material[] materials3 = this.DoorMesh.materials;
				materials3[1] = this.DoorOffMat;
				this.DoorMesh.materials = materials3;
				Material[] materials4 = this.BodyMesh.materials;
				materials4[1] = this.BodyOffMat;
				this.BodyMesh.materials = materials4;
			}
			for (int i = 0; i < this.Lights.Length; i++)
			{
				this.Lights[i].Enabled = this.isLit;
			}
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x0014EF11 File Offset: 0x0014D111
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBreak()
		{
			this.RpcWriter___Server_SendBreak_2166136261();
			this.RpcLogic___SendBreak_2166136261();
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x0014EF1F File Offset: 0x0014D11F
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

		// Token: 0x06004F69 RID: 20329 RVA: 0x0014EF49 File Offset: 0x0014D149
		[ObserversRpc]
		private void Repair()
		{
			this.RpcWriter___Observers_Repair_2166136261();
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x0014EF54 File Offset: 0x0014D154
		[ServerRpc(RequireOwnership = false)]
		private void DropCash()
		{
			this.RpcWriter___Server_DropCash_2166136261();
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x0014EF67 File Offset: 0x0014D167
		public void Load(GenericSaveData data)
		{
			this.IsBroken = data.GetBool("broken", false);
			this.DaysUntilRepair = data.GetInt("daysUntilRepair", 0);
			if (this.IsBroken)
			{
				this.Break(null);
			}
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x0014EF9C File Offset: 0x0014D19C
		public GenericSaveData GetSaveData()
		{
			GenericSaveData genericSaveData = new GenericSaveData(this.GUID.ToString());
			genericSaveData.Add("broken", this.IsBroken);
			genericSaveData.Add("daysUntilRepair", this.DaysUntilRepair);
			return genericSaveData;
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x0014F019 File Offset: 0x0014D219
		[CompilerGenerated]
		private IEnumerator <PurchaseRoutine>g__Routine|61_0()
		{
			this.PaySound.Play();
			this.DispenseSound.Play();
			this.Anim.Play();
			yield return new WaitForSeconds(0.65f);
			if (base.IsServer)
			{
				this.DropItem();
			}
			this.purchaseInProgress = false;
			yield break;
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x0014F028 File Offset: 0x0014D228
		[CompilerGenerated]
		private IEnumerator <Impacted>g__BreakRoutine|64_0()
		{
			int cashDrop = Random.Range(1, 5);
			int num;
			for (int i = 0; i < cashDrop; i = num + 1)
			{
				this.DropCash();
				yield return new WaitForSeconds(0.25f);
				num = i;
			}
			yield break;
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x0014F037 File Offset: 0x0014D237
		[CompilerGenerated]
		private IEnumerator <Impacted>g__Drop|64_1()
		{
			this.DispenseSound.Play();
			yield return new WaitForSeconds(0.65f);
			this.DropItem();
			yield break;
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x0014F048 File Offset: 0x0014D248
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendPurchase_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_PurchaseRoutine_2166136261));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_DropItem_2166136261));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_SendBreak_2166136261));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_Break_328543758));
			base.RegisterTargetRpc(5U, new ClientRpcDelegate(this.RpcReader___Target_Break_328543758));
			base.RegisterObserversRpc(6U, new ClientRpcDelegate(this.RpcReader___Observers_Repair_2166136261));
			base.RegisterServerRpc(7U, new ServerRpcDelegate(this.RpcReader___Server_DropCash_2166136261));
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x0014F11E File Offset: 0x0014D31E
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x0014F131 File Offset: 0x0014D331
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x0014F140 File Offset: 0x0014D340
		private void RpcWriter___Server_SendPurchase_2166136261()
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

		// Token: 0x06004F76 RID: 20342 RVA: 0x0014F1DA File Offset: 0x0014D3DA
		public void RpcLogic___SendPurchase_2166136261()
		{
			this.PurchaseRoutine();
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x0014F1E4 File Offset: 0x0014D3E4
		private void RpcReader___Server_SendPurchase_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendPurchase_2166136261();
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x0014F214 File Offset: 0x0014D414
		private void RpcWriter___Observers_PurchaseRoutine_2166136261()
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

		// Token: 0x06004F79 RID: 20345 RVA: 0x0014F2BD File Offset: 0x0014D4BD
		public void RpcLogic___PurchaseRoutine_2166136261()
		{
			if (this.purchaseInProgress)
			{
				return;
			}
			this.purchaseInProgress = true;
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<PurchaseRoutine>g__Routine|61_0());
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x0014F2E0 File Offset: 0x0014D4E0
		private void RpcReader___Observers_PurchaseRoutine_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___PurchaseRoutine_2166136261();
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x0014F30C File Offset: 0x0014D50C
		private void RpcWriter___Server_DropItem_2166136261()
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

		// Token: 0x06004F7C RID: 20348 RVA: 0x0014F3A8 File Offset: 0x0014D5A8
		public void RpcLogic___DropItem_2166136261()
		{
			ItemPickup itemPickup = Object.Instantiate<ItemPickup>(this.CukePrefab, this.ItemSpawnPoint.position, this.ItemSpawnPoint.rotation);
			base.Spawn(itemPickup.gameObject, null, default(Scene));
			this.lastDroppedItem = itemPickup;
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x0014F3F4 File Offset: 0x0014D5F4
		private void RpcReader___Server_DropItem_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___DropItem_2166136261();
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x0014F414 File Offset: 0x0014D614
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
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x0014F4AE File Offset: 0x0014D6AE
		private void RpcLogic___SendBreak_2166136261()
		{
			this.DaysUntilRepair = 2;
			this.Break(null);
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x0014F4C0 File Offset: 0x0014D6C0
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

		// Token: 0x06004F81 RID: 20353 RVA: 0x0014F4F0 File Offset: 0x0014D6F0
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
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x0014F599 File Offset: 0x0014D799
		private void RpcLogic___Break_328543758(NetworkConnection conn)
		{
			if (this.IsBroken)
			{
				return;
			}
			this.IsBroken = true;
			this.SetLit(false);
			UnityEvent unityEvent = this.onBreak;
			if (unityEvent == null)
			{
				return;
			}
			unityEvent.Invoke();
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x0014F5C4 File Offset: 0x0014D7C4
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

		// Token: 0x06004F84 RID: 20356 RVA: 0x0014F5F0 File Offset: 0x0014D7F0
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
			base.SendTargetRpc(5U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x0014F698 File Offset: 0x0014D898
		private void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Break_328543758(base.LocalConnection);
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x0014F6C0 File Offset: 0x0014D8C0
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
			base.SendObserversRpc(6U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x0014F769 File Offset: 0x0014D969
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

		// Token: 0x06004F88 RID: 20360 RVA: 0x0014F78C File Offset: 0x0014D98C
		private void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Repair_2166136261();
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x0014F7AC File Offset: 0x0014D9AC
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
			base.SendServerRpc(7U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x0014F848 File Offset: 0x0014DA48
		private void RpcLogic___DropCash_2166136261()
		{
			GameObject gameObject = Object.Instantiate<GameObject>(this.CashPrefab.gameObject, this.CashSpawnPoint.position, this.CashSpawnPoint.rotation);
			gameObject.GetComponent<Rigidbody>().AddForce(this.CashSpawnPoint.forward * Random.Range(1.5f, 2.5f), 2);
			gameObject.GetComponent<Rigidbody>().AddTorque(Random.insideUnitSphere * 2f, 2);
			base.Spawn(gameObject.gameObject, null, default(Scene));
			this.PaySound.Play();
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x0014F8E4 File Offset: 0x0014DAE4
		private void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___DropCash_2166136261();
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x0014F904 File Offset: 0x0014DB04
		private void dll()
		{
			if (!VendingMachine.AllMachines.Contains(this))
			{
				VendingMachine.AllMachines.Add(this);
			}
			PhysicsDamageable damageable = this.Damageable;
			damageable.onImpacted = (Action<Impact>)Delegate.Combine(damageable.onImpacted, new Action<Impact>(this.Impacted));
			this.GUID = new Guid(this.BakedGUID);
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x04003BD8 RID: 15320
		public static List<VendingMachine> AllMachines = new List<VendingMachine>();

		// Token: 0x04003BD9 RID: 15321
		public const float COST = 2f;

		// Token: 0x04003BDA RID: 15322
		public const int REPAIR_TIME_DAYS = 2;

		// Token: 0x04003BDB RID: 15323
		public const float IMPACT_THRESHOLD_FREE_ITEM = 50f;

		// Token: 0x04003BDC RID: 15324
		public const float IMPACT_THRESHOLD_FREE_ITEM_CHANCE = 0.33f;

		// Token: 0x04003BDD RID: 15325
		public const float IMPACT_THRESHOLD_BREAK = 165f;

		// Token: 0x04003BDE RID: 15326
		public const int MIN_CASH_DROP = 1;

		// Token: 0x04003BDF RID: 15327
		public const int MAX_CASH_DROP = 4;

		// Token: 0x04003BE2 RID: 15330
		[Header("Settings")]
		public int LitStartTime = 1700;

		// Token: 0x04003BE3 RID: 15331
		public int LitOnEndTime = 800;

		// Token: 0x04003BE4 RID: 15332
		public ItemPickup CukePrefab;

		// Token: 0x04003BE5 RID: 15333
		public CashPickup CashPrefab;

		// Token: 0x04003BE6 RID: 15334
		[Header("References")]
		public MeshRenderer DoorMesh;

		// Token: 0x04003BE7 RID: 15335
		public MeshRenderer BodyMesh;

		// Token: 0x04003BE8 RID: 15336
		public Material DoorOffMat;

		// Token: 0x04003BE9 RID: 15337
		public Material DoorOnMat;

		// Token: 0x04003BEA RID: 15338
		public Material BodyOffMat;

		// Token: 0x04003BEB RID: 15339
		public Material BodyOnMat;

		// Token: 0x04003BEC RID: 15340
		public OptimizedLight[] Lights;

		// Token: 0x04003BED RID: 15341
		public AudioSourceController PaySound;

		// Token: 0x04003BEE RID: 15342
		public AudioSourceController DispenseSound;

		// Token: 0x04003BEF RID: 15343
		public Animation Anim;

		// Token: 0x04003BF0 RID: 15344
		public Transform ItemSpawnPoint;

		// Token: 0x04003BF1 RID: 15345
		public InteractableObject IntObj;

		// Token: 0x04003BF2 RID: 15346
		public Transform AccessPoint;

		// Token: 0x04003BF3 RID: 15347
		public PhysicsDamageable Damageable;

		// Token: 0x04003BF4 RID: 15348
		public Transform CashSpawnPoint;

		// Token: 0x04003BF5 RID: 15349
		public UnityEvent onBreak;

		// Token: 0x04003BF6 RID: 15350
		public UnityEvent onRepair;

		// Token: 0x04003BF8 RID: 15352
		private bool isLit;

		// Token: 0x04003BF9 RID: 15353
		private bool purchaseInProgress;

		// Token: 0x04003BFA RID: 15354
		private float timeOnLastFreeItem;

		// Token: 0x04003BFC RID: 15356
		[SerializeField]
		protected string BakedGUID = string.Empty;

		// Token: 0x04003BFD RID: 15357
		private bool dll_Excuted;

		// Token: 0x04003BFE RID: 15358
		private bool dll_Excuted;
	}
}
