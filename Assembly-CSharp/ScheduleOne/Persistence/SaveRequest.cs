using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Persistence
{
	// Token: 0x02000381 RID: 897
	public class SaveRequest
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0005B4AD File Offset: 0x000596AD
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x0005B4B5 File Offset: 0x000596B5
		public string SaveString { get; private set; }

		// Token: 0x0600146C RID: 5228 RVA: 0x0005B4C0 File Offset: 0x000596C0
		public SaveRequest(ISaveable saveable, string parentFolderPath)
		{
			this.Saveable = saveable;
			this.ParentFolderPath = parentFolderPath;
			this.SaveString = saveable.GetSaveString();
			if (this.SaveString != string.Empty)
			{
				Singleton<SaveManager>.Instance.QueueSaveRequest(this);
				return;
			}
			saveable.CompleteSave(parentFolderPath, false);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0005B513 File Offset: 0x00059713
		public void Complete()
		{
			Singleton<SaveManager>.Instance.DequeueSaveRequest(this);
			this.Saveable.WriteBaseData(this.ParentFolderPath, this.SaveString);
		}

		// Token: 0x0400133C RID: 4924
		public ISaveable Saveable;

		// Token: 0x0400133D RID: 4925
		public string ParentFolderPath;
	}
}
