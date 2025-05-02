using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009BF RID: 2495
	public class BodySearchScreen : Singleton<BodySearchScreen>
	{
		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x00119E53 File Offset: 0x00118053
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x00119E5B File Offset: 0x0011805B
		public bool IsOpen { get; private set; }

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x00119E64 File Offset: 0x00118064
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x00119E6C File Offset: 0x0011806C
		public bool TutorialOpen { get; private set; }

		// Token: 0x06004354 RID: 17236 RVA: 0x00119E78 File Offset: 0x00118078
		protected override void Start()
		{
			base.Start();
			if (Player.Local != null)
			{
				this.SetupSlots();
			}
			else
			{
				Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.SetupSlots));
			}
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00119EE0 File Offset: 0x001180E0
		private void SetupSlots()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.SetupSlots));
			for (int i = 0; i < 8; i++)
			{
				ItemSlotUI slot = Object.Instantiate<ItemSlotUI>(this.ItemSlotPrefab, this.SlotContainer);
				slot.AssignSlot(PlayerSingleton<PlayerInventory>.Instance.hotbarSlots[i]);
				this.slots.Add(slot);
				EventTrigger eventTrigger = slot.Rect.gameObject.AddComponent<EventTrigger>();
				eventTrigger.triggers = new List<EventTrigger.Entry>();
				EventTrigger.Entry entry = new EventTrigger.Entry();
				entry.eventID = 2;
				entry.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
				{
					this.SlotHeld(slot);
				}));
				eventTrigger.triggers.Add(entry);
				EventTrigger.Entry entry2 = new EventTrigger.Entry();
				entry2.eventID = 3;
				entry2.callback.AddListener(new UnityAction<BaseEventData>(delegate(BaseEventData data)
				{
					this.SlotReleased(slot);
				}));
				eventTrigger.triggers.Add(entry2);
			}
			this.defaultSlotColor = this.slots[0].normalColor;
			this.defaultSlotHighlightColor = this.slots[0].highlightColor;
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x0011A028 File Offset: 0x00118228
		private void Update()
		{
			if (this.hoveredSlot != null)
			{
				this.hoveredSlot.SetHighlighted(this.hoveredSlot != this.concealedSlot);
			}
			if (this.IsOpen)
			{
				if (GameInput.GetButton(GameInput.ButtonCode.Jump))
				{
					this.speedBoost = Mathf.MoveTowards(this.speedBoost, 2.5f, Time.deltaTime * 6f);
				}
				else
				{
					this.speedBoost = Mathf.MoveTowards(this.speedBoost, 0f, Time.deltaTime * 6f);
				}
				if (Player.Local != null && Player.Local.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
				{
					this.Close(false);
				}
			}
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x0011A0D8 File Offset: 0x001182D8
		public void Open(NPC _searcher, float searchTime = 0f)
		{
			BodySearchScreen.<>c__DisplayClass37_0 CS$<>8__locals1 = new BodySearchScreen.<>c__DisplayClass37_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.searchTime = searchTime;
			this.IsOpen = true;
			this.searcher = _searcher;
			Singleton<GameInput>.Instance.ExitAll();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0f);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(false, true);
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			for (int i = 0; i < this.slots.Count; i++)
			{
				if (this.slots[i].assignedSlot.ItemInstance != null && this.slots[i].assignedSlot.ItemInstance.Definition.legalStatus != ELegalStatus.Legal)
				{
					this.slots[i].SetNormalColor(this.SlotRedColor);
					this.slots[i].SetHighlightColor(this.SlotHighlightRedColor);
				}
				else
				{
					this.slots[i].SetNormalColor(this.defaultSlotColor);
					this.slots[i].SetHighlightColor(this.defaultSlotHighlightColor);
				}
				this.slots[i].SetHighlighted(false);
			}
			this.concealedSlot = null;
			base.StartCoroutine(CS$<>8__locals1.<Open>g__Search|0());
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x0011A24D File Offset: 0x0011844D
		private bool IsSlotConcealed(ItemSlotUI slot)
		{
			return this.concealedSlot == slot;
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x0011A25B File Offset: 0x0011845B
		private void ItemDetected(ItemSlotUI slot)
		{
			this.IndicatorAnimation.Play("Police icon discover");
			if (this.onSearchFail != null)
			{
				this.onSearchFail.Invoke();
			}
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x0011A284 File Offset: 0x00118484
		public void SlotHeld(ItemSlotUI ui)
		{
			this.concealedSlot = ui;
			Image[] componentsInChildren = ui.ItemContainer.GetComponentsInChildren<Image>();
			this.defaultItemIconColors = new Color[componentsInChildren.Length];
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				this.defaultItemIconColors[i] = componentsInChildren[i].color;
				componentsInChildren[i].color = Color.black;
			}
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x0011A2E4 File Offset: 0x001184E4
		public void SlotReleased(ItemSlotUI ui)
		{
			this.concealedSlot = null;
			Image[] componentsInChildren = ui.ItemContainer.GetComponentsInChildren<Image>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].color = this.defaultItemIconColors[i];
			}
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x0011A328 File Offset: 0x00118528
		public void Close(bool clear)
		{
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0f);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
			if (clear && this.onSearchClear != null)
			{
				this.onSearchClear.Invoke();
			}
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x0011A3C5 File Offset: 0x001185C5
		private void OpenTutorial()
		{
			this.TutorialOpen = true;
			this.TutorialContainer.gameObject.SetActive(true);
			this.TutorialAnimation.Play();
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x0011A3EB File Offset: 0x001185EB
		public void CloseTutorial()
		{
			this.TutorialOpen = false;
			this.TutorialContainer.gameObject.SetActive(false);
		}

		// Token: 0x040030E7 RID: 12519
		public const float MAX_SPEED_BOOST = 2.5f;

		// Token: 0x040030EA RID: 12522
		public Color SlotRedColor = new Color(1f, 0f, 0f, 0.5f);

		// Token: 0x040030EB RID: 12523
		public Color SlotHighlightRedColor = new Color(1f, 0f, 0f, 0.5f);

		// Token: 0x040030EC RID: 12524
		public float GapTime = 0.2f;

		// Token: 0x040030ED RID: 12525
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040030EE RID: 12526
		public RectTransform Container;

		// Token: 0x040030EF RID: 12527
		public RectTransform MinigameController;

		// Token: 0x040030F0 RID: 12528
		public RectTransform SlotContainer;

		// Token: 0x040030F1 RID: 12529
		public ItemSlotUI ItemSlotPrefab;

		// Token: 0x040030F2 RID: 12530
		public RectTransform SearchIndicator;

		// Token: 0x040030F3 RID: 12531
		public RectTransform SearchIndicatorStart;

		// Token: 0x040030F4 RID: 12532
		public RectTransform SearchIndicatorEnd;

		// Token: 0x040030F5 RID: 12533
		public Animation IndicatorAnimation;

		// Token: 0x040030F6 RID: 12534
		public Animation TutorialAnimation;

		// Token: 0x040030F7 RID: 12535
		public RectTransform TutorialContainer;

		// Token: 0x040030F8 RID: 12536
		public Animation ResetAnimation;

		// Token: 0x040030F9 RID: 12537
		private List<ItemSlotUI> slots = new List<ItemSlotUI>();

		// Token: 0x040030FA RID: 12538
		public UnityEvent onSearchClear;

		// Token: 0x040030FB RID: 12539
		public UnityEvent onSearchFail;

		// Token: 0x040030FC RID: 12540
		private Color defaultSlotColor = new Color(0f, 0f, 0f, 0f);

		// Token: 0x040030FD RID: 12541
		private Color defaultSlotHighlightColor = new Color(0f, 0f, 0f, 0f);

		// Token: 0x040030FE RID: 12542
		private ItemSlotUI concealedSlot;

		// Token: 0x040030FF RID: 12543
		private ItemSlotUI hoveredSlot;

		// Token: 0x04003100 RID: 12544
		private Color[] defaultItemIconColors;

		// Token: 0x04003101 RID: 12545
		private float speedBoost;

		// Token: 0x04003102 RID: 12546
		private NPC searcher;
	}
}
