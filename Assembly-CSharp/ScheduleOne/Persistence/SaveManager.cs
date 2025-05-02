using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Datas;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x0200037D RID: 893
	public class SaveManager : PersistentSingleton<SaveManager>
	{
		// Token: 0x06001439 RID: 5177 RVA: 0x0005A628 File Offset: 0x00058828
		public static void ReportSaveError()
		{
			SaveManager.SaveError = true;
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0005A630 File Offset: 0x00058830
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x0005A638 File Offset: 0x00058838
		public bool AccessPermissionIssueDetected { get; protected set; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0005A641 File Offset: 0x00058841
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x0005A649 File Offset: 0x00058849
		public bool IsSaving { get; protected set; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0005A652 File Offset: 0x00058852
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x0005A65A File Offset: 0x0005885A
		public float SecondsSinceLastSave { get; protected set; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0005A663 File Offset: 0x00058863
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x0005A66B File Offset: 0x0005886B
		public string PlayersSavePath { get; protected set; } = string.Empty;

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0005A674 File Offset: 0x00058874
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x0005A67C File Offset: 0x0005887C
		public string IndividualSavesContainerPath { get; protected set; } = string.Empty;

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0005A685 File Offset: 0x00058885
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x0005A68D File Offset: 0x0005888D
		public string SaveName { get; protected set; } = "DevSave";

		// Token: 0x06001446 RID: 5190 RVA: 0x0005A698 File Offset: 0x00058898
		protected override void Awake()
		{
			base.Awake();
			if (Singleton<SaveManager>.Instance == null || Singleton<SaveManager>.Instance != this)
			{
				return;
			}
			this.PlayersSavePath = Path.Combine(Application.persistentDataPath, "Saves");
			if (!Directory.Exists(this.PlayersSavePath))
			{
				Directory.CreateDirectory(this.PlayersSavePath);
			}
			if (Directory.GetDirectories(this.PlayersSavePath).Length == 0)
			{
				string path = Path.Combine(this.PlayersSavePath, "TempPlayer");
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
			}
			string[] directories = Directory.GetDirectories(this.PlayersSavePath);
			if (directories.Length > 1)
			{
				for (int i = 0; i < directories.Length; i++)
				{
					if (!directories[i].Contains("TempPlayer"))
					{
						this.IndividualSavesContainerPath = directories[i];
						return;
					}
				}
				return;
			}
			this.IndividualSavesContainerPath = directories[0];
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0005A765 File Offset: 0x00058965
		protected override void Start()
		{
			base.Start();
			Singleton<LoadManager>.Instance.onPreSceneChange.AddListener(new UnityAction(this.Clean));
			this.CheckSaveFolderInitialized();
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0005A790 File Offset: 0x00058990
		public void CheckSaveFolderInitialized()
		{
			if (this.saveFolderInitialized)
			{
				return;
			}
			this.saveFolderInitialized = true;
			if (SteamManager.Initialized)
			{
				string path = SteamUser.GetSteamID().ToString();
				string text = Path.Combine(this.PlayersSavePath, path);
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				this.IndividualSavesContainerPath = text;
				Console.Log("Initialized individual save folder path: " + this.IndividualSavesContainerPath, null);
			}
			else
			{
				Console.LogError("Steamworks not intialized in time for SaveManager! Using save container path: " + this.IndividualSavesContainerPath, null);
			}
			if (SaveManager.HasWritePermissionOnDir(this.IndividualSavesContainerPath))
			{
				this.AccessPermissionIssueDetected = false;
				Console.Log("Successfully verified write permission on save folder: " + this.IndividualSavesContainerPath, null);
				if (this.WriteIssueDisplay != null)
				{
					this.WriteIssueDisplay.gameObject.SetActive(false);
					return;
				}
			}
			else
			{
				this.AccessPermissionIssueDetected = true;
				Console.LogError("No write permission on save folder: " + this.IndividualSavesContainerPath, null);
				if (this.WriteIssueDisplay != null)
				{
					this.WriteIssueDisplay.gameObject.SetActive(true);
				}
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0005A8A0 File Offset: 0x00058AA0
		public static bool HasWritePermissionOnDir(string path)
		{
			bool result = false;
			string path2 = Path.Combine(path, "WriteTest.txt");
			if (Directory.Exists(path))
			{
				try
				{
					File.WriteAllText(path2, "If you're reading this, it means Schedule I can write save files properly - Yay!");
					if (File.Exists(path2))
					{
						result = true;
					}
				}
				catch (Exception)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0005A8F0 File Offset: 0x00058AF0
		private void Update()
		{
			if (Singleton<LoadManager>.Instance.IsGameLoaded && Singleton<LoadManager>.Instance.LoadedGameFolderPath != string.Empty && Input.GetKeyDown(KeyCode.F5) && (Application.isEditor || Debug.isDebugBuild))
			{
				this.Save();
			}
			if (Singleton<LoadManager>.Instance.IsGameLoaded)
			{
				this.SecondsSinceLastSave += Time.unscaledDeltaTime;
				return;
			}
			this.SecondsSinceLastSave = 0f;
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0005A969 File Offset: 0x00058B69
		public void DelayedSave()
		{
			base.Invoke("Save", 1f);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0005A97B File Offset: 0x00058B7B
		public void Save()
		{
			this.Save(Singleton<LoadManager>.Instance.LoadedGameFolderPath);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0005A990 File Offset: 0x00058B90
		public void Save(string saveFolderPath)
		{
			SaveManager.<>c__DisplayClass51_0 CS$<>8__locals1 = new SaveManager.<>c__DisplayClass51_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.saveFolderPath = saveFolderPath;
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (Singleton<LoadManager>.Instance.LoadedGameFolderPath == string.Empty)
			{
				Console.LogWarning("No game loaded to save", null);
				return;
			}
			if (this.IsSaving)
			{
				Console.LogWarning("Save called while saving is already in progress", null);
				return;
			}
			if (NetworkSingleton<GameManager>.Instance.IsTutorial && !Application.isEditor)
			{
				Console.LogWarning("Can't save during tutorial", null);
				return;
			}
			if (NetworkSingleton<GameManager>.Instance.IsTutorial)
			{
				CS$<>8__locals1.saveFolderPath = Path.Combine(Singleton<SaveManager>.Instance.IndividualSavesContainerPath, "DevSave");
			}
			Console.Log("Saving game to " + CS$<>8__locals1.saveFolderPath, null);
			this.IsSaving = true;
			if (this.onSaveStart != null)
			{
				this.onSaveStart.Invoke();
			}
			this.CompletedSaveables.Clear();
			this.ApprovedBaseLevelPaths.Clear();
			SaveManager.SaveError = false;
			base.StartCoroutine(CS$<>8__locals1.<Save>g__SaveRoutine|0());
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0005AA90 File Offset: 0x00058C90
		private void ClearBaseLevelOutdatedSaves(string saveFolderPath)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(saveFolderPath);
			}
			catch (Exception ex)
			{
				string str = "Failed to get files in folder: ";
				string str2 = "\nException: ";
				Exception ex2 = ex;
				Console.LogError(str + saveFolderPath + str2 + ((ex2 != null) ? ex2.ToString() : null), null);
				return;
			}
			try
			{
				array2 = Directory.GetDirectories(saveFolderPath);
			}
			catch (Exception ex3)
			{
				string str3 = "Failed to get folders in folder: ";
				string str4 = "\nException: ";
				Exception ex4 = ex3;
				Console.LogError(str3 + saveFolderPath + str4 + ((ex4 != null) ? ex4.ToString() : null), null);
				return;
			}
			if (array == null || array2 == null)
			{
				Console.LogError("Failed to get files or folders in folder: " + saveFolderPath, null);
				return;
			}
			foreach (string text in array)
			{
				FileInfo fileInfo = new FileInfo(text);
				if (!this.ApprovedBaseLevelPaths.Contains(fileInfo.Name))
				{
					try
					{
						Debug.Log("Deleting file: " + text);
						File.Delete(text);
					}
					catch (Exception ex5)
					{
						string str5 = "Failed to delete file: ";
						string str6 = text;
						string str7 = "\nException: ";
						Exception ex6 = ex5;
						Console.LogError(str5 + str6 + str7 + ((ex6 != null) ? ex6.ToString() : null), null);
					}
				}
			}
			foreach (string text2 in array2)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text2);
				if (!this.ApprovedBaseLevelPaths.Contains(directoryInfo.Name))
				{
					try
					{
						Debug.Log("Deleting folder: " + text2);
						Directory.Delete(text2, true);
					}
					catch (Exception ex7)
					{
						string str8 = "Failed to delete folder: ";
						string str9 = text2;
						string str10 = "\nException: ";
						Exception ex8 = ex7;
						Console.LogError(str8 + str9 + str10 + ((ex8 != null) ? ex8.ToString() : null), null);
					}
				}
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0005AC54 File Offset: 0x00058E54
		public void CompleteSaveable(ISaveable saveable)
		{
			if (this.CompletedSaveables.Contains(saveable))
			{
				Console.LogWarning("Saveable already completed", null);
				return;
			}
			this.CompletedSaveables.Add(saveable);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0005AC7C File Offset: 0x00058E7C
		public void ClearCompletedSaveable(ISaveable saveable)
		{
			this.CompletedSaveables.Remove(saveable);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0005AC8B File Offset: 0x00058E8B
		public void RegisterSaveable(ISaveable saveable)
		{
			if (this.Saveables.Contains(saveable))
			{
				return;
			}
			this.Saveables.Add(saveable);
			if (saveable is IBaseSaveable)
			{
				this.BaseSaveables.Add(saveable as IBaseSaveable);
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0005ACC1 File Offset: 0x00058EC1
		public void QueueSaveRequest(SaveRequest request)
		{
			this.QueuedSaveRequests.Add(request);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0005ACCF File Offset: 0x00058ECF
		public void DequeueSaveRequest(SaveRequest request)
		{
			this.QueuedSaveRequests.Remove(request);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0005ACDE File Offset: 0x00058EDE
		public static string StripExtensions(string filePath)
		{
			return filePath.Replace(".json", string.Empty);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0005ACF0 File Offset: 0x00058EF0
		public static string MakeFileSafe(string fileName)
		{
			foreach (char oldChar in Path.GetInvalidFileNameChars())
			{
				fileName = fileName.Replace(oldChar, '-');
			}
			return fileName;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0005AD24 File Offset: 0x00058F24
		public static float GetVersionNumber(string version)
		{
			version.ToLower().Contains("alternate");
			version = version.Replace(".", string.Empty);
			version = version.Replace("f", ".");
			version = Regex.Replace(version, "[^\\d.]", string.Empty);
			version = version.TrimStart('0');
			float result;
			if (!float.TryParse(version, out result))
			{
				Console.LogError("Failed to parse version number: " + version, null);
				return 0f;
			}
			return result;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0005ADA4 File Offset: 0x00058FA4
		private void Clean()
		{
			this.Saveables.Clear();
			this.BaseSaveables.Clear();
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0005ADBC File Offset: 0x00058FBC
		public void DisablePlayTutorial(SaveInfo info)
		{
			string path = Path.Combine(info.SavePath, "Metadata.json");
			if (File.Exists(path))
			{
				string text = string.Empty;
				try
				{
					text = File.ReadAllText(path);
				}
				catch (Exception ex)
				{
					Console.LogError("Error reading save metadata: " + ex.Message, null);
					return;
				}
				MetaData metaData = JsonUtility.FromJson<MetaData>(text);
				metaData.PlayTutorial = false;
				try
				{
					File.WriteAllText(path, metaData.GetJson(true));
					Console.Log("Successfully disabled tutorial in metadata file", null);
				}
				catch (Exception ex2)
				{
					string str = "Failed to modify metadata file. Exception: ";
					Exception ex3 = ex2;
					Console.LogError(str + ((ex3 != null) ? ex3.ToString() : null), null);
				}
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0005AE74 File Offset: 0x00059074
		public static string SanitizeFileName(string fileName)
		{
			foreach (char oldChar in Path.GetInvalidFileNameChars())
			{
				fileName = fileName.Replace(oldChar, '_');
			}
			return fileName;
		}

		// Token: 0x0400131A RID: 4890
		public const string MAIN_SCENE_NAME = "Main";

		// Token: 0x0400131B RID: 4891
		public const string MENU_SCENE_NAME = "Menu";

		// Token: 0x0400131C RID: 4892
		public const string TUTORIAL_SCENE_NAME = "Tutorial";

		// Token: 0x0400131D RID: 4893
		public const int SAVES_PER_FRAME = 10;

		// Token: 0x0400131E RID: 4894
		public const string SAVE_FILE_EXTENSION = ".json";

		// Token: 0x0400131F RID: 4895
		public const int SAVE_SLOT_COUNT = 5;

		// Token: 0x04001320 RID: 4896
		public const string SAVE_GAME_PREFIX = "SaveGame_";

		// Token: 0x04001321 RID: 4897
		public const bool DEBUG = false;

		// Token: 0x04001322 RID: 4898
		public const bool PRETTY_PRINT = true;

		// Token: 0x04001323 RID: 4899
		public static bool SaveError;

		// Token: 0x0400132A RID: 4906
		public List<ISaveable> Saveables = new List<ISaveable>();

		// Token: 0x0400132B RID: 4907
		public List<IBaseSaveable> BaseSaveables = new List<IBaseSaveable>();

		// Token: 0x0400132C RID: 4908
		[HideInInspector]
		public List<string> ApprovedBaseLevelPaths = new List<string>();

		// Token: 0x0400132D RID: 4909
		protected List<ISaveable> CompletedSaveables = new List<ISaveable>();

		// Token: 0x0400132E RID: 4910
		protected List<SaveRequest> QueuedSaveRequests = new List<SaveRequest>();

		// Token: 0x0400132F RID: 4911
		[Header("References")]
		public RectTransform WriteIssueDisplay;

		// Token: 0x04001330 RID: 4912
		[Header("Events")]
		public UnityEvent onSaveStart;

		// Token: 0x04001331 RID: 4913
		public UnityEvent onSaveComplete;

		// Token: 0x04001332 RID: 4914
		private bool saveFolderInitialized;
	}
}
