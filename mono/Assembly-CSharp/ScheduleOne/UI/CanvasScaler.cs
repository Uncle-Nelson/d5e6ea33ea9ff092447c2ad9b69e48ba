using System;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009C7 RID: 2503
	[RequireComponent(typeof(CanvasScaler))]
	public class CanvasScaler : MonoBehaviour
	{
		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600437D RID: 17277 RVA: 0x0011ACBE File Offset: 0x00118EBE
		public static float NormalizedCanvasScaleFactor
		{
			get
			{
				return Mathf.InverseLerp(0.7f, 1.4f, CanvasScaler.CanvasScaleFactor);
			}
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x0011ACD4 File Offset: 0x00118ED4
		public void Awake()
		{
			this.canvasScaler = base.GetComponent<CanvasScaler>();
			this.referenceResolution = this.canvasScaler.referenceResolution;
			CanvasScaler.OnCanvasScaleFactorChanged = (Action)Delegate.Combine(CanvasScaler.OnCanvasScaleFactorChanged, new Action(this.RefreshScale));
			this.RefreshScale();
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x0011AD24 File Offset: 0x00118F24
		private void OnDestroy()
		{
			CanvasScaler.OnCanvasScaleFactorChanged = (Action)Delegate.Remove(CanvasScaler.OnCanvasScaleFactorChanged, new Action(this.RefreshScale));
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x0011AD46 File Offset: 0x00118F46
		private void RefreshScale()
		{
			this.canvasScaler.referenceResolution = this.referenceResolution / CanvasScaler.CanvasScaleFactor / this.ScaleMultiplier;
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x0011AD6E File Offset: 0x00118F6E
		public static void SetScaleFactor(float scaleFactor)
		{
			scaleFactor = Mathf.Clamp(scaleFactor, 0.7f, 1.4f);
			CanvasScaler.CanvasScaleFactor = scaleFactor;
			Action onCanvasScaleFactorChanged = CanvasScaler.OnCanvasScaleFactorChanged;
			if (onCanvasScaleFactorChanged == null)
			{
				return;
			}
			onCanvasScaleFactorChanged();
		}

		// Token: 0x0400311D RID: 12573
		public static float CanvasScaleFactor = 1f;

		// Token: 0x0400311E RID: 12574
		public static Action OnCanvasScaleFactorChanged;

		// Token: 0x0400311F RID: 12575
		public float ScaleMultiplier = 1f;

		// Token: 0x04003120 RID: 12576
		private Vector2 referenceResolution = new Vector2(1920f, 1080f);

		// Token: 0x04003121 RID: 12577
		private CanvasScaler canvasScaler;
	}
}
