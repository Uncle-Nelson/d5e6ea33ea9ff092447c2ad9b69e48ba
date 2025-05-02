using System;
using System.Linq;
using System.Text;
using EasyButtons;
using FishNet.Managing;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.UI;
using ScheduleOne.UI.MainMenu;
using Steamworks;
using UnityEngine;

namespace ScheduleOne.Networking
{
	// Token: 0x0200053D RID: 1341
	public class Lobby : PersistentSingleton<Lobby>
	{
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000863F7 File Offset: 0x000845F7
		public bool IsHost
		{
			get
			{
				return !this.IsInLobby || (this.Players.Length != 0 && this.Players[0] == this.LocalPlayerID);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x00086425 File Offset: 0x00084625
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x0008642D File Offset: 0x0008462D
		public ulong LobbyID { get; private set; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x00086436 File Offset: 0x00084636
		public CSteamID LobbySteamID
		{
			get
			{
				return new CSteamID(this.LobbyID);
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x00086443 File Offset: 0x00084643
		public bool IsInLobby
		{
			get
			{
				return this.LobbyID > 0UL;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x0008644F File Offset: 0x0008464F
		public int PlayerCount
		{
			get
			{
				if (!this.IsInLobby)
				{
					return 1;
				}
				return this.Players.Count((CSteamID p) => p != CSteamID.Nil);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x00086485 File Offset: 0x00084685
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x0008648D File Offset: 0x0008468D
		public CSteamID LocalPlayerID { get; private set; } = CSteamID.Nil;

		// Token: 0x060020B0 RID: 8368 RVA: 0x00086496 File Offset: 0x00084696
		protected override void Awake()
		{
			base.Awake();
			if (Singleton<Lobby>.Instance == null || Singleton<Lobby>.Instance != this)
			{
				return;
			}
			bool destroyed = this.Destroyed;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000864C0 File Offset: 0x000846C0
		protected override void Start()
		{
			base.Start();
			if (Singleton<Lobby>.Instance == null || Singleton<Lobby>.Instance != this)
			{
				return;
			}
			if (this.Destroyed)
			{
				return;
			}
			if (!SteamManager.Initialized)
			{
				Debug.LogError("Steamworks not initialized");
				return;
			}
			this.LocalPlayerID = SteamUser.GetSteamID();
			this.InitializeCallbacks();
			string launchLobby = this.GetLaunchLobby();
			if (launchLobby != null && launchLobby != string.Empty && SteamManager.Initialized)
			{
				try
				{
					SteamMatchmaking.JoinLobby(new CSteamID(ulong.Parse(launchLobby)));
				}
				catch
				{
					Console.LogWarning("There is an issue with launch commands.", null);
				}
			}
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0008656C File Offset: 0x0008476C
		private void InitializeCallbacks()
		{
			this.LobbyCreatedCallback = Callback<LobbyCreated_t>.Create(new Callback<LobbyCreated_t>.DispatchDelegate(this.OnLobbyCreated));
			this.LobbyEnteredCallback = Callback<LobbyEnter_t>.Create(new Callback<LobbyEnter_t>.DispatchDelegate(this.OnLobbyEntered));
			this.ChatUpdateCallback = Callback<LobbyChatUpdate_t>.Create(new Callback<LobbyChatUpdate_t>.DispatchDelegate(this.PlayerEnterOrLeave));
			this.GameLobbyJoinRequestedCallback = Callback<GameLobbyJoinRequested_t>.Create(new Callback<GameLobbyJoinRequested_t>.DispatchDelegate(this.LobbyJoinRequested));
			this.LobbyChatMessageCallback = Callback<LobbyChatMsg_t>.Create(new Callback<LobbyChatMsg_t>.DispatchDelegate(this.OnLobbyChatMessage));
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x000865EC File Offset: 0x000847EC
		public void TryOpenInviteInterface()
		{
			if (!this.IsInLobby)
			{
				Console.Log("Not currently in a lobby, creating one...", null);
				this.CreateLobby();
			}
			if (SteamMatchmaking.GetNumLobbyMembers(this.LobbySteamID) >= 4)
			{
				Debug.LogWarning("Lobby already at max capacity!");
				return;
			}
			SteamFriends.ActivateGameOverlayInviteDialog(this.LobbySteamID);
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0008662C File Offset: 0x0008482C
		public void LeaveLobby()
		{
			if (this.IsInLobby)
			{
				SteamMatchmaking.LeaveLobby(this.LobbySteamID);
				Console.Log("Leaving lobby: " + this.LobbyID.ToString(), null);
			}
			this.LobbyID = 0UL;
			this.UpdateLobbyMembers();
			if (this.onLobbyChange != null)
			{
				this.onLobbyChange();
			}
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x0008668B File Offset: 0x0008488B
		private void CreateLobby()
		{
			SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeFriendsOnly, 4);
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00086698 File Offset: 0x00084898
		private string GetLaunchLobby()
		{
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			for (int i = 0; i < commandLineArgs.Length; i++)
			{
				if (commandLineArgs[i].ToLower() == "+connect_lobby" && commandLineArgs.Length > i + 1)
				{
					return commandLineArgs[i + 1];
				}
			}
			return string.Empty;
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x000866E0 File Offset: 0x000848E0
		private void UpdateLobbyMembers()
		{
			for (int i = 0; i < this.Players.Length; i++)
			{
				this.Players[i] = CSteamID.Nil;
			}
			int num = this.IsInLobby ? SteamMatchmaking.GetNumLobbyMembers(this.LobbySteamID) : 0;
			for (int j = 0; j < num; j++)
			{
				this.Players[j] = SteamMatchmaking.GetLobbyMemberByIndex(this.LobbySteamID, j);
			}
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0008674C File Offset: 0x0008494C
		[Button]
		public void DebugJoin()
		{
			this.JoinAsClient(this.DebugSteamId64);
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x0008675A File Offset: 0x0008495A
		public void JoinAsClient(string steamId64)
		{
			Singleton<LoadManager>.Instance.LoadAsClient(steamId64);
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00086768 File Offset: 0x00084968
		public void SendLobbyMessage(string message)
		{
			if (!this.IsInLobby)
			{
				Console.LogWarning("Not in a lobby, cannot send message.", null);
				return;
			}
			byte[] bytes = Encoding.ASCII.GetBytes(message);
			SteamMatchmaking.SendLobbyChatMsg(this.LobbySteamID, bytes, bytes.Length);
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x000867A5 File Offset: 0x000849A5
		public void SetLobbyData(string key, string value)
		{
			if (!this.IsInLobby)
			{
				Console.LogWarning("Not in a lobby, cannot set data.", null);
				return;
			}
			SteamMatchmaking.SetLobbyData(this.LobbySteamID, key, value);
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x000867CC File Offset: 0x000849CC
		private void OnLobbyCreated(LobbyCreated_t result)
		{
			if (result.m_eResult == EResult.k_EResultOK)
			{
				Console.Log("Lobby created: " + result.m_ulSteamIDLobby.ToString(), null);
			}
			else
			{
				Console.LogWarning("Lobby creation failed: " + result.m_eResult.ToString(), null);
			}
			this.LobbyID = result.m_ulSteamIDLobby;
			SteamMatchmaking.SetLobbyData((CSteamID)result.m_ulSteamIDLobby, "owner", SteamUser.GetSteamID().ToString());
			SteamMatchmaking.SetLobbyData((CSteamID)result.m_ulSteamIDLobby, "version", Application.version);
			SteamMatchmaking.SetLobbyData((CSteamID)result.m_ulSteamIDLobby, "host_loading", "false");
			SteamMatchmaking.SetLobbyData((CSteamID)result.m_ulSteamIDLobby, "ready", "false");
			this.UpdateLobbyMembers();
			if (this.onLobbyChange != null)
			{
				this.onLobbyChange();
			}
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x000868C4 File Offset: 0x00084AC4
		private void OnLobbyEntered(LobbyEnter_t result)
		{
			string lobbyData = SteamMatchmaking.GetLobbyData(new CSteamID(result.m_ulSteamIDLobby), "version");
			Console.Log("Lobby version: " + lobbyData + ", client version: " + Application.version, null);
			if (lobbyData != Application.version)
			{
				Console.LogWarning("Lobby version mismatch, cannot join.", null);
				if (Singleton<MainMenuPopup>.InstanceExists)
				{
					Singleton<MainMenuPopup>.Instance.Open("Version Mismatch", "Host version: " + lobbyData + "\nYour version: " + Application.version, true);
				}
				this.LeaveLobby();
				return;
			}
			Console.Log("Entered lobby: " + result.m_ulSteamIDLobby.ToString(), null);
			this.LobbyID = result.m_ulSteamIDLobby;
			this.UpdateLobbyMembers();
			if (this.onLobbyChange != null)
			{
				this.onLobbyChange();
			}
			string lobbyData2 = SteamMatchmaking.GetLobbyData(this.LobbySteamID, "ready");
			bool flag = SteamMatchmaking.GetLobbyData(this.LobbySteamID, "load_tutorial") == "true";
			bool flag2 = SteamMatchmaking.GetLobbyData(this.LobbySteamID, "host_loading") == "true";
			if (lobbyData2 == "true" && !this.IsHost)
			{
				this.JoinAsClient(SteamMatchmaking.GetLobbyOwner(this.LobbySteamID).m_SteamID.ToString());
				return;
			}
			if (flag && !this.IsHost)
			{
				Singleton<LoadManager>.Instance.LoadTutorialAsClient();
				return;
			}
			if (flag2 && !this.IsHost)
			{
				Singleton<LoadManager>.Instance.SetWaitingForHostLoad();
				Singleton<LoadingScreen>.Instance.Open(false);
			}
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00086A40 File Offset: 0x00084C40
		private void PlayerEnterOrLeave(LobbyChatUpdate_t result)
		{
			Console.Log("Player join/leave: " + SteamFriends.GetFriendPersonaName(new CSteamID(result.m_ulSteamIDUserChanged)), null);
			this.UpdateLobbyMembers();
			if (result.m_ulSteamIDMakingChange == this.LobbySteamID.m_SteamID && result.m_ulSteamIDUserChanged != this.LocalPlayerID.m_SteamID)
			{
				Console.Log("Lobby owner left, leaving lobby.", null);
				this.LeaveLobby();
			}
			if (this.onLobbyChange != null)
			{
				this.onLobbyChange();
			}
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00086AC0 File Offset: 0x00084CC0
		private void LobbyJoinRequested(GameLobbyJoinRequested_t result)
		{
			string str = "Join requested: ";
			CSteamID steamIDLobby = result.m_steamIDLobby;
			Console.Log(str + steamIDLobby.ToString(), null);
			if (this.LobbyID != 0UL)
			{
				this.LeaveLobby();
			}
			SteamMatchmaking.JoinLobby(result.m_steamIDLobby);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00086B0C File Offset: 0x00084D0C
		private void OnLobbyChatMessage(LobbyChatMsg_t result)
		{
			byte[] array = new byte[128];
			int cubData = 128;
			CSteamID csteamID;
			EChatEntryType echatEntryType;
			SteamMatchmaking.GetLobbyChatEntry(new CSteamID(this.LobbyID), (int)result.m_iChatID, out csteamID, array, cubData, out echatEntryType);
			string text = Encoding.ASCII.GetString(array);
			text = text.TrimEnd(new char[1]);
			Console.Log("Lobby chat message received: " + text, null);
			if (!this.IsHost && !Singleton<LoadManager>.Instance.IsGameLoaded)
			{
				if (text == "ready")
				{
					this.JoinAsClient(csteamID.m_SteamID.ToString());
					return;
				}
				if (text == "load_tutorial")
				{
					Singleton<LoadManager>.Instance.LoadTutorialAsClient();
					return;
				}
				if (text == "host_loading")
				{
					Singleton<LoadManager>.Instance.SetWaitingForHostLoad();
					Singleton<LoadingScreen>.Instance.Open(false);
				}
			}
		}

		// Token: 0x0400193D RID: 6461
		public const bool ENABLED = true;

		// Token: 0x0400193E RID: 6462
		public const int PLAYER_LIMIT = 4;

		// Token: 0x0400193F RID: 6463
		public const string JOIN_READY = "ready";

		// Token: 0x04001940 RID: 6464
		public const string LOAD_TUTORIAL = "load_tutorial";

		// Token: 0x04001941 RID: 6465
		public const string HOST_LOADING = "host_loading";

		// Token: 0x04001942 RID: 6466
		public NetworkManager NetworkManager;

		// Token: 0x04001945 RID: 6469
		public CSteamID[] Players = new CSteamID[4];

		// Token: 0x04001946 RID: 6470
		public Action onLobbyChange;

		// Token: 0x04001947 RID: 6471
		private Callback<LobbyCreated_t> LobbyCreatedCallback;

		// Token: 0x04001948 RID: 6472
		private Callback<LobbyEnter_t> LobbyEnteredCallback;

		// Token: 0x04001949 RID: 6473
		private Callback<LobbyChatUpdate_t> ChatUpdateCallback;

		// Token: 0x0400194A RID: 6474
		private Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback;

		// Token: 0x0400194B RID: 6475
		private Callback<LobbyChatMsg_t> LobbyChatMessageCallback;

		// Token: 0x0400194C RID: 6476
		public string DebugSteamId64 = string.Empty;
	}
}
