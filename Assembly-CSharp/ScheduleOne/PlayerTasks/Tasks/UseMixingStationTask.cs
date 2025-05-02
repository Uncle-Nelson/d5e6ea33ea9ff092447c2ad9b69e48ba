using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.StationFramework;
using ScheduleOne.Trash;
using ScheduleOne.UI;
using ScheduleOne.UI.Stations;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x0200035D RID: 861
	public class UseMixingStationTask : Task
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x00056C49 File Offset: 0x00054E49
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x00056C51 File Offset: 0x00054E51
		public MixingStation Station { get; private set; }

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00056C5A File Offset: 0x00054E5A
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x00056C62 File Offset: 0x00054E62
		public UseMixingStationTask.EStep CurrentStep { get; private set; }

		// Token: 0x0600137B RID: 4987 RVA: 0x00056C6B File Offset: 0x00054E6B
		public static string GetStepDescription(UseMixingStationTask.EStep step)
		{
			if (step == UseMixingStationTask.EStep.CombineIngredients)
			{
				return "Combine ingredients in bowl";
			}
			if (step != UseMixingStationTask.EStep.StartMixing)
			{
				return "Unknown step";
			}
			return "Start mixing machine";
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00056C88 File Offset: 0x00054E88
		public UseMixingStationTask(MixingStation station)
		{
			UseMixingStationTask.<>c__DisplayClass15_0 CS$<>8__locals1;
			CS$<>8__locals1.station = station;
			base..ctor();
			CS$<>8__locals1.<>4__this = this;
			this.Station = CS$<>8__locals1.station;
			this.Station.onStartButtonClicked.AddListener(new UnityAction(this.StartButtonPressed));
			this.ClickDetectionRadius = 0.012f;
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.Station.CameraPosition_CombineIngredients.position, this.Station.CameraPosition_CombineIngredients.rotation, 0.2f, false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(this.TaskName);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			this.removedIngredients = new ItemInstance[2];
			int mixQuantity = CS$<>8__locals1.station.GetMixQuantity();
			this.removedIngredients[0] = CS$<>8__locals1.station.ProductSlot.ItemInstance.GetCopy(mixQuantity);
			this.removedIngredients[1] = CS$<>8__locals1.station.MixerSlot.ItemInstance.GetCopy(mixQuantity);
			CS$<>8__locals1.station.ProductSlot.ChangeQuantity(-mixQuantity, false);
			CS$<>8__locals1.station.MixerSlot.ChangeQuantity(-mixQuantity, false);
			base.EnableMultiDragging(CS$<>8__locals1.station.ItemContainer, 0.12f);
			int num = 0;
			Singleton<InputPromptsCanvas>.Instance.LoadModule("packaging");
			for (int i = 0; i < mixQuantity; i++)
			{
				this.<.ctor>g__SetupIngredient|15_0(this.removedIngredients[1].Definition as StorableItemDefinition, num, true, ref CS$<>8__locals1);
				num++;
			}
			for (int j = 0; j < mixQuantity; j++)
			{
				this.<.ctor>g__SetupIngredient|15_0(this.removedIngredients[0].Definition as StorableItemDefinition, num, false, ref CS$<>8__locals1);
				num++;
			}
			if (this.Jug != null)
			{
				this.Jug.Pourable.LiquidCapacity_L = this.Jug.Fillable.LiquidCapacity_L;
				this.Jug.Pourable.DefaultLiquid_L = this.Jug.Fillable.GetTotalLiquidVolume();
				this.Jug.Pourable.SetLiquidLevel(this.Jug.Pourable.DefaultLiquid_L);
				this.Jug.Pourable.PourParticlesColor = this.Jug.Fillable.LiquidContainer.LiquidColor;
				this.Jug.Pourable.LiquidColor = this.Jug.Fillable.LiquidContainer.LiquidColor;
				this.Jug.Pourable.PourParticles[0].trigger.AddCollider(this.Station.BowlFillable.LiquidContainer.Collider);
				this.Jug.Fillable.FillableEnabled = false;
			}
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00056F48 File Offset: 0x00055148
		private Beaker CreateJug()
		{
			Beaker component = Object.Instantiate<GameObject>(this.Station.JugPrefab, this.Station.ItemContainer).GetComponent<Beaker>();
			component.transform.position = this.Station.JugAlignment.position;
			component.transform.rotation = this.Station.JugAlignment.rotation;
			component.GetComponent<DraggableConstraint>().Container = this.Station.ItemContainer;
			component.ActivateModule<PourableModule>();
			return component;
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00056FC7 File Offset: 0x000551C7
		public override void Update()
		{
			base.Update();
			this.CheckProgress();
			this.UpdateInstruction();
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00056FDC File Offset: 0x000551DC
		private void UpdateInstruction()
		{
			base.CurrentInstruction = UseMixingStationTask.GetStepDescription(this.CurrentStep);
			if (this.CurrentStep == UseMixingStationTask.EStep.CombineIngredients)
			{
				int num = this.items.Count;
				if (this.Jug != null)
				{
					num++;
				}
				int combinedIngredients = this.GetCombinedIngredients();
				base.CurrentInstruction = string.Concat(new string[]
				{
					base.CurrentInstruction,
					" (",
					combinedIngredients.ToString(),
					"/",
					num.ToString(),
					")"
				});
			}
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0005706D File Offset: 0x0005526D
		private void CheckProgress()
		{
			if (this.CurrentStep == UseMixingStationTask.EStep.CombineIngredients)
			{
				this.CheckStep_CombineIngredients();
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0005707D File Offset: 0x0005527D
		private void CheckStep_CombineIngredients()
		{
			if (this.GetCombinedIngredients() >= this.items.Count + ((this.Jug != null) ? 1 : 0))
			{
				this.ProgressStep();
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x000570AC File Offset: 0x000552AC
		private int GetCombinedIngredients()
		{
			int num = 0;
			for (int i = 0; i < this.items.Count; i++)
			{
				if (this.items[i].HasModule<IngredientModule>())
				{
					IngredientModule module = this.items[i].GetModule<IngredientModule>();
					bool flag = true;
					IngredientPiece[] pieces = module.Pieces;
					for (int j = 0; j < pieces.Length; j++)
					{
						if (pieces[j].CurrentLiquidContainer != this.Station.BowlFillable.LiquidContainer)
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						num++;
					}
				}
				else if (this.items[i].HasModule<PourableModule>() && this.items[i].GetModule<PourableModule>().NormalizedLiquidLevel <= 0.02f)
				{
					num++;
				}
			}
			if (this.Jug != null && this.Jug.Pourable.NormalizedLiquidLevel <= 0.02f)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x000571A0 File Offset: 0x000553A0
		private void ProgressStep()
		{
			UseMixingStationTask.EStep currentStep = this.CurrentStep;
			this.CurrentStep = currentStep + 1;
			if (this.CurrentStep == UseMixingStationTask.EStep.StartMixing)
			{
				this.Station.SetStartButtonClickable(true);
			}
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x000571D2 File Offset: 0x000553D2
		private void StartButtonPressed()
		{
			if (this.CurrentStep == UseMixingStationTask.EStep.StartMixing)
			{
				this.Success();
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x000571E4 File Offset: 0x000553E4
		public override void Success()
		{
			ProductItemInstance productItemInstance = this.removedIngredients[0] as ProductItemInstance;
			string id = this.removedIngredients[1].Definition.ID;
			this.CreateTrash();
			Singleton<MixingStationCanvas>.Instance.StartMixOperation(new MixOperation(productItemInstance.ID, productItemInstance.Quality, id, productItemInstance.Quantity));
			base.Success();
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00057240 File Offset: 0x00055440
		private void CreateTrash()
		{
			BoxCollider trashSpawnVolume = this.Station.TrashSpawnVolume;
			for (int i = 0; i < Mathf.CeilToInt((float)this.mixerItems.Count / 2f); i++)
			{
				if (!(this.mixerItems[0].TrashPrefab == null))
				{
					Vector3 posiiton = trashSpawnVolume.transform.TransformPoint(new Vector3(Random.Range(-trashSpawnVolume.size.x / 2f, trashSpawnVolume.size.x / 2f), 0f, Random.Range(-trashSpawnVolume.size.z / 2f, trashSpawnVolume.size.z / 2f)));
					Vector3 vector = trashSpawnVolume.transform.forward;
					vector = Quaternion.Euler(0f, Random.Range(-45f, 45f), 0f) * vector;
					float d = Random.Range(0.25f, 0.4f);
					NetworkSingleton<TrashManager>.Instance.CreateTrashItem(this.mixerItems[0].TrashPrefab.ID, posiiton, Random.rotation, vector * d, "", false);
				}
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0005737C File Offset: 0x0005557C
		public override void StopTask()
		{
			this.Station.onStartButtonClicked.RemoveListener(new UnityAction(this.StartButtonPressed));
			this.Station.BowlFillable.ResetContents();
			if (this.Outcome != Task.EOutcome.Success)
			{
				this.Station.ProductSlot.AddItem(this.removedIngredients[0], false);
				this.Station.MixerSlot.AddItem(this.removedIngredients[1], false);
			}
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			foreach (StationItem stationItem in this.items)
			{
				stationItem.Destroy();
			}
			this.items.Clear();
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(this.TaskName);
			this.Station.Open();
			if (this.Jug != null)
			{
				Object.Destroy(this.Jug.gameObject);
			}
			base.StopTask();
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00057488 File Offset: 0x00055688
		[CompilerGenerated]
		private void <.ctor>g__SetupIngredient|15_0(StorableItemDefinition def, int index, bool mixer, ref UseMixingStationTask.<>c__DisplayClass15_0 A_4)
		{
			if (def.StationItem == null)
			{
				Console.LogError("Ingredient '" + def.Name + "' does not have a station item", null);
				return;
			}
			if (mixer)
			{
				this.mixerItems.Add(def.StationItem);
			}
			if (def.StationItem.HasModule<PourableModule>())
			{
				if (this.Jug == null)
				{
					this.Jug = this.CreateJug();
				}
				PourableModule module = def.StationItem.GetModule<PourableModule>();
				this.Jug.Fillable.AddLiquid(module.LiquidType, module.LiquidCapacity_L, module.LiquidColor);
				return;
			}
			StationItem stationItem = Object.Instantiate<StationItem>(def.StationItem, A_4.station.ItemContainer);
			stationItem.transform.rotation = A_4.station.IngredientTransforms[this.items.Count].rotation;
			Vector3 eulerAngles = stationItem.transform.eulerAngles;
			eulerAngles.y = Random.Range(0f, 360f);
			stationItem.transform.eulerAngles = eulerAngles;
			stationItem.transform.position = A_4.station.IngredientTransforms[this.items.Count].position;
			stationItem.Initialize(def);
			if (stationItem.HasModule<IngredientModule>())
			{
				stationItem.ActivateModule<IngredientModule>();
				foreach (IngredientPiece ingredientPiece in stationItem.GetModule<IngredientModule>().Pieces)
				{
					this.ingredientPieces.Add(ingredientPiece);
					ingredientPiece.DisableInteractionInLiquid = false;
				}
			}
			else
			{
				Console.LogError("Ingredient '" + def.Name + "' does not have an ingredient or pourable module", null);
			}
			foreach (Draggable draggable in stationItem.GetComponentsInChildren<Draggable>())
			{
				draggable.DragProjectionMode = Draggable.EDragProjectionMode.FlatCameraForward;
				DraggableConstraint component = draggable.gameObject.GetComponent<DraggableConstraint>();
				if (component != null)
				{
					component.ProportionalZClamp = true;
				}
			}
			this.items.Add(stationItem);
		}

		// Token: 0x040012A7 RID: 4775
		private List<StationItem> items = new List<StationItem>();

		// Token: 0x040012A8 RID: 4776
		private List<StationItem> mixerItems = new List<StationItem>();

		// Token: 0x040012A9 RID: 4777
		private List<IngredientPiece> ingredientPieces = new List<IngredientPiece>();

		// Token: 0x040012AA RID: 4778
		private ItemInstance[] removedIngredients;

		// Token: 0x040012AB RID: 4779
		private Beaker Jug;

		// Token: 0x0200035E RID: 862
		public enum EStep
		{
			// Token: 0x040012AD RID: 4781
			CombineIngredients,
			// Token: 0x040012AE RID: 4782
			StartMixing
		}
	}
}
