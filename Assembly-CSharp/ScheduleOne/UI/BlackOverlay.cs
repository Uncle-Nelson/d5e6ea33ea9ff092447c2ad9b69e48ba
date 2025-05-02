using System;
using System.Collections;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009BD RID: 2493
	public class BlackOverlay : Singleton<BlackOverlay>
	{
		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06004343 RID: 17219 RVA: 0x00119C78 File Offset: 0x00117E78
		// (set) Token: 0x06004344 RID: 17220 RVA: 0x00119C80 File Offset: 0x00117E80
		public bool isShown { get; protected set; }

		// Token: 0x06004345 RID: 17221 RVA: 0x00119C89 File Offset: 0x00117E89
		protected override void Awake()
		{
			base.Awake();
			this.isShown = false;
			this.canvas.enabled = false;
			this.group.alpha = 0f;
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00119CB4 File Offset: 0x00117EB4
		public void Open(float fadeTime = 0.5f)
		{
			this.isShown = true;
			this.canvas.enabled = true;
			if (this.fadeRoutine != null)
			{
				base.StopCoroutine(this.fadeRoutine);
			}
			this.fadeRoutine = base.StartCoroutine(this.Fade(1f, fadeTime));
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00119D00 File Offset: 0x00117F00
		public void Close(float fadeTime = 0.5f)
		{
			this.isShown = false;
			if (this.fadeRoutine != null)
			{
				base.StopCoroutine(this.fadeRoutine);
			}
			this.fadeRoutine = base.StartCoroutine(this.Fade(0f, fadeTime));
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00119D35 File Offset: 0x00117F35
		private IEnumerator Fade(float endOpacity, float fadeTime)
		{
			float start = this.group.alpha;
			for (float i = 0f; i < fadeTime; i += Time.deltaTime)
			{
				this.group.alpha = Mathf.Lerp(start, endOpacity, i / fadeTime);
				yield return new WaitForEndOfFrame();
			}
			this.group.alpha = endOpacity;
			if (endOpacity == 0f)
			{
				this.canvas.enabled = false;
			}
			this.fadeRoutine = null;
			yield break;
		}

		// Token: 0x040030DD RID: 12509
		[Header("References")]
		public Canvas canvas;

		// Token: 0x040030DE RID: 12510
		public CanvasGroup group;

		// Token: 0x040030DF RID: 12511
		private Coroutine fadeRoutine;
	}
}
