using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Variables
{
	// Token: 0x02000295 RID: 661
	[Serializable]
	public class VariableSetter
	{
		// Token: 0x06000DBE RID: 3518 RVA: 0x0003D584 File Offset: 0x0003B784
		public void Execute()
		{
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.VariableName, this.NewValue, true);
		}

		// Token: 0x04000E4F RID: 3663
		public string VariableName;

		// Token: 0x04000E50 RID: 3664
		public string NewValue;
	}
}
