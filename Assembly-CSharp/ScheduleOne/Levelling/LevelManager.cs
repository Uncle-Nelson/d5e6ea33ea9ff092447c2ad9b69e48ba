using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Levelling
{
	// Token: 0x020005B0 RID: 1456
	public class LevelManager : NetworkSingleton<LevelManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x00092366 File Offset: 0x00090566
		// (set) Token: 0x0600240B RID: 9227 RVA: 0x0009236E File Offset: 0x0009056E
		public ERank Rank { get; private set; }

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x00092377 File Offset: 0x00090577
		// (set) Token: 0x0600240D RID: 9229 RVA: 0x0009237F File Offset: 0x0009057F
		public int Tier { get; private set; } = 1;

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x00092388 File Offset: 0x00090588
		// (set) Token: 0x0600240F RID: 9231 RVA: 0x00092390 File Offset: 0x00090590
		public int XP { get; private set; }

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x00092399 File Offset: 0x00090599
		// (set) Token: 0x06002411 RID: 9233 RVA: 0x000923A1 File Offset: 0x000905A1
		public int TotalXP { get; private set; }

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x000923AA File Offset: 0x000905AA
		public float XPToNextTier
		{
			get
			{
				return Mathf.Round(Mathf.Lerp(200f, 2500f, (float)this.Rank / (float)this.rankCount) / 25f) * 25f;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x000923DB File Offset: 0x000905DB
		public string SaveFolderName
		{
			get
			{
				return "Rank";
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x000923DB File Offset: 0x000905DB
		public string SaveFileName
		{
			get
			{
				return "Rank";
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x000923E2 File Offset: 0x000905E2
		public Loader Loader
		{
			get
			{
				return this.loader;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000923EA File Offset: 0x000905EA
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x000923F2 File Offset: 0x000905F2
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x000923FB File Offset: 0x000905FB
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x00092403 File Offset: 0x00090603
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x0009240C File Offset: 0x0009060C
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x00092414 File Offset: 0x00090614
		public bool HasChanged { get; set; }

		// Token: 0x0600241D RID: 9245 RVA: 0x0009241D File Offset: 0x0009061D
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Levelling.LevelManager_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00092431 File Offset: 0x00090631
		protected override void Start()
		{
			base.Start();
			this.InitializeSaveable();
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0009243F File Offset: 0x0009063F
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			this.SetData(connection, this.Rank, this.Tier, this.XP, this.TotalXP);
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00092467 File Offset: 0x00090667
		[ServerRpc(RequireOwnership = false)]
		public void AddXP(int xp)
		{
			this.RpcWriter___Server_AddXP_3316948804(xp);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00092474 File Offset: 0x00090674
		[ObserversRpc]
		private void AddXPLocal(int xp)
		{
			this.RpcWriter___Observers_AddXPLocal_3316948804(xp);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0009248C File Offset: 0x0009068C
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_SetData_20965027(conn, rank, tier, xp, totalXp);
				this.RpcLogic___SetData_20965027(conn, rank, tier, xp, totalXp);
			}
			else
			{
				this.RpcWriter___Target_SetData_20965027(conn, rank, tier, xp, totalXp);
			}
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x000924F4 File Offset: 0x000906F4
		[ObserversRpc]
		private void IncreaseTierNetworked(FullRank before, FullRank after)
		{
			this.RpcWriter___Observers_IncreaseTierNetworked_3953286437(before, after);
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00092510 File Offset: 0x00090710
		private void IncreaseTier()
		{
			this.XP -= (int)this.XPToNextTier;
			int tier = this.Tier;
			this.Tier = tier + 1;
			if (this.Tier > 5 && this.Rank != ERank.Kingpin)
			{
				this.Tier = 1;
				ERank rank = this.Rank;
				this.Rank = rank + 1;
			}
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0009256B File Offset: 0x0009076B
		public virtual string GetSaveString()
		{
			return new RankData((int)this.Rank, this.Tier, this.XP, this.TotalXP).GetJson(true);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00092590 File Offset: 0x00090790
		public FullRank GetFullRank()
		{
			return new FullRank(this.Rank, this.Tier);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x000925A4 File Offset: 0x000907A4
		public void AddUnlockable(Unlockable unlockable)
		{
			if (!this.Unlockables.ContainsKey(unlockable.Rank))
			{
				this.Unlockables.Add(unlockable.Rank, new List<Unlockable>());
			}
			if (this.Unlockables[unlockable.Rank].Find((Unlockable x) => x.Title.ToLower() == unlockable.Title.ToLower() && x.Icon == unlockable.Icon) != null)
			{
				return;
			}
			this.Unlockables[unlockable.Rank].Add(unlockable);
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0009263C File Offset: 0x0009083C
		public int GetTotalXPForRank(FullRank fullrank)
		{
			int num = 0;
			foreach (ERank erank in (ERank[])Enum.GetValues(typeof(ERank)))
			{
				int xpforTier = this.GetXPForTier(erank);
				int num2 = 5;
				if (erank == ERank.Kingpin)
				{
					num2 = 1000;
				}
				for (int j = 1; j <= num2; j++)
				{
					if (erank == fullrank.Rank && j == fullrank.Tier)
					{
						return num;
					}
					num += xpforTier;
				}
			}
			Console.LogError("Rank not found: " + fullrank.ToString(), null);
			return 0;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x000926D4 File Offset: 0x000908D4
		public FullRank GetFullRank(int totalXp)
		{
			int num = totalXp;
			foreach (ERank erank in (ERank[])Enum.GetValues(typeof(ERank)))
			{
				int xpforTier = this.GetXPForTier(erank);
				if (erank == ERank.Kingpin)
				{
					for (int j = 1; j <= 1000; j++)
					{
						if (num < xpforTier)
						{
							return new FullRank(erank, j);
						}
						num -= xpforTier;
					}
				}
				else
				{
					for (int k = 1; k <= 5; k++)
					{
						if (num < xpforTier)
						{
							return new FullRank(erank, k);
						}
						num -= xpforTier;
					}
				}
			}
			Console.LogError("Rank not found for XP: " + totalXp.ToString(), null);
			return new FullRank(ERank.Street_Rat, 1);
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00092782 File Offset: 0x00090982
		public int GetXPForTier(ERank rank)
		{
			return Mathf.RoundToInt(Mathf.Round(Mathf.Lerp(200f, 2500f, (float)rank / (float)this.rankCount) / 25f) * 25f);
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x000927B4 File Offset: 0x000909B4
		public static float GetOrderLimitMultiplier(FullRank rank)
		{
			float rankOrderLimitMultiplier = LevelManager.GetRankOrderLimitMultiplier(rank.Rank);
			if (rank.Rank < ERank.Kingpin)
			{
				float rankOrderLimitMultiplier2 = LevelManager.GetRankOrderLimitMultiplier(rank.Rank + 1);
				float t = (float)(rank.Tier - 1) / 4f;
				return Mathf.Lerp(rankOrderLimitMultiplier, rankOrderLimitMultiplier2, t);
			}
			return Mathf.Clamp(LevelManager.GetRankOrderLimitMultiplier(ERank.Kingpin) + 0.1f * (float)(rank.Tier - 1), 1f, 10f);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00092824 File Offset: 0x00090A24
		private static float GetRankOrderLimitMultiplier(ERank rank)
		{
			switch (rank)
			{
			case ERank.Street_Rat:
				return 1f;
			case ERank.Hoodlum:
				return 1.25f;
			case ERank.Peddler:
				return 1.5f;
			case ERank.Hustler:
				return 1.75f;
			case ERank.Bagman:
				return 2f;
			case ERank.Enforcer:
				return 2.25f;
			case ERank.Shot_Caller:
				return 2.5f;
			case ERank.Block_Boss:
				return 2.75f;
			case ERank.Underlord:
				return 3f;
			case ERank.Baron:
				return 3.25f;
			case ERank.Kingpin:
				return 3.5f;
			default:
				return 1f;
			}
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x000928E8 File Offset: 0x00090AE8
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_AddXP_3316948804));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_AddXPLocal_3316948804));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_SetData_20965027));
			base.RegisterTargetRpc(3U, new ClientRpcDelegate(this.RpcReader___Target_SetData_20965027));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_IncreaseTierNetworked_3953286437));
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0009297F File Offset: 0x00090B7F
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00092998 File Offset: 0x00090B98
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x000929A8 File Offset: 0x00090BA8
		private void RpcWriter___Server_AddXP_3316948804(int xp)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteInt32(xp, AutoPackType.Packed);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x00092A54 File Offset: 0x00090C54
		public void RpcLogic___AddXP_3316948804(int xp)
		{
			this.AddXPLocal(xp);
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00092A60 File Offset: 0x00090C60
		private void RpcReader___Server_AddXP_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int xp = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___AddXP_3316948804(xp);
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00092A98 File Offset: 0x00090C98
		private void RpcWriter___Observers_AddXPLocal_3316948804(int xp)
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
			writer.WriteInt32(xp, AutoPackType.Packed);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00092B54 File Offset: 0x00090D54
		private void RpcLogic___AddXPLocal_3316948804(int xp)
		{
			NetworkSingleton<DailySummary>.Instance.AddXP(xp);
			this.XP += xp;
			this.TotalXP += xp;
			this.HasChanged = true;
			Console.Log(string.Concat(new string[]
			{
				"Rank progress: ",
				this.XP.ToString(),
				"/",
				this.XPToNextTier.ToString(),
				" (Total ",
				this.TotalXP.ToString(),
				")"
			}), null);
			if (InstanceFinder.IsServer)
			{
				FullRank fullRank = this.GetFullRank();
				bool flag = false;
				while ((float)this.XP >= this.XPToNextTier)
				{
					this.IncreaseTier();
					flag = true;
				}
				this.SetData(null, this.Rank, this.Tier, this.XP, this.TotalXP);
				if (flag)
				{
					this.IncreaseTierNetworked(fullRank, this.GetFullRank());
				}
			}
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00092C4C File Offset: 0x00090E4C
		private void RpcReader___Observers_AddXPLocal_3316948804(PooledReader PooledReader0, Channel channel)
		{
			int xp = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___AddXPLocal_3316948804(xp);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00092C84 File Offset: 0x00090E84
		private void RpcWriter___Observers_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
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
			writer.Write___ScheduleOne.Levelling.ERankFishNet.Serializing.Generated(rank);
			writer.WriteInt32(tier, AutoPackType.Packed);
			writer.WriteInt32(xp, AutoPackType.Packed);
			writer.WriteInt32(totalXp, AutoPackType.Packed);
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00092D70 File Offset: 0x00090F70
		public void RpcLogic___SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			this.Rank = rank;
			this.Tier = tier;
			this.XP = xp;
			this.TotalXP = totalXp;
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00092D90 File Offset: 0x00090F90
		private void RpcReader___Observers_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			ERank rank = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Levelling.ERankFishNet.Serializing.Generateds(PooledReader0);
			int tier = PooledReader0.ReadInt32(AutoPackType.Packed);
			int xp = PooledReader0.ReadInt32(AutoPackType.Packed);
			int totalXp = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetData_20965027(null, rank, tier, xp, totalXp);
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00092E10 File Offset: 0x00091010
		private void RpcWriter___Target_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
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
			writer.Write___ScheduleOne.Levelling.ERankFishNet.Serializing.Generated(rank);
			writer.WriteInt32(tier, AutoPackType.Packed);
			writer.WriteInt32(xp, AutoPackType.Packed);
			writer.WriteInt32(totalXp, AutoPackType.Packed);
			base.SendTargetRpc(3U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00092EFC File Offset: 0x000910FC
		private void RpcReader___Target_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			ERank rank = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Levelling.ERankFishNet.Serializing.Generateds(PooledReader0);
			int tier = PooledReader0.ReadInt32(AutoPackType.Packed);
			int xp = PooledReader0.ReadInt32(AutoPackType.Packed);
			int totalXp = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___SetData_20965027(base.LocalConnection, rank, tier, xp, totalXp);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00092F78 File Offset: 0x00091178
		private void RpcWriter___Observers_IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
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
			writer.Write___ScheduleOne.Levelling.FullRankFishNet.Serializing.Generated(before);
			writer.Write___ScheduleOne.Levelling.FullRankFishNet.Serializing.Generated(after);
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0009303C File Offset: 0x0009123C
		private void RpcLogic___IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
			Action<FullRank, FullRank> action = this.onRankUp;
			if (action != null)
			{
				action(before, after);
			}
			this.HasChanged = true;
			Console.Log("Ranked up to " + this.Rank.ToString() + ": " + this.Tier.ToString(), null);
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0009309C File Offset: 0x0009129C
		private void RpcReader___Observers_IncreaseTierNetworked_3953286437(PooledReader PooledReader0, Channel channel)
		{
			FullRank before = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Levelling.FullRankFishNet.Serializing.Generateds(PooledReader0);
			FullRank after = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Levelling.FullRankFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___IncreaseTierNetworked_3953286437(before, after);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x000930DE File Offset: 0x000912DE
		protected virtual void dll()
		{
			base.Awake();
			this.rankCount = Enum.GetValues(typeof(ERank)).Length;
		}

		// Token: 0x04001AEE RID: 6894
		public const int TIERS_PER_RANK = 5;

		// Token: 0x04001AEF RID: 6895
		public const int XP_PER_TIER_MIN = 200;

		// Token: 0x04001AF0 RID: 6896
		public const int XP_PER_TIER_MAX = 2500;

		// Token: 0x04001AF2 RID: 6898
		private int rankCount;

		// Token: 0x04001AF6 RID: 6902
		public Action<FullRank, FullRank> onRankUp;

		// Token: 0x04001AF7 RID: 6903
		public Dictionary<FullRank, List<Unlockable>> Unlockables = new Dictionary<FullRank, List<Unlockable>>();

		// Token: 0x04001AF8 RID: 6904
		private RankLoader loader = new RankLoader();

		// Token: 0x04001AFC RID: 6908
		private bool dll_Excuted;

		// Token: 0x04001AFD RID: 6909
		private bool dll_Excuted;
	}
}
