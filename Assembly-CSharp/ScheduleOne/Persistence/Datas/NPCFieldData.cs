using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003FC RID: 1020
	[Serializable]
	public class NPCFieldData
	{
		// Token: 0x06001570 RID: 5488 RVA: 0x0005FA33 File Offset: 0x0005DC33
		public NPCFieldData(string npcGuid)
		{
			this.NPCGuid = npcGuid;
		}

		// Token: 0x040013BE RID: 5054
		public string NPCGuid;
	}
}
