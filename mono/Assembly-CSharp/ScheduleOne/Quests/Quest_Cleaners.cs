using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.Management;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E7 RID: 743
	public class Quest_Cleaners : Quest_Employees
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x0004AD44 File Offset: 0x00048F44
		protected override void MinPass()
		{
			base.MinPass();
			if (this.AssignWorkEntry.State == EQuestState.Active)
			{
				using (List<Employee>.Enumerator enumerator = this.GetEmployees().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((enumerator.Current as Cleaner).Configuration as CleanerConfiguration).binItems.Count > 0)
						{
							this.AssignWorkEntry.Complete();
							break;
						}
					}
				}
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0004ADCC File Offset: 0x00048FCC
		public override List<Employee> GetEmployees()
		{
			return NetworkSingleton<EmployeeManager>.Instance.GetEmployeesByType(EEmployeeType.Cleaner);
		}

		// Token: 0x040010E7 RID: 4327
		public QuestEntry AssignWorkEntry;
	}
}
