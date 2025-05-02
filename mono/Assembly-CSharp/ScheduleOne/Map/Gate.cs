using System;
using EasyButtons;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C1D RID: 3101
	public class Gate : MonoBehaviour
	{
		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x0016DFEF File Offset: 0x0016C1EF
		// (set) Token: 0x06005713 RID: 22291 RVA: 0x0016DFF7 File Offset: 0x0016C1F7
		public bool IsOpen { get; protected set; }

		// Token: 0x06005714 RID: 22292 RVA: 0x0016E000 File Offset: 0x0016C200
		private void Update()
		{
			this.Momentum = Mathf.MoveTowards(this.Momentum, 1f, Time.deltaTime * this.Acceleration);
			if (this.IsOpen)
			{
				this.openDelta += Time.deltaTime * this.OpenSpeed * this.Momentum;
			}
			else
			{
				this.openDelta -= Time.deltaTime * this.OpenSpeed * this.Momentum;
			}
			this.openDelta = Mathf.Clamp01(this.openDelta);
			if (this.openDelta <= 0.01f || this.openDelta >= 0.99f)
			{
				if (this.LoopSounds[0].isPlaying)
				{
					AudioSourceController[] array = this.LoopSounds;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].Stop();
					}
					array = this.StopSounds;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].Play();
					}
				}
			}
			else if (!this.LoopSounds[0].isPlaying && this.StartSounds[0].AudioSource.time >= this.StartSounds[0].AudioSource.clip.length * 0.5f)
			{
				AudioSourceController[] array = this.LoopSounds;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Play();
				}
			}
			this.Gate1.localPosition = Vector3.Lerp(this.Gate1Closed, this.Gate1Open, this.openDelta);
			this.Gate2.localPosition = Vector3.Lerp(this.Gate2Closed, this.Gate2Open, this.openDelta);
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x0016E194 File Offset: 0x0016C394
		[Button]
		public void Open()
		{
			this.Momentum *= -1f;
			if (this.openDelta == 0f)
			{
				this.Momentum = 0f;
			}
			AudioSourceController[] startSounds = this.StartSounds;
			for (int i = 0; i < startSounds.Length; i++)
			{
				startSounds[i].Play();
			}
			this.IsOpen = true;
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x0016E1F0 File Offset: 0x0016C3F0
		[Button]
		public void Close()
		{
			this.Momentum *= -1f;
			if (this.openDelta == 1f)
			{
				this.Momentum = 0f;
			}
			AudioSourceController[] startSounds = this.StartSounds;
			for (int i = 0; i < startSounds.Length; i++)
			{
				startSounds[i].Play();
			}
			this.IsOpen = false;
		}

		// Token: 0x0400406B RID: 16491
		public Transform Gate1;

		// Token: 0x0400406C RID: 16492
		public Vector3 Gate1Open;

		// Token: 0x0400406D RID: 16493
		public Vector3 Gate1Closed;

		// Token: 0x0400406E RID: 16494
		public Transform Gate2;

		// Token: 0x0400406F RID: 16495
		public Vector3 Gate2Open;

		// Token: 0x04004070 RID: 16496
		public Vector3 Gate2Closed;

		// Token: 0x04004071 RID: 16497
		public float OpenSpeed;

		// Token: 0x04004072 RID: 16498
		public float Acceleration = 2f;

		// Token: 0x04004073 RID: 16499
		[Header("Sound")]
		public AudioSourceController[] StartSounds;

		// Token: 0x04004074 RID: 16500
		public AudioSourceController[] LoopSounds;

		// Token: 0x04004075 RID: 16501
		public AudioSourceController[] StopSounds;

		// Token: 0x04004076 RID: 16502
		private float Momentum;

		// Token: 0x04004077 RID: 16503
		private float openDelta;
	}
}
