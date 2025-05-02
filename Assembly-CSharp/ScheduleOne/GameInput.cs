using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace ScheduleOne
{
	// Token: 0x0200026B RID: 619
	public class GameInput : PersistentSingleton<GameInput>
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000396C4 File Offset: 0x000378C4
		public static Vector2 MouseDelta
		{
			get
			{
				return new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000396DF File Offset: 0x000378DF
		public static Vector3 MousePosition
		{
			get
			{
				return Input.mousePosition;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x000396E6 File Offset: 0x000378E6
		public static float MouseScrollDelta
		{
			get
			{
				return Input.GetAxis("Mouse ScrollWheel");
			}
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000396F2 File Offset: 0x000378F2
		protected override void Awake()
		{
			base.Awake();
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000396FC File Offset: 0x000378FC
		protected override void Start()
		{
			base.Start();
			if (Singleton<GameInput>.Instance == null || Singleton<GameInput>.Instance != this)
			{
				return;
			}
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(delegate()
			{
				GameInput.exitListeners.Clear();
			}));
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00039758 File Offset: 0x00037958
		private void OnApplicationFocus(bool focus)
		{
			if (!focus)
			{
				foreach (GameInput.ButtonCode item in this.buttonsDown)
				{
					this.buttonsUpThisFrame.Add(item);
				}
				this.buttonsDown.Clear();
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000397C0 File Offset: 0x000379C0
		public static bool GetButton(GameInput.ButtonCode buttonCode)
		{
			return Singleton<GameInput>.Instance.buttonsDown.Contains(buttonCode);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x000397D2 File Offset: 0x000379D2
		public static bool GetButtonDown(GameInput.ButtonCode buttonCode)
		{
			return Singleton<GameInput>.Instance.buttonsDownThisFrame.Contains(buttonCode);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000397E4 File Offset: 0x000379E4
		public static bool GetButtonUp(GameInput.ButtonCode buttonCode)
		{
			return Singleton<GameInput>.Instance.buttonsUpThisFrame.Contains(buttonCode);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x000397F8 File Offset: 0x000379F8
		protected virtual void Update()
		{
			if (!Singleton<GameInput>.InstanceExists)
			{
				return;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Escape) || GameInput.GetButtonDown(GameInput.ButtonCode.Back))
			{
				this.Exit(GameInput.GetButtonDown(GameInput.ButtonCode.Escape) ? ExitType.Escape : ExitType.RightClick);
			}
			if (GameInput.GetButton(GameInput.ButtonCode.PrimaryClick) && !Input.GetMouseButton(0))
			{
				Console.LogWarning("Mouse button (0) sticking detected!", null);
				this.OnPrimaryClick();
			}
			if (GameInput.GetButton(GameInput.ButtonCode.SecondaryClick) && !Input.GetMouseButton(1))
			{
				Console.LogWarning("Mouse button (1) sticking detected!", null);
				this.OnSecondaryClick();
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00039874 File Offset: 0x00037A74
		private void Exit(ExitType type)
		{
			ExitAction exitAction = new ExitAction();
			exitAction.exitType = type;
			for (int i = 0; i < GameInput.exitListeners.Count; i++)
			{
				GameInput.exitListeners[GameInput.exitListeners.Count - (1 + i)].listenerFunction(exitAction);
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000398C6 File Offset: 0x00037AC6
		private void LateUpdate()
		{
			this.buttonsDownThisFrame.Clear();
			this.buttonsUpThisFrame.Clear();
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000398E0 File Offset: 0x00037AE0
		public void ExitAll()
		{
			int num = 20;
			while (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount > 0)
			{
				num--;
				if (num <= 0)
				{
					Console.LogError("Failed to exit from all active UI elements.", null);
					for (int i = 0; i < PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount; i++)
					{
						Debug.LogError(PlayerSingleton<PlayerCamera>.Instance.activeUIElements[i]);
					}
					return;
				}
				this.Exit(ExitType.Escape);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00039944 File Offset: 0x00037B44
		private void OnMotion(InputValue value)
		{
			GameInput.MotionAxis = value.Get<Vector2>();
			if (GameInput.MotionAxis.x > 0f)
			{
				if (!this.buttonsDown.Contains(GameInput.ButtonCode.Right))
				{
					this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Right);
					this.buttonsDown.Add(GameInput.ButtonCode.Right);
				}
			}
			else if (this.buttonsDown.Contains(GameInput.ButtonCode.Right))
			{
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Right);
				this.buttonsDown.Remove(GameInput.ButtonCode.Right);
			}
			if (GameInput.MotionAxis.x < 0f)
			{
				if (!this.buttonsDown.Contains(GameInput.ButtonCode.Left))
				{
					this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Left);
					this.buttonsDown.Add(GameInput.ButtonCode.Left);
				}
			}
			else if (this.buttonsDown.Contains(GameInput.ButtonCode.Left))
			{
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Left);
				this.buttonsDown.Remove(GameInput.ButtonCode.Left);
			}
			if (GameInput.MotionAxis.y > 0f)
			{
				if (!this.buttonsDown.Contains(GameInput.ButtonCode.Forward))
				{
					this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Forward);
					this.buttonsDown.Add(GameInput.ButtonCode.Forward);
				}
			}
			else if (this.buttonsDown.Contains(GameInput.ButtonCode.Forward))
			{
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Forward);
				this.buttonsDown.Remove(GameInput.ButtonCode.Forward);
			}
			if (GameInput.MotionAxis.y < 0f)
			{
				if (!this.buttonsDown.Contains(GameInput.ButtonCode.Backward))
				{
					this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Backward);
					this.buttonsDown.Add(GameInput.ButtonCode.Backward);
					return;
				}
			}
			else if (this.buttonsDown.Contains(GameInput.ButtonCode.Backward))
			{
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Backward);
				this.buttonsDown.Remove(GameInput.ButtonCode.Backward);
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00039ADC File Offset: 0x00037CDC
		private void OnPrimaryClick()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.PrimaryClick))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.PrimaryClick);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.PrimaryClick);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.PrimaryClick);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.PrimaryClick);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00039B2C File Offset: 0x00037D2C
		private void OnSecondaryClick()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.SecondaryClick))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.SecondaryClick);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.SecondaryClick);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.SecondaryClick);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.SecondaryClick);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00039B7C File Offset: 0x00037D7C
		private void OnTertiaryClick()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.TertiaryClick))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.TertiaryClick);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.TertiaryClick);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.TertiaryClick);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.TertiaryClick);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00039BCC File Offset: 0x00037DCC
		private void OnJump()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.Jump))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.Jump);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Jump);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.Jump);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Jump);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00039C1C File Offset: 0x00037E1C
		private void OnCrouch()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.Crouch))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.Crouch);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Crouch);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.Crouch);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Crouch);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00039C6C File Offset: 0x00037E6C
		private void OnSprint()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.Sprint))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.Sprint);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Sprint);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.Sprint);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Sprint);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00039CC0 File Offset: 0x00037EC0
		private void OnEscape()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.Escape))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.Escape);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Escape);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.Escape);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Escape);
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00039D14 File Offset: 0x00037F14
		private void OnBack()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.Back))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.Back);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Back);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.Back);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Back);
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00039D68 File Offset: 0x00037F68
		private void OnInteract()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.Interact))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.Interact);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Interact);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.Interact);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Interact);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00039DBC File Offset: 0x00037FBC
		private void OnSubmit()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.Submit))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.Submit);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Submit);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.Submit);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Submit);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00039E10 File Offset: 0x00038010
		private void OnTogglePhone()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.TogglePhone))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.TogglePhone);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.TogglePhone);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.TogglePhone);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.TogglePhone);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00039E64 File Offset: 0x00038064
		private void OnToggleLights()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.ToggleLights))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.ToggleLights);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.ToggleLights);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.ToggleLights);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.ToggleLights);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00039EB8 File Offset: 0x000380B8
		private void OnHandbrake()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.Handbrake))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.Handbrake);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Handbrake);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.Handbrake);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Handbrake);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00039F0C File Offset: 0x0003810C
		private void OnRotateLeft()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.RotateLeft))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.RotateLeft);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.RotateLeft);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.RotateLeft);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.RotateLeft);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00039F60 File Offset: 0x00038160
		private void OnRotateRight()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.RotateRight))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.RotateRight);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.RotateRight);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.RotateRight);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.RotateRight);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00039FB4 File Offset: 0x000381B4
		private void OnManagementMode()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.ManagementMode))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.ManagementMode);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.ManagementMode);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.ManagementMode);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.ManagementMode);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0003A008 File Offset: 0x00038208
		private void OnOpenMap()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.OpenMap))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.OpenMap);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.OpenMap);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.OpenMap);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.OpenMap);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0003A05C File Offset: 0x0003825C
		private void OnOpenJournal()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.OpenJournal))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.OpenJournal);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.OpenJournal);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.OpenJournal);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.OpenJournal);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0003A0B0 File Offset: 0x000382B0
		private void OnOpenTexts()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.OpenTexts))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.OpenTexts);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.OpenTexts);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.OpenTexts);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.OpenTexts);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0003A104 File Offset: 0x00038304
		private void OnQuickMove()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.QuickMove))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.QuickMove);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.QuickMove);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.QuickMove);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.QuickMove);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0003A158 File Offset: 0x00038358
		private void OnToggleFlashlight()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.ToggleFlashlight))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.ToggleFlashlight);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.ToggleFlashlight);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.ToggleFlashlight);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.ToggleFlashlight);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0003A1AC File Offset: 0x000383AC
		private void OnViewAvatar()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.ViewAvatar))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.ViewAvatar);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.ViewAvatar);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.ViewAvatar);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.ViewAvatar);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0003A200 File Offset: 0x00038400
		private void OnReload()
		{
			if (this.buttonsDown.Contains(GameInput.ButtonCode.Reload))
			{
				this.buttonsDown.Remove(GameInput.ButtonCode.Reload);
				this.buttonsUpThisFrame.Add(GameInput.ButtonCode.Reload);
				return;
			}
			this.buttonsDown.Add(GameInput.ButtonCode.Reload);
			this.buttonsDownThisFrame.Add(GameInput.ButtonCode.Reload);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0003A254 File Offset: 0x00038454
		public static void RegisterExitListener(GameInput.ExitDelegate listener, int priority = 0)
		{
			GameInput.ExitListener exitListener = new GameInput.ExitListener();
			exitListener.listenerFunction = listener;
			exitListener.priority = priority;
			for (int i = 0; i < GameInput.exitListeners.Count; i++)
			{
				if (priority <= GameInput.exitListeners[i].priority)
				{
					GameInput.exitListeners.Insert(i, exitListener);
					return;
				}
			}
			GameInput.exitListeners.Add(exitListener);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0003A2B8 File Offset: 0x000384B8
		public static void DeregisterExitListener(GameInput.ExitDelegate listener)
		{
			for (int i = 0; i < GameInput.exitListeners.Count; i++)
			{
				if (GameInput.exitListeners[i].listenerFunction == listener)
				{
					GameInput.exitListeners.RemoveAt(i);
					i--;
				}
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0003A301 File Offset: 0x00038501
		public InputAction GetAction(GameInput.ButtonCode code)
		{
			return this.PlayerInput.currentActionMap.FindAction(code.ToString(), false);
		}

		// Token: 0x04000D6B RID: 3435
		public static List<GameInput.ExitListener> exitListeners = new List<GameInput.ExitListener>();

		// Token: 0x04000D6C RID: 3436
		public PlayerInput PlayerInput;

		// Token: 0x04000D6D RID: 3437
		public static bool IsTyping = false;

		// Token: 0x04000D6E RID: 3438
		public static Vector2 MotionAxis = Vector2.zero;

		// Token: 0x04000D6F RID: 3439
		private List<GameInput.ButtonCode> buttonsDownThisFrame = new List<GameInput.ButtonCode>();

		// Token: 0x04000D70 RID: 3440
		private List<GameInput.ButtonCode> buttonsDown = new List<GameInput.ButtonCode>();

		// Token: 0x04000D71 RID: 3441
		private List<GameInput.ButtonCode> buttonsUpThisFrame = new List<GameInput.ButtonCode>();

		// Token: 0x0200026C RID: 620
		public enum ButtonCode
		{
			// Token: 0x04000D73 RID: 3443
			PrimaryClick,
			// Token: 0x04000D74 RID: 3444
			SecondaryClick,
			// Token: 0x04000D75 RID: 3445
			TertiaryClick,
			// Token: 0x04000D76 RID: 3446
			Forward,
			// Token: 0x04000D77 RID: 3447
			Backward,
			// Token: 0x04000D78 RID: 3448
			Left,
			// Token: 0x04000D79 RID: 3449
			Right,
			// Token: 0x04000D7A RID: 3450
			Jump,
			// Token: 0x04000D7B RID: 3451
			Crouch,
			// Token: 0x04000D7C RID: 3452
			Sprint,
			// Token: 0x04000D7D RID: 3453
			Escape,
			// Token: 0x04000D7E RID: 3454
			Back,
			// Token: 0x04000D7F RID: 3455
			Interact,
			// Token: 0x04000D80 RID: 3456
			Submit,
			// Token: 0x04000D81 RID: 3457
			TogglePhone,
			// Token: 0x04000D82 RID: 3458
			ToggleLights,
			// Token: 0x04000D83 RID: 3459
			Handbrake,
			// Token: 0x04000D84 RID: 3460
			RotateLeft,
			// Token: 0x04000D85 RID: 3461
			RotateRight,
			// Token: 0x04000D86 RID: 3462
			ManagementMode,
			// Token: 0x04000D87 RID: 3463
			OpenMap,
			// Token: 0x04000D88 RID: 3464
			OpenJournal,
			// Token: 0x04000D89 RID: 3465
			OpenTexts,
			// Token: 0x04000D8A RID: 3466
			QuickMove,
			// Token: 0x04000D8B RID: 3467
			ToggleFlashlight,
			// Token: 0x04000D8C RID: 3468
			ViewAvatar,
			// Token: 0x04000D8D RID: 3469
			Reload
		}

		// Token: 0x0200026D RID: 621
		public class ExitListener
		{
			// Token: 0x04000D8E RID: 3470
			public GameInput.ExitDelegate listenerFunction;

			// Token: 0x04000D8F RID: 3471
			public int priority;
		}

		// Token: 0x0200026E RID: 622
		// (Invoke) Token: 0x06000D10 RID: 3344
		public delegate void ExitDelegate(ExitAction exitAction);
	}
}
