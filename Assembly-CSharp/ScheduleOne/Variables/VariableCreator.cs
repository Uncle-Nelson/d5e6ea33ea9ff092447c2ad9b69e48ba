using System;

namespace ScheduleOne.Variables
{
	// Token: 0x02000292 RID: 658
	[Serializable]
	public class VariableCreator
	{
		// Token: 0x04000E3C RID: 3644
		public string Name;

		// Token: 0x04000E3D RID: 3645
		public VariableDatabase.EVariableType Type;

		// Token: 0x04000E3E RID: 3646
		public string InitialValue = string.Empty;

		// Token: 0x04000E3F RID: 3647
		public bool Persistent = true;

		// Token: 0x04000E40 RID: 3648
		public EVariableMode Mode;
	}
}
