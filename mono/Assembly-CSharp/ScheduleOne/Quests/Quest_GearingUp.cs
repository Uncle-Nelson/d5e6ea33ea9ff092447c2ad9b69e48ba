using System;
using ScheduleOne.Economy;
using UnityEngine.Events;

namespace ScheduleOne.Quests
{
	// Token: 0x020002EC RID: 748
	public class Quest_GearingUp : Quest
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x0004B0C1 File Offset: 0x000492C1
		protected override void Start()
		{
			base.Start();
			this.Supplier.onDeaddropReady.AddListener(new UnityAction(this.DropReady));
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0004B0E8 File Offset: 0x000492E8
		protected override void MinPass()
		{
			base.MinPass();
			if (this.CollectDropEntry.State == EQuestState.Active && !this.setCollectionPosition)
			{
				DeadDrop deadDrop = DeadDrop.DeadDrops.Find((DeadDrop x) => x.Storage.ItemCount > 0);
				if (deadDrop != null)
				{
					this.setCollectionPosition = true;
					this.CollectDropEntry.SetPoILocation(deadDrop.transform.position);
				}
			}
			if (this.WaitForDropEntry.State == EQuestState.Active)
			{
				float num = (float)this.Supplier.minsUntilDeaddropReady;
				if (num > 0f)
				{
					this.WaitForDropEntry.SetEntryTitle("Wait for the dead drop (" + num.ToString() + " mins)");
					return;
				}
				this.WaitForDropEntry.SetEntryTitle("Wait for the dead drop");
			}
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0004B1B6 File Offset: 0x000493B6
		private void DropReady()
		{
			if (this.WaitForDropEntry.State == EQuestState.Active)
			{
				this.WaitForDropEntry.Complete();
				this.MinPass();
			}
		}

		// Token: 0x040010ED RID: 4333
		public QuestEntry WaitForDropEntry;

		// Token: 0x040010EE RID: 4334
		public QuestEntry CollectDropEntry;

		// Token: 0x040010EF RID: 4335
		public Supplier Supplier;

		// Token: 0x040010F0 RID: 4336
		private bool setCollectionPosition;
	}
}
