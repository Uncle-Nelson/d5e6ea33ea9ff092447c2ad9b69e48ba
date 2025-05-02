using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Map;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005D1 RID: 1489
	[Serializable]
	public class SentryInstance
	{
		// Token: 0x060024DF RID: 9439 RVA: 0x00094A08 File Offset: 0x00092C08
		public void Evaluate()
		{
			if (this.Location.AssignedOfficers.Count > 0)
			{
				return;
			}
			if (this.officers.Count > 0)
			{
				return;
			}
			if (Singleton<LawController>.Instance.LE_Intensity >= this.IntensityRequirement && NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime, this.EndTime) && (!this.OnlyIfCurfewEnabled || NetworkSingleton<CurfewManager>.Instance.IsEnabled))
			{
				this.StartEntry();
			}
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00094A7C File Offset: 0x00092C7C
		public void StartEntry()
		{
			if (this.Location.AssignedOfficers.Count > 0)
			{
				Console.LogWarning("StartEntry called but location already has active officers", null);
				return;
			}
			PoliceStation closestPoliceStation = PoliceStation.GetClosestPoliceStation(this.Location.transform.position);
			if (closestPoliceStation.OfficerPool.Count == 0)
			{
				return;
			}
			for (int i = 0; i < this.Members; i++)
			{
				PoliceOfficer policeOfficer = closestPoliceStation.PullOfficer();
				if (policeOfficer == null)
				{
					Console.LogWarning("Failed to pull officer from station", null);
					break;
				}
				policeOfficer.AssignToSentryLocation(this.Location);
				this.officers.Add(policeOfficer);
			}
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00094B38 File Offset: 0x00092D38
		private void MinPass()
		{
			if (!NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime, this.EndTime))
			{
				this.EndSentry();
			}
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00094B58 File Offset: 0x00092D58
		public void EndSentry()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			for (int i = 0; i < this.officers.Count; i++)
			{
				this.officers[i].UnassignFromSentryLocation();
			}
			this.officers.Clear();
		}

		// Token: 0x04001B6F RID: 7023
		public SentryLocation Location;

		// Token: 0x04001B70 RID: 7024
		public int Members = 2;

		// Token: 0x04001B71 RID: 7025
		[Header("Timing")]
		public int StartTime = 2000;

		// Token: 0x04001B72 RID: 7026
		public int EndTime = 100;

		// Token: 0x04001B73 RID: 7027
		[Range(1f, 10f)]
		public int IntensityRequirement = 5;

		// Token: 0x04001B74 RID: 7028
		public bool OnlyIfCurfewEnabled;

		// Token: 0x04001B75 RID: 7029
		private List<PoliceOfficer> officers = new List<PoliceOfficer>();
	}
}
