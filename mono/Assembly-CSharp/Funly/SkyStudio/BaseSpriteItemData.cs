using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001D8 RID: 472
	public class BaseSpriteItemData
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0002E617 File Offset: 0x0002C817
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x0002E61F File Offset: 0x0002C81F
		public Matrix4x4 modelMatrix { get; protected set; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002E628 File Offset: 0x0002C828
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0002E630 File Offset: 0x0002C830
		public BaseSpriteItemData.SpriteState state { get; protected set; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0002E639 File Offset: 0x0002C839
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x0002E641 File Offset: 0x0002C841
		public Vector3 spritePosition { get; set; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0002E64A File Offset: 0x0002C84A
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x0002E652 File Offset: 0x0002C852
		public float startTime { get; protected set; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0002E65B File Offset: 0x0002C85B
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x0002E663 File Offset: 0x0002C863
		public float endTime { get; protected set; }

		// Token: 0x06000A74 RID: 2676 RVA: 0x0002E66C File Offset: 0x0002C86C
		public BaseSpriteItemData()
		{
			this.state = BaseSpriteItemData.SpriteState.NotStarted;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0002E67B File Offset: 0x0002C87B
		public void SetTRSMatrix(Vector3 worldPosition, Quaternion rotation, Vector3 scale)
		{
			this.spritePosition = worldPosition;
			this.modelMatrix = Matrix4x4.TRS(worldPosition, rotation, scale);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0002E694 File Offset: 0x0002C894
		public void Start()
		{
			this.state = BaseSpriteItemData.SpriteState.Animating;
			this.startTime = BaseSpriteItemData.CalculateStartTimeWithDelay(this.delay);
			this.endTime = BaseSpriteItemData.CalculateEndTime(this.startTime, this.spriteSheetData.frameCount, this.spriteSheetData.frameRate);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		public void Continue()
		{
			if (this.state != BaseSpriteItemData.SpriteState.Animating)
			{
				return;
			}
			if (Time.time > this.endTime)
			{
				this.state = BaseSpriteItemData.SpriteState.Complete;
				return;
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002E701 File Offset: 0x0002C901
		public void Reset()
		{
			this.state = BaseSpriteItemData.SpriteState.NotStarted;
			this.startTime = -1f;
			this.endTime = -1f;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002E720 File Offset: 0x0002C920
		public static float CalculateStartTimeWithDelay(float delay)
		{
			return Time.time + delay;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002E72C File Offset: 0x0002C92C
		public static float CalculateEndTime(float startTime, int itemCount, int animationSpeed)
		{
			float num = 1f / (float)animationSpeed;
			float num2 = (float)itemCount * num;
			return startTime + num2;
		}

		// Token: 0x04000B69 RID: 2921
		public SpriteSheetData spriteSheetData;

		// Token: 0x04000B6F RID: 2927
		public float delay;

		// Token: 0x020001D9 RID: 473
		public enum SpriteState
		{
			// Token: 0x04000B71 RID: 2929
			Unknown,
			// Token: 0x04000B72 RID: 2930
			NotStarted,
			// Token: 0x04000B73 RID: 2931
			Animating,
			// Token: 0x04000B74 RID: 2932
			Complete
		}
	}
}
