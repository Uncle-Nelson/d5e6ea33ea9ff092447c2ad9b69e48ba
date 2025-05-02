using System;

namespace ScheduleOne.Variables
{
	// Token: 0x0200028D RID: 653
	[Serializable]
	public class Conditions
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x0003C5CC File Offset: 0x0003A7CC
		public bool Evaluate()
		{
			bool flag = false;
			for (int i = 0; i < this.ConditionList.Length; i++)
			{
				if (this.ConditionList[i].Evaluate())
				{
					flag = true;
					if (this.EvaluationType != Conditions.EEvaluationType.And)
					{
						return true;
					}
				}
				else if (this.EvaluationType == Conditions.EEvaluationType.And)
				{
					return false;
				}
			}
			for (int j = 0; j < this.QuestConditionList.Length; j++)
			{
				if (this.QuestConditionList[j].Evaluate())
				{
					flag = true;
					if (this.EvaluationType != Conditions.EEvaluationType.And)
					{
						return true;
					}
				}
				else if (this.EvaluationType == Conditions.EEvaluationType.And)
				{
					return false;
				}
			}
			return flag || this.ConditionList.Length + this.QuestConditionList.Length == 0;
		}

		// Token: 0x04000E2E RID: 3630
		public Conditions.EEvaluationType EvaluationType;

		// Token: 0x04000E2F RID: 3631
		public Condition[] ConditionList;

		// Token: 0x04000E30 RID: 3632
		public QuestCondition[] QuestConditionList;

		// Token: 0x0200028E RID: 654
		public enum EEvaluationType
		{
			// Token: 0x04000E32 RID: 3634
			And,
			// Token: 0x04000E33 RID: 3635
			Or
		}
	}
}
