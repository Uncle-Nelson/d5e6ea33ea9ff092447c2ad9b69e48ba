using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000858 RID: 2136
	[Serializable]
	public class FloatSmoother
	{
		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x000F6B97 File Offset: 0x000F4D97
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x000F6B9F File Offset: 0x000F4D9F
		public float CurrentValue { get; private set; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x000F6BA8 File Offset: 0x000F4DA8
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x000F6BB0 File Offset: 0x000F4DB0
		public float Multiplier { get; private set; } = 1f;

		// Token: 0x06003A74 RID: 14964 RVA: 0x000F6BB9 File Offset: 0x000F4DB9
		public void Initialize()
		{
			this.SetDefault(this.DefaultValue);
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onFixedUpdate = (Action)Delegate.Combine(instance.onFixedUpdate, new Action(this.Update));
			}
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x000F6BF4 File Offset: 0x000F4DF4
		public void Destroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onFixedUpdate = (Action)Delegate.Remove(instance.onFixedUpdate, new Action(this.Update));
			}
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x000F6C23 File Offset: 0x000F4E23
		public void SetDefault(float value)
		{
			this.AddOverride(value, 0, "Default");
			this.CurrentValue = value;
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x000F6C39 File Offset: 0x000F4E39
		public void SetMultiplier(float value)
		{
			this.Multiplier = value;
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x000F6C42 File Offset: 0x000F4E42
		public void SetSmoothingSpeed(float value)
		{
			this.SmoothingSpeed = value;
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x000F6C4C File Offset: 0x000F4E4C
		public void AddOverride(float value, int priority, string label)
		{
			FloatSmoother.Override @override = this.overrides.Find((FloatSmoother.Override x) => x.Label.ToLower() == label.ToLower());
			if (@override == null)
			{
				@override = new FloatSmoother.Override();
				@override.Label = label;
				this.overrides.Add(@override);
			}
			@override.Value = value;
			@override.Priority = priority;
			this.overrides.Sort((FloatSmoother.Override x, FloatSmoother.Override y) => y.Priority.CompareTo(x.Priority));
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x000F6CD8 File Offset: 0x000F4ED8
		public void RemoveOverride(string label)
		{
			FloatSmoother.Override @override = this.overrides.Find((FloatSmoother.Override x) => x.Label.ToLower() == label.ToLower());
			if (@override != null)
			{
				this.overrides.Remove(@override);
			}
			this.overrides.Sort((FloatSmoother.Override x, FloatSmoother.Override y) => y.Priority.CompareTo(x.Priority));
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x000F6D44 File Offset: 0x000F4F44
		public void Update()
		{
			if (this.overrides.Count == 0)
			{
				return;
			}
			FloatSmoother.Override @override = this.overrides[0];
			this.CurrentValue = Mathf.Lerp(this.CurrentValue, @override.Value, this.SmoothingSpeed * Time.fixedDeltaTime) * this.Multiplier;
		}

		// Token: 0x04002A14 RID: 10772
		[SerializeField]
		private float DefaultValue = 1f;

		// Token: 0x04002A15 RID: 10773
		[SerializeField]
		private float SmoothingSpeed = 1f;

		// Token: 0x04002A16 RID: 10774
		private List<FloatSmoother.Override> overrides = new List<FloatSmoother.Override>();

		// Token: 0x02000859 RID: 2137
		public class Override
		{
			// Token: 0x04002A17 RID: 10775
			public float Value;

			// Token: 0x04002A18 RID: 10776
			public int Priority;

			// Token: 0x04002A19 RID: 10777
			public string Label;
		}
	}
}
