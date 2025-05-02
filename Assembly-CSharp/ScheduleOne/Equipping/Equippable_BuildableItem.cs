using System;
using ScheduleOne.Building;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Equipping
{
	// Token: 0x02000920 RID: 2336
	public class Equippable_BuildableItem : Equippable_StorableItem
	{
		// Token: 0x06003F2C RID: 16172 RVA: 0x0010A858 File Offset: 0x00108A58
		protected override void Update()
		{
			base.CheckLookingAtStorageObject();
			if (this.lookingAtStorageObject && this.isBuilding)
			{
				this.isBuilding = false;
				if (Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_Grid>() != null)
				{
					this.rotation = Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_Grid>().CurrentRotation;
				}
			}
			base.Update();
			if (!this.lookingAtStorageObject && !this.isBuilding)
			{
				this.isBuilding = true;
				Singleton<BuildManager>.Instance.StartBuilding(this.itemInstance);
				if (Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_Grid>() != null)
				{
					Singleton<BuildManager>.Instance.currentBuildHandler.GetComponent<BuildUpdate_Grid>().CurrentRotation = this.rotation;
				}
			}
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x0010A911 File Offset: 0x00108B11
		public override void Unequip()
		{
			if (this.isBuilding)
			{
				Singleton<BuildManager>.Instance.StopBuilding();
			}
			base.Unequip();
		}

		// Token: 0x04002D56 RID: 11606
		protected bool isBuilding;
	}
}
