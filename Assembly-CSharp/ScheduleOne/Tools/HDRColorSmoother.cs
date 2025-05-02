using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200085F RID: 2143
	[Serializable]
	public class HDRColorSmoother
	{
		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06003A8A RID: 14986 RVA: 0x000F6E91 File Offset: 0x000F5091
		// (set) Token: 0x06003A8B RID: 14987 RVA: 0x000F6E99 File Offset: 0x000F5099
		public Color CurrentValue { get; private set; } = Color.white;

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06003A8C RID: 14988 RVA: 0x000F6EA2 File Offset: 0x000F50A2
		// (set) Token: 0x06003A8D RID: 14989 RVA: 0x000F6EAA File Offset: 0x000F50AA
		public float Multiplier { get; private set; } = 1f;

		// Token: 0x06003A8E RID: 14990 RVA: 0x000F6EB3 File Offset: 0x000F50B3
		public void Initialize()
		{
			this.SetDefault(this.DefaultValue);
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onFixedUpdate = (Action)Delegate.Combine(instance.onFixedUpdate, new Action(this.Update));
			}
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x000F6EEE File Offset: 0x000F50EE
		public void Destroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onFixedUpdate = (Action)Delegate.Remove(instance.onFixedUpdate, new Action(this.Update));
			}
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x000F6F1D File Offset: 0x000F511D
		public void SetDefault(Color value)
		{
			this.AddOverride(value, 0, "Default");
			this.CurrentValue = value;
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x000F6F33 File Offset: 0x000F5133
		public void SetMultiplier(float value)
		{
			this.Multiplier = value;
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x000F6F3C File Offset: 0x000F513C
		public void AddOverride(Color value, int priority, string label)
		{
			HDRColorSmoother.Override @override = this.overrides.Find((HDRColorSmoother.Override x) => x.Label.ToLower() == label.ToLower());
			if (@override == null)
			{
				@override = new HDRColorSmoother.Override();
				@override.Label = label;
				this.overrides.Add(@override);
			}
			@override.Value = value;
			@override.Priority = priority;
			this.overrides.Sort((HDRColorSmoother.Override x, HDRColorSmoother.Override y) => y.Priority.CompareTo(x.Priority));
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x000F6FC8 File Offset: 0x000F51C8
		public void RemoveOverride(string label)
		{
			HDRColorSmoother.Override @override = this.overrides.Find((HDRColorSmoother.Override x) => x.Label.ToLower() == label.ToLower());
			if (@override != null)
			{
				this.overrides.Remove(@override);
			}
			this.overrides.Sort((HDRColorSmoother.Override x, HDRColorSmoother.Override y) => y.Priority.CompareTo(x.Priority));
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x000F7034 File Offset: 0x000F5234
		public void Update()
		{
			if (this.overrides.Count == 0)
			{
				return;
			}
			HDRColorSmoother.Override @override = this.overrides[0];
			this.CurrentValue = Color.Lerp(this.CurrentValue, @override.Value, this.SmoothingSpeed * Time.fixedDeltaTime) * this.Multiplier;
		}

		// Token: 0x04002A23 RID: 10787
		[ColorUsage(true, true)]
		[SerializeField]
		private Color DefaultValue = Color.white;

		// Token: 0x04002A24 RID: 10788
		[SerializeField]
		private float SmoothingSpeed = 1f;

		// Token: 0x04002A25 RID: 10789
		[SerializeField]
		private List<HDRColorSmoother.Override> overrides = new List<HDRColorSmoother.Override>();

		// Token: 0x02000860 RID: 2144
		[Serializable]
		public class Override
		{
			// Token: 0x04002A26 RID: 10790
			public Color Value;

			// Token: 0x04002A27 RID: 10791
			public int Priority;

			// Token: 0x04002A28 RID: 10792
			public string Label;
		}
	}
}
