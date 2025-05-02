using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C22 RID: 3106
	public class MapPositionUtility : Singleton<MapPositionUtility>
	{
		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600572B RID: 22315 RVA: 0x0016E5C0 File Offset: 0x0016C7C0
		// (set) Token: 0x0600572C RID: 22316 RVA: 0x0016E5C8 File Offset: 0x0016C7C8
		private float conversionFactor { get; set; }

		// Token: 0x0600572D RID: 22317 RVA: 0x0016E5D1 File Offset: 0x0016C7D1
		protected override void Awake()
		{
			base.Awake();
			this.Recalculate();
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x0016E5DF File Offset: 0x0016C7DF
		public Vector2 GetMapPosition(Vector3 worldPosition)
		{
			return new Vector2(worldPosition.x - this.OriginPoint.position.x, worldPosition.z - this.OriginPoint.position.z) * this.conversionFactor;
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x0016E61F File Offset: 0x0016C81F
		[Button]
		public void Recalculate()
		{
			this.conversionFactor = this.MapDimensions * 0.5f / Vector3.Distance(this.OriginPoint.position, this.EdgePoint.position);
		}

		// Token: 0x04004085 RID: 16517
		public Transform OriginPoint;

		// Token: 0x04004086 RID: 16518
		public Transform EdgePoint;

		// Token: 0x04004087 RID: 16519
		public float MapDimensions = 2048f;
	}
}
