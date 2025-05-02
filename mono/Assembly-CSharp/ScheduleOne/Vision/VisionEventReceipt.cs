using System;
using FishNet.Object;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Vision
{
	// Token: 0x02000285 RID: 645
	[Serializable]
	public class VisionEventReceipt
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x0003C409 File Offset: 0x0003A609
		public VisionEventReceipt(NetworkObject targetPlayer, PlayerVisualState.EVisualState state)
		{
			this.TargetPlayer = targetPlayer;
			this.State = state;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0000494F File Offset: 0x00002B4F
		public VisionEventReceipt()
		{
		}

		// Token: 0x04000E16 RID: 3606
		public NetworkObject TargetPlayer;

		// Token: 0x04000E17 RID: 3607
		public PlayerVisualState.EVisualState State;
	}
}
