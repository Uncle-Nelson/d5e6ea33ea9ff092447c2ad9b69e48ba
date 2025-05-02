using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Compass;
using ScheduleOne.UI.Items;
using ScheduleOne.UI.Phone;
using ScheduleOne.UI.Phone.Map;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009E5 RID: 2533
	public class GameplayMenu : Singleton<GameplayMenu>
	{
		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x0011E9D3 File Offset: 0x0011CBD3
		// (set) Token: 0x0600445E RID: 17502 RVA: 0x0011E9DB File Offset: 0x0011CBDB
		public bool IsOpen { get; protected set; }

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool CharacterScreenEnabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x0011E9E4 File Offset: 0x0011CBE4
		// (set) Token: 0x06004461 RID: 17505 RVA: 0x0011E9EC File Offset: 0x0011CBEC
		public GameplayMenu.EGameplayScreen CurrentScreen { get; protected set; }

		// Token: 0x06004462 RID: 17506 RVA: 0x0011E9F8 File Offset: 0x0011CBF8
		protected override void Start()
		{
			base.Start();
			this.OverlayCamera.enabled = false;
			this.OverlayLight.enabled = false;
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, -2f, base.transform.localPosition.z);
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 0);
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x0011EA6C File Offset: 0x0011CC6C
		public void Exit(ExitAction exit)
		{
			if (exit.used)
			{
				return;
			}
			if (exit.exitType == ExitType.RightClick && Singleton<ItemUIManager>.InstanceExists && Singleton<ItemUIManager>.Instance.CanDragFromSlot(Singleton<ItemUIManager>.Instance.HoveredSlot))
			{
				return;
			}
			if (this.IsOpen)
			{
				exit.used = true;
				this.SetIsOpen(false);
			}
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x0011EAC0 File Offset: 0x0011CCC0
		protected virtual void Update()
		{
			if (!GameInput.IsTyping && !Singleton<PauseMenu>.Instance.IsPaused && (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount == 0 || this.IsOpen))
			{
				if (GameInput.GetButtonDown(GameInput.ButtonCode.TogglePhone))
				{
					this.SetIsOpen(!this.IsOpen);
				}
				if (GameInput.GetButtonDown(GameInput.ButtonCode.OpenMap) && !GameManager.IS_TUTORIAL)
				{
					if (PlayerSingleton<MapApp>.Instance.isOpen && this.IsOpen && this.CurrentScreen == GameplayMenu.EGameplayScreen.Phone)
					{
						this.SetIsOpen(false);
					}
					else
					{
						this.<Update>g__PrepAppOpen|22_0();
						PlayerSingleton<MapApp>.Instance.SetOpen(true);
					}
				}
				if (GameInput.GetButtonDown(GameInput.ButtonCode.OpenJournal))
				{
					if (PlayerSingleton<JournalApp>.Instance.isOpen && this.IsOpen && this.CurrentScreen == GameplayMenu.EGameplayScreen.Phone)
					{
						this.SetIsOpen(false);
					}
					else
					{
						this.<Update>g__PrepAppOpen|22_0();
						PlayerSingleton<JournalApp>.Instance.SetOpen(true);
					}
				}
				if (GameInput.GetButtonDown(GameInput.ButtonCode.OpenTexts))
				{
					if (PlayerSingleton<MessagesApp>.Instance.isOpen && this.IsOpen && this.CurrentScreen == GameplayMenu.EGameplayScreen.Phone)
					{
						this.SetIsOpen(false);
					}
					else
					{
						this.<Update>g__PrepAppOpen|22_0();
						PlayerSingleton<MessagesApp>.Instance.SetOpen(true);
					}
				}
				if (this.IsOpen)
				{
					bool characterScreenEnabled = this.CharacterScreenEnabled;
				}
			}
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x0011EBE8 File Offset: 0x0011CDE8
		public void SetScreen(GameplayMenu.EGameplayScreen screen)
		{
			GameplayMenu.<>c__DisplayClass23_0 CS$<>8__locals1 = new GameplayMenu.<>c__DisplayClass23_0();
			CS$<>8__locals1.screen = screen;
			CS$<>8__locals1.<>4__this = this;
			if (this.CurrentScreen == CS$<>8__locals1.screen)
			{
				return;
			}
			CS$<>8__locals1.previousScreen = this.CurrentScreen;
			this.CurrentScreen = CS$<>8__locals1.screen;
			if (CS$<>8__locals1.screen == GameplayMenu.EGameplayScreen.Phone)
			{
				PlayerSingleton<Phone>.Instance.SetIsOpen(true);
			}
			else if (CS$<>8__locals1.screen == GameplayMenu.EGameplayScreen.Character)
			{
				Singleton<CharacterDisplay>.Instance.SetOpen(true);
			}
			if (this.screenChangeRoutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.screenChangeRoutine);
			}
			Singleton<GameplayMenuInterface>.Instance.SetSelected(CS$<>8__locals1.screen);
			this.screenChangeRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SetScreen>g__ScreenChange|0());
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x0011EC98 File Offset: 0x0011CE98
		public void SetIsOpen(bool open)
		{
			this.IsOpen = open;
			if (open)
			{
				this.OverlayLight.enabled = true;
			}
			if (this.CurrentScreen == GameplayMenu.EGameplayScreen.Phone)
			{
				if (open)
				{
					PlayerSingleton<Phone>.Instance.SetIsOpen(true);
				}
				else
				{
					PlayerSingleton<Phone>.Instance.SetIsOpen(false);
				}
			}
			else if (this.CurrentScreen == GameplayMenu.EGameplayScreen.Character)
			{
				if (open)
				{
					Singleton<CharacterDisplay>.Instance.SetOpen(true);
				}
				else
				{
					Singleton<CharacterDisplay>.Instance.SetOpen(false);
				}
			}
			if (this.IsOpen)
			{
				PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
				PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
				PlayerSingleton<PlayerMovement>.Instance.canMove = false;
				Singleton<ItemUIManager>.Instance.SetDraggingEnabled(true, false);
				Singleton<CompassManager>.Instance.SetVisible(false);
				Player.Local.SendEquippable_Networked("Avatar/Equippables/Phone_Lowered");
				Singleton<InputPromptsCanvas>.Instance.LoadModule("phone");
				Singleton<GameplayMenuInterface>.Instance.Open();
			}
			else
			{
				PlayerSingleton<PlayerCamera>.Instance.LockMouse();
				if (Player.Local.CurrentVehicle == null)
				{
					PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
					PlayerSingleton<PlayerMovement>.Instance.canMove = true;
					PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
				}
				else
				{
					Singleton<HUD>.Instance.SetCrosshairVisible(false);
				}
				Singleton<ItemUIManager>.Instance.SetDraggingEnabled(false, true);
				Singleton<CompassManager>.Instance.SetVisible(true);
				Player.Local.SendEquippable_Networked(string.Empty);
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
				Singleton<GameplayMenuInterface>.Instance.Close();
			}
			if (this.openCloseRoutine != null)
			{
				base.StopCoroutine(this.openCloseRoutine);
			}
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			if (this.IsOpen)
			{
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			}
			this.openCloseRoutine = base.StartCoroutine(this.<SetIsOpen>g__SetIsOpenRoutine|24_0(open));
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x0011EE61 File Offset: 0x0011D061
		[CompilerGenerated]
		private void <Update>g__PrepAppOpen|22_0()
		{
			if (!this.IsOpen)
			{
				this.SetIsOpen(true);
			}
			if (this.CurrentScreen != GameplayMenu.EGameplayScreen.Phone)
			{
				this.SetScreen(GameplayMenu.EGameplayScreen.Phone);
			}
			if (Phone.ActiveApp != null)
			{
				PlayerSingleton<Phone>.Instance.RequestCloseApp();
			}
		}

		// Token: 0x06004469 RID: 17513 RVA: 0x0011EE98 File Offset: 0x0011D098
		[CompilerGenerated]
		private IEnumerator <SetIsOpen>g__SetIsOpenRoutine|24_0(bool open)
		{
			if (open)
			{
				this.OverlayCamera.enabled = true;
			}
			float num = 1f - base.transform.localPosition.y / -2f;
			float adjustedLerpTime = 0.06f;
			float startVert = base.transform.localPosition.y;
			float endVert = 0f;
			if (open)
			{
				adjustedLerpTime *= 1f - num;
				endVert = 0.02f;
			}
			else
			{
				adjustedLerpTime *= num;
				endVert = -2f;
			}
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(open, adjustedLerpTime);
			for (float i = 0f; i < adjustedLerpTime; i += Time.deltaTime)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, Mathf.Lerp(startVert, endVert, i / adjustedLerpTime), base.transform.localPosition.z);
				yield return new WaitForEndOfFrame();
			}
			base.transform.localPosition = new Vector3(base.transform.localPosition.x, endVert, base.transform.localPosition.z);
			if (!open)
			{
				this.OverlayCamera.enabled = false;
				this.OverlayLight.enabled = false;
			}
			this.openCloseRoutine = null;
			yield break;
		}

		// Token: 0x040031D5 RID: 12757
		public const float OpenVerticalOffset = 0.02f;

		// Token: 0x040031D6 RID: 12758
		public const float ClosedVerticalOffset = -2f;

		// Token: 0x040031D7 RID: 12759
		public const float OpenTime = 0.06f;

		// Token: 0x040031D8 RID: 12760
		public const float SlideTime = 0.12f;

		// Token: 0x040031DB RID: 12763
		[Header("References")]
		public Camera OverlayCamera;

		// Token: 0x040031DC RID: 12764
		public Light OverlayLight;

		// Token: 0x040031DD RID: 12765
		[Header("Settings")]
		public float ContainerOffset_PhoneScreen = -0.1f;

		// Token: 0x040031DE RID: 12766
		private Coroutine openCloseRoutine;

		// Token: 0x040031DF RID: 12767
		private Coroutine screenChangeRoutine;

		// Token: 0x020009E6 RID: 2534
		public enum EGameplayScreen
		{
			// Token: 0x040031E1 RID: 12769
			Phone,
			// Token: 0x040031E2 RID: 12770
			Character
		}
	}
}
