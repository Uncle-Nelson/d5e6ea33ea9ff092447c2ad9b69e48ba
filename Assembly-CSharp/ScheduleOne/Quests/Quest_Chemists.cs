using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.Management;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E5 RID: 741
	public class Quest_Chemists : Quest_Employees
	{
		// Token: 0x060010A5 RID: 4261 RVA: 0x0004ABE0 File Offset: 0x00048DE0
		protected override void MinPass()
		{
			base.MinPass();
			if (this.AssignWorkEntry.State == EQuestState.Active)
			{
				using (List<Employee>.Enumerator enumerator = this.GetEmployees().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((enumerator.Current as Chemist).Configuration as ChemistConfiguration).TotalStations > 0)
						{
							this.AssignWorkEntry.Complete();
							break;
						}
					}
				}
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0004AC64 File Offset: 0x00048E64
		public override List<Employee> GetEmployees()
		{
			return NetworkSingleton<EmployeeManager>.Instance.GetEmployeesByType(EEmployeeType.Chemist);
		}

		// Token: 0x040010E4 RID: 4324
		public QuestEntry AssignWorkEntry;
	}
}
