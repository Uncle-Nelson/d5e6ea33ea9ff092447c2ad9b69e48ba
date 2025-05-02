using System;
using System.Collections.Generic;
using EasyButtons;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.Networking;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.CrashReportHandler;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006DE RID: 1758
	public class GameManager : NetworkSingleton<GameManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x000C786C File Offset: 0x000C5A6C
		public static bool IS_TUTORIAL
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Tutorial";
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002FDA RID: 12250 RVA: 0x000C7890 File Offset: 0x000C5A90
		public static int Seed
		{
			get
			{
				if (NetworkSingleton<GameManager>.Instance != null)
				{
					return NetworkSingleton<GameManager>.Instance.seed;
				}
				return 0;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x000C78AB File Offset: 0x000C5AAB
		// (set) Token: 0x06002FDC RID: 12252 RVA: 0x000C78B3 File Offset: 0x000C5AB3
		public Sprite OrganisationLogo { get; protected set; }

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x000C78BC File Offset: 0x000C5ABC
		public bool IsTutorial
		{
			get
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Tutorial";
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x000C78E0 File Offset: 0x000C5AE0
		public string SaveFolderName
		{
			get
			{
				return "Game";
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x000C78E0 File Offset: 0x000C5AE0
		public string SaveFileName
		{
			get
			{
				return "Game";
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002FE0 RID: 12256 RVA: 0x000C78E7 File Offset: 0x000C5AE7
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002FE2 RID: 12258 RVA: 0x000C78EF File Offset: 0x000C5AEF
		// (set) Token: 0x06002FE3 RID: 12259 RVA: 0x000C78F7 File Offset: 0x000C5AF7
		public List<string> LocalExtraFiles { get; set; } = new List<string>
		{
			"Logo.png"
		};

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x000C7900 File Offset: 0x000C5B00
		// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x000C7908 File Offset: 0x000C5B08
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x000C7911 File Offset: 0x000C5B11
		// (set) Token: 0x06002FE7 RID: 12263 RVA: 0x000C7919 File Offset: 0x000C5B19
		public bool HasChanged { get; set; }

		// Token: 0x06002FE8 RID: 12264 RVA: 0x000C7922 File Offset: 0x000C5B22
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.DevUtilities.GameManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x000C7936 File Offset: 0x000C5B36
		protected override void Start()
		{
			base.Start();
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x000C793E File Offset: 0x000C5B3E
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (!connection.IsHost)
			{
				this.SetGameData(connection, new GameData(this.OrganisationName, this.seed, this.Settings));
			}
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x000C796D File Offset: 0x000C5B6D
		[TargetRpc]
		public void SetGameData(NetworkConnection conn, GameData data)
		{
			this.RpcWriter___Target_SetGameData_3076874643(conn, data);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x000C797D File Offset: 0x000C5B7D
		public virtual string GetSaveString()
		{
			return new GameData(this.OrganisationName, this.seed, this.Settings).GetJson(true);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x000C799C File Offset: 0x000C5B9C
		public void Load(GameData data, string path)
		{
			this.OrganisationName = data.OrganisationName;
			this.seed = data.Seed;
			this.Settings = data.Settings;
			if (this.onSettingsLoaded != null)
			{
				this.onSettingsLoaded.Invoke();
			}
			this.HasChanged = true;
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x000C79DC File Offset: 0x000C5BDC
		[Button]
		public void EndTutorial(bool natural)
		{
			if (!this.IsTutorial)
			{
				return;
			}
			if (Singleton<LoadManager>.Instance.StoredSaveInfo != null && (!Singleton<Lobby>.Instance.IsInLobby || Singleton<Lobby>.Instance.IsHost))
			{
				Singleton<SaveManager>.Instance.DisablePlayTutorial(Singleton<LoadManager>.Instance.StoredSaveInfo);
				Singleton<LoadManager>.Instance.StoredSaveInfo.MetaData.PlayTutorial = false;
			}
			if (natural)
			{
				Singleton<AchievementManager>.Instance.UnlockAchievement(AchievementManager.EAchievement.COMPLETE_PROLOGUE);
			}
			Singleton<LoadManager>.Instance.ExitToMenu(Singleton<LoadManager>.Instance.StoredSaveInfo, null, true);
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x000C7AC4 File Offset: 0x000C5CC4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterTargetRpc(0U, new ClientRpcDelegate(this.RpcReader___Target_SetGameData_3076874643));
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x000C7AF4 File Offset: 0x000C5CF4
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x000C7B0D File Offset: 0x000C5D0D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x000C7B1C File Offset: 0x000C5D1C
		private void RpcWriter___Target_SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Persistence.Datas.GameDataFishNet.Serializing.Generated(data);
			base.SendTargetRpc(0U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x000C7BD1 File Offset: 0x000C5DD1
		public void RpcLogic___SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
			this.OrganisationName = data.OrganisationName;
			this.seed = data.Seed;
			this.Settings = data.Settings;
			if (this.onSettingsLoaded != null)
			{
				this.onSettingsLoaded.Invoke();
			}
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x000C7C0C File Offset: 0x000C5E0C
		private void RpcReader___Target_SetGameData_3076874643(PooledReader PooledReader0, Channel channel)
		{
			GameData data = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.GameDataFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetGameData_3076874643(base.LocalConnection, data);
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x000C7C43 File Offset: 0x000C5E43
		protected virtual void dll()
		{
			base.Awake();
			CrashReportHandler.logBufferSize = 50U;
			this.InitializeSaveable();
		}

		// Token: 0x04002205 RID: 8709
		public const bool IS_DEMO = false;

		// Token: 0x04002206 RID: 8710
		public static bool IS_BETA;

		// Token: 0x04002207 RID: 8711
		[SerializeField]
		private int seed;

		// Token: 0x04002208 RID: 8712
		public string OrganisationName = "Organisation";

		// Token: 0x0400220A RID: 8714
		public GameSettings Settings = new GameSettings();

		// Token: 0x0400220B RID: 8715
		public Transform SpawnPoint;

		// Token: 0x0400220C RID: 8716
		public Transform NoHomeRespawnPoint;

		// Token: 0x0400220D RID: 8717
		public Transform Temp;

		// Token: 0x0400220E RID: 8718
		public UnityEvent onSettingsLoaded = new UnityEvent();

		// Token: 0x0400220F RID: 8719
		private GameDataLoader loader = new GameDataLoader();

		// Token: 0x04002213 RID: 8723
		private bool dll_Excuted;

		// Token: 0x04002214 RID: 8724
		private bool dll_Excuted;
	}
}
