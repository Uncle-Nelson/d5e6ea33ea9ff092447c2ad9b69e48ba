using System;
using ScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	// Token: 0x02000496 RID: 1174
	public class HoldItem : MonoBehaviour
	{
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x00070729 File Offset: 0x0006E929
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x00070731 File Offset: 0x0006E931
		public bool active { get; protected set; }

		// Token: 0x060019FC RID: 6652 RVA: 0x0007073A File Offset: 0x0006E93A
		public void Begin()
		{
			this.active = true;
			this.Npc.SetEquippable_Return(this.Equippable.AssetPath);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0007075A File Offset: 0x0006E95A
		private void Update()
		{
			bool active = this.active;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00070763 File Offset: 0x0006E963
		public void End()
		{
			this.active = false;
			this.Npc.SetEquippable_Return(string.Empty);
		}

		// Token: 0x04001657 RID: 5719
		public NPC Npc;

		// Token: 0x04001658 RID: 5720
		public AvatarEquippable Equippable;
	}
}
