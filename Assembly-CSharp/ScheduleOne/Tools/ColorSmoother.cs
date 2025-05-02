using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000849 RID: 2121
	[Serializable]
	public class ColorSmoother
	{
		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x000F64C4 File Offset: 0x000F46C4
		// (set) Token: 0x06003A3B RID: 14907 RVA: 0x000F64CC File Offset: 0x000F46CC
		public Color CurrentValue { get; private set; } = Color.white;

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06003A3C RID: 14908 RVA: 0x000F64D5 File Offset: 0x000F46D5
		// (set) Token: 0x06003A3D RID: 14909 RVA: 0x000F64DD File Offset: 0x000F46DD
		public float Multiplier { get; private set; } = 1f;

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x000F64E6 File Offset: 0x000F46E6
		public Color Default
		{
			get
			{
				return this.DefaultValue;
			}
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x000F64EE File Offset: 0x000F46EE
		public void Initialize()
		{
			this.SetDefault(this.DefaultValue);
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onFixedUpdate = (Action)Delegate.Combine(instance.onFixedUpdate, new Action(this.Update));
			}
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x000F6529 File Offset: 0x000F4729
		public void Destroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onFixedUpdate = (Action)Delegate.Remove(instance.onFixedUpdate, new Action(this.Update));
			}
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x000F6558 File Offset: 0x000F4758
		public void SetDefault(Color value)
		{
			this.AddOverride(value, 0, "Default");
			this.CurrentValue = value;
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x000F656E File Offset: 0x000F476E
		public void SetMultiplier(float value)
		{
			this.Multiplier = value;
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x000F6578 File Offset: 0x000F4778
		public void AddOverride(Color value, int priority, string label)
		{
			ColorSmoother.Override @override = this.overrides.Find((ColorSmoother.Override x) => x.Label.ToLower() == label.ToLower());
			if (@override == null)
			{
				@override = new ColorSmoother.Override();
				@override.Label = label;
				this.overrides.Add(@override);
			}
			@override.Value = value;
			@override.Priority = priority;
			this.overrides.Sort((ColorSmoother.Override x, ColorSmoother.Override y) => y.Priority.CompareTo(x.Priority));
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x000F6604 File Offset: 0x000F4804
		public void RemoveOverride(string label)
		{
			ColorSmoother.Override @override = this.overrides.Find((ColorSmoother.Override x) => x.Label.ToLower() == label.ToLower());
			if (@override != null)
			{
				this.overrides.Remove(@override);
			}
			this.overrides.Sort((ColorSmoother.Override x, ColorSmoother.Override y) => y.Priority.CompareTo(x.Priority));
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x000F6670 File Offset: 0x000F4870
		public void Update()
		{
			if (this.overrides.Count == 0)
			{
				return;
			}
			ColorSmoother.Override @override = this.overrides[0];
			this.CurrentValue = Color.Lerp(this.CurrentValue, @override.Value, this.SmoothingSpeed * Time.fixedDeltaTime) * this.Multiplier;
		}

		// Token: 0x040029ED RID: 10733
		[SerializeField]
		private Color DefaultValue = Color.white;

		// Token: 0x040029EE RID: 10734
		[SerializeField]
		private float SmoothingSpeed = 1f;

		// Token: 0x040029EF RID: 10735
		[SerializeField]
		private List<ColorSmoother.Override> overrides = new List<ColorSmoother.Override>();

		// Token: 0x0200084A RID: 2122
		[Serializable]
		public class Override
		{
			// Token: 0x040029F0 RID: 10736
			public Color Value;

			// Token: 0x040029F1 RID: 10737
			public int Priority;

			// Token: 0x040029F2 RID: 10738
			public string Label;
		}
	}
}
