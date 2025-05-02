using System;
using ScheduleOne.Building;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200092A RID: 2346
	public class Equippable_StorableItem : Equippable
	{
		// Token: 0x06003F81 RID: 16257 RVA: 0x0010C1D6 File Offset: 0x0010A3D6
		protected virtual void Update()
		{
			this.CheckLookingAtStorageObject();
			if (this.lookingAtStorageObject)
			{
				if (!this.isBuildingStoredItem)
				{
					this.StartBuildingStoredItem();
					return;
				}
			}
			else if (this.isBuildingStoredItem)
			{
				this.StopBuildingStoredItem();
			}
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x0010C204 File Offset: 0x0010A404
		protected void CheckLookingAtStorageObject()
		{
			this.lookingAtStorageObject = false;
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x0010C218 File Offset: 0x0010A418
		public override void Unequip()
		{
			if (this.lookingAtStorageObject)
			{
				Singleton<BuildManager>.Instance.StopBuilding();
			}
			base.Unequip();
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x0010C232 File Offset: 0x0010A432
		protected virtual void StartBuildingStoredItem()
		{
			this.isBuildingStoredItem = true;
			Singleton<BuildManager>.Instance.StartBuildingStoredItem(this.itemInstance);
			Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_StoredItem>().currentRotation = this.rotation;
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x0010C265 File Offset: 0x0010A465
		protected virtual void StopBuildingStoredItem()
		{
			this.isBuildingStoredItem = false;
			this.rotation = Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_StoredItem>().currentRotation;
			Singleton<BuildManager>.Instance.StopBuilding();
		}

		// Token: 0x04002DB1 RID: 11697
		protected bool isBuildingStoredItem;

		// Token: 0x04002DB2 RID: 11698
		protected bool lookingAtStorageObject;

		// Token: 0x04002DB3 RID: 11699
		protected float rotation;
	}
}
