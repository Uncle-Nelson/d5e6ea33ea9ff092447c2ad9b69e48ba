using System;
using System.Collections;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A8 RID: 1448
	public class PoliceLight : MonoBehaviour
	{
		// Token: 0x060023E3 RID: 9187 RVA: 0x00091B73 File Offset: 0x0008FD73
		public void SetIsOn(bool isOn)
		{
			this.IsOn = isOn;
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x00091B7C File Offset: 0x0008FD7C
		private void FixedUpdate()
		{
			if (this.IsOn)
			{
				if (!this.Siren.isPlaying)
				{
					this.Siren.Play();
				}
				if (this.cycleRoutine == null)
				{
					this.cycleRoutine = base.StartCoroutine(this.CycleCoroutine());
					return;
				}
			}
			else if (this.Siren.isPlaying)
			{
				this.Siren.Stop();
			}
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00091BDC File Offset: 0x0008FDDC
		protected IEnumerator CycleCoroutine()
		{
			foreach (OptimizedLight optimizedLight in this.RedLights)
			{
				optimizedLight._Light.intensity = 0f;
				optimizedLight.Enabled = true;
			}
			foreach (OptimizedLight optimizedLight2 in this.BlueLights)
			{
				optimizedLight2._Light.intensity = 0f;
				optimizedLight2.Enabled = true;
			}
			float time = 0f;
			MeshRenderer[] array2;
			while (this.IsOn)
			{
				time += Time.deltaTime;
				float time2 = time / this.CycleDuration % 1f;
				float num = this.RedBrightnessCurve.Evaluate(time2);
				float num2 = this.BlueBrightnessCurve.Evaluate(time2);
				OptimizedLight[] array = this.RedLights;
				for (int i = 0; i < array.Length; i++)
				{
					array[i]._Light.intensity = num * this.LightBrightness;
				}
				array2 = this.RedMeshes;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].material = ((num > 0f) ? this.RedOnMat : this.RedOffMat);
				}
				array = this.BlueLights;
				for (int i = 0; i < array.Length; i++)
				{
					array[i]._Light.intensity = num2 * this.LightBrightness;
				}
				array2 = this.BlueMeshes;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].material = ((num2 > 0f) ? this.BlueOnMat : this.BlueOffMat);
				}
				yield return new WaitForEndOfFrame();
			}
			foreach (OptimizedLight optimizedLight3 in this.RedLights)
			{
				optimizedLight3._Light.intensity = 0f;
				optimizedLight3.Enabled = false;
			}
			array2 = this.RedMeshes;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].material = this.RedOffMat;
			}
			foreach (OptimizedLight optimizedLight4 in this.BlueLights)
			{
				optimizedLight4._Light.intensity = 0f;
				optimizedLight4.Enabled = false;
			}
			array2 = this.BlueMeshes;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].material = this.BlueOffMat;
			}
			this.cycleRoutine = null;
			yield break;
		}

		// Token: 0x04001ABE RID: 6846
		public bool IsOn;

		// Token: 0x04001ABF RID: 6847
		[Header("References")]
		public MeshRenderer[] RedMeshes;

		// Token: 0x04001AC0 RID: 6848
		public MeshRenderer[] BlueMeshes;

		// Token: 0x04001AC1 RID: 6849
		public OptimizedLight[] RedLights;

		// Token: 0x04001AC2 RID: 6850
		public OptimizedLight[] BlueLights;

		// Token: 0x04001AC3 RID: 6851
		public AudioSourceController Siren;

		// Token: 0x04001AC4 RID: 6852
		[Header("Settings")]
		public float CycleDuration = 0.5f;

		// Token: 0x04001AC5 RID: 6853
		public Material RedOffMat;

		// Token: 0x04001AC6 RID: 6854
		public Material RedOnMat;

		// Token: 0x04001AC7 RID: 6855
		public Material BlueOffMat;

		// Token: 0x04001AC8 RID: 6856
		public Material BlueOnMat;

		// Token: 0x04001AC9 RID: 6857
		public AnimationCurve RedBrightnessCurve;

		// Token: 0x04001ACA RID: 6858
		public AnimationCurve BlueBrightnessCurve;

		// Token: 0x04001ACB RID: 6859
		public float LightBrightness = 5f;

		// Token: 0x04001ACC RID: 6860
		private Coroutine cycleRoutine;
	}
}
