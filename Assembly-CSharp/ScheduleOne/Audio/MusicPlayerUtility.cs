using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x020007B5 RID: 1973
	public class MusicPlayerUtility : MonoBehaviour
	{
		// Token: 0x06003573 RID: 13683 RVA: 0x000E0ABB File Offset: 0x000DECBB
		public void PlayTrack(string trackName)
		{
			Singleton<MusicPlayer>.Instance.SetTrackEnabled(trackName, true);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x000E0AC9 File Offset: 0x000DECC9
		public void StopTracks()
		{
			Singleton<MusicPlayer>.Instance.StopAndDisableTracks();
		}
	}
}
