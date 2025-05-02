using System;

namespace ScheduleOne
{
	// Token: 0x0200026A RID: 618
	public interface IGUIDRegisterable
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000CE1 RID: 3297
		Guid GUID { get; }

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00039694 File Offset: 0x00037894
		void SetGUID(string guid)
		{
			Guid guid2;
			if (Guid.TryParse(guid, out guid2))
			{
				this.SetGUID(guid2);
				return;
			}
			Console.LogWarning(guid + " is not a valid GUID.", null);
		}

		// Token: 0x06000CE3 RID: 3299
		void SetGUID(Guid guid);
	}
}
