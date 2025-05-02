using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.UI;
using ScheduleOne.UI.Items;
using ScheduleOne.Variables;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005F5 RID: 1525
	public class PlayerInventory : PlayerSingleton<PlayerInventory>
	{
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000A2157 File Offset: 0x000A0357
		public int TOTAL_SLOT_COUNT
		{
			get
			{
				return 9 + (this.ManagementSlotEnabled ? 1 : 0);
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x000A2168 File Offset: 0x000A0368
		// (set) Token: 0x060027A2 RID: 10146 RVA: 0x000A2170 File Offset: 0x000A0370
		public CashSlot cashSlot { get; private set; }

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x000A2179 File Offset: 0x000A0379
		// (set) Token: 0x060027A4 RID: 10148 RVA: 0x000A2181 File Offset: 0x000A0381
		public CashInstance cashInstance { get; protected set; }

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x000A218A File Offset: 0x000A038A
		// (set) Token: 0x060027A6 RID: 10150 RVA: 0x000A2192 File Offset: 0x000A0392
		public int EquippedSlotIndex { get; protected set; } = -1;

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x000A219B File Offset: 0x000A039B
		// (set) Token: 0x060027A8 RID: 10152 RVA: 0x000A21A3 File Offset: 0x000A03A3
		public bool HotbarEnabled { get; protected set; } = true;

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x000A21AC File Offset: 0x000A03AC
		// (set) Token: 0x060027AA RID: 10154 RVA: 0x000A21B4 File Offset: 0x000A03B4
		public bool EquippingEnabled { get; protected set; } = true;

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060027AB RID: 10155 RVA: 0x000A21BD File Offset: 0x000A03BD
		// (set) Token: 0x060027AC RID: 10156 RVA: 0x000A21C5 File Offset: 0x000A03C5
		public Equippable equippable { get; protected set; }

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000A21CE File Offset: 0x000A03CE
		public HotbarSlot equippedSlot
		{
			get
			{
				if (this.EquippedSlotIndex == -1)
				{
					return null;
				}
				return this.IndexAllSlots(this.EquippedSlotIndex);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x000A21E7 File Offset: 0x000A03E7
		public bool isAnythingEquipped
		{
			get
			{
				return this.equippedSlot != null && this.equippedSlot.ItemInstance != null;
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000A2204 File Offset: 0x000A0404
		public HotbarSlot IndexAllSlots(int index)
		{
			if (index < 0)
			{
				return null;
			}
			if (this.ManagementSlotEnabled)
			{
				if (index < this.hotbarSlots.Count)
				{
					return this.hotbarSlots[index];
				}
				if (index == 8)
				{
					return this.clipboardSlot;
				}
				if (index == 9)
				{
					return this.cashSlot;
				}
				return null;
			}
			else
			{
				if (index < this.hotbarSlots.Count)
				{
					return this.hotbarSlots[index];
				}
				if (index == 8)
				{
					return this.cashSlot;
				}
				return null;
			}
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000A227A File Offset: 0x000A047A
		protected override void Awake()
		{
			base.Awake();
			this.SetupInventoryUI();
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000A2288 File Offset: 0x000A0488
		private void SetupInventoryUI()
		{
			for (int i = 0; i < 8; i++)
			{
				HotbarSlot hotbarSlot = new HotbarSlot();
				this.hotbarSlots.Add(hotbarSlot);
				ItemSlotUI component = Object.Instantiate<ItemSlotUI>(Singleton<ItemUIManager>.Instance.HotbarSlotUIPrefab, Singleton<HUD>.Instance.SlotContainer).GetComponent<ItemSlotUI>();
				component.AssignSlot(hotbarSlot);
				this.slotUIs.Add(component);
			}
			this.clipboardSlot = new ClipboardSlot();
			this.clipboardSlot.SetStoredItem(Registry.GetItem("managementclipboard").GetDefaultInstance(1), false);
			this.clipboardSlot.AddFilter(new ItemFilter_ID(new List<string>
			{
				"managementclipboard"
			}));
			this.clipboardSlot.SetIsRemovalLocked(true);
			this.clipboardSlot.SetIsAddLocked(true);
			Singleton<HUD>.Instance.managementSlotUI.AssignSlot(this.clipboardSlot);
			Singleton<HUD>.Instance.managementSlotContainer.gameObject.SetActive(false);
			this.slotUIs.Add(Singleton<HUD>.Instance.managementSlotUI);
			this.cashSlot = new CashSlot();
			this.cashSlot.SetStoredItem(Registry.GetItem("cash").GetDefaultInstance(1), false);
			this.cashInstance = (this.cashSlot.ItemInstance as CashInstance);
			this.cashSlot.AddFilter(new ItemFilter_Category(new List<EItemCategory>
			{
				EItemCategory.Cash
			}));
			Singleton<HUD>.Instance.cashSlotUI.GetComponent<CashSlotUI>().AssignSlot(this.cashSlot);
			this.slotUIs.Add(Singleton<HUD>.Instance.cashSlotUI.GetComponent<ItemSlotUI>());
			this.discardSlot = new ItemSlot();
			Singleton<HUD>.Instance.discardSlot.AssignSlot(this.discardSlot);
			this.RepositionUI();
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000A2438 File Offset: 0x000A0638
		private void RepositionUI()
		{
			float num = 0f;
			float num2 = 20f;
			for (int i = 0; i < 8; i++)
			{
				ItemSlotUI itemSlotUI = this.slotUIs[i];
				itemSlotUI.Rect.Find("Background/Index").GetComponent<TextMeshProUGUI>().text = ((i + 1) % 10).ToString();
				itemSlotUI.Rect.anchoredPosition = new Vector2(num + itemSlotUI.Rect.sizeDelta.x / 2f + num2, 0f);
				num += itemSlotUI.Rect.sizeDelta.x + num2;
				if (i == 7)
				{
					itemSlotUI.Rect.Find("Seperator").gameObject.SetActive(true);
					itemSlotUI.Rect.Find("Seperator").GetComponent<RectTransform>().anchoredPosition = new Vector2(num2, 0f);
					num += num2;
				}
			}
			int num3 = 8;
			if (this.ManagementSlotEnabled)
			{
				Singleton<HUD>.Instance.managementSlotUI.transform.Find("Background/Index").GetComponent<Text>().text = ((num3 + 1) % 10).ToString();
				Singleton<HUD>.Instance.managementSlotContainer.anchoredPosition = new Vector2(num + Singleton<HUD>.Instance.managementSlotContainer.sizeDelta.x / 2f + num2, 0f);
				num += Singleton<HUD>.Instance.managementSlotContainer.sizeDelta.x + num2;
				num3++;
			}
			Singleton<HUD>.Instance.managementSlotContainer.gameObject.SetActive(this.ManagementSlotEnabled);
			Singleton<HUD>.Instance.cashSlotUI.Find("Background/Index").GetComponent<Text>().text = ((num3 + 1) % 10).ToString();
			Singleton<HUD>.Instance.cashSlotContainer.anchoredPosition = new Vector2(num + Singleton<HUD>.Instance.cashSlotContainer.sizeDelta.x / 2f + num2, 0f);
			num += Singleton<HUD>.Instance.cashSlotContainer.sizeDelta.x + num2;
			Singleton<HUD>.Instance.SlotContainer.anchoredPosition = new Vector2(-num / 2f, Singleton<HUD>.Instance.SlotContainer.anchoredPosition.y);
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000A2688 File Offset: 0x000A0888
		protected override void Start()
		{
			base.Start();
			for (int i = 0; i < this.hotbarSlots.Count; i++)
			{
				HotbarSlot slot = this.hotbarSlots[i];
				Player.Local.SetInventoryItem(i, slot.ItemInstance);
				int index = i;
				HotbarSlot slot2 = slot;
				slot2.onItemDataChanged = (Action)Delegate.Combine(slot2.onItemDataChanged, new Action(delegate()
				{
					this.UpdateInventoryVariables();
					Player.Local.SetInventoryItem(index, slot.ItemInstance);
				}));
			}
			Player.Local.SetInventoryItem(8, this.cashSlot.ItemInstance);
			CashSlot cashSlot = this.cashSlot;
			cashSlot.onItemDataChanged = (Action)Delegate.Combine(cashSlot.onItemDataChanged, new Action(delegate()
			{
				this.UpdateInventoryVariables();
				Player.Local.SetInventoryItem(8, this.cashSlot.ItemInstance);
			}));
			if (this.giveStartupItems)
			{
				this.GiveStartupItems();
			}
			if (!GameManager.IS_TUTORIAL)
			{
				BoolVariable boolVariable = NetworkSingleton<VariableDatabase>.Instance.GetVariable("ClipboardAcquired") as BoolVariable;
				if (boolVariable.Value)
				{
					this.ClipboardAcquiredVarChange(true);
					return;
				}
				boolVariable.OnValueChanged.AddListener(new UnityAction<bool>(this.ClipboardAcquiredVarChange));
			}
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x000A27A4 File Offset: 0x000A09A4
		private void GiveStartupItems()
		{
			if (!Application.isEditor && !Debug.isDebugBuild)
			{
				return;
			}
			foreach (PlayerInventory.ItemAmount itemAmount in this.startupItems)
			{
				this.AddItemToInventory(itemAmount.Definition.GetDefaultInstance(itemAmount.Amount));
			}
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000A2818 File Offset: 0x000A0A18
		protected virtual void Update()
		{
			this.UpdateHotbarSelection();
			if (this.isAnythingEquipped && this.HotbarEnabled)
			{
				this.currentEquipTime += Time.deltaTime;
			}
			else
			{
				this.currentEquipTime = 0f;
			}
			if (this.isAnythingEquipped)
			{
				Singleton<HUD>.Instance.selectedItemLabel.text = this.equippedSlot.ItemInstance.Name;
				Singleton<HUD>.Instance.selectedItemLabel.color = this.equippedSlot.ItemInstance.LabelDisplayColor;
				if (this.currentEquipTime > 2f)
				{
					float num = Mathf.Clamp01((this.currentEquipTime - 2f) / 0.5f);
					Singleton<HUD>.Instance.selectedItemLabel.color = new Color(Singleton<HUD>.Instance.selectedItemLabel.color.r, Singleton<HUD>.Instance.selectedItemLabel.color.g, Singleton<HUD>.Instance.selectedItemLabel.color.b, 1f - num);
				}
				else
				{
					Singleton<HUD>.Instance.selectedItemLabel.color = new Color(Singleton<HUD>.Instance.selectedItemLabel.color.r, Singleton<HUD>.Instance.selectedItemLabel.color.g, Singleton<HUD>.Instance.selectedItemLabel.color.b, 1f);
				}
			}
			else
			{
				Singleton<HUD>.Instance.selectedItemLabel.text = string.Empty;
			}
			if (this.discardSlot.ItemInstance != null && !Singleton<HUD>.Instance.discardSlot.IsBeingDragged)
			{
				this.currentDiscardTime += Time.deltaTime;
				Singleton<HUD>.Instance.discardSlotFill.fillAmount = this.currentDiscardTime / 1.5f;
				if (this.currentDiscardTime >= 1.5f)
				{
					this.discardSlot.ClearStoredInstance(false);
					return;
				}
			}
			else
			{
				this.currentDiscardTime = 0f;
				Singleton<HUD>.Instance.discardSlotFill.fillAmount = 0f;
			}
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000A2A10 File Offset: 0x000A0C10
		private void UpdateHotbarSelection()
		{
			if (!this.HotbarEnabled)
			{
				return;
			}
			if (!this.EquippingEnabled)
			{
				return;
			}
			if (GameInput.IsTyping)
			{
				return;
			}
			if (Singleton<PauseMenu>.Instance.IsPaused)
			{
				return;
			}
			int num = -1;
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				num = 0;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				num = 1;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				num = 2;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				num = 3;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha5))
			{
				num = 4;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha6))
			{
				num = 5;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha7))
			{
				num = 6;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha8))
			{
				num = 7;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha9))
			{
				num = 8;
			}
			else if (Input.GetKeyDown(KeyCode.Alpha0))
			{
				num = 9;
			}
			if (num == -1)
			{
				float mouseScrollDelta = GameInput.MouseScrollDelta;
				if (mouseScrollDelta < 0f)
				{
					num = this.EquippedSlotIndex + 1;
					if (num >= this.TOTAL_SLOT_COUNT)
					{
						num = 0;
					}
				}
				else if (mouseScrollDelta > 0f)
				{
					num = this.EquippedSlotIndex - 1;
					if (num < 0)
					{
						num = this.TOTAL_SLOT_COUNT - 1;
					}
				}
			}
			if (num == -1 && GameInput.GetButtonDown(GameInput.ButtonCode.TertiaryClick))
			{
				if (this.EquippedSlotIndex != -1)
				{
					num = this.EquippedSlotIndex;
				}
				else if (this.PreviousEquippedSlotIndex != -1)
				{
					num = this.PreviousEquippedSlotIndex;
				}
			}
			if (num != -1)
			{
				if (num >= this.TOTAL_SLOT_COUNT)
				{
					return;
				}
				if (num != this.EquippedSlotIndex && this.EquippedSlotIndex != -1)
				{
					this.IndexAllSlots(this.EquippedSlotIndex).Unequip();
					this.currentEquipTime = 0f;
				}
				this.PreviousEquippedSlotIndex = this.EquippedSlotIndex;
				this.EquippedSlotIndex = -1;
				if (this.IndexAllSlots(num).IsEquipped)
				{
					this.IndexAllSlots(num).Unequip();
					return;
				}
				this.Equip(this.IndexAllSlots(num));
				this.EquippedSlotIndex = num;
				PlayerSingleton<ViewmodelSway>.Instance.RefreshViewmodel();
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x000A2BC6 File Offset: 0x000A0DC6
		public void Equip(HotbarSlot slot)
		{
			slot.Equip();
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000A2BCE File Offset: 0x000A0DCE
		public void SetInventoryEnabled(bool enabled)
		{
			this.HotbarEnabled = enabled;
			if (this.onInventoryStateChanged != null)
			{
				this.onInventoryStateChanged(enabled);
			}
			Singleton<HUD>.Instance.HotbarContainer.gameObject.SetActive(enabled);
			this.SetEquippingEnabled(enabled);
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x000A2C08 File Offset: 0x000A0E08
		public void SetEquippingEnabled(bool enabled)
		{
			if (this.EquippingEnabled == enabled)
			{
				return;
			}
			this.EquippingEnabled = enabled;
			this.equipContainer.gameObject.SetActive(enabled);
			if (enabled)
			{
				if (this.PriorEquippedSlotIndex != -1)
				{
					this.EquippedSlotIndex = this.PriorEquippedSlotIndex;
					this.Equip(this.IndexAllSlots(this.EquippedSlotIndex));
				}
			}
			else
			{
				this.PriorEquippedSlotIndex = this.EquippedSlotIndex;
				if (this.EquippedSlotIndex != -1)
				{
					this.IndexAllSlots(this.EquippedSlotIndex).Unequip();
					this.EquippedSlotIndex = -1;
				}
			}
			foreach (ItemSlotUI itemSlotUI in this.slotUIs)
			{
				itemSlotUI.Rect.Find("Background/Index").gameObject.SetActive(enabled);
			}
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000A2CE8 File Offset: 0x000A0EE8
		private void ClipboardAcquiredVarChange(bool newVal)
		{
			this.SetManagementClipboardEnabled(newVal);
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x000A2CF1 File Offset: 0x000A0EF1
		public void SetManagementClipboardEnabled(bool enabled)
		{
			if (GameManager.IS_TUTORIAL)
			{
				enabled = false;
			}
			this.ManagementSlotEnabled = enabled;
			this.RepositionUI();
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000A2D0C File Offset: 0x000A0F0C
		public void SetViewmodelVisible(bool visible)
		{
			PlayerSingleton<PlayerCamera>.Instance.Camera.cullingMask = (visible ? (PlayerSingleton<PlayerCamera>.Instance.Camera.cullingMask | 1 << LayerMask.NameToLayer("Viewmodel")) : (PlayerSingleton<PlayerCamera>.Instance.Camera.cullingMask & ~(1 << LayerMask.NameToLayer("Viewmodel"))));
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x000A2D6C File Offset: 0x000A0F6C
		public bool CanItemFitInInventory(ItemInstance item, int quantity = 1)
		{
			if (item == null)
			{
				Console.LogWarning("CanItemFitInInventory: item is null!", null);
				return false;
			}
			for (int i = 0; i < this.hotbarSlots.Count; i++)
			{
				if (this.hotbarSlots[i].ItemInstance == null)
				{
					quantity -= item.StackLimit;
				}
				else if (this.hotbarSlots[i].ItemInstance.CanStackWith(item, true))
				{
					quantity -= item.StackLimit - this.hotbarSlots[i].ItemInstance.Quantity;
				}
			}
			return quantity <= 0;
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000A2E00 File Offset: 0x000A1000
		public void AddItemToInventory(ItemInstance item)
		{
			if (item == null)
			{
				Console.LogError("AddItemToInventory: item is null!", null);
				return;
			}
			if (!item.IsValidInstance())
			{
				Console.LogError("AddItemToInventory: item is not valid!", null);
				return;
			}
			if (!this.CanItemFitInInventory(item, 1))
			{
				Console.LogWarning("AddItemToInventory: item won't fit!", null);
				return;
			}
			int num = item.Quantity;
			int num2 = 0;
			while (num2 < this.hotbarSlots.Count && num != 0)
			{
				if (this.hotbarSlots[num2].ItemInstance != null && this.hotbarSlots[num2].ItemInstance.CanStackWith(item, false))
				{
					int num3 = Mathf.Min(num, this.hotbarSlots[num2].ItemInstance.StackLimit - this.hotbarSlots[num2].Quantity);
					if (num3 > 0)
					{
						this.hotbarSlots[num2].ChangeQuantity(num3, false);
						num -= num3;
					}
				}
				num2++;
			}
			int num4 = 0;
			while (num4 < this.hotbarSlots.Count && num != 0)
			{
				if (this.hotbarSlots[num4].ItemInstance == null)
				{
					this.hotbarSlots[num4].SetStoredItem(item.GetCopy(num), false);
					num = 0;
				}
				num4++;
			}
			if (num > 0)
			{
				Console.LogWarning("Could not add full amount of '" + item.Name + "' to inventory!", null);
			}
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000A2F4C File Offset: 0x000A114C
		public uint GetAmountOfItem(string ID)
		{
			uint num = 0U;
			for (int i = 0; i < this.hotbarSlots.Count; i++)
			{
				if (this.hotbarSlots[i].ItemInstance != null && this.hotbarSlots[i].ItemInstance.ID.ToLower() == ID.ToLower())
				{
					num += (uint)this.hotbarSlots[i].Quantity;
				}
			}
			return num;
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000A2FC4 File Offset: 0x000A11C4
		public void RemoveAmountOfItem(string ID, uint amount = 1U)
		{
			uint num = amount;
			for (int i = 0; i < this.hotbarSlots.Count; i++)
			{
				if (this.hotbarSlots[i].ItemInstance != null && this.hotbarSlots[i].ItemInstance.ID.ToLower() == ID.ToLower())
				{
					uint num2 = num;
					if ((ulong)num2 > (ulong)((long)this.hotbarSlots[i].Quantity))
					{
						num2 = (uint)this.hotbarSlots[i].Quantity;
					}
					num -= num2;
					this.hotbarSlots[i].ChangeQuantity((int)(-(int)num2), false);
					if (num <= 0U)
					{
						break;
					}
				}
			}
			if (num > 0U)
			{
				Console.LogWarning("Could not fully remove " + amount.ToString() + " " + ID, null);
			}
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x000A3094 File Offset: 0x000A1294
		public void ClearInventory()
		{
			for (int i = 0; i < this.hotbarSlots.Count; i++)
			{
				if (this.hotbarSlots[i].ItemInstance != null)
				{
					this.hotbarSlots[i].ClearStoredInstance(false);
				}
			}
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x000A30DC File Offset: 0x000A12DC
		public void RemoveProductFromInventory(EStealthLevel maxStealth)
		{
			for (int i = 0; i < this.hotbarSlots.Count; i++)
			{
				if (this.hotbarSlots[i].ItemInstance != null && this.hotbarSlots[i].ItemInstance is ProductItemInstance)
				{
					ProductItemInstance productItemInstance = this.hotbarSlots[i].ItemInstance as ProductItemInstance;
					EStealthLevel estealthLevel = EStealthLevel.None;
					if (productItemInstance.AppliedPackaging != null)
					{
						estealthLevel = productItemInstance.AppliedPackaging.StealthLevel;
					}
					if (estealthLevel <= maxStealth)
					{
						this.hotbarSlots[i].ClearStoredInstance(false);
					}
				}
			}
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x000A3178 File Offset: 0x000A1378
		public void RemoveRandomItemsFromInventory()
		{
			for (int i = 0; i < this.hotbarSlots.Count; i++)
			{
				if (this.hotbarSlots[i].ItemInstance != null && Random.Range(0, 3) == 0)
				{
					int num = Random.Range(1, this.hotbarSlots[i].ItemInstance.Quantity + 1);
					this.hotbarSlots[i].ChangeQuantity(-num, false);
				}
			}
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x000A31ED File Offset: 0x000A13ED
		public void SetEquippable(Equippable eq)
		{
			this.equippable = eq;
			if (this.equippable != null && this.onItemEquipped != null)
			{
				this.onItemEquipped.Invoke();
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000A3218 File Offset: 0x000A1418
		public void Reequip()
		{
			HotbarSlot equippedSlot = this.equippedSlot;
			if (equippedSlot != null)
			{
				equippedSlot.Unequip();
				this.currentEquipTime = 0f;
				this.Equip(equippedSlot);
			}
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000A3248 File Offset: 0x000A1448
		public List<ItemSlot> GetAllInventorySlots()
		{
			List<ItemSlot> list = new List<ItemSlot>();
			for (int i = 0; i < this.hotbarSlots.Count; i++)
			{
				list.Add(this.hotbarSlots[i]);
			}
			list.Add(this.cashSlot);
			return list;
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000A3290 File Offset: 0x000A1490
		private void UpdateInventoryVariables()
		{
			if (!NetworkSingleton<VariableDatabase>.InstanceExists)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < this.ItemVariables.Count; i++)
			{
				int num3 = 0;
				for (int j = 0; j < this.hotbarSlots.Count; j++)
				{
					if (this.hotbarSlots[j].ItemInstance != null && this.hotbarSlots[j].ItemInstance.ID.ToLower() == this.ItemVariables[i].Definition.ID.ToLower())
					{
						num3 += this.hotbarSlots[j].Quantity;
					}
					if (this.hotbarSlots[j].ItemInstance != null && NetworkSingleton<ProductManager>.Instance.ValidMixIngredients.Contains(this.hotbarSlots[j].ItemInstance.Definition))
					{
						num += this.hotbarSlots[j].Quantity;
					}
				}
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.ItemVariables[i].VariableName, num3.ToString(), false);
			}
			int num4 = 0;
			for (int k = 0; k < this.hotbarSlots.Count; k++)
			{
				if (this.hotbarSlots[k].ItemInstance != null && this.hotbarSlots[k].ItemInstance is ProductItemInstance)
				{
					if (this.hotbarSlots[k].ItemInstance is ProductItemInstance && (this.hotbarSlots[k].ItemInstance as ProductItemInstance).AppliedPackaging != null)
					{
						num4 += this.hotbarSlots[k].Quantity;
					}
					if (this.hotbarSlots[k].ItemInstance is WeedInstance)
					{
						num2 += this.hotbarSlots[k].Quantity;
					}
				}
			}
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Inventory_Weed_Count", num2.ToString(), false);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Inventory_Packaged_Product", num4.ToString(), false);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Inventory_MixingIngredients", num.ToString(), false);
		}

		// Token: 0x04001CC1 RID: 7361
		public const float LABEL_DISPLAY_TIME = 2f;

		// Token: 0x04001CC2 RID: 7362
		public const float LABEL_FADE_TIME = 0.5f;

		// Token: 0x04001CC3 RID: 7363
		public const float DISCARD_TIME = 1.5f;

		// Token: 0x04001CC4 RID: 7364
		public const int INVENTORY_SLOT_COUNT = 8;

		// Token: 0x04001CC5 RID: 7365
		[Header("Startup Items (Editor only)")]
		[SerializeField]
		private bool giveStartupItems;

		// Token: 0x04001CC6 RID: 7366
		[SerializeField]
		private List<PlayerInventory.ItemAmount> startupItems = new List<PlayerInventory.ItemAmount>();

		// Token: 0x04001CC7 RID: 7367
		[Header("References")]
		public Transform equipContainer;

		// Token: 0x04001CC8 RID: 7368
		public List<HotbarSlot> hotbarSlots = new List<HotbarSlot>();

		// Token: 0x04001CCB RID: 7371
		private ClipboardSlot clipboardSlot;

		// Token: 0x04001CCC RID: 7372
		private List<ItemSlotUI> slotUIs = new List<ItemSlotUI>();

		// Token: 0x04001CCD RID: 7373
		private ItemSlot discardSlot;

		// Token: 0x04001CCE RID: 7374
		[Header("Item Variables")]
		public List<PlayerInventory.ItemVariable> ItemVariables = new List<PlayerInventory.ItemVariable>();

		// Token: 0x04001CD3 RID: 7379
		public Action<bool> onInventoryStateChanged;

		// Token: 0x04001CD4 RID: 7380
		private int PriorEquippedSlotIndex = -1;

		// Token: 0x04001CD5 RID: 7381
		private int PreviousEquippedSlotIndex = -1;

		// Token: 0x04001CD6 RID: 7382
		public UnityEvent onPreItemEquipped;

		// Token: 0x04001CD7 RID: 7383
		public UnityEvent onItemEquipped;

		// Token: 0x04001CD8 RID: 7384
		private bool ManagementSlotEnabled;

		// Token: 0x04001CD9 RID: 7385
		public float currentEquipTime;

		// Token: 0x04001CDA RID: 7386
		protected float currentDiscardTime;

		// Token: 0x020005F6 RID: 1526
		[Serializable]
		public class ItemVariable
		{
			// Token: 0x04001CDB RID: 7387
			public ItemDefinition Definition;

			// Token: 0x04001CDC RID: 7388
			public string VariableName;
		}

		// Token: 0x020005F7 RID: 1527
		[Serializable]
		private class ItemAmount
		{
			// Token: 0x04001CDD RID: 7389
			public ItemDefinition Definition;

			// Token: 0x04001CDE RID: 7390
			public int Amount = 10;
		}
	}
}
