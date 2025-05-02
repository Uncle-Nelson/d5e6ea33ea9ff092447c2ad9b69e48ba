using System;
using System.Collections;
using EasyButtons;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x0200096D RID: 2413
	[ExecuteInEditMode]
	public class EyeController : MonoBehaviour
	{
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060041A0 RID: 16800 RVA: 0x00113BD9 File Offset: 0x00111DD9
		// (set) Token: 0x060041A1 RID: 16801 RVA: 0x00113BE1 File Offset: 0x00111DE1
		public bool EyesOpen { get; protected set; } = true;

		// Token: 0x060041A2 RID: 16802 RVA: 0x00113BEA File Offset: 0x00111DEA
		protected virtual void Awake()
		{
			this.avatar = base.GetComponentInParent<Avatar>();
			this.avatar.onRagdollChange.AddListener(new UnityAction<bool, bool, bool>(this.RagdollChange));
			this.SetEyesOpen(true);
			this.ApplyDilation();
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x00113C24 File Offset: 0x00111E24
		protected void Update()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			if (this.BlinkingEnabled && this.blinkRoutine == null)
			{
				this.blinkRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.BlinkRoutine());
			}
			if (this.BlinkingEnabled)
			{
				this.timeUntilNextBlink -= Time.deltaTime;
			}
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00113C79 File Offset: 0x00111E79
		private void OnEnable()
		{
			this.ApplyRestingEyeLidState();
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x00113C84 File Offset: 0x00111E84
		[Button]
		public void ApplySettings()
		{
			this.leftEye.transform.localEulerAngles = new Vector3(0f, -this.eyeSpacing, 0f);
			this.rightEye.transform.localEulerAngles = new Vector3(0f, this.eyeSpacing, 0f);
			this.rightEye.transform.localPosition = new Vector3(0f, this.eyeHeight * EyeController.eyeHeightMultiplier, 0f);
			this.leftEye.transform.localPosition = new Vector3(0f, this.eyeHeight * EyeController.eyeHeightMultiplier, 0f);
			this.leftEye.SetSize(this.eyeSize);
			this.rightEye.SetSize(this.eyeSize);
			this.leftEye.SetLidColor(this.leftEyeLidColor);
			this.rightEye.SetLidColor(this.rightEyeLidColor);
			this.leftEye.SetEyeballMaterial(this.eyeBallMaterial, this.eyeBallColor);
			this.rightEye.SetEyeballMaterial(this.eyeBallMaterial, this.eyeBallColor);
			this.ApplyDilation();
			this.ApplyRestingEyeLidState();
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x00113DB0 File Offset: 0x00111FB0
		public void SetEyeballTint(Color col)
		{
			this.leftEye.SetEyeballColor(col, 0.115f, true);
			this.rightEye.SetEyeballColor(col, 0.115f, true);
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00113DD6 File Offset: 0x00111FD6
		public void OverrideEyeballTint(Color col)
		{
			this.leftEye.SetEyeballColor(col, 0.115f, true);
			this.rightEye.SetEyeballColor(col, 0.115f, true);
			this.eyeBallTintOverridden = true;
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x00113E03 File Offset: 0x00112003
		public void ResetEyeballTint()
		{
			this.leftEye.SetEyeballColor(this.eyeBallColor, 0.115f, true);
			this.rightEye.SetEyeballColor(this.eyeBallColor, 0.115f, true);
			this.eyeBallTintOverridden = false;
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x00113E3A File Offset: 0x0011203A
		public void OverrideEyeLids(Eye.EyeLidConfiguration eyeLidConfiguration)
		{
			if (!this.eyeLidOverridden)
			{
				this.defaultLeftEyeRestingState = this.LeftRestingEyeState;
				this.defaultRightEyeRestingState = this.RightRestingEyeState;
			}
			this.LeftRestingEyeState = eyeLidConfiguration;
			this.RightRestingEyeState = eyeLidConfiguration;
			this.eyeLidOverridden = true;
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x00113E71 File Offset: 0x00112071
		public void ResetEyeLids()
		{
			this.LeftRestingEyeState = this.defaultLeftEyeRestingState;
			this.RightRestingEyeState = this.defaultRightEyeRestingState;
			this.eyeLidOverridden = false;
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x00113E92 File Offset: 0x00112092
		private void RagdollChange(bool oldValue, bool newValue, bool playStandUpAnim)
		{
			if (newValue)
			{
				this.ForceBlink();
			}
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x00113EA0 File Offset: 0x001120A0
		public void SetEyesOpen(bool open)
		{
			if (this.DEBUG)
			{
				Debug.Log("Setting eyes open: " + open.ToString());
			}
			this.EyesOpen = open;
			this.leftEye.SetEyeLidState(open ? this.LeftRestingEyeState : new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0f,
				topLidOpen = 0f
			}, 0.1f);
			this.rightEye.SetEyeLidState(open ? this.RightRestingEyeState : new Eye.EyeLidConfiguration
			{
				bottomLidOpen = 0f,
				topLidOpen = 0f
			}, 0.1f);
		}

		// Token: 0x060041AD RID: 16813 RVA: 0x00113F4A File Offset: 0x0011214A
		private void ApplyDilation()
		{
			this.leftEye.SetDilation(this.PupilDilation);
			this.rightEye.SetDilation(this.PupilDilation);
		}

		// Token: 0x060041AE RID: 16814 RVA: 0x00113F6E File Offset: 0x0011216E
		public void SetPupilDilation(float dilation, bool writeDefault = true)
		{
			this.PupilDilation = dilation;
			this.ApplyDilation();
			this.defaultDilation = this.PupilDilation;
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x00113F89 File Offset: 0x00112189
		public void ResetPupilDilation()
		{
			this.SetPupilDilation(this.defaultDilation, true);
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x00113F98 File Offset: 0x00112198
		private void ApplyRestingEyeLidState()
		{
			this.leftEye.SetEyeLidState(this.LeftRestingEyeState, false);
			this.rightEye.SetEyeLidState(this.RightRestingEyeState, false);
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x00113FBE File Offset: 0x001121BE
		public void ForceBlink()
		{
			this.leftEye.Blink(this.blinkDuration, this.LeftRestingEyeState, false);
			this.rightEye.Blink(this.blinkDuration, this.RightRestingEyeState, false);
			this.ResetBlinkCounter();
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x00113FF6 File Offset: 0x001121F6
		public void SetLeftEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			this.LeftRestingEyeState = config;
			if (!this.leftEye.IsBlinking)
			{
				this.leftEye.SetEyeLidState(config, false);
			}
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x00114019 File Offset: 0x00112219
		public void SetRightEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			this.RightRestingEyeState = config;
			if (!this.rightEye.IsBlinking)
			{
				this.rightEye.SetEyeLidState(config, false);
			}
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x0011403C File Offset: 0x0011223C
		private IEnumerator BlinkRoutine()
		{
			while (this.BlinkingEnabled)
			{
				if (this.EyesOpen)
				{
					if (this.DEBUG)
					{
						Debug.Log("Blinking");
					}
					this.leftEye.Blink(this.blinkDuration, this.LeftRestingEyeState, this.DEBUG);
					this.rightEye.Blink(this.blinkDuration, this.RightRestingEyeState, this.DEBUG);
				}
				this.ResetBlinkCounter();
				yield return new WaitUntil(() => this.timeUntilNextBlink <= 0f);
			}
			this.blinkRoutine = null;
			yield break;
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x0011404B File Offset: 0x0011224B
		private void ResetBlinkCounter()
		{
			this.timeUntilNextBlink = Random.Range(Mathf.Clamp(this.blinkInterval - this.blinkIntervalSpread, this.blinkDuration, float.MaxValue), this.blinkInterval + this.blinkIntervalSpread);
		}

		// Token: 0x060041B6 RID: 16822 RVA: 0x00114082 File Offset: 0x00112282
		public void LookAt(Vector3 position, bool instant = false)
		{
			bool debug = this.DEBUG;
			this.leftEye.LookAt(position, instant);
			this.rightEye.LookAt(position, instant);
		}

		// Token: 0x04002F2C RID: 12076
		private static float eyeHeightMultiplier = 0.03f;

		// Token: 0x04002F2D RID: 12077
		public bool DEBUG;

		// Token: 0x04002F2F RID: 12079
		[Header("References")]
		[SerializeField]
		public Eye leftEye;

		// Token: 0x04002F30 RID: 12080
		[SerializeField]
		public Eye rightEye;

		// Token: 0x04002F31 RID: 12081
		[Header("Location Settings")]
		[Range(0f, 45f)]
		[SerializeField]
		protected float eyeSpacing = 20f;

		// Token: 0x04002F32 RID: 12082
		[Range(-1f, 1f)]
		[SerializeField]
		protected float eyeHeight;

		// Token: 0x04002F33 RID: 12083
		[Range(0.5f, 1.5f)]
		[SerializeField]
		protected float eyeSize = 1f;

		// Token: 0x04002F34 RID: 12084
		[Header("Eyelid Settings")]
		[SerializeField]
		protected Color leftEyeLidColor = Color.white;

		// Token: 0x04002F35 RID: 12085
		[SerializeField]
		protected Color rightEyeLidColor = Color.white;

		// Token: 0x04002F36 RID: 12086
		public Eye.EyeLidConfiguration LeftRestingEyeState;

		// Token: 0x04002F37 RID: 12087
		public Eye.EyeLidConfiguration RightRestingEyeState;

		// Token: 0x04002F38 RID: 12088
		[Header("Eyeball Settings")]
		[SerializeField]
		protected Material eyeBallMaterial;

		// Token: 0x04002F39 RID: 12089
		[SerializeField]
		protected Color eyeBallColor;

		// Token: 0x04002F3A RID: 12090
		[Header("Pupil State")]
		[Range(0f, 1f)]
		public float PupilDilation = 0.5f;

		// Token: 0x04002F3B RID: 12091
		[Header("Blinking Settings")]
		public bool BlinkingEnabled = true;

		// Token: 0x04002F3C RID: 12092
		[SerializeField]
		[Range(0f, 10f)]
		protected float blinkInterval = 3.5f;

		// Token: 0x04002F3D RID: 12093
		[SerializeField]
		[Range(0f, 2f)]
		protected float blinkIntervalSpread = 0.5f;

		// Token: 0x04002F3E RID: 12094
		[SerializeField]
		[Range(0f, 1f)]
		protected float blinkDuration = 0.2f;

		// Token: 0x04002F3F RID: 12095
		private Avatar avatar;

		// Token: 0x04002F40 RID: 12096
		private Coroutine blinkRoutine;

		// Token: 0x04002F41 RID: 12097
		private float timeUntilNextBlink;

		// Token: 0x04002F42 RID: 12098
		private bool eyeBallTintOverridden;

		// Token: 0x04002F43 RID: 12099
		private bool eyeLidOverridden;

		// Token: 0x04002F44 RID: 12100
		private Eye.EyeLidConfiguration defaultLeftEyeRestingState;

		// Token: 0x04002F45 RID: 12101
		private Eye.EyeLidConfiguration defaultRightEyeRestingState;

		// Token: 0x04002F46 RID: 12102
		private float defaultDilation = 0.5f;
	}
}
