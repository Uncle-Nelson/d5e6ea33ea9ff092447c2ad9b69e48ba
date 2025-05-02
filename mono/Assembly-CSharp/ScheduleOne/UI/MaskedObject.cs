using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ScheduleOne.UI
{
	// Token: 0x02000A4F RID: 2639
	public class MaskedObject : UIBehaviour
	{
		// Token: 0x0600471E RID: 18206 RVA: 0x00129F62 File Offset: 0x00128162
		protected override void OnRectTransformDimensionsChange()
		{
			base.OnRectTransformDimensionsChange();
			if (this.initialized)
			{
				this.SetTargetClippingRect();
			}
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x00129F78 File Offset: 0x00128178
		protected override void Awake()
		{
			base.Awake();
			this.Initialize(this.rootCanvas, this.maskRectTransform);
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x00129F94 File Offset: 0x00128194
		protected override void Start()
		{
			this.canvasRenderersToClip.Add(this.canvasRendererToClip);
			if (this.includeChildren)
			{
				CanvasRenderer[] componentsInChildren = base.GetComponentsInChildren<CanvasRenderer>(true);
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					if (componentsInChildren[i] != this.canvasRendererToClip)
					{
						this.canvasRenderersToClip.Add(componentsInChildren[i]);
					}
				}
			}
			this.SetTargetClippingRect();
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x00129FF4 File Offset: 0x001281F4
		public void Initialize(Canvas rootCanvas, RectTransform maskRectTransform)
		{
			this.rootCanvas = rootCanvas;
			this.maskRectTransform = maskRectTransform;
			this.SetTargetClippingRect();
			this.initialized = true;
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x0012A014 File Offset: 0x00128214
		private void SetTargetClippingRect()
		{
			Rect rect = this.maskRectTransform.rect;
			rect.center += this.rootCanvas.transform.InverseTransformPoint(this.maskRectTransform.position);
			foreach (CanvasRenderer canvasRenderer in this.canvasRenderersToClip)
			{
				canvasRenderer.EnableRectClipping(rect);
			}
		}

		// Token: 0x04003489 RID: 13449
		[SerializeField]
		private CanvasRenderer canvasRendererToClip;

		// Token: 0x0400348A RID: 13450
		public bool includeChildren;

		// Token: 0x0400348B RID: 13451
		[SerializeField]
		private Canvas rootCanvas;

		// Token: 0x0400348C RID: 13452
		[SerializeField]
		private RectTransform maskRectTransform;

		// Token: 0x0400348D RID: 13453
		private bool initialized;

		// Token: 0x0400348E RID: 13454
		private List<CanvasRenderer> canvasRenderersToClip = new List<CanvasRenderer>();
	}
}
