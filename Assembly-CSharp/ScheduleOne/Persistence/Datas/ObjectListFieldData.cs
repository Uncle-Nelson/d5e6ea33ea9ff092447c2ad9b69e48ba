using System;
using System.Collections.Generic;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003FF RID: 1023
	[Serializable]
	public class ObjectListFieldData
	{
		// Token: 0x06001573 RID: 5491 RVA: 0x0005FA60 File Offset: 0x0005DC60
		public ObjectListFieldData(List<string> objectGUIDs)
		{
			this.ObjectGUIDs = objectGUIDs;
		}

		// Token: 0x040013C1 RID: 5057
		public List<string> ObjectGUIDs;
	}
}
