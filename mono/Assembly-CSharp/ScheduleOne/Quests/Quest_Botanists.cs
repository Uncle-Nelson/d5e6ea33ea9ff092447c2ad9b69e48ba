using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E4 RID: 740
	public class Quest_Botanists : Quest_Employees
	{
		// Token: 0x060010A2 RID: 4258 RVA: 0x0004AA0C File Offset: 0x00048C0C
		protected override void MinPass()
		{
			base.MinPass();
			if (this.AssignSuppliesEntry.State == EQuestState.Active)
			{
				using (List<Employee>.Enumerator enumerator = this.GetEmployees().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((enumerator.Current as Botanist).Configuration as BotanistConfiguration).Supplies.SelectedObject != null)
						{
							this.AssignSuppliesEntry.Complete();
							break;
						}
					}
				}
			}
			if (this.AssignWorkEntry.State == EQuestState.Active)
			{
				using (List<Employee>.Enumerator enumerator = this.GetEmployees().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((enumerator.Current as Botanist).Configuration as BotanistConfiguration).AssignedPots.Count > 0)
						{
							this.AssignWorkEntry.Complete();
							break;
						}
					}
				}
			}
			if (this.AssignDestinationEntry.State == EQuestState.Active)
			{
				foreach (Employee employee in this.GetEmployees())
				{
					using (List<Pot>.Enumerator enumerator2 = ((employee as Botanist).Configuration as BotanistConfiguration).AssignedPots.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if ((enumerator2.Current.Configuration as PotConfiguration).Destination.SelectedObject != null)
							{
								this.AssignDestinationEntry.Complete();
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0004ABC8 File Offset: 0x00048DC8
		public override List<Employee> GetEmployees()
		{
			return NetworkSingleton<EmployeeManager>.Instance.GetEmployeesByType(EEmployeeType.Botanist);
		}

		// Token: 0x040010E1 RID: 4321
		public QuestEntry AssignSuppliesEntry;

		// Token: 0x040010E2 RID: 4322
		public QuestEntry AssignWorkEntry;

		// Token: 0x040010E3 RID: 4323
		public QuestEntry AssignDestinationEntry;
	}
}
