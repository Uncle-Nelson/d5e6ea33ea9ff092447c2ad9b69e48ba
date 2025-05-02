using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B19 RID: 2841
	public class Disclaimer : MonoBehaviour
	{
		// Token: 0x06004BD0 RID: 19408 RVA: 0x0013E874 File Offset: 0x0013CA74
		private void Awake()
		{
			if (Application.isEditor || Disclaimer.Shown)
			{
				base.gameObject.SetActive(false);
				return;
			}
			Disclaimer.Shown = true;
			this.Group.alpha = 1f;
			this.TextGroup.alpha = 0f;
			this.Fade();
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x0013E8C8 File Offset: 0x0013CAC8
		private void Fade()
		{
			base.StartCoroutine(this.<Fade>g__Fade|5_0());
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x0013E8EA File Offset: 0x0013CAEA
		[CompilerGenerated]
		private IEnumerator <Fade>g__Fade|5_0()
		{
			while (this.TextGroup.alpha < 1f)
			{
				this.TextGroup.alpha += Time.deltaTime * 2f;
				yield return null;
			}
			for (float i = 0f; i < this.Duration; i += Time.deltaTime)
			{
				if (Input.GetKey(KeyCode.Space))
				{
					IL_FC:
					while (this.Group.alpha > 0f)
					{
						this.Group.alpha -= Time.deltaTime * 2f;
						yield return null;
					}
					base.gameObject.SetActive(false);
					yield break;
				}
				yield return new WaitForEndOfFrame();
			}
			goto IL_FC;
		}

		// Token: 0x040038D2 RID: 14546
		public static bool Shown;

		// Token: 0x040038D3 RID: 14547
		public CanvasGroup Group;

		// Token: 0x040038D4 RID: 14548
		public CanvasGroup TextGroup;

		// Token: 0x040038D5 RID: 14549
		public float Duration = 3.8f;
	}
}
