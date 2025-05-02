using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Map;
using ScheduleOne.NPCs.Behaviour;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005CF RID: 1487
	[Serializable]
	public class PatrolInstance
	{
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060024D7 RID: 9431 RVA: 0x000945CA File Offset: 0x000927CA
		// (set) Token: 0x060024D8 RID: 9432 RVA: 0x000945D2 File Offset: 0x000927D2
		public PatrolGroup ActiveGroup { get; protected set; }

		// Token: 0x060024D9 RID: 9433 RVA: 0x000945DC File Offset: 0x000927DC
		public void Evaluate()
		{
			if (this.ActiveGroup != null)
			{
				return;
			}
			if (Singleton<LawController>.Instance.LE_Intensity >= this.IntensityRequirement && NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime, this.EndTime) && (!this.OnlyIfCurfewEnabled || NetworkSingleton<CurfewManager>.Instance.IsEnabled))
			{
				this.StartPatrol();
			}
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00094638 File Offset: 0x00092838
		public void StartPatrol()
		{
			if (this.ActiveGroup != null)
			{
				Console.LogWarning("StartPatrol called but patrol is already active.", null);
				return;
			}
			if (PoliceStation.GetClosestPoliceStation(Vector3.zero).OfficerPool.Count == 0)
			{
				return;
			}
			this.ActiveGroup = Singleton<LawManager>.Instance.StartFootpatrol(this.Route, this.Members);
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000946B2 File Offset: 0x000928B2
		private void MinPass()
		{
			if (!NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime, this.EndTime))
			{
				this.EndPatrol();
			}
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000946D4 File Offset: 0x000928D4
		public void EndPatrol()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			if (this.ActiveGroup == null)
			{
				return;
			}
			this.ActiveGroup.DisbandGroup();
			this.ActiveGroup = null;
		}

		// Token: 0x04001B5A RID: 7002
		public FootPatrolRoute Route;

		// Token: 0x04001B5B RID: 7003
		public int Members = 2;

		// Token: 0x04001B5C RID: 7004
		public int StartTime = 2000;

		// Token: 0x04001B5D RID: 7005
		public int EndTime = 100;

		// Token: 0x04001B5E RID: 7006
		[Range(1f, 10f)]
		public int IntensityRequirement = 5;

		// Token: 0x04001B5F RID: 7007
		public bool OnlyIfCurfewEnabled;
	}
}
