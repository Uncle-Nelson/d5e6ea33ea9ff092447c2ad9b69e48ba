using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FluffyUnderware.DevTools.Extensions;
using GameKit.Utilities;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.UI.Input;
using ScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A1A RID: 2586
	public class PickpocketScreen : Singleton<PickpocketScreen>
	{
		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x00124534 File Offset: 0x00122734
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x0012453C File Offset: 0x0012273C
		public bool IsOpen { get; private set; }

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x00124545 File Offset: 0x00122745
		// (set) Token: 0x060045B7 RID: 17847 RVA: 0x0012454D File Offset: 0x0012274D
		public bool TutorialOpen { get; private set; }

		// Token: 0x060045B8 RID: 17848 RVA: 0x00124556 File Offset: 0x00122756
		protected override void Awake()
		{
			base.Awake();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 3);
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00124590 File Offset: 0x00122790
		public void Open(NPC _npc)
		{
			this.IsOpen = true;
			this.npc = _npc;
			this.npc.SetIsBeingPickPocketed(true);
			Singleton<GameInput>.Instance.ExitAll();
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0f);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(true, true);
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			Player.Local.VisualState.ApplyState("pickpocketing", PlayerVisualState.EVisualState.Pickpocketing, 0f);
			ItemSlot[] array = _npc.Inventory.ItemSlots.ToArray();
			Arrays.Shuffle<ItemSlot>(array);
			for (int i = 0; i < this.Slots.Length; i++)
			{
				if (i < array.Length)
				{
					this.Slots[i].AssignSlot(array[i]);
				}
				else
				{
					this.Slots[i].ClearSlot();
				}
			}
			Singleton<ItemUIManager>.Instance.EnableQuickMove(new List<ItemSlot>(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots()), array.ToList<ItemSlot>());
			for (int j = 0; j < this.Slots.Length; j++)
			{
				ItemSlotUI itemSlotUI = this.Slots[j];
				this.SetSlotLocked(j, true);
				if (itemSlotUI.assignedSlot == null || itemSlotUI.assignedSlot.Quantity == 0)
				{
					this.GreenAreas[j].gameObject.SetActive(false);
				}
				else
				{
					float monetaryValue = itemSlotUI.assignedSlot.ItemInstance.GetMonetaryValue();
					float num = Mathf.Lerp(this.GreenAreaMaxWidth, this.GreenAreaMinWidth, Mathf.Pow(Mathf.Clamp01(monetaryValue / this.ValueDivisor), 0.3f));
					if (Player.Local.Sneaky)
					{
						num *= 1.5f;
					}
					RectTransform rectTransform = this.GreenAreas[j];
					rectTransform.sizeDelta = new Vector2(num, rectTransform.sizeDelta.y);
					rectTransform.gameObject.SetActive(true);
					rectTransform.anchoredPosition = new Vector2(37.5f + 90f * (float)j, rectTransform.anchoredPosition.y);
				}
			}
			this.InputPrompt.SetLabel("Stop Arrow");
			this.isFail = false;
			this.isSliding = true;
			this.sliderPosition = 0f;
			this.slideDirection = 1;
			this.slideTimeMultiplier = 1f;
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x00124804 File Offset: 0x00122A04
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

		// Token: 0x060045BB RID: 17851 RVA: 0x00124830 File Offset: 0x00122A30
		private void Update()
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (this.isFail)
			{
				return;
			}
			if (Player.Local.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
			{
				this.Close();
				return;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Jump))
			{
				if (this.isSliding)
				{
					this.StopArrow();
				}
				else
				{
					this.InputPrompt.SetLabel("Stop Arrow");
					this.isSliding = true;
					ItemSlotUI hoveredSlot = this.GetHoveredSlot();
					if (((hoveredSlot != null) ? hoveredSlot.assignedSlot : null) != null)
					{
						this.GreenAreas[ArrayExt.IndexOf<ItemSlotUI>(this.Slots, this.GetHoveredSlot())].gameObject.SetActive(false);
					}
				}
			}
			if (this.isSliding)
			{
				this.slideTimeMultiplier = Mathf.Clamp(this.slideTimeMultiplier + Time.deltaTime / 20f, 0f, this.SlideTimeMaxMultiplier);
				if (this.slideDirection == 1)
				{
					this.sliderPosition = Mathf.Clamp01(this.sliderPosition + Time.deltaTime / this.SlideTime * this.slideTimeMultiplier);
					if (this.sliderPosition >= 1f)
					{
						this.slideDirection = -1;
					}
				}
				else
				{
					this.sliderPosition = Mathf.Clamp01(this.sliderPosition - Time.deltaTime / this.SlideTime * this.slideTimeMultiplier);
					if (this.sliderPosition <= 0f)
					{
						this.slideDirection = 1;
					}
				}
			}
			this.Slider.value = this.sliderPosition;
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00124990 File Offset: 0x00122B90
		private void StopArrow()
		{
			if (this.onStop != null)
			{
				this.onStop.Invoke();
			}
			this.isSliding = false;
			ItemSlotUI hoveredSlot = this.GetHoveredSlot();
			this.InputPrompt.SetLabel("Continue");
			if (hoveredSlot != null)
			{
				NetworkSingleton<LevelManager>.Instance.AddXP(2);
				this.SetSlotLocked(ArrayExt.IndexOf<ItemSlotUI>(this.Slots, hoveredSlot), false);
				Customer component = this.npc.GetComponent<Customer>();
				if (component != null && component.TimeSinceLastDealCompleted < 60 && hoveredSlot.assignedSlot != null && hoveredSlot.assignedSlot.ItemInstance != null && hoveredSlot.assignedSlot.ItemInstance is ProductItemInstance)
				{
					Singleton<AchievementManager>.Instance.UnlockAchievement(AchievementManager.EAchievement.INDIAN_DEALER);
				}
				if (this.onHitGreen != null)
				{
					this.onHitGreen.Invoke();
					return;
				}
			}
			else
			{
				this.Fail();
			}
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x00124A64 File Offset: 0x00122C64
		public void SetSlotLocked(int index, bool locked)
		{
			this.Slots[index].Rect.Find("Locked").gameObject.SetActive(locked);
			this.Slots[index].assignedSlot.SetIsAddLocked(locked);
			this.Slots[index].assignedSlot.SetIsRemovalLocked(locked);
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00124ABC File Offset: 0x00122CBC
		private ItemSlotUI GetHoveredSlot()
		{
			for (int i = 0; i < this.GreenAreas.Length; i++)
			{
				if (this.GreenAreas[i].gameObject.activeSelf)
				{
					float num = this.GetGreenAreaNormalizedPosition(i) - this.GetGreenAreaNormalizedWidth(i) / 2f;
					float num2 = this.GetGreenAreaNormalizedPosition(i) + this.GetGreenAreaNormalizedWidth(i) / 2f;
					if (this.Slider.value >= num - this.Tolerance && this.Slider.value <= num2 + this.Tolerance)
					{
						return this.Slots[i];
					}
				}
			}
			return null;
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00124B53 File Offset: 0x00122D53
		private void Fail()
		{
			this.isFail = true;
			if (this.onFail != null)
			{
				this.onFail.Invoke();
			}
			base.StartCoroutine(this.<Fail>g__FailCoroutine|40_0());
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00124B7C File Offset: 0x00122D7C
		public void Close()
		{
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			for (int i = 0; i < this.Slots.Length; i++)
			{
				if (this.Slots[i].assignedSlot != null)
				{
					this.Slots[i].assignedSlot.SetIsRemovalLocked(false);
				}
			}
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0f);
			Player.Local.VisualState.RemoveState("pickpocketing", 0f);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(false, true);
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
			this.npc.SetIsBeingPickPocketed(false);
			if (this.isFail)
			{
				this.npc.responses.PlayerFailedPickpocket(Player.Local);
				this.npc.Inventory.ExpirePickpocket();
			}
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00124C96 File Offset: 0x00122E96
		private void OpenTutorial()
		{
			this.TutorialOpen = true;
			this.TutorialContainer.gameObject.SetActive(true);
			this.TutorialAnimation.Play();
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00124CBC File Offset: 0x00122EBC
		public void CloseTutorial()
		{
			this.TutorialOpen = false;
			this.TutorialContainer.gameObject.SetActive(false);
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00124CD6 File Offset: 0x00122ED6
		private float GetGreenAreaNormalizedPosition(int index)
		{
			return this.GreenAreas[index].anchoredPosition.x / this.SliderContainer.sizeDelta.x;
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00124CFB File Offset: 0x00122EFB
		private float GetGreenAreaNormalizedWidth(int index)
		{
			return this.GreenAreas[index].sizeDelta.x / this.SliderContainer.sizeDelta.x;
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00124D87 File Offset: 0x00122F87
		[CompilerGenerated]
		private IEnumerator <Fail>g__FailCoroutine|40_0()
		{
			yield return new WaitForSeconds(0.9f);
			if (this.IsOpen)
			{
				this.Close();
			}
			yield break;
		}

		// Token: 0x0400334B RID: 13131
		public const int PICKPOCKET_XP = 2;

		// Token: 0x0400334E RID: 13134
		[Header("Settings")]
		public float GreenAreaMaxWidth = 70f;

		// Token: 0x0400334F RID: 13135
		public float GreenAreaMinWidth = 5f;

		// Token: 0x04003350 RID: 13136
		public float SlideTime = 1f;

		// Token: 0x04003351 RID: 13137
		public float SlideTimeMaxMultiplier = 2f;

		// Token: 0x04003352 RID: 13138
		public float ValueDivisor = 300f;

		// Token: 0x04003353 RID: 13139
		public float Tolerance = 0.01f;

		// Token: 0x04003354 RID: 13140
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003355 RID: 13141
		public RectTransform Container;

		// Token: 0x04003356 RID: 13142
		public ItemSlotUI[] Slots;

		// Token: 0x04003357 RID: 13143
		public RectTransform[] GreenAreas;

		// Token: 0x04003358 RID: 13144
		public Animation TutorialAnimation;

		// Token: 0x04003359 RID: 13145
		public RectTransform TutorialContainer;

		// Token: 0x0400335A RID: 13146
		public RectTransform SliderContainer;

		// Token: 0x0400335B RID: 13147
		public Slider Slider;

		// Token: 0x0400335C RID: 13148
		public InputPrompt InputPrompt;

		// Token: 0x0400335D RID: 13149
		public UnityEvent onFail;

		// Token: 0x0400335E RID: 13150
		public UnityEvent onStop;

		// Token: 0x0400335F RID: 13151
		public UnityEvent onHitGreen;

		// Token: 0x04003360 RID: 13152
		private NPC npc;

		// Token: 0x04003361 RID: 13153
		private bool isSliding;

		// Token: 0x04003362 RID: 13154
		private int slideDirection = 1;

		// Token: 0x04003363 RID: 13155
		private float sliderPosition;

		// Token: 0x04003364 RID: 13156
		private float slideTimeMultiplier = 1f;

		// Token: 0x04003365 RID: 13157
		private bool isFail;
	}
}
