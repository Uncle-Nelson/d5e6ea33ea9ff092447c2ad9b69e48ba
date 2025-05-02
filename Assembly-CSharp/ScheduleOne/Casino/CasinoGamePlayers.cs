using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using FluffyUnderware.DevTools.Extensions;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x0200075E RID: 1886
	public class CasinoGamePlayers : NetworkBehaviour
	{
		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600332B RID: 13099 RVA: 0x000D52E9 File Offset: 0x000D34E9
		public int CurrentPlayerCount
		{
			get
			{
				return this.Players.Count((Player p) => p != null);
			}
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x000D5315 File Offset: 0x000D3515
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Casino.CasinoGamePlayers_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x000D532C File Offset: 0x000D352C
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (this.CurrentPlayerCount > 0)
			{
				this.SetPlayerList(connection, this.GetPlayerObjects());
				foreach (Player player in this.Players)
				{
					if (!(player == null) && this.playerScores[player] != 0)
					{
						this.SetPlayerScore(connection, player.NetworkObject, this.playerScores[player]);
					}
				}
			}
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x000D539F File Offset: 0x000D359F
		public void AddPlayer(Player player)
		{
			this.RequestAddPlayer(player.NetworkObject);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x000D53AD File Offset: 0x000D35AD
		public void RemovePlayer(Player player)
		{
			this.RequestRemovePlayer(player.NetworkObject);
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x000D53BB File Offset: 0x000D35BB
		public void SetPlayerScore(Player player, int score)
		{
			this.RequestSetScore(player.NetworkObject, score);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x000D53CA File Offset: 0x000D35CA
		public int GetPlayerScore(Player player)
		{
			if (player == null)
			{
				return 0;
			}
			if (this.playerScores.ContainsKey(player))
			{
				return this.playerScores[player];
			}
			return 0;
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x000D53F3 File Offset: 0x000D35F3
		public Player GetPlayer(int index)
		{
			if (index < this.Players.Length)
			{
				return this.Players[index];
			}
			return null;
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x000D540A File Offset: 0x000D360A
		public int GetPlayerIndex(Player player)
		{
			return ArrayExt.IndexOf<Player>(this.Players, player);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x000D5418 File Offset: 0x000D3618
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestAddPlayer(NetworkObject playerObject)
		{
			this.RpcWriter___Server_RequestAddPlayer_3323014238(playerObject);
			this.RpcLogic___RequestAddPlayer_3323014238(playerObject);
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x000D543C File Offset: 0x000D363C
		private void AddPlayerToArray(Player player)
		{
			for (int i = 0; i < this.PlayerLimit; i++)
			{
				if (this.Players[i] == null)
				{
					this.Players[i] = player;
					return;
				}
			}
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x000D5474 File Offset: 0x000D3674
		[ServerRpc(RequireOwnership = false)]
		private void RequestRemovePlayer(NetworkObject playerObject)
		{
			this.RpcWriter___Server_RequestRemovePlayer_3323014238(playerObject);
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x000D548C File Offset: 0x000D368C
		private void RemovePlayerFromArray(Player player)
		{
			for (int i = 0; i < this.PlayerLimit; i++)
			{
				if (this.Players[i] == player)
				{
					this.Players[i] = null;
					return;
				}
			}
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x000D54C4 File Offset: 0x000D36C4
		[ServerRpc(RequireOwnership = false)]
		private void RequestSetScore(NetworkObject playerObject, int score)
		{
			this.RpcWriter___Server_RequestSetScore_4172557123(playerObject, score);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x000D54D4 File Offset: 0x000D36D4
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetPlayerScore(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetPlayerScore_1865307316(conn, playerObject, score);
				this.RpcLogic___SetPlayerScore_1865307316(conn, playerObject, score);
			}
			else
			{
				this.RpcWriter___Target_SetPlayerScore_1865307316(conn, playerObject, score);
			}
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x000D5524 File Offset: 0x000D3724
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetPlayerList(NetworkConnection conn, NetworkObject[] playerObjects)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetPlayerList_204172449(conn, playerObjects);
				this.RpcLogic___SetPlayerList_204172449(conn, playerObjects);
			}
			else
			{
				this.RpcWriter___Target_SetPlayerList_204172449(conn, playerObjects);
			}
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x000D5565 File Offset: 0x000D3765
		public CasinoGamePlayerData GetPlayerData()
		{
			return this.GetPlayerData(Player.Local);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x000D5572 File Offset: 0x000D3772
		public CasinoGamePlayerData GetPlayerData(Player player)
		{
			if (!this.playerDatas.ContainsKey(player))
			{
				this.playerDatas.Add(player, new CasinoGamePlayerData(this, player));
			}
			return this.playerDatas[player];
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x000D55A1 File Offset: 0x000D37A1
		public CasinoGamePlayerData GetPlayerData(int index)
		{
			if (index < this.Players.Length && this.Players[index] != null)
			{
				return this.GetPlayerData(this.Players[index]);
			}
			return null;
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x000D55CE File Offset: 0x000D37CE
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerBool(NetworkObject playerObject, string key, bool value)
		{
			this.RpcWriter___Server_SendPlayerBool_77262511(playerObject, key, value);
			this.RpcLogic___SendPlayerBool_77262511(playerObject, key, value);
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x000D55F4 File Offset: 0x000D37F4
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerBool(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ReceivePlayerBool_1748594478(conn, playerObject, key, value);
				this.RpcLogic___ReceivePlayerBool_1748594478(conn, playerObject, key, value);
			}
			else
			{
				this.RpcWriter___Target_ReceivePlayerBool_1748594478(conn, playerObject, key, value);
			}
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x000D564D File Offset: 0x000D384D
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerFloat(NetworkObject playerObject, string key, float value)
		{
			this.RpcWriter___Server_SendPlayerFloat_2931762093(playerObject, key, value);
			this.RpcLogic___SendPlayerFloat_2931762093(playerObject, key, value);
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x000D5674 File Offset: 0x000D3874
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerFloat(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ReceivePlayerFloat_2317689966(conn, playerObject, key, value);
				this.RpcLogic___ReceivePlayerFloat_2317689966(conn, playerObject, key, value);
			}
			else
			{
				this.RpcWriter___Target_ReceivePlayerFloat_2317689966(conn, playerObject, key, value);
			}
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x000D56D0 File Offset: 0x000D38D0
		private NetworkObject[] GetPlayerObjects()
		{
			NetworkObject[] array = new NetworkObject[this.PlayerLimit];
			for (int i = 0; i < this.PlayerLimit; i++)
			{
				if (this.Players[i] != null)
				{
					array[i] = this.Players[i].NetworkObject;
				}
			}
			return array;
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x000D5740 File Offset: 0x000D3940
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_RequestAddPlayer_3323014238));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_RequestRemovePlayer_3323014238));
			base.RegisterServerRpc(2U, new ServerRpcDelegate(this.RpcReader___Server_RequestSetScore_4172557123));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_SetPlayerScore_1865307316));
			base.RegisterTargetRpc(4U, new ClientRpcDelegate(this.RpcReader___Target_SetPlayerScore_1865307316));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_SetPlayerList_204172449));
			base.RegisterTargetRpc(6U, new ClientRpcDelegate(this.RpcReader___Target_SetPlayerList_204172449));
			base.RegisterServerRpc(7U, new ServerRpcDelegate(this.RpcReader___Server_SendPlayerBool_77262511));
			base.RegisterObserversRpc(8U, new ClientRpcDelegate(this.RpcReader___Observers_ReceivePlayerBool_1748594478));
			base.RegisterTargetRpc(9U, new ClientRpcDelegate(this.RpcReader___Target_ReceivePlayerBool_1748594478));
			base.RegisterServerRpc(10U, new ServerRpcDelegate(this.RpcReader___Server_SendPlayerFloat_2931762093));
			base.RegisterObserversRpc(11U, new ClientRpcDelegate(this.RpcReader___Observers_ReceivePlayerFloat_2317689966));
			base.RegisterTargetRpc(12U, new ClientRpcDelegate(this.RpcReader___Target_ReceivePlayerFloat_2317689966));
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x000D5889 File Offset: 0x000D3A89
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x000D589C File Offset: 0x000D3A9C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x000D58AC File Offset: 0x000D3AAC
		private void RpcWriter___Server_RequestAddPlayer_3323014238(NetworkObject playerObject)
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
			writer.WriteNetworkObject(playerObject);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000D5954 File Offset: 0x000D3B54
		private void RpcLogic___RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
			Player component = playerObject.GetComponent<Player>();
			if (component != null && !this.Players.Contains(component))
			{
				this.AddPlayerToArray(component);
				if (!this.playerScores.ContainsKey(component))
				{
					this.playerScores.Add(component, 0);
				}
				if (!this.playerDatas.ContainsKey(component))
				{
					this.playerDatas.Add(component, new CasinoGamePlayerData(this, component));
				}
			}
			this.SetPlayerList(null, this.GetPlayerObjects());
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x000D59D0 File Offset: 0x000D3BD0
		private void RpcReader___Server_RequestAddPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___RequestAddPlayer_3323014238(playerObject);
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x000D5A10 File Offset: 0x000D3C10
		private void RpcWriter___Server_RequestRemovePlayer_3323014238(NetworkObject playerObject)
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
			writer.WriteNetworkObject(playerObject);
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x000D5AB8 File Offset: 0x000D3CB8
		private void RpcLogic___RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
			Player component = playerObject.GetComponent<Player>();
			if (component != null && this.Players.Contains(component))
			{
				this.RemovePlayerFromArray(component);
			}
			this.SetPlayerList(null, this.GetPlayerObjects());
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x000D5AF8 File Offset: 0x000D3CF8
		private void RpcReader___Server_RequestRemovePlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___RequestRemovePlayer_3323014238(playerObject);
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x000D5B2C File Offset: 0x000D3D2C
		private void RpcWriter___Server_RequestSetScore_4172557123(NetworkObject playerObject, int score)
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
			writer.WriteNetworkObject(playerObject);
			writer.WriteInt32(score, AutoPackType.Packed);
			base.SendServerRpc(2U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x000D5BE5 File Offset: 0x000D3DE5
		private void RpcLogic___RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
			this.SetPlayerScore(null, playerObject, score);
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x000D5BF0 File Offset: 0x000D3DF0
		private void RpcReader___Server_RequestSetScore_4172557123(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			int score = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___RequestSetScore_4172557123(playerObject, score);
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x000D5C38 File Offset: 0x000D3E38
		private void RpcWriter___Observers_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
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
			writer.WriteNetworkObject(playerObject);
			writer.WriteInt32(score, AutoPackType.Packed);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x000D5D00 File Offset: 0x000D3F00
		private void RpcLogic___SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			Player component = playerObject.GetComponent<Player>();
			if (component == null)
			{
				return;
			}
			if (!this.playerScores.ContainsKey(component))
			{
				this.playerScores.Add(component, score);
			}
			else
			{
				this.playerScores[component] = score;
			}
			if (this.onPlayerScoresChanged != null)
			{
				this.onPlayerScoresChanged.Invoke();
			}
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x000D5D5C File Offset: 0x000D3F5C
		private void RpcReader___Observers_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			int score = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetPlayerScore_1865307316(null, playerObject, score);
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x000D5DB0 File Offset: 0x000D3FB0
		private void RpcWriter___Target_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
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
			writer.WriteNetworkObject(playerObject);
			writer.WriteInt32(score, AutoPackType.Packed);
			base.SendTargetRpc(4U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000D5E78 File Offset: 0x000D4078
		private void RpcReader___Target_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			int score = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetPlayerScore_1865307316(base.LocalConnection, playerObject, score);
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x000D5EC8 File Offset: 0x000D40C8
		private void RpcWriter___Observers_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
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
			writer.Write___FishNet.Object.NetworkObject[]FishNet.Serializing.Generated(playerObjects);
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x000D5F80 File Offset: 0x000D4180
		private void RpcLogic___SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
			this.Players = new Player[this.PlayerLimit];
			for (int i = 0; i < this.PlayerLimit; i++)
			{
				this.Players[i] = null;
			}
			for (int j = 0; j < playerObjects.Length; j++)
			{
				if (!(playerObjects[j] == null))
				{
					Player component = playerObjects[j].GetComponent<Player>();
					if (component != null)
					{
						this.Players[j] = component;
						if (!this.playerScores.ContainsKey(component))
						{
							this.playerScores.Add(component, 0);
						}
						if (!this.playerDatas.ContainsKey(component))
						{
							this.playerDatas.Add(component, new CasinoGamePlayerData(this, component));
						}
					}
				}
			}
			if (this.onPlayerListChanged != null)
			{
				this.onPlayerListChanged.Invoke();
			}
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x000D603C File Offset: 0x000D423C
		private void RpcReader___Observers_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject[] playerObjects = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___FishNet.Object.NetworkObject[]FishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetPlayerList_204172449(null, playerObjects);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000D6078 File Offset: 0x000D4278
		private void RpcWriter___Target_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
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
			writer.Write___FishNet.Object.NetworkObject[]FishNet.Serializing.Generated(playerObjects);
			base.SendTargetRpc(6U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000D6130 File Offset: 0x000D4330
		private void RpcReader___Target_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject[] playerObjects = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___FishNet.Object.NetworkObject[]FishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetPlayerList_204172449(base.LocalConnection, playerObjects);
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x000D6168 File Offset: 0x000D4368
		private void RpcWriter___Server_SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
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
			writer.WriteNetworkObject(playerObject);
			writer.WriteString(key);
			writer.WriteBoolean(value);
			base.SendServerRpc(7U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x000D6229 File Offset: 0x000D4429
		public void RpcLogic___SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
			this.ReceivePlayerBool(null, playerObject, key, value);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x000D6238 File Offset: 0x000D4438
		private void RpcReader___Server_SendPlayerBool_77262511(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			string key = PooledReader0.ReadString();
			bool value = PooledReader0.ReadBoolean();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendPlayerBool_77262511(playerObject, key, value);
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x000D6298 File Offset: 0x000D4498
		private void RpcWriter___Observers_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
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
			writer.WriteNetworkObject(playerObject);
			writer.WriteString(key);
			writer.WriteBoolean(value);
			base.SendObserversRpc(8U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x000D6368 File Offset: 0x000D4568
		private void RpcLogic___ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			Player component = playerObject.GetComponent<Player>();
			if (component == null)
			{
				return;
			}
			if (!this.playerDatas.ContainsKey(component))
			{
				this.playerDatas.Add(component, new CasinoGamePlayerData(this, component));
			}
			this.playerDatas[component].SetData<bool>(key, value, false);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x000D63BC File Offset: 0x000D45BC
		private void RpcReader___Observers_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			string key = PooledReader0.ReadString();
			bool value = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceivePlayerBool_1748594478(null, playerObject, key, value);
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x000D641C File Offset: 0x000D461C
		private void RpcWriter___Target_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
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
			writer.WriteNetworkObject(playerObject);
			writer.WriteString(key);
			writer.WriteBoolean(value);
			base.SendTargetRpc(9U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000D64EC File Offset: 0x000D46EC
		private void RpcReader___Target_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			string key = PooledReader0.ReadString();
			bool value = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceivePlayerBool_1748594478(base.LocalConnection, playerObject, key, value);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x000D6548 File Offset: 0x000D4748
		private void RpcWriter___Server_SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
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
			writer.WriteNetworkObject(playerObject);
			writer.WriteString(key);
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendServerRpc(10U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x000D660E File Offset: 0x000D480E
		public void RpcLogic___SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
			this.ReceivePlayerFloat(null, playerObject, key, value);
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x000D661C File Offset: 0x000D481C
		private void RpcReader___Server_SendPlayerFloat_2931762093(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			string key = PooledReader0.ReadString();
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendPlayerFloat_2931762093(playerObject, key, value);
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x000D6684 File Offset: 0x000D4884
		private void RpcWriter___Observers_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
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
			writer.WriteNetworkObject(playerObject);
			writer.WriteString(key);
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendObserversRpc(11U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000D675C File Offset: 0x000D495C
		private void RpcLogic___ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			Player component = playerObject.GetComponent<Player>();
			if (component == null)
			{
				return;
			}
			if (!this.playerDatas.ContainsKey(component))
			{
				this.playerDatas.Add(component, new CasinoGamePlayerData(this, component));
			}
			this.playerDatas[component].SetData<float>(key, value, false);
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x000D67B0 File Offset: 0x000D49B0
		private void RpcReader___Observers_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			string key = PooledReader0.ReadString();
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceivePlayerFloat_2317689966(null, playerObject, key, value);
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x000D6814 File Offset: 0x000D4A14
		private void RpcWriter___Target_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
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
			writer.WriteNetworkObject(playerObject);
			writer.WriteString(key);
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendTargetRpc(12U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x000D68E8 File Offset: 0x000D4AE8
		private void RpcReader___Target_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject playerObject = PooledReader0.ReadNetworkObject();
			string key = PooledReader0.ReadString();
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceivePlayerFloat_2317689966(base.LocalConnection, playerObject, key, value);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x000D6946 File Offset: 0x000D4B46
		private void dll()
		{
			this.Players = new Player[this.PlayerLimit];
		}

		// Token: 0x0400248A RID: 9354
		public int PlayerLimit = 4;

		// Token: 0x0400248B RID: 9355
		private Player[] Players;

		// Token: 0x0400248C RID: 9356
		public UnityEvent onPlayerListChanged;

		// Token: 0x0400248D RID: 9357
		public UnityEvent onPlayerScoresChanged;

		// Token: 0x0400248E RID: 9358
		private Dictionary<Player, int> playerScores = new Dictionary<Player, int>();

		// Token: 0x0400248F RID: 9359
		private Dictionary<Player, CasinoGamePlayerData> playerDatas = new Dictionary<Player, CasinoGamePlayerData>();

		// Token: 0x04002490 RID: 9360
		private bool dll_Excuted;

		// Token: 0x04002491 RID: 9361
		private bool dll_Excuted;
	}
}
