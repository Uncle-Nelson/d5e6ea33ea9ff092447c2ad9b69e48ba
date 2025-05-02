using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200033E RID: 830
	[RequireComponent(typeof(Accelerometer))]
	public class Pourable : Draggable
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x000513FD File Offset: 0x0004F5FD
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x00051405 File Offset: 0x0004F605
		public bool IsPouring { get; protected set; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x0005140E File Offset: 0x0004F60E
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x00051416 File Offset: 0x0004F616
		public float NormalizedPourRate { get; private set; }

		// Token: 0x0600129A RID: 4762 RVA: 0x00051420 File Offset: 0x0004F620
		protected virtual void Start()
		{
			if (this.autoSetCurrentQuantity)
			{
				this.currentQuantity = this.StartQuantity;
			}
			this.accelerometer = base.GetComponent<AverageAcceleration>();
			if (this.accelerometer == null)
			{
				this.accelerometer = base.gameObject.AddComponent<AverageAcceleration>();
			}
			this.particleMinSizes = new float[this.PourParticles.Length];
			this.particleMaxSizes = new float[this.PourParticles.Length];
			for (int i = 0; i < this.PourParticles.Length; i++)
			{
				this.particleMinSizes[i] = this.PourParticles[i].main.startSize.constantMin;
				this.particleMaxSizes[i] = this.PourParticles[i].main.startSize.constantMax;
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x000514EF File Offset: 0x0004F6EF
		protected override void Update()
		{
			base.Update();
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000514F7 File Offset: 0x0004F6F7
		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			this.UpdatePouring();
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00051508 File Offset: 0x0004F708
		protected virtual void UpdatePouring()
		{
			float num = Vector3.Angle(Vector3.up, this.PourPoint.forward);
			this.IsPouring = (num > this.AngleFromUpToPour && this.CanPour());
			this.NormalizedPourRate = 0f;
			if (this.IsPouring && this.currentQuantity > 0f)
			{
				float num2 = (0.3f + 0.7f * (num - this.AngleFromUpToPour) / (180f - this.AngleFromUpToPour)) * this.GetShakeBoost();
				this.NormalizedPourRate = num2;
				if (this.PourLoop != null)
				{
					this.PourLoop.VolumeMultiplier = num2 - 0.3f;
					if (!this.PourLoop.isPlaying)
					{
						this.PourLoop.Play();
					}
				}
				this.PourAmount(this.PourRate_L * num2 * Time.deltaTime);
				for (int i = 0; i < this.PourParticles.Length; i++)
				{
					ParticleSystem.MainModule main = this.PourParticles[i].main;
					float num3 = this.ParticleMinMultiplier * num2 * this.particleMinSizes[i];
					float num4 = this.ParticleMaxMultiplier * num2 * this.particleMaxSizes[i];
					main.startSize = new ParticleSystem.MinMaxCurve(num3, num4);
				}
				if (!this.PourParticles[0].isEmitting && this.currentQuantity > 0f)
				{
					for (int j = 0; j < this.PourParticles.Length; j++)
					{
						this.PourParticles[j].Play();
					}
				}
			}
			else
			{
				if (this.PourLoop != null && this.PourLoop.isPlaying)
				{
					this.PourLoop.Stop();
				}
				if (this.PourParticles[0].isEmitting)
				{
					for (int k = 0; k < this.PourParticles.Length; k++)
					{
						this.PourParticles[k].Stop(false, 1);
					}
				}
			}
			if (this.currentQuantity == 0f && this.PourParticles[0].isEmitting)
			{
				for (int l = 0; l < this.PourParticles.Length; l++)
				{
					this.PourParticles[l].Stop(false, 1);
				}
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00051724 File Offset: 0x0004F924
		private float GetShakeBoost()
		{
			return Mathf.Lerp(1f, this.ShakeBoostRate, Mathf.Clamp(this.accelerometer.Acceleration.y / 0.75f, 0f, 1f));
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0005175C File Offset: 0x0004F95C
		protected virtual void PourAmount(float amount)
		{
			if (!this.Unlimited)
			{
				this.currentQuantity = Mathf.Clamp(this.currentQuantity - amount, 0f, this.StartQuantity);
			}
			if (this.AffectsCoverage && this.IsPourPointOverPot())
			{
				this.TargetPot.SoilCover.QueuePour(this.PourPoint.position + this.PourPoint.forward * 0.05f);
			}
			if (!this.hasPoured)
			{
				if (this.onInitialPour != null)
				{
					this.onInitialPour();
				}
				this.hasPoured = true;
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000517F8 File Offset: 0x0004F9F8
		protected bool IsPourPointOverPot()
		{
			Vector3 position = this.PourPoint.position;
			position.y = this.TargetPot.transform.position.y;
			return Vector3.Distance(position, this.TargetPot.transform.position) < this.TargetPot.PotRadius;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000022C9 File Offset: 0x000004C9
		protected virtual bool CanPour()
		{
			return true;
		}

		// Token: 0x040011F1 RID: 4593
		public Action onInitialPour;

		// Token: 0x040011F2 RID: 4594
		[Header("Pourable settings")]
		public bool Unlimited;

		// Token: 0x040011F3 RID: 4595
		public float StartQuantity = 10f;

		// Token: 0x040011F4 RID: 4596
		public float PourRate_L = 0.25f;

		// Token: 0x040011F5 RID: 4597
		public float AngleFromUpToPour = 90f;

		// Token: 0x040011F6 RID: 4598
		[Tooltip("Multiplier for pour rate when pourable is shaken up and down")]
		public float ShakeBoostRate = 1.35f;

		// Token: 0x040011F7 RID: 4599
		public bool AffectsCoverage;

		// Token: 0x040011F8 RID: 4600
		[Header("Particles")]
		public float ParticleMinMultiplier = 0.8f;

		// Token: 0x040011F9 RID: 4601
		public float ParticleMaxMultiplier = 1.5f;

		// Token: 0x040011FA RID: 4602
		[Header("Pourable References")]
		public ParticleSystem[] PourParticles;

		// Token: 0x040011FB RID: 4603
		public Transform PourPoint;

		// Token: 0x040011FC RID: 4604
		public AudioSourceController PourLoop;

		// Token: 0x040011FD RID: 4605
		[Header("Trash")]
		public TrashItem TrashItem;

		// Token: 0x040011FE RID: 4606
		[HideInInspector]
		public Pot TargetPot;

		// Token: 0x04001200 RID: 4608
		public float currentQuantity;

		// Token: 0x04001201 RID: 4609
		protected bool hasPoured;

		// Token: 0x04001202 RID: 4610
		protected bool autoSetCurrentQuantity = true;

		// Token: 0x04001203 RID: 4611
		private float[] particleMinSizes;

		// Token: 0x04001204 RID: 4612
		private float[] particleMaxSizes;

		// Token: 0x04001205 RID: 4613
		private AverageAcceleration accelerometer;
	}
}
