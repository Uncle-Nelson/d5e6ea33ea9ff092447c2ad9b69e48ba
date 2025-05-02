using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.FX
{
	// Token: 0x02000625 RID: 1573
	public class ProximityCircle : MonoBehaviour
	{
		// Token: 0x06002936 RID: 10550 RVA: 0x000AA012 File Offset: 0x000A8212
		private void LateUpdate()
		{
			if (!this.enabledThisFrame)
			{
				this.SetAlpha(0f);
				this.enabledThisFrame = false;
			}
			this.enabledThisFrame = false;
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000AA035 File Offset: 0x000A8235
		public void SetRadius(float rad)
		{
			this.Circle.size = new Vector3(rad * 2f, rad * 2f, 3f);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000AA05A File Offset: 0x000A825A
		public void SetAlpha(float alpha)
		{
			this.enabledThisFrame = true;
			this.Circle.fadeFactor = alpha;
			this.Circle.enabled = (alpha > 0f);
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000AA082 File Offset: 0x000A8282
		public void SetColor(Color col)
		{
			this.Circle.material.color = col;
		}

		// Token: 0x04001E71 RID: 7793
		[Header("References")]
		public DecalProjector Circle;

		// Token: 0x04001E72 RID: 7794
		private bool enabledThisFrame;
	}
}
