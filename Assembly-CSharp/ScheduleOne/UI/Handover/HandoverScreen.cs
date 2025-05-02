using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Items;
using ScheduleOne.Variables;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Handover
{
	// Token: 0x02000B2D RID: 2861
	public class HandoverScreen : Singleton<HandoverScreen>
	{
		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06004C22 RID: 19490 RVA: 0x00140B45 File Offset: 0x0013ED45
		// (set) Token: 0x06004C23 RID: 19491 RVA: 0x00140B4D File Offset: 0x0013ED4D
		public Contract CurrentContract { get; protected set; }

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06004C24 RID: 19492 RVA: 0x00140B56 File Offset: 0x0013ED56
		// (set) Token: 0x06004C25 RID: 19493 RVA: 0x00140B5E File Offset: 0x0013ED5E
		public bool IsOpen { get; protected set; }

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x00140B67 File Offset: 0x0013ED67
		// (set) Token: 0x06004C27 RID: 19495 RVA: 0x00140B6F File Offset: 0x0013ED6F
		public bool TutorialOpen { get; private set; }

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06004C28 RID: 19496 RVA: 0x00140B78 File Offset: 0x0013ED78
		// (set) Token: 0x06004C29 RID: 19497 RVA: 0x00140B80 File Offset: 0x0013ED80
		public HandoverScreen.EMode Mode { get; protected set; }

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x00140B89 File Offset: 0x0013ED89
		// (set) Token: 0x06004C2B RID: 19499 RVA: 0x00140B91 File Offset: 0x0013ED91
		public Customer CurrentCustomer { get; private set; }

		// Token: 0x06004C2C RID: 19500 RVA: 0x00140B9C File Offset: 0x0013ED9C
		protected override void Start()
		{
			base.Start();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 8);
			this.VehicleSlotUIs = this.VehicleSlotContainer.GetComponentsInChildren<ItemSlotUI>();
			this.CustomerSlotUIs = this.CustomerSlotContainer.GetComponentsInChildren<ItemSlotUI>();
			this.DoneButton.onClick.AddListener(new UnityAction(this.DonePressed));
			for (int i = 0; i < this.CustomerSlots.Length; i++)
			{
				this.CustomerSlots[i] = new ItemSlot();
				this.CustomerSlotUIs[i].AssignSlot(this.CustomerSlots[i]);
				ItemSlot itemSlot = this.CustomerSlots[i];
				itemSlot.onItemDataChanged = (Action)Delegate.Combine(itemSlot.onItemDataChanged, new Action(this.CustomerItemsChanged));
			}
			this.VehicleSubtitle.text = "This is the vehicle you last drove.\nMust be within " + 20f.ToString() + " meters.";
			this.ClearCustomerSlots(false);
			this.PriceSelector.gameObject.SetActive(false);
			this.PriceSelector.onPriceChanged.AddListener(new UnityAction(this.UpdateSuccessChance));
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			this.IsOpen = false;
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x00140CDC File Offset: 0x0013EEDC
		private void Update()
		{
			if (this.IsOpen && ((Player.Local.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None && Player.Local.CrimeData.TimeSinceSighted < 5f) || Player.Local.CrimeData.CurrentArrestProgress > 0.01f))
			{
				this.Close(HandoverScreen.EHandoverOutcome.Cancelled);
			}
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x00140D35 File Offset: 0x0013EF35
		private void OpenTutorial()
		{
			this.CanvasGroup.alpha = 0f;
			this.TutorialOpen = true;
			this.TutorialContainer.gameObject.SetActive(true);
			this.TutorialAnimation.Play();
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x00140D6B File Offset: 0x0013EF6B
		public void CloseTutorial()
		{
			this.CanvasGroup.alpha = 1f;
			this.TutorialOpen = false;
			this.TutorialContainer.gameObject.SetActive(false);
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x00140D98 File Offset: 0x0013EF98
		public virtual void Open(Contract contract, Customer customer, HandoverScreen.EMode mode, Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> callback, Func<List<ItemInstance>, float, float> successChanceMethod)
		{
			if (mode == HandoverScreen.EMode.Contract && contract == null)
			{
				Console.LogWarning("Contract is null", null);
				return;
			}
			this.CurrentContract = contract;
			this.CurrentCustomer = customer;
			this.Mode = mode;
			if (this.Mode == HandoverScreen.EMode.Contract)
			{
				this.TitleLabel.text = "Complete Deal";
			}
			else if (this.Mode == HandoverScreen.EMode.Sample)
			{
				this.TitleLabel.text = "Give Free Sample";
			}
			else if (this.Mode == HandoverScreen.EMode.Offer)
			{
				this.TitleLabel.text = "Offer Deal";
			}
			this.DetailPanel.Open(customer);
			this.onHandoverComplete = callback;
			this.SuccessChanceMethod = successChanceMethod;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			Singleton<CompassManager>.Instance.SetVisible(false);
			List<ItemSlot> allInventorySlots = PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots();
			List<ItemSlot> secondarySlots = new List<ItemSlot>(this.CustomerSlots);
			if (!NetworkSingleton<VariableDatabase>.Instance.GetValue<bool>("ItemAmountSelectionTutorialDone") && GameManager.IS_TUTORIAL)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("ItemAmountSelectionTutorialDone", true.ToString(), true);
				this.OpenTutorial();
			}
			else
			{
				Player.Local.VisualState.ApplyState("drugdeal", PlayerVisualState.EVisualState.DrugDealing, 0f);
			}
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			if (this.Mode == HandoverScreen.EMode.Contract)
			{
				this.DescriptionLabel.text = customer.NPC.FirstName + " is paying <color=#50E65A>" + MoneyManager.FormatAmount(contract.Payment, false, false) + "</color> for:";
				this.DescriptionLabel.enabled = true;
			}
			else
			{
				this.DescriptionLabel.enabled = false;
			}
			if (this.Mode == HandoverScreen.EMode.Sample)
			{
				EDrugType property = customer.GetOrderedDrugTypes()[0];
				string text = ColorUtility.ToHtmlStringRGB(property.GetColor());
				this.FavouriteDrugLabel.text = string.Concat(new string[]
				{
					customer.NPC.FirstName,
					"'s favourite drug: <color=#",
					text,
					">",
					property.ToString(),
					"</color>"
				});
				this.FavouriteDrugLabel.enabled = true;
				this.FavouritePropertiesLabel.text = customer.NPC.FirstName + "'s favourite effects:";
				for (int i = 0; i < this.PropertiesEntries.Length; i++)
				{
					if (customer.CustomerData.PreferredProperties.Count > i)
					{
						this.PropertiesEntries[i].text = "•  " + customer.CustomerData.PreferredProperties[i].Name;
						this.PropertiesEntries[i].color = customer.CustomerData.PreferredProperties[i].LabelColor;
						this.PropertiesEntries[i].enabled = true;
					}
					else
					{
						this.PropertiesEntries[i].enabled = false;
					}
				}
				this.FavouritePropertiesLabel.gameObject.SetActive(true);
			}
			else
			{
				this.FavouriteDrugLabel.enabled = false;
				this.FavouritePropertiesLabel.gameObject.SetActive(false);
			}
			for (int j = 0; j < this.ExpectationEntries.Length; j++)
			{
				if (contract != null && contract.ProductList.entries.Count > j)
				{
					this.ExpectationEntries[j].Find("Title").gameObject.GetComponent<TextMeshProUGUI>().text = "<color=#FFC73D>" + contract.ProductList.entries[j].Quantity.ToString() + "x</color> " + Registry.GetItem(contract.ProductList.entries[j].ProductID).Name;
					this.ExpectationEntries[j].Find("Star").GetComponent<Image>().color = ItemQuality.GetColor(contract.ProductList.entries[j].Quality);
					this.ExpectationEntries[j].Find("Star").GetComponent<RectTransform>().anchoredPosition = new Vector2(-this.ExpectationEntries[j].Find("Title").gameObject.GetComponent<TextMeshProUGUI>().preferredWidth / 2f + 30f, 0f);
					this.ExpectationEntries[j].gameObject.SetActive(true);
				}
				else
				{
					this.ExpectationEntries[j].gameObject.SetActive(false);
				}
			}
			if (Player.Local.LastDrivenVehicle != null && Player.Local.LastDrivenVehicle.Storage != null && Vector3.Distance(Player.Local.LastDrivenVehicle.transform.position, Player.Local.transform.position) < 20f)
			{
				if (Player.Local.LastDrivenVehicle.Storage != null)
				{
					for (int k = 0; k < this.VehicleSlotUIs.Length; k++)
					{
						ItemSlot itemSlot = null;
						if (k < Player.Local.LastDrivenVehicle.Storage.ItemSlots.Count)
						{
							itemSlot = Player.Local.LastDrivenVehicle.Storage.ItemSlots[k];
						}
						if (itemSlot != null)
						{
							this.VehicleSlotUIs[k].AssignSlot(itemSlot);
							this.VehicleSlotUIs[k].gameObject.SetActive(true);
							allInventorySlots.Add(itemSlot);
						}
						else
						{
							this.VehicleSlotUIs[k].gameObject.SetActive(false);
						}
					}
				}
				this.NoVehicle.gameObject.SetActive(false);
				this.VehicleContainer.gameObject.SetActive(true);
			}
			else
			{
				this.NoVehicle.gameObject.SetActive(true);
				this.VehicleContainer.gameObject.SetActive(false);
			}
			if (this.Mode == HandoverScreen.EMode.Contract)
			{
				this.CustomerSubtitle.text = "Place the expected products here";
			}
			else if (this.Mode == HandoverScreen.EMode.Sample)
			{
				this.CustomerSubtitle.text = "Place a product here for " + customer.NPC.FirstName + " to try";
			}
			else if (this.Mode == HandoverScreen.EMode.Offer)
			{
				this.CustomerSubtitle.text = "Place product here";
			}
			if (mode == HandoverScreen.EMode.Offer)
			{
				this.PriceSelector.gameObject.SetActive(true);
				this.PriceSelector.SetPrice(1f);
			}
			else
			{
				this.PriceSelector.gameObject.SetActive(false);
			}
			this.RecordOriginalLocations();
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(true, true);
			Singleton<ItemUIManager>.Instance.EnableQuickMove(allInventorySlots, secondarySlots);
			this.CustomerItemsChanged();
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			this.IsOpen = true;
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x00141490 File Offset: 0x0013F690
		public virtual void Close(HandoverScreen.EHandoverOutcome outcome)
		{
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			List<ItemInstance> list = new List<ItemInstance>();
			if (outcome == HandoverScreen.EHandoverOutcome.Finalize)
			{
				for (int i = 0; i < this.CustomerSlots.Length; i++)
				{
					if (this.CustomerSlots[i].ItemInstance != null)
					{
						list.Add(this.CustomerSlots[i].ItemInstance);
					}
				}
			}
			Singleton<CompassManager>.Instance.SetVisible(true);
			this.CurrentContract = null;
			this.CurrentCustomer = null;
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			float arg = 0f;
			if (this.Mode == HandoverScreen.EMode.Offer)
			{
				this.PriceSelector.RefreshPrice();
				arg = this.PriceSelector.Price;
			}
			if (this.onHandoverComplete != null)
			{
				this.onHandoverComplete(outcome, list, arg);
			}
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(false, true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			Player.Local.VisualState.RemoveState("drugdeal", 0f);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			if (outcome == HandoverScreen.EHandoverOutcome.Cancelled)
			{
				this.ClearCustomerSlots(true);
			}
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x001415C9 File Offset: 0x0013F7C9
		public void DonePressed()
		{
			this.Close(HandoverScreen.EHandoverOutcome.Finalize);
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x001415D4 File Offset: 0x0013F7D4
		private void RecordOriginalLocations()
		{
			foreach (HotbarSlot hotbarSlot in PlayerSingleton<PlayerInventory>.Instance.hotbarSlots)
			{
				if (hotbarSlot.ItemInstance != null)
				{
					if (this.OriginalItemLocations.ContainsKey(hotbarSlot.ItemInstance))
					{
						Console.LogWarning("Item already exists in original locations", null);
					}
					else
					{
						this.OriginalItemLocations.Add(hotbarSlot.ItemInstance, HandoverScreen.EItemSource.Player);
					}
				}
			}
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00141660 File Offset: 0x0013F860
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
				if (this.TutorialOpen)
				{
					this.CloseTutorial();
					return;
				}
				this.Close(HandoverScreen.EHandoverOutcome.Cancelled);
			}
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x0014169C File Offset: 0x0013F89C
		public void ClearCustomerSlots(bool returnToOriginals)
		{
			this.ignoreCustomerChangedEvents = true;
			foreach (ItemSlot itemSlot in this.CustomerSlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					if (returnToOriginals)
					{
						PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(itemSlot.ItemInstance);
					}
					itemSlot.ClearStoredInstance(false);
				}
			}
			this.OriginalItemLocations.Clear();
			this.ignoreCustomerChangedEvents = false;
			this.CustomerItemsChanged();
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00141704 File Offset: 0x0013F904
		private void CustomerItemsChanged()
		{
			if (this.ignoreCustomerChangedEvents)
			{
				return;
			}
			this.UpdateDoneButton();
			this.UpdateSuccessChance();
			if (this.Mode == HandoverScreen.EMode.Offer)
			{
				float customerItemsValue = this.GetCustomerItemsValue();
				this.PriceSelector.SetPrice(customerItemsValue);
				this.FairPriceLabel.text = "Fair price: " + MoneyManager.FormatAmount(customerItemsValue, false, false);
			}
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x00141760 File Offset: 0x0013F960
		private void UpdateDoneButton()
		{
			string text;
			if (this.GetError(out text))
			{
				this.DoneButton.interactable = false;
				this.ErrorLabel.text = text;
				this.ErrorLabel.enabled = true;
			}
			else
			{
				this.DoneButton.interactable = true;
				this.ErrorLabel.enabled = false;
			}
			string text2;
			if (!this.ErrorLabel.enabled && this.GetWarning(out text2))
			{
				this.WarningLabel.text = text2;
				this.WarningLabel.enabled = true;
				return;
			}
			this.WarningLabel.enabled = false;
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x001417F4 File Offset: 0x0013F9F4
		private void UpdateSuccessChance()
		{
			if (this.GetCustomerItems(false).Count == 0)
			{
				this.SuccessLabel.enabled = false;
				return;
			}
			float num;
			if (this.Mode == HandoverScreen.EMode.Sample)
			{
				Func<List<ItemInstance>, float, float> successChanceMethod = this.SuccessChanceMethod;
				num = ((successChanceMethod != null) ? successChanceMethod(this.GetCustomerItems(true), 0f) : 0f);
				this.SuccessLabel.text = Mathf.RoundToInt(num * 100f).ToString() + "% chance of success";
				this.SuccessLabel.color = this.SuccessColorMap.Evaluate(num);
				this.SuccessLabel.enabled = true;
				return;
			}
			if (this.Mode != HandoverScreen.EMode.Contract)
			{
				if (this.Mode == HandoverScreen.EMode.Offer)
				{
					float price = this.PriceSelector.Price;
					Func<List<ItemInstance>, float, float> successChanceMethod2 = this.SuccessChanceMethod;
					num = ((successChanceMethod2 != null) ? successChanceMethod2(this.GetCustomerItems(true), price) : 0f);
					this.SuccessLabel.text = Mathf.RoundToInt(num * 100f).ToString() + "% chance of success";
					this.SuccessLabel.color = this.SuccessColorMap.Evaluate(num);
					this.SuccessLabel.enabled = true;
				}
				return;
			}
			if (this.CurrentContract == null)
			{
				Console.LogWarning("Current contract is null", null);
				return;
			}
			int num2;
			num = Mathf.Clamp(this.CurrentContract.GetProductListMatch(this.GetCustomerItems(true), out num2), 0.01f, 1f);
			if (num < 1f)
			{
				this.SuccessLabel.text = Mathf.RoundToInt(num * 100f).ToString() + "% chance of customer accepting";
				this.SuccessLabel.color = this.SuccessColorMap.Evaluate(num);
				this.SuccessLabel.enabled = true;
				return;
			}
			this.SuccessLabel.enabled = false;
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x001419C8 File Offset: 0x0013FBC8
		private bool GetError(out string err)
		{
			err = string.Empty;
			if (this.Mode == HandoverScreen.EMode.Contract && this.CurrentContract != null)
			{
				if (this.GetCustomerItemsCount(false) == 0)
				{
					err = string.Empty;
					return true;
				}
				if (NetworkSingleton<GameManager>.Instance.IsTutorial && this.GetCustomerItemsCount(true) > this.CurrentContract.ProductList.GetTotalQuantity())
				{
					err = "You are providing more product than required.";
					return true;
				}
			}
			if ((this.Mode == HandoverScreen.EMode.Sample || this.Mode == HandoverScreen.EMode.Offer) && this.GetCustomerItemsCount(true) == 0)
			{
				bool flag = false;
				for (int i = 0; i < this.CustomerSlots.Length; i++)
				{
					if (this.CustomerSlots[i].ItemInstance != null && this.CustomerSlots[i].ItemInstance is ProductItemInstance && (this.CustomerSlots[i].ItemInstance as ProductItemInstance).AppliedPackaging == null)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					err = "Product must be packaged";
				}
				return true;
			}
			return false;
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00141AB8 File Offset: 0x0013FCB8
		private bool GetWarning(out string warning)
		{
			warning = string.Empty;
			if (this.Mode == HandoverScreen.EMode.Contract)
			{
				if (this.CurrentContract != null)
				{
					int num;
					if (this.CurrentContract.GetProductListMatch(this.GetCustomerItems(true), out num) < 1f)
					{
						warning = "Customer expectations not met";
						return true;
					}
					if (this.GetCustomerItemsCount(false) > this.CurrentContract.ProductList.GetTotalQuantity())
					{
						warning = "You are providing more items than required.";
						return true;
					}
				}
			}
			else if (this.Mode == HandoverScreen.EMode.Sample && this.GetCustomerItemsCount(false) > 1)
			{
				warning = "Only 1 sample product is required.";
				return true;
			}
			bool flag = false;
			for (int i = 0; i < this.CustomerSlots.Length; i++)
			{
				if (this.CustomerSlots[i].ItemInstance != null && this.CustomerSlots[i].ItemInstance is ProductItemInstance && (this.CustomerSlots[i].ItemInstance as ProductItemInstance).AppliedPackaging == null)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				warning = "Product must be packaged";
				return true;
			}
			return false;
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x00141BAC File Offset: 0x0013FDAC
		private List<ItemInstance> GetCustomerItems(bool onlyPackagedProduct = true)
		{
			List<ItemInstance> list = new List<ItemInstance>();
			for (int i = 0; i < this.CustomerSlots.Length; i++)
			{
				if (this.CustomerSlots[i].ItemInstance != null)
				{
					if (onlyPackagedProduct)
					{
						ProductItemInstance productItemInstance = this.CustomerSlots[i].ItemInstance as ProductItemInstance;
						if (productItemInstance == null || productItemInstance.AppliedPackaging == null)
						{
							goto IL_53;
						}
					}
					list.Add(this.CustomerSlots[i].ItemInstance);
				}
				IL_53:;
			}
			return list;
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x00141C1C File Offset: 0x0013FE1C
		private float GetCustomerItemsValue()
		{
			float num = 0f;
			foreach (ItemInstance itemInstance in this.GetCustomerItems(true))
			{
				if (itemInstance is ProductItemInstance)
				{
					ProductItemInstance productItemInstance = itemInstance as ProductItemInstance;
					num += (productItemInstance.Definition as ProductDefinition).MarketValue * (float)productItemInstance.Quantity * (float)productItemInstance.Amount;
				}
			}
			return num;
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x00141CA4 File Offset: 0x0013FEA4
		private int GetCustomerItemsCount(bool onlyPackagedProduct = true)
		{
			int num = 0;
			for (int i = 0; i < this.CustomerSlots.Length; i++)
			{
				if (this.CustomerSlots[i].ItemInstance != null)
				{
					ProductItemInstance productItemInstance = this.CustomerSlots[i].ItemInstance as ProductItemInstance;
					if (!onlyPackagedProduct || (productItemInstance != null && !(productItemInstance.AppliedPackaging == null)))
					{
						int num2 = 1;
						if (productItemInstance != null)
						{
							num2 = productItemInstance.Amount;
						}
						num += this.CustomerSlots[i].ItemInstance.Quantity * num2;
					}
				}
			}
			return num;
		}

		// Token: 0x04003921 RID: 14625
		public const int CUSTOMER_SLOT_COUNT = 4;

		// Token: 0x04003922 RID: 14626
		public const float VEHICLE_MAX_DIST = 20f;

		// Token: 0x04003927 RID: 14631
		[Header("Settings")]
		public Gradient SuccessColorMap;

		// Token: 0x04003928 RID: 14632
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003929 RID: 14633
		public GameObject Container;

		// Token: 0x0400392A RID: 14634
		public CanvasGroup CanvasGroup;

		// Token: 0x0400392B RID: 14635
		public TextMeshProUGUI DescriptionLabel;

		// Token: 0x0400392C RID: 14636
		public TextMeshProUGUI CustomerSubtitle;

		// Token: 0x0400392D RID: 14637
		public TextMeshProUGUI FavouriteDrugLabel;

		// Token: 0x0400392E RID: 14638
		public TextMeshProUGUI FavouritePropertiesLabel;

		// Token: 0x0400392F RID: 14639
		public TextMeshProUGUI[] PropertiesEntries;

		// Token: 0x04003930 RID: 14640
		public RectTransform[] ExpectationEntries;

		// Token: 0x04003931 RID: 14641
		public GameObject NoVehicle;

		// Token: 0x04003932 RID: 14642
		public RectTransform VehicleSlotContainer;

		// Token: 0x04003933 RID: 14643
		public RectTransform CustomerSlotContainer;

		// Token: 0x04003934 RID: 14644
		public TextMeshProUGUI VehicleSubtitle;

		// Token: 0x04003935 RID: 14645
		public TextMeshProUGUI SuccessLabel;

		// Token: 0x04003936 RID: 14646
		public TextMeshProUGUI ErrorLabel;

		// Token: 0x04003937 RID: 14647
		public TextMeshProUGUI WarningLabel;

		// Token: 0x04003938 RID: 14648
		public Button DoneButton;

		// Token: 0x04003939 RID: 14649
		public RectTransform VehicleContainer;

		// Token: 0x0400393A RID: 14650
		public TextMeshProUGUI TitleLabel;

		// Token: 0x0400393B RID: 14651
		public HandoverScreenPriceSelector PriceSelector;

		// Token: 0x0400393C RID: 14652
		public TextMeshProUGUI FairPriceLabel;

		// Token: 0x0400393D RID: 14653
		public Animation TutorialAnimation;

		// Token: 0x0400393E RID: 14654
		public RectTransform TutorialContainer;

		// Token: 0x0400393F RID: 14655
		public HandoverScreenDetailPanel DetailPanel;

		// Token: 0x04003940 RID: 14656
		public Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> onHandoverComplete;

		// Token: 0x04003941 RID: 14657
		public Func<List<ItemInstance>, float, float> SuccessChanceMethod;

		// Token: 0x04003942 RID: 14658
		private ItemSlotUI[] VehicleSlotUIs;

		// Token: 0x04003943 RID: 14659
		private ItemSlotUI[] CustomerSlotUIs;

		// Token: 0x04003944 RID: 14660
		private ItemSlot[] CustomerSlots = new ItemSlot[4];

		// Token: 0x04003945 RID: 14661
		private Dictionary<ItemInstance, HandoverScreen.EItemSource> OriginalItemLocations = new Dictionary<ItemInstance, HandoverScreen.EItemSource>();

		// Token: 0x04003946 RID: 14662
		private bool ignoreCustomerChangedEvents;

		// Token: 0x02000B2E RID: 2862
		public enum EMode
		{
			// Token: 0x04003949 RID: 14665
			Contract,
			// Token: 0x0400394A RID: 14666
			Sample,
			// Token: 0x0400394B RID: 14667
			Offer
		}

		// Token: 0x02000B2F RID: 2863
		public enum EHandoverOutcome
		{
			// Token: 0x0400394D RID: 14669
			Cancelled,
			// Token: 0x0400394E RID: 14670
			Finalize
		}

		// Token: 0x02000B30 RID: 2864
		private enum EItemSource
		{
			// Token: 0x04003950 RID: 14672
			Player,
			// Token: 0x04003951 RID: 14673
			Vehicle
		}
	}
}
