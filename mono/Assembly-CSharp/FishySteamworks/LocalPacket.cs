using System;
using FishNet.Utility.Performance;

namespace FishySteamworks
{
	// Token: 0x02000C40 RID: 3136
	internal struct LocalPacket
	{
		// Token: 0x060057DD RID: 22493 RVA: 0x00170728 File Offset: 0x0016E928
		public LocalPacket(ArraySegment<byte> data, byte channel)
		{
			this.Data = ByteArrayPool.Retrieve(data.Count);
			this.Length = data.Count;
			Buffer.BlockCopy(data.Array, data.Offset, this.Data, 0, this.Length);
			this.Channel = channel;
		}

		// Token: 0x0400411D RID: 16669
		public byte[] Data;

		// Token: 0x0400411E RID: 16670
		public int Length;

		// Token: 0x0400411F RID: 16671
		public byte Channel;
	}
}
