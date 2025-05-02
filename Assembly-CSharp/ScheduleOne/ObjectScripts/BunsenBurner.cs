using System;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BC6 RID: 3014
	public class BunsenBurner : MonoBehaviour
	{
		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06005202 RID: 20994 RVA: 0x001599F8 File Offset: 0x00157BF8
		// (set) Token: 0x06005203 RID: 20995 RVA: 0x00159A00 File Offset: 0x00157C00
		public bool Interactable { get; private set; }

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x00159A09 File Offset: 0x00157C09
		// (set) Token: 0x06005205 RID: 20997 RVA: 0x00159A11 File Offset: 0x00157C11
		public bool IsDialHeld { get; private set; }

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x00159A1A File Offset: 0x00157C1A
		// (set) Token: 0x06005207 RID: 20999 RVA: 0x00159A22 File Offset: 0x00157C22
		public float CurrentDialValue { get; private set; }

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x00159A2B File Offset: 0x00157C2B
		// (set) Token: 0x06005209 RID: 21001 RVA: 0x00159A33 File Offset: 0x00157C33
		public float CurrentHeat { get; private set; }

		// Token: 0x0600520A RID: 21002 RVA: 0x00159A3C File Offset: 0x00157C3C
		private void Start()
		{
			this.SetInteractable(false);
			this.HandleClickable.onClickStart.AddListener(new UnityAction<RaycastHit>(this.ClickStart));
			this.HandleClickable.onClickEnd.AddListener(new UnityAction(this.ClickEnd));
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x00159A88 File Offset: 0x00157C88
		private void Update()
		{
			if (!this.LockDial)
			{
				if (this.IsDialHeld)
				{
					this.CurrentDialValue = Mathf.Clamp01(this.CurrentDialValue + this.HandleRotationSpeed * Time.deltaTime);
				}
				else
				{
					this.CurrentDialValue = Mathf.Clamp01(this.CurrentDialValue - this.HandleRotationSpeed * Time.deltaTime);
				}
				this.Handle.localRotation = Quaternion.Lerp(this.Handle_Min.localRotation, this.Handle_Max.localRotation, this.CurrentDialValue);
			}
			this.CurrentHeat = this.CurrentDialValue;
			this.Highlight.gameObject.SetActive(this.Interactable && !this.IsDialHeld);
			if (this.CurrentHeat > 0f)
			{
				this.FlameSound.VolumeMultiplier = this.CurrentHeat;
				this.FlameSound.AudioSource.pitch = this.FlamePitch.Evaluate(this.CurrentHeat);
				if (!this.FlameSound.AudioSource.isPlaying)
				{
					this.FlameSound.Play();
				}
			}
			else if (this.FlameSound.AudioSource.isPlaying)
			{
				this.FlameSound.Stop();
			}
			this.UpdateEffects();
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x00159BC0 File Offset: 0x00157DC0
		private void UpdateEffects()
		{
			if (this.CurrentHeat > 0f)
			{
				if (!this.Flame.isPlaying)
				{
					this.Flame.Play();
				}
				this.Light.gameObject.SetActive(true);
				this.Flame.startColor = this.FlameColor.Evaluate(this.CurrentHeat);
				this.Light.color = this.Flame.startColor;
				this.Light.intensity = this.LightIntensity.Evaluate(this.CurrentHeat);
				return;
			}
			if (this.Flame.isPlaying)
			{
				this.Flame.Stop();
			}
			this.Light.gameObject.SetActive(false);
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x00159C7B File Offset: 0x00157E7B
		public void SetDialPosition(float pos)
		{
			this.CurrentDialValue = Mathf.Clamp01(pos);
			this.Handle.localRotation = Quaternion.Lerp(this.Handle_Min.localRotation, this.Handle_Max.localRotation, this.CurrentDialValue);
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x00159CB8 File Offset: 0x00157EB8
		public void SetInteractable(bool e)
		{
			this.Interactable = e;
			this.HandleClickable.ClickableEnabled = e;
			if (!this.Interactable)
			{
				this.IsDialHeld = false;
			}
			if (this.Interactable)
			{
				this.Anim.Play();
				return;
			}
			this.Anim.Stop();
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x00159D07 File Offset: 0x00157F07
		public void ClickStart(RaycastHit hit)
		{
			this.IsDialHeld = true;
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x00159D10 File Offset: 0x00157F10
		public void ClickEnd()
		{
			this.IsDialHeld = false;
		}

		// Token: 0x04003D79 RID: 15737
		public bool LockDial;

		// Token: 0x04003D7A RID: 15738
		[Header("Settings")]
		public Gradient FlameColor;

		// Token: 0x04003D7B RID: 15739
		public AnimationCurve LightIntensity;

		// Token: 0x04003D7C RID: 15740
		public float HandleRotationSpeed = 1f;

		// Token: 0x04003D7D RID: 15741
		public AnimationCurve FlamePitch;

		// Token: 0x04003D7E RID: 15742
		[Header("References")]
		public ParticleSystem Flame;

		// Token: 0x04003D7F RID: 15743
		public Light Light;

		// Token: 0x04003D80 RID: 15744
		public Transform Handle;

		// Token: 0x04003D81 RID: 15745
		public Clickable HandleClickable;

		// Token: 0x04003D82 RID: 15746
		public Transform Handle_Min;

		// Token: 0x04003D83 RID: 15747
		public Transform Handle_Max;

		// Token: 0x04003D84 RID: 15748
		public Transform Highlight;

		// Token: 0x04003D85 RID: 15749
		public Animation Anim;

		// Token: 0x04003D86 RID: 15750
		public AudioSourceController FlameSound;
	}
}
