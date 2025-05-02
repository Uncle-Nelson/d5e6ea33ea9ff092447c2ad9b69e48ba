using System;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x02000300 RID: 768
	[Serializable]
	public class SystemTrigger
	{
		// Token: 0x0600110D RID: 4365 RVA: 0x0004C16C File Offset: 0x0004A36C
		public bool Trigger()
		{
			if (this.Conditions.Evaluate())
			{
				for (int i = 0; i < this.onEvaluateTrueQuestSetters.Length; i++)
				{
					this.onEvaluateTrueQuestSetters[i].Execute();
				}
				for (int j = 0; j < this.onEvaluateTrueVariableSetters.Length; j++)
				{
					this.onEvaluateTrueVariableSetters[j].Execute();
				}
				if (this.onEvaluateTrue != null)
				{
					this.onEvaluateTrue.Invoke();
				}
				return true;
			}
			for (int k = 0; k < this.onEvaluateFalseQuestSetters.Length; k++)
			{
				this.onEvaluateFalseQuestSetters[k].Execute();
			}
			for (int l = 0; l < this.onEvaluateFalseVariableSetters.Length; l++)
			{
				this.onEvaluateFalseVariableSetters[l].Execute();
			}
			if (this.onEvaluateFalse != null)
			{
				this.onEvaluateFalse.Invoke();
			}
			return false;
		}

		// Token: 0x04001131 RID: 4401
		public Conditions Conditions;

		// Token: 0x04001132 RID: 4402
		[Header("True")]
		public VariableSetter[] onEvaluateTrueVariableSetters;

		// Token: 0x04001133 RID: 4403
		public QuestStateSetter[] onEvaluateTrueQuestSetters;

		// Token: 0x04001134 RID: 4404
		public UnityEvent onEvaluateTrue;

		// Token: 0x04001135 RID: 4405
		[Header("False")]
		public VariableSetter[] onEvaluateFalseVariableSetters;

		// Token: 0x04001136 RID: 4406
		public QuestStateSetter[] onEvaluateFalseQuestSetters;

		// Token: 0x04001137 RID: 4407
		public UnityEvent onEvaluateFalse;
	}
}
