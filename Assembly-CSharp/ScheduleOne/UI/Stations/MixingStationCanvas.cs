using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks.Tasks;
using ScheduleOne.Product;
using ScheduleOne.Properties;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Items;
using ScheduleOne.Variables;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	// Token: 0x02000A71 RID: 2673
	public class MixingStationCanvas : Singleton<MixingStationCanvas>
	{
		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060047FC RID: 18428 RVA: 0x0012DF06 File Offset: 0x0012C106
		// (set) Token: 0x060047FD RID: 18429 RVA: 0x0012DF0E File Offset: 0x0012C10E
		public bool isOpen { get; protected set; }

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060047FE RID: 18430 RVA: 0x0012DF17 File Offset: 0x0012C117
		// (set) Token: 0x060047FF RID: 18431 RVA: 0x0012DF1F File Offset: 0x0012C11F
		public MixingStation MixingStation { get; protected set; }

		// Token: 0x06004800 RID: 18432 RVA: 0x0012DF28 File Offset: 0x0012C128
		protected override void Awake()
		{
			base.Awake();
			this.BeginButton.onClick.AddListener(new UnityAction(this.BeginButtonPressed));
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x0012DF4C File Offset: 0x0012C14C
		protected override void Start()
		{
			base.Start();
			this.isOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(true);
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x0012DF8C File Offset: 0x0012C18C
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.isOpen)
			{
				return;
			}
			if (action.exitType != ExitType.Escape)
			{
				return;
			}
			action.used = true;
			if (Singleton<NewMixScreen>.Instance.IsOpen)
			{
				Singleton<NewMixScreen>.Instance.Close();
			}
			this.Close(true);
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x0012DFD9 File Offset: 0x0012C1D9
		protected virtual void Update()
		{
			if (this.isOpen)
			{
				if (this.BeginButton.interactable && GameInput.GetButtonDown(GameInput.ButtonCode.Submit))
				{
					this.BeginButtonPressed();
					return;
				}
				this.UpdateInput();
				this.UpdateUI();
			}
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x000045B1 File Offset: 0x000027B1
		private void UpdateUI()
		{
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x0012E00C File Offset: 0x0012C20C
		private void UpdateInput()
		{
			this.UpdateDisplayMode();
			this.UpdateInstruction();
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x0012E01C File Offset: 0x0012C21C
		public void Open(MixingStation station)
		{
			this.isOpen = true;
			this.MixingStation = station;
			this.UpdateUI();
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>("MixingHintsShown"))
			{
				this.MixerHint.gameObject.SetActive(true);
				this.ProductHint.gameObject.SetActive(true);
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("MixingHintsShown", true.ToString(), true);
			}
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			}
			this.ProductSlotUI.AssignSlot(station.ProductSlot);
			this.IngredientSlotUI.AssignSlot(station.MixerSlot);
			this.OutputSlotUI.AssignSlot(station.OutputSlot);
			ItemSlot productSlot = station.ProductSlot;
			productSlot.onItemDataChanged = (Action)Delegate.Combine(productSlot.onItemDataChanged, new Action(this.StationContentsChanged));
			ItemSlot mixerSlot = station.MixerSlot;
			mixerSlot.onItemDataChanged = (Action)Delegate.Combine(mixerSlot.onItemDataChanged, new Action(this.StationContentsChanged));
			ItemSlot outputSlot = station.OutputSlot;
			outputSlot.onItemDataChanged = (Action)Delegate.Combine(outputSlot.onItemDataChanged, new Action(this.StationContentsChanged));
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(true, true);
			List<ItemSlot> list = new List<ItemSlot>();
			list.Add(station.ProductSlot);
			list.Add(station.MixerSlot);
			list.Add(station.OutputSlot);
			Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), list);
			this.UpdateDisplayMode();
			this.UpdateInstruction();
			this.UpdatePreview();
			this.UpdateBeginButton();
			ProductDefinition productDefinition;
			if (station.IsMixingDone && !station.CurrentMixOperation.IsOutputKnown(out productDefinition))
			{
				List<Property> properties;
				station.CurrentMixOperation.GetOutput(out properties);
				ProductDefinition item = Registry.GetItem<ProductDefinition>(this.MixingStation.CurrentMixOperation.ProductID);
				station.DiscoveryBox.ShowProduct(item, properties);
				station.DiscoveryBox.transform.SetParent(PlayerSingleton<PlayerCamera>.Instance.transform);
				station.DiscoveryBox.transform.localPosition = station.DiscoveryBoxOffset;
				station.DiscoveryBox.transform.localRotation = station.DiscoveryBoxRotation;
				float productMarketValue = ProductManager.CalculateProductValue(item.BasePrice, properties);
				Singleton<NewMixScreen>.Instance.Open(properties, item.DrugType, productMarketValue);
				NewMixScreen instance = Singleton<NewMixScreen>.Instance;
				instance.onMixNamed = (Action<string>)Delegate.Remove(instance.onMixNamed, new Action<string>(this.MixNamed));
				NewMixScreen instance2 = Singleton<NewMixScreen>.Instance;
				instance2.onMixNamed = (Action<string>)Delegate.Combine(instance2.onMixNamed, new Action<string>(this.MixNamed));
			}
			else
			{
				station.onMixDone.RemoveListener(new UnityAction(this.MixingDone));
				station.onMixDone.AddListener(new UnityAction(this.MixingDone));
			}
			Singleton<CompassManager>.Instance.SetVisible(false);
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x0012E330 File Offset: 0x0012C530
		public void Close(bool enablePlayerControl = true)
		{
			this.isOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			}
			this.ProductSlotUI.ClearSlot();
			this.IngredientSlotUI.ClearSlot();
			this.OutputSlotUI.ClearSlot();
			ItemSlot productSlot = this.MixingStation.ProductSlot;
			productSlot.onItemDataChanged = (Action)Delegate.Remove(productSlot.onItemDataChanged, new Action(this.StationContentsChanged));
			ItemSlot mixerSlot = this.MixingStation.MixerSlot;
			mixerSlot.onItemDataChanged = (Action)Delegate.Remove(mixerSlot.onItemDataChanged, new Action(this.StationContentsChanged));
			ItemSlot outputSlot = this.MixingStation.OutputSlot;
			outputSlot.onItemDataChanged = (Action)Delegate.Remove(outputSlot.onItemDataChanged, new Action(this.StationContentsChanged));
			this.MixingStation.onMixDone.RemoveListener(new UnityAction(this.MixingDone));
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(false, true);
			if (enablePlayerControl)
			{
				this.MixingStation.Close();
				this.MixingStation = null;
			}
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x0012E464 File Offset: 0x0012C664
		private void MixingDone()
		{
			ProductDefinition productDefinition;
			if (this.MixingStation.IsMixingDone && !this.MixingStation.CurrentMixOperation.IsOutputKnown(out productDefinition))
			{
				List<Property> properties;
				this.MixingStation.CurrentMixOperation.GetOutput(out properties);
				ProductDefinition item = Registry.GetItem<ProductDefinition>(this.MixingStation.CurrentMixOperation.ProductID);
				this.MixingStation.DiscoveryBox.ShowProduct(item, properties);
				this.MixingStation.DiscoveryBox.transform.SetParent(PlayerSingleton<PlayerCamera>.Instance.transform);
				this.MixingStation.DiscoveryBox.transform.localPosition = this.MixingStation.DiscoveryBoxOffset;
				this.MixingStation.DiscoveryBox.transform.localRotation = this.MixingStation.DiscoveryBoxRotation;
				float productMarketValue = ProductManager.CalculateProductValue(item.BasePrice, properties);
				Singleton<NewMixScreen>.Instance.Open(properties, item.DrugType, productMarketValue);
				NewMixScreen instance = Singleton<NewMixScreen>.Instance;
				instance.onMixNamed = (Action<string>)Delegate.Remove(instance.onMixNamed, new Action<string>(this.MixNamed));
				NewMixScreen instance2 = Singleton<NewMixScreen>.Instance;
				instance2.onMixNamed = (Action<string>)Delegate.Combine(instance2.onMixNamed, new Action<string>(this.MixNamed));
			}
			this.UpdateDisplayMode();
			this.UpdateInstruction();
			this.UpdatePreview();
			this.UpdateBeginButton();
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x0012E5B8 File Offset: 0x0012C7B8
		private void StationContentsChanged()
		{
			this.UpdateDisplayMode();
			this.UpdatePreview();
			this.UpdateBeginButton();
			if (this.MixingStation.ProductSlot.Quantity > 0)
			{
				this.ProductHint.gameObject.SetActive(false);
			}
			if (this.MixingStation.MixerSlot.Quantity > 0)
			{
				this.MixerHint.gameObject.SetActive(false);
			}
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x0012E620 File Offset: 0x0012C820
		private void UpdateDisplayMode()
		{
			this.TitleContainer.gameObject.SetActive(true);
			this.MainContainer.gameObject.SetActive(true);
			this.OutputSlotUI.gameObject.SetActive(false);
			if (this.MixingStation.OutputSlot.Quantity > 0)
			{
				this.MainContainer.gameObject.SetActive(false);
				this.OutputSlotUI.gameObject.SetActive(true);
				return;
			}
			ProductDefinition productDefinition;
			if (this.MixingStation.CurrentMixOperation != null && this.MixingStation.IsMixingDone && !this.MixingStation.CurrentMixOperation.IsOutputKnown(out productDefinition))
			{
				this.TitleContainer.gameObject.SetActive(false);
				this.MainContainer.gameObject.SetActive(false);
				this.OutputSlotUI.gameObject.SetActive(false);
				return;
			}
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x0012E6F8 File Offset: 0x0012C8F8
		private void UpdateInstruction()
		{
			this.InstructionLabel.enabled = true;
			if (this.MixingStation.OutputSlot.Quantity > 0)
			{
				this.InstructionLabel.text = "Collect output";
				return;
			}
			if (this.MixingStation.CurrentMixOperation != null)
			{
				this.InstructionLabel.text = "Mixing in progress...";
				return;
			}
			if (!this.MixingStation.CanStartMix())
			{
				this.InstructionLabel.text = "Insert unpackaged product and mixing ingredient";
				return;
			}
			this.InstructionLabel.enabled = false;
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x0012E780 File Offset: 0x0012C980
		private void UpdatePreview()
		{
			ProductDefinition product = this.MixingStation.GetProduct();
			PropertyItemDefinition mixer = this.MixingStation.GetMixer();
			if (product != null)
			{
				this.ProductPropertiesLabel.text = this.GetPropertyListString(product.Properties);
				this.ProductPropertiesLabel.enabled = true;
			}
			else
			{
				this.ProductPropertiesLabel.enabled = false;
			}
			if (mixer == null && this.MixingStation.MixerSlot.Quantity > 0)
			{
				this.IngredientProblemLabel.enabled = true;
			}
			else
			{
				this.IngredientProblemLabel.enabled = false;
			}
			this.UnknownOutputIcon.gameObject.SetActive(false);
			if (!(product != null) || !(mixer != null))
			{
				this.PreviewIcon.enabled = false;
				this.PreviewLabel.enabled = false;
				this.PreviewPropertiesLabel.enabled = false;
				return;
			}
			List<Property> outputProperties = this.GetOutputProperties(product, mixer);
			ProductDefinition knownProduct = NetworkSingleton<ProductManager>.Instance.GetKnownProduct(product.DrugTypes[0].DrugType, outputProperties);
			if (knownProduct == null)
			{
				this.PreviewIcon.sprite = product.Icon;
				this.PreviewIcon.color = Color.black;
				this.PreviewIcon.enabled = true;
				this.PreviewLabel.text = "Unknown";
				this.PreviewLabel.enabled = true;
				this.UnknownOutputIcon.gameObject.SetActive(true);
				this.PreviewPropertiesLabel.text = string.Empty;
				for (int i = 0; i < outputProperties.Count; i++)
				{
					if (product.Properties.Contains(outputProperties[i]))
					{
						if (this.PreviewPropertiesLabel.text.Length > 0)
						{
							TextMeshProUGUI previewPropertiesLabel = this.PreviewPropertiesLabel;
							previewPropertiesLabel.text += "\n";
						}
						TextMeshProUGUI previewPropertiesLabel2 = this.PreviewPropertiesLabel;
						previewPropertiesLabel2.text += this.GetPropertyString(outputProperties[i]);
					}
					else
					{
						if (this.PreviewPropertiesLabel.text.Length > 0)
						{
							TextMeshProUGUI previewPropertiesLabel3 = this.PreviewPropertiesLabel;
							previewPropertiesLabel3.text += "\n";
						}
						TextMeshProUGUI previewPropertiesLabel4 = this.PreviewPropertiesLabel;
						previewPropertiesLabel4.text = previewPropertiesLabel4.text + "<color=#" + ColorUtility.ToHtmlStringRGBA(outputProperties[i].LabelColor) + ">• ?</color>";
					}
				}
				this.PreviewPropertiesLabel.enabled = true;
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.PreviewPropertiesLabel.rectTransform);
				return;
			}
			this.PreviewIcon.sprite = knownProduct.Icon;
			this.PreviewIcon.color = Color.white;
			this.PreviewIcon.enabled = true;
			this.PreviewLabel.text = knownProduct.Name;
			this.PreviewLabel.enabled = true;
			this.UnknownOutputIcon.gameObject.SetActive(false);
			this.PreviewPropertiesLabel.text = this.GetPropertyListString(knownProduct.Properties);
			this.PreviewPropertiesLabel.enabled = true;
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.PreviewPropertiesLabel.rectTransform);
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x0012EA90 File Offset: 0x0012CC90
		private string GetPropertyListString(List<Property> properties)
		{
			string text = "";
			for (int i = 0; i < properties.Count; i++)
			{
				if (i > 0)
				{
					text += "\n";
				}
				text += this.GetPropertyString(properties[i]);
			}
			return text;
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x0011BBA3 File Offset: 0x00119DA3
		private string GetPropertyString(Property property)
		{
			return string.Concat(new string[]
			{
				"<color=#",
				ColorUtility.ToHtmlStringRGBA(property.LabelColor),
				">• ",
				property.Name,
				"</color>"
			});
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x0012EADC File Offset: 0x0012CCDC
		private List<Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			List<Property> properties = product.Properties;
			List<Property> properties2 = mixer.Properties;
			return PropertyMixCalculator.MixProperties(properties, properties2[0], product.DrugType);
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x0012EB08 File Offset: 0x0012CD08
		private bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			knownProduct = null;
			ProductDefinition product = this.MixingStation.GetProduct();
			PropertyItemDefinition mixer = this.MixingStation.GetMixer();
			if (product != null && mixer != null)
			{
				List<Property> outputProperties = this.GetOutputProperties(product, mixer);
				knownProduct = NetworkSingleton<ProductManager>.Instance.GetKnownProduct(product.DrugTypes[0].DrugType, outputProperties);
			}
			return knownProduct != null;
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x0012EB74 File Offset: 0x0012CD74
		private void UpdateBeginButton()
		{
			if (this.MixingStation.CurrentMixOperation != null || this.MixingStation.OutputSlot.Quantity > 0)
			{
				this.BeginButton.gameObject.SetActive(false);
				return;
			}
			this.BeginButton.gameObject.SetActive(true);
			this.BeginButton.interactable = this.MixingStation.CanStartMix();
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x0012EBDC File Offset: 0x0012CDDC
		public void BeginButtonPressed()
		{
			int mixQuantity = this.MixingStation.GetMixQuantity();
			if (mixQuantity <= 0)
			{
				Console.LogWarning("Failed to start mixing operation, not enough ingredients or output slot is full", null);
				return;
			}
			bool flag = false;
			if (Application.isEditor && Input.GetKey(KeyCode.R))
			{
				flag = true;
			}
			if (this.MixingStation.RequiresIngredientInsertion && !flag)
			{
				MixingStation mixingStation = this.MixingStation;
				this.Close(false);
				new UseMixingStationTask(mixingStation);
				return;
			}
			ProductItemInstance productItemInstance = this.MixingStation.ProductSlot.ItemInstance as ProductItemInstance;
			string id = this.MixingStation.MixerSlot.ItemInstance.ID;
			this.MixingStation.ProductSlot.ChangeQuantity(-mixQuantity, false);
			this.MixingStation.MixerSlot.ChangeQuantity(-mixQuantity, false);
			this.StartMixOperation(new MixOperation(productItemInstance.ID, productItemInstance.Quality, id, mixQuantity));
			this.Close(true);
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x0012ECB4 File Offset: 0x0012CEB4
		public void StartMixOperation(MixOperation mixOperation)
		{
			this.MixingStation.SendMixingOperation(mixOperation, 0);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Mixing_Operations_Started", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Mixing_Operations_Started") + 1f).ToString(), true);
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x0012ECFC File Offset: 0x0012CEFC
		private void MixNamed(string mixName)
		{
			if (this.MixingStation == null)
			{
				Console.LogWarning("Mixing station is null, cannot finish mix operation", null);
				return;
			}
			if (this.MixingStation.CurrentMixOperation == null)
			{
				Console.LogWarning("Mixing station current mix operation is null, cannot finish mix operation", null);
				return;
			}
			NetworkSingleton<ProductManager>.Instance.FinishAndNameMix(this.MixingStation.CurrentMixOperation.ProductID, this.MixingStation.CurrentMixOperation.IngredientID, mixName);
			this.MixingStation.TryCreateOutputItems();
			this.MixingStation.DiscoveryBox.gameObject.SetActive(false);
			this.UpdateDisplayMode();
		}

		// Token: 0x04003560 RID: 13664
		[Header("Prefabs")]
		public StationRecipeEntry RecipeEntryPrefab;

		// Token: 0x04003561 RID: 13665
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003562 RID: 13666
		public RectTransform Container;

		// Token: 0x04003563 RID: 13667
		public ItemSlotUI ProductSlotUI;

		// Token: 0x04003564 RID: 13668
		public TextMeshProUGUI ProductPropertiesLabel;

		// Token: 0x04003565 RID: 13669
		public ItemSlotUI IngredientSlotUI;

		// Token: 0x04003566 RID: 13670
		public TextMeshProUGUI IngredientProblemLabel;

		// Token: 0x04003567 RID: 13671
		public ItemSlotUI PreviewSlotUI;

		// Token: 0x04003568 RID: 13672
		public Image PreviewIcon;

		// Token: 0x04003569 RID: 13673
		public TextMeshProUGUI PreviewLabel;

		// Token: 0x0400356A RID: 13674
		public RectTransform UnknownOutputIcon;

		// Token: 0x0400356B RID: 13675
		public TextMeshProUGUI PreviewPropertiesLabel;

		// Token: 0x0400356C RID: 13676
		public ItemSlotUI OutputSlotUI;

		// Token: 0x0400356D RID: 13677
		public TextMeshProUGUI InstructionLabel;

		// Token: 0x0400356E RID: 13678
		public RectTransform TitleContainer;

		// Token: 0x0400356F RID: 13679
		public RectTransform MainContainer;

		// Token: 0x04003570 RID: 13680
		public Button BeginButton;

		// Token: 0x04003571 RID: 13681
		public RectTransform ProductHint;

		// Token: 0x04003572 RID: 13682
		public RectTransform MixerHint;

		// Token: 0x04003573 RID: 13683
		private StationRecipe selectedRecipe;
	}
}
