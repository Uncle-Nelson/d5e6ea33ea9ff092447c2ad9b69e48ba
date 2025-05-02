using System;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x0200040A RID: 1034
	public class NPCHealthData : SaveData
	{
		// Token: 0x0600157F RID: 5503 RVA: 0x0005FBB8 File Offset: 0x0005DDB8
		public NPCHealthData(float health, bool isDead, int daysPassedSinceDeath)
		{
			this.Health = health;
			this.IsDead = isDead;
			this.DaysPassedSinceDeath = daysPassedSinceDeath;
		}

		// Token: 0x040013DD RID: 5085
		public float Health;

		// Token: 0x040013DE RID: 5086
		public bool IsDead;

		// Token: 0x040013DF RID: 5087
		public int DaysPassedSinceDeath;
	}
}
