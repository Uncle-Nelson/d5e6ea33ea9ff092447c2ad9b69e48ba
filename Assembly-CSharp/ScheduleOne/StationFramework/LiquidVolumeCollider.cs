using System;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008CC RID: 2252
	public class LiquidVolumeCollider : MonoBehaviour
	{
		// Token: 0x06003D2D RID: 15661 RVA: 0x00100F8E File Offset: 0x000FF18E
		private void Awake()
		{
			if (this.LiquidContainer == null)
			{
				this.LiquidContainer = base.GetComponentInParent<LiquidContainer>();
			}
		}

		// Token: 0x04002BFB RID: 11259
		public LiquidContainer LiquidContainer;
	}
}
