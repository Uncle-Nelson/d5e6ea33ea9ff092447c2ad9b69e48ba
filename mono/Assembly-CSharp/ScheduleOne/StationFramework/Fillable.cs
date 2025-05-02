using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008C0 RID: 2240
	public class Fillable : MonoBehaviour
	{
		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x00100708 File Offset: 0x000FE908
		// (set) Token: 0x06003CF4 RID: 15604 RVA: 0x00100710 File Offset: 0x000FE910
		public List<Fillable.Content> contents { get; protected set; } = new List<Fillable.Content>();

		// Token: 0x06003CF5 RID: 15605 RVA: 0x00100719 File Offset: 0x000FE919
		private void Awake()
		{
			this.LiquidContainer.SetLiquidLevel(0f, false);
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x0010072C File Offset: 0x000FE92C
		public void AddLiquid(string label, float volume, Color color)
		{
			Fillable.Content content = this.contents.Find((Fillable.Content c) => c.Label == label);
			if (content == null)
			{
				content = new Fillable.Content();
				content.Label = label;
				content.Volume_L = 0f;
				content.Color = color;
				this.contents.Add(content);
			}
			content.Volume_L += volume;
			this.UpdateLiquid();
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x001007A5 File Offset: 0x000FE9A5
		public void ResetContents()
		{
			this.contents.Clear();
			this.UpdateLiquid();
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x001007B8 File Offset: 0x000FE9B8
		private void UpdateLiquid()
		{
			float totalVolume = this.contents.Sum((Fillable.Content x) => x.Volume_L);
			this.LiquidContainer.SetLiquidLevel(totalVolume / this.LiquidCapacity_L, false);
			if (totalVolume > 0f)
			{
				Color color = this.contents.Aggregate(Color.clear, (Color acc, Fillable.Content c) => acc + c.Color * c.Volume_L / totalVolume);
				this.LiquidContainer.SetLiquidColor(color, true, true);
			}
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x0010084C File Offset: 0x000FEA4C
		public float GetLiquidVolume(string label)
		{
			Fillable.Content content = this.contents.Find((Fillable.Content c) => c.Label == label);
			if (content == null)
			{
				return 0f;
			}
			return content.Volume_L;
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x0010088D File Offset: 0x000FEA8D
		public float GetTotalLiquidVolume()
		{
			return this.contents.Sum((Fillable.Content x) => x.Volume_L);
		}

		// Token: 0x04002BD0 RID: 11216
		[Header("References")]
		public LiquidContainer LiquidContainer;

		// Token: 0x04002BD1 RID: 11217
		[Header("Settings")]
		public bool FillableEnabled = true;

		// Token: 0x04002BD2 RID: 11218
		public float LiquidCapacity_L = 1f;

		// Token: 0x020008C1 RID: 2241
		public class Content
		{
			// Token: 0x04002BD3 RID: 11219
			public string Label;

			// Token: 0x04002BD4 RID: 11220
			public float Volume_L;

			// Token: 0x04002BD5 RID: 11221
			public Color Color;
		}
	}
}
