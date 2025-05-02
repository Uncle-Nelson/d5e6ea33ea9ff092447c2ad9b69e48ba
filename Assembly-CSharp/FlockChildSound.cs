using System;
using ScheduleOne.Audio;
using UnityEngine;

// Token: 0x02000048 RID: 72
[RequireComponent(typeof(AudioSource))]
public class FlockChildSound : MonoBehaviour
{
	// Token: 0x0600017C RID: 380 RVA: 0x00008E74 File Offset: 0x00007074
	public void Start()
	{
		this._flockChild = base.GetComponent<FlockChild>();
		this._audio = base.GetComponent<AudioSource>();
		base.InvokeRepeating("PlayRandomSound", Random.value + 1f, 1f);
		if (this._scareSounds.Length != 0)
		{
			base.InvokeRepeating("ScareSound", 1f, 0.01f);
		}
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00008ED4 File Offset: 0x000070D4
	public void PlayRandomSound()
	{
		if (base.gameObject.activeInHierarchy)
		{
			if (!this._audio.isPlaying && this._flightSounds.Length != 0 && this._flightSoundRandomChance > Random.value && !this._flockChild._landing)
			{
				if (this.controller != null)
				{
					this.controller.Play();
					return;
				}
			}
			else if (!this._audio.isPlaying && this._idleSounds.Length != 0 && this._idleSoundRandomChance > Random.value && this._flockChild._landing && this.controller != null)
			{
				this.controller.Play();
			}
		}
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00008F84 File Offset: 0x00007184
	public void ScareSound()
	{
		if (base.gameObject.activeInHierarchy && this._hasLanded && !this._flockChild._landing && this._idleSoundRandomChance * 2f > Random.value)
		{
			this._audio.clip = this._scareSounds[Random.Range(0, this._scareSounds.Length)];
			this._audio.volume = Random.Range(this._volumeMin, this._volumeMax);
			this._audio.PlayDelayed(Random.value * 0.2f);
			this._hasLanded = false;
		}
	}

	// Token: 0x0400016B RID: 363
	public AudioSourceController controller;

	// Token: 0x0400016C RID: 364
	public AudioClip[] _idleSounds;

	// Token: 0x0400016D RID: 365
	public float _idleSoundRandomChance = 0.05f;

	// Token: 0x0400016E RID: 366
	public AudioClip[] _flightSounds;

	// Token: 0x0400016F RID: 367
	public float _flightSoundRandomChance = 0.05f;

	// Token: 0x04000170 RID: 368
	public AudioClip[] _scareSounds;

	// Token: 0x04000171 RID: 369
	public float _pitchMin = 0.85f;

	// Token: 0x04000172 RID: 370
	public float _pitchMax = 1f;

	// Token: 0x04000173 RID: 371
	public float _volumeMin = 0.6f;

	// Token: 0x04000174 RID: 372
	public float _volumeMax = 0.8f;

	// Token: 0x04000175 RID: 373
	private FlockChild _flockChild;

	// Token: 0x04000176 RID: 374
	private AudioSource _audio;

	// Token: 0x04000177 RID: 375
	private bool _hasLanded;
}
