using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using Steamworks;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x020009D7 RID: 2519
	public class DemoEndScreen : MonoBehaviour
	{
		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x0011CE77 File Offset: 0x0011B077
		// (set) Token: 0x060043F9 RID: 17401 RVA: 0x0011CE7F File Offset: 0x0011B07F
		public bool IsOpen { get; private set; }

		// Token: 0x060043FA RID: 17402 RVA: 0x0011CE88 File Offset: 0x0011B088
		public void Awake()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x0011CEB9 File Offset: 0x0011B0B9
		private void OnDestroy()
		{
			GameInput.DeregisterExitListener(new GameInput.ExitDelegate(this.Exit));
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x000045B1 File Offset: 0x000027B1
		[Button]
		public void Open()
		{
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x0011CECC File Offset: 0x0011B0CC
		private void Update()
		{
			if (this.IsOpen)
			{
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			}
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x0011CEE4 File Offset: 0x0011B0E4
		public void Close()
		{
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0.25f);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x0011CF75 File Offset: 0x0011B175
		private void Exit(ExitAction action)
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (action.used)
			{
				return;
			}
			if (action.exitType != ExitType.Escape)
			{
				return;
			}
			action.used = true;
			this.Close();
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x0011CFA0 File Offset: 0x0011B1A0
		public void LinkClicked()
		{
			if (SteamManager.Initialized)
			{
				SteamFriends.ActivateGameOverlayToStore(new AppId_t(3164500U), EOverlayToStoreFlag.k_EOverlayToStoreFlag_None);
			}
		}

		// Token: 0x0400317F RID: 12671
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003180 RID: 12672
		public RectTransform Container;
	}
}
