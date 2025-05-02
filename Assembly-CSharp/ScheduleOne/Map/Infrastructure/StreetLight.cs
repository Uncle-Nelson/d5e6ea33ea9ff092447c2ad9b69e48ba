using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Lighting;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Map.Infrastructure
{
	// Token: 0x02000C3B RID: 3131
	public class StreetLight : MonoBehaviour
	{
		// Token: 0x060057B2 RID: 22450 RVA: 0x0016FFB0 File Offset: 0x0016E1B0
		protected virtual void Awake()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.UpdateState));
			if (this.BeamTracker != null)
			{
				this.BeamTracker.Override = true;
			}
			this.StartTimeOffset = (int)(Vector3.Distance(base.transform.position, StreetLight.POWER_ORIGIN) / 50f);
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x00170020 File Offset: 0x0016E220
		private void Start()
		{
			this.UpdateState();
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x00170028 File Offset: 0x0016E228
		protected virtual void UpdateState()
		{
			this.SetState(NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(TimeManager.AddMinutesTo24HourTime(this.StartTime, this.StartTimeOffset), TimeManager.AddMinutesTo24HourTime(this.EndTime, this.StartTimeOffset)));
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				this.UpdateShadows();
			}
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x000045B1 File Offset: 0x000027B1
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00170074 File Offset: 0x0016E274
		private void SetState(bool on)
		{
			if (this.BeamTracker != null)
			{
				this.BeamTracker.Enabled = this.isOn;
			}
			float num = 0f;
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				num = Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position);
			}
			if (num < this.LightMaxDistance * QualitySettings.lodBias)
			{
				this.Light.enabled = this.isOn;
			}
			else
			{
				this.Light.enabled = false;
			}
			if (on == this.isOn)
			{
				return;
			}
			this.isOn = on;
			if (this.LightRend != null)
			{
				this.LightRend.material = (this.isOn ? this.LightOnMat : this.LightOffMat);
			}
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x0017013C File Offset: 0x0016E33C
		private void UpdateShadows()
		{
			if (!this.ShadowsEnabled)
			{
				this.Light.shadows = LightShadows.None;
				return;
			}
			float num = Vector3.Distance(base.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position);
			if (num < this.SoftShadowsThreshold * QualitySettings.lodBias)
			{
				this.Light.shadows = LightShadows.Soft;
				return;
			}
			if (num < this.HardShadowsThreshold * QualitySettings.lodBias)
			{
				this.Light.shadows = LightShadows.Hard;
				return;
			}
			this.Light.shadows = LightShadows.None;
		}

		// Token: 0x040040F7 RID: 16631
		public static Vector3 POWER_ORIGIN = new Vector3(150f, 0f, -150f);

		// Token: 0x040040F8 RID: 16632
		[Header("References")]
		[SerializeField]
		protected MeshRenderer LightRend;

		// Token: 0x040040F9 RID: 16633
		[SerializeField]
		protected Light Light;

		// Token: 0x040040FA RID: 16634
		[SerializeField]
		protected VolumetricLightTracker BeamTracker;

		// Token: 0x040040FB RID: 16635
		[Header("Materials")]
		public Material LightOnMat;

		// Token: 0x040040FC RID: 16636
		public Material LightOffMat;

		// Token: 0x040040FD RID: 16637
		[Header("Timing")]
		public int StartTime = 1800;

		// Token: 0x040040FE RID: 16638
		public int EndTime = 600;

		// Token: 0x040040FF RID: 16639
		public int StartTimeOffset;

		// Token: 0x04004100 RID: 16640
		[Header("Settings")]
		public bool ShadowsEnabled = true;

		// Token: 0x04004101 RID: 16641
		public float LightMaxDistance = 80f;

		// Token: 0x04004102 RID: 16642
		public float SoftShadowsThreshold = 12f;

		// Token: 0x04004103 RID: 16643
		public float HardShadowsThreshold = 36f;

		// Token: 0x04004104 RID: 16644
		private bool isOn;
	}
}
