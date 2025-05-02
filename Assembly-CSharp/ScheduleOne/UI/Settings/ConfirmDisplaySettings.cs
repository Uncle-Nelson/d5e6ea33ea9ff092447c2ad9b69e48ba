using System;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A77 RID: 2679
	public class ConfirmDisplaySettings : MonoBehaviour
	{
		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x0012F844 File Offset: 0x0012DA44
		public bool IsOpen
		{
			get
			{
				return this != null && base.gameObject != null && base.gameObject.activeSelf;
			}
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x0012F86A File Offset: 0x0012DA6A
		public void Awake()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 6);
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x0012F88A File Offset: 0x0012DA8A
		public void Open(DisplaySettings _oldSettings, DisplaySettings _newSettings)
		{
			base.gameObject.SetActive(true);
			this.oldSettings = _oldSettings;
			this.newSettings = _newSettings;
			this.timeUntilRevert = 15f;
			this.Update();
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x0012F8B7 File Offset: 0x0012DAB7
		public void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.Close(true);
			}
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x0012F8E4 File Offset: 0x0012DAE4
		public void Update()
		{
			this.timeUntilRevert -= Time.unscaledDeltaTime;
			this.SubtitleLabel.text = string.Format("Reverting in {0:0.0} seconds", this.timeUntilRevert);
			if (this.timeUntilRevert <= 0f)
			{
				this.Close(true);
			}
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x0012F938 File Offset: 0x0012DB38
		public void Close(bool revert)
		{
			if (revert)
			{
				Singleton<Settings>.Instance.ApplyDisplaySettings(this.oldSettings);
				Singleton<Settings>.Instance.DisplaySettings = this.oldSettings;
				Singleton<Settings>.Instance.UnappliedDisplaySettings = this.oldSettings;
			}
			else
			{
				Singleton<Settings>.Instance.WriteDisplaySettings(this.newSettings);
			}
			base.transform.parent.gameObject.SetActive(false);
			base.transform.parent.gameObject.SetActive(true);
			base.gameObject.SetActive(false);
		}

		// Token: 0x0400358E RID: 13710
		public const float RevertTime = 15f;

		// Token: 0x0400358F RID: 13711
		public TextMeshProUGUI SubtitleLabel;

		// Token: 0x04003590 RID: 13712
		private float timeUntilRevert;

		// Token: 0x04003591 RID: 13713
		private DisplaySettings oldSettings;

		// Token: 0x04003592 RID: 13714
		private DisplaySettings newSettings;
	}
}
