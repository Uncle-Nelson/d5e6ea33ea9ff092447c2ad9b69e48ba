using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000ACA RID: 2762
	public class WindowSelectorButton : MonoBehaviour
	{
		// Token: 0x06004A3D RID: 19005 RVA: 0x00137477 File Offset: 0x00135677
		private void Awake()
		{
			this.HoverIndicator.gameObject.SetActive(true);
			this.HoverIndicator.localScale = Vector3.one;
			this.Button.onClick.AddListener(new UnityAction(this.Clicked));
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x001374B6 File Offset: 0x001356B6
		public void SetInteractable(bool interactable)
		{
			this.Button.interactable = interactable;
			this.InactiveOverlay.SetActive(!interactable);
			if (!interactable)
			{
				this.SetHoverIndicator(false);
			}
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x001374DD File Offset: 0x001356DD
		public void HoverStart()
		{
			if (!this.Button.interactable)
			{
				return;
			}
			this.SetHoverIndicator(true);
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x001374F4 File Offset: 0x001356F4
		public void HoverEnd()
		{
			if (!this.Button.interactable)
			{
				return;
			}
			this.SetHoverIndicator(false);
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x0013750B File Offset: 0x0013570B
		public void Clicked()
		{
			if (this.OnSelected != null)
			{
				this.OnSelected.Invoke();
			}
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x00137520 File Offset: 0x00135720
		public void SetHoverIndicator(bool shown)
		{
			WindowSelectorButton.<>c__DisplayClass13_0 CS$<>8__locals1 = new WindowSelectorButton.<>c__DisplayClass13_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.shown = shown;
			if (this.hoverRoutine != null)
			{
				base.StopCoroutine(this.hoverRoutine);
			}
			this.hoverRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SetHoverIndicator>g__Routine|0());
		}

		// Token: 0x0400377B RID: 14203
		public const float SELECTION_INDICATOR_SCALE = 1.1f;

		// Token: 0x0400377C RID: 14204
		public const float INDICATOR_LERP_TIME = 0.075f;

		// Token: 0x0400377D RID: 14205
		public UnityEvent OnSelected;

		// Token: 0x0400377E RID: 14206
		public EDealWindow WindowType;

		// Token: 0x0400377F RID: 14207
		[Header("References")]
		public Button Button;

		// Token: 0x04003780 RID: 14208
		public GameObject InactiveOverlay;

		// Token: 0x04003781 RID: 14209
		public RectTransform HoverIndicator;

		// Token: 0x04003782 RID: 14210
		private Coroutine hoverRoutine;
	}
}
