using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.Networking;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000713 RID: 1811
	public class Settings : PersistentSingleton<Settings>
	{
		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060030E2 RID: 12514 RVA: 0x000CB383 File Offset: 0x000C9583
		// (set) Token: 0x060030E3 RID: 12515 RVA: 0x000CB38B File Offset: 0x000C958B
		public Settings.UnitType unitType { get; protected set; }

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060030E4 RID: 12516 RVA: 0x000CB394 File Offset: 0x000C9594
		public bool PausingFreezesTime
		{
			get
			{
				return Player.PlayerList.Count <= 1 && !Singleton<Lobby>.Instance.IsInLobby;
			}
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x000CB3B4 File Offset: 0x000C95B4
		protected override void Awake()
		{
			base.Awake();
			if (Singleton<Settings>.Instance == null || Singleton<Settings>.Instance != this)
			{
				return;
			}
			this.playerControls = this.InputActions.FindActionMap("Generic", false);
			this.DisplaySettings = this.ReadDisplaySettings();
			this.UnappliedDisplaySettings = this.ReadDisplaySettings();
			this.GraphicsSettings = this.ReadGraphicsSettings();
			this.AudioSettings = this.ReadAudioSettings();
			this.InputSettings = this.ReadInputSettings();
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			for (int i = 0; i < commandLineArgs.Length; i++)
			{
				if (commandLineArgs[i] == "-beta")
				{
					GameManager.IS_BETA = true;
				}
			}
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x000CB45E File Offset: 0x000C965E
		protected override void Start()
		{
			base.Start();
			this.ApplyDisplaySettings(this.DisplaySettings);
			this.ApplyGraphicsSettings(this.GraphicsSettings);
			this.ApplyAudioSettings(this.AudioSettings);
			this.ApplyInputSettings(this.InputSettings);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000CB498 File Offset: 0x000C9698
		public void ApplyDisplaySettings(DisplaySettings settings)
		{
			Resolution[] array = DisplaySettings.GetResolutions().ToArray();
			Resolution resolution = array[Mathf.Clamp(settings.ResolutionIndex, 0, array.Length - 1)];
			FullScreenMode fullScreenMode = FullScreenMode.Windowed;
			switch (settings.DisplayMode)
			{
			case DisplaySettings.EDisplayMode.Windowed:
				fullScreenMode = FullScreenMode.Windowed;
				break;
			case DisplaySettings.EDisplayMode.FullscreenWindow:
				fullScreenMode = FullScreenMode.FullScreenWindow;
				break;
			case DisplaySettings.EDisplayMode.ExclusiveFullscreen:
				fullScreenMode = FullScreenMode.ExclusiveFullScreen;
				break;
			}
			Screen.fullScreenMode = fullScreenMode;
			Screen.SetResolution(resolution.width, resolution.height, settings.DisplayMode == DisplaySettings.EDisplayMode.ExclusiveFullscreen || settings.DisplayMode == DisplaySettings.EDisplayMode.FullscreenWindow);
			QualitySettings.vSyncCount = (settings.VSync ? 1 : 0);
			Application.targetFrameRate = settings.TargetFPS;
			List<DisplayInfo> list = new List<DisplayInfo>();
			Screen.GetDisplayLayout(list);
			DisplayInfo displayInfo = list[Mathf.Clamp(settings.ActiveDisplayIndex, 0, list.Count - 1)];
			this.MoveMainWindowTo(displayInfo);
			CanvasScaler.SetScaleFactor(settings.UIScale);
			Singleton<Settings>.Instance.CameraBobIntensity = settings.CameraBobbing;
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x000CB586 File Offset: 0x000C9786
		private void MoveMainWindowTo(DisplayInfo displayInfo)
		{
			Console.Log("Moving main window to display: " + displayInfo.name, null);
			Screen.MoveMainWindowTo(ref displayInfo, new Vector2Int(displayInfo.width / 2, displayInfo.height / 2));
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x000CB5BB File Offset: 0x000C97BB
		public void ReloadGraphicsSettings()
		{
			this.ApplyGraphicsSettings(this.GraphicsSettings);
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000CB5CC File Offset: 0x000C97CC
		public void ApplyGraphicsSettings(GraphicsSettings settings)
		{
			QualitySettings.SetQualityLevel((int)settings.GraphicsQuality);
			PlayerCamera.SetAntialiasingMode(settings.AntiAliasingMode);
			this.CameraFOV = settings.FOV;
			this.SSAO.SetActive(settings.SSAO);
			this.GodRays.SetActive(settings.GodRays);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000CB61D File Offset: 0x000C981D
		public void ReloadAudioSettings()
		{
			this.ApplyAudioSettings(this.AudioSettings);
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000CB62C File Offset: 0x000C982C
		public void ApplyAudioSettings(AudioSettings settings)
		{
			Singleton<AudioManager>.Instance.SetMasterVolume(settings.MasterVolume);
			Singleton<AudioManager>.Instance.SetVolume(EAudioType.Ambient, settings.AmbientVolume);
			Singleton<AudioManager>.Instance.SetVolume(EAudioType.Music, settings.MusicVolume);
			Singleton<AudioManager>.Instance.SetVolume(EAudioType.FX, settings.SFXVolume);
			Singleton<AudioManager>.Instance.SetVolume(EAudioType.UI, settings.UIVolume);
			Singleton<AudioManager>.Instance.SetVolume(EAudioType.Voice, settings.DialogueVolume);
			Singleton<AudioManager>.Instance.SetVolume(EAudioType.Footsteps, settings.FootstepsVolume);
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x000CB6AF File Offset: 0x000C98AF
		public void ReloadInputSettings()
		{
			this.ApplyInputSettings(this.InputSettings);
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x000CB6C0 File Offset: 0x000C98C0
		public void ApplyInputSettings(InputSettings settings)
		{
			this.InputSettings = settings;
			this.LookSensitivity = settings.MouseSensitivity;
			this.InvertMouse = settings.InvertMouse;
			this.SprintMode = settings.SprintMode;
			this.InputActions.Disable();
			InputActionRebindingExtensions.LoadBindingOverridesFromJson(this.InputActions, settings.BindingOverrides, true);
			this.InputActions.Enable();
			this.GameInput.PlayerInput.actions = this.InputActions;
			Action action = this.onInputsApplied;
			if (action == null)
			{
				return;
			}
			action();
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x000CB748 File Offset: 0x000C9948
		public void WriteDisplaySettings(DisplaySettings settings)
		{
			this.DisplaySettings = settings;
			this.UnappliedDisplaySettings = settings;
			PlayerPrefs.SetInt("ResolutionIndex", settings.ResolutionIndex);
			PlayerPrefs.SetInt("DisplayMode", (int)settings.DisplayMode);
			PlayerPrefs.SetInt("VSync", settings.VSync ? 1 : 0);
			PlayerPrefs.SetInt("TargetFPS", settings.TargetFPS);
			PlayerPrefs.SetFloat("UIScale", settings.UIScale);
			PlayerPrefs.SetFloat("CameraBobbing", settings.CameraBobbing);
			PlayerPrefs.SetInt("ActiveDisplayIndex", settings.ActiveDisplayIndex);
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x000CB7DC File Offset: 0x000C99DC
		public DisplaySettings ReadDisplaySettings()
		{
			return new DisplaySettings
			{
				ResolutionIndex = PlayerPrefs.GetInt("ResolutionIndex", Screen.resolutions.Length - 1),
				DisplayMode = (DisplaySettings.EDisplayMode)PlayerPrefs.GetInt("DisplayMode", 2),
				VSync = (PlayerPrefs.GetInt("VSync", 1) == 1),
				TargetFPS = PlayerPrefs.GetInt("TargetFPS", 90),
				UIScale = PlayerPrefs.GetFloat("UIScale", 1f),
				CameraBobbing = PlayerPrefs.GetFloat("CameraBobbing", 0.7f),
				ActiveDisplayIndex = PlayerPrefs.GetInt("ActiveDisplayIndex", 0)
			};
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x000CB884 File Offset: 0x000C9A84
		public void WriteGraphicsSettings(GraphicsSettings settings)
		{
			this.GraphicsSettings = settings;
			PlayerPrefs.SetInt("QualityLevel", (int)settings.GraphicsQuality);
			PlayerPrefs.SetInt("AntiAliasing", (int)settings.AntiAliasingMode);
			PlayerPrefs.SetFloat("FOV", settings.FOV);
			PlayerPrefs.SetInt("SSAO", settings.SSAO ? 1 : 0);
			PlayerPrefs.SetInt("GodRays", settings.GodRays ? 1 : 0);
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x000CB8F4 File Offset: 0x000C9AF4
		public GraphicsSettings ReadGraphicsSettings()
		{
			return new GraphicsSettings
			{
				GraphicsQuality = (GraphicsSettings.EGraphicsQuality)PlayerPrefs.GetInt("QualityLevel", 2),
				AntiAliasingMode = (GraphicsSettings.EAntiAliasingMode)PlayerPrefs.GetInt("AntiAliasing", 2),
				FOV = PlayerPrefs.GetFloat("FOV", 80f),
				SSAO = (PlayerPrefs.GetInt("SSAO", 1) == 1),
				GodRays = (PlayerPrefs.GetInt("GodRays", 1) == 1)
			};
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x000CB968 File Offset: 0x000C9B68
		public void WriteAudioSettings(AudioSettings settings)
		{
			this.AudioSettings = settings;
			PlayerPrefs.SetFloat("MasterVolume", settings.MasterVolume);
			PlayerPrefs.SetFloat("AmbientVolume", settings.AmbientVolume);
			PlayerPrefs.SetFloat("MusicVolume", settings.MusicVolume);
			PlayerPrefs.SetFloat("SFXVolume", settings.SFXVolume);
			PlayerPrefs.SetFloat("UIVolume", settings.UIVolume);
			PlayerPrefs.SetFloat("DialogueVolume", settings.DialogueVolume);
			PlayerPrefs.SetFloat("FootstepsVolume", settings.FootstepsVolume);
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x000CB9EC File Offset: 0x000C9BEC
		public AudioSettings ReadAudioSettings()
		{
			return new AudioSettings
			{
				MasterVolume = PlayerPrefs.GetFloat("MasterVolume", 1f),
				AmbientVolume = PlayerPrefs.GetFloat("AmbientVolume", 1f),
				MusicVolume = PlayerPrefs.GetFloat("MusicVolume", 1f),
				SFXVolume = PlayerPrefs.GetFloat("SFXVolume", 1f),
				UIVolume = PlayerPrefs.GetFloat("UIVolume", 1f),
				DialogueVolume = PlayerPrefs.GetFloat("DialogueVolume", 1f),
				FootstepsVolume = PlayerPrefs.GetFloat("FootstepsVolume", 1f)
			};
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x000CBA94 File Offset: 0x000C9C94
		public void WriteInputSettings(InputSettings settings)
		{
			this.InputSettings = settings;
			PlayerPrefs.SetFloat("MouseSensitivity", settings.MouseSensitivity);
			PlayerPrefs.SetInt("InvertMouse", settings.InvertMouse ? 1 : 0);
			PlayerPrefs.SetInt("SprintMode", (int)settings.SprintMode);
			string value = InputActionRebindingExtensions.SaveBindingOverridesAsJson(this.GameInput.PlayerInput.actions);
			PlayerPrefs.SetString("BindingOverrides", value);
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x000CBB00 File Offset: 0x000C9D00
		public InputSettings ReadInputSettings()
		{
			return new InputSettings
			{
				MouseSensitivity = PlayerPrefs.GetFloat("MouseSensitivity", 1f),
				InvertMouse = (PlayerPrefs.GetInt("InvertMouse", 0) == 1),
				SprintMode = (InputSettings.EActionMode)PlayerPrefs.GetInt("SprintMode", 0),
				BindingOverrides = PlayerPrefs.GetString("BindingOverrides", InputActionRebindingExtensions.SaveBindingOverridesAsJson(this.GameInput.PlayerInput.actions))
			};
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x000CBB74 File Offset: 0x000C9D74
		public string GetActionControlPath(string actionName)
		{
			InputAction inputAction = this.playerControls.FindAction(actionName, false);
			if (inputAction == null)
			{
				Console.LogError("Could not find action with name '" + actionName + "'", null);
				return string.Empty;
			}
			return inputAction.controls[0].path;
		}

		// Token: 0x040022DE RID: 8926
		public const float MinYPos = -20f;

		// Token: 0x040022E0 RID: 8928
		public DisplaySettings DisplaySettings;

		// Token: 0x040022E1 RID: 8929
		public DisplaySettings UnappliedDisplaySettings;

		// Token: 0x040022E2 RID: 8930
		public GraphicsSettings GraphicsSettings = new GraphicsSettings();

		// Token: 0x040022E3 RID: 8931
		public AudioSettings AudioSettings = new AudioSettings();

		// Token: 0x040022E4 RID: 8932
		public InputSettings InputSettings = new InputSettings();

		// Token: 0x040022E5 RID: 8933
		public InputActionAsset InputActions;

		// Token: 0x040022E6 RID: 8934
		public GameInput GameInput;

		// Token: 0x040022E7 RID: 8935
		public ScriptableRendererFeature SSAO;

		// Token: 0x040022E8 RID: 8936
		public ScriptableRendererFeature GodRays;

		// Token: 0x040022E9 RID: 8937
		[Header("Camera")]
		public float LookSensitivity = 1f;

		// Token: 0x040022EA RID: 8938
		public bool InvertMouse;

		// Token: 0x040022EB RID: 8939
		public float CameraFOV = 75f;

		// Token: 0x040022EC RID: 8940
		public InputSettings.EActionMode SprintMode = InputSettings.EActionMode.Hold;

		// Token: 0x040022ED RID: 8941
		[Range(0f, 1f)]
		public float CameraBobIntensity = 1f;

		// Token: 0x040022EE RID: 8942
		private InputActionMap playerControls;

		// Token: 0x040022EF RID: 8943
		public Action onDisplayChanged;

		// Token: 0x040022F0 RID: 8944
		public Action onInputsApplied;

		// Token: 0x02000714 RID: 1812
		public enum UnitType
		{
			// Token: 0x040022F2 RID: 8946
			Metric,
			// Token: 0x040022F3 RID: 8947
			Imperial
		}
	}
}
