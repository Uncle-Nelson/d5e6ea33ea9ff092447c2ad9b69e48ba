using System;
using FishNet.Connection;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x02000289 RID: 649
	public abstract class BaseVariable
	{
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0003C432 File Offset: 0x0003A632
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x0003C43A File Offset: 0x0003A63A
		public Player Owner { get; private set; }

		// Token: 0x06000D7E RID: 3454 RVA: 0x0003C444 File Offset: 0x0003A644
		public BaseVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner)
		{
			this.Name = name;
			this.ReplicationMode = replicationMode;
			if (mode == EVariableMode.Global)
			{
				NetworkSingleton<VariableDatabase>.Instance.AddVariable(this);
			}
			else
			{
				if (owner == null)
				{
					Console.LogError("Player variable created without owner", null);
					return;
				}
				owner.AddVariable(this);
			}
			this.Persistent = persistent;
			this.VariableMode = mode;
			this.Owner = owner;
		}

		// Token: 0x06000D7F RID: 3455
		public abstract object GetValue();

		// Token: 0x06000D80 RID: 3456
		public abstract void SetValue(object value, bool replicate = true);

		// Token: 0x06000D81 RID: 3457
		public abstract void ReplicateValue(NetworkConnection conn);

		// Token: 0x06000D82 RID: 3458 RVA: 0x000141BA File Offset: 0x000123BA
		public virtual bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return false;
		}

		// Token: 0x04000E1F RID: 3615
		public EVariableReplicationMode ReplicationMode;

		// Token: 0x04000E20 RID: 3616
		public string Name;

		// Token: 0x04000E21 RID: 3617
		public bool Persistent;

		// Token: 0x04000E22 RID: 3618
		public EVariableMode VariableMode;
	}
}
