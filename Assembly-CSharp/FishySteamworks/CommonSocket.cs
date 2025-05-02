using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using FishNet.Transporting;
using FishNet.Utility.Performance;
using Steamworks;

namespace FishySteamworks
{
	// Token: 0x02000C3F RID: 3135
	public abstract class CommonSocket
	{
		// Token: 0x060057D4 RID: 22484 RVA: 0x001704A7 File Offset: 0x0016E6A7
		internal LocalConnectionState GetLocalConnectionState()
		{
			return this._connectionState;
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x001704B0 File Offset: 0x0016E6B0
		protected virtual void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
			if (connectionState == this._connectionState)
			{
				return;
			}
			this._connectionState = connectionState;
			if (server)
			{
				this.Transport.HandleServerConnectionState(new ServerConnectionStateArgs(connectionState, this.Transport.Index));
				return;
			}
			this.Transport.HandleClientConnectionState(new ClientConnectionStateArgs(connectionState, this.Transport.Index));
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x0017050C File Offset: 0x0016E70C
		internal virtual void Initialize(Transport t)
		{
			this.Transport = t;
			int num = this.Transport.GetMTU(0);
			num = Math.Max(num, this.Transport.GetMTU(1));
			this.InboundBuffer = new byte[num];
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x0017054C File Offset: 0x0016E74C
		protected byte[] GetIPBytes(string address)
		{
			if (string.IsNullOrEmpty(address))
			{
				return null;
			}
			IPAddress ipaddress;
			if (!IPAddress.TryParse(address, out ipaddress))
			{
				this.Transport.NetworkManager.LogError("Could not parse address " + address + " to IPAddress.");
				return null;
			}
			return ipaddress.GetAddressBytes();
		}

		// Token: 0x060057D8 RID: 22488 RVA: 0x00170598 File Offset: 0x0016E798
		protected EResult Send(HSteamNetConnection steamConnection, ArraySegment<byte> segment, byte channelId)
		{
			if (segment.Array.Length - 1 <= segment.Offset + segment.Count)
			{
				byte[] array = segment.Array;
				Array.Resize<byte>(ref array, array.Length + 1);
				array[array.Length - 1] = channelId;
			}
			else
			{
				segment.Array[segment.Offset + segment.Count] = channelId;
			}
			segment = new ArraySegment<byte>(segment.Array, segment.Offset, segment.Count + 1);
			GCHandle gchandle = GCHandle.Alloc(segment.Array, GCHandleType.Pinned);
			IntPtr pData = gchandle.AddrOfPinnedObject() + segment.Offset;
			int nSendFlags = (channelId == 1) ? 0 : 8;
			long num;
			EResult eresult = SteamNetworkingSockets.SendMessageToConnection(steamConnection, pData, (uint)segment.Count, nSendFlags, out num);
			if (eresult != EResult.k_EResultOK)
			{
				this.Transport.NetworkManager.LogWarning(string.Format("Send issue: {0}", eresult));
			}
			gchandle.Free();
			return eresult;
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x00170684 File Offset: 0x0016E884
		internal void ClearQueue(ConcurrentQueue<LocalPacket> queue)
		{
			LocalPacket localPacket;
			while (queue.TryDequeue(out localPacket))
			{
				ByteArrayPool.Store(localPacket.Data);
			}
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x001706A8 File Offset: 0x0016E8A8
		internal void ClearQueue(Queue<LocalPacket> queue)
		{
			while (queue.Count > 0)
			{
				ByteArrayPool.Store(queue.Dequeue().Data);
			}
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x001706C8 File Offset: 0x0016E8C8
		protected void GetMessage(IntPtr ptr, byte[] buffer, out ArraySegment<byte> segment, out byte channel)
		{
			SteamNetworkingMessage_t steamNetworkingMessage_t = Marshal.PtrToStructure<SteamNetworkingMessage_t>(ptr);
			int cbSize = steamNetworkingMessage_t.m_cbSize;
			Marshal.Copy(steamNetworkingMessage_t.m_pData, buffer, 0, cbSize);
			SteamNetworkingMessage_t.Release(ptr);
			channel = buffer[cbSize - 1];
			segment = new ArraySegment<byte>(buffer, 0, cbSize - 1);
		}

		// Token: 0x04004117 RID: 16663
		private LocalConnectionState _connectionState;

		// Token: 0x04004118 RID: 16664
		protected bool PeerToPeer;

		// Token: 0x04004119 RID: 16665
		protected Transport Transport;

		// Token: 0x0400411A RID: 16666
		protected IntPtr[] MessagePointers = new IntPtr[256];

		// Token: 0x0400411B RID: 16667
		protected byte[] InboundBuffer;

		// Token: 0x0400411C RID: 16668
		protected const int MAX_MESSAGES = 256;
	}
}
