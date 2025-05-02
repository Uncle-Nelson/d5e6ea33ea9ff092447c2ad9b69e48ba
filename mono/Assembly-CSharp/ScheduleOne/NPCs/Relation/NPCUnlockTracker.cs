using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Relation
{
	// Token: 0x02000494 RID: 1172
	public class NPCUnlockTracker : MonoBehaviour
	{
		// Token: 0x060019F1 RID: 6641 RVA: 0x000705D0 File Offset: 0x0006E7D0
		private void Awake()
		{
			if (this.Npc.RelationData.Unlocked)
			{
				this.Invoke(this.Npc.RelationData.UnlockType, false);
			}
			NPCRelationData relationData = this.Npc.RelationData;
			relationData.onUnlocked = (Action<NPCRelationData.EUnlockType, bool>)Delegate.Combine(relationData.onUnlocked, new Action<NPCRelationData.EUnlockType, bool>(this.Invoke));
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00070632 File Offset: 0x0006E832
		private void Invoke(NPCRelationData.EUnlockType type, bool t)
		{
			if (this.onUnlocked != null)
			{
				this.onUnlocked.Invoke();
			}
		}

		// Token: 0x04001652 RID: 5714
		public NPC Npc;

		// Token: 0x04001653 RID: 5715
		public UnityEvent onUnlocked;
	}
}
