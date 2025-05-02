using System;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A53 RID: 2643
	public class UIMover : MonoBehaviour
	{
		// Token: 0x06004733 RID: 18227 RVA: 0x0012A2E0 File Offset: 0x001284E0
		private void Start()
		{
			this.speed = new Vector2(Random.Range(this.MinSpeed.x, this.MaxSpeed.x), Random.Range(this.MinSpeed.y, this.MaxSpeed.y));
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0012A330 File Offset: 0x00128530
		public void Update()
		{
			Vector2 b = this.speed * this.SpeedMultiplier * Time.deltaTime;
			this.Rect.anchoredPosition += b;
		}

		// Token: 0x04003499 RID: 13465
		public RectTransform Rect;

		// Token: 0x0400349A RID: 13466
		public Vector2 MinSpeed = Vector2.one;

		// Token: 0x0400349B RID: 13467
		public Vector2 MaxSpeed = Vector2.one;

		// Token: 0x0400349C RID: 13468
		public float SpeedMultiplier = 1f;

		// Token: 0x0400349D RID: 13469
		private Vector2 speed = Vector2.zero;
	}
}
