using System;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008BC RID: 2236
	public class BoilingFlask : Fillable
	{
		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x0010012D File Offset: 0x000FE32D
		// (set) Token: 0x06003CE0 RID: 15584 RVA: 0x00100135 File Offset: 0x000FE335
		public float CurrentTemperature { get; private set; }

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x0010013E File Offset: 0x000FE33E
		// (set) Token: 0x06003CE2 RID: 15586 RVA: 0x00100146 File Offset: 0x000FE346
		public float CurrentTemperatureVelocity { get; private set; }

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x0010014F File Offset: 0x000FE34F
		public bool IsTemperatureInRange
		{
			get
			{
				return this.Recipe != null && this.CurrentTemperature >= this.Recipe.CookTemperatureLowerBound && this.CurrentTemperature <= this.Recipe.CookTemperatureUpperBound;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x0010018C File Offset: 0x000FE38C
		// (set) Token: 0x06003CE5 RID: 15589 RVA: 0x00100194 File Offset: 0x000FE394
		public float OverheatScale { get; private set; }

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x0010019D File Offset: 0x000FE39D
		// (set) Token: 0x06003CE7 RID: 15591 RVA: 0x001001A5 File Offset: 0x000FE3A5
		public StationRecipe Recipe { get; private set; }

		// Token: 0x06003CE8 RID: 15592 RVA: 0x001001B0 File Offset: 0x000FE3B0
		public void Update()
		{
			if (this.Burner == null)
			{
				return;
			}
			if (!this.LockTemperature)
			{
				float num = this.Burner.CurrentHeat - this.CurrentTemperature / 500f;
				this.CurrentTemperatureVelocity = Mathf.MoveTowards(this.CurrentTemperatureVelocity, num * this.TEMPERATURE_MAX_VELOCITY, this.TEMPERATURE_ACCELERATION * Time.deltaTime);
				this.CurrentTemperature = Mathf.Clamp(this.CurrentTemperature + this.CurrentTemperatureVelocity * Time.deltaTime, 0f, 500f);
			}
			if (this.CurrentTemperature > 0f)
			{
				this.BoilSound.VolumeMultiplier = Mathf.Clamp01(this.CurrentTemperature / 500f);
				this.BoilSound.AudioSource.pitch = this.BoilSoundPitchCurve.Evaluate(Mathf.Clamp01(this.CurrentTemperature / 500f));
				this.BoilSound.ApplyVolume();
				this.BoilSound.ApplyPitch();
				if (!this.BoilSound.AudioSource.isPlaying)
				{
					this.BoilSound.AudioSource.Play();
				}
			}
			else
			{
				this.BoilSound.AudioSource.Stop();
			}
			if (this.Recipe != null && this.CurrentTemperature >= this.Recipe.CookTemperatureUpperBound)
			{
				float num2 = Mathf.Clamp((this.CurrentTemperature - this.Recipe.CookTemperatureUpperBound) / (500f - this.Recipe.CookTemperatureUpperBound), 0.25f, 1f);
				this.OverheatScale += num2 * Time.deltaTime / 1.25f;
			}
			else
			{
				this.OverheatScale = Mathf.MoveTowards(this.OverheatScale, 0f, Time.deltaTime / 1.25f);
			}
			if (this.OverheatScale > 0f)
			{
				this.OverheatMesh.material.color = new Color(1f, 1f, 1f, Mathf.Pow(this.OverheatScale, 2f));
				this.OverheatMesh.enabled = true;
				return;
			}
			this.OverheatMesh.enabled = false;
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x001003C8 File Offset: 0x000FE5C8
		private void FixedUpdate()
		{
			this.UpdateCanvas();
			this.UpdateSmoke();
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x001003D8 File Offset: 0x000FE5D8
		private void UpdateCanvas()
		{
			if (this.TemperatureCanvas.gameObject.activeSelf)
			{
				this.TemperatureLabel.text = Mathf.RoundToInt(this.CurrentTemperature).ToString() + "°C";
				if (this.CurrentTemperature < this.Recipe.CookTemperatureLowerBound)
				{
					this.TemperatureLabel.color = Color.white;
				}
				else if (this.CurrentTemperature > this.Recipe.CookTemperatureUpperBound)
				{
					this.TemperatureLabel.color = new Color32(byte.MaxValue, 90, 90, byte.MaxValue);
				}
				else
				{
					this.TemperatureLabel.color = Color.green;
				}
				this.TemperatureSlider.value = this.CurrentTemperature / 500f;
				if (this.OverheatScale > 0f)
				{
					this.TemperatureLabel.transform.localPosition = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f) * Mathf.Clamp(this.OverheatScale, 0.3f, 1f) * this.LabelJitterScale;
					return;
				}
				this.TemperatureLabel.transform.localPosition = Vector3.zero;
			}
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00100528 File Offset: 0x000FE728
		private void UpdateSmoke()
		{
			if (this.CurrentTemperature < 1f)
			{
				if (this.SmokeParticles.isPlaying)
				{
					this.SmokeParticles.Stop();
				}
				return;
			}
			ParticleSystem.MainModule main = this.SmokeParticles.main;
			main.simulationSpeed = Mathf.Lerp(1f, 3f, this.CurrentTemperature / 500f);
			main.startColor = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, this.CurrentTemperature / 500f));
			if (!this.SmokeParticles.isPlaying)
			{
				this.SmokeParticles.Play();
			}
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x001005DC File Offset: 0x000FE7DC
		public void SetCanvasVisible(bool visible)
		{
			this.TemperatureCanvas.gameObject.SetActive(visible);
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x001005EF File Offset: 0x000FE7EF
		public void SetTemperature(float temp)
		{
			this.CurrentTemperature = temp;
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x001005F8 File Offset: 0x000FE7F8
		public void SetRecipe(StationRecipe recipe)
		{
			this.Recipe = recipe;
			if (recipe == null)
			{
				return;
			}
			float x = this.Recipe.CookTemperatureLowerBound / 500f;
			float x2 = this.Recipe.CookTemperatureUpperBound / 500f;
			this.TemperatureRangeIndicator.anchorMin = new Vector2(x, this.TemperatureRangeIndicator.anchorMin.y);
			this.TemperatureRangeIndicator.anchorMax = new Vector2(x2, this.TemperatureRangeIndicator.anchorMax.y);
		}

		// Token: 0x04002BB1 RID: 11185
		public const float TEMPERATURE_MAX = 500f;

		// Token: 0x04002BB2 RID: 11186
		public float TEMPERATURE_MAX_VELOCITY = 200f;

		// Token: 0x04002BB3 RID: 11187
		public float TEMPERATURE_ACCELERATION = 50f;

		// Token: 0x04002BB4 RID: 11188
		public const float OVERHEAT_TIME = 1.25f;

		// Token: 0x04002BB9 RID: 11193
		public bool LockTemperature;

		// Token: 0x04002BBA RID: 11194
		public AnimationCurve BoilSoundPitchCurve;

		// Token: 0x04002BBB RID: 11195
		public float LabelJitterScale = 1f;

		// Token: 0x04002BBC RID: 11196
		[Header("References")]
		public BunsenBurner Burner;

		// Token: 0x04002BBD RID: 11197
		public Canvas TemperatureCanvas;

		// Token: 0x04002BBE RID: 11198
		public TextMeshProUGUI TemperatureLabel;

		// Token: 0x04002BBF RID: 11199
		public Slider TemperatureSlider;

		// Token: 0x04002BC0 RID: 11200
		public RectTransform TemperatureRangeIndicator;

		// Token: 0x04002BC1 RID: 11201
		public ParticleSystem SmokeParticles;

		// Token: 0x04002BC2 RID: 11202
		public AudioSourceController BoilSound;

		// Token: 0x04002BC3 RID: 11203
		public MeshRenderer OverheatMesh;
	}
}
