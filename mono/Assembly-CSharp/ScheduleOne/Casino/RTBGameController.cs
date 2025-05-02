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
using ScheduleOne.Casino.UI;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x02000768 RID: 1896
	public class RTBGameController : CasinoGameController
	{
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600338B RID: 13195 RVA: 0x000D6ECE File Offset: 0x000D50CE
		// (set) Token: 0x0600338C RID: 13196 RVA: 0x000D6ED6 File Offset: 0x000D50D6
		public RTBGameController.EStage CurrentStage { get; private set; }

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600338D RID: 13197 RVA: 0x000D6EDF File Offset: 0x000D50DF
		// (set) Token: 0x0600338E RID: 13198 RVA: 0x000D6EE7 File Offset: 0x000D50E7
		public bool IsQuestionActive { get; private set; }

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600338F RID: 13199 RVA: 0x000D6EF0 File Offset: 0x000D50F0
		// (set) Token: 0x06003390 RID: 13200 RVA: 0x000D6EF8 File Offset: 0x000D50F8
		public float LocalPlayerBet { get; private set; } = 10f;

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06003391 RID: 13201 RVA: 0x000D6F01 File Offset: 0x000D5101
		// (set) Token: 0x06003392 RID: 13202 RVA: 0x000D6F09 File Offset: 0x000D5109
		public float LocalPlayerBetMultiplier { get; private set; } = 1f;

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003393 RID: 13203 RVA: 0x000D6F12 File Offset: 0x000D5112
		public float MultipliedLocalPlayerBet
		{
			get
			{
				return this.LocalPlayerBet * this.LocalPlayerBetMultiplier;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x000D6F21 File Offset: 0x000D5121
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x000D6F29 File Offset: 0x000D5129
		public float RemainingAnswerTime { get; private set; } = 6f;

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x000D6F32 File Offset: 0x000D5132
		public bool IsLocalPlayerInCurrentRound
		{
			get
			{
				return this.playersInCurrentRound.Contains(Player.Local);
			}
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x000D6F44 File Offset: 0x000D5144
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Casino.RTBGameController_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x000D6F58 File Offset: 0x000D5158
		protected override void Open()
		{
			base.Open();
			Singleton<RTBInterface>.Instance.Open(this);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x000D6F6B File Offset: 0x000D516B
		protected override void Close()
		{
			if (this.IsLocalPlayerInCurrentRound)
			{
				this.RemoveLocalPlayerFromGame(true, 0f);
			}
			Singleton<RTBInterface>.Instance.Close();
			base.Close();
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x000D6F91 File Offset: 0x000D5191
		protected override void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!base.IsOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape && this.IsLocalPlayerInCurrentRound)
			{
				action.used = true;
				this.RemoveLocalPlayerFromGame(true, 0f);
			}
			base.Exit(action);
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x000D6FD0 File Offset: 0x000D51D0
		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.CurrentStage == RTBGameController.EStage.WaitingForPlayers && this.AreAllPlayersReady())
			{
				for (int i = 0; i < this.Players.CurrentPlayerCount; i++)
				{
					this.AddPlayerToCurrentRound(this.Players.GetPlayer(i).NetworkObject);
				}
				this.SetStage(RTBGameController.EStage.RedOrBlack);
			}
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x000D7030 File Offset: 0x000D5230
		[ObserversRpc(RunLocally = true)]
		private void SetStage(RTBGameController.EStage stage)
		{
			this.RpcWriter___Observers_SetStage_2502303021(stage);
			this.RpcLogic___SetStage_2502303021(stage);
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x000D7054 File Offset: 0x000D5254
		private void RunRound(RTBGameController.EStage stage)
		{
			RTBGameController.<>c__DisplayClass50_0 CS$<>8__locals1 = new RTBGameController.<>c__DisplayClass50_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.stage = stage;
			this.SetBetMultiplier(RTBGameController.GetNetBetMultiplier(CS$<>8__locals1.stage - 1));
			base.StartCoroutine(CS$<>8__locals1.<RunRound>g__RunRound|0());
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x000D7095 File Offset: 0x000D5295
		[ObserversRpc(RunLocally = true)]
		private void SetBetMultiplier(float multiplier)
		{
			this.RpcWriter___Observers_SetBetMultiplier_431000436(multiplier);
			this.RpcLogic___SetBetMultiplier_431000436(multiplier);
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x000D70AB File Offset: 0x000D52AB
		[ObserversRpc(RunLocally = true)]
		private void EndGame()
		{
			this.RpcWriter___Observers_EndGame_2166136261();
			this.RpcLogic___EndGame_2166136261();
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x000D70BC File Offset: 0x000D52BC
		public void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0f)
		{
			RTBGameController.<>c__DisplayClass53_0 CS$<>8__locals1 = new RTBGameController.<>c__DisplayClass53_0();
			CS$<>8__locals1.cameraDelay = cameraDelay;
			CS$<>8__locals1.<>4__this = this;
			this.RequestRemovePlayerFromCurrentRound(Player.Local.NetworkObject);
			this.Players.SetPlayerScore(Player.Local, 0);
			if (payout)
			{
				NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(this.LocalPlayerBet * this.LocalPlayerBetMultiplier, true, false);
			}
			if (this.onLocalPlayerExitRound != null)
			{
				this.onLocalPlayerExitRound();
			}
			base.StartCoroutine(CS$<>8__locals1.<RemoveLocalPlayerFromGame>g__Wait|0());
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x000D713A File Offset: 0x000D533A
		private bool IsCurrentRoundEmpty()
		{
			return this.playersInCurrentRound.Count == 0;
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x000D714C File Offset: 0x000D534C
		private float GetAnswerIndex(RTBGameController.EStage stage, PlayingCard.CardData card)
		{
			if (stage == RTBGameController.EStage.RedOrBlack)
			{
				if (card.Suit == PlayingCard.ECardSuit.Hearts || card.Suit == PlayingCard.ECardSuit.Diamonds)
				{
					return 1f;
				}
				return 2f;
			}
			else if (stage == RTBGameController.EStage.HigherOrLower)
			{
				PlayingCard.CardData card2 = this.drawnCards[this.drawnCards.Count - 2];
				if (this.GetCardNumberValue(card) >= this.GetCardNumberValue(card2))
				{
					return 1f;
				}
				return 2f;
			}
			else
			{
				if (stage != RTBGameController.EStage.InsideOrOutside)
				{
					if (stage == RTBGameController.EStage.Suit)
					{
						switch (card.Suit)
						{
						case PlayingCard.ECardSuit.Spades:
							return 4f;
						case PlayingCard.ECardSuit.Hearts:
							return 1f;
						case PlayingCard.ECardSuit.Diamonds:
							return 3f;
						case PlayingCard.ECardSuit.Clubs:
							return 2f;
						}
					}
					Console.LogError("GetAnswerIndex not implemented for stage " + stage.ToString(), null);
					return 0f;
				}
				PlayingCard.CardData card3 = this.drawnCards[this.drawnCards.Count - 2];
				PlayingCard.CardData card4 = this.drawnCards[this.drawnCards.Count - 3];
				int num = Mathf.Min(this.GetCardNumberValue(card3), this.GetCardNumberValue(card4));
				int num2 = Mathf.Max(this.GetCardNumberValue(card3), this.GetCardNumberValue(card4));
				int cardNumberValue = this.GetCardNumberValue(card);
				if (cardNumberValue >= num && cardNumberValue <= num2)
				{
					return 1f;
				}
				return 2f;
			}
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x000D7294 File Offset: 0x000D5494
		[ObserversRpc(RunLocally = true)]
		private void NotifyAnswer(float answerIndex)
		{
			this.RpcWriter___Observers_NotifyAnswer_431000436(answerIndex);
			this.RpcLogic___NotifyAnswer_431000436(answerIndex);
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x000D72B8 File Offset: 0x000D54B8
		[ObserversRpc(RunLocally = true)]
		private void QuestionDone()
		{
			this.RpcWriter___Observers_QuestionDone_2166136261();
			this.RpcLogic___QuestionDone_2166136261();
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x000D72D4 File Offset: 0x000D54D4
		private void GetQuestionsAndAnswers(RTBGameController.EStage stage, out string question, out string[] answers)
		{
			question = "";
			answers = new string[0];
			if (stage == RTBGameController.EStage.RedOrBlack)
			{
				question = "What will the next card be?";
				answers = new string[]
				{
					"Red",
					"Black"
				};
			}
			if (stage == RTBGameController.EStage.HigherOrLower)
			{
				question = "Will the next card be higher or lower?";
				answers = new string[]
				{
					"Higher",
					"Lower"
				};
			}
			if (stage == RTBGameController.EStage.InsideOrOutside)
			{
				question = "Will the next card be inside or outside?";
				answers = new string[]
				{
					"Inside",
					"Outside"
				};
			}
			if (stage == RTBGameController.EStage.Suit)
			{
				question = "What will the suit of the next card be?";
				answers = new string[]
				{
					"Hearts",
					"Clubs",
					"Diamonds",
					"Spades"
				};
			}
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x000D738C File Offset: 0x000D558C
		private void ResetCards()
		{
			for (int i = 0; i < this.Cards.Length; i++)
			{
				this.Cards[i].SetFaceUp(false, true);
				this.Cards[i].GlideTo(this.CardDefaultPositions[i].position, this.CardDefaultPositions[i].rotation, 0.5f, true);
			}
			this.cardsInDeck = new List<PlayingCard.CardData>();
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 13; k++)
				{
					PlayingCard.CardData item = default(PlayingCard.CardData);
					item.Suit = (PlayingCard.ECardSuit)j;
					item.Value = k + PlayingCard.ECardValue.Ace;
					this.cardsInDeck.Add(item);
				}
			}
			this.drawnCards.Clear();
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x000D7440 File Offset: 0x000D5640
		[ObserversRpc(RunLocally = true)]
		private void AddPlayerToCurrentRound(NetworkObject player)
		{
			this.RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(player);
			this.RpcLogic___AddPlayerToCurrentRound_3323014238(player);
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x000D7461 File Offset: 0x000D5661
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			this.RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(player);
			this.RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(player);
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x000D7478 File Offset: 0x000D5678
		[ObserversRpc(RunLocally = true)]
		private void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			this.RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(player);
			this.RpcLogic___RemovePlayerFromCurrentRound_3323014238(player);
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x000D749C File Offset: 0x000D569C
		private PlayingCard.CardData PullCardFromDeck()
		{
			PlayingCard.CardData cardData = this.cardsInDeck[Random.Range(0, this.cardsInDeck.Count)];
			this.cardsInDeck.Remove(cardData);
			this.drawnCards.Add(cardData);
			return cardData;
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x000D74E0 File Offset: 0x000D56E0
		public void SetLocalPlayerBet(float bet)
		{
			if (!base.IsOpen)
			{
				return;
			}
			this.LocalPlayerBet = bet;
			if (this.onLocalPlayerBetChange != null)
			{
				this.onLocalPlayerBetChange();
			}
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x000D7505 File Offset: 0x000D5705
		public bool AreAllPlayersReady()
		{
			return this.Players.CurrentPlayerCount != 0 && this.GetPlayersReadyCount() == this.Players.CurrentPlayerCount;
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x000D752C File Offset: 0x000D572C
		public int GetPlayersReadyCount()
		{
			int num = 0;
			for (int i = 0; i < this.Players.CurrentPlayerCount; i++)
			{
				if (!(this.Players.GetPlayer(i) == null) && this.Players.GetPlayerData(i).GetData<bool>("Ready"))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x000D7582 File Offset: 0x000D5782
		public void SetLocalPlayerAnswer(float answer)
		{
			base.LocalPlayerData.SetData<float>("Answer", answer, true);
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x000D7598 File Offset: 0x000D5798
		public int GetAnsweredPlayersCount()
		{
			int num = 0;
			for (int i = 0; i < this.Players.CurrentPlayerCount; i++)
			{
				if (!(this.Players.GetPlayer(i) == null) && this.playersInCurrentRound.Contains(this.Players.GetPlayer(i)) && this.Players.GetPlayerData(i).GetData<float>("Answer") > 0.1f)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x000D760C File Offset: 0x000D580C
		public void ToggleLocalPlayerReady()
		{
			bool flag = base.LocalPlayerData.GetData<bool>("Ready");
			flag = !flag;
			base.LocalPlayerData.SetData<bool>("Ready", flag, true);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x000D7641 File Offset: 0x000D5841
		private int GetCardNumberValue(PlayingCard.CardData card)
		{
			if (card.Value == PlayingCard.ECardValue.Ace)
			{
				return 14;
			}
			return (int)card.Value;
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x000D7655 File Offset: 0x000D5855
		public static float GetNetBetMultiplier(RTBGameController.EStage stage)
		{
			if (stage == RTBGameController.EStage.RedOrBlack)
			{
				return 2f;
			}
			if (stage == RTBGameController.EStage.HigherOrLower)
			{
				return 3f;
			}
			if (stage == RTBGameController.EStage.InsideOrOutside)
			{
				return 4f;
			}
			if (stage == RTBGameController.EStage.Suit)
			{
				return 20f;
			}
			return 1f;
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x000D76DC File Offset: 0x000D58DC
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_SetStage_2502303021));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_SetBetMultiplier_431000436));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_EndGame_2166136261));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_NotifyAnswer_431000436));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_QuestionDone_2166136261));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_AddPlayerToCurrentRound_3323014238));
			base.RegisterServerRpc(6U, new ServerRpcDelegate(this.RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238));
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x000D77B8 File Offset: 0x000D59B8
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x000D77D1 File Offset: 0x000D59D1
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x000D77E0 File Offset: 0x000D59E0
		private void RpcWriter___Observers_SetStage_2502303021(RTBGameController.EStage stage)
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
			writer.Write___ScheduleOne.Casino.RTBGameController/EStageFishNet.Serializing.Generated(stage);
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x000D7898 File Offset: 0x000D5A98
		private void RpcLogic___SetStage_2502303021(RTBGameController.EStage stage)
		{
			this.CurrentStage = stage;
			if (!this.IsLocalPlayerInCurrentRound && !InstanceFinder.IsServer)
			{
				return;
			}
			if (stage == RTBGameController.EStage.RedOrBlack)
			{
				this.RunRound(RTBGameController.EStage.RedOrBlack);
			}
			if (stage == RTBGameController.EStage.HigherOrLower)
			{
				this.RunRound(RTBGameController.EStage.HigherOrLower);
			}
			if (stage == RTBGameController.EStage.InsideOrOutside)
			{
				this.RunRound(RTBGameController.EStage.InsideOrOutside);
			}
			if (stage == RTBGameController.EStage.Suit)
			{
				this.RunRound(RTBGameController.EStage.Suit);
			}
			if (this.onStageChange != null)
			{
				this.onStageChange(stage);
			}
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x000D78FC File Offset: 0x000D5AFC
		private void RpcReader___Observers_SetStage_2502303021(PooledReader PooledReader0, Channel channel)
		{
			RTBGameController.EStage stage = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Casino.RTBGameController/EStageFishNet.Serializing.Generateds(PooledReader0);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetStage_2502303021(stage);
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x000D7938 File Offset: 0x000D5B38
		private void RpcWriter___Observers_SetBetMultiplier_431000436(float multiplier)
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
			writer.WriteSingle(multiplier, AutoPackType.Unpacked);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x000D79F3 File Offset: 0x000D5BF3
		private void RpcLogic___SetBetMultiplier_431000436(float multiplier)
		{
			this.LocalPlayerBetMultiplier = multiplier;
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x000D79FC File Offset: 0x000D5BFC
		private void RpcReader___Observers_SetBetMultiplier_431000436(PooledReader PooledReader0, Channel channel)
		{
			float multiplier = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetBetMultiplier_431000436(multiplier);
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x000D7A3C File Offset: 0x000D5C3C
		private void RpcWriter___Observers_EndGame_2166136261()
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
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x000D7AE5 File Offset: 0x000D5CE5
		private void RpcLogic___EndGame_2166136261()
		{
			if (this.IsLocalPlayerInCurrentRound)
			{
				this.RemoveLocalPlayerFromGame(true, 0f);
			}
			this.ResetCards();
			this.SetStage(RTBGameController.EStage.WaitingForPlayers);
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x000D7B08 File Offset: 0x000D5D08
		private void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___EndGame_2166136261();
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x000D7B34 File Offset: 0x000D5D34
		private void RpcWriter___Observers_NotifyAnswer_431000436(float answerIndex)
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
			writer.WriteSingle(answerIndex, AutoPackType.Unpacked);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x000D7BF0 File Offset: 0x000D5DF0
		private void RpcLogic___NotifyAnswer_431000436(float answerIndex)
		{
			if (!this.IsLocalPlayerInCurrentRound)
			{
				return;
			}
			if (base.LocalPlayerData.GetData<float>("Answer") == answerIndex)
			{
				Console.Log("Correct answer!", null);
				this.Players.SetPlayerScore(Player.Local, Mathf.RoundToInt(this.MultipliedLocalPlayerBet));
				if (this.onLocalPlayerCorrect != null)
				{
					this.onLocalPlayerCorrect();
					return;
				}
			}
			else
			{
				Console.Log("Incorrect answer!", null);
				this.RemoveLocalPlayerFromGame(false, 2f);
				if (this.onLocalPlayerIncorrect != null)
				{
					this.onLocalPlayerIncorrect();
				}
			}
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x000D7C80 File Offset: 0x000D5E80
		private void RpcReader___Observers_NotifyAnswer_431000436(PooledReader PooledReader0, Channel channel)
		{
			float answerIndex = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___NotifyAnswer_431000436(answerIndex);
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x000D7CC0 File Offset: 0x000D5EC0
		private void RpcWriter___Observers_QuestionDone_2166136261()
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
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x000D7D6C File Offset: 0x000D5F6C
		private void RpcLogic___QuestionDone_2166136261()
		{
			if (!this.IsLocalPlayerInCurrentRound)
			{
				return;
			}
			if (!this.IsQuestionActive)
			{
				return;
			}
			if (base.LocalPlayerData.GetData<float>("Answer") == 0f)
			{
				this.SetLocalPlayerAnswer(1f);
			}
			this.IsQuestionActive = false;
			if (this.onQuestionDone != null)
			{
				this.onQuestionDone();
			}
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x000D7DC8 File Offset: 0x000D5FC8
		private void RpcReader___Observers_QuestionDone_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___QuestionDone_2166136261();
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x000D7DF4 File Offset: 0x000D5FF4
		private void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
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
			writer.WriteNetworkObject(player);
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x000D7EAC File Offset: 0x000D60AC
		private void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			Player component = player.GetComponent<Player>();
			if (component == null)
			{
				return;
			}
			if (!this.playersInCurrentRound.Contains(component))
			{
				this.playersInCurrentRound.Add(component);
			}
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x000D7EE4 File Offset: 0x000D60E4
		private void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___AddPlayerToCurrentRound_3323014238(player);
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x000D7F20 File Offset: 0x000D6120
		private void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
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
			writer.WriteNetworkObject(player);
			base.SendServerRpc(6U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x000D7FC7 File Offset: 0x000D61C7
		private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			this.RemovePlayerFromCurrentRound(player);
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x000D7FD0 File Offset: 0x000D61D0
		private void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(player);
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x000D8010 File Offset: 0x000D6210
		private void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
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
			writer.WriteNetworkObject(player);
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x000D80C8 File Offset: 0x000D62C8
		private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			if (player == null)
			{
				return;
			}
			Player component = player.GetComponent<Player>();
			if (component == null)
			{
				return;
			}
			if (this.playersInCurrentRound.Contains(component))
			{
				this.playersInCurrentRound.Remove(component);
			}
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x000D810C File Offset: 0x000D630C
		private void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___RemovePlayerFromCurrentRound_3323014238(player);
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x000D8147 File Offset: 0x000D6347
		protected virtual void dll()
		{
			base.Awake();
			this.ResetCards();
		}

		// Token: 0x040024C8 RID: 9416
		public const int BET_MINIMUM = 10;

		// Token: 0x040024C9 RID: 9417
		public const int BET_MAXIMUM = 500;

		// Token: 0x040024CA RID: 9418
		public const float ANSWER_MAX_TIME = 6f;

		// Token: 0x040024CB RID: 9419
		[Header("References")]
		public Transform PlayCameraTransform;

		// Token: 0x040024CC RID: 9420
		public Transform FocusedCameraTransform;

		// Token: 0x040024CD RID: 9421
		public PlayingCard[] Cards;

		// Token: 0x040024CE RID: 9422
		public Transform[] CardDefaultPositions;

		// Token: 0x040024CF RID: 9423
		public Transform ActiveCardPosition;

		// Token: 0x040024D0 RID: 9424
		public Transform[] DockedCardPositions;

		// Token: 0x040024D2 RID: 9426
		public Action<RTBGameController.EStage> onStageChange;

		// Token: 0x040024D3 RID: 9427
		public Action<string, string[]> onQuestionReady;

		// Token: 0x040024D4 RID: 9428
		public Action onQuestionDone;

		// Token: 0x040024D5 RID: 9429
		public Action onLocalPlayerCorrect;

		// Token: 0x040024D6 RID: 9430
		public Action onLocalPlayerIncorrect;

		// Token: 0x040024D7 RID: 9431
		public Action onLocalPlayerBetChange;

		// Token: 0x040024D8 RID: 9432
		public Action onLocalPlayerExitRound;

		// Token: 0x040024DD RID: 9437
		private List<Player> playersInCurrentRound = new List<Player>();

		// Token: 0x040024DE RID: 9438
		private List<PlayingCard.CardData> cardsInDeck = new List<PlayingCard.CardData>();

		// Token: 0x040024DF RID: 9439
		private List<PlayingCard.CardData> drawnCards = new List<PlayingCard.CardData>();

		// Token: 0x040024E0 RID: 9440
		private bool dll_Excuted;

		// Token: 0x040024E1 RID: 9441
		private bool dll_Excuted;

		// Token: 0x02000769 RID: 1897
		public enum EStage
		{
			// Token: 0x040024E3 RID: 9443
			WaitingForPlayers,
			// Token: 0x040024E4 RID: 9444
			RedOrBlack,
			// Token: 0x040024E5 RID: 9445
			HigherOrLower,
			// Token: 0x040024E6 RID: 9446
			InsideOrOutside,
			// Token: 0x040024E7 RID: 9447
			Suit
		}
	}
}
