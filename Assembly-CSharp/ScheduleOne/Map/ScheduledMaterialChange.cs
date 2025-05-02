using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C33 RID: 3123
	public class ScheduledMaterialChange : MonoBehaviour
	{
		// Token: 0x0600578C RID: 22412 RVA: 0x0016F59C File Offset: 0x0016D79C
		protected virtual void Start()
		{
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.Tick));
			this.SetMaterial(false);
			this.appliedInsideTimeRange = false;
			this.randomShift = Random.Range(-this.TimeRangeRandomization, this.TimeRangeRandomization);
			this.Tick();
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x0016F5FC File Offset: 0x0016D7FC
		protected virtual void Tick()
		{
			if (!this.Enabled && this.appliedInsideTimeRange)
			{
				this.SetMaterial(false);
			}
			int min = TimeManager.AddMinutesTo24HourTime(this.TimeRangeMin, this.TimeRangeShift + this.randomShift);
			int max = TimeManager.AddMinutesTo24HourTime(this.TimeRangeMax, this.TimeRangeShift + this.randomShift);
			if (NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(min, max))
			{
				if (this.onState == ScheduledMaterialChange.EOnState.Undecided)
				{
					this.onState = ((Random.Range(0f, 1f) > this.TurnOnChance) ? ScheduledMaterialChange.EOnState.Off : ScheduledMaterialChange.EOnState.On);
				}
			}
			else
			{
				this.onState = ScheduledMaterialChange.EOnState.Undecided;
			}
			if (NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(min, max) && this.onState == ScheduledMaterialChange.EOnState.On)
			{
				if (!this.appliedInsideTimeRange)
				{
					this.SetMaterial(true);
					return;
				}
			}
			else if (this.appliedInsideTimeRange)
			{
				this.SetMaterial(false);
			}
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x0016F6C8 File Offset: 0x0016D8C8
		private void SetMaterial(bool insideTimeRange)
		{
			if (this.Renderers == null || this.Renderers.Length == 0)
			{
				return;
			}
			this.appliedInsideTimeRange = insideTimeRange;
			Material material = this.Renderers[0].materials[this.MaterialIndex];
			material = (insideTimeRange ? this.InsideTimeRangeMaterial : this.OutsideTimeRangeMaterial);
			foreach (MeshRenderer meshRenderer in this.Renderers)
			{
				Material[] materials = meshRenderer.materials;
				materials[this.MaterialIndex] = material;
				meshRenderer.materials = materials;
			}
		}

		// Token: 0x040040CB RID: 16587
		public MeshRenderer[] Renderers;

		// Token: 0x040040CC RID: 16588
		public int MaterialIndex;

		// Token: 0x040040CD RID: 16589
		[Header("Settings")]
		public bool Enabled = true;

		// Token: 0x040040CE RID: 16590
		public Material OutsideTimeRangeMaterial;

		// Token: 0x040040CF RID: 16591
		public Material InsideTimeRangeMaterial;

		// Token: 0x040040D0 RID: 16592
		public int TimeRangeMin;

		// Token: 0x040040D1 RID: 16593
		public int TimeRangeMax;

		// Token: 0x040040D2 RID: 16594
		public int TimeRangeShift;

		// Token: 0x040040D3 RID: 16595
		public int TimeRangeRandomization;

		// Token: 0x040040D4 RID: 16596
		[Range(0f, 1f)]
		public float TurnOnChance = 1f;

		// Token: 0x040040D5 RID: 16597
		private bool appliedInsideTimeRange;

		// Token: 0x040040D6 RID: 16598
		private ScheduledMaterialChange.EOnState onState;

		// Token: 0x040040D7 RID: 16599
		private int randomShift;

		// Token: 0x02000C34 RID: 3124
		private enum EOnState
		{
			// Token: 0x040040D9 RID: 16601
			Undecided,
			// Token: 0x040040DA RID: 16602
			On,
			// Token: 0x040040DB RID: 16603
			Off
		}
	}
}
