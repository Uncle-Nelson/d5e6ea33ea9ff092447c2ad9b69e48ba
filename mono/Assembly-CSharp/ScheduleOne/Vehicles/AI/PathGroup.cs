using System;
using Pathfinding;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020007FA RID: 2042
	public class PathGroup
	{
		// Token: 0x0400282D RID: 10285
		public Vector3 entryPoint;

		// Token: 0x0400282E RID: 10286
		public Path startToEntryPath;

		// Token: 0x0400282F RID: 10287
		public Path entryToExitPath;

		// Token: 0x04002830 RID: 10288
		public Path exitToDestinationPath;
	}
}
