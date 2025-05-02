using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000ADA RID: 2778
	public class ClipboardScreen : MonoBehaviour
	{
		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06004A83 RID: 19075 RVA: 0x00138E37 File Offset: 0x00137037
		// (set) Token: 0x06004A84 RID: 19076 RVA: 0x00138E3F File Offset: 0x0013703F
		public bool IsOpen { get; protected set; }

		// Token: 0x06004A85 RID: 19077 RVA: 0x00138E48 File Offset: 0x00137048
		protected virtual void Start()
		{
			if (this.OpenOnStart)
			{
				this.IsOpen = true;
				this.Container.anchoredPosition = new Vector2(0f, this.Container.anchoredPosition.y);
			}
			else
			{
				this.IsOpen = false;
				this.Container.anchoredPosition = new Vector2(this.ClosedOffset, this.Container.anchoredPosition.y);
				this.Container.gameObject.SetActive(false);
			}
			if (this.UseExitListener)
			{
				GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), this.ExitActionPriority);
			}
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x00138EE8 File Offset: 0x001370E8
		private void Exit(ExitAction exitAction)
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (exitAction.used)
			{
				return;
			}
			exitAction.used = true;
			this.Close();
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x00138F09 File Offset: 0x00137109
		public virtual void Open()
		{
			this.Container.gameObject.SetActive(true);
			this.IsOpen = true;
			this.Lerp(true, null);
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x00138F2B File Offset: 0x0013712B
		public virtual void Close()
		{
			this.IsOpen = false;
			this.Lerp(false, delegate
			{
				this.Container.gameObject.SetActive(false);
			});
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x00138F48 File Offset: 0x00137148
		private void Lerp(bool open, Action callback)
		{
			ClipboardScreen.<>c__DisplayClass14_0 CS$<>8__locals1 = new ClipboardScreen.<>c__DisplayClass14_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.open = open;
			CS$<>8__locals1.callback = callback;
			if (this.lerpRoutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.lerpRoutine);
			}
			this.lerpRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<Lerp>g__Routine|0());
		}

		// Token: 0x040037D6 RID: 14294
		[Header("References")]
		public RectTransform Container;

		// Token: 0x040037D7 RID: 14295
		[Header("Settings")]
		public float ClosedOffset = 420f;

		// Token: 0x040037D8 RID: 14296
		public bool OpenOnStart;

		// Token: 0x040037D9 RID: 14297
		public bool UseExitListener = true;

		// Token: 0x040037DA RID: 14298
		public int ExitActionPriority = 10;

		// Token: 0x040037DB RID: 14299
		private Coroutine lerpRoutine;
	}
}
