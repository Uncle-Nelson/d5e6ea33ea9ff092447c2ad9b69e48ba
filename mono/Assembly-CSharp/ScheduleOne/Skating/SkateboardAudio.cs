using System;
using ScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Skating
{
	// Token: 0x020002CF RID: 719
	public class SkateboardAudio : MonoBehaviour
	{
		// Token: 0x06000F85 RID: 3973 RVA: 0x00045003 File Offset: 0x00043203
		private void Awake()
		{
			this.Board.OnJump.AddListener(new UnityAction<float>(this.PlayJump));
			this.Board.OnLand.AddListener(new UnityAction(this.PlayLand));
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00045040 File Offset: 0x00043240
		private void Start()
		{
			if (this.Board.IsGrounded())
			{
				this.PlayLand();
			}
			this.RollingAudio.VolumeMultiplier = 0f;
			this.RollingAudio.Play();
			this.WindAudio.VolumeMultiplier = 0f;
			this.WindAudio.Play();
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00045098 File Offset: 0x00043298
		private void Update()
		{
			float num = Mathf.Clamp(Mathf.Abs(this.Board.CurrentSpeed_Kmh) / this.Board.TopSpeed_Kmh, 0f, 1.5f);
			float volumeMultiplier = num;
			if (this.Board.AirTime > 0.2f)
			{
				volumeMultiplier = 0f;
			}
			this.RollingAudio.VolumeMultiplier = volumeMultiplier;
			this.RollingAudio.AudioSource.pitch = Mathf.Lerp(0.75f, 1f, num);
			if (this.Board.IsOwner)
			{
				this.WindAudio.VolumeMultiplier = num;
				this.WindAudio.AudioSource.pitch = Mathf.Lerp(1.2f, 1.5f, num);
				return;
			}
			this.WindAudio.VolumeMultiplier = 0f;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00045161 File Offset: 0x00043361
		public void PlayJump(float force)
		{
			this.JumpAudio.VolumeMultiplier = Mathf.Lerp(0.5f, 1f, force);
			this.JumpAudio.Play();
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00045189 File Offset: 0x00043389
		public void PlayLand()
		{
			this.LandAudio.Play();
		}

		// Token: 0x04001027 RID: 4135
		public Skateboard Board;

		// Token: 0x04001028 RID: 4136
		[Header("References")]
		public AudioSourceController JumpAudio;

		// Token: 0x04001029 RID: 4137
		public AudioSourceController LandAudio;

		// Token: 0x0400102A RID: 4138
		public AudioSourceController RollingAudio;

		// Token: 0x0400102B RID: 4139
		public AudioSourceController WindAudio;
	}
}
