using System;
using System.IO;
using ScheduleOne.DevUtilities;
using ScheduleOne.ExtendedComponents;
using ScheduleOne.Networking;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.MainMenu
{
	// Token: 0x02000B24 RID: 2852
	public class SetupScreen : MainMenuScreen
	{
		// Token: 0x06004BFE RID: 19454 RVA: 0x0013F308 File Offset: 0x0013D508
		protected virtual void Start()
		{
			this.InputField.onSubmit.AddListener(new UnityAction<string>(delegate(string <p0>)
			{
				this.StartGame();
			}));
			this.SkipIntroContainer.gameObject.SetActive(true);
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x0013F337 File Offset: 0x0013D537
		public void Initialize(int index)
		{
			this.slotIndex = index;
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x0013F340 File Offset: 0x0013D540
		private void Update()
		{
			if (base.IsOpen)
			{
				this.StartButton.interactable = (this.IsInputValid() && Singleton<Lobby>.Instance.IsHost);
				this.NotHostWarning.gameObject.SetActive(!Singleton<Lobby>.Instance.IsHost);
			}
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x0013F394 File Offset: 0x0013D594
		public void StartGame()
		{
			if (!this.IsInputValid())
			{
				return;
			}
			if (!Singleton<Lobby>.Instance.IsHost)
			{
				Console.LogWarning("Only the host can start the game.", null);
				return;
			}
			string text = Path.Combine(Singleton<SaveManager>.Instance.IndividualSavesContainerPath, "SaveGame_" + (this.slotIndex + 1).ToString());
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			this.ClearFolderContents(text);
			this.CopyDefaultSaveToFolder(text);
			string path = Path.Combine(text, "Game.json");
			int seed = Random.Range(0, int.MaxValue);
			string json = new GameData(this.InputField.text, seed, new GameSettings()).GetJson(true);
			File.WriteAllText(path, json);
			bool isOn = this.SkipIntroToggle.isOn;
			string path2 = Path.Combine(text, "Metadata.json");
			string json2 = new MetaData(new DateTimeData(DateTime.Now), new DateTimeData(DateTime.Now), Application.version, Application.version, !isOn).GetJson(true);
			File.WriteAllText(path2, json2);
			Singleton<LoadManager>.Instance.RefreshSaveInfo();
			Singleton<LoadManager>.Instance.StartGame(LoadManager.SaveGames[this.slotIndex], false);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x0013F4B2 File Offset: 0x0013D6B2
		private bool IsInputValid()
		{
			return !string.IsNullOrEmpty(this.InputField.text);
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x0013F4C8 File Offset: 0x0013D6C8
		private void ClearFolderContents(string folderPath)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
			FileInfo[] files = directoryInfo.GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				files[i].Delete();
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				directories[i].Delete(true);
			}
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x0013F518 File Offset: 0x0013D718
		private void CopyDefaultSaveToFolder(string folderPath)
		{
			SetupScreen.CopyFilesRecursively(Path.Combine(Application.streamingAssetsPath, "DefaultSave"), folderPath);
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x0013F53C File Offset: 0x0013D73C
		private static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			string[] array = Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories);
			for (int i = 0; i < array.Length; i++)
			{
				Directory.CreateDirectory(array[i].Replace(sourcePath, targetPath));
			}
			foreach (string text in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
			{
				if (!text.EndsWith(".meta"))
				{
					File.Copy(text, text.Replace(sourcePath, targetPath), true);
				}
			}
		}

		// Token: 0x040038FA RID: 14586
		public const string DEFAULT_SAVE_PATH = "DefaultSave";

		// Token: 0x040038FB RID: 14587
		[Header("References")]
		public GameInputField InputField;

		// Token: 0x040038FC RID: 14588
		public Button StartButton;

		// Token: 0x040038FD RID: 14589
		public RectTransform SkipIntroContainer;

		// Token: 0x040038FE RID: 14590
		public Toggle SkipIntroToggle;

		// Token: 0x040038FF RID: 14591
		public RectTransform NotHostWarning;

		// Token: 0x04003900 RID: 14592
		private int slotIndex;
	}
}
