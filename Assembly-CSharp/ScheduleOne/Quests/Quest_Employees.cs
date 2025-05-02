using System;
using System.Collections.Generic;
using FishNet;
using ScheduleOne.Employees;

namespace ScheduleOne.Quests
{
	// Token: 0x020002EA RID: 746
	public abstract class Quest_Employees : Quest
	{
		// Token: 0x060010B3 RID: 4275
		public abstract List<Employee> GetEmployees();

		// Token: 0x060010B4 RID: 4276 RVA: 0x0004AEE0 File Offset: 0x000490E0
		protected override void MinPass()
		{
			base.MinPass();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.AssignBedEntry.State == EQuestState.Active && this.AreAnyEmployeesAssignedBeds())
			{
				this.AssignBedEntry.Complete();
			}
			if (this.PayEntry.State == EQuestState.Active && this.AreAnyEmployeesPaid())
			{
				this.PayEntry.Complete();
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0004AF40 File Offset: 0x00049140
		protected bool AreAnyEmployeesAssignedBeds()
		{
			using (List<Employee>.Enumerator enumerator = this.GetEmployees().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetBed() != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0004AFA0 File Offset: 0x000491A0
		protected bool AreAnyEmployeesPaid()
		{
			using (List<Employee>.Enumerator enumerator = this.GetEmployees().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.PaidForToday)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x040010E8 RID: 4328
		public EEmployeeType EmployeeType;

		// Token: 0x040010E9 RID: 4329
		public QuestEntry AssignBedEntry;

		// Token: 0x040010EA RID: 4330
		public QuestEntry PayEntry;
	}
}
