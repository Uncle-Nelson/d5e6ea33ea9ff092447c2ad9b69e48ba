using System;
using System.Collections;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Tooltips;
using UnityEngine;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000A99 RID: 2713
	public class AppsCanvas : PlayerSingleton<AppsCanvas>
	{
		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060048F9 RID: 18681 RVA: 0x001321C9 File Offset: 0x001303C9
		// (set) Token: 0x060048FA RID: 18682 RVA: 0x001321D1 File Offset: 0x001303D1
		public bool isOpen { get; private set; }

		// Token: 0x060048FB RID: 18683 RVA: 0x001321DA File Offset: 0x001303DA
		protected override void Awake()
		{
			base.Awake();
			this.SetIsOpen(false);
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x001321EC File Offset: 0x001303EC
		public override void OnStartClient(bool IsOwner)
		{
			base.OnStartClient(IsOwner);
			if (!IsOwner)
			{
				return;
			}
			Phone instance = PlayerSingleton<Phone>.Instance;
			instance.onPhoneOpened = (Action)Delegate.Combine(instance.onPhoneOpened, new Action(this.PhoneOpened));
			Phone instance2 = PlayerSingleton<Phone>.Instance;
			instance2.onPhoneClosed = (Action)Delegate.Combine(instance2.onPhoneClosed, new Action(this.PhoneClosed));
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x00132250 File Offset: 0x00130450
		protected void PhoneOpened()
		{
			if (this.isOpen)
			{
				this.SetCanvasActive(true);
			}
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00132261 File Offset: 0x00130461
		protected void PhoneClosed()
		{
			this.delayedSetOpenRoutine = base.StartCoroutine(this.DelayedSetCanvasActive(false, 0.25f));
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x0013227B File Offset: 0x0013047B
		private IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			yield return new WaitForSeconds(delay);
			this.delayedSetOpenRoutine = null;
			this.SetCanvasActive(active);
			yield break;
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x00132298 File Offset: 0x00130498
		public void SetIsOpen(bool o)
		{
			this.isOpen = o;
			this.SetCanvasActive(o);
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x001322A8 File Offset: 0x001304A8
		private void SetCanvasActive(bool a)
		{
			if (this.delayedSetOpenRoutine != null)
			{
				base.StopCoroutine(this.delayedSetOpenRoutine);
			}
			this.canvas.enabled = a;
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x001322CA File Offset: 0x001304CA
		protected override void Start()
		{
			base.Start();
			Singleton<TooltipManager>.Instance.AddCanvas(this.canvas);
		}

		// Token: 0x0400361B RID: 13851
		[Header("References")]
		public Canvas canvas;

		// Token: 0x0400361C RID: 13852
		private Coroutine delayedSetOpenRoutine;
	}
}
