using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.Management;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F2 RID: 754
	public class Quest_Packagers : Quest_Employees
	{
		// Token: 0x060010CA RID: 4298 RVA: 0x0004B39C File Offset: 0x0004959C
		protected override void MinPass()
		{
			base.MinPass();
			if (this.AssignWorkEntry.State == EQuestState.Active)
			{
				using (List<Employee>.Enumerator enumerator = this.GetEmployees().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((enumerator.Current as Packager).Configuration as PackagerConfiguration).AssignedStationCount > 0)
						{
							this.AssignWorkEntry.Complete();
							break;
						}
					}
				}
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0004B420 File Offset: 0x00049620
		public override List<Employee> GetEmployees()
		{
			return NetworkSingleton<EmployeeManager>.Instance.GetEmployeesByType(EEmployeeType.Handler);
		}

		// Token: 0x040010FB RID: 4347
		public QuestEntry AssignWorkEntry;
	}
}
