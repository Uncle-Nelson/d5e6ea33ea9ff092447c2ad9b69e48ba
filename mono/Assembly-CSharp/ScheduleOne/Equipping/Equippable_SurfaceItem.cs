using System;
using ScheduleOne.Building;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200092B RID: 2347
	public class Equippable_SurfaceItem : Equippable_StorableItem
	{
		// Token: 0x06003F87 RID: 16263 RVA: 0x0010C29C File Offset: 0x0010A49C
		protected override void Update()
		{
			base.CheckLookingAtStorageObject();
			if (this.lookingAtStorageObject && this.isBuilding)
			{
				this.isBuilding = false;
				if (Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_Surface>() != null)
				{
					this.rotation = Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_Surface>().CurrentRotation;
				}
			}
			base.Update();
			if (!this.lookingAtStorageObject && !this.isBuilding)
			{
				this.isBuilding = true;
				Singleton<BuildManager>.Instance.StartBuilding(this.itemInstance);
				if (Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_Surface>() != null)
				{
					Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_Surface>().CurrentRotation = this.rotation;
				}
			}
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x0010C355 File Offset: 0x0010A555
		public override void Unequip()
		{
			if (this.isBuilding)
			{
				Singleton<BuildManager>.Instance.StopBuilding();
			}
			base.Unequip();
		}

		// Token: 0x04002DB4 RID: 11700
		protected bool isBuilding;
	}
}
