using System;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Trash;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x0200087E RID: 2174
	public class FunctionalSeed : MonoBehaviour
	{
		// Token: 0x06003AFE RID: 15102 RVA: 0x000F8592 File Offset: 0x000F6792
		public void TriggerExit(Collider other)
		{
			if (other == this.SeedCollider && this.onSeedExitVial != null)
			{
				this.onSeedExitVial();
			}
		}

		// Token: 0x04002A81 RID: 10881
		public Action onSeedExitVial;

		// Token: 0x04002A82 RID: 10882
		public Draggable Vial;

		// Token: 0x04002A83 RID: 10883
		public Collider SeedBlocker;

		// Token: 0x04002A84 RID: 10884
		public VialCap Cap;

		// Token: 0x04002A85 RID: 10885
		public Collider SeedCollider;

		// Token: 0x04002A86 RID: 10886
		public Rigidbody SeedRigidbody;

		// Token: 0x04002A87 RID: 10887
		public TrashItem TrashPrefab;
	}
}
