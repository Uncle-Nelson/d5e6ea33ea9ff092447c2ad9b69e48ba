using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.Settings
{
	// Token: 0x02000A7E RID: 2686
	public class Keybinder : MonoBehaviour
	{
		// Token: 0x06004856 RID: 18518 RVA: 0x0012FC82 File Offset: 0x0012DE82
		private void Awake()
		{
			RebindActionUI rebindActionUI = this.rebindActionUI;
			rebindActionUI.onRebind = (Action)Delegate.Combine(rebindActionUI.onRebind, new Action(this.OnRebind));
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x0012FCAC File Offset: 0x0012DEAC
		private void Start()
		{
			Settings instance = Singleton<Settings>.Instance;
			instance.onInputsApplied = (Action)Delegate.Remove(instance.onInputsApplied, new Action(this.OnSettingsApplied));
			Settings instance2 = Singleton<Settings>.Instance;
			instance2.onInputsApplied = (Action)Delegate.Combine(instance2.onInputsApplied, new Action(this.OnSettingsApplied));
			this.rebindActionUI.UpdateBindingDisplay();
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x0012FD10 File Offset: 0x0012DF10
		private void OnDestroy()
		{
			if (this.rebindActionUI != null)
			{
				RebindActionUI rebindActionUI = this.rebindActionUI;
				rebindActionUI.onRebind = (Action)Delegate.Remove(rebindActionUI.onRebind, new Action(this.OnRebind));
			}
			if (Singleton<Settings>.InstanceExists)
			{
				Settings instance = Singleton<Settings>.Instance;
				instance.onInputsApplied = (Action)Delegate.Remove(instance.onInputsApplied, new Action(this.OnSettingsApplied));
			}
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x0012FD7F File Offset: 0x0012DF7F
		private void OnRebind()
		{
			base.StartCoroutine(Keybinder.<OnRebind>g__ApplySettings|4_0());
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x0012FD8D File Offset: 0x0012DF8D
		private void OnSettingsApplied()
		{
			this.rebindActionUI.UpdateBindingDisplay();
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x0012FD9A File Offset: 0x0012DF9A
		[CompilerGenerated]
		internal static IEnumerator <OnRebind>g__ApplySettings|4_0()
		{
			yield return new WaitForEndOfFrame();
			Singleton<Settings>.Instance.WriteInputSettings(Singleton<Settings>.Instance.InputSettings);
			Singleton<Settings>.Instance.ApplyInputSettings(Singleton<Settings>.Instance.ReadInputSettings());
			yield break;
		}

		// Token: 0x04003598 RID: 13720
		public RebindActionUI rebindActionUI;
	}
}
