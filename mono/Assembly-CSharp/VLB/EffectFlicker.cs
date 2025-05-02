using System;
using System.Collections;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000F3 RID: 243
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-flicker/")]
	public class EffectFlicker : EffectAbstractBase
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x00015E34 File Offset: 0x00014034
		public override void InitFrom(EffectAbstractBase source)
		{
			base.InitFrom(source);
			EffectFlicker effectFlicker = source as EffectFlicker;
			if (effectFlicker)
			{
				this.frequency = effectFlicker.frequency;
				this.performPauses = effectFlicker.performPauses;
				this.flickeringDuration = effectFlicker.flickeringDuration;
				this.pauseDuration = effectFlicker.pauseDuration;
				this.restoreIntensityOnPause = effectFlicker.restoreIntensityOnPause;
				this.intensityAmplitude = effectFlicker.intensityAmplitude;
				this.smoothing = effectFlicker.smoothing;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00015EAB File Offset: 0x000140AB
		protected override void OnEnable()
		{
			base.OnEnable();
			base.StartCoroutine(this.CoUpdate());
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00015EC0 File Offset: 0x000140C0
		private IEnumerator CoUpdate()
		{
			for (;;)
			{
				yield return this.CoFlicker();
				if (this.performPauses)
				{
					yield return this.CoChangeIntensity(this.pauseDuration.randomValue, this.restoreIntensityOnPause ? 0f : this.m_CurrentAdditiveIntensity);
				}
			}
			yield break;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00015ECF File Offset: 0x000140CF
		private IEnumerator CoFlicker()
		{
			float remainingDuration = this.flickeringDuration.randomValue;
			float deltaTime = Time.deltaTime;
			while (!this.performPauses || remainingDuration > 0f)
			{
				float freqDuration = 1f / this.frequency;
				yield return this.CoChangeIntensity(freqDuration, this.intensityAmplitude.randomValue);
				remainingDuration -= freqDuration;
			}
			yield break;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00015EDE File Offset: 0x000140DE
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			float velocity = 0f;
			float t = 0f;
			while (t < expectedDuration)
			{
				this.m_CurrentAdditiveIntensity = Mathf.SmoothDamp(this.m_CurrentAdditiveIntensity, nextIntensity, ref velocity, this.smoothing);
				base.SetAdditiveIntensity(this.m_CurrentAdditiveIntensity);
				t += Time.deltaTime;
				yield return null;
			}
			yield break;
		}

		// Token: 0x04000562 RID: 1378
		public new const string ClassName = "EffectFlicker";

		// Token: 0x04000563 RID: 1379
		[Range(1f, 60f)]
		public float frequency = 10f;

		// Token: 0x04000564 RID: 1380
		public bool performPauses;

		// Token: 0x04000565 RID: 1381
		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat flickeringDuration = Consts.Effects.FlickeringDurationDefault;

		// Token: 0x04000566 RID: 1382
		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat pauseDuration = Consts.Effects.PauseDurationDefault;

		// Token: 0x04000567 RID: 1383
		public bool restoreIntensityOnPause;

		// Token: 0x04000568 RID: 1384
		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude = Consts.Effects.IntensityAmplitudeDefault;

		// Token: 0x04000569 RID: 1385
		[Range(0f, 0.25f)]
		public float smoothing = 0.05f;

		// Token: 0x0400056A RID: 1386
		private float m_CurrentAdditiveIntensity;
	}
}
