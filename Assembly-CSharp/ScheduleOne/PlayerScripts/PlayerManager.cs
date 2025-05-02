using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using Steamworks;
using Unity.AI.Navigation;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005F9 RID: 1529
	public class PlayerManager : Singleton<PlayerManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000A3598 File Offset: 0x000A1798
		public string SaveFolderName
		{
			get
			{
				return "Players";
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x000A3598 File Offset: 0x000A1798
		public string SaveFileName
		{
			get
			{
				return "Players";
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x000A359F File Offset: 0x000A179F
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060027D1 RID: 10193 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x000A35A7 File Offset: 0x000A17A7
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x000A35AF File Offset: 0x000A17AF
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x000A35B8 File Offset: 0x000A17B8
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x000A35C0 File Offset: 0x000A17C0
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000A35C9 File Offset: 0x000A17C9
		// (set) Token: 0x060027D7 RID: 10199 RVA: 0x000A35D1 File Offset: 0x000A17D1
		public bool HasChanged { get; set; }

		// Token: 0x060027D8 RID: 10200 RVA: 0x000A35DA File Offset: 0x000A17DA
		protected override void Awake()
		{
			base.Awake();
			this.InitializeSaveable();
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetSaveString()
		{
			return string.Empty;
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x000A35E8 File Offset: 0x000A17E8
		public virtual List<string> WriteData(string parentFolderPath)
		{
			List<string> list = new List<string>();
			string containerFolder = ((ISaveable)this).GetContainerFolder(parentFolderPath);
			int i;
			int j;
			for (i = 0; i < Player.PlayerList.Count; i = j + 1)
			{
				new SaveRequest(Player.PlayerList[i], containerFolder);
				list.Add(Player.PlayerList[i].SaveFolderName);
				if (!this.loadedPlayerData.Exists((PlayerData PlayerData) => PlayerData.PlayerCode == Player.PlayerList[i].PlayerCode))
				{
					this.loadedPlayerData.Add(Player.PlayerList[i].GetPlayerData());
					this.loadedPlayerDataPaths.Add(Path.Combine(containerFolder, Player.PlayerList[i].SaveFolderName));
					this.loadedPlayerFileNames.Add(Player.PlayerList[i].SaveFolderName);
				}
				j = i;
			}
			string[] collection = Directory.GetDirectories(containerFolder).Select(new Func<string, string>(Path.GetFileName)).ToArray<string>();
			list.AddRange(collection);
			list.AddRange(this.loadedPlayerFileNames);
			return list;
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000A3720 File Offset: 0x000A1920
		public void SavePlayer(Player player)
		{
			Console.Log("Saving player: " + player.PlayerCode, null);
			string text = Path.Combine(Singleton<LoadManager>.Instance.LoadedGameFolderPath, this.SaveFolderName);
			Singleton<SaveManager>.Instance.ClearCompletedSaveable(player);
			string saveString = player.GetSaveString();
			((ISaveable)player).WriteBaseData(text, saveString);
			player.WriteData(text);
			PlayerData playerData = this.loadedPlayerData.FirstOrDefault((PlayerData PlayerData) => PlayerData.PlayerCode == player.PlayerCode);
			if (playerData != null)
			{
				int index = this.loadedPlayerData.IndexOf(playerData);
				this.loadedPlayerData[index] = player.GetPlayerData();
				return;
			}
			this.loadedPlayerData.Add(player.GetPlayerData());
			this.loadedPlayerDataPaths.Add(Path.Combine(text, player.SaveFolderName));
			this.loadedPlayerFileNames.Add(player.SaveFolderName);
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x000A382C File Offset: 0x000A1A2C
		public void LoadPlayer(PlayerData data, string containerPath)
		{
			this.loadedPlayerData.Add(data);
			this.loadedPlayerDataPaths.Add(containerPath);
			this.loadedPlayerFileNames.Add(Path.GetFileName(containerPath));
			Player player = Player.PlayerList.FirstOrDefault((Player Player) => Player.PlayerCode == data.PlayerCode);
			if (player == null && InstanceFinder.IsServer)
			{
				string fileName = Path.GetFileName(containerPath);
				if (fileName == "Player_Local" || fileName == "Player_0")
				{
					player = Player.Local;
				}
			}
			if (player != null)
			{
				player.Load(data, containerPath);
			}
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x000A38D8 File Offset: 0x000A1AD8
		public void AllPlayerFilesLoaded()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			string text = string.Empty;
			if (SteamManager.Initialized)
			{
				text = SteamUser.GetSteamID().ToString();
			}
			if (this.loadedPlayerFileNames.Contains("Player_0"))
			{
				int index = this.loadedPlayerFileNames.IndexOf("Player_0");
				Player.Local.Load(this.loadedPlayerData[index], this.loadedPlayerDataPaths[index]);
				return;
			}
			if (text != string.Empty && this.loadedPlayerFileNames.Contains("Player_" + text))
			{
				int index2 = this.loadedPlayerFileNames.IndexOf("Player_" + text);
				Player.Local.Load(this.loadedPlayerData[index2], this.loadedPlayerDataPaths[index2]);
				return;
			}
			if (this.loadedPlayerFileNames.Contains("Player_Local"))
			{
				int index3 = this.loadedPlayerFileNames.IndexOf("Player_Local");
				Player.Local.Load(this.loadedPlayerData[index3], this.loadedPlayerDataPaths[index3]);
				return;
			}
			if (this.loadedPlayerData.Count > 0)
			{
				Player.Local.Load(this.loadedPlayerData[0], this.loadedPlayerDataPaths[0]);
				return;
			}
			Console.LogWarning("Couldn't find any data for host player. This is fine if this is a new game, but not if this is a loaded game.", null);
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x000A3A38 File Offset: 0x000A1C38
		public bool TryGetPlayerData(string playerCode, out PlayerData data, out string inventoryString, out string appearanceString, out string clothingString, out VariableData[] variables)
		{
			data = this.loadedPlayerData.FirstOrDefault((PlayerData PlayerData) => PlayerData.PlayerCode == playerCode);
			inventoryString = string.Empty;
			appearanceString = string.Empty;
			clothingString = string.Empty;
			variables = null;
			List<VariableData> list = new List<VariableData>();
			if (data != null)
			{
				string text = this.loadedPlayerDataPaths[this.loadedPlayerData.IndexOf(data)];
				PlayerLoader playerLoader = new PlayerLoader();
				string text2;
				if (playerLoader.TryLoadFile(text, "Inventory", out text2))
				{
					inventoryString = text2;
				}
				else
				{
					Console.LogWarning("Failed to load player inventory under " + text, null);
				}
				string text3;
				if (playerLoader.TryLoadFile(text, "Appearance", out text3))
				{
					appearanceString = text3;
				}
				else
				{
					Console.LogWarning("Failed to load player appearance under " + text, null);
				}
				string text4;
				if (playerLoader.TryLoadFile(text, "Clothing", out text4))
				{
					clothingString = text4;
				}
				else
				{
					Console.LogWarning("Failed to load player clothing under " + text, null);
				}
				string path = Path.Combine(text, "Variables");
				if (Directory.Exists(path))
				{
					string[] files = Directory.GetFiles(path);
					VariablesLoader variablesLoader = new VariablesLoader();
					for (int i = 0; i < files.Length; i++)
					{
						string text5;
						if (variablesLoader.TryLoadFile(files[i], out text5, false))
						{
							VariableData item = null;
							try
							{
								item = JsonUtility.FromJson<VariableData>(text5);
							}
							catch (Exception ex)
							{
								Debug.LogError("Error loading player variable data: " + ex.Message);
							}
							if (data != null)
							{
								list.Add(item);
							}
						}
					}
				}
			}
			if (list.Count > 0)
			{
				variables = list.ToArray();
			}
			return data != null;
		}

		// Token: 0x04001CE2 RID: 7394
		private PlayersLoader loader = new PlayersLoader();

		// Token: 0x04001CE6 RID: 7398
		[SerializeField]
		protected List<PlayerData> loadedPlayerData = new List<PlayerData>();

		// Token: 0x04001CE7 RID: 7399
		protected List<string> loadedPlayerDataPaths = new List<string>();

		// Token: 0x04001CE8 RID: 7400
		protected List<string> loadedPlayerFileNames = new List<string>();

		// Token: 0x04001CE9 RID: 7401
		public NavMeshSurface PlayerRecoverySurface;
	}
}
