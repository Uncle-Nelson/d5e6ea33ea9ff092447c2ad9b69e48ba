using System;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009E4 RID: 2532
	public class Flipboard : MonoBehaviour
	{
		// Token: 0x0600445A RID: 17498 RVA: 0x0011E920 File Offset: 0x0011CB20
		public void Update()
		{
			this.time += Time.deltaTime * this.SpeedMultiplier;
			if (this.time >= this.FlipTime)
			{
				this.time = 0f;
				this.index = (this.index + 1) % this.Sprites.Length;
				this.Image.sprite = this.Sprites[this.index];
			}
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x0011E98E File Offset: 0x0011CB8E
		public void SetIndex(int index)
		{
			this.index = index;
			this.time = 0f;
			this.Image.sprite = this.Sprites[index];
		}

		// Token: 0x040031CF RID: 12751
		public Sprite[] Sprites;

		// Token: 0x040031D0 RID: 12752
		public Image Image;

		// Token: 0x040031D1 RID: 12753
		public float FlipTime = 0.2f;

		// Token: 0x040031D2 RID: 12754
		public float SpeedMultiplier = 1f;

		// Token: 0x040031D3 RID: 12755
		private float time;

		// Token: 0x040031D4 RID: 12756
		private int index;
	}
}
