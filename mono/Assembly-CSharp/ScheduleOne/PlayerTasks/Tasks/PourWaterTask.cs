using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x0200035C RID: 860
	public class PourWaterTask : PourOntoTargetTask
	{
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x000022C9 File Offset: 0x000004C9
		protected override bool UseCoverage
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x000141BA File Offset: 0x000123BA
		protected override bool FailOnEmpty
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x000523A3 File Offset: 0x000505A3
		protected override Pot.ECameraPosition CameraPosition
		{
			get
			{
				return Pot.ECameraPosition.BirdsEye;
			}
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00056B10 File Offset: 0x00054D10
		public PourWaterTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : base(_pot, _itemInstance, _pourablePrefab)
		{
			base.CurrentInstruction = "Pour water over target";
			this.removeItemAfterInitialPour = false;
			this.pourable.GetComponent<FunctionalWateringCan>().Setup(_itemInstance as WateringCanInstance);
			this.pourable.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
			this.pot.SoilCover.ConfigureAppearance(Color.black, 0.6f);
			if (NetworkSingleton<GameManager>.Instance.IsTutorial && !PourWaterTask.hintShown)
			{
				PourWaterTask.hintShown = true;
				Singleton<HintDisplay>.Instance.ShowHint_20s("While dragging an item, press <Input_Left> or <Input_Right> to rotate it.");
			}
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00056BB4 File Offset: 0x00054DB4
		public override void StopTask()
		{
			this.pot.PushWaterDataToServer();
			base.StopTask();
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00056BC8 File Offset: 0x00054DC8
		public override void TargetReached()
		{
			this.pot.ChangeWaterAmount(0.2f * this.pot.WaterCapacity);
			this.pot.PushWaterDataToServer();
			if (this.pot.NormalizedWaterLevel >= 0.975f)
			{
				this.Success();
				float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("WateredPotsCount");
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("WateredPotsCount", (value + 1f).ToString(), true);
			}
			base.TargetReached();
		}

		// Token: 0x040012A3 RID: 4771
		public const float NORMALIZED_FILL_PER_TARGET = 0.2f;

		// Token: 0x040012A4 RID: 4772
		public static bool hintShown;
	}
}
