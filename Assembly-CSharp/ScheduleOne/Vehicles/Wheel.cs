using System;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007DF RID: 2015
	public class Wheel : MonoBehaviour
	{
		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x000E7BB2 File Offset: 0x000E5DB2
		// (set) Token: 0x06003717 RID: 14103 RVA: 0x000E7BBA File Offset: 0x000E5DBA
		public bool isStatic { get; protected set; }

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x000E7BC3 File Offset: 0x000E5DC3
		// (set) Token: 0x06003719 RID: 14105 RVA: 0x000E7BCB File Offset: 0x000E5DCB
		public bool IsDrifting { get; protected set; }

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x000E7BD4 File Offset: 0x000E5DD4
		public bool IsDrifting_Smoothed
		{
			get
			{
				return this.DriftTime > 0.2f;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x000E7BE3 File Offset: 0x000E5DE3
		// (set) Token: 0x0600371C RID: 14108 RVA: 0x000E7BEB File Offset: 0x000E5DEB
		public float DriftTime { get; protected set; }

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x000E7BF4 File Offset: 0x000E5DF4
		// (set) Token: 0x0600371E RID: 14110 RVA: 0x000E7BFC File Offset: 0x000E5DFC
		public float DriftIntensity { get; protected set; }

		// Token: 0x0600371F RID: 14111 RVA: 0x000E7C08 File Offset: 0x000E5E08
		protected virtual void Start()
		{
			this.vehicle = base.GetComponentInParent<LandVehicle>();
			this.wheelCollider.ConfigureVehicleSubsteps(5f, 12, 15);
			this.defaultForwardStiffness = this.wheelCollider.forwardFriction.stiffness;
			this.defaultSidewaysStiffness = this.wheelCollider.sidewaysFriction.stiffness;
			this.wheelTransform = base.transform;
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x000E7C73 File Offset: 0x000E5E73
		protected virtual void LateUpdate()
		{
			this.lastFramePosition = this.wheelTransform.position;
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x000E7C88 File Offset: 0x000E5E88
		private void FixedUpdate()
		{
			if (this.wheelCollider.enabled && !this.vehicle.Agent.KinematicMode && this.vehicle.DistanceToLocalCamera < 40f)
			{
				Vector3 position;
				Quaternion rotation;
				this.wheelCollider.GetWorldPose(ref position, ref rotation);
				this.wheelModel.transform.position = position;
				if (this.vehicle.localPlayerIsDriver)
				{
					this.modelContainer.transform.localRotation = Quaternion.identity;
					this.wheelModel.transform.rotation = rotation;
				}
				else
				{
					Vector3 vector = this.wheelTransform.position - this.lastFramePosition;
					float xAngle = this.wheelTransform.InverseTransformVector(vector).z / (6.2831855f * this.wheelCollider.radius) * 360f;
					this.wheelModel.transform.Rotate(xAngle, 0f, 0f, Space.Self);
					this.modelContainer.transform.localEulerAngles = new Vector3(0f, this.wheelCollider.steerAngle, 0f);
				}
				if (this.DriftParticlesEnabled)
				{
					this.DriftParticles.transform.position = this.wheelTransform.position - Vector3.up * this.wheelCollider.radius;
				}
			}
			if (!this.vehicle.localPlayerIsDriver)
			{
				this.DriftParticles.Stop();
				this.DriftAudioSource.Stop();
				return;
			}
			if (this.vehicle.isStatic)
			{
				return;
			}
			this.ApplyFriction();
			this.CheckDrifting();
			this.UpdateDriftEffects();
			this.UpdateDriftAudio();
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x000E7E38 File Offset: 0x000E6038
		private void CheckDrifting()
		{
			if (!this.wheelCollider.enabled)
			{
				this.IsDrifting = false;
				this.DriftTime = 0f;
				this.DriftIntensity = 0f;
				return;
			}
			if (Mathf.Abs(this.vehicle.speed_Kmh) < 8f)
			{
				this.IsDrifting = false;
				this.DriftTime = 0f;
				this.DriftIntensity = 0f;
				return;
			}
			this.wheelCollider.GetGroundHit(ref this.wheelData);
			this.IsDrifting = ((Mathf.Abs(this.wheelData.sidewaysSlip) > 0.2f || Mathf.Abs(this.wheelData.forwardSlip) > 0.8f) && Mathf.Abs(this.vehicle.speed_Kmh) > 2f);
			float a = Mathf.Clamp01(Mathf.Abs(this.wheelData.sidewaysSlip));
			float b = Mathf.Clamp01(Mathf.Abs(this.wheelData.forwardSlip));
			this.DriftIntensity = Mathf.Max(a, b);
			if (this.IsDrifting)
			{
				this.DriftTime += Time.fixedDeltaTime;
			}
			else
			{
				this.DriftTime = 0f;
			}
			if (this.DEBUG_MODE)
			{
				Debug.Log("Sideways slip: " + this.wheelData.sidewaysSlip.ToString() + "\nForward slip: " + this.wheelData.forwardSlip.ToString());
				Debug.Log("Drifting: " + this.IsDrifting.ToString());
			}
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x000E7FC4 File Offset: 0x000E61C4
		private void UpdateDriftEffects()
		{
			if (this.IsDrifting_Smoothed && this.DriftParticlesEnabled)
			{
				if (!this.DriftParticles.isPlaying)
				{
					this.DriftParticles.Play();
					return;
				}
			}
			else if (this.DriftParticles.isPlaying)
			{
				this.DriftParticles.Stop();
			}
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x000E8014 File Offset: 0x000E6214
		private void UpdateDriftAudio()
		{
			if (!this.DriftAudioEnabled)
			{
				return;
			}
			if (this.IsDrifting_Smoothed && this.DriftIntensity > 0.2f && !this.DriftAudioSource.isPlaying)
			{
				this.DriftAudioSource.Play();
			}
			if (this.DriftAudioSource.isPlaying)
			{
				float volumeMultiplier = Mathf.Clamp01(Mathf.InverseLerp(0.2f, 1f, this.DriftIntensity));
				this.DriftAudioSource.VolumeMultiplier = volumeMultiplier;
			}
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x000E808C File Offset: 0x000E628C
		private void ApplyFriction()
		{
			this.forwardCurve = this.wheelCollider.forwardFriction;
			this.forwardCurve.stiffness = this.defaultForwardStiffness * ((this.vehicle.handbrakeApplied && this.vehicle.isOccupied) ? this.ForwardStiffnessMultiplier_Handbrake : 1f);
			this.wheelCollider.forwardFriction = this.forwardCurve;
			this.sidewaysCurve = this.wheelCollider.sidewaysFriction;
			this.sidewaysCurve.stiffness = this.defaultSidewaysStiffness * ((this.vehicle.handbrakeApplied && this.vehicle.isOccupied) ? this.SidewayStiffnessMultiplier_Handbrake : 1f);
			this.wheelCollider.sidewaysFriction = this.sidewaysCurve;
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x000E8150 File Offset: 0x000E6350
		public virtual void SetIsStatic(bool s)
		{
			this.isStatic = s;
			if (this.isStatic)
			{
				this.wheelCollider.enabled = false;
				this.wheelModel.transform.localPosition = new Vector3(this.wheelModel.transform.localPosition.x, -this.wheelCollider.suspensionDistance * this.wheelCollider.suspensionSpring.targetPosition, this.wheelModel.transform.localPosition.z);
				this.staticCollider.enabled = true;
				this.GroundWheelModel();
				return;
			}
			this.wheelCollider.enabled = true;
			this.staticCollider.enabled = false;
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x000E8200 File Offset: 0x000E6400
		private void GroundWheelModel()
		{
			this.wheelModel.localPosition = Vector3.zero;
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x000E8220 File Offset: 0x000E6420
		public bool IsWheelGrounded()
		{
			WheelHit wheelHit;
			return this.wheelCollider.GetGroundHit(ref wheelHit);
		}

		// Token: 0x0400278C RID: 10124
		public const float SIDEWAY_SLIP_THRESHOLD = 0.2f;

		// Token: 0x0400278D RID: 10125
		public const float FORWARD_SLIP_THRESHOLD = 0.8f;

		// Token: 0x0400278E RID: 10126
		public const float DRIFT_AUDIO_THRESHOLD = 0.2f;

		// Token: 0x0400278F RID: 10127
		public const float MIN_SPEED_FOR_DRIFT = 8f;

		// Token: 0x04002790 RID: 10128
		public const float WHEEL_ANIMATION_DISTANCE = 40f;

		// Token: 0x04002791 RID: 10129
		public bool DEBUG_MODE;

		// Token: 0x04002792 RID: 10130
		[Header("References")]
		public Transform wheelModel;

		// Token: 0x04002793 RID: 10131
		public Transform modelContainer;

		// Token: 0x04002794 RID: 10132
		public WheelCollider wheelCollider;

		// Token: 0x04002795 RID: 10133
		public Transform axleConnectionPoint;

		// Token: 0x04002796 RID: 10134
		public Collider staticCollider;

		// Token: 0x04002797 RID: 10135
		public ParticleSystem DriftParticles;

		// Token: 0x04002798 RID: 10136
		[Header("Settings")]
		public bool DriftParticlesEnabled = true;

		// Token: 0x04002799 RID: 10137
		public float ForwardStiffnessMultiplier_Handbrake = 0.5f;

		// Token: 0x0400279A RID: 10138
		public float SidewayStiffnessMultiplier_Handbrake = 0.5f;

		// Token: 0x0400279B RID: 10139
		[Header("Drift Audio")]
		public bool DriftAudioEnabled;

		// Token: 0x0400279C RID: 10140
		public AudioSourceController DriftAudioSource;

		// Token: 0x0400279D RID: 10141
		private float defaultForwardStiffness = 1f;

		// Token: 0x0400279E RID: 10142
		private float defaultSidewaysStiffness = 1f;

		// Token: 0x040027A3 RID: 10147
		private LandVehicle vehicle;

		// Token: 0x040027A4 RID: 10148
		private Vector3 lastFramePosition = Vector3.zero;

		// Token: 0x040027A5 RID: 10149
		private WheelHit wheelData;

		// Token: 0x040027A6 RID: 10150
		private WheelFrictionCurve forwardCurve;

		// Token: 0x040027A7 RID: 10151
		private WheelFrictionCurve sidewaysCurve;

		// Token: 0x040027A8 RID: 10152
		private Transform wheelTransform;
	}
}
