using System;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Doors;
using ScheduleOne.GameTime;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Map
{
	// Token: 0x02000C14 RID: 3092
	public class DarkMarket : NetworkSingleton<DarkMarket>
	{
		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060056DB RID: 22235 RVA: 0x0016D4E2 File Offset: 0x0016B6E2
		// (set) Token: 0x060056DC RID: 22236 RVA: 0x0016D4EA File Offset: 0x0016B6EA
		public bool IsOpen { get; protected set; } = true;

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060056DD RID: 22237 RVA: 0x0016D4F3 File Offset: 0x0016B6F3
		// (set) Token: 0x060056DE RID: 22238 RVA: 0x0016D4FB File Offset: 0x0016B6FB
		public bool Unlocked { get; protected set; }

		// Token: 0x060056DF RID: 22239 RVA: 0x0016D504 File Offset: 0x0016B704
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onLoadComplete.AddListener(new UnityAction(this.OnLoad));
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x0016D527 File Offset: 0x0016B727
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.Unlocked)
			{
				this.SetUnlocked(connection);
			}
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x0016D53F File Offset: 0x0016B73F
		private void Update()
		{
			this.IsOpen = this.ShouldBeOpen();
		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x0016D550 File Offset: 0x0016B750
		private bool ShouldBeOpen()
		{
			if (!NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(this.AccessZone.OpenTime, this.AccessZone.CloseTime))
			{
				return false;
			}
			for (int i = 0; i < Player.PlayerList.Count; i++)
			{
				if (Player.PlayerList[i].CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x0016D5B0 File Offset: 0x0016B7B0
		private void OnLoad()
		{
			Singleton<LoadManager>.Instance.onLoadComplete.RemoveListener(new UnityAction(this.OnLoad));
			if (NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>("WarehouseUnlocked"))
			{
				this.SendUnlocked();
				return;
			}
			this.MainDoor.SetKnockingEnabled(true);
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x0016D5FC File Offset: 0x0016B7FC
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendUnlocked()
		{
			this.RpcWriter___Server_SendUnlocked_2166136261();
			this.RpcLogic___SendUnlocked_2166136261();
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x0016D60C File Offset: 0x0016B80C
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetUnlocked(NetworkConnection conn)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetUnlocked_328543758(conn);
				this.RpcLogic___SetUnlocked_328543758(conn);
			}
			else
			{
				this.RpcWriter___Target_SetUnlocked_328543758(conn);
			}
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x0016D650 File Offset: 0x0016B850
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendUnlocked_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetUnlocked_328543758));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_SetUnlocked_328543758));
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x0016D6B9 File Offset: 0x0016B8B9
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x0016D6D2 File Offset: 0x0016B8D2
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x0016D6E0 File Offset: 0x0016B8E0
		private void RpcWriter___Server_SendUnlocked_2166136261()
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

		// Token: 0x060056EB RID: 22251 RVA: 0x0016D77A File Offset: 0x0016B97A
		public void RpcLogic___SendUnlocked_2166136261()
		{
			this.SetUnlocked(null);
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x0016D784 File Offset: 0x0016B984
		private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendUnlocked_2166136261();
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x0016D7B4 File Offset: 0x0016B9B4
		private void RpcWriter___Observers_SetUnlocked_328543758(NetworkConnection conn)
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

		// Token: 0x060056EE RID: 22254 RVA: 0x0016D860 File Offset: 0x0016BA60
		private void RpcLogic___SetUnlocked_328543758(NetworkConnection conn)
		{
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("WarehouseUnlocked", true.ToString(), true);
			this.MainDoor.SetKnockingEnabled(false);
			this.MainDoor.Igor.gameObject.SetActive(false);
			this.Unlocked = true;
			this.Oscar.EnableDeliveries();
			DoorController[] doors = this.AccessZone.Doors;
			for (int i = 0; i < doors.Length; i++)
			{
				doors[i].noAccessErrorMessage = "Only open after 6PM";
			}
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x0016D8E4 File Offset: 0x0016BAE4
		private void RpcReader___Observers_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetUnlocked_328543758(null);
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x0016D910 File Offset: 0x0016BB10
		private void RpcWriter___Target_SetUnlocked_328543758(NetworkConnection conn)
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

		// Token: 0x060056F1 RID: 22257 RVA: 0x0016D9B8 File Offset: 0x0016BBB8
		private void RpcReader___Target_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetUnlocked_328543758(base.LocalConnection);
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x0016D9DE File Offset: 0x0016BBDE
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04004042 RID: 16450
		public DarkMarketAccessZone AccessZone;

		// Token: 0x04004043 RID: 16451
		public DarkMarketMainDoor MainDoor;

		// Token: 0x04004044 RID: 16452
		public Oscar Oscar;

		// Token: 0x04004045 RID: 16453
		public FullRank UnlockRank;

		// Token: 0x04004046 RID: 16454
		private bool dll_Excuted;

		// Token: 0x04004047 RID: 16455
		private bool dll_Excuted;
	}
}
