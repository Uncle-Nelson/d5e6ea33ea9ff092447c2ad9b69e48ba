using System;
using FishNet.Object;

namespace ScheduleOne.Management
{
	// Token: 0x02000581 RID: 1409
	public interface IUsable
	{
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x0008FFA9 File Offset: 0x0008E1A9
		bool IsInUse
		{
			get
			{
				return this.NPCUserObject != null || this.PlayerUserObject != null;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600231D RID: 8989
		// (set) Token: 0x0600231E RID: 8990
		NetworkObject NPCUserObject { get; set; }

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600231F RID: 8991
		// (set) Token: 0x06002320 RID: 8992
		NetworkObject PlayerUserObject { get; set; }

		// Token: 0x06002321 RID: 8993
		void SetPlayerUser(NetworkObject playerObject);

		// Token: 0x06002322 RID: 8994
		void SetNPCUser(NetworkObject playerObject);
	}
}
