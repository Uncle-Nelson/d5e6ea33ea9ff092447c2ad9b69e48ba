using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Managing;
using Pathfinding;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Money;
using ScheduleOne.Networking;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.ItemLoaders;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using ScheduleOne.UI;
using ScheduleOne.UI.MainMenu;
using ScheduleOne.UI.Phone;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ScheduleOne.Persistence
{
	// Token: 0x02000367 RID: 871
	public class LoadManager : PersistentSingleton<LoadManager>
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x00057FF2 File Offset: 0x000561F2
		public string DefaultTutorialSaveFolder
		{
			get
			{
				return Path.Combine(Application.streamingAssetsPath, "DefaultTutorialSave");
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x00058003 File Offset: 0x00056203
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x0005800B File Offset: 0x0005620B
		public bool IsGameLoaded { get; protected set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00058014 File Offset: 0x00056214
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x0005801C File Offset: 0x0005621C
		public bool IsLoading { get; protected set; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00058025 File Offset: 0x00056225
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x0005802D File Offset: 0x0005622D
		public float TimeSinceGameLoaded { get; protected set; }

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00058036 File Offset: 0x00056236
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x0005803E File Offset: 0x0005623E
		public bool DebugMode { get; protected set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x00058047 File Offset: 0x00056247
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x0005804F File Offset: 0x0005624F
		public LoadManager.ELoadStatus LoadStatus { get; protected set; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00058058 File Offset: 0x00056258
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x00058060 File Offset: 0x00056260
		public string LoadedGameFolderPath { get; protected set; } = string.Empty;

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00058069 File Offset: 0x00056269
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x00058071 File Offset: 0x00056271
		public SaveInfo ActiveSaveInfo { get; private set; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0005807A File Offset: 0x0005627A
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00058082 File Offset: 0x00056282
		public SaveInfo StoredSaveInfo { get; private set; }

		// Token: 0x060013CC RID: 5068 RVA: 0x0005808B File Offset: 0x0005628B
		protected override void Awake()
		{
			base.Awake();
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00058094 File Offset: 0x00056294
		protected override void Start()
		{
			base.Start();
			if (Singleton<LoadManager>.Instance == null || Singleton<LoadManager>.Instance != this)
			{
				return;
			}
			this.Bananas();
			this.InitializeItemLoaders();
			this.InitializeObjectLoaders();
			this.InitializeNPCLoaders();
			Singleton<SaveManager>.Instance.CheckSaveFolderInitialized();
			this.RefreshSaveInfo();
			if (SceneManager.GetActiveScene().name == "Main" || SceneManager.GetActiveScene().name == "Tutorial")
			{
				this.DebugMode = true;
				this.IsGameLoaded = true;
				this.LoadedGameFolderPath = Path.Combine(Singleton<SaveManager>.Instance.IndividualSavesContainerPath, "DevSave");
				if (!Directory.Exists(this.LoadedGameFolderPath))
				{
					Directory.CreateDirectory(this.LoadedGameFolderPath);
				}
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00058160 File Offset: 0x00056360
		private void Bananas()
		{
			string fullName = new DirectoryInfo(Application.dataPath).Parent.FullName;
			Console.Log("Game folder path: " + fullName, null);
			string path = Path.Combine(fullName, "OnlineFix.ini");
			if (!File.Exists(path))
			{
				return;
			}
			string[] array;
			try
			{
				array = File.ReadAllLines(path);
			}
			catch (Exception ex)
			{
				Console.LogWarning("Error reading INI file: " + ex.Message, null);
				return;
			}
			int num = -1;
			int num2 = -1;
			string str = null;
			string str2 = null;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (text.StartsWith("RealAppId="))
				{
					num = i;
					str = text.Substring("RealAppId=".Length);
				}
				else if (text.StartsWith("FakeAppId="))
				{
					num2 = i;
					str2 = text.Substring("FakeAppId=".Length);
				}
			}
			if (num == -1 || num2 == -1)
			{
				return;
			}
			array[num] = "RealAppId=" + str2;
			array[num2] = "FakeAppId=" + str;
			try
			{
				File.WriteAllLines(path, array);
			}
			catch (Exception ex2)
			{
				Console.LogError("Error writing INI file: " + ex2.Message, null);
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x000582AC File Offset: 0x000564AC
		private void InitializeItemLoaders()
		{
			new ItemLoader();
			new WateringCanLoader();
			new CashLoader();
			new QualityItemLoader();
			new ProductItemLoader();
			new WeedLoader();
			new MethLoader();
			new CocaineLoader();
			new IntegerItemLoader();
			new TrashGrabberLoader();
			new ClothingLoader();
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000582FC File Offset: 0x000564FC
		private void InitializeObjectLoaders()
		{
			new BuildableItemLoader();
			new GridItemLoader();
			new ProceduralGridItemLoader();
			new SurfaceItemLoader();
			new ToggleableItemLoader();
			new PotLoader();
			new PackagingStationLoader();
			new StorageRackLoader();
			new ChemistryStationLoader();
			new LabOvenLoader();
			new BrickPressLoader();
			new MixingStationLoader();
			new CauldronLoader();
			new TrashContainerLoader();
			new SoilPourerLoader();
			new DryingRackLoader();
			new ToggleableSurfaceItemLoader();
			new StorageSurfaceItemLoader();
			new LabelledSurfaceItemLoader();
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0005837B File Offset: 0x0005657B
		private void InitializeNPCLoaders()
		{
			new NPCLoader();
			new EmployeeLoader();
			new PackagerLoader();
			new BotanistLoader();
			new ChemistLoader();
			new CleanerLoader();
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x000583A4 File Offset: 0x000565A4
		public void Update()
		{
			if (this.IsGameLoaded && this.LoadedGameFolderPath != string.Empty && Input.GetKeyDown(KeyCode.F6) && (Application.isEditor || Debug.isDebugBuild))
			{
				NetworkManager networkManager = Object.FindObjectOfType<NetworkManager>();
				networkManager.ClientManager.StopConnection();
				networkManager.ServerManager.StopConnection(false);
				this.StartGame(new SaveInfo(this.LoadedGameFolderPath, -1, "Test Org", DateTime.Now, DateTime.Now, 0f, Application.version, new MetaData(null, null, string.Empty, string.Empty, false)), true);
			}
			if (this.IsGameLoaded && this.LoadStatus == LoadManager.ELoadStatus.None)
			{
				this.TimeSinceGameLoaded += Time.deltaTime;
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00058465 File Offset: 0x00056665
		public void QueueLoadRequest(LoadRequest request)
		{
			this.loadRequests.Add(request);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00058473 File Offset: 0x00056673
		public void DequeueLoadRequest(LoadRequest request)
		{
			this.loadRequests.Remove(request);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00058484 File Offset: 0x00056684
		public ItemLoader GetItemLoader(string itemType)
		{
			ItemLoader itemLoader = this.ItemLoaders.Find((ItemLoader loader) => loader.ItemType == itemType);
			if (itemLoader == null)
			{
				Console.LogError("No item loader found for data type: " + itemType, null);
				return null;
			}
			return itemLoader;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x000584D4 File Offset: 0x000566D4
		public BuildableItemLoader GetObjectLoader(string objectType)
		{
			BuildableItemLoader buildableItemLoader = this.ObjectLoaders.Find((BuildableItemLoader loader) => loader.ItemType == objectType);
			if (buildableItemLoader == null)
			{
				Console.LogError("No object loader found for data type: " + objectType, null);
				return null;
			}
			return buildableItemLoader;
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00058524 File Offset: 0x00056724
		public NPCLoader GetNPCLoader(string npcType)
		{
			NPCLoader npcloader = this.NPCLoaders.Find((NPCLoader loader) => loader.NPCType == npcType);
			if (npcloader == null)
			{
				Console.LogError("No NPC loader found for NPC type: " + npcType, null);
				return null;
			}
			return npcloader;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00058574 File Offset: 0x00056774
		public string GetLoadStatusText()
		{
			switch (this.LoadStatus)
			{
			case LoadManager.ELoadStatus.LoadingScene:
				return "Loading world...";
			case LoadManager.ELoadStatus.Initializing:
				return "Initializing...";
			case LoadManager.ELoadStatus.LoadingData:
				return "Loading data...";
			case LoadManager.ELoadStatus.SpawningPlayer:
				return "Spawning player...";
			case LoadManager.ELoadStatus.WaitingForHost:
				return "Waiting for host to finish loading...";
			default:
				return string.Empty;
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x000585CC File Offset: 0x000567CC
		public void StartGame(SaveInfo info, bool allowLoadStacking = false)
		{
			LoadManager.<>c__DisplayClass63_0 CS$<>8__locals1 = new LoadManager.<>c__DisplayClass63_0();
			CS$<>8__locals1.info = info;
			CS$<>8__locals1.<>4__this = this;
			if (this.IsGameLoaded && !allowLoadStacking)
			{
				Console.LogWarning("Game already loaded, cannot start another", null);
				return;
			}
			if (CS$<>8__locals1.info == null)
			{
				Console.LogWarning("Save info is null, cannot start game", null);
				return;
			}
			string savePath = CS$<>8__locals1.info.SavePath;
			if (!Directory.Exists(savePath))
			{
				Console.LogWarning("Save game does not exist at " + savePath, null);
				return;
			}
			Singleton<MusicPlayer>.Instance.StopAndDisableTracks();
			Console.Log("Starting game!", null);
			this.ActiveSaveInfo = CS$<>8__locals1.info;
			this.IsLoading = true;
			this.TimeSinceGameLoaded = 0f;
			this.LoadedGameFolderPath = CS$<>8__locals1.info.SavePath;
			LoadManager.LoadHistory.Add("Loading game: " + this.ActiveSaveInfo.OrganisationName);
			base.StartCoroutine(CS$<>8__locals1.<StartGame>g__LoadRoutine|0());
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x000586B0 File Offset: 0x000568B0
		public void LoadTutorialAsClient()
		{
			LoadManager.<>c__DisplayClass64_0 CS$<>8__locals1 = new LoadManager.<>c__DisplayClass64_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.waitForExit = false;
			if (this.IsGameLoaded)
			{
				Console.LogWarning("Game already loaded, exiting", null);
				CS$<>8__locals1.waitForExit = true;
				this.ExitToMenu(null, null, false);
			}
			base.StartCoroutine(CS$<>8__locals1.<LoadTutorialAsClient>g__LoadRoutine|0());
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00058704 File Offset: 0x00056904
		public void LoadAsClient(string steamId64)
		{
			LoadManager.<>c__DisplayClass65_0 CS$<>8__locals1 = new LoadManager.<>c__DisplayClass65_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.steamId64 = steamId64;
			CS$<>8__locals1.waitForExit = false;
			if (this.IsGameLoaded)
			{
				Console.LogWarning("Game already loaded, exiting", null);
				CS$<>8__locals1.waitForExit = true;
				this.ExitToMenu(null, null, false);
			}
			base.StartCoroutine(CS$<>8__locals1.<LoadAsClient>g__LoadRoutine|0());
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0005875C File Offset: 0x0005695C
		private void StartLoadErrorAutosubmit()
		{
			base.StartCoroutine(this.<StartLoadErrorAutosubmit>g__Wait|66_0());
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0005876B File Offset: 0x0005696B
		public void SetWaitingForHostLoad()
		{
			this.IsLoading = true;
			this.LoadStatus = LoadManager.ELoadStatus.WaitingForHost;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0005877B File Offset: 0x0005697B
		public void LoadLastSave()
		{
			if (this.ActiveSaveInfo == null)
			{
				Console.LogWarning("No active save info, cannot load last save", null);
				return;
			}
			this.StartGame(this.ActiveSaveInfo, true);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x000587A0 File Offset: 0x000569A0
		private void CleanUp()
		{
			GUIDManager.Clear();
			Quest.Quests.Clear();
			Quest.ActiveQuests.Clear();
			NodeLink.validNodeLinks.Clear();
			Player.onLocalPlayerSpawned = null;
			Player.PlayerList.Clear();
			SupplierLocation.AllLocations.Clear();
			Phone.ActiveApp = null;
			ATM.WeeklyDepositSum = 0f;
			NavMeshUtility.ClearCache();
			Business.OwnedBusinesses.Clear();
			Business.UnownedBusinesses.Clear();
			Property.OwnedProperties.Clear();
			Property.UnownedProperties.Clear();
			PlayerMovement.StaticMoveSpeedMultiplier = 1f;
			Business.onOperationFinished = null;
			Business.onOperationStarted = null;
			Property.onPropertyAcquired = null;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00058844 File Offset: 0x00056A44
		public void ExitToMenu(SaveInfo autoLoadSave = null, MainMenuPopup.Data mainMenuPopup = null, bool preventLeaveLobby = false)
		{
			LoadManager.<>c__DisplayClass70_0 CS$<>8__locals1 = new LoadManager.<>c__DisplayClass70_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.autoLoadSave = autoLoadSave;
			CS$<>8__locals1.mainMenuPopup = mainMenuPopup;
			if (!this.IsGameLoaded)
			{
				Console.LogWarning("Game not loaded, cannot exit to menu", null);
				return;
			}
			Console.Log("Exiting to menu", null);
			LoadManager.LoadHistory.Add("Exiting to menu");
			if (Player.Local != null && InstanceFinder.IsServer)
			{
				Player.Local.HostExitedGame();
			}
			if (Singleton<Lobby>.InstanceExists && Singleton<Lobby>.Instance.IsInLobby && !preventLeaveLobby)
			{
				Singleton<Lobby>.Instance.LeaveLobby();
			}
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			this.IsGameLoaded = false;
			this.ActiveSaveInfo = null;
			this.IsLoading = true;
			Time.timeScale = 1f;
			Singleton<MusicPlayer>.Instance.StopAndDisableTracks();
			base.StartCoroutine(CS$<>8__locals1.<ExitToMenu>g__Load|0());
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0005891C File Offset: 0x00056B1C
		public void RefreshSaveInfo()
		{
			for (int i = 0; i < 5; i++)
			{
				LoadManager.SaveGames[i] = null;
				string text = Path.Combine(Singleton<SaveManager>.Instance.IndividualSavesContainerPath, "SaveGame_" + (i + 1).ToString());
				if (Directory.Exists(text))
				{
					string path = Path.Combine(text, "Metadata.json");
					MetaData metaData = null;
					if (File.Exists(path))
					{
						string text2 = string.Empty;
						try
						{
							text2 = File.ReadAllText(path);
						}
						catch (Exception ex)
						{
							Console.LogError("Error reading save metadata: " + ex.Message, null);
						}
						if (!string.IsNullOrEmpty(text2))
						{
							try
							{
								metaData = JsonUtility.FromJson<MetaData>(text2);
								goto IL_BF;
							}
							catch (Exception ex2)
							{
								metaData = null;
								Console.LogError("Error parsing save metadata: " + ex2.Message, null);
								goto IL_BF;
							}
						}
						Console.LogWarning("Metadata is empty", null);
					}
					IL_BF:
					string path2 = Path.Combine(text, "Game.json");
					GameData gameData = null;
					if (File.Exists(path2))
					{
						string text3 = string.Empty;
						try
						{
							text3 = File.ReadAllText(path2);
						}
						catch (Exception ex3)
						{
							Console.LogError("Error reading save game data: " + ex3.Message, null);
						}
						if (!string.IsNullOrEmpty(text3))
						{
							try
							{
								gameData = JsonUtility.FromJson<GameData>(text3);
								goto IL_142;
							}
							catch (Exception ex4)
							{
								gameData = null;
								Console.LogError("Error parsing save game data: " + ex4.Message, null);
								goto IL_142;
							}
						}
						Console.LogWarning("Game data is empty", null);
					}
					IL_142:
					float networth = 0f;
					string path3 = Path.Combine(text, "Money.json");
					MoneyData moneyData = null;
					if (File.Exists(path3))
					{
						string text4 = string.Empty;
						try
						{
							text4 = File.ReadAllText(path3);
						}
						catch (Exception ex5)
						{
							Console.LogError("Error reading save money data: " + ex5.Message, null);
						}
						if (!string.IsNullOrEmpty(text4))
						{
							try
							{
								moneyData = JsonUtility.FromJson<MoneyData>(text4);
								goto IL_1CC;
							}
							catch (Exception ex6)
							{
								moneyData = null;
								Console.LogError("Error parsing save money data: " + ex6.Message, null);
								goto IL_1CC;
							}
							goto IL_1C1;
						}
						goto IL_1C1;
						IL_1CC:
						if (moneyData != null)
						{
							networth = moneyData.Networth;
							goto IL_1D9;
						}
						goto IL_1D9;
						IL_1C1:
						Console.LogWarning("Money data is empty", null);
						goto IL_1CC;
					}
					IL_1D9:
					if (metaData == null)
					{
						Console.LogWarning("Failed to load metadata. Setting default", null);
						metaData = new MetaData(new DateTimeData(DateTime.Now), new DateTimeData(DateTime.Now), Application.version, Application.version, false);
						try
						{
							File.WriteAllText(path, metaData.GetJson(true));
						}
						catch (Exception)
						{
						}
					}
					if (gameData == null)
					{
						Console.LogWarning("Failed to load game data. Setting default", null);
						gameData = new GameData("Unknown", Random.Range(0, int.MaxValue), new GameSettings());
						try
						{
							File.WriteAllText(path2, gameData.GetJson(true));
						}
						catch (Exception)
						{
						}
					}
					SaveInfo saveInfo = new SaveInfo(text, i + 1, gameData.OrganisationName, metaData.CreationDate.GetDateTime(), metaData.LastPlayedDate.GetDateTime(), networth, metaData.LastSaveVersion, metaData);
					LoadManager.SaveGames[i] = saveInfo;
				}
			}
			LoadManager.LastPlayedGame = null;
			for (int j = 0; j < LoadManager.SaveGames.Length; j++)
			{
				if (LoadManager.SaveGames[j] != null && (LoadManager.LastPlayedGame == null || LoadManager.SaveGames[j].DateLastPlayed > LoadManager.LastPlayedGame.DateLastPlayed))
				{
					LoadManager.LastPlayedGame = LoadManager.SaveGames[j];
				}
			}
			if (this.onSaveInfoLoaded != null)
			{
				this.onSaveInfoLoaded.Invoke();
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00058D00 File Offset: 0x00056F00
		[CompilerGenerated]
		internal static void <LoadAsClient>g__PlayerSpawned|65_5()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(LoadManager.<LoadAsClient>g__PlayerSpawned|65_5));
			Console.Log("Local player spawned", null);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00058D2D File Offset: 0x00056F2D
		[CompilerGenerated]
		private IEnumerator <StartLoadErrorAutosubmit>g__Wait|66_0()
		{
			for (float t = 0f; t < 90f; t += Time.deltaTime)
			{
				if (this.LoadStatus == LoadManager.ELoadStatus.None)
				{
					yield break;
				}
				yield return new WaitForEndOfFrame();
			}
			if (Singleton<PauseMenu>.InstanceExists)
			{
				Console.LogError("Load error timeout reached, submitting error report", null);
				Singleton<PauseMenu>.Instance.FeedbackForm.SetFormData("[AUTOREPORT] Load as client error");
				Singleton<PauseMenu>.Instance.FeedbackForm.SetCategory("Bugs - Multiplayer");
				Singleton<PauseMenu>.Instance.FeedbackForm.IncludeScreenshot = false;
				Singleton<PauseMenu>.Instance.FeedbackForm.IncludeSaveFile = false;
				Singleton<PauseMenu>.Instance.FeedbackForm.Submit();
			}
			yield break;
		}

		// Token: 0x040012B8 RID: 4792
		public const int LOADS_PER_FRAME = 50;

		// Token: 0x040012B9 RID: 4793
		public const bool DEBUG = false;

		// Token: 0x040012BA RID: 4794
		public const float LOAD_ERROR_TIMEOUT = 90f;

		// Token: 0x040012BB RID: 4795
		public const float NETWORK_TIMEOUT = 30f;

		// Token: 0x040012BC RID: 4796
		public static List<string> LoadHistory = new List<string>();

		// Token: 0x040012BD RID: 4797
		public static SaveInfo[] SaveGames = new SaveInfo[5];

		// Token: 0x040012BE RID: 4798
		public static SaveInfo LastPlayedGame = null;

		// Token: 0x040012C7 RID: 4807
		private List<LoadRequest> loadRequests = new List<LoadRequest>();

		// Token: 0x040012C8 RID: 4808
		public List<ItemLoader> ItemLoaders = new List<ItemLoader>();

		// Token: 0x040012C9 RID: 4809
		public List<BuildableItemLoader> ObjectLoaders = new List<BuildableItemLoader>();

		// Token: 0x040012CA RID: 4810
		public List<NPCLoader> NPCLoaders = new List<NPCLoader>();

		// Token: 0x040012CB RID: 4811
		public UnityEvent onPreSceneChange;

		// Token: 0x040012CC RID: 4812
		public UnityEvent onPreLoad;

		// Token: 0x040012CD RID: 4813
		public UnityEvent onLoadComplete;

		// Token: 0x040012CE RID: 4814
		public UnityEvent onSaveInfoLoaded;

		// Token: 0x02000368 RID: 872
		public enum ELoadStatus
		{
			// Token: 0x040012D0 RID: 4816
			None,
			// Token: 0x040012D1 RID: 4817
			LoadingScene,
			// Token: 0x040012D2 RID: 4818
			Initializing,
			// Token: 0x040012D3 RID: 4819
			LoadingData,
			// Token: 0x040012D4 RID: 4820
			SpawningPlayer,
			// Token: 0x040012D5 RID: 4821
			WaitingForHost
		}
	}
}
