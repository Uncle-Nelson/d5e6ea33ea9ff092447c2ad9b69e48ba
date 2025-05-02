using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003FE RID: 1022
	[Serializable]
	public class ObjectFieldData
	{
		// Token: 0x06001572 RID: 5490 RVA: 0x0005FA51 File Offset: 0x0005DC51
		public ObjectFieldData(string objectGUID)
		{
			this.ObjectGUID = objectGUID;
		}

		// Token: 0x040013C0 RID: 5056
		public string ObjectGUID;
	}
}
