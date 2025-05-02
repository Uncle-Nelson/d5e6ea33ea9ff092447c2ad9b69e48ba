using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A35 RID: 2613
	public class StaminaBar : MonoBehaviour
	{
		// Token: 0x06004679 RID: 18041 RVA: 0x00127DFE File Offset: 0x00125FFE
		private void Awake()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
			this.Group.alpha = 0f;
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x00127E30 File Offset: 0x00126030
		private void PlayerSpawned()
		{
			PlayerMovement instance = PlayerSingleton<PlayerMovement>.Instance;
			instance.onStaminaReserveChanged = (Action<float>)Delegate.Combine(instance.onStaminaReserveChanged, new Action<float>(this.UpdateStaminaBar));
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x00127E58 File Offset: 0x00126058
		private void UpdateStaminaBar(float change)
		{
			if (!PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				return;
			}
			Slider[] sliders = this.Sliders;
			for (int i = 0; i < sliders.Length; i++)
			{
				sliders[i].value = PlayerSingleton<PlayerMovement>.Instance.CurrentStaminaReserve / PlayerMovement.StaminaReserveMax;
			}
			this.Group.alpha = 1f;
			if (this.routine != null)
			{
				base.StopCoroutine(this.routine);
			}
			this.routine = base.StartCoroutine(this.<UpdateStaminaBar>g__Routine|7_0());
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x00127ED0 File Offset: 0x001260D0
		[CompilerGenerated]
		private IEnumerator <UpdateStaminaBar>g__Routine|7_0()
		{
			yield return new WaitForSeconds(1.5f);
			for (float i = 0f; i < 0.5f; i += Time.deltaTime)
			{
				this.Group.alpha = Mathf.Lerp(1f, 0f, i / 0.5f);
				yield return new WaitForEndOfFrame();
			}
			this.Group.alpha = 0f;
			this.routine = null;
			yield break;
		}

		// Token: 0x0400340C RID: 13324
		public const float StaminaShowTime = 1.5f;

		// Token: 0x0400340D RID: 13325
		public const float StaminaFadeTime = 0.5f;

		// Token: 0x0400340E RID: 13326
		[Header("References")]
		public Slider[] Sliders;

		// Token: 0x0400340F RID: 13327
		public CanvasGroup Group;

		// Token: 0x04003410 RID: 13328
		private Coroutine routine;
	}
}
