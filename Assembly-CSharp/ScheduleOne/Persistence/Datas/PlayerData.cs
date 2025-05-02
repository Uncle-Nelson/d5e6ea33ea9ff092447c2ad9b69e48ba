using System;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000428 RID: 1064
	[Serializable]
	public class PlayerData : SaveData
	{
		// Token: 0x0600159D RID: 5533 RVA: 0x00060122 File Offset: 0x0005E322
		public PlayerData(string playerCode, Vector3 playerPos, float playerRot, bool introCompleted)
		{
			this.PlayerCode = playerCode;
			this.Position = playerPos;
			this.Rotation = playerRot;
			this.IntroCompleted = introCompleted;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00060152 File Offset: 0x0005E352
		public PlayerData()
		{
		}

		// Token: 0x04001439 RID: 5177
		public string PlayerCode;

		// Token: 0x0400143A RID: 5178
		public Vector3 Position = Vector3.zero;

		// Token: 0x0400143B RID: 5179
		public float Rotation;

		// Token: 0x0400143C RID: 5180
		public bool IntroCompleted;
	}
}
