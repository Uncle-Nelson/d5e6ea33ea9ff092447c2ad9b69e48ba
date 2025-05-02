using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200091E RID: 2334
	public class Equippable_Additive : Equippable_Pourable
	{
		// Token: 0x06003F22 RID: 16162 RVA: 0x0010A684 File Offset: 0x00108884
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			this.additiveDef = (this.itemInstance.Definition as AdditiveDefinition);
			this.InteractionLabel = "Apply " + this.additiveDef.Name;
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0010A6BE File Offset: 0x001088BE
		protected override void StartPourTask(Pot pot)
		{
			new ApplyAdditiveToPot(pot, this.itemInstance, this.PourablePrefab);
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x0010A6D4 File Offset: 0x001088D4
		protected override bool CanPour(Pot pot, out string reason)
		{
			if (pot.SoilLevel < pot.SoilCapacity)
			{
				reason = "No soil";
				return false;
			}
			if (pot.Plant == null)
			{
				reason = "No plant";
				return false;
			}
			if (pot.GetAdditive(this.additiveDef.AdditivePrefab.AdditiveName) != null)
			{
				reason = "Already contains " + this.additiveDef.AdditivePrefab.AdditiveName;
				return false;
			}
			return base.CanPour(pot, out reason);
		}

		// Token: 0x04002D50 RID: 11600
		private AdditiveDefinition additiveDef;
	}
}
