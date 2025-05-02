using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence
{
	// Token: 0x02000363 RID: 867
	public interface IGenericSaveable
	{
		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600139C RID: 5020
		Guid GUID { get; }

		// Token: 0x0600139D RID: 5021 RVA: 0x000578A2 File Offset: 0x00055AA2
		void InitializeSaveable()
		{
			if (!Singleton<GenericSaveablesManager>.InstanceExists)
			{
				Console.LogError("GenericSaveablesManager does not exist in scene.", null);
				return;
			}
			Singleton<GenericSaveablesManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x0600139E RID: 5022
		void Load(GenericSaveData data);

		// Token: 0x0600139F RID: 5023
		GenericSaveData GetSaveData();
	}
}
