using System;
using ScheduleOne.Interaction;

namespace ScheduleOne.Storage
{
	// Token: 0x020008AB RID: 2219
	public class StorageEntityInteractable : InteractableObject
	{
		// Token: 0x06003C50 RID: 15440 RVA: 0x000FE31C File Offset: 0x000FC51C
		private void Awake()
		{
			this.StorageEntity = base.GetComponentInParent<StorageEntity>();
			this.MaxInteractionRange = this.StorageEntity.MaxAccessDistance;
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x000FE33B File Offset: 0x000FC53B
		public override void Hovered()
		{
			base.Hovered();
			base.SetInteractableState(this.StorageEntity.CanBeOpened() ? InteractableObject.EInteractableState.Default : InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x000FE35A File Offset: 0x000FC55A
		public override void StartInteract()
		{
			base.StartInteract();
			this.StorageEntity.Open();
		}

		// Token: 0x04002B68 RID: 11112
		private StorageEntity StorageEntity;
	}
}
