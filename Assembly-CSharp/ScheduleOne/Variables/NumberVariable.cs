using System;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x0200028F RID: 655
	public class NumberVariable : Variable<float>
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x0003C664 File Offset: 0x0003A864
		public NumberVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, float value) : base(name, replicationMode, persistent, mode, owner, value)
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0003C678 File Offset: 0x0003A878
		public override bool TryDeserialize(string valueString, out float value)
		{
			float num;
			if (float.TryParse(valueString, out num))
			{
				value = num;
				return true;
			}
			value = 0f;
			return false;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0003C69C File Offset: 0x0003A89C
		public override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			float num;
			if (!this.TryDeserialize(value, out num))
			{
				return false;
			}
			if (operation == Condition.EConditionType.EqualTo)
			{
				return this.Value == num;
			}
			if (operation == Condition.EConditionType.NotEqualTo)
			{
				return this.Value != num;
			}
			if (operation == Condition.EConditionType.GreaterThan)
			{
				return this.Value > num;
			}
			if (operation == Condition.EConditionType.LessThan)
			{
				return this.Value < num;
			}
			if (operation == Condition.EConditionType.GreaterThanOrEqualTo)
			{
				return this.Value >= num;
			}
			if (operation == Condition.EConditionType.LessThanOrEqualTo)
			{
				return this.Value <= num;
			}
			Console.LogError("Invalid operation " + operation.ToString() + " for number variable", null);
			return false;
		}
	}
}
