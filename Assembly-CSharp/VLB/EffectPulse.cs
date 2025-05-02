using System;
using System.Collections;
using UnityEngine;

namespace VLB
{
	// Token: 0x020000F8 RID: 248
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-pulse/")]
	public class EffectPulse : EffectAbstractBase
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x0001623C File Offset: 0x0001443C
		public override void InitFrom(EffectAbstractBase source)
		{
			base.InitFrom(source);
			EffectPulse effectPulse = source as EffectPulse;
			if (effectPulse)
			{
				this.frequency = effectPulse.frequency;
				this.intensityAmplitude = effectPulse.intensityAmplitude;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00016277 File Offset: 0x00014477
		protected override void OnEnable()
		{
			base.OnEnable();
			base.StartCoroutine(this.CoUpdate());
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0001628C File Offset: 0x0001448C
		private IEnumerator CoUpdate()
		{
			float t = 0f;
			for (;;)
			{
				float num = Mathf.Sin(this.frequency * t);
				float lerpedValue = this.intensityAmplitude.GetLerpedValue(num * 0.5f + 0.5f);
				base.SetAdditiveIntensity(lerpedValue);
				yield return null;
				t += Time.deltaTime;
			}
			yield break;
		}

		// Token: 0x0400057D RID: 1405
		public new const string ClassName = "EffectPulse";

		// Token: 0x0400057E RID: 1406
		[Range(0.1f, 60f)]
		public float frequency = 10f;

		// Token: 0x0400057F RID: 1407
		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude = Consts.Effects.IntensityAmplitudeDefault;
	}
}
