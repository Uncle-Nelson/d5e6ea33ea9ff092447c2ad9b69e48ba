using System;
using ScheduleOne.NPCs.Relation;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003EB RID: 1003
	[Serializable]
	public class RelationshipData : SaveData
	{
		// Token: 0x0600155E RID: 5470 RVA: 0x0005F8E3 File Offset: 0x0005DAE3
		public RelationshipData(float relationDelta, bool unlocked, NPCRelationData.EUnlockType unlockType)
		{
			this.RelationDelta = relationDelta;
			this.Unlocked = unlocked;
			this.UnlockType = unlockType;
		}

		// Token: 0x040013A1 RID: 5025
		public float RelationDelta;

		// Token: 0x040013A2 RID: 5026
		public bool Unlocked;

		// Token: 0x040013A3 RID: 5027
		public NPCRelationData.EUnlockType UnlockType;
	}
}
