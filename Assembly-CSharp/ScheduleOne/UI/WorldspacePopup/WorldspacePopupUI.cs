using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000A62 RID: 2658
	public class WorldspacePopupUI : MonoBehaviour
	{
		// Token: 0x0600478F RID: 18319 RVA: 0x0012BAB7 File Offset: 0x00129CB7
		public void SetFill(float fill)
		{
			this.FillImage.fillAmount = fill;
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x0012BAC5 File Offset: 0x00129CC5
		public void Destroy()
		{
			if (this.onDestroyed != null)
			{
				this.onDestroyed.Invoke();
			}
			Object.Destroy(base.gameObject);
		}

		// Token: 0x040034F7 RID: 13559
		[HideInInspector]
		public WorldspacePopup Popup;

		// Token: 0x040034F8 RID: 13560
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x040034F9 RID: 13561
		public Image FillImage;

		// Token: 0x040034FA RID: 13562
		public UnityEvent onDestroyed;
	}
}
