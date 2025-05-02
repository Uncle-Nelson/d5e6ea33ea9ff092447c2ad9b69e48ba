using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007AE RID: 1966
	public class GameVolumeSetter : MonoBehaviour
	{
		// Token: 0x0600355A RID: 13658 RVA: 0x000E04BD File Offset: 0x000DE6BD
		private void Update()
		{
			Singleton<AudioManager>.Instance.SetGameVolumeMultipler(this.VolumeMultiplier);
		}

		// Token: 0x04002652 RID: 9810
		[Range(0f, 1f)]
		public float VolumeMultiplier = 1f;
	}
}
