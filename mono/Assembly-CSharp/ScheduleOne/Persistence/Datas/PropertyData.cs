using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200042E RID: 1070
	[Serializable]
	public class PropertyData : SaveData
	{
		// Token: 0x060015A4 RID: 5540 RVA: 0x00060206 File Offset: 0x0005E406
		public PropertyData(string propertyCode, bool isOwned, bool[] switchStates, bool[] toggleableStates)
		{
			this.PropertyCode = propertyCode;
			this.IsOwned = isOwned;
			this.SwitchStates = switchStates;
			this.ToggleableStates = toggleableStates;
		}

		// Token: 0x0400144B RID: 5195
		public string PropertyCode;

		// Token: 0x0400144C RID: 5196
		public bool IsOwned;

		// Token: 0x0400144D RID: 5197
		public bool[] SwitchStates;

		// Token: 0x0400144E RID: 5198
		public bool[] ToggleableStates;
	}
}
