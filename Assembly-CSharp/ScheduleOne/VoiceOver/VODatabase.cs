using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000277 RID: 631
	[CreateAssetMenu(fileName = "VODatabase", menuName = "ScriptableObjects/VODatabase")]
	[Serializable]
	public class VODatabase : ScriptableObject
	{
		// Token: 0x06000D29 RID: 3369 RVA: 0x0003A780 File Offset: 0x00038980
		public VODatabaseEntry GetEntry(EVOLineType lineType)
		{
			foreach (VODatabaseEntry vodatabaseEntry in this.Entries)
			{
				if (vodatabaseEntry.LineType == lineType)
				{
					return vodatabaseEntry;
				}
			}
			return null;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0003A7DC File Offset: 0x000389DC
		public AudioClip GetRandomClip(EVOLineType lineType)
		{
			VODatabaseEntry entry = this.GetEntry(lineType);
			if (entry != null)
			{
				return entry.GetRandomClip();
			}
			return null;
		}

		// Token: 0x04000DC6 RID: 3526
		[Range(0f, 2f)]
		public float VolumeMultiplier = 1f;

		// Token: 0x04000DC7 RID: 3527
		public List<VODatabaseEntry> Entries = new List<VODatabaseEntry>();
	}
}
