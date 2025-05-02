using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000467 RID: 1127
	public class NPCPathCache
	{
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0006981A File Offset: 0x00067A1A
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x00069822 File Offset: 0x00067A22
		public List<NPCPathCache.PathCache> Paths { get; private set; } = new List<NPCPathCache.PathCache>();

		// Token: 0x060017E2 RID: 6114 RVA: 0x0006982C File Offset: 0x00067A2C
		public NavMeshPath GetPath(Vector3 start, Vector3 end, float sqrMaxDistance)
		{
			foreach (NPCPathCache.PathCache pathCache in this.Paths)
			{
				if ((pathCache.Start - start).sqrMagnitude < sqrMaxDistance && (pathCache.End - end).sqrMagnitude < sqrMaxDistance)
				{
					return pathCache.Path;
				}
			}
			return null;
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x000698B4 File Offset: 0x00067AB4
		public void AddPath(Vector3 start, Vector3 end, NavMeshPath path)
		{
			this.Paths.Add(new NPCPathCache.PathCache(start, end, path));
		}

		// Token: 0x02000468 RID: 1128
		[Serializable]
		public class PathCache
		{
			// Token: 0x060017E5 RID: 6117 RVA: 0x000698DC File Offset: 0x00067ADC
			public PathCache(Vector3 start, Vector3 end, NavMeshPath path)
			{
				this.Start = start;
				this.End = end;
				this.Path = path;
			}

			// Token: 0x0400157C RID: 5500
			public Vector3 Start;

			// Token: 0x0400157D RID: 5501
			public Vector3 End;

			// Token: 0x0400157E RID: 5502
			public NavMeshPath Path;
		}
	}
}
