using System;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks.Tasks;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000343 RID: 835
	public class ApplyAdditiveToPot : PourIntoPotTask
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x000022C9 File Offset: 0x000004C9
		protected override bool UseCoverage
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x000523A3 File Offset: 0x000505A3
		protected override Pot.ECameraPosition CameraPosition
		{
			get
			{
				return Pot.ECameraPosition.BirdsEye;
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000523A8 File Offset: 0x000505A8
		public ApplyAdditiveToPot(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : base(_pot, _itemInstance, _pourablePrefab)
		{
			this.def = (_itemInstance.Definition as AdditiveDefinition);
			base.CurrentInstruction = "Cover soil with " + this.def.AdditivePrefab.AdditiveName + " (0%)";
			this.removeItemAfterInitialPour = false;
			this.pot.SoilCover.ConfigureAppearance((this.pourable as PourableAdditive).LiquidColor, 0.3f);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00052420 File Offset: 0x00050620
		public override void Update()
		{
			base.Update();
			int num = Mathf.FloorToInt(this.pot.SoilCover.GetNormalizedProgress() * 100f);
			base.CurrentInstruction = string.Concat(new string[]
			{
				"Cover soil with ",
				this.def.AdditivePrefab.AdditiveName,
				" (",
				num.ToString(),
				"%)"
			});
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00052495 File Offset: 0x00050695
		protected override void FullyCovered()
		{
			base.FullyCovered();
			this.pot.SendAdditive((this.pourable as PourableAdditive).AdditiveDefinition.AdditivePrefab.AssetPath, true);
			base.RemoveItem();
			this.Success();
		}

		// Token: 0x04001227 RID: 4647
		private AdditiveDefinition def;
	}
}
