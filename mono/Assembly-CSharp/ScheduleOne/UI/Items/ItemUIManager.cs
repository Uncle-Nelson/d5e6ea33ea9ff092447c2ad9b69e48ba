using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	// Token: 0x02000B75 RID: 2933
	public class ItemUIManager : Singleton<ItemUIManager>
	{
		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06004E0D RID: 19981 RVA: 0x0014881A File Offset: 0x00146A1A
		// (set) Token: 0x06004E0E RID: 19982 RVA: 0x00148822 File Offset: 0x00146A22
		public bool DraggingEnabled { get; protected set; }

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06004E0F RID: 19983 RVA: 0x0014882B File Offset: 0x00146A2B
		// (set) Token: 0x06004E10 RID: 19984 RVA: 0x00148833 File Offset: 0x00146A33
		public ItemSlotUI HoveredSlot { get; protected set; }

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06004E11 RID: 19985 RVA: 0x0014883C File Offset: 0x00146A3C
		// (set) Token: 0x06004E12 RID: 19986 RVA: 0x00148844 File Offset: 0x00146A44
		public bool QuickMoveEnabled { get; protected set; }

		// Token: 0x06004E13 RID: 19987 RVA: 0x0014884D File Offset: 0x00146A4D
		protected override void Awake()
		{
			base.Awake();
			this.InputsContainer.gameObject.SetActive(false);
			this.ItemQuantityPrompt.gameObject.SetActive(false);
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x00148878 File Offset: 0x00146A78
		protected virtual void Update()
		{
			this.HoveredSlot = null;
			if (this.DraggingEnabled)
			{
				CursorManager.ECursorType cursorAppearance = CursorManager.ECursorType.Default;
				this.HoveredSlot = this.GetHoveredItemSlot();
				if (this.HoveredSlot != null && this.CanDragFromSlot(this.HoveredSlot))
				{
					cursorAppearance = CursorManager.ECursorType.OpenHand;
				}
				if (this.HoveredSlot != null && this.draggedSlot == null && this.HoveredSlot.assignedSlot != null && this.HoveredSlot.assignedSlot.Quantity > 0)
				{
					if (this.InfoPanel.CurrentItem != this.HoveredSlot.assignedSlot.ItemInstance)
					{
						this.InfoPanel.Open(this.HoveredSlot.assignedSlot.ItemInstance, this.HoveredSlot.Rect);
					}
				}
				else
				{
					ItemDefinitionInfoHoverable hoveredItemInfo = this.GetHoveredItemInfo();
					if (hoveredItemInfo != null)
					{
						this.InfoPanel.Open(hoveredItemInfo.AssignedItem, hoveredItemInfo.transform as RectTransform);
					}
					else if (this.InfoPanel.IsOpen)
					{
						this.InfoPanel.Close();
					}
				}
				if (this.draggedSlot != null)
				{
					cursorAppearance = CursorManager.ECursorType.Grab;
					if (!GameInput.GetButton(GameInput.ButtonCode.PrimaryClick) && !GameInput.GetButton(GameInput.ButtonCode.SecondaryClick) && !GameInput.GetButton(GameInput.ButtonCode.TertiaryClick))
					{
						this.EndDrag();
					}
				}
				else if ((GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) || GameInput.GetButtonDown(GameInput.ButtonCode.SecondaryClick) || GameInput.GetButtonDown(GameInput.ButtonCode.TertiaryClick)) && this.HoveredSlot != null)
				{
					this.SlotClicked(this.HoveredSlot);
				}
				Singleton<CursorManager>.Instance.SetCursorAppearance(cursorAppearance);
			}
			if (this.draggedSlot != null && this.customDragAmount)
			{
				if (this.isDraggingCash)
				{
					CashInstance instance = this.draggedSlot.assignedSlot.ItemInstance as CashInstance;
					this.UpdateCashDragAmount(instance);
					return;
				}
				if (GameInput.MouseScrollDelta > 0f)
				{
					this.SetDraggedAmount(Mathf.Clamp(this.draggedAmount + 1, 1, this.draggedSlot.assignedSlot.Quantity));
					return;
				}
				if (GameInput.MouseScrollDelta < 0f)
				{
					this.SetDraggedAmount(Mathf.Clamp(this.draggedAmount - 1, 1, this.draggedSlot.assignedSlot.Quantity));
				}
			}
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x00148A9C File Offset: 0x00146C9C
		protected virtual void LateUpdate()
		{
			if (this.DraggingEnabled && this.draggedSlot != null)
			{
				this.tempIcon.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y) - this.mouseOffset;
				if (this.customDragAmount)
				{
					this.ItemQuantityPrompt.position = this.tempIcon.position + new Vector3(0f, this.tempIcon.rect.height * 0.5f + 25f, 0f);
				}
			}
			this.UpdateCashDragSelectorUI();
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x00148B50 File Offset: 0x00146D50
		private void UpdateCashDragSelectorUI()
		{
			if (this.draggedSlot != null && this.draggedSlot.assignedSlot != null && this.draggedSlot.assignedSlot.ItemInstance != null && this.draggedSlot.assignedSlot.ItemInstance is CashInstance && this.customDragAmount)
			{
				ItemInstance itemInstance = this.draggedSlot.assignedSlot.ItemInstance;
				this.tempIcon.Find("Balance").GetComponent<TextMeshProUGUI>().text = MoneyManager.FormatAmount(this.draggedCashAmount, false, false);
				this.CashDragAmountContainer.position = this.tempIcon.position + new Vector3(0f, this.tempIcon.rect.height * 0.5f + 15f, 0f);
				this.CashDragAmountContainer.gameObject.SetActive(true);
				return;
			}
			this.CashDragAmountContainer.gameObject.SetActive(false);
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x00148C5C File Offset: 0x00146E5C
		private void UpdateCashDragAmount(CashInstance instance)
		{
			float[] array = new float[]
			{
				50f,
				10f,
				1f
			};
			float[] array2 = new float[]
			{
				100f,
				10f,
				1f
			};
			float num = 0f;
			if (GameInput.MouseScrollDelta > 0f)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (this.draggedCashAmount >= array2[i])
					{
						num = array[i];
						break;
					}
				}
			}
			else if (GameInput.MouseScrollDelta < 0f)
			{
				for (int j = 0; j < array.Length; j++)
				{
					if (this.draggedCashAmount > array2[j])
					{
						num = -array[j];
						break;
					}
				}
			}
			if (num == 0f)
			{
				return;
			}
			this.draggedCashAmount = Mathf.Clamp(this.draggedCashAmount + num, 1f, Mathf.Min(instance.Balance, 1000f));
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x00148D24 File Offset: 0x00146F24
		public void SetDraggingEnabled(bool enabled, bool modifierPromptsVisible = true)
		{
			this.DraggingEnabled = enabled;
			if (!this.DraggingEnabled && this.draggedSlot != null)
			{
				this.EndDrag();
			}
			if (this.InfoPanel.IsOpen)
			{
				this.InfoPanel.Close();
			}
			if (!enabled)
			{
				this.DisableQuickMove();
			}
			this.InputsContainer.gameObject.SetActive(this.DraggingEnabled && modifierPromptsVisible);
			Singleton<HUD>.Instance.discardSlot.gameObject.SetActive(this.DraggingEnabled);
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x00148DA8 File Offset: 0x00146FA8
		public void EnableQuickMove(List<ItemSlot> primarySlots, List<ItemSlot> secondarySlots)
		{
			this.QuickMoveEnabled = true;
			this.PrimarySlots = new List<ItemSlot>();
			this.PrimarySlots.AddRange(primarySlots);
			this.SecondarySlots = new List<ItemSlot>();
			this.SecondarySlots.AddRange(secondarySlots);
			this.InputsContainer.gameObject.SetActive(this.QuickMoveEnabled);
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00148E00 File Offset: 0x00147000
		private List<ItemSlot> GetQuickMoveSlots(ItemSlot sourceSlot)
		{
			if (sourceSlot == null || sourceSlot.ItemInstance == null)
			{
				return new List<ItemSlot>();
			}
			List<ItemSlot> list = this.PrimarySlots.Contains(sourceSlot) ? this.SecondarySlots : this.PrimarySlots;
			List<ItemSlot> list2 = new List<ItemSlot>();
			foreach (ItemSlot itemSlot in list)
			{
				if (!itemSlot.IsLocked && !itemSlot.IsAddLocked && !itemSlot.IsRemovalLocked && itemSlot.DoesItemMatchFilters(sourceSlot.ItemInstance) && (itemSlot.GetCapacityForItem(sourceSlot.ItemInstance) > 0 || sourceSlot.ItemInstance is CashInstance))
				{
					list2.Add(itemSlot);
				}
			}
			return list2;
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00148EC4 File Offset: 0x001470C4
		public void DisableQuickMove()
		{
			this.QuickMoveEnabled = false;
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00148ED0 File Offset: 0x001470D0
		private ItemSlotUI GetHoveredItemSlot()
		{
			PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
			pointerEventData.position = Input.mousePosition;
			foreach (GraphicRaycaster baseRaycaster in this.Raycasters)
			{
				List<RaycastResult> list = new List<RaycastResult>();
				baseRaycaster.Raycast(pointerEventData, list);
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].gameObject.GetComponentInParent<ItemSlotUI>())
					{
						return list[j].gameObject.GetComponentInParent<ItemSlotUI>();
					}
				}
			}
			return null;
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x00148F68 File Offset: 0x00147168
		private ItemDefinitionInfoHoverable GetHoveredItemInfo()
		{
			PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
			pointerEventData.position = Input.mousePosition;
			foreach (GraphicRaycaster baseRaycaster in this.Raycasters)
			{
				List<RaycastResult> list = new List<RaycastResult>();
				baseRaycaster.Raycast(pointerEventData, list);
				for (int j = 0; j < list.Count; j++)
				{
					ItemDefinitionInfoHoverable componentInParent = list[j].gameObject.GetComponentInParent<ItemDefinitionInfoHoverable>();
					if (componentInParent != null && componentInParent.enabled)
					{
						return componentInParent;
					}
				}
			}
			return null;
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x00148FFC File Offset: 0x001471FC
		private void SlotClicked(ItemSlotUI ui)
		{
			if (!this.CanDragFromSlot(ui))
			{
				return;
			}
			if (this.DraggingEnabled)
			{
				if (this.draggedSlot != null)
				{
					return;
				}
				if (ui.assignedSlot.ItemInstance != null && !ui.assignedSlot.IsLocked && !ui.assignedSlot.IsRemovalLocked)
				{
					this.mouseOffset = new Vector2(Input.mousePosition.x, Input.mousePosition.y) - new Vector2(ui.ItemUI.Rect.position.x, ui.ItemUI.Rect.position.y);
					this.draggedSlot = ui;
					this.isDraggingCash = (this.draggedSlot.assignedSlot.ItemInstance is CashInstance);
					if (this.isDraggingCash)
					{
						this.StartDragCash();
						return;
					}
					this.customDragAmount = false;
					this.draggedAmount = this.draggedSlot.assignedSlot.Quantity;
					if (GameInput.GetButtonDown(GameInput.ButtonCode.SecondaryClick))
					{
						this.draggedAmount = 1;
						this.customDragAmount = true;
						this.mouseOffset += new Vector2(-10f, -15f);
					}
					if (GameInput.GetButton(GameInput.ButtonCode.QuickMove) && this.QuickMoveEnabled)
					{
						List<ItemSlot> quickMoveSlots = this.GetQuickMoveSlots(this.draggedSlot.assignedSlot);
						if (quickMoveSlots.Count > 0)
						{
							int num = 0;
							int num2 = 0;
							while (num2 < quickMoveSlots.Count && num < this.draggedAmount)
							{
								if (quickMoveSlots[num2].ItemInstance != null && quickMoveSlots[num2].ItemInstance.CanStackWith(this.draggedSlot.assignedSlot.ItemInstance, false))
								{
									int num3 = Mathf.Min(quickMoveSlots[num2].GetCapacityForItem(this.draggedSlot.assignedSlot.ItemInstance), this.draggedAmount - num);
									quickMoveSlots[num2].AddItem(this.draggedSlot.assignedSlot.ItemInstance.GetCopy(num3), false);
									num += num3;
								}
								num2++;
							}
							int num4 = 0;
							while (num4 < quickMoveSlots.Count && num < this.draggedAmount)
							{
								int num5 = Mathf.Min(quickMoveSlots[num4].GetCapacityForItem(this.draggedSlot.assignedSlot.ItemInstance), this.draggedAmount - num);
								quickMoveSlots[num4].AddItem(this.draggedSlot.assignedSlot.ItemInstance.GetCopy(num5), false);
								num += num5;
								num4++;
							}
							this.draggedSlot.assignedSlot.ChangeQuantity(-num, false);
						}
						this.draggedSlot = null;
						if (this.onItemMoved != null)
						{
							this.onItemMoved.Invoke();
						}
						return;
					}
					if (this.onDragStart != null)
					{
						this.onDragStart.Invoke();
					}
					this.ItemQuantityPrompt.gameObject.SetActive(this.customDragAmount);
					this.tempIcon = this.draggedSlot.DuplicateIcon(Singleton<HUD>.Instance.transform, this.draggedAmount);
					this.draggedSlot.IsBeingDragged = true;
					if (this.draggedAmount == this.draggedSlot.assignedSlot.Quantity)
					{
						this.draggedSlot.SetVisible(false);
						return;
					}
					this.draggedSlot.OverrideDisplayedQuantity(this.draggedSlot.assignedSlot.Quantity - this.draggedAmount);
				}
			}
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x00149354 File Offset: 0x00147554
		private void StartDragCash()
		{
			CashInstance cashInstance = this.draggedSlot.assignedSlot.ItemInstance as CashInstance;
			this.draggedCashAmount = Mathf.Min(cashInstance.Balance, 1000f);
			this.draggedAmount = 1;
			if (GameInput.GetButtonDown(GameInput.ButtonCode.SecondaryClick))
			{
				this.draggedAmount = 1;
				this.draggedCashAmount = Mathf.Min(cashInstance.Balance, 100f);
				this.mouseOffset += new Vector2(-10f, -15f);
				this.customDragAmount = true;
			}
			if (this.draggedCashAmount <= 0f)
			{
				this.draggedSlot = null;
				return;
			}
			if (GameInput.GetButton(GameInput.ButtonCode.QuickMove) && this.QuickMoveEnabled)
			{
				List<ItemSlot> quickMoveSlots = this.GetQuickMoveSlots(this.draggedSlot.assignedSlot);
				if (quickMoveSlots.Count > 0)
				{
					Debug.Log("Quick-moving " + this.draggedAmount.ToString() + " items...");
					float a = this.draggedCashAmount;
					float num = 0f;
					int num2 = 0;
					while (num2 < quickMoveSlots.Count && num < (float)this.draggedAmount)
					{
						ItemSlot itemSlot = quickMoveSlots[num2];
						if (itemSlot.ItemInstance != null)
						{
							CashInstance cashInstance2 = itemSlot.ItemInstance as CashInstance;
							if (cashInstance2 != null)
							{
								float num3;
								if (itemSlot is CashSlot)
								{
									num3 = Mathf.Min(a, float.MaxValue - cashInstance2.Balance);
								}
								else
								{
									num3 = Mathf.Min(a, 1000f - cashInstance2.Balance);
								}
								cashInstance2.ChangeBalance(num3);
								itemSlot.ReplicateStoredInstance();
								num += num3;
							}
						}
						else
						{
							CashInstance cashInstance3 = Registry.GetItem("cash").GetDefaultInstance(1) as CashInstance;
							cashInstance3.SetBalance(this.draggedCashAmount, false);
							itemSlot.SetStoredItem(cashInstance3, false);
							num += this.draggedCashAmount;
						}
						num2++;
					}
					if (num >= cashInstance.Balance)
					{
						this.draggedSlot.assignedSlot.ClearStoredInstance(false);
					}
					else
					{
						cashInstance.ChangeBalance(-num);
						this.draggedSlot.assignedSlot.ReplicateStoredInstance();
					}
				}
				if (this.onItemMoved != null)
				{
					this.onItemMoved.Invoke();
				}
				this.draggedSlot = null;
				return;
			}
			if (this.onDragStart != null)
			{
				this.onDragStart.Invoke();
			}
			if (this.draggedSlot.assignedSlot != PlayerSingleton<PlayerInventory>.Instance.cashSlot)
			{
				this.CashSlotHintAnim.Play();
			}
			this.tempIcon = this.draggedSlot.DuplicateIcon(Singleton<HUD>.Instance.transform, this.draggedAmount);
			this.tempIcon.Find("Balance").GetComponent<TextMeshProUGUI>().text = MoneyManager.FormatAmount(this.draggedCashAmount, false, false);
			this.draggedSlot.IsBeingDragged = true;
			if (this.draggedCashAmount >= cashInstance.Balance)
			{
				this.draggedSlot.SetVisible(false);
				return;
			}
			(this.draggedSlot.ItemUI as ItemUI_Cash).SetDisplayedBalance(cashInstance.Balance - this.draggedCashAmount);
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x00149648 File Offset: 0x00147848
		private void EndDrag()
		{
			if (this.isDraggingCash)
			{
				this.EndCashDrag();
				return;
			}
			if (this.CanDragFromSlot(this.draggedSlot) && this.HoveredSlot != null && this.HoveredSlot != this.draggedSlot && this.HoveredSlot.assignedSlot != null && !this.HoveredSlot.assignedSlot.IsLocked && !this.HoveredSlot.assignedSlot.IsAddLocked && this.HoveredSlot.assignedSlot.DoesItemMatchFilters(this.draggedSlot.assignedSlot.ItemInstance))
			{
				if (this.HoveredSlot.assignedSlot.ItemInstance == null)
				{
					this.HoveredSlot.assignedSlot.SetStoredItem(this.draggedSlot.assignedSlot.ItemInstance.GetCopy(this.draggedAmount), false);
					this.draggedSlot.assignedSlot.ChangeQuantity(-this.draggedAmount, false);
				}
				else if (this.HoveredSlot.assignedSlot.ItemInstance.CanStackWith(this.draggedSlot.assignedSlot.ItemInstance, false))
				{
					while (this.HoveredSlot.assignedSlot.Quantity < this.HoveredSlot.assignedSlot.ItemInstance.StackLimit)
					{
						if (this.draggedAmount <= 0)
						{
							break;
						}
						this.HoveredSlot.assignedSlot.ChangeQuantity(1, false);
						this.draggedSlot.assignedSlot.ChangeQuantity(-1, false);
						this.draggedAmount--;
					}
				}
				else if (this.draggedSlot.assignedSlot.DoesItemMatchFilters(this.HoveredSlot.assignedSlot.ItemInstance))
				{
					if (this.draggedAmount == this.draggedSlot.assignedSlot.Quantity)
					{
						ItemInstance itemInstance = this.draggedSlot.assignedSlot.ItemInstance;
						ItemInstance itemInstance2 = this.HoveredSlot.assignedSlot.ItemInstance;
						this.draggedSlot.assignedSlot.SetStoredItem(itemInstance2, false);
						this.HoveredSlot.assignedSlot.SetStoredItem(itemInstance, false);
					}
					else if (this.HoveredSlot.assignedSlot.ItemInstance == null)
					{
						this.HoveredSlot.assignedSlot.SetStoredItem(this.draggedSlot.assignedSlot.ItemInstance, false);
						this.draggedSlot.assignedSlot.ClearStoredInstance(false);
					}
				}
				if (this.onItemMoved != null)
				{
					this.onItemMoved.Invoke();
				}
			}
			if (this.draggedSlot != null)
			{
				this.draggedSlot.SetVisible(true);
				this.draggedSlot.UpdateUI();
				this.draggedSlot.IsBeingDragged = false;
				this.draggedSlot = null;
			}
			if (this.tempIcon != null)
			{
				Object.Destroy(this.tempIcon.gameObject);
				this.tempIcon = null;
			}
			this.ItemQuantityPrompt.gameObject.SetActive(false);
			Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Default);
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x00149940 File Offset: 0x00147B40
		private void SetDraggedAmount(int amount)
		{
			ItemUIManager.<>c__DisplayClass49_0 CS$<>8__locals1 = new ItemUIManager.<>c__DisplayClass49_0();
			CS$<>8__locals1.<>4__this = this;
			this.draggedAmount = amount;
			CS$<>8__locals1.quantityText = this.tempIcon.Find("Quantity").GetComponent<TextMeshProUGUI>();
			if (CS$<>8__locals1.quantityText != null && CS$<>8__locals1.quantityText.gameObject.name == "Quantity")
			{
				CS$<>8__locals1.quantityText.text = this.draggedAmount.ToString() + "x";
				CS$<>8__locals1.quantityText.enabled = (this.draggedAmount > 1);
			}
			if (this.draggedAmount == this.draggedSlot.assignedSlot.Quantity)
			{
				this.draggedSlot.SetVisible(false);
			}
			else
			{
				this.draggedSlot.OverrideDisplayedQuantity(this.draggedSlot.assignedSlot.Quantity - this.draggedAmount);
				this.draggedSlot.SetVisible(true);
			}
			if (CS$<>8__locals1.quantityText != null)
			{
				if (this.quantityChangePopRoutine != null)
				{
					base.StopCoroutine(this.quantityChangePopRoutine);
				}
				this.quantityChangePopRoutine = base.StartCoroutine(CS$<>8__locals1.<SetDraggedAmount>g__LerpQuantityTextSize|0());
			}
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x00149A64 File Offset: 0x00147C64
		private void EndCashDrag()
		{
			CashInstance cashInstance = null;
			if (this.draggedSlot != null && this.draggedSlot.assignedSlot != null)
			{
				cashInstance = (this.draggedSlot.assignedSlot.ItemInstance as CashInstance);
			}
			this.CashSlotHintAnim.Stop();
			this.CashSlotHintAnimCanvasGroup.alpha = 0f;
			if (this.CanDragFromSlot(this.draggedSlot) && this.HoveredSlot != null && this.CanCashBeDraggedIntoSlot(this.HoveredSlot) && !this.HoveredSlot.assignedSlot.IsLocked && !this.HoveredSlot.assignedSlot.IsAddLocked && this.HoveredSlot.assignedSlot.DoesItemMatchFilters(this.draggedSlot.assignedSlot.ItemInstance))
			{
				if (this.HoveredSlot.assignedSlot is HotbarSlot && !(this.HoveredSlot.assignedSlot is CashSlot))
				{
					this.HoveredSlot = Singleton<HUD>.Instance.cashSlotUI.GetComponent<CashSlotUI>();
				}
				float num = Mathf.Min(this.draggedCashAmount, cashInstance.Balance);
				if (num > 0f)
				{
					float num2 = num;
					if (this.HoveredSlot.assignedSlot.ItemInstance != null)
					{
						CashInstance cashInstance2 = this.HoveredSlot.assignedSlot.ItemInstance as CashInstance;
						if (this.HoveredSlot.assignedSlot is CashSlot)
						{
							num2 = Mathf.Min(num, float.MaxValue - cashInstance2.Balance);
						}
						else
						{
							num2 = Mathf.Min(num, 1000f - cashInstance2.Balance);
						}
						cashInstance2.ChangeBalance(num2);
						this.HoveredSlot.assignedSlot.ReplicateStoredInstance();
					}
					else
					{
						CashInstance cashInstance3 = Registry.GetItem("cash").GetDefaultInstance(1) as CashInstance;
						cashInstance3.SetBalance(num2, false);
						this.HoveredSlot.assignedSlot.SetStoredItem(cashInstance3, false);
					}
					if (num2 >= cashInstance.Balance)
					{
						this.draggedSlot.assignedSlot.ClearStoredInstance(false);
					}
					else
					{
						cashInstance.ChangeBalance(-num2);
						this.draggedSlot.assignedSlot.ReplicateStoredInstance();
					}
				}
			}
			this.draggedSlot.SetVisible(true);
			this.draggedSlot.UpdateUI();
			this.draggedSlot.IsBeingDragged = false;
			this.draggedSlot = null;
			Object.Destroy(this.tempIcon.gameObject);
			Singleton<CursorManager>.Instance.SetCursorAppearance(CursorManager.ECursorType.Default);
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x00149CC0 File Offset: 0x00147EC0
		public bool CanDragFromSlot(ItemSlotUI slotUI)
		{
			return !(slotUI == null) && slotUI.assignedSlot != null && slotUI.assignedSlot.ItemInstance != null && !slotUI.assignedSlot.IsLocked && !slotUI.assignedSlot.IsRemovalLocked;
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x00149D0E File Offset: 0x00147F0E
		public bool CanCashBeDraggedIntoSlot(ItemSlotUI ui)
		{
			return !(ui == null) && ui.assignedSlot != null && (ui.assignedSlot.ItemInstance == null || ui.assignedSlot.ItemInstance is CashInstance);
		}

		// Token: 0x04003AE1 RID: 15073
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003AE2 RID: 15074
		public GraphicRaycaster[] Raycasters;

		// Token: 0x04003AE3 RID: 15075
		public RectTransform CashDragAmountContainer;

		// Token: 0x04003AE4 RID: 15076
		public RectTransform InputsContainer;

		// Token: 0x04003AE5 RID: 15077
		public ItemInfoPanel InfoPanel;

		// Token: 0x04003AE6 RID: 15078
		public RectTransform ItemQuantityPrompt;

		// Token: 0x04003AE7 RID: 15079
		public Animation CashSlotHintAnim;

		// Token: 0x04003AE8 RID: 15080
		public CanvasGroup CashSlotHintAnimCanvasGroup;

		// Token: 0x04003AE9 RID: 15081
		[Header("Prefabs")]
		public ItemSlotUI ItemSlotUIPrefab;

		// Token: 0x04003AEA RID: 15082
		public ItemUI DefaultItemUIPrefab;

		// Token: 0x04003AEB RID: 15083
		public ItemSlotUI HotbarSlotUIPrefab;

		// Token: 0x04003AEC RID: 15084
		private ItemSlotUI draggedSlot;

		// Token: 0x04003AED RID: 15085
		private Vector2 mouseOffset = Vector2.zero;

		// Token: 0x04003AEE RID: 15086
		private int draggedAmount;

		// Token: 0x04003AEF RID: 15087
		private RectTransform tempIcon;

		// Token: 0x04003AF0 RID: 15088
		private bool isDraggingCash;

		// Token: 0x04003AF1 RID: 15089
		private float draggedCashAmount;

		// Token: 0x04003AF2 RID: 15090
		private List<ItemSlot> PrimarySlots = new List<ItemSlot>();

		// Token: 0x04003AF3 RID: 15091
		private List<ItemSlot> SecondarySlots = new List<ItemSlot>();

		// Token: 0x04003AF4 RID: 15092
		private bool customDragAmount;

		// Token: 0x04003AF5 RID: 15093
		private Coroutine quantityChangePopRoutine;

		// Token: 0x04003AF6 RID: 15094
		public UnityEvent onDragStart;

		// Token: 0x04003AF7 RID: 15095
		public UnityEvent onItemMoved;
	}
}
