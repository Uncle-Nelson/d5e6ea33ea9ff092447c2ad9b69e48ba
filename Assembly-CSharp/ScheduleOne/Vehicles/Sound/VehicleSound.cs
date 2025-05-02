using System;
using ScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles.Sound
{
	// Token: 0x020007E0 RID: 2016
	public class VehicleSound : MonoBehaviour
	{
		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x000E828D File Offset: 0x000E648D
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x000E8295 File Offset: 0x000E6495
		public LandVehicle Vehicle { get; private set; }

		// Token: 0x0600372C RID: 14124 RVA: 0x000E82A0 File Offset: 0x000E64A0
		protected virtual void Awake()
		{
			this.Vehicle = base.GetComponentInParent<LandVehicle>();
			if (this.Vehicle == null)
			{
				return;
			}
			this.Vehicle.onHandbrakeApplied.AddListener(new UnityAction(this.HandbrakeApplied));
			this.Vehicle.onVehicleStart.AddListener(new UnityAction(this.EngineStart));
			this.EngineIdleSource.VolumeMultiplier = 0f;
			this.EngineLoopSource.VolumeMultiplier = 0f;
			this.Vehicle.onCollision.AddListener(new UnityAction<Collision>(this.OnCollision));
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x000E833C File Offset: 0x000E653C
		protected virtual void FixedUpdate()
		{
			this.UpdateIdle();
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x000E8344 File Offset: 0x000E6544
		private void UpdateIdle()
		{
			if (this.Vehicle.isOccupied)
			{
				this.currentIdleVolume = Mathf.MoveTowards(this.currentIdleVolume, 1f, Time.fixedDeltaTime * 2f);
				float time = Mathf.Abs(this.Vehicle.VelocityCalculator.Velocity.magnitude * 3.6f / this.Vehicle.TopSpeed);
				this.EngineLoopSource.AudioSource.pitch = this.EngineLoopPitchCurve.Evaluate(time) * this.EngineLoopPitchMultiplier;
				this.EngineLoopSource.VolumeMultiplier = this.EngineLoopVolumeCurve.Evaluate(time) * this.VolumeMultiplier;
				if (!this.EngineLoopSource.AudioSource.isPlaying)
				{
					this.EngineLoopSource.Play();
				}
			}
			else
			{
				this.currentIdleVolume = Mathf.MoveTowards(this.currentIdleVolume, 0f, Time.fixedDeltaTime * 2f);
				if (this.EngineLoopSource.AudioSource.isPlaying)
				{
					this.EngineLoopSource.Stop();
				}
			}
			this.EngineIdleSource.VolumeMultiplier = this.currentIdleVolume * this.VolumeMultiplier;
			if (this.currentIdleVolume > 0f)
			{
				if (!this.EngineIdleSource.AudioSource.isPlaying)
				{
					this.EngineIdleSource.Play();
					return;
				}
			}
			else
			{
				this.EngineIdleSource.Stop();
			}
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x000E849B File Offset: 0x000E669B
		protected void HandbrakeApplied()
		{
			this.HandbrakeSource.VolumeMultiplier = this.VolumeMultiplier;
			this.HandbrakeSource.Play();
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x000E84B9 File Offset: 0x000E66B9
		protected void EngineStart()
		{
			this.EngineStartSource.VolumeMultiplier = this.VolumeMultiplier;
			this.EngineStartSource.Play();
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x000E84D7 File Offset: 0x000E66D7
		public void Honk()
		{
			this.HonkSource.Play();
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x000E84E4 File Offset: 0x000E66E4
		private void OnCollision(Collision collision)
		{
			float num = collision.relativeVelocity.magnitude * this.Vehicle.Rb.mass;
			if (collision.gameObject.layer == LayerMask.NameToLayer("NPC"))
			{
				num *= 0.2f;
			}
			if (num < this.MinCollisionMomentum)
			{
				return;
			}
			if (Time.time - this.lastCollisionTime < 0.5f && num < this.lastCollisionMomentum)
			{
				return;
			}
			float t = Mathf.InverseLerp(this.MinCollisionMomentum, this.MaxCollisionMomentum, num);
			this.ImpactSound.VolumeMultiplier = Mathf.Lerp(this.MinCollisionVolume, this.MaxCollisionVolume, t);
			this.ImpactSound.PitchMultiplier = Mathf.Lerp(this.MaxCollisionPitch, this.MinCollisionPitch, t);
			this.ImpactSound.transform.position = collision.contacts[0].point;
			this.ImpactSound.Play();
			this.lastCollisionTime = Time.time;
			this.lastCollisionMomentum = num;
		}

		// Token: 0x040027A9 RID: 10153
		public const float COLLISION_SOUND_COOLDOWN = 0.5f;

		// Token: 0x040027AA RID: 10154
		public float VolumeMultiplier = 1f;

		// Token: 0x040027AB RID: 10155
		[Header("References")]
		public AudioSourceController EngineStartSource;

		// Token: 0x040027AC RID: 10156
		public AudioSourceController EngineIdleSource;

		// Token: 0x040027AD RID: 10157
		public AudioSourceController EngineLoopSource;

		// Token: 0x040027AE RID: 10158
		public AudioSourceController HandbrakeSource;

		// Token: 0x040027AF RID: 10159
		public AudioSourceController HonkSource;

		// Token: 0x040027B0 RID: 10160
		public AudioSourceController ImpactSound;

		// Token: 0x040027B1 RID: 10161
		[Header("Impact Sounds")]
		public float MinCollisionMomentum = 3000f;

		// Token: 0x040027B2 RID: 10162
		public float MaxCollisionMomentum = 20000f;

		// Token: 0x040027B3 RID: 10163
		public float MinCollisionVolume = 0.2f;

		// Token: 0x040027B4 RID: 10164
		public float MaxCollisionVolume = 1f;

		// Token: 0x040027B5 RID: 10165
		public float MinCollisionPitch = 0.6f;

		// Token: 0x040027B6 RID: 10166
		public float MaxCollisionPitch = 1.1f;

		// Token: 0x040027B7 RID: 10167
		[Header("Engine Loop Settings")]
		public AnimationCurve EngineLoopPitchCurve;

		// Token: 0x040027B8 RID: 10168
		public float EngineLoopPitchMultiplier = 1f;

		// Token: 0x040027B9 RID: 10169
		public AnimationCurve EngineLoopVolumeCurve;

		// Token: 0x040027BB RID: 10171
		private float currentIdleVolume;

		// Token: 0x040027BC RID: 10172
		private float lastCollisionTime;

		// Token: 0x040027BD RID: 10173
		private float lastCollisionMomentum;
	}
}
