using System;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x0200029B RID: 667
	public class PongPaddle : MonoBehaviour
	{
		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0003DDA8 File Offset: 0x0003BFA8
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x0003DDB0 File Offset: 0x0003BFB0
		public float TargetY { get; set; }

		// Token: 0x06000DDA RID: 3546 RVA: 0x0003DDB9 File Offset: 0x0003BFB9
		public void SetTargetY(float y)
		{
			this.TargetY = y;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0003DDC2 File Offset: 0x0003BFC2
		private void Update()
		{
			this.UpdateMove();
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0003DDCC File Offset: 0x0003BFCC
		private void UpdateMove()
		{
			float num = this.Rect.anchoredPosition.y;
			num = Mathf.Lerp(num, this.TargetY, 20f * Time.deltaTime * this.SpeedMultiplier);
			num = Mathf.Clamp(num, -160f, 160f);
			this.Rect.anchoredPosition = new Vector3(this.Rect.anchoredPosition.x, num);
		}

		// Token: 0x04000E7B RID: 3707
		public const float BOUND_Y = 160f;

		// Token: 0x04000E7C RID: 3708
		public const float MOVE_SPEED = 20f;

		// Token: 0x04000E7D RID: 3709
		public float SpeedMultiplier = 1f;

		// Token: 0x04000E7F RID: 3711
		public RectTransform Rect;
	}
}
