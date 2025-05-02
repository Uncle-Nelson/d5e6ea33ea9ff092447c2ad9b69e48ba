using System;
using FishNet.Managing;
using FishNet.Transporting;
using FishySteamworks.Client;
using FishySteamworks.Server;
using Steamworks;
using UnityEngine;

namespace FishySteamworks
{
	// Token: 0x02000C41 RID: 3137
	public class FishySteamworks : Transport
	{
		// Token: 0x060057DE RID: 22494 RVA: 0x0017077C File Offset: 0x0016E97C
		~FishySteamworks()
		{
			this.Shutdown();
		}

		// Token: 0x060057DF RID: 22495 RVA: 0x001707A8 File Offset: 0x0016E9A8
		public override void Initialize(NetworkManager networkManager, int transportIndex)
		{
			base.Initialize(networkManager, transportIndex);
			this._client = new ClientSocket();
			this._clientHost = new ClientHostSocket();
			this._server = new ServerSocket();
			this.CreateChannelData();
			this._client.Initialize(this);
			this._clientHost.Initialize(this);
			this._server.Initialize(this);
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x00170808 File Offset: 0x0016EA08
		private void OnDestroy()
		{
			this.Shutdown();
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x00170810 File Offset: 0x0016EA10
		private void Update()
		{
			this._clientHost.CheckSetStarted();
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x0017081D File Offset: 0x0016EA1D
		private void CreateChannelData()
		{
			this._mtus = new int[]
			{
				1048576,
				1200
			};
		}

		// Token: 0x060057E3 RID: 22499 RVA: 0x0017083C File Offset: 0x0016EA3C
		private bool InitializeRelayNetworkAccess()
		{
			bool result;
			try
			{
				SteamNetworkingUtils.InitRelayNetworkAccess();
				if (this.IsNetworkAccessAvailable())
				{
					this.LocalUserSteamID = SteamUser.GetSteamID().m_SteamID;
				}
				this._shutdownCalled = false;
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060057E4 RID: 22500 RVA: 0x00170888 File Offset: 0x0016EA88
		public bool IsNetworkAccessAvailable()
		{
			bool result;
			try
			{
				InteropHelp.TestIfAvailableClient();
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060057E5 RID: 22501 RVA: 0x001708B4 File Offset: 0x0016EAB4
		public override string GetConnectionAddress(int connectionId)
		{
			return this._server.GetConnectionAddress(connectionId);
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060057E6 RID: 22502 RVA: 0x001708C4 File Offset: 0x0016EAC4
		// (remove) Token: 0x060057E7 RID: 22503 RVA: 0x001708FC File Offset: 0x0016EAFC
		public override event Action<ClientConnectionStateArgs> OnClientConnectionState;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060057E8 RID: 22504 RVA: 0x00170934 File Offset: 0x0016EB34
		// (remove) Token: 0x060057E9 RID: 22505 RVA: 0x0017096C File Offset: 0x0016EB6C
		public override event Action<ServerConnectionStateArgs> OnServerConnectionState;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060057EA RID: 22506 RVA: 0x001709A4 File Offset: 0x0016EBA4
		// (remove) Token: 0x060057EB RID: 22507 RVA: 0x001709DC File Offset: 0x0016EBDC
		public override event Action<RemoteConnectionStateArgs> OnRemoteConnectionState;

		// Token: 0x060057EC RID: 22508 RVA: 0x00170A11 File Offset: 0x0016EC11
		public override LocalConnectionState GetConnectionState(bool server)
		{
			if (server)
			{
				return this._server.GetLocalConnectionState();
			}
			return this._client.GetLocalConnectionState();
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00170A2D File Offset: 0x0016EC2D
		public override RemoteConnectionState GetConnectionState(int connectionId)
		{
			return this._server.GetConnectionState(connectionId);
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x00170A3B File Offset: 0x0016EC3B
		public override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs)
		{
			Action<ClientConnectionStateArgs> onClientConnectionState = this.OnClientConnectionState;
			if (onClientConnectionState == null)
			{
				return;
			}
			onClientConnectionState(connectionStateArgs);
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x00170A4E File Offset: 0x0016EC4E
		public override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs)
		{
			Action<ServerConnectionStateArgs> onServerConnectionState = this.OnServerConnectionState;
			if (onServerConnectionState == null)
			{
				return;
			}
			onServerConnectionState(connectionStateArgs);
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x00170A61 File Offset: 0x0016EC61
		public override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs)
		{
			Action<RemoteConnectionStateArgs> onRemoteConnectionState = this.OnRemoteConnectionState;
			if (onRemoteConnectionState == null)
			{
				return;
			}
			onRemoteConnectionState(connectionStateArgs);
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x00170A74 File Offset: 0x0016EC74
		public override void IterateIncoming(bool server)
		{
			if (server)
			{
				this._server.IterateIncoming();
				return;
			}
			this._client.IterateIncoming();
			this._clientHost.IterateIncoming();
		}

		// Token: 0x060057F2 RID: 22514 RVA: 0x00170A9B File Offset: 0x0016EC9B
		public override void IterateOutgoing(bool server)
		{
			if (server)
			{
				this._server.IterateOutgoing();
				return;
			}
			this._client.IterateOutgoing();
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060057F3 RID: 22515 RVA: 0x00170AB8 File Offset: 0x0016ECB8
		// (remove) Token: 0x060057F4 RID: 22516 RVA: 0x00170AF0 File Offset: 0x0016ECF0
		public override event Action<ClientReceivedDataArgs> OnClientReceivedData;

		// Token: 0x060057F5 RID: 22517 RVA: 0x00170B25 File Offset: 0x0016ED25
		public override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs)
		{
			Action<ClientReceivedDataArgs> onClientReceivedData = this.OnClientReceivedData;
			if (onClientReceivedData == null)
			{
				return;
			}
			onClientReceivedData(receivedDataArgs);
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060057F6 RID: 22518 RVA: 0x00170B38 File Offset: 0x0016ED38
		// (remove) Token: 0x060057F7 RID: 22519 RVA: 0x00170B70 File Offset: 0x0016ED70
		public override event Action<ServerReceivedDataArgs> OnServerReceivedData;

		// Token: 0x060057F8 RID: 22520 RVA: 0x00170BA5 File Offset: 0x0016EDA5
		public override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs)
		{
			Action<ServerReceivedDataArgs> onServerReceivedData = this.OnServerReceivedData;
			if (onServerReceivedData == null)
			{
				return;
			}
			onServerReceivedData(receivedDataArgs);
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x00170BB8 File Offset: 0x0016EDB8
		public override void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			this._client.SendToServer(channelId, segment);
			this._clientHost.SendToServer(channelId, segment);
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x00170BD4 File Offset: 0x0016EDD4
		public override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
			this._server.SendToClient(channelId, segment, connectionId);
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x00170BE4 File Offset: 0x0016EDE4
		public override int GetMaximumClients()
		{
			return this._server.GetMaximumClients();
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x00170BF1 File Offset: 0x0016EDF1
		public override void SetMaximumClients(int value)
		{
			this._server.SetMaximumClients(value);
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x00170BFF File Offset: 0x0016EDFF
		public override void SetClientAddress(string address)
		{
			this._clientAddress = address;
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x00170C08 File Offset: 0x0016EE08
		public override void SetServerBindAddress(string address, IPAddressType addressType)
		{
			this._serverBindAddress = address;
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00170C11 File Offset: 0x0016EE11
		public override void SetPort(ushort port)
		{
			this._port = port;
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x00170C1A File Offset: 0x0016EE1A
		public override bool StartConnection(bool server)
		{
			if (server)
			{
				return this.StartServer();
			}
			return this.StartClient(this._clientAddress);
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x00170C32 File Offset: 0x0016EE32
		public override bool StopConnection(bool server)
		{
			if (server)
			{
				return this.StopServer();
			}
			return this.StopClient();
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x00170C44 File Offset: 0x0016EE44
		public override bool StopConnection(int connectionId, bool immediately)
		{
			return this.StopClient(connectionId, immediately);
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x00170C4E File Offset: 0x0016EE4E
		public override void Shutdown()
		{
			if (this._shutdownCalled)
			{
				return;
			}
			this._shutdownCalled = true;
			this.StopConnection(false);
			this.StopConnection(true);
		}

		// Token: 0x06005804 RID: 22532 RVA: 0x00170C70 File Offset: 0x0016EE70
		private bool StartServer()
		{
			if (!this.InitializeRelayNetworkAccess())
			{
				base.NetworkManager.LogError("RelayNetworkAccess could not be initialized.");
				return false;
			}
			if (!this.IsNetworkAccessAvailable())
			{
				base.NetworkManager.LogError("Server network access is not available.");
				return false;
			}
			this._server.ResetInvalidSocket();
			if (this._server.GetLocalConnectionState() != LocalConnectionState.Stopped)
			{
				base.NetworkManager.LogError("Server is already running.");
				return false;
			}
			bool flag = this._client.GetLocalConnectionState() > LocalConnectionState.Stopped;
			if (flag)
			{
				this._client.StopConnection();
			}
			bool flag2 = this._server.StartConnection(this._serverBindAddress, this._port, (int)this._maximumClients, this._peerToPeer);
			if (flag2 && flag)
			{
				this.StartConnection(false);
			}
			return flag2;
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x00170D29 File Offset: 0x0016EF29
		private bool StopServer()
		{
			return this._server != null && this._server.StopConnection();
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x00170D40 File Offset: 0x0016EF40
		private bool StartClient(string address)
		{
			if (this._server.GetLocalConnectionState() == LocalConnectionState.Stopped)
			{
				if (this._client.GetLocalConnectionState() != LocalConnectionState.Stopped)
				{
					base.NetworkManager.LogError("Client is already running.");
					return false;
				}
				if (this._clientHost.GetLocalConnectionState() != LocalConnectionState.Stopped)
				{
					this._clientHost.StopConnection();
				}
				if (!this.InitializeRelayNetworkAccess())
				{
					base.NetworkManager.LogError("RelayNetworkAccess could not be initialized.");
					return false;
				}
				if (!this.IsNetworkAccessAvailable())
				{
					base.NetworkManager.LogError("Client network access is not available.");
					return false;
				}
				this._client.StartConnection(address, this._port, this._peerToPeer);
			}
			else
			{
				this._clientHost.StartConnection(this._server);
			}
			return true;
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x00170DF8 File Offset: 0x0016EFF8
		private bool StopClient()
		{
			bool flag = false;
			if (this._client != null)
			{
				flag |= this._client.StopConnection();
			}
			if (this._clientHost != null)
			{
				flag |= this._clientHost.StopConnection();
			}
			return flag;
		}

		// Token: 0x06005808 RID: 22536 RVA: 0x00170E34 File Offset: 0x0016F034
		private bool StopClient(int connectionId, bool immediately)
		{
			return this._server.StopConnection(connectionId);
		}

		// Token: 0x06005809 RID: 22537 RVA: 0x00170E42 File Offset: 0x0016F042
		public override int GetMTU(byte channel)
		{
			if ((int)channel >= this._mtus.Length)
			{
				Debug.LogError(string.Format("Channel {0} is out of bounds.", channel));
				return 0;
			}
			return this._mtus[(int)channel];
		}

		// Token: 0x04004120 RID: 16672
		[NonSerialized]
		public ulong LocalUserSteamID;

		// Token: 0x04004121 RID: 16673
		[Tooltip("Address server should bind to.")]
		[SerializeField]
		private string _serverBindAddress = string.Empty;

		// Token: 0x04004122 RID: 16674
		[Tooltip("Port to use.")]
		[SerializeField]
		private ushort _port = 7770;

		// Token: 0x04004123 RID: 16675
		[Tooltip("Maximum number of players which may be connected at once.")]
		[Range(1f, 65535f)]
		[SerializeField]
		private ushort _maximumClients = 9001;

		// Token: 0x04004124 RID: 16676
		[Tooltip("True if using peer to peer socket.")]
		[SerializeField]
		private bool _peerToPeer;

		// Token: 0x04004125 RID: 16677
		[Tooltip("Address client should connect to.")]
		[SerializeField]
		private string _clientAddress = string.Empty;

		// Token: 0x04004126 RID: 16678
		private int[] _mtus;

		// Token: 0x04004127 RID: 16679
		private ClientSocket _client;

		// Token: 0x04004128 RID: 16680
		private ClientHostSocket _clientHost;

		// Token: 0x04004129 RID: 16681
		private ServerSocket _server;

		// Token: 0x0400412A RID: 16682
		private bool _shutdownCalled = true;

		// Token: 0x0400412B RID: 16683
		internal const int CLIENT_HOST_ID = 32767;
	}
}
