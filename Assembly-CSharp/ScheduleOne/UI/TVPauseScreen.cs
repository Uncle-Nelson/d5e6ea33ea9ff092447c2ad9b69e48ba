using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.TV;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009BB RID: 2491
	public class TVPauseScreen : MonoBehaviour
	{
		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x00119B1B File Offset: 0x00117D1B
		// (set) Token: 0x06004334 RID: 17204 RVA: 0x00119B23 File Offset: 0x00117D23
		public bool IsPaused { get; private set; }

		// Token: 0x06004335 RID: 17205 RVA: 0x00119B2C File Offset: 0x00117D2C
		private void Awake()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00119B40 File Offset: 0x00117D40
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsPaused)
			{
				return;
			}
			if (!this.App.IsOpen)
			{
				return;
			}
			action.used = true;
			this.Back();
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x00119B6F File Offset: 0x00117D6F
		public void Pause()
		{
			this.IsPaused = true;
			base.gameObject.SetActive(true);
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x00119B84 File Offset: 0x00117D84
		public void Resume()
		{
			this.IsPaused = false;
			base.gameObject.SetActive(false);
			this.App.Resume();
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x00119BA4 File Offset: 0x00117DA4
		public void Back()
		{
			this.App.Close();
		}

		// Token: 0x040030D5 RID: 12501
		public TVApp App;
	}
}
