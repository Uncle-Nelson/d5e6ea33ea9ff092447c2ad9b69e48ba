using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200043F RID: 1087
	[Serializable]
	public class WorldStorageEntityData : SaveData
	{
		// Token: 0x060015BC RID: 5564 RVA: 0x0006055F File Offset: 0x0005E75F
		public WorldStorageEntityData(Guid guid, ItemSet contents)
		{
			this.GUID = guid.ToString();
			this.Contents = contents;
		}

		// Token: 0x04001482 RID: 5250
		public string GUID;

		// Token: 0x04001483 RID: 5251
		public ItemSet Contents;
	}
}
