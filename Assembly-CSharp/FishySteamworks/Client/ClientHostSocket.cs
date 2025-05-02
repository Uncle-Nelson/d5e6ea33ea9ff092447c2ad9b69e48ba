using System;
using System.Collections.Generic;
using FishNet.Transporting;
using FishNet.Utility.Performance;
using FishySteamworks.Server;

namespace FishySteamworks.Client
{
	// Token: 0x02000C44 RID: 3140
	public class ClientHostSocket : CommonSocket
	{
		// Token: 0x06005822 RID: 22562 RVA: 0x0017189A File Offset: 0x0016FA9A
		internal void CheckSetStarted()
		{
			if (this._server != null && base.GetLocalConnectionState() == LocalConnectionState.Starting && this._server.GetLocalConnectionState() == LocalConnectionState.Started)
			{
				this.SetLocalConnectionState(LocalConnectionState.Started, false);
			}
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x001718C3 File Offset: 0x0016FAC3
		internal bool StartConnection(ServerSocket serverSocket)
		{
			this._server = serverSocket;
			this._server.SetClientHostSocket(this);
			if (this._server.GetLocalConnectionState() != LocalConnectionState.Started)
			{
				return false;
			}
			this.SetLocalConnectionState(LocalConnectionState.Starting, false);
			return true;
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x001718F1 File Offset: 0x0016FAF1
		protected override void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
			base.SetLocalConnectionState(connectionState, server);
			if (connectionState == LocalConnectionState.Started)
			{
				this._server.OnClientHostState(true);
				return;
			}
			this._server.OnClientHostState(false);
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x00171918 File Offset: 0x0016FB18
		internal bool StopConnection()
		{
			if (base.GetLocalConnectionState() == LocalConnectionState.Stopped || base.GetLocalConnectionState() == LocalConnectionState.Stopping)
			{
				return false;
			}
			base.ClearQueue(this._incoming);
			this.SetLocalConnectionState(LocalConnectionState.Stopping, false);
			this.SetLocalConnectionState(LocalConnectionState.Stopped, false);
			this._server.SetClientHostSocket(null);
			return true;
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x00171958 File Offset: 0x0016FB58
		internal void IterateIncoming()
		{
			if (base.GetLocalConnectionState() != LocalConnectionState.Started)
			{
				return;
			}
			while (this._incoming.Count > 0)
			{
				LocalPacket localPacket = this._incoming.Dequeue();
				ArraySegment<byte> data = new ArraySegment<byte>(localPacket.Data, 0, localPacket.Length);
				this.Transport.HandleClientReceivedDataArgs(new ClientReceivedDataArgs(data, (Channel)localPacket.Channel, this.Transport.Index));
				ByteArrayPool.Store(localPacket.Data);
			}
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x001719CA File Offset: 0x0016FBCA
		internal void ReceivedFromLocalServer(LocalPacket packet)
		{
			this._incoming.Enqueue(packet);
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x001719D8 File Offset: 0x0016FBD8
		internal void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			if (base.GetLocalConnectionState() != LocalConnectionState.Started)
			{
				return;
			}
			if (this._server.GetLocalConnectionState() != LocalConnectionState.Started)
			{
				return;
			}
			LocalPacket packet = new LocalPacket(segment, channelId);
			this._server.ReceivedFromClientHost(packet);
		}

		// Token: 0x04004140 RID: 16704
		private ServerSocket _server;

		// Token: 0x04004141 RID: 16705
		private Queue<LocalPacket> _incoming = new Queue<LocalPacket>();
	}
}
