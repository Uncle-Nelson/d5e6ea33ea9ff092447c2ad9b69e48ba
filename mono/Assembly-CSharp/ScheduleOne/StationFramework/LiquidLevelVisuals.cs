using System;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008CB RID: 2251
	public class LiquidLevelVisuals : MonoBehaviour
	{
		// Token: 0x06003D2B RID: 15659 RVA: 0x00100EE0 File Offset: 0x000FF0E0
		private void Update()
		{
			if (this.Container == null)
			{
				return;
			}
			float num = this.Container.CurrentLiquidLevel / this.Container.MaxLevel;
			this.LiquidSurface.localPosition = Vector3.Lerp(this.LiquidSurface_Min.localPosition, this.LiquidSurface_Max.localPosition, num);
			this.LiquidSurface.localScale = new Vector3(this.LiquidSurface.localScale.x, num, this.LiquidSurface.localScale.z);
			this.LiquidSurface.gameObject.SetActive(this.Container.CurrentLiquidLevel > 0f);
		}

		// Token: 0x04002BF7 RID: 11255
		public LiquidContainer Container;

		// Token: 0x04002BF8 RID: 11256
		public Transform LiquidSurface;

		// Token: 0x04002BF9 RID: 11257
		public Transform LiquidSurface_Min;

		// Token: 0x04002BFA RID: 11258
		public Transform LiquidSurface_Max;
	}
}
