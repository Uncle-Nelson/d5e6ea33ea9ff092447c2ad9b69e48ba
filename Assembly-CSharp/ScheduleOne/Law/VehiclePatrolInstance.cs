using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Map;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005D3 RID: 1491
	[Serializable]
	public class VehiclePatrolInstance
	{
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x00094C0F File Offset: 0x00092E0F
		private PoliceStation nearestStation
		{
			get
			{
				return PoliceStation.GetClosestPoliceStation(Vector3.zero);
			}
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00094C1C File Offset: 0x00092E1C
		public void Evaluate()
		{
			if (this.activeOfficer != null)
			{
				this.CheckEnd();
				return;
			}
			if (this.nearestStation.OfficerPool.Count == 0)
			{
				return;
			}
			this.latestStartTime = TimeManager.AddMinutesTo24HourTime(this.StartTime, 30);
			if (NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime, this.latestStartTime) && (!this.OnlyIfCurfewEnabled || NetworkSingleton<CurfewManager>.Instance.IsEnabled))
			{
				if (!this.startedThisCycle && Singleton<LawController>.Instance.LE_Intensity >= this.IntensityRequirement)
				{
					this.StartPatrol();
					return;
				}
			}
			else
			{
				this.startedThisCycle = false;
			}
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00094CB8 File Offset: 0x00092EB8
		private void CheckEnd()
		{
			if (this.activeOfficer != null && !this.activeOfficer.VehiclePatrolBehaviour.Enabled)
			{
				this.activeOfficer = null;
			}
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00094CE4 File Offset: 0x00092EE4
		public void StartPatrol()
		{
			if (this.activeOfficer != null)
			{
				Console.LogWarning("StartPatrol called but patrol is already active.", null);
				return;
			}
			this.startedThisCycle = true;
			if (this.nearestStation.OfficerPool.Count == 0)
			{
				return;
			}
			this.activeOfficer = Singleton<LawManager>.Instance.StartVehiclePatrol(this.Route);
		}

		// Token: 0x04001B78 RID: 7032
		public VehiclePatrolRoute Route;

		// Token: 0x04001B79 RID: 7033
		public int StartTime = 2000;

		// Token: 0x04001B7A RID: 7034
		[Range(1f, 10f)]
		public int IntensityRequirement = 5;

		// Token: 0x04001B7B RID: 7035
		public bool OnlyIfCurfewEnabled;

		// Token: 0x04001B7C RID: 7036
		private PoliceOfficer activeOfficer;

		// Token: 0x04001B7D RID: 7037
		private int latestStartTime;

		// Token: 0x04001B7E RID: 7038
		private bool startedThisCycle;
	}
}
