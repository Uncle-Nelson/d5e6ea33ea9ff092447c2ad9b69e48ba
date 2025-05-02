using System;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.StationFramework
{
	// Token: 0x020008CF RID: 2255
	public class PourableModule : ItemModule
	{
		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06003D34 RID: 15668 RVA: 0x00101093 File Offset: 0x000FF293
		// (set) Token: 0x06003D35 RID: 15669 RVA: 0x0010109B File Offset: 0x000FF29B
		public bool IsPouring { get; protected set; }

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06003D36 RID: 15670 RVA: 0x001010A4 File Offset: 0x000FF2A4
		// (set) Token: 0x06003D37 RID: 15671 RVA: 0x001010AC File Offset: 0x000FF2AC
		public float NormalizedPourRate { get; private set; }

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06003D38 RID: 15672 RVA: 0x001010B5 File Offset: 0x000FF2B5
		// (set) Token: 0x06003D39 RID: 15673 RVA: 0x001010BD File Offset: 0x000FF2BD
		public float LiquidLevel { get; protected set; } = 1f;

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x001010C6 File Offset: 0x000FF2C6
		public float NormalizedLiquidLevel
		{
			get
			{
				return this.LiquidLevel / this.LiquidCapacity_L;
			}
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x001010D8 File Offset: 0x000FF2D8
		protected virtual void Start()
		{
			this.particleMinSizes = new float[this.PourParticles.Length];
			this.particleMaxSizes = new float[this.PourParticles.Length];
			for (int i = 0; i < this.PourParticles.Length; i++)
			{
				this.particleMinSizes[i] = this.PourParticles[i].main.startSize.constantMin;
				this.particleMaxSizes[i] = this.PourParticles[i].main.startSize.constantMax;
				ParticleSystem.CollisionModule collision = this.PourParticles[i].collision;
				LayerMask layerMask = collision.collidesWith;
				layerMask |= 1 << LayerMask.NameToLayer("Task");
				collision.collidesWith = layerMask;
				collision.sendCollisionMessages = true;
				this.PourParticles[i].gameObject.AddComponent<ParticleCollisionDetector>().onCollision.AddListener(new UnityAction<GameObject>(this.ParticleCollision));
			}
			if (this.LiquidContainer != null)
			{
				this.SetLiquidLevel(this.DefaultLiquid_L);
			}
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x001011F4 File Offset: 0x000FF3F4
		public override void ActivateModule(StationItem item)
		{
			base.ActivateModule(item);
			if (this.DraggableConstraint != null)
			{
				this.DraggableConstraint.SetContainer(item.transform.parent);
			}
			if (this.Draggable != null)
			{
				this.Draggable.ClickableEnabled = true;
			}
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x00101246 File Offset: 0x000FF446
		protected virtual void FixedUpdate()
		{
			if (!base.IsModuleActive)
			{
				return;
			}
			this.UpdatePouring();
			this.UpdatePourSound();
			if (this.timeSinceFillableHit > 0.25f)
			{
				this.activeFillable = null;
			}
			this.timeSinceFillableHit += Time.fixedDeltaTime;
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00101284 File Offset: 0x000FF484
		protected virtual void UpdatePouring()
		{
			float num = Vector3.Angle(Vector3.up, this.PourPoint.forward);
			this.IsPouring = (num > this.AngleFromUpToPour && this.CanPour());
			this.NormalizedPourRate = 0f;
			if (this.IsPouring && this.NormalizedLiquidLevel > 0f)
			{
				float num2 = 0.3f + 0.7f * (num - this.AngleFromUpToPour) / (180f - this.AngleFromUpToPour);
				this.NormalizedPourRate = num2;
				this.PourAmount(num2 * this.PourRate * Time.deltaTime);
				for (int i = 0; i < this.PourParticles.Length; i++)
				{
					ParticleSystem.MainModule main = this.PourParticles[i].main;
					float num3 = 1f;
					if (this.LiquidContainer != null)
					{
						num3 = Mathf.Clamp(this.LiquidContainer.CurrentLiquidLevel, 0.3f, 1f);
					}
					float num4 = this.ParticleMinMultiplier * num2 * this.particleMinSizes[i] * num3;
					float num5 = this.ParticleMaxMultiplier * num2 * this.particleMaxSizes[i] * num3;
					main.startSize = new ParticleSystem.MinMaxCurve(num4, num5);
					main.startColor = this.PourParticlesColor;
				}
				if (!this.PourParticles[0].isEmitting && this.NormalizedLiquidLevel > 0f)
				{
					for (int j = 0; j < this.PourParticles.Length; j++)
					{
						this.PourParticles[j].Play();
					}
				}
			}
			else if (this.PourParticles[0].isEmitting)
			{
				for (int k = 0; k < this.PourParticles.Length; k++)
				{
					this.PourParticles[k].Stop(false, 1);
				}
			}
			if (this.NormalizedLiquidLevel == 0f && this.PourParticles[0].isEmitting)
			{
				for (int l = 0; l < this.PourParticles.Length; l++)
				{
					this.PourParticles[l].Stop(false, 1);
				}
			}
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00101484 File Offset: 0x000FF684
		private void UpdatePourSound()
		{
			if (this.PourSound == null)
			{
				return;
			}
			if (this.NormalizedPourRate > 0f)
			{
				this.PourSound.VolumeMultiplier = this.NormalizedPourRate;
				if (!this.PourSound.isPlaying)
				{
					this.PourSound.Play();
					return;
				}
			}
			else if (this.PourSound.isPlaying)
			{
				this.PourSound.Stop();
			}
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x001014EF File Offset: 0x000FF6EF
		public virtual void ChangeLiquidLevel(float change)
		{
			this.LiquidLevel = Mathf.Clamp(this.LiquidLevel + change, 0f, this.LiquidCapacity_L);
			if (this.LiquidContainer != null)
			{
				this.LiquidContainer.SetLiquidLevel(this.NormalizedLiquidLevel, false);
			}
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x0010152F File Offset: 0x000FF72F
		public virtual void SetLiquidLevel(float level)
		{
			this.LiquidLevel = Mathf.Clamp(level, 0f, this.LiquidCapacity_L);
			if (this.LiquidContainer != null)
			{
				this.LiquidContainer.SetLiquidLevel(this.NormalizedLiquidLevel, false);
			}
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00101568 File Offset: 0x000FF768
		protected virtual void PourAmount(float amount)
		{
			Physics.RaycastAll(this.PourPoint.position, Vector3.down, 1f, 1 << LayerMask.NameToLayer("Task"));
			if (!this.OnlyEmptyOverFillable || (this.activeFillable != null && this.activeFillable.FillableEnabled))
			{
				this.ChangeLiquidLevel(-amount);
				if (this.activeFillable != null)
				{
					this.activeFillable.AddLiquid(this.LiquidType, amount, this.LiquidColor);
				}
			}
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x001015F0 File Offset: 0x000FF7F0
		private void ParticleCollision(GameObject other)
		{
			Fillable componentInParent = other.GetComponentInParent<Fillable>();
			if (componentInParent != null && componentInParent.enabled)
			{
				this.timeSinceFillableHit = 0f;
				this.activeFillable = componentInParent;
			}
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x000022C9 File Offset: 0x000004C9
		protected virtual bool CanPour()
		{
			return true;
		}

		// Token: 0x04002C06 RID: 11270
		[Header("Settings")]
		public string LiquidType = "Liquid";

		// Token: 0x04002C07 RID: 11271
		public float PourRate = 0.2f;

		// Token: 0x04002C08 RID: 11272
		public float AngleFromUpToPour = 90f;

		// Token: 0x04002C09 RID: 11273
		public bool OnlyEmptyOverFillable = true;

		// Token: 0x04002C0A RID: 11274
		public float LiquidCapacity_L = 0.25f;

		// Token: 0x04002C0B RID: 11275
		public Color LiquidColor;

		// Token: 0x04002C0C RID: 11276
		public float DefaultLiquid_L = 1f;

		// Token: 0x04002C0D RID: 11277
		[Header("References")]
		public ParticleSystem[] PourParticles;

		// Token: 0x04002C0E RID: 11278
		public Transform PourPoint;

		// Token: 0x04002C0F RID: 11279
		public LiquidContainer LiquidContainer;

		// Token: 0x04002C10 RID: 11280
		public Draggable Draggable;

		// Token: 0x04002C11 RID: 11281
		public DraggableConstraint DraggableConstraint;

		// Token: 0x04002C12 RID: 11282
		public AudioSourceController PourSound;

		// Token: 0x04002C13 RID: 11283
		[Header("Particles")]
		public Color PourParticlesColor;

		// Token: 0x04002C14 RID: 11284
		public float ParticleMinMultiplier = 0.8f;

		// Token: 0x04002C15 RID: 11285
		public float ParticleMaxMultiplier = 1.5f;

		// Token: 0x04002C16 RID: 11286
		private float[] particleMinSizes;

		// Token: 0x04002C17 RID: 11287
		private float[] particleMaxSizes;

		// Token: 0x04002C18 RID: 11288
		private Fillable activeFillable;

		// Token: 0x04002C19 RID: 11289
		private float timeSinceFillableHit = 10f;
	}
}
