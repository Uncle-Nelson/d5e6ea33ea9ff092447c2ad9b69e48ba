using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B1F RID: 2847
	public class MainMenuScreen : MonoBehaviour
	{
		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x0013EC03 File Offset: 0x0013CE03
		// (set) Token: 0x06004BE5 RID: 19429 RVA: 0x0013EC0B File Offset: 0x0013CE0B
		public bool IsOpen { get; protected set; }

		// Token: 0x06004BE6 RID: 19430 RVA: 0x0013EC14 File Offset: 0x0013CE14
		protected virtual void Awake()
		{
			this.Rect = base.GetComponent<RectTransform>();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), this.ExitInputPriority);
			if (this.OpenOnStart)
			{
				this.Group.alpha = 1f;
				this.Rect.localScale = new Vector3(1f, 1f, 1f);
				base.gameObject.SetActive(true);
				this.IsOpen = true;
			}
			else
			{
				this.Group.alpha = 0f;
				this.Rect.localScale = new Vector3(1.25f, 1.25f, 1.25f);
				base.gameObject.SetActive(false);
				this.IsOpen = false;
			}
			if (this.OpenOnStart)
			{
				Singleton<MusicPlayer>.Instance.SetTrackEnabled("Main Menu", true);
			}
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x0013ECEB File Offset: 0x0013CEEB
		private void OnDestroy()
		{
			if (Singleton<MusicPlayer>.Instance != null)
			{
				Singleton<MusicPlayer>.Instance.SetTrackEnabled("Main Menu", false);
			}
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x0013ED0A File Offset: 0x0013CF0A
		protected virtual void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (action.exitType == ExitType.RightClick)
			{
				return;
			}
			if (this.PreviousScreen == null)
			{
				return;
			}
			if (this.IsOpen)
			{
				this.Close(true);
				action.used = true;
			}
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x0013ED43 File Offset: 0x0013CF43
		public virtual void Open(bool closePrevious)
		{
			this.IsOpen = true;
			this.Lerp(true);
			if (closePrevious && this.PreviousScreen != null)
			{
				this.PreviousScreen.Close(false);
			}
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x0013ED70 File Offset: 0x0013CF70
		public virtual void Close(bool openPrevious)
		{
			this.IsOpen = false;
			this.Lerp(false);
			if (openPrevious && this.PreviousScreen != null)
			{
				this.PreviousScreen.Open(false);
			}
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x0013EDA0 File Offset: 0x0013CFA0
		private void Lerp(bool open)
		{
			MainMenuScreen.<>c__DisplayClass17_0 CS$<>8__locals1 = new MainMenuScreen.<>c__DisplayClass17_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.open = open;
			if (this.lerpRoutine != null)
			{
				base.StopCoroutine(this.lerpRoutine);
			}
			if (CS$<>8__locals1.open)
			{
				base.gameObject.SetActive(true);
			}
			if (this.Rect == null)
			{
				this.Rect = base.GetComponent<RectTransform>();
			}
			this.lerpRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<Lerp>g__Routine|0());
		}

		// Token: 0x040038E3 RID: 14563
		public const float LERP_TIME = 0.075f;

		// Token: 0x040038E4 RID: 14564
		public const float LERP_SCALE = 1.25f;

		// Token: 0x040038E6 RID: 14566
		[Header("Settings")]
		public int ExitInputPriority;

		// Token: 0x040038E7 RID: 14567
		public bool OpenOnStart;

		// Token: 0x040038E8 RID: 14568
		[Header("References")]
		public MainMenuScreen PreviousScreen;

		// Token: 0x040038E9 RID: 14569
		public CanvasGroup Group;

		// Token: 0x040038EA RID: 14570
		private RectTransform Rect;

		// Token: 0x040038EB RID: 14571
		private Coroutine lerpRoutine;
	}
}
