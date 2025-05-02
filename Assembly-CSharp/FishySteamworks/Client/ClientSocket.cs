using System;
using System.Diagnostics;
using System.Threading;
using FishNet.Transporting;
using Steamworks;
using UnityEngine;

namespace FishySteamworks.Client
{
	// Token: 0x02000C45 RID: 3141
	public class ClientSocket : CommonSocket
	{
		// Token: 0x0600582A RID: 22570 RVA: 0x00171A28 File Offset: 0x0016FC28
		private void CheckTimeout()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			do
			{
				if ((float)(stopwatch.ElapsedMilliseconds / 1000L) > this._connectTimeout)
				{
					this.StopConnection();
				}
				Thread.Sleep(50);
			}
			while (base.GetLocalConnectionState() == LocalConnectionState.Starting);
			stopwatch.Stop();
			this._timeoutThread.Abort();
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x00171A80 File Offset: 0x0016FC80
		internal bool StartConnection(string address, ushort port, bool peerToPeer)
		{
			try
			{
				if (this._onLocalConnectionStateCallback == null)
				{
					this._onLocalConnectionStateCallback = Callback<SteamNetConnectionStatusChangedCallback_t>.Create(new Callback<SteamNetConnectionStatusChangedCallback_t>.DispatchDelegate(this.OnLocalConnectionState));
				}
				this.PeerToPeer = peerToPeer;
				byte[] array = (!peerToPeer) ? base.GetIPBytes(address) : null;
				if (!peerToPeer && array == null)
				{
					base.SetLocalConnectionState(LocalConnectionState.Stopped, false);
					return false;
				}
				base.SetLocalConnectionState(LocalConnectionState.Starting, false);
				this._connectTimeout = Time.unscaledTime + 8000f;
				this._timeoutThread = new Thread(new ThreadStart(this.CheckTimeout));
				this._timeoutThread.Start();
				this._hostSteamID = new CSteamID(ulong.Parse(address));
				SteamNetworkingIdentity steamNetworkingIdentity = default(SteamNetworkingIdentity);
				steamNetworkingIdentity.SetSteamID(this._hostSteamID);
				SteamNetworkingConfigValue_t[] array2 = new SteamNetworkingConfigValue_t[0];
				if (this.PeerToPeer)
				{
					this._socket = SteamNetworkingSockets.ConnectP2P(ref steamNetworkingIdentity, 0, array2.Length, array2);
				}
				else
				{
					SteamNetworkingIPAddr steamNetworkingIPAddr = default(SteamNetworkingIPAddr);
					steamNetworkingIPAddr.Clear();
					steamNetworkingIPAddr.SetIPv6(array, port);
					this._socket = SteamNetworkingSockets.ConnectByIPAddress(ref steamNetworkingIPAddr, 0, array2);
				}
			}
			catch
			{
				base.SetLocalConnectionState(LocalConnectionState.Stopped, false);
				return false;
			}
			return true;
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x00171BA4 File Offset: 0x0016FDA4
		private void OnLocalConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
			if (args.m_info.m_eState == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_Connected)
			{
				base.SetLocalConnectionState(LocalConnectionState.Started, false);
				return;
			}
			if (args.m_info.m_eState == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ClosedByPeer || args.m_info.m_eState == ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_ProblemDetectedLocally)
			{
				this.Transport.NetworkManager.Log("Connection was closed by peer, " + args.m_info.m_szEndDebug);
				this.StopConnection();
				return;
			}
			this.Transport.NetworkManager.Log("Connection state changed: " + args.m_info.m_eState.ToString() + " - " + args.m_info.m_szEndDebug);
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x00171C54 File Offset: 0x0016FE54
		internal bool StopConnection()
		{
			if (this._timeoutThread != null && this._timeoutThread.IsAlive)
			{
				this._timeoutThread.Abort();
			}
			if (this._socket != HSteamNetConnection.Invalid)
			{
				if (this._onLocalConnectionStateCallback != null)
				{
					this._onLocalConnectionStateCallback.Dispose();
					this._onLocalConnectionStateCallback = null;
				}
				SteamNetworkingSockets.CloseConnection(this._socket, 0, string.Empty, false);
				this._socket = HSteamNetConnection.Invalid;
			}
			if (base.GetLocalConnectionState() == LocalConnectionState.Stopped || base.GetLocalConnectionState() == LocalConnectionState.Stopping)
			{
				return false;
			}
			base.SetLocalConnectionState(LocalConnectionState.Stopping, false);
			base.SetLocalConnectionState(LocalConnectionState.Stopped, false);
			return true;
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x00171CF0 File Offset: 0x0016FEF0
		internal void IterateIncoming()
		{
			if (base.GetLocalConnectionState() != LocalConnectionState.Started)
			{
				return;
			}
			int num = SteamNetworkingSockets.ReceiveMessagesOnConnection(this._socket, this.MessagePointers, 256);
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					ArraySegment<byte> data;
					byte channel;
					base.GetMessage(this.MessagePointers[i], this.InboundBuffer, out data, out channel);
					this.Transport.HandleClientReceivedDataArgs(new ClientReceivedDataArgs(data, (Channel)channel, this.Transport.Index));
				}
			}
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x00171D64 File Offset: 0x0016FF64
		internal void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			if (base.GetLocalConnectionState() != LocalConnectionState.Started)
			{
				return;
			}
			EResult eresult = base.Send(this._socket, segment, channelId);
			if (eresult == EResult.k_EResultNoConnection || eresult == EResult.k_EResultInvalidParam)
			{
				this.Transport.NetworkManager.Log("Connection to server was lost.");
				this.StopConnection();
				return;
			}
			if (eresult != EResult.k_EResultOK)
			{
				this.Transport.NetworkManager.LogError("Could not send: " + eresult.ToString());
			}
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x00171DDA File Offset: 0x0016FFDA
		internal void IterateOutgoing()
		{
			if (base.GetLocalConnectionState() != LocalConnectionState.Started)
			{
				return;
			}
			SteamNetworkingSockets.FlushMessagesOnConnection(this._socket);
		}

		// Token: 0x04004142 RID: 16706
		private Callback<SteamNetConnectionStatusChangedCallback_t> _onLocalConnectionStateCallback;

		// Token: 0x04004143 RID: 16707
		private CSteamID _hostSteamID = CSteamID.Nil;

		// Token: 0x04004144 RID: 16708
		private HSteamNetConnection _socket;

		// Token: 0x04004145 RID: 16709
		private Thread _timeoutThread;

		// Token: 0x04004146 RID: 16710
		private float _connectTimeout = -1f;

		// Token: 0x04004147 RID: 16711
		private const float CONNECT_TIMEOUT_DURATION = 8000f;
	}
}
