using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000A68 RID: 2664
	public class ChemistryStationCanvas : Singleton<ChemistryStationCanvas>
	{
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x060047BA RID: 18362 RVA: 0x0012C706 File Offset: 0x0012A906
		// (set) Token: 0x060047BB RID: 18363 RVA: 0x0012C70E File Offset: 0x0012A90E
		public bool isOpen { get; protected set; }

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x060047BC RID: 18364 RVA: 0x0012C717 File Offset: 0x0012A917
		// (set) Token: 0x060047BD RID: 18365 RVA: 0x0012C71F File Offset: 0x0012A91F
		public ChemistryStation ChemistryStation { get; protected set; }

		// Token: 0x060047BE RID: 18366 RVA: 0x0012C728 File Offset: 0x0012A928
		protected override void Awake()
		{
			base.Awake();
			this.BeginButton.onClick.AddListener(new UnityAction(this.BeginButtonPressed));
			for (int i = 0; i < this.Recipes.Count; i++)
			{
				StationRecipeEntry component = Object.Instantiate<StationRecipeEntry>(this.RecipeEntryPrefab, this.RecipeContainer).GetComponent<StationRecipeEntry>();
				component.AssignRecipe(this.Recipes[i]);
				this.recipeEntries.Add(component);
			}
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x0012C7A2 File Offset: 0x0012A9A2
		protected override void Start()
		{
			base.Start();
			this.Close(false);
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x0012C7B4 File Offset: 0x0012A9B4
		protected virtual void Update()
		{
			if (this.isOpen)
			{
				if (this.ChemistryStation.CurrentCookOperation != null)
				{
					this.BeginButton.interactable = (this.ChemistryStation.CurrentCookOperation.CurrentTime >= this.ChemistryStation.CurrentCookOperation.Recipe.CookTime_Mins);
					this.BeginButton.gameObject.SetActive(false);
				}
				else
				{
					this.BeginButton.interactable = (this.selectedRecipe != null && this.selectedRecipe.IsValid && this.ChemistryStation.DoesOutputHaveSpace(this.selectedRecipe.Recipe));
					this.BeginButton.gameObject.SetActive(true);
				}
				if (this.BeginButton.interactable && GameInput.GetButtonDown(GameInput.ButtonCode.Submit))
				{
					this.BeginButtonPressed();
				}
				this.UpdateInput();
				this.UpdateUI();
			}
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x0012C899 File Offset: 0x0012AA99
		private void LateUpdate()
		{
			if (!this.isOpen)
			{
				return;
			}
			if (this.selectedRecipe != null)
			{
				this.SelectionIndicator.position = this.selectedRecipe.transform.position;
			}
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x0012C8D0 File Offset: 0x0012AAD0
		private void UpdateUI()
		{
			this.ErrorLabel.enabled = false;
			if (this.ChemistryStation.CurrentCookOperation != null)
			{
				this.CookingInProgressContainer.gameObject.SetActive(true);
				this.RecipeSelectionContainer.gameObject.SetActive(false);
				if (this.ChemistryStation.CurrentCookOperation.CurrentTime >= this.ChemistryStation.CurrentCookOperation.Recipe.CookTime_Mins)
				{
					this.InProgressLabel.text = "Ready to finish";
				}
				else
				{
					this.InProgressLabel.text = "Cooking in progress...";
				}
				if (this.InProgressRecipeEntry.Recipe != this.ChemistryStation.CurrentCookOperation.Recipe)
				{
					this.InProgressRecipeEntry.AssignRecipe(this.ChemistryStation.CurrentCookOperation.Recipe);
					return;
				}
			}
			else
			{
				this.RecipeSelectionContainer.gameObject.SetActive(true);
				this.CookingInProgressContainer.gameObject.SetActive(false);
				if (this.selectedRecipe != null && !this.ChemistryStation.DoesOutputHaveSpace(this.selectedRecipe.Recipe))
				{
					this.ErrorLabel.text = "Output slot does not have enough space";
					this.ErrorLabel.enabled = true;
				}
			}
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x0012CA0C File Offset: 0x0012AC0C
		private void UpdateInput()
		{
			if (this.selectedRecipe != null)
			{
				if (GameInput.MouseScrollDelta < 0f || GameInput.GetButtonDown(GameInput.ButtonCode.Backward) || Input.GetKeyDown(KeyCode.DownArrow))
				{
					if (this.recipeEntries.IndexOf(this.selectedRecipe) < this.recipeEntries.Count - 1)
					{
						StationRecipeEntry stationRecipeEntry = this.recipeEntries[this.recipeEntries.IndexOf(this.selectedRecipe) + 1];
						if (stationRecipeEntry.IsValid)
						{
							this.SetSelectedRecipe(stationRecipeEntry);
							return;
						}
					}
				}
				else if ((GameInput.MouseScrollDelta > 0f || GameInput.GetButtonDown(GameInput.ButtonCode.Forward) || Input.GetKeyDown(KeyCode.UpArrow)) && this.recipeEntries.IndexOf(this.selectedRecipe) > 0)
				{
					StationRecipeEntry stationRecipeEntry2 = this.recipeEntries[this.recipeEntries.IndexOf(this.selectedRecipe) - 1];
					if (stationRecipeEntry2.IsValid)
					{
						this.SetSelectedRecipe(stationRecipeEntry2);
					}
				}
			}
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x0012CB00 File Offset: 0x0012AD00
		public void Open(ChemistryStation station)
		{
			this.isOpen = true;
			this.ChemistryStation = station;
			this.UpdateUI();
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			}
			for (int i = 0; i < station.IngredientSlots.Length; i++)
			{
				this.InputSlotUIs[i].AssignSlot(station.IngredientSlots[i]);
				ItemSlot itemSlot = station.IngredientSlots[i];
				itemSlot.onItemDataChanged = (Action)Delegate.Combine(itemSlot.onItemDataChanged, new Action(this.StationSlotsChanged));
			}
			this.OutputSlotUI.AssignSlot(station.OutputSlot);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(true, true);
			List<ItemSlot> list = new List<ItemSlot>();
			list.AddRange(station.IngredientSlots);
			list.Add(station.OutputSlot);
			Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), list);
			Singleton<CompassManager>.Instance.SetVisible(false);
			this.StationSlotsChanged();
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x0012CC2C File Offset: 0x0012AE2C
		public void Close(bool removeUI)
		{
			this.isOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			}
			for (int i = 0; i < this.InputSlotUIs.Length; i++)
			{
				this.InputSlotUIs[i].ClearSlot();
				if (this.ChemistryStation != null)
				{
					ItemSlot itemSlot = this.ChemistryStation.IngredientSlots[i];
					itemSlot.onItemDataChanged = (Action)Delegate.Remove(itemSlot.onItemDataChanged, new Action(this.StationSlotsChanged));
				}
			}
			this.OutputSlotUI.ClearSlot();
			if (removeUI)
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(false, true);
			this.ChemistryStation = null;
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x0012CCFB File Offset: 0x0012AEFB
		public void BeginButtonPressed()
		{
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			new UseChemistryStationTask(this.ChemistryStation, this.selectedRecipe.Recipe);
			this.Close(false);
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x0012CD28 File Offset: 0x0012AF28
		private void StationSlotsChanged()
		{
			List<ItemInstance> list = new List<ItemInstance>();
			for (int i = 0; i < this.InputSlotUIs.Length; i++)
			{
				if (this.InputSlotUIs[i].assignedSlot.ItemInstance != null)
				{
					list.Add(this.InputSlotUIs[i].assignedSlot.ItemInstance);
				}
			}
			for (int j = 0; j < this.recipeEntries.Count; j++)
			{
				this.recipeEntries[j].RefreshValidity(list);
			}
			this.SortRecipes(list);
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x0012CDAC File Offset: 0x0012AFAC
		private void SortRecipes(List<ItemInstance> ingredients)
		{
			Dictionary<StationRecipeEntry, float> recipes = new Dictionary<StationRecipeEntry, float>();
			for (int i = 0; i < this.recipeEntries.Count; i++)
			{
				float ingredientsMatchDelta = this.recipeEntries[i].GetIngredientsMatchDelta(ingredients);
				recipes.Add(this.recipeEntries[i], ingredientsMatchDelta);
			}
			this.recipeEntries.Sort((StationRecipeEntry a, StationRecipeEntry b) => recipes[b].CompareTo(recipes[a]));
			for (int j = 0; j < this.recipeEntries.Count; j++)
			{
				this.recipeEntries[j].transform.SetAsLastSibling();
			}
			if (this.recipeEntries.Count > 0 && this.recipeEntries[0].IsValid)
			{
				this.SetSelectedRecipe(this.recipeEntries[0]);
				return;
			}
			this.SetSelectedRecipe(null);
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x0012CE8C File Offset: 0x0012B08C
		private void SetSelectedRecipe(StationRecipeEntry entry)
		{
			this.selectedRecipe = entry;
			if (entry != null)
			{
				this.SelectionIndicator.position = entry.transform.position;
				this.SelectionIndicator.gameObject.SetActive(true);
				return;
			}
			this.SelectionIndicator.gameObject.SetActive(false);
		}

		// Token: 0x04003521 RID: 13601
		public List<StationRecipe> Recipes = new List<StationRecipe>();

		// Token: 0x04003522 RID: 13602
		[Header("Prefabs")]
		public StationRecipeEntry RecipeEntryPrefab;

		// Token: 0x04003523 RID: 13603
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003524 RID: 13604
		public RectTransform Container;

		// Token: 0x04003525 RID: 13605
		public RectTransform InputSlotsContainer;

		// Token: 0x04003526 RID: 13606
		public ItemSlotUI[] InputSlotUIs;

		// Token: 0x04003527 RID: 13607
		public ItemSlotUI OutputSlotUI;

		// Token: 0x04003528 RID: 13608
		public RectTransform RecipeSelectionContainer;

		// Token: 0x04003529 RID: 13609
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x0400352A RID: 13610
		public Button BeginButton;

		// Token: 0x0400352B RID: 13611
		public RectTransform SelectionIndicator;

		// Token: 0x0400352C RID: 13612
		public RectTransform RecipeContainer;

		// Token: 0x0400352D RID: 13613
		public RectTransform CookingInProgressContainer;

		// Token: 0x0400352E RID: 13614
		public StationRecipeEntry InProgressRecipeEntry;

		// Token: 0x0400352F RID: 13615
		public TextMeshProUGUI InProgressLabel;

		// Token: 0x04003530 RID: 13616
		public TextMeshProUGUI ErrorLabel;

		// Token: 0x04003531 RID: 13617
		private List<StationRecipeEntry> recipeEntries = new List<StationRecipeEntry>();

		// Token: 0x04003532 RID: 13618
		private StationRecipeEntry selectedRecipe;
	}
}
