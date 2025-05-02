using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Persistence
{
	// Token: 0x0200037A RID: 890
	public class LoadRequest
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0005A428 File Offset: 0x00058628
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x0005A430 File Offset: 0x00058630
		public bool IsDone { get; private set; }

		// Token: 0x06001433 RID: 5171 RVA: 0x0005A439 File Offset: 0x00058639
		public LoadRequest(string filePath, Loader loader)
		{
			if (loader == null)
			{
				Debug.LogError("Loader is null for file path: " + filePath);
				return;
			}
			this.Path = filePath;
			this.Loader = loader;
			Singleton<LoadManager>.Instance.QueueLoadRequest(this);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0005A46E File Offset: 0x0005866E
		public void Complete()
		{
			Singleton<LoadManager>.Instance.DequeueLoadRequest(this);
			this.Loader.Load(this.Path);
			this.IsDone = true;
		}

		// Token: 0x0400130D RID: 4877
		public string Path;

		// Token: 0x0400130E RID: 4878
		public Loader Loader;
	}
}
