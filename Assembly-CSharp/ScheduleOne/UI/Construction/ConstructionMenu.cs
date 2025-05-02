using System;
using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.Construction;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Tooltips;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Construction
{
	// Token: 0x02000B7C RID: 2940
	public class ConstructionMenu : Singleton<ConstructionMenu>
	{
		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06004E39 RID: 20025 RVA: 0x0014A193 File Offset: 0x00148393
		// (set) Token: 0x06004E3A RID: 20026 RVA: 0x0014A19B File Offset: 0x0014839B
		public bool isOpen { get; protected set; }

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06004E3B RID: 20027 RVA: 0x0014A1A4 File Offset: 0x001483A4
		public Constructable SelectedConstructable
		{
			get
			{
				return this.selectedConstructable;
			}
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x0014A1AC File Offset: 0x001483AC
		protected override void Start()
		{
			base.Start();
			this.SetIsOpen(false);
			ConstructionManager instance = Singleton<ConstructionManager>.Instance;
			instance.onConstructionModeEnabled = (Action)Delegate.Combine(instance.onConstructionModeEnabled, new Action(delegate()
			{
				this.SetIsOpen(true);
			}));
			ConstructionManager instance2 = Singleton<ConstructionManager>.Instance;
			instance2.onConstructionModeDisabled = (Action)Delegate.Combine(instance2.onConstructionModeDisabled, new Action(delegate()
			{
				this.SetIsOpen(false);
			}));
			ConstructionManager instance3 = Singleton<ConstructionManager>.Instance;
			instance3.onNewConstructableBuilt = (ConstructionManager.ConstructableNotification)Delegate.Combine(instance3.onNewConstructableBuilt, new ConstructionManager.ConstructableNotification(this.OnConstructableBuilt));
			ConstructionManager instance4 = Singleton<ConstructionManager>.Instance;
			instance4.onConstructableMoved = (ConstructionManager.ConstructableNotification)Delegate.Combine(instance4.onConstructableMoved, new ConstructionManager.ConstructableNotification(this.SelectConstructable));
			this.GenerateCategories();
			this.SelectCategory(this.categories[0].categoryName);
			this.SetupListings();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), -1);
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x0014A293 File Offset: 0x00148493
		private void Exit(ExitAction exit)
		{
			if (exit.used)
			{
				return;
			}
			if (this.selectedConstructable != null)
			{
				exit.used = true;
				this.DeselectConstructable();
			}
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x0014A2B9 File Offset: 0x001484B9
		protected virtual void Update()
		{
			if (this.isOpen)
			{
				this.CheckConstructableSelection();
			}
		}

		// Token: 0x06004E3F RID: 20031 RVA: 0x0014A2C9 File Offset: 0x001484C9
		private void SetupListings()
		{
			this.AddListing("small_shed", 2500f, "Multipurpose");
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x0014A2E0 File Offset: 0x001484E0
		private void AddListing(string ID, float price, string category)
		{
			if (Registry.GetConstructable(ID) == null)
			{
				Console.LogWarning("ID not valid!", null);
				return;
			}
			ConstructionMenu.ConstructionMenuCategory constructionMenuCategory = this.categories.Find((ConstructionMenu.ConstructionMenuCategory x) => x.categoryName.ToLower() == category.ToLower());
			if (constructionMenuCategory == null)
			{
				Console.LogWarning("Category not found!", null);
				return;
			}
			new ConstructionMenu.ConstructionMenuListing(ID, price, constructionMenuCategory);
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x0014A344 File Offset: 0x00148544
		private void SetIsOpen(bool open)
		{
			if (open)
			{
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			}
			else
			{
				this.DeselectConstructable();
				if (PlayerSingleton<PlayerCamera>.InstanceExists)
				{
					PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
				}
			}
			this.isOpen = open;
			this.canvas.enabled = open;
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x000045B1 File Offset: 0x000027B1
		private void OnConstructableBuilt(Constructable c)
		{
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x0014A396 File Offset: 0x00148596
		public void ClearSelectedListing()
		{
			if (this.selectedListing != null)
			{
				this.selectedListing.ListingUnselected();
				this.selectedListing = null;
				Singleton<ConstructionManager>.Instance.StopConstructableDeploy();
			}
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x0014A3BC File Offset: 0x001485BC
		public void ListingClicked(ConstructionMenu.ConstructionMenuListing listing)
		{
			this.ClearSelectedListing();
			this.DeselectConstructable();
			Singleton<ConstructionManager>.Instance.DeployConstructable(listing);
			this.selectedListing = listing;
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x0014A3DC File Offset: 0x001485DC
		public bool IsHoveringUI()
		{
			List<RaycastResult> list = new List<RaycastResult>();
			PointerEventData pointerEventData = new PointerEventData(this.eventSystem);
			pointerEventData.position = Input.mousePosition;
			this.raycaster.Raycast(pointerEventData, list);
			return list.Count > 0;
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x0014A421 File Offset: 0x00148621
		public void MoveButtonPressed()
		{
			if (this.selectedConstructable != null && this.selectedConstructable is Constructable_GridBased)
			{
				Singleton<ConstructionManager>.Instance.MoveConstructable(this.selectedConstructable as Constructable_GridBased);
				this.DeselectConstructable();
			}
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x000045B1 File Offset: 0x000027B1
		public void CustomizeButtonPressed()
		{
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x0014A45C File Offset: 0x0014865C
		public void BulldozeButtonPressed()
		{
			if (this.selectedConstructable != null)
			{
				Constructable constructable = this.selectedConstructable;
				if (!this.selectedConstructable.CanBeDestroyed())
				{
					Console.Log("Can't be destroyed!", null);
					return;
				}
				this.DeselectConstructable();
				constructable.DestroyConstructable(true);
			}
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x0014A4A4 File Offset: 0x001486A4
		private void CheckConstructableSelection()
		{
			if (this.IsHoveringUI())
			{
				return;
			}
			if (Singleton<ConstructionManager>.Instance.isDeployingConstructable)
			{
				return;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick))
			{
				Constructable hoveredConstructable = this.GetHoveredConstructable();
				if (hoveredConstructable != null)
				{
					if (this.selectedConstructable == hoveredConstructable)
					{
						this.DeselectConstructable();
						return;
					}
					this.SelectConstructable(hoveredConstructable);
					return;
				}
				else if (this.selectedConstructable != null)
				{
					this.DeselectConstructable();
				}
			}
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x0014A510 File Offset: 0x00148710
		public void SelectConstructable(Constructable c)
		{
			this.SelectConstructable(c, true);
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x0014A51C File Offset: 0x0014871C
		public void SelectConstructable(Constructable c, bool focusCameraTo)
		{
			if (!c.CanBeSelected())
			{
				return;
			}
			if (focusCameraTo)
			{
				this.selectedConstructable = c;
			}
			Singleton<BirdsEyeView>.Instance.SlideCameraOrigin(c.GetCosmeticCenter(), c.GetBoundingBoxLongestSide() * 1.75f, 0f);
			this.infoPopup_ConstructableName.text = c.ConstructableName;
			this.infoPopup_Description.text = c.ConstructableDescription;
			List<Button> list = new List<Button>();
			if (c is Constructable_GridBased)
			{
				this.SetButtonInteractable(this.moveButton, true, this.iconColor_Unselected);
				list.Add(this.moveButton);
			}
			else
			{
				this.moveButton.gameObject.SetActive(false);
			}
			this.customizeButton.gameObject.SetActive(false);
			string empty = string.Empty;
			list.Add(this.destroyButton);
			if (c.CanBeDestroyed(out empty))
			{
				this.destroyButton.GetComponent<Tooltip>().text = "Bulldoze";
				this.SetButtonInteractable(this.destroyButton, true, new Color32(byte.MaxValue, 110, 80, byte.MaxValue));
			}
			else
			{
				this.destroyButton.GetComponent<Tooltip>().text = "Cannot bulldoze (" + empty + ")";
				this.SetButtonInteractable(this.destroyButton, false, new Color32(byte.MaxValue, 110, 80, byte.MaxValue));
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].GetComponent<RectTransform>().anchoredPosition = new Vector2((float)(-(float)list.Count) * 50f * 0.5f + 50f * ((float)i + 0.5f), -25f);
				list[i].gameObject.SetActive(true);
			}
			if (Singleton<FeaturesManager>.Instance.activeConstructable != this.selectedConstructable)
			{
				Singleton<FeaturesManager>.Instance.Activate(this.selectedConstructable);
			}
			this.infoPopup.gameObject.SetActive(true);
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x0014A704 File Offset: 0x00148904
		private void SetButtonInteractable(Button b, bool interactable, Color32 iconDefaultColor)
		{
			b.interactable = interactable;
			if (interactable)
			{
				b.transform.Find("Outline/Background/Icon").GetComponent<Image>().color = iconDefaultColor;
				return;
			}
			b.transform.Find("Outline/Background/Icon").GetComponent<Image>().color = new Color32(200, 200, 200, byte.MaxValue);
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x0014A774 File Offset: 0x00148974
		public void DeselectConstructable()
		{
			this.selectedConstructable = null;
			this.infoPopup.gameObject.SetActive(false);
			if (Singleton<FeaturesManager>.Instance.isActive)
			{
				Singleton<FeaturesManager>.Instance.Deactivate();
			}
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x0014A7A4 File Offset: 0x001489A4
		private Constructable GetHoveredConstructable()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.MouseRaycast(1000f, out raycastHit, 1 << LayerMask.NameToLayer("Default"), true, 0f))
			{
				return raycastHit.collider.GetComponentInParent<Constructable>();
			}
			return null;
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x0014A7EC File Offset: 0x001489EC
		private void GenerateCategories()
		{
			for (int i = 0; i < this.categories.Count; i++)
			{
				Button component = Object.Instantiate<GameObject>(this.categoryButtonPrefab, this.categoryButtonContainer).GetComponent<Button>();
				component.GetComponent<RectTransform>().anchoredPosition = new Vector2((0.5f + (float)(i % 3)) * 50f, -(0.5f + (float)(i / 3)) * 50f);
				component.transform.Find("Outline/Background/Icon").GetComponent<Image>().sprite = this.categories[i].categoryIcon;
				string catName = this.categories[i].categoryName;
				component.onClick.AddListener(new UnityAction(delegate()
				{
					this.SelectCategory(catName);
				}));
				component.GetComponent<Tooltip>().text = this.categories[i].categoryName;
				this.categories[i].button = component;
				RectTransform component2 = Object.Instantiate<GameObject>(this.categoryContainerPrefab, this.categoryContainer).GetComponent<RectTransform>();
				component2.name = this.categories[i].categoryName;
				component2.gameObject.SetActive(false);
				this.categories[i].container = component2;
			}
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x0014A940 File Offset: 0x00148B40
		public void SelectCategory(string categoryName)
		{
			this.ClearSelectedListing();
			ConstructionMenu.ConstructionMenuCategory constructionMenuCategory = this.categories.Find((ConstructionMenu.ConstructionMenuCategory x) => x.categoryName.ToLower() == categoryName.ToLower());
			if (this.selectedCategory != null)
			{
				this.selectedCategory.button.transform.Find("Outline/Background/Icon").GetComponent<Image>().color = this.iconColor_Unselected;
				this.selectedCategory.button.interactable = true;
				this.selectedCategory.container.gameObject.SetActive(false);
			}
			constructionMenuCategory.button.interactable = false;
			constructionMenuCategory.button.transform.Find("Outline/Background/Icon").GetComponent<Image>().color = this.iconColor_Selected;
			constructionMenuCategory.container.gameObject.SetActive(true);
			this.categoryNameDisplay.text = constructionMenuCategory.categoryName;
			this.selectedCategory = constructionMenuCategory;
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x0014AA2C File Offset: 0x00148C2C
		public float GetListingPrice(string id)
		{
			for (int i = 0; i < this.categories.Count; i++)
			{
				for (int j = 0; j < this.categories[i].listings.Count; j++)
				{
					if (this.categories[i].listings[j].ID == id)
					{
						return this.categories[i].listings[j].price;
					}
				}
			}
			Console.LogWarning("Failed to get listing price for ID: " + id, null);
			return 0f;
		}

		// Token: 0x04003B06 RID: 15110
		public List<ConstructionMenu.ConstructionMenuCategory> categories = new List<ConstructionMenu.ConstructionMenuCategory>();

		// Token: 0x04003B07 RID: 15111
		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x04003B08 RID: 15112
		[SerializeField]
		protected GraphicRaycaster raycaster;

		// Token: 0x04003B09 RID: 15113
		[SerializeField]
		protected Transform categoryButtonContainer;

		// Token: 0x04003B0A RID: 15114
		[SerializeField]
		protected RectTransform categoryContainer;

		// Token: 0x04003B0B RID: 15115
		[SerializeField]
		protected Text categoryNameDisplay;

		// Token: 0x04003B0C RID: 15116
		[SerializeField]
		protected RectTransform infoPopup;

		// Token: 0x04003B0D RID: 15117
		[SerializeField]
		protected TextMeshProUGUI infoPopup_ConstructableName;

		// Token: 0x04003B0E RID: 15118
		[SerializeField]
		protected EventSystem eventSystem;

		// Token: 0x04003B0F RID: 15119
		[SerializeField]
		protected Button destroyButton;

		// Token: 0x04003B10 RID: 15120
		[SerializeField]
		protected Button customizeButton;

		// Token: 0x04003B11 RID: 15121
		[SerializeField]
		protected Button moveButton;

		// Token: 0x04003B12 RID: 15122
		[SerializeField]
		protected TextMeshProUGUI infoPopup_Description;

		// Token: 0x04003B13 RID: 15123
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject categoryButtonPrefab;

		// Token: 0x04003B14 RID: 15124
		[SerializeField]
		protected GameObject categoryContainerPrefab;

		// Token: 0x04003B15 RID: 15125
		public GameObject listingPrefab;

		// Token: 0x04003B16 RID: 15126
		[Header("Settings")]
		[SerializeField]
		protected Color iconColor_Unselected;

		// Token: 0x04003B17 RID: 15127
		[SerializeField]
		protected Color iconColor_Selected;

		// Token: 0x04003B18 RID: 15128
		public Color listingOutlineColor_Unselected;

		// Token: 0x04003B19 RID: 15129
		public Color listingOutlineColor_Selected;

		// Token: 0x04003B1A RID: 15130
		private ConstructionMenu.ConstructionMenuCategory selectedCategory;

		// Token: 0x04003B1B RID: 15131
		private ConstructionMenu.ConstructionMenuListing selectedListing;

		// Token: 0x04003B1C RID: 15132
		private Constructable selectedConstructable;

		// Token: 0x02000B7D RID: 2941
		[Serializable]
		public class ConstructionMenuCategory
		{
			// Token: 0x04003B1D RID: 15133
			public string categoryName = "Category";

			// Token: 0x04003B1E RID: 15134
			public Sprite categoryIcon;

			// Token: 0x04003B1F RID: 15135
			[HideInInspector]
			public Button button;

			// Token: 0x04003B20 RID: 15136
			[HideInInspector]
			public RectTransform container;

			// Token: 0x04003B21 RID: 15137
			[HideInInspector]
			public List<ConstructionMenu.ConstructionMenuListing> listings = new List<ConstructionMenu.ConstructionMenuListing>();
		}

		// Token: 0x02000B7E RID: 2942
		public class ConstructionMenuListing
		{
			// Token: 0x06004E56 RID: 20054 RVA: 0x0014AB0A File Offset: 0x00148D0A
			public ConstructionMenuListing(string id, float _price, ConstructionMenu.ConstructionMenuCategory _cat)
			{
				this.ID = id;
				this.price = _price;
				this.category = _cat;
				this.category.listings.Add(this);
				this.CreateUI();
			}

			// Token: 0x06004E57 RID: 20055 RVA: 0x0014AB4C File Offset: 0x00148D4C
			private void CreateUI()
			{
				int num = this.category.listings.IndexOf(this);
				this.entry = Object.Instantiate<GameObject>(Singleton<ConstructionMenu>.Instance.listingPrefab, this.category.container).GetComponent<RectTransform>();
				this.entry.anchoredPosition = new Vector2((0.5f + (float)num) * this.entry.sizeDelta.x, this.entry.anchoredPosition.y);
				this.entry.Find("Content/Icon").GetComponent<Image>().sprite = Registry.GetConstructable(this.ID).ConstructableIcon;
				this.entry.Find("Content/Name").GetComponent<Text>().text = Registry.GetConstructable(this.ID).ConstructableName;
				this.entry.Find("Content/Price").GetComponent<Text>().text = MoneyManager.FormatAmount(this.price, false, false);
				this.entry.GetComponent<Button>().onClick.AddListener(new UnityAction(this.ListingClicked));
			}

			// Token: 0x06004E58 RID: 20056 RVA: 0x0014AC65 File Offset: 0x00148E65
			private void ListingClicked()
			{
				if (this.isSelected)
				{
					Singleton<ConstructionMenu>.Instance.ClearSelectedListing();
					return;
				}
				Singleton<ConstructionMenu>.Instance.ListingClicked(this);
				this.SetSelected(true);
			}

			// Token: 0x06004E59 RID: 20057 RVA: 0x0014AC8C File Offset: 0x00148E8C
			public void ListingUnselected()
			{
				this.SetSelected(false);
			}

			// Token: 0x06004E5A RID: 20058 RVA: 0x0014AC98 File Offset: 0x00148E98
			public void SetSelected(bool selected)
			{
				this.isSelected = selected;
				if (selected)
				{
					this.entry.Find("Content/Outline").GetComponent<Image>().color = Singleton<ConstructionMenu>.Instance.listingOutlineColor_Selected;
					this.entry.Find("Content/Name").GetComponent<Text>().color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
					return;
				}
				this.entry.Find("Content/Outline").GetComponent<Image>().color = Singleton<ConstructionMenu>.Instance.listingOutlineColor_Unselected;
				this.entry.Find("Content/Name").GetComponent<Text>().color = new Color32(50, 50, 50, byte.MaxValue);
			}

			// Token: 0x04003B22 RID: 15138
			public string ID = string.Empty;

			// Token: 0x04003B23 RID: 15139
			public float price;

			// Token: 0x04003B24 RID: 15140
			public ConstructionMenu.ConstructionMenuCategory category;

			// Token: 0x04003B25 RID: 15141
			public RectTransform entry;

			// Token: 0x04003B26 RID: 15142
			public bool isSelected;
		}
	}
}
