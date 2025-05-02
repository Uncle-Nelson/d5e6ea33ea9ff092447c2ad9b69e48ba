using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000A9E RID: 2718
	public class CallNotification : Singleton<CallNotification>
	{
		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06004923 RID: 18723 RVA: 0x00132B2C File Offset: 0x00130D2C
		// (set) Token: 0x06004924 RID: 18724 RVA: 0x00132B34 File Offset: 0x00130D34
		public PhoneCallData ActiveCallData { get; private set; }

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x00132B3D File Offset: 0x00130D3D
		// (set) Token: 0x06004926 RID: 18726 RVA: 0x00132B45 File Offset: 0x00130D45
		public bool IsOpen { get; protected set; }

		// Token: 0x06004927 RID: 18727 RVA: 0x00132B50 File Offset: 0x00130D50
		protected override void Awake()
		{
			base.Awake();
			this.Group.alpha = 0f;
			this.Container.anchoredPosition = new Vector2(-600f, 0f);
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00132BA0 File Offset: 0x00130DA0
		public void SetIsOpen(bool visible, CallerID caller)
		{
			CallNotification.<>c__DisplayClass14_0 CS$<>8__locals1 = new CallNotification.<>c__DisplayClass14_0();
			CS$<>8__locals1.visible = visible;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.caller = caller;
			this.IsOpen = CS$<>8__locals1.visible;
			if (this.slideRoutine != null)
			{
				base.StopCoroutine(this.slideRoutine);
			}
			this.slideRoutine = base.StartCoroutine(CS$<>8__locals1.<SetIsOpen>g__Routine|0());
		}

		// Token: 0x0400363E RID: 13886
		public const float TIME_PER_CHAR = 0.015f;

		// Token: 0x04003641 RID: 13889
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04003642 RID: 13890
		public Image ProfilePicture;

		// Token: 0x04003643 RID: 13891
		public CanvasGroup Group;

		// Token: 0x04003644 RID: 13892
		private Coroutine slideRoutine;
	}
}
