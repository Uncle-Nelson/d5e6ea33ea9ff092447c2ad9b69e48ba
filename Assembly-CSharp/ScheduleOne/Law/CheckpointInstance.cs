using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Map;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	// Token: 0x020005B4 RID: 1460
	[Serializable]
	public class CheckpointInstance
	{
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0009317E File Offset: 0x0009137E
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x00093186 File Offset: 0x00091386
		public RoadCheckpoint activeCheckpoint { get; protected set; }

		// Token: 0x06002447 RID: 9287 RVA: 0x00093190 File Offset: 0x00091390
		public void Evaluate()
		{
			if (this.checkPoint == null)
			{
				this.checkPoint = NetworkSingleton<CheckpointManager>.Instance.GetCheckpoint(this.Location);
			}
			if (this.activeCheckpoint != null)
			{
				return;
			}
			if (this.checkPoint.ActivationState == RoadCheckpoint.ECheckpointState.Enabled)
			{
				return;
			}
			if (Singleton<LawController>.Instance.LE_Intensity >= this.IntensityRequirement && NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime, this.EndTime) && (!this.OnlyIfCurfewEnabled || NetworkSingleton<CurfewManager>.Instance.IsEnabled) && this.DistanceRequirementsMet())
			{
				this.EnableCheckpoint();
			}
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x0009322C File Offset: 0x0009142C
		public void EnableCheckpoint()
		{
			if (this.activeCheckpoint != null)
			{
				Console.LogWarning("StartPatrol called but patrol is already active.", null);
				return;
			}
			if (PoliceStation.GetClosestPoliceStation(Vector3.zero).OfficerPool.Count == 0)
			{
				return;
			}
			this.activeCheckpoint = NetworkSingleton<CheckpointManager>.Instance.GetCheckpoint(this.Location);
			NetworkSingleton<CheckpointManager>.Instance.SetCheckpointEnabled(this.Location, true, this.Members);
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x000932C0 File Offset: 0x000914C0
		private bool DistanceRequirementsMet()
		{
			float num;
			Player closestPlayer = Player.GetClosestPlayer(NetworkSingleton<CheckpointManager>.Instance.GetCheckpoint(this.Location).transform.position, out num, null);
			return NetworkSingleton<TimeManager>.Instance.SleepInProgress || closestPlayer == null || num >= 50f;
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00093310 File Offset: 0x00091510
		private void MinPass()
		{
			if (!NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(this.StartTime, this.EndTime) && this.DistanceRequirementsMet())
			{
				this.DisableCheckpoint();
			}
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x00093338 File Offset: 0x00091538
		public void DisableCheckpoint()
		{
			if (this.activeCheckpoint == null)
			{
				return;
			}
			NetworkSingleton<CheckpointManager>.Instance.SetCheckpointEnabled(this.Location, false, this.Members);
			this.activeCheckpoint = null;
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
		}

		// Token: 0x04001B06 RID: 6918
		public const float MIN_ACTIVATION_DISTANCE = 50f;

		// Token: 0x04001B07 RID: 6919
		public CheckpointManager.ECheckpointLocation Location;

		// Token: 0x04001B08 RID: 6920
		public int Members = 2;

		// Token: 0x04001B09 RID: 6921
		public int StartTime = 800;

		// Token: 0x04001B0A RID: 6922
		public int EndTime = 2000;

		// Token: 0x04001B0B RID: 6923
		[Range(1f, 10f)]
		public int IntensityRequirement = 5;

		// Token: 0x04001B0C RID: 6924
		public bool OnlyIfCurfewEnabled;

		// Token: 0x04001B0D RID: 6925
		private RoadCheckpoint checkPoint;
	}
}
