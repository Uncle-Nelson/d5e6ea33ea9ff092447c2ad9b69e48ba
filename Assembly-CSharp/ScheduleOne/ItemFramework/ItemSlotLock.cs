using System;
using FishNet.Object;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000956 RID: 2390
	public class ItemSlotLock
	{
		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060040C3 RID: 16579 RVA: 0x0010FFF9 File Offset: 0x0010E1F9
		// (set) Token: 0x060040C4 RID: 16580 RVA: 0x00110001 File Offset: 0x0010E201
		public ItemSlot Slot { get; protected set; }

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060040C5 RID: 16581 RVA: 0x0011000A File Offset: 0x0010E20A
		// (set) Token: 0x060040C6 RID: 16582 RVA: 0x00110012 File Offset: 0x0010E212
		public NetworkObject LockOwner { get; protected set; }

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x0011001B File Offset: 0x0010E21B
		// (set) Token: 0x060040C8 RID: 16584 RVA: 0x00110023 File Offset: 0x0010E223
		public string LockReason { get; protected set; } = "";

		// Token: 0x060040C9 RID: 16585 RVA: 0x0011002C File Offset: 0x0010E22C
		public ItemSlotLock(ItemSlot slot, NetworkObject lockOwner, string lockReason)
		{
			this.Slot = slot;
			this.LockOwner = lockOwner;
			this.LockReason = lockReason;
		}
	}
}
