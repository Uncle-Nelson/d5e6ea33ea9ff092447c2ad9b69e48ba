using System;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x020006C5 RID: 1733
	[Serializable]
	public class BranchNodeData
	{
		// Token: 0x040021B0 RID: 8624
		public string Guid;

		// Token: 0x040021B1 RID: 8625
		public string BranchLabel;

		// Token: 0x040021B2 RID: 8626
		public Vector2 Position;

		// Token: 0x040021B3 RID: 8627
		public BranchOptionData[] options;
	}
}
