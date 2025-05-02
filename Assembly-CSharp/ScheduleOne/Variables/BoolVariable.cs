using System;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x0200028A RID: 650
	public class BoolVariable : Variable<bool>
	{
		// Token: 0x06000D83 RID: 3459 RVA: 0x0003C4AB File Offset: 0x0003A6AB
		public BoolVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, bool value) : base(name, replicationMode, persistent, mode, owner, value)
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0003C4BC File Offset: 0x0003A6BC
		public override bool TryDeserialize(string valueString, out bool value)
		{
			if (valueString.ToLower() == "true")
			{
				value = true;
				return true;
			}
			if (valueString.ToLower() == "false")
			{
				value = false;
				return true;
			}
			value = false;
			return false;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0003C4F0 File Offset: 0x0003A6F0
		public override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			bool flag;
			if (!this.TryDeserialize(value, out flag))
			{
				return false;
			}
			if (operation == Condition.EConditionType.EqualTo)
			{
				return this.Value == flag;
			}
			if (operation == Condition.EConditionType.NotEqualTo)
			{
				return this.Value != flag;
			}
			Console.LogError("Invalid operation " + operation.ToString() + " for bool variable", null);
			return false;
		}
	}
}
