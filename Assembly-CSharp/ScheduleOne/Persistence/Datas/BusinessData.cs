using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x020003D2 RID: 978
	[Serializable]
	public class BusinessData : PropertyData
	{
		// Token: 0x06001535 RID: 5429 RVA: 0x0005F48F File Offset: 0x0005D68F
		public BusinessData(string propertyCode, bool isOwned, bool[] switchStates, LaunderOperationData[] launderingOperations, bool[] toggleableStates) : base(propertyCode, isOwned, switchStates, toggleableStates)
		{
			this.LaunderingOperations = launderingOperations;
		}

		// Token: 0x0400136C RID: 4972
		public LaunderOperationData[] LaunderingOperations;
	}
}
