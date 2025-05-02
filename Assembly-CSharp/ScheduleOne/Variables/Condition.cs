using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Variables
{
	// Token: 0x0200028B RID: 651
	[Serializable]
	public class Condition
	{
		// Token: 0x06000D86 RID: 3462 RVA: 0x0003C54C File Offset: 0x0003A74C
		public bool Evaluate()
		{
			if (!NetworkSingleton<VariableDatabase>.InstanceExists)
			{
				return false;
			}
			BaseVariable variable = NetworkSingleton<VariableDatabase>.Instance.GetVariable(this.VariableName);
			if (variable == null)
			{
				Debug.LogError("Variable " + this.VariableName + " not found");
				return false;
			}
			return variable.EvaluateCondition(this.Operator, this.Value);
		}

		// Token: 0x04000E24 RID: 3620
		public string VariableName = "Variable Name";

		// Token: 0x04000E25 RID: 3621
		public Condition.EConditionType Operator = Condition.EConditionType.EqualTo;

		// Token: 0x04000E26 RID: 3622
		public string Value = "true";

		// Token: 0x0200028C RID: 652
		public enum EConditionType
		{
			// Token: 0x04000E28 RID: 3624
			GreaterThan,
			// Token: 0x04000E29 RID: 3625
			LessThan,
			// Token: 0x04000E2A RID: 3626
			EqualTo,
			// Token: 0x04000E2B RID: 3627
			NotEqualTo,
			// Token: 0x04000E2C RID: 3628
			GreaterThanOrEqualTo,
			// Token: 0x04000E2D RID: 3629
			LessThanOrEqualTo
		}
	}
}
