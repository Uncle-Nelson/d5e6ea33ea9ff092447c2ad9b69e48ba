using System;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.MainMenu;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000A12 RID: 2578
	public class PauseMenu : Singleton<PauseMenu>
	{
		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x00122C4A File Offset: 0x00120E4A
		// (set) Token: 0x0600456A RID: 17770 RVA: 0x00122C52 File Offset: 0x00120E52
		public bool IsPaused { get; protected set; }

		// Token: 0x0600456B RID: 17771 RVA: 0x00122C5B File Offset: 0x00120E5B
		protected override void Awake()
		{
			base.Awake();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), -100);
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x00122C76 File Offset: 0x00120E76
		protected override void Start()
		{
			base.Start();
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x00122C9B File Offset: 0x00120E9B
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (action.exitType == ExitType.RightClick)
			{
				return;
			}
			if (this.justResumed)
			{
				return;
			}
			if (GameInput.IsTyping)
			{
				return;
			}
			if (this.IsPaused)
			{
				this.Resume();
				return;
			}
			this.Pause();
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00122CD5 File Offset: 0x00120ED5
		private void Update()
		{
			bool instanceExists = PlayerSingleton<PlayerCamera>.InstanceExists;
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x00122CDD File Offset: 0x00120EDD
		private void LateUpdate()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			this.noActiveUIElements = (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount == 0);
			this.justPaused = false;
			this.justResumed = false;
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00122D08 File Offset: 0x00120F08
		public void Pause()
		{
			Console.Log("Game paused", null);
			this.IsPaused = true;
			this.justPaused = true;
			if (this.FeedbackForm != null)
			{
				this.FeedbackForm.PrepScreenshot();
			}
			if (Singleton<Settings>.InstanceExists && Singleton<Settings>.Instance.PausingFreezesTime)
			{
				Time.timeScale = 0f;
			}
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				this.couldLook = PlayerSingleton<PlayerCamera>.Instance.canLook;
				this.lockedMouse = (Cursor.lockState == CursorLockMode.Locked);
				this.crosshairVisible = Singleton<HUD>.Instance.crosshair.gameObject.activeSelf;
				this.hudVisible = Singleton<HUD>.Instance.canvas.enabled;
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
				PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
				PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0.075f);
				Singleton<HUD>.Instance.canvas.enabled = false;
			}
			this.Screen.Open(false);
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x00122E1C File Offset: 0x0012101C
		public void Resume()
		{
			Console.Log("Game resumed", null);
			this.IsPaused = false;
			this.justResumed = true;
			if (Singleton<Settings>.InstanceExists && Singleton<Settings>.Instance.PausingFreezesTime)
			{
				if (NetworkSingleton<TimeManager>.Instance.SleepInProgress)
				{
					Time.timeScale = 1f;
				}
				else
				{
					Time.timeScale = 1f;
				}
			}
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				if (this.couldLook)
				{
					PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
				}
				if (this.lockedMouse && (!Singleton<CharacterCreator>.InstanceExists || !Singleton<CharacterCreator>.Instance.IsOpen))
				{
					PlayerSingleton<PlayerCamera>.Instance.LockMouse();
				}
				PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0.075f);
			}
			if (Singleton<HUD>.InstanceExists)
			{
				Singleton<HUD>.Instance.SetCrosshairVisible(this.crosshairVisible);
				Singleton<HUD>.Instance.canvas.enabled = this.hudVisible;
			}
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			this.Screen.Close(false);
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00122F1B File Offset: 0x0012111B
		public void StuckButtonClicked()
		{
			this.Resume();
			PlayerSingleton<PlayerMovement>.Instance.WarpToNavMesh();
		}

		// Token: 0x040032F5 RID: 13045
		public Canvas Canvas;

		// Token: 0x040032F6 RID: 13046
		public RectTransform Container;

		// Token: 0x040032F7 RID: 13047
		public MainMenuScreen Screen;

		// Token: 0x040032F8 RID: 13048
		public FeedbackForm FeedbackForm;

		// Token: 0x040032F9 RID: 13049
		private bool noActiveUIElements = true;

		// Token: 0x040032FA RID: 13050
		private bool justPaused;

		// Token: 0x040032FB RID: 13051
		private bool justResumed;

		// Token: 0x040032FC RID: 13052
		private bool couldLook;

		// Token: 0x040032FD RID: 13053
		private bool lockedMouse;

		// Token: 0x040032FE RID: 13054
		private bool crosshairVisible;

		// Token: 0x040032FF RID: 13055
		private bool hudVisible;

		// Token: 0x04003300 RID: 13056
		public UnityEvent onPause;

		// Token: 0x04003301 RID: 13057
		public UnityEvent onResume;
	}
}
