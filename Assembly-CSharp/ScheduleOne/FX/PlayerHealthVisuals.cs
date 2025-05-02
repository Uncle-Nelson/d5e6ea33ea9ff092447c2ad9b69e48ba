using System;
using Beautify.Universal;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace ScheduleOne.FX
{
	// Token: 0x02000623 RID: 1571
	public class PlayerHealthVisuals : MonoBehaviour
	{
		// Token: 0x06002926 RID: 10534 RVA: 0x000A9AF4 File Offset: 0x000A7CF4
		private void Awake()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.Spawned));
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.Spawned));
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.MinPass));
			this.GlobalVolume.sharedProfile.TryGet<Beautify>(ref this._beautifySettings);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000A9BA4 File Offset: 0x000A7DA4
		private void Spawned()
		{
			if (!Player.Local.Owner.IsLocalClient)
			{
				return;
			}
			this.UpdateEffects(Player.Local.Health.CurrentHealth);
			Player.Local.Health.onHealthChanged.AddListener(new UnityAction<float>(this.UpdateEffects));
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000A9BF8 File Offset: 0x000A7DF8
		private void MinPass()
		{
			this._beautifySettings.vignettingOuterRing.value = this.OuterRingCurve.Evaluate(NetworkSingleton<TimeManager>.Instance.NormalizedTime);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000A9C20 File Offset: 0x000A7E20
		private void UpdateEffects(float newHealth)
		{
			this._beautifySettings.vignettingColor.value = new Color(this._beautifySettings.vignettingColor.value.r, this._beautifySettings.vignettingColor.value.g, this._beautifySettings.vignettingColor.value.b, Mathf.Lerp(this.VignetteAlpha_MinHealth, this.VignetteAlpha_MaxHealth, newHealth / 100f));
			this._beautifySettings.saturate.value = Mathf.Lerp(this.Saturation_MinHealth, this.Saturation_MaxHealth, newHealth / 100f);
			this._beautifySettings.chromaticAberrationIntensity.value = Mathf.Lerp(this.ChromAb_MinHealth, this.ChromAb_MaxHealth, newHealth / 100f);
			this._beautifySettings.lensDirtIntensity.value = Mathf.Lerp(this.LensDirt_MinHealth, this.LensDirt_MaxHealth, newHealth / 100f);
		}

		// Token: 0x04001E55 RID: 7765
		[Header("References")]
		public Volume GlobalVolume;

		// Token: 0x04001E56 RID: 7766
		[Header("Vignette")]
		public float VignetteAlpha_MaxHealth;

		// Token: 0x04001E57 RID: 7767
		public float VignetteAlpha_MinHealth;

		// Token: 0x04001E58 RID: 7768
		public AnimationCurve OuterRingCurve;

		// Token: 0x04001E59 RID: 7769
		[Header("Saturation")]
		public float Saturation_MaxHealth = 0.5f;

		// Token: 0x04001E5A RID: 7770
		public float Saturation_MinHealth = -2f;

		// Token: 0x04001E5B RID: 7771
		[Header("Chromatic Abberation")]
		public float ChromAb_MaxHealth;

		// Token: 0x04001E5C RID: 7772
		public float ChromAb_MinHealth = 0.02f;

		// Token: 0x04001E5D RID: 7773
		[Header("Lens Dirt")]
		public float LensDirt_MaxHealth;

		// Token: 0x04001E5E RID: 7774
		public float LensDirt_MinHealth = 1f;

		// Token: 0x04001E5F RID: 7775
		private Beautify _beautifySettings;
	}
}
