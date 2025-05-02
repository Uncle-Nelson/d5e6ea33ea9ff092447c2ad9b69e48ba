using System;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A4E RID: 2638
	public class DestroyUIAtBounds : MonoBehaviour
	{
		// Token: 0x0600471C RID: 18204 RVA: 0x00129EA4 File Offset: 0x001280A4
		public void Update()
		{
			if (this.Rect.anchoredPosition.x < this.MinBounds.x || this.Rect.anchoredPosition.x > this.MaxBounds.x || this.Rect.anchoredPosition.y < this.MinBounds.y || this.Rect.anchoredPosition.y > this.MaxBounds.y)
			{
				Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x04003486 RID: 13446
		public RectTransform Rect;

		// Token: 0x04003487 RID: 13447
		public Vector2 MinBounds = new Vector2(-1000f, -1000f);

		// Token: 0x04003488 RID: 13448
		public Vector2 MaxBounds = new Vector2(1000f, 1000f);
	}
}
