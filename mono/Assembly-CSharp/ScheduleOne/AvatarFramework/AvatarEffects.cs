using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x0200095D RID: 2397
	public class AvatarEffects : MonoBehaviour
	{
		// Token: 0x06004111 RID: 16657 RVA: 0x00111770 File Offset: 0x0010F970
		private void Start()
		{
			this.AdditionalWeightController.Initialize();
			this.AdditionalWeightController.SetDefault(0f);
			this.AdditionalGenderController.Initialize();
			this.AdditionalGenderController.SetDefault(0f);
			this.HeadSizeBoost.Initialize();
			this.HeadSizeBoost.SetDefault(0f);
			this.NeckSizeBoost.Initialize();
			this.NeckSizeBoost.SetDefault(0f);
			this.SkinColorSmoother.Initialize();
			if (this.Avatar.CurrentSettings != null)
			{
				this.SetDefaultSkinColor(true);
			}
			this.ZapLoopSound.VolumeMultiplier = 0f;
			this.Avatar.onSettingsLoaded.AddListener(new UnityAction(delegate()
			{
				this.SetDefaultSkinColor(true);
			}));
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0011183C File Offset: 0x0010FA3C
		public void FixedUpdate()
		{
			this.SetEffectsCulled(this.Avatar.Anim.IsAvatarCulled);
			if (!this.Avatar.Anim.enabled)
			{
				return;
			}
			if (this.Avatar.Anim.IsAvatarCulled)
			{
				return;
			}
			this.Avatar.SetAdditionalWeight(this.AdditionalWeightController.CurrentValue);
			this.Avatar.SetAdditionalGender(this.AdditionalGenderController.CurrentValue);
			this.Avatar.SetSkinColor(this.SkinColorSmoother.CurrentValue);
			this.currentEmission = Color.Lerp(this.currentEmission, this.targetEmission, Time.deltaTime * 0.5f);
			this.Avatar.SetEmission(this.currentEmission);
			if (this.DisableHead)
			{
				this.HeadBone.transform.localScale = Vector3.zero;
			}
			else
			{
				this.HeadBone.transform.localScale = Vector3.one * (1f + this.HeadSizeBoost.CurrentValue);
			}
			this.NeckBone.transform.localScale = Vector3.one * (1f + this.NeckSizeBoost.CurrentValue);
			if (this.FireParticles.isPlaying)
			{
				this.FireSound.VolumeMultiplier = Mathf.MoveTowards(this.FireSound.VolumeMultiplier, 1f, Time.deltaTime);
				if (!this.FireSound.isPlaying)
				{
					this.FireSound.Play();
				}
			}
			else
			{
				this.FireSound.VolumeMultiplier = Mathf.MoveTowards(this.FireSound.VolumeMultiplier, 0f, Time.deltaTime);
				if (this.FireSound.VolumeMultiplier <= 0f)
				{
					this.FireSound.Stop();
				}
			}
			if (this.ZapParticles.isPlaying)
			{
				this.ZapLoopSound.VolumeMultiplier = Mathf.MoveTowards(this.ZapLoopSound.VolumeMultiplier, 1f, Time.deltaTime * 2f);
				if (!this.ZapLoopSound.isPlaying)
				{
					this.ZapLoopSound.Play();
					return;
				}
			}
			else
			{
				this.ZapLoopSound.VolumeMultiplier = Mathf.MoveTowards(this.ZapLoopSound.VolumeMultiplier, 0f, Time.deltaTime * 2f);
				if (this.ZapLoopSound.VolumeMultiplier <= 0f)
				{
					this.ZapLoopSound.Stop();
				}
			}
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x00111A98 File Offset: 0x0010FC98
		private void SetEffectsCulled(bool culled)
		{
			if (this.isCulled == culled)
			{
				return;
			}
			this.isCulled = culled;
			GameObject[] objectsToCull = this.ObjectsToCull;
			for (int i = 0; i < objectsToCull.Length; i++)
			{
				objectsToCull[i].SetActive(!culled);
			}
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x00111AD8 File Offset: 0x0010FCD8
		public void SetStinkParticlesActive(bool active, bool mirror = true)
		{
			foreach (ParticleSystem particleSystem in this.StinkParticles)
			{
				if (active)
				{
					particleSystem.Play();
				}
				else
				{
					particleSystem.Stop();
				}
			}
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetStinkParticlesActive(active, false);
				}
			}
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x00111B34 File Offset: 0x0010FD34
		public void TriggerSick(bool mirror = true)
		{
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].TriggerSick(false);
				}
			}
			base.StartCoroutine(this.<TriggerSick>g__Routine|36_0());
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x00111B70 File Offset: 0x0010FD70
		public void SetAntiGrav(bool active, bool mirror = true)
		{
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetAntiGrav(active, false);
				}
			}
			if (active)
			{
				this.AntiGravParticles.Play();
				return;
			}
			this.AntiGravParticles.Stop();
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00111BBC File Offset: 0x0010FDBC
		public void SetFoggy(bool active, bool mirror = true)
		{
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetFoggy(active, false);
				}
			}
			if (active)
			{
				this.FoggyEffects.Play();
				return;
			}
			this.FoggyEffects.Stop();
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x00111C08 File Offset: 0x0010FE08
		public void VanishHair(bool mirror = true)
		{
			this.HeadPoofParticles.Play();
			this.PoofSound.Play();
			this.Avatar.SetHairVisible(false);
			this.Avatar.EyeBrows.leftBrow.gameObject.SetActive(false);
			this.Avatar.EyeBrows.rightBrow.gameObject.SetActive(false);
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].VanishHair(false);
				}
			}
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x00111C90 File Offset: 0x0010FE90
		public void SetZapped(bool zapped, bool mirror = true)
		{
			if (zapped)
			{
				LayerUtility.SetLayerRecursively(this.ZapParticles.gameObject, LayerMask.NameToLayer("Default"));
				this.ZapParticles.Play();
				this.ZapSound.Play();
			}
			else
			{
				this.ZapParticles.Stop();
				this.ZapSound.Stop();
			}
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetZapped(zapped, false);
				}
			}
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00111D0C File Offset: 0x0010FF0C
		public void ReturnHair(bool mirror = true)
		{
			this.HeadPoofParticles.Play();
			this.PoofSound.Play();
			this.Avatar.SetHairVisible(true);
			this.Avatar.EyeBrows.leftBrow.gameObject.SetActive(true);
			this.Avatar.EyeBrows.rightBrow.gameObject.SetActive(true);
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].ReturnHair(false);
				}
			}
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x00111D94 File Offset: 0x0010FF94
		public void OverrideHairColor(Color color, bool mirror = true)
		{
			this.HeadPoofParticles.Play();
			this.PoofSound.Play();
			this.Avatar.OverrideHairColor(color);
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].OverrideHairColor(color, false);
				}
			}
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00111DE8 File Offset: 0x0010FFE8
		public void ResetHairColor(bool mirror = true)
		{
			this.HeadPoofParticles.Play();
			this.PoofSound.Play();
			this.Avatar.ResetHairColor();
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].ResetHairColor(false);
				}
			}
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00111E38 File Offset: 0x00110038
		public void OverrideEyeColor(Color color, float emission = 0.115f, bool mirror = true)
		{
			this.Avatar.Eyes.rightEye.SetEyeballColor(color, emission, false);
			this.Avatar.Eyes.leftEye.SetEyeballColor(color, emission, false);
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].OverrideEyeColor(color, emission, false);
				}
			}
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00111E98 File Offset: 0x00110098
		public void ResetEyeColor(bool mirror = true)
		{
			this.Avatar.Eyes.rightEye.ResetEyeballColor();
			this.Avatar.Eyes.leftEye.ResetEyeballColor();
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].ResetEyeColor(false);
				}
			}
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00111EF0 File Offset: 0x001100F0
		public void SetEyeLightEmission(float intensity, Color color, bool mirror = true)
		{
			this.Avatar.Eyes.rightEye.ConfigureEyeLight(color, intensity);
			this.Avatar.Eyes.leftEye.ConfigureEyeLight(color, intensity);
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetEyeLightEmission(intensity, color, false);
				}
			}
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x00111F50 File Offset: 0x00110150
		public void EnableLaxative(bool mirror = true)
		{
			this.laxativeEnabled = true;
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].EnableLaxative(false);
				}
			}
			Singleton<CoroutineService>.Instance.StartCoroutine(this.<EnableLaxative>g__Routine|47_0());
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x00111F98 File Offset: 0x00110198
		public void DisableLaxative(bool mirror = true)
		{
			this.laxativeEnabled = false;
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].DisableLaxative(false);
				}
			}
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00111FD0 File Offset: 0x001101D0
		public void SetFireActive(bool active, bool mirror = true)
		{
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetFireActive(active, false);
				}
			}
			this.FireLight.Enabled = active;
			if (active)
			{
				this.FireParticles.Play();
				return;
			}
			this.FireParticles.Stop();
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x00112028 File Offset: 0x00110228
		public void SetBigHeadActive(bool active, bool mirror = true)
		{
			if (active)
			{
				this.HeadSizeBoost.AddOverride(0.4f, 7, "big head");
			}
			else
			{
				this.HeadSizeBoost.RemoveOverride("big head");
			}
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetBigHeadActive(active, false);
				}
			}
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x00112084 File Offset: 0x00110284
		public void SetGiraffeActive(bool active, bool mirror = true)
		{
			if (active)
			{
				this.HeadSizeBoost.AddOverride(-0.5f, 8, "giraffe");
				this.NeckSizeBoost.AddOverride(1f, 8, "giraffe");
			}
			else
			{
				this.HeadSizeBoost.RemoveOverride("giraffe");
				this.NeckSizeBoost.RemoveOverride("giraffe");
			}
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetGiraffeActive(active, false);
				}
			}
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00112104 File Offset: 0x00110304
		public void SetSkinColorInverted(bool inverted, bool mirror = true)
		{
			if (inverted)
			{
				if (this.Avatar.IsWhite())
				{
					this.SkinColorSmoother.AddOverride(new Color32(58, 49, 42, byte.MaxValue), 7, "inverted");
				}
				else
				{
					this.SkinColorSmoother.AddOverride(new Color32(223, 189, 161, byte.MaxValue), 7, "inverted");
				}
			}
			else
			{
				this.SkinColorSmoother.RemoveOverride("inverted");
			}
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetSkinColorInverted(inverted, false);
				}
			}
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x001121AC File Offset: 0x001103AC
		public void SetSicklySkinColor(bool mirror = true)
		{
			Color skinColor = this.Avatar.CurrentSettings.SkinColor;
			float num = 0.5f;
			float num2 = 0.3f * skinColor.r + 0.59f * skinColor.g + 0.11f * skinColor.b;
			Color color = Color.white;
			color.r = skinColor.r + (num2 - skinColor.r) * num;
			color.g = skinColor.g + (num2 - skinColor.g) * num;
			color.b = skinColor.b + (num2 - skinColor.b) * num;
			color *= 1.1f;
			string str = "Sickly Color: ";
			Color color2 = color;
			Console.Log(str + color2.ToString(), null);
			this.SkinColorSmoother.AddOverride(color, 6, "sickly");
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetSicklySkinColor(false);
				}
			}
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x001122AC File Offset: 0x001104AC
		private void SetDefaultSkinColor(bool mirror = true)
		{
			if (this.Avatar.CurrentSettings == null)
			{
				return;
			}
			this.SkinColorSmoother.SetDefault(this.Avatar.CurrentSettings.SkinColor);
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetDefaultSkinColor(false);
				}
			}
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x0011230C File Offset: 0x0011050C
		public void SetGenderInverted(bool inverted, bool mirror = true)
		{
			if (inverted)
			{
				if (this.Avatar.IsMale())
				{
					this.AdditionalGenderController.AddOverride(1f, 7, "jennerising");
				}
				else
				{
					this.AdditionalGenderController.AddOverride(-1f, 7, "jennerising");
				}
			}
			else
			{
				this.AdditionalGenderController.RemoveOverride("jennerising");
			}
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetGenderInverted(inverted, false);
				}
			}
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x0011238C File Offset: 0x0011058C
		public void AddAdditionalWeightOverride(float value, int priority, string label, bool mirror = true)
		{
			this.AdditionalWeightController.AddOverride(value, priority, label);
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].AddAdditionalWeightOverride(value, priority, label, false);
				}
			}
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x001123CC File Offset: 0x001105CC
		public void RemoveAdditionalWeightOverride(string label, bool mirror = true)
		{
			this.AdditionalWeightController.RemoveOverride(label);
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].RemoveAdditionalWeightOverride(label, false);
				}
			}
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00112408 File Offset: 0x00110608
		public void SetGlowingOn(Color color, bool mirror = true)
		{
			this.targetEmission = color;
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetGlowingOn(color, false);
				}
			}
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00112440 File Offset: 0x00110640
		public void SetGlowingOff(bool mirror = true)
		{
			this.targetEmission = Color.black;
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetGlowingOff(false);
				}
			}
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x0011247C File Offset: 0x0011067C
		public void TriggerCountdownExplosion(bool mirror = true)
		{
			this.CountdownExplosion.Trigger();
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].TriggerCountdownExplosion(false);
				}
			}
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x001124B8 File Offset: 0x001106B8
		public void StopCountdownExplosion(bool mirror = true)
		{
			this.CountdownExplosion.StopCountdown();
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].StopCountdownExplosion(false);
				}
			}
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x001124F4 File Offset: 0x001106F4
		public void SetCyclopean(bool enabled, bool mirror = true)
		{
			this.HeadPoofParticles.Play();
			this.PoofSound.Play();
			if (enabled)
			{
				this.Avatar.Eyes.rightEye.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
				this.Avatar.Eyes.rightEye.transform.localScale = new Vector3(1.2f, 1.2f, 1f);
				this.Avatar.Eyes.leftEye.gameObject.SetActive(false);
				this.Avatar.SetBlockEyeFaceLayers(true);
			}
			else
			{
				this.Avatar.Eyes.rightEye.transform.localRotation = Quaternion.Euler(0f, 22f, 0f);
				this.Avatar.Eyes.rightEye.transform.localScale = new Vector3(1f, 1f, 1f);
				this.Avatar.Eyes.leftEye.gameObject.SetActive(true);
				this.Avatar.SetBlockEyeFaceLayers(false);
			}
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetCyclopean(enabled, false);
				}
			}
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x0011264C File Offset: 0x0011084C
		public void SetZombified(bool zombified, bool mirror = true)
		{
			if (zombified)
			{
				this.SkinColorSmoother.AddOverride(new Color32(117, 122, 92, byte.MaxValue), 10, "Zombified");
				this.Avatar.Eyes.leftEye.PupilContainer.gameObject.SetActive(!zombified);
				this.Avatar.Eyes.rightEye.PupilContainer.gameObject.SetActive(!zombified);
				this.OverrideEyeColor(new Color32(159, 129, 129, byte.MaxValue), 0.115f, false);
				this.Avatar.EmotionManager.AddEmotionOverride("Zombie", "Zombified", 0f, 10);
			}
			else
			{
				this.SkinColorSmoother.RemoveOverride("Zombified");
				this.Avatar.Eyes.leftEye.PupilContainer.gameObject.SetActive(true);
				this.Avatar.Eyes.rightEye.PupilContainer.gameObject.SetActive(true);
				this.ResetEyeColor(false);
				this.Avatar.EmotionManager.RemoveEmotionOverride("Zombified");
			}
			if (mirror)
			{
				AvatarEffects[] mirrorEffectsTo = this.MirrorEffectsTo;
				for (int i = 0; i < mirrorEffectsTo.Length; i++)
				{
					mirrorEffectsTo[i].SetZombified(zombified, false);
				}
			}
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x001127CE File Offset: 0x001109CE
		[CompilerGenerated]
		private IEnumerator <TriggerSick>g__Routine|36_0()
		{
			this.GurgleSound.Play();
			yield return new WaitForSeconds(4.5f);
			this.VomitSound.Play();
			this.VomitParticles.gameObject.layer = LayerMask.NameToLayer("Default");
			this.VomitParticles.Play();
			yield break;
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x001127DD File Offset: 0x001109DD
		[CompilerGenerated]
		private IEnumerator <EnableLaxative>g__Routine|47_0()
		{
			do
			{
				this.FartParticles.Play();
				this.FartSound.Play();
				yield return new WaitForSeconds(Random.Range(3f, 20f));
			}
			while (this.laxativeEnabled);
			yield break;
		}

		// Token: 0x04002EAB RID: 11947
		[Header("References")]
		public Avatar Avatar;

		// Token: 0x04002EAC RID: 11948
		public ParticleSystem[] StinkParticles;

		// Token: 0x04002EAD RID: 11949
		public ParticleSystem VomitParticles;

		// Token: 0x04002EAE RID: 11950
		public ParticleSystem HeadPoofParticles;

		// Token: 0x04002EAF RID: 11951
		public ParticleSystem FartParticles;

		// Token: 0x04002EB0 RID: 11952
		public ParticleSystem AntiGravParticles;

		// Token: 0x04002EB1 RID: 11953
		public ParticleSystem FireParticles;

		// Token: 0x04002EB2 RID: 11954
		public OptimizedLight FireLight;

		// Token: 0x04002EB3 RID: 11955
		public ParticleSystem FoggyEffects;

		// Token: 0x04002EB4 RID: 11956
		public Transform HeadBone;

		// Token: 0x04002EB5 RID: 11957
		public Transform NeckBone;

		// Token: 0x04002EB6 RID: 11958
		public AvatarEffects[] MirrorEffectsTo;

		// Token: 0x04002EB7 RID: 11959
		public ParticleSystem ZapParticles;

		// Token: 0x04002EB8 RID: 11960
		public CountdownExplosion CountdownExplosion;

		// Token: 0x04002EB9 RID: 11961
		public GameObject[] ObjectsToCull;

		// Token: 0x04002EBA RID: 11962
		[Header("Settings")]
		public bool DisableHead;

		// Token: 0x04002EBB RID: 11963
		[Header("Sounds")]
		public AudioSourceController GurgleSound;

		// Token: 0x04002EBC RID: 11964
		public AudioSourceController VomitSound;

		// Token: 0x04002EBD RID: 11965
		public AudioSourceController PoofSound;

		// Token: 0x04002EBE RID: 11966
		public AudioSourceController FartSound;

		// Token: 0x04002EBF RID: 11967
		public AudioSourceController FireSound;

		// Token: 0x04002EC0 RID: 11968
		public AudioSourceController ZapSound;

		// Token: 0x04002EC1 RID: 11969
		public AudioSourceController ZapLoopSound;

		// Token: 0x04002EC2 RID: 11970
		[Header("Smoothers")]
		[SerializeField]
		private FloatSmoother AdditionalWeightController;

		// Token: 0x04002EC3 RID: 11971
		[SerializeField]
		private FloatSmoother AdditionalGenderController;

		// Token: 0x04002EC4 RID: 11972
		[SerializeField]
		private FloatSmoother HeadSizeBoost;

		// Token: 0x04002EC5 RID: 11973
		[SerializeField]
		private FloatSmoother NeckSizeBoost;

		// Token: 0x04002EC6 RID: 11974
		[SerializeField]
		private ColorSmoother SkinColorSmoother;

		// Token: 0x04002EC7 RID: 11975
		private bool laxativeEnabled;

		// Token: 0x04002EC8 RID: 11976
		private Color currentEmission = Color.black;

		// Token: 0x04002EC9 RID: 11977
		private Color targetEmission = Color.black;

		// Token: 0x04002ECA RID: 11978
		private bool isCulled;
	}
}
