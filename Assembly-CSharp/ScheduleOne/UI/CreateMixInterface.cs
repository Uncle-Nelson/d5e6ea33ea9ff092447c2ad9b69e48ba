using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Properties;
using ScheduleOne.Storage;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009CE RID: 2510
	public class CreateMixInterface : Singleton<CreateMixInterface>
	{
		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x0011B3FF File Offset: 0x001195FF
		// (set) Token: 0x060043A5 RID: 17317 RVA: 0x0011B407 File Offset: 0x00119607
		public bool IsOpen { get; private set; }

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060043A6 RID: 17318 RVA: 0x0011B410 File Offset: 0x00119610
		private ItemSlot beanSlot
		{
			get
			{
				return this.Storage.ItemSlots[0];
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x0011B423 File Offset: 0x00119623
		private ItemSlot mixerSlot
		{
			get
			{
				return this.Storage.ItemSlots[1];
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x060043A8 RID: 17320 RVA: 0x0011B436 File Offset: 0x00119636
		private ItemSlot outputSlot
		{
			get
			{
				return this.Storage.ItemSlots[2];
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x0011B449 File Offset: 0x00119649
		private ItemSlot productSlot
		{
			get
			{
				return this.Storage.ItemSlots[3];
			}
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x0011B45C File Offset: 0x0011965C
		protected override void Awake()
		{
			base.Awake();
			this.Canvas.enabled = false;
			this.BeansSlot.AssignSlot(this.beanSlot);
			this.MixerSlot.AssignSlot(this.mixerSlot);
			this.OutputSlot.AssignSlot(this.outputSlot);
			this.ProductSlot.AssignSlot(this.productSlot);
			this.beanSlot.AddFilter(new ItemFilter_ID(new List<string>
			{
				"megabean"
			}));
			this.productSlot.AddFilter(new ItemFilter_Category(new List<EItemCategory>
			{
				EItemCategory.Product
			}));
			this.outputSlot.SetIsAddLocked(true);
			this.Storage.onContentsChanged.AddListener(new UnityAction(this.ContentsChanged));
			this.BeginButton.onClick.AddListener(new UnityAction(this.BeginPressed));
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 3);
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x0011B551 File Offset: 0x00119751
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.Close();
			}
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x0011B57C File Offset: 0x0011977C
		public void Open()
		{
			this.IsOpen = true;
			this.Canvas.enabled = true;
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0f);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(true, true);
			List<ItemSlot> secondarySlots = new List<ItemSlot>
			{
				this.beanSlot,
				this.productSlot,
				this.mixerSlot
			};
			Singleton<ItemUIManager>.Instance.EnableQuickMove(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots(), secondarySlots);
			Singleton<CompassManager>.Instance.SetVisible(false);
			this.ContentsChanged();
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x0011B67C File Offset: 0x0011987C
		private void ContentsChanged()
		{
			this.UpdateCanBegin();
			this.UpdateOutput();
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x0011B68C File Offset: 0x0011988C
		private void UpdateCanBegin()
		{
			this.BeanProblemLabel.enabled = !this.HasBeans();
			this.ProductProblemLabel.enabled = !this.HasProduct();
			if (this.HasProduct())
			{
				ProductDefinition productDefinition = this.productSlot.ItemInstance.Definition as ProductDefinition;
				this.ProductPropertiesLabel.text = this.GetPropertyListString(productDefinition.Properties);
				this.ProductPropertiesLabel.enabled = true;
			}
			else
			{
				this.ProductPropertiesLabel.enabled = false;
			}
			if (this.mixerSlot.Quantity == 0)
			{
				this.MixerProblemLabel.text = "Required";
				this.MixerProblemLabel.enabled = true;
			}
			else if (!this.HasMixer())
			{
				this.MixerProblemLabel.text = "Invalid mixer";
				this.MixerProblemLabel.enabled = true;
			}
			else
			{
				this.MixerProblemLabel.enabled = false;
			}
			this.BeginButton.interactable = this.CanBegin();
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x0011B780 File Offset: 0x00119980
		private void UpdateOutput()
		{
			ProductDefinition product = this.GetProduct();
			PropertyItemDefinition mixer = this.GetMixer();
			if (!(product != null) || !(mixer != null))
			{
				this.OutputIcon.enabled = false;
				this.OutputPropertiesLabel.enabled = false;
				this.OutputProblemLabel.enabled = false;
				return;
			}
			List<Property> outputProperties = this.GetOutputProperties(product, mixer);
			ProductDefinition knownProduct = NetworkSingleton<ProductManager>.Instance.GetKnownProduct(product.DrugTypes[0].DrugType, outputProperties);
			if (knownProduct == null)
			{
				this.OutputIcon.sprite = product.Icon;
				this.OutputIcon.color = Color.black;
				this.OutputIcon.enabled = true;
				this.UnknownOutputIcon.gameObject.SetActive(true);
				List<Color32> list = new List<Color32>();
				this.OutputPropertiesLabel.text = string.Empty;
				for (int i = 0; i < outputProperties.Count; i++)
				{
					if (this.OutputPropertiesLabel.text.Length > 0)
					{
						TextMeshProUGUI outputPropertiesLabel = this.OutputPropertiesLabel;
						outputPropertiesLabel.text += "\n";
					}
					if (product.Properties.Contains(outputProperties[i]))
					{
						TextMeshProUGUI outputPropertiesLabel2 = this.OutputPropertiesLabel;
						outputPropertiesLabel2.text += this.GetPropertyString(outputProperties[i]);
					}
					else
					{
						list.Add(outputProperties[i].LabelColor);
					}
				}
				for (int j = 0; j < list.Count; j++)
				{
					if (this.OutputPropertiesLabel.text.Length > 0)
					{
						TextMeshProUGUI outputPropertiesLabel3 = this.OutputPropertiesLabel;
						outputPropertiesLabel3.text += "\n";
					}
					TextMeshProUGUI outputPropertiesLabel4 = this.OutputPropertiesLabel;
					outputPropertiesLabel4.text = outputPropertiesLabel4.text + "<color=#" + ColorUtility.ToHtmlStringRGBA(list[j]) + ">• ?</color>";
				}
				this.OutputPropertiesLabel.enabled = true;
				this.OutputProblemLabel.enabled = false;
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.OutputPropertiesLabel.rectTransform);
				return;
			}
			this.OutputIcon.sprite = knownProduct.Icon;
			this.OutputIcon.color = Color.white;
			this.OutputIcon.enabled = true;
			this.UnknownOutputIcon.gameObject.SetActive(false);
			this.OutputPropertiesLabel.text = this.GetPropertyListString(knownProduct.Properties);
			this.OutputPropertiesLabel.enabled = true;
			this.OutputProblemLabel.text = "Mix already known. ";
			this.OutputProblemLabel.enabled = true;
			LayoutRebuilder.ForceRebuildLayoutImmediate(this.OutputPropertiesLabel.rectTransform);
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x0011BA2C File Offset: 0x00119C2C
		private void BeginPressed()
		{
			if (!this.CanBegin())
			{
				return;
			}
			ItemDefinition product = this.GetProduct();
			PropertyItemDefinition mixer = this.GetMixer();
			NewMixOperation operation = new NewMixOperation(product.ID, mixer.ID);
			NetworkSingleton<ProductManager>.Instance.SendMixOperation(operation, false);
			this.beanSlot.ChangeQuantity(-5, false);
			this.productSlot.ChangeQuantity(-1, false);
			this.mixerSlot.ChangeQuantity(-1, false);
			this.Close();
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x0011BA9C File Offset: 0x00119C9C
		private List<Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			List<Property> properties = product.Properties;
			List<Property> properties2 = mixer.Properties;
			return PropertyMixCalculator.MixProperties(properties, properties2[0], product.DrugType);
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x0011BAC8 File Offset: 0x00119CC8
		private bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			knownProduct = null;
			ProductDefinition product = this.GetProduct();
			PropertyItemDefinition mixer = this.GetMixer();
			if (product != null && mixer != null)
			{
				List<Property> outputProperties = this.GetOutputProperties(product, mixer);
				knownProduct = NetworkSingleton<ProductManager>.Instance.GetKnownProduct(product.DrugTypes[0].DrugType, outputProperties);
			}
			return knownProduct != null;
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x0011BB28 File Offset: 0x00119D28
		private string GetPropertyListString(List<Property> properties)
		{
			this.ProductPropertiesLabel.text = "";
			for (int i = 0; i < properties.Count; i++)
			{
				if (i > 0)
				{
					TextMeshProUGUI productPropertiesLabel = this.ProductPropertiesLabel;
					productPropertiesLabel.text += "\n";
				}
				TextMeshProUGUI productPropertiesLabel2 = this.ProductPropertiesLabel;
				productPropertiesLabel2.text += this.GetPropertyString(properties[i]);
			}
			return this.ProductPropertiesLabel.text;
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x0011BBA3 File Offset: 0x00119DA3
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

		// Token: 0x060043B5 RID: 17333 RVA: 0x0011BBE0 File Offset: 0x00119DE0
		private bool CanBegin()
		{
			ProductDefinition productDefinition;
			return this.HasBeans() && this.HasProduct() && this.HasMixer() && !this.IsOutputKnown(out productDefinition);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x0011BC14 File Offset: 0x00119E14
		public void Close()
		{
			this.IsOpen = false;
			this.Canvas.enabled = false;
			if (this.beanSlot.ItemInstance != null)
			{
				PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.beanSlot.ItemInstance.GetCopy(-1));
				this.beanSlot.ClearStoredInstance(false);
			}
			if (this.productSlot.ItemInstance != null)
			{
				PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.productSlot.ItemInstance.GetCopy(-1));
				this.productSlot.ClearStoredInstance(false);
			}
			if (this.mixerSlot.ItemInstance != null)
			{
				PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.mixerSlot.ItemInstance.GetCopy(-1));
				this.mixerSlot.ClearStoredInstance(false);
			}
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, false);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0f);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(false, true);
			Singleton<CompassManager>.Instance.SetVisible(true);
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x0011BD67 File Offset: 0x00119F67
		private bool HasProduct()
		{
			return this.GetProduct() != null;
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x0011BD75 File Offset: 0x00119F75
		private bool HasBeans()
		{
			return this.beanSlot.Quantity >= 5;
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x0011BD88 File Offset: 0x00119F88
		private bool HasMixer()
		{
			return this.GetMixer() != null;
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x0011BD96 File Offset: 0x00119F96
		private ProductDefinition GetProduct()
		{
			if (this.productSlot.ItemInstance != null)
			{
				return this.productSlot.ItemInstance.Definition as ProductDefinition;
			}
			return null;
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x0011BDBC File Offset: 0x00119FBC
		private PropertyItemDefinition GetMixer()
		{
			if (this.mixerSlot.ItemInstance != null)
			{
				PropertyItemDefinition propertyItemDefinition = this.mixerSlot.ItemInstance.Definition as PropertyItemDefinition;
				if (propertyItemDefinition != null && NetworkSingleton<ProductManager>.Instance.ValidMixIngredients.Contains(propertyItemDefinition))
				{
					return propertyItemDefinition;
				}
			}
			return null;
		}

		// Token: 0x04003137 RID: 12599
		public const int BEAN_REQUIREMENT = 5;

		// Token: 0x04003139 RID: 12601
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400313A RID: 12602
		public ItemSlotUI BeansSlot;

		// Token: 0x0400313B RID: 12603
		public ItemSlotUI ProductSlot;

		// Token: 0x0400313C RID: 12604
		public ItemSlotUI MixerSlot;

		// Token: 0x0400313D RID: 12605
		public ItemSlotUI OutputSlot;

		// Token: 0x0400313E RID: 12606
		public Image OutputIcon;

		// Token: 0x0400313F RID: 12607
		public Button BeginButton;

		// Token: 0x04003140 RID: 12608
		public WorldStorageEntity Storage;

		// Token: 0x04003141 RID: 12609
		public TextMeshProUGUI ProductPropertiesLabel;

		// Token: 0x04003142 RID: 12610
		public TextMeshProUGUI OutputPropertiesLabel;

		// Token: 0x04003143 RID: 12611
		public TextMeshProUGUI BeanProblemLabel;

		// Token: 0x04003144 RID: 12612
		public TextMeshProUGUI ProductProblemLabel;

		// Token: 0x04003145 RID: 12613
		public TextMeshProUGUI MixerProblemLabel;

		// Token: 0x04003146 RID: 12614
		public TextMeshProUGUI OutputProblemLabel;

		// Token: 0x04003147 RID: 12615
		public Transform CameraPosition;

		// Token: 0x04003148 RID: 12616
		public RectTransform UnknownOutputIcon;

		// Token: 0x04003149 RID: 12617
		public UnityEvent onOpen;

		// Token: 0x0400314A RID: 12618
		public UnityEvent onClose;
	}
}
