using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x0200035A RID: 858
	public class PourOntoTargetTask : PourIntoPotTask
	{
		// Token: 0x06001367 RID: 4967 RVA: 0x00056831 File Offset: 0x00054A31
		public PourOntoTargetTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : base(_pot, _itemInstance, _pourablePrefab)
		{
			this.Target = _pot.Target;
			_pot.RandomizeTarget();
			_pot.SetTargetActive(true);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0005686C File Offset: 0x00054A6C
		public override void Update()
		{
			base.Update();
			Vector3 vector = this.pourable.PourPoint.position - this.Target.position;
			vector.y = 0f;
			if (vector.magnitude < this.SUCCESS_THRESHOLD)
			{
				this.timeOverTarget += Time.deltaTime * this.pourable.NormalizedPourRate;
				if (this.timeOverTarget >= this.SUCCESS_TIME)
				{
					this.TargetReached();
					return;
				}
			}
			else
			{
				this.timeOverTarget = 0f;
			}
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000568F9 File Offset: 0x00054AF9
		public override void StopTask()
		{
			this.pot.SetTargetActive(false);
			base.StopTask();
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0005690D File Offset: 0x00054B0D
		public virtual void TargetReached()
		{
			this.pot.RandomizeTarget();
			this.timeOverTarget = 0f;
			Singleton<TaskManager>.Instance.PlayTaskCompleteSound();
		}

		// Token: 0x0400129D RID: 4765
		public Transform Target;

		// Token: 0x0400129E RID: 4766
		public float SUCCESS_THRESHOLD = 0.12f;

		// Token: 0x0400129F RID: 4767
		public float SUCCESS_TIME = 0.4f;

		// Token: 0x040012A0 RID: 4768
		private float timeOverTarget;
	}
}
