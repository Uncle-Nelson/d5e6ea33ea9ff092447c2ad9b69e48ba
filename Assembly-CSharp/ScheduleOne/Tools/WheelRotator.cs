using System;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087D RID: 2173
	[ExecuteInEditMode]
	public class WheelRotator : MonoBehaviour
	{
		// Token: 0x06003AFB RID: 15099 RVA: 0x000F8485 File Offset: 0x000F6685
		private void Start()
		{
			if (this.Controller != null)
			{
				this.Controller.AudioSource.time = Random.Range(0f, this.Controller.AudioSource.clip.length);
			}
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x000F84C4 File Offset: 0x000F66C4
		private void LateUpdate()
		{
			Vector3 position = base.transform.position;
			float num = Vector3.Distance(position, this.lastFramePosition);
			if (num > 0f)
			{
				float num2 = num / (6.2831855f * this.Radius) * 360f;
				this.Wheel.Rotate(this.RotationAxis, num2 * (this.Flip ? -1f : 1f));
				float num3 = num2 / Time.deltaTime;
				if (this.Controller != null)
				{
					this.Controller.VolumeMultiplier = num3 / this.AudioVolumeDivisor;
				}
			}
			this.lastFramePosition = position;
		}

		// Token: 0x04002A7A RID: 10874
		public float Radius = 0.5f;

		// Token: 0x04002A7B RID: 10875
		public Transform Wheel;

		// Token: 0x04002A7C RID: 10876
		public bool Flip;

		// Token: 0x04002A7D RID: 10877
		public AudioSourceController Controller;

		// Token: 0x04002A7E RID: 10878
		public float AudioVolumeDivisor = 90f;

		// Token: 0x04002A7F RID: 10879
		public Vector3 RotationAxis = Vector3.up;

		// Token: 0x04002A80 RID: 10880
		[SerializeField]
		private Vector3 lastFramePosition = Vector3.zero;
	}
}
