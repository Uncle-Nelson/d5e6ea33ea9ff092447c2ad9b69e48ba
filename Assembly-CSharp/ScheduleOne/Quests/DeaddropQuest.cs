using System;
using System.Collections.Generic;
using ScheduleOne.Economy;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Quests
{
	// Token: 0x020002E3 RID: 739
	public class DeaddropQuest : Quest
	{
		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x0004A89C File Offset: 0x00048A9C
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x0004A8A4 File Offset: 0x00048AA4
		public DeadDrop Drop { get; private set; }

		// Token: 0x0600109A RID: 4250 RVA: 0x0004A8AD File Offset: 0x00048AAD
		public override void Begin(bool network = true)
		{
			base.Begin(network);
			if (!DeaddropQuest.DeaddropQuests.Contains(this))
			{
				DeaddropQuest.DeaddropQuests.Add(this);
			}
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0004A8CE File Offset: 0x00048ACE
		public void SetDrop(DeadDrop drop)
		{
			this.Drop = drop;
			this.Entries[0].SetPoILocation(this.Drop.transform.position);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0004A8F8 File Offset: 0x00048AF8
		protected override void MinPass()
		{
			base.MinPass();
			if (base.QuestState == EQuestState.Active && this.Drop.Storage.ItemCount == 0)
			{
				this.Entries[0].Complete();
				this.Complete(false);
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0004A933 File Offset: 0x00048B33
		private void OnDestroy()
		{
			DeaddropQuest.DeaddropQuests.Remove(this);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0004A941 File Offset: 0x00048B41
		public override void End()
		{
			base.End();
			DeaddropQuest.DeaddropQuests.Remove(this);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0004A958 File Offset: 0x00048B58
		public override string GetSaveString()
		{
			List<QuestEntryData> list = new List<QuestEntryData>();
			for (int i = 0; i < this.Entries.Count; i++)
			{
				list.Add(this.Entries[i].GetSaveData());
			}
			return new DeaddropQuestData(base.GUID.ToString(), base.QuestState, base.IsTracked, this.title, this.Description, base.Expires, new GameDateTimeData(base.Expiry), list.ToArray(), this.Drop.GUID.ToString()).GetJson(true);
		}

		// Token: 0x040010DF RID: 4319
		public static List<DeaddropQuest> DeaddropQuests = new List<DeaddropQuest>();
	}
}
