using System;
using ScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	// Token: 0x02000495 RID: 1173
	public class DrinkItem : MonoBehaviour
	{
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00070647 File Offset: 0x0006E847
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0007064F File Offset: 0x0006E84F
		public bool active { get; protected set; }

		// Token: 0x060019F6 RID: 6646 RVA: 0x00070658 File Offset: 0x0006E858
		private void Awake()
		{
			if (this.Npc == null)
			{
				this.Npc = base.GetComponentInParent<NPC>();
			}
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00070674 File Offset: 0x0006E874
		public void Begin()
		{
			this.active = true;
			this.Npc.SetEquippable_Return(this.DrinkPrefab.AssetPath);
			this.Npc.Avatar.Anim.SetBool("Drinking", true);
			this.Npc.Avatar.LookController.OverrideIKWeight(0.3f);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000706D4 File Offset: 0x0006E8D4
		public void End()
		{
			this.active = false;
			this.Npc.Avatar.Anim.SetBool("Drinking", false);
			this.Npc.Avatar.LookController.ResetIKWeight();
			this.Npc.SetEquippable_Return(string.Empty);
		}

		// Token: 0x04001654 RID: 5716
		public NPC Npc;

		// Token: 0x04001655 RID: 5717
		public AvatarEquippable DrinkPrefab;
	}
}
