using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.PlayerTasks.Tasks;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200091C RID: 2332
	public class Equippable_WateringCan : Equippable_Pourable
	{
		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x0010A50B File Offset: 0x0010870B
		// (set) Token: 0x06003F18 RID: 16152 RVA: 0x0010A513 File Offset: 0x00108713
		public override string InteractionLabel { get; set; } = "Pour water";

		// Token: 0x06003F19 RID: 16153 RVA: 0x0010A51C File Offset: 0x0010871C
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			this.WCInstance = (item as WateringCanInstance);
			this.UpdateVisuals();
			item.onDataChanged = (Action)Delegate.Combine(item.onDataChanged, new Action(this.UpdateVisuals));
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0010A559 File Offset: 0x00108759
		public override void Unequip()
		{
			base.Unequip();
			if (this.WCInstance != null)
			{
				WateringCanInstance wcinstance = this.WCInstance;
				wcinstance.onDataChanged = (Action)Delegate.Remove(wcinstance.onDataChanged, new Action(this.UpdateVisuals));
			}
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x0010A590 File Offset: 0x00108790
		private void UpdateVisuals()
		{
			if (this.WCInstance == null)
			{
				return;
			}
			this.Visuals.SetFillLevel(this.WCInstance.CurrentFillAmount / 15f);
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x0010A5B8 File Offset: 0x001087B8
		protected override bool CanPour(Pot pot, out string reason)
		{
			if (pot.SoilLevel < pot.SoilCapacity)
			{
				reason = "No soil";
				return false;
			}
			if (pot.NormalizedWaterLevel >= 0.975f)
			{
				reason = string.Empty;
				return false;
			}
			if ((this.itemInstance as WateringCanInstance).CurrentFillAmount <= 0f)
			{
				reason = "Watering can empty";
				return false;
			}
			return base.CanPour(pot, out reason);
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x0010A61A File Offset: 0x0010881A
		protected override void StartPourTask(Pot pot)
		{
			new PourWaterTask(pot, this.itemInstance, this.PourablePrefab);
		}

		// Token: 0x04002D4B RID: 11595
		public WateringCanVisuals Visuals;

		// Token: 0x04002D4C RID: 11596
		private WateringCanInstance WCInstance;
	}
}
