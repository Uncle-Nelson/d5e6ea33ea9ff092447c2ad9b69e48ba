using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Casino.UI;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x02000750 RID: 1872
	public class BlackjackGameController : CasinoGameController
	{
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x000D1F32 File Offset: 0x000D0132
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x000D1F3A File Offset: 0x000D013A
		public BlackjackGameController.EStage CurrentStage { get; private set; }

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06003291 RID: 12945 RVA: 0x000D1F43 File Offset: 0x000D0143
		// (set) Token: 0x06003292 RID: 12946 RVA: 0x000D1F4B File Offset: 0x000D014B
		public Player PlayerTurn { get; private set; }

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x000D1F54 File Offset: 0x000D0154
		// (set) Token: 0x06003294 RID: 12948 RVA: 0x000D1F5C File Offset: 0x000D015C
		public float LocalPlayerBet { get; private set; } = 10f;

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x000D1F65 File Offset: 0x000D0165
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x000D1F6D File Offset: 0x000D016D
		public int DealerScore { get; private set; }

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x000D1F76 File Offset: 0x000D0176
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x000D1F7E File Offset: 0x000D017E
		public int LocalPlayerScore { get; private set; }

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x000D1F87 File Offset: 0x000D0187
		// (set) Token: 0x0600329A RID: 12954 RVA: 0x000D1F8F File Offset: 0x000D018F
		public bool IsLocalPlayerBlackjack { get; private set; }

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x000D1F98 File Offset: 0x000D0198
		// (set) Token: 0x0600329C RID: 12956 RVA: 0x000D1FA0 File Offset: 0x000D01A0
		public bool IsLocalPlayerBust { get; private set; }

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x000D1FA9 File Offset: 0x000D01A9
		public bool IsLocalPlayerInCurrentRound
		{
			get
			{
				return this.playersInCurrentRound.Contains(Player.Local);
			}
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000D1FBB File Offset: 0x000D01BB
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Casino.BlackjackGameController_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000D1FD0 File Offset: 0x000D01D0
		protected override void Open()
		{
			base.Open();
			Singleton<BlackjackInterface>.Instance.Open(this);
			this.localFocusCameraTransform = this.FocusedCameraTransforms[this.Players.GetPlayerIndex(Player.Local)];
			this.localFinalCameraTransform = this.FinalCameraTransforms[this.Players.GetPlayerIndex(Player.Local)];
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000D2028 File Offset: 0x000D0228
		protected override void Close()
		{
			if (this.IsLocalPlayerInCurrentRound)
			{
				this.RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType.None, 0f);
			}
			Singleton<BlackjackInterface>.Instance.Close();
			base.Close();
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000D204E File Offset: 0x000D024E
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
				this.RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType.None, 0f);
			}
			base.Exit(action);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000D2090 File Offset: 0x000D0290
		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			if (this.CurrentStage == BlackjackGameController.EStage.WaitingForPlayers && this.AreAllPlayersReady())
			{
				for (int i = 0; i < this.Players.CurrentPlayerCount; i++)
				{
					this.AddPlayerToCurrentRound(this.Players.GetPlayer(i).NetworkObject);
				}
				this.StartGame();
			}
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000D20F0 File Offset: 0x000D02F0
		private List<Player> GetClockwisePlayers()
		{
			List<Player> list = new List<Player>();
			Player player = this.Players.GetPlayer(3);
			Player player2 = this.Players.GetPlayer(1);
			Player player3 = this.Players.GetPlayer(0);
			Player player4 = this.Players.GetPlayer(2);
			if (player != null)
			{
				list.Add(player);
			}
			if (player2 != null)
			{
				list.Add(player2);
			}
			if (player3 != null)
			{
				list.Add(player3);
			}
			if (player4 != null)
			{
				list.Add(player4);
			}
			return list;
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000D217C File Offset: 0x000D037C
		[ObserversRpc(RunLocally = true)]
		private void StartGame()
		{
			this.RpcWriter___Observers_StartGame_2166136261();
			this.RpcLogic___StartGame_2166136261();
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000D2198 File Offset: 0x000D0398
		[ObserversRpc(RunLocally = true)]
		private void NotifyPlayerScore(NetworkObject player, int score, bool blackjack)
		{
			this.RpcWriter___Observers_NotifyPlayerScore_2864061566(player, score, blackjack);
			this.RpcLogic___NotifyPlayerScore_2864061566(player, score, blackjack);
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000D21C9 File Offset: 0x000D03C9
		private Transform[] GetPlayerCardPositions(int playerIndex)
		{
			switch (playerIndex)
			{
			case 0:
				return this.Player1CardPositions;
			case 1:
				return this.Player2CardPositions;
			case 2:
				return this.Player3CardPositions;
			case 3:
				return this.Player4CardPositions;
			default:
				return null;
			}
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x000D2200 File Offset: 0x000D0400
		[ObserversRpc(RunLocally = true)]
		private void SetRoundEnded(bool ended)
		{
			this.RpcWriter___Observers_SetRoundEnded_1140765316(ended);
			this.RpcLogic___SetRoundEnded_1140765316(ended);
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x000D2216 File Offset: 0x000D0416
		private void AddCardToPlayerHand(int playerIndex, PlayingCard card)
		{
			this.AddCardToPlayerHand(playerIndex, card.CardID);
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x000D2228 File Offset: 0x000D0428
		[ObserversRpc(RunLocally = true)]
		private void AddCardToPlayerHand(int playerindex, string cardID)
		{
			this.RpcWriter___Observers_AddCardToPlayerHand_2801973956(playerindex, cardID);
			this.RpcLogic___AddCardToPlayerHand_2801973956(playerindex, cardID);
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000D2254 File Offset: 0x000D0454
		[ObserversRpc(RunLocally = true)]
		private void AddCardToDealerHand(string cardID)
		{
			this.RpcWriter___Observers_AddCardToDealerHand_3615296227(cardID);
			this.RpcLogic___AddCardToDealerHand_3615296227(cardID);
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000D2275 File Offset: 0x000D0475
		private List<PlayingCard> GetPlayerCards(int playerIndex)
		{
			switch (playerIndex)
			{
			case 0:
				return this.player1Hand;
			case 1:
				return this.player2Hand;
			case 2:
				return this.player3Hand;
			case 3:
				return this.player4Hand;
			default:
				return null;
			}
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x000D22AC File Offset: 0x000D04AC
		private int GetHandScore(List<PlayingCard> cards, bool countFaceDown = true)
		{
			int num = 0;
			foreach (PlayingCard playingCard in cards)
			{
				if (countFaceDown || playingCard.IsFaceUp)
				{
					num += this.GetCardValue(playingCard, true);
				}
			}
			if (num > 21)
			{
				using (List<PlayingCard>.Enumerator enumerator = cards.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Value == PlayingCard.ECardValue.Ace)
						{
							num -= 10;
						}
						if (num <= 21)
						{
							break;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x000D235C File Offset: 0x000D055C
		private int GetCardValue(PlayingCard card, bool aceAsEleven = true)
		{
			if (card.Value == PlayingCard.ECardValue.Ace)
			{
				if (!aceAsEleven)
				{
					return 1;
				}
				return 11;
			}
			else
			{
				if (card.Value == PlayingCard.ECardValue.Jack || card.Value == PlayingCard.ECardValue.Queen || card.Value == PlayingCard.ECardValue.King)
				{
					return 10;
				}
				return (int)card.Value;
			}
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000D2398 File Offset: 0x000D0598
		private PlayingCard DrawCard()
		{
			PlayingCard playingCard = this.playStack[0];
			this.playStack.RemoveAt(0);
			PlayingCard.CardData cardData = this.cardValuesInDeck[Random.Range(0, this.cardValuesInDeck.Count)];
			this.cardValuesInDeck.Remove(cardData);
			this.drawnCardsValues.Add(cardData);
			playingCard.SetCard(cardData.Suit, cardData.Value, true);
			return playingCard;
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000D2408 File Offset: 0x000D0608
		private void ResetCards()
		{
			if (InstanceFinder.IsServer)
			{
				for (int i = 0; i < this.Cards.Length; i++)
				{
					this.Cards[i].SetFaceUp(false, true);
					this.Cards[i].GlideTo(this.DefaultCardPositions[i].position, this.DefaultCardPositions[i].rotation, 0.5f, true);
				}
			}
			this.cardValuesInDeck = new List<PlayingCard.CardData>();
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 13; k++)
				{
					PlayingCard.CardData item = default(PlayingCard.CardData);
					item.Suit = (PlayingCard.ECardSuit)j;
					item.Value = k + PlayingCard.ECardValue.Ace;
					this.cardValuesInDeck.Add(item);
				}
			}
			this.playStack = new List<PlayingCard>();
			this.playStack.AddRange(this.Cards);
			this.player1Hand.Clear();
			this.player2Hand.Clear();
			this.player3Hand.Clear();
			this.player4Hand.Clear();
			this.dealerHand.Clear();
			this.drawnCardsValues.Clear();
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x000D2513 File Offset: 0x000D0713
		[ObserversRpc(RunLocally = true)]
		private void EndGame()
		{
			this.RpcWriter___Observers_EndGame_2166136261();
			this.RpcLogic___EndGame_2166136261();
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x000D2524 File Offset: 0x000D0724
		public void RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType payout, float cameraDelay = 0f)
		{
			BlackjackGameController.<>c__DisplayClass83_0 CS$<>8__locals1 = new BlackjackGameController.<>c__DisplayClass83_0();
			CS$<>8__locals1.cameraDelay = cameraDelay;
			CS$<>8__locals1.<>4__this = this;
			this.RequestRemovePlayerFromCurrentRound(Player.Local.NetworkObject);
			this.Players.SetPlayerScore(Player.Local, 0);
			float payout2 = this.GetPayout(this.LocalPlayerBet, payout);
			if (payout2 > 0f)
			{
				NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(payout2, true, false);
			}
			if (this.onLocalPlayerRoundCompleted != null)
			{
				this.onLocalPlayerRoundCompleted(payout);
			}
			if (this.onLocalPlayerExitRound != null)
			{
				this.onLocalPlayerExitRound();
			}
			base.StartCoroutine(CS$<>8__locals1.<RemoveLocalPlayerFromGame>g__Wait|0());
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x000D25BD File Offset: 0x000D07BD
		public float GetPayout(float bet, BlackjackGameController.EPayoutType payout)
		{
			switch (payout)
			{
			case BlackjackGameController.EPayoutType.Blackjack:
				return bet * 2.5f;
			case BlackjackGameController.EPayoutType.Win:
				return bet * 2f;
			case BlackjackGameController.EPayoutType.Push:
				return bet;
			default:
				return 0f;
			}
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x000D25EC File Offset: 0x000D07EC
		private bool IsCurrentRoundEmpty()
		{
			return this.playersInCurrentRound.Count == 0;
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x000D25FC File Offset: 0x000D07FC
		[ObserversRpc(RunLocally = true)]
		private void AddPlayerToCurrentRound(NetworkObject player)
		{
			this.RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(player);
			this.RpcLogic___AddPlayerToCurrentRound_3323014238(player);
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x000D261D File Offset: 0x000D081D
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			this.RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(player);
			this.RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(player);
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x000D2634 File Offset: 0x000D0834
		[ObserversRpc(RunLocally = true)]
		private void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			this.RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(player);
			this.RpcLogic___RemovePlayerFromCurrentRound_3323014238(player);
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x000D2655 File Offset: 0x000D0855
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

		// Token: 0x060032B8 RID: 12984 RVA: 0x000D267A File Offset: 0x000D087A
		public bool AreAllPlayersReady()
		{
			return this.Players.CurrentPlayerCount != 0 && this.GetPlayersReadyCount() == this.Players.CurrentPlayerCount;
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x000D26A0 File Offset: 0x000D08A0
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

		// Token: 0x060032BA RID: 12986 RVA: 0x000D26F8 File Offset: 0x000D08F8
		public void ToggleLocalPlayerReady()
		{
			bool flag = base.LocalPlayerData.GetData<bool>("Ready");
			flag = !flag;
			base.LocalPlayerData.SetData<bool>("Ready", flag, true);
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x000D27B4 File Offset: 0x000D09B4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterObserversRpc(0U, new ClientRpcDelegate(this.RpcReader___Observers_StartGame_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_NotifyPlayerScore_2864061566));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_SetRoundEnded_1140765316));
			base.RegisterObserversRpc(3U, new ClientRpcDelegate(this.RpcReader___Observers_AddCardToPlayerHand_2801973956));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_AddCardToDealerHand_3615296227));
			base.RegisterObserversRpc(5U, new ClientRpcDelegate(this.RpcReader___Observers_EndGame_2166136261));
			base.RegisterObserversRpc(6U, new ClientRpcDelegate(this.RpcReader___Observers_AddPlayerToCurrentRound_3323014238));
			base.RegisterServerRpc(7U, new ServerRpcDelegate(this.RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238));
			base.RegisterObserversRpc(8U, new ClientRpcDelegate(this.RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238));
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x000D28A7 File Offset: 0x000D0AA7
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x000D28C0 File Offset: 0x000D0AC0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x000D28D0 File Offset: 0x000D0AD0
		private void RpcWriter___Observers_StartGame_2166136261()
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
			base.SendObserversRpc(0U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x000D297C File Offset: 0x000D0B7C
		private void RpcLogic___StartGame_2166136261()
		{
			BlackjackGameController.<>c__DisplayClass70_0 CS$<>8__locals1 = new BlackjackGameController.<>c__DisplayClass70_0();
			CS$<>8__locals1.<>4__this = this;
			this.ResetCards();
			this.CurrentStage = BlackjackGameController.EStage.Dealing;
			this.PlayerTurn = null;
			this.IsLocalPlayerBlackjack = false;
			this.IsLocalPlayerBust = false;
			if (InstanceFinder.IsServer)
			{
				this.SetRoundEnded(false);
			}
			if (this.IsLocalPlayerInCurrentRound)
			{
				NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.LocalPlayerBet, true, false);
				this.Players.SetPlayerScore(Player.Local, Mathf.RoundToInt(this.LocalPlayerBet));
				base.LocalPlayerData.SetData<bool>("Ready", false, true);
			}
			CS$<>8__locals1.clockwisePlayers = this.GetClockwisePlayers();
			if (this.gameRoutine != null)
			{
				Console.LogWarning("Game routine already running, stopping...", null);
				base.StopCoroutine(this.gameRoutine);
			}
			this.gameRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<StartGame>g__GameRoutine|0());
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x000D2A50 File Offset: 0x000D0C50
		private void RpcReader___Observers_StartGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___StartGame_2166136261();
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x000D2A7C File Offset: 0x000D0C7C
		private void RpcWriter___Observers_NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
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
			writer.WriteInt32(score, AutoPackType.Packed);
			writer.WriteBoolean(blackjack);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x000D2B54 File Offset: 0x000D0D54
		private void RpcLogic___NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
			Player component = player.GetComponent<Player>();
			if (component == null)
			{
				return;
			}
			if (component.IsLocalPlayer)
			{
				this.LocalPlayerScore = score;
				this.IsLocalPlayerBlackjack = blackjack;
				if (score > 21)
				{
					this.IsLocalPlayerBust = true;
				}
			}
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x000D2B94 File Offset: 0x000D0D94
		private void RpcReader___Observers_NotifyPlayerScore_2864061566(PooledReader PooledReader0, Channel channel)
		{
			NetworkObject player = PooledReader0.ReadNetworkObject();
			int score = PooledReader0.ReadInt32(AutoPackType.Packed);
			bool blackjack = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___NotifyPlayerScore_2864061566(player, score, blackjack);
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000D2BF8 File Offset: 0x000D0DF8
		private void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended)
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
			writer.WriteBoolean(ended);
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x000D2CAE File Offset: 0x000D0EAE
		private void RpcLogic___SetRoundEnded_1140765316(bool ended)
		{
			this.roundEnded = ended;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x000D2CB8 File Offset: 0x000D0EB8
		private void RpcReader___Observers_SetRoundEnded_1140765316(PooledReader PooledReader0, Channel channel)
		{
			bool ended = PooledReader0.ReadBoolean();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___SetRoundEnded_1140765316(ended);
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x000D2CF4 File Offset: 0x000D0EF4
		private void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID)
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
			writer.WriteInt32(playerindex, AutoPackType.Packed);
			writer.WriteString(cardID);
			base.SendObserversRpc(3U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x000D2DBC File Offset: 0x000D0FBC
		private void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
			PlayingCard playingCard = this.Cards.FirstOrDefault((PlayingCard x) => x.CardID == cardID);
			if (playingCard == null)
			{
				return;
			}
			switch (playerindex)
			{
			case 0:
				if (!this.player1Hand.Contains(playingCard))
				{
					this.player1Hand.Add(playingCard);
					return;
				}
				break;
			case 1:
				if (!this.player2Hand.Contains(playingCard))
				{
					this.player2Hand.Add(playingCard);
					return;
				}
				break;
			case 2:
				if (!this.player3Hand.Contains(playingCard))
				{
					this.player3Hand.Add(playingCard);
					return;
				}
				break;
			case 3:
				if (!this.player4Hand.Contains(playingCard))
				{
					this.player4Hand.Add(playingCard);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000D2E7C File Offset: 0x000D107C
		private void RpcReader___Observers_AddCardToPlayerHand_2801973956(PooledReader PooledReader0, Channel channel)
		{
			int playerindex = PooledReader0.ReadInt32(AutoPackType.Packed);
			string cardID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___AddCardToPlayerHand_2801973956(playerindex, cardID);
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000D2ED0 File Offset: 0x000D10D0
		private void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID)
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
			writer.WriteString(cardID);
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x000D2F88 File Offset: 0x000D1188
		private void RpcLogic___AddCardToDealerHand_3615296227(string cardID)
		{
			PlayingCard playingCard = this.Cards.FirstOrDefault((PlayingCard x) => x.CardID == cardID);
			if (playingCard == null)
			{
				return;
			}
			if (!this.dealerHand.Contains(playingCard))
			{
				this.dealerHand.Add(playingCard);
			}
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x000D2FE0 File Offset: 0x000D11E0
		private void RpcReader___Observers_AddCardToDealerHand_3615296227(PooledReader PooledReader0, Channel channel)
		{
			string cardID = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___AddCardToDealerHand_3615296227(cardID);
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x000D301C File Offset: 0x000D121C
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
			base.SendObserversRpc(5U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x000D30C5 File Offset: 0x000D12C5
		private void RpcLogic___EndGame_2166136261()
		{
			this.PlayerTurn = null;
			this.CurrentStage = BlackjackGameController.EStage.WaitingForPlayers;
			this.ResetCards();
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x000D30DC File Offset: 0x000D12DC
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

		// Token: 0x060032D1 RID: 13009 RVA: 0x000D3108 File Offset: 0x000D1308
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
			base.SendObserversRpc(6U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000D31C0 File Offset: 0x000D13C0
		private void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			Player component = player.GetComponent<Player>();
			if (component == null)
			{
				return;
			}
			Console.Log("Adding player to current round: " + component.PlayerName, null);
			if (!this.playersInCurrentRound.Contains(component))
			{
				this.playersInCurrentRound.Add(component);
			}
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x000D3210 File Offset: 0x000D1410
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

		// Token: 0x060032D4 RID: 13012 RVA: 0x000D324C File Offset: 0x000D144C
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
			base.SendServerRpc(7U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x000D32F3 File Offset: 0x000D14F3
		private void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			this.RemovePlayerFromCurrentRound(player);
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000D32FC File Offset: 0x000D14FC
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

		// Token: 0x060032D7 RID: 13015 RVA: 0x000D333C File Offset: 0x000D153C
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
			base.SendObserversRpc(8U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x000D33F4 File Offset: 0x000D15F4
		private void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			Player component = player.GetComponent<Player>();
			if (component == null)
			{
				return;
			}
			Console.Log("Removing player from current round: " + component.PlayerName, null);
			if (this.playersInCurrentRound.Contains(component))
			{
				this.playersInCurrentRound.Remove(component);
			}
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x000D3444 File Offset: 0x000D1644
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

		// Token: 0x060032DA RID: 13018 RVA: 0x000D347F File Offset: 0x000D167F
		protected virtual void dll()
		{
			base.Awake();
			this.ResetCards();
		}

		// Token: 0x0400242C RID: 9260
		public const int BET_MINIMUM = 10;

		// Token: 0x0400242D RID: 9261
		public const int BET_MAXIMUM = 1000;

		// Token: 0x0400242E RID: 9262
		public const float PAYOUT_RATIO = 1f;

		// Token: 0x0400242F RID: 9263
		public const float BLACKJACK_PAYOUT_RATIO = 1.5f;

		// Token: 0x04002437 RID: 9271
		[Header("References")]
		public PlayingCard[] Cards;

		// Token: 0x04002438 RID: 9272
		public Transform[] DefaultCardPositions;

		// Token: 0x04002439 RID: 9273
		public Transform[] FocusedCameraTransforms;

		// Token: 0x0400243A RID: 9274
		public Transform[] FinalCameraTransforms;

		// Token: 0x0400243B RID: 9275
		public Transform[] Player1CardPositions;

		// Token: 0x0400243C RID: 9276
		public Transform[] Player2CardPositions;

		// Token: 0x0400243D RID: 9277
		public Transform[] Player3CardPositions;

		// Token: 0x0400243E RID: 9278
		public Transform[] Player4CardPositions;

		// Token: 0x0400243F RID: 9279
		public Transform[] DealerCardPositions;

		// Token: 0x04002440 RID: 9280
		private List<Player> playersInCurrentRound = new List<Player>();

		// Token: 0x04002441 RID: 9281
		private List<PlayingCard> playStack = new List<PlayingCard>();

		// Token: 0x04002442 RID: 9282
		private List<PlayingCard> player1Hand = new List<PlayingCard>();

		// Token: 0x04002443 RID: 9283
		private List<PlayingCard> player2Hand = new List<PlayingCard>();

		// Token: 0x04002444 RID: 9284
		private List<PlayingCard> player3Hand = new List<PlayingCard>();

		// Token: 0x04002445 RID: 9285
		private List<PlayingCard> player4Hand = new List<PlayingCard>();

		// Token: 0x04002446 RID: 9286
		private List<PlayingCard> dealerHand = new List<PlayingCard>();

		// Token: 0x04002447 RID: 9287
		private List<PlayingCard.CardData> cardValuesInDeck = new List<PlayingCard.CardData>();

		// Token: 0x04002448 RID: 9288
		private List<PlayingCard.CardData> drawnCardsValues = new List<PlayingCard.CardData>();

		// Token: 0x04002449 RID: 9289
		protected Transform localFocusCameraTransform;

		// Token: 0x0400244A RID: 9290
		protected Transform localFinalCameraTransform;

		// Token: 0x0400244B RID: 9291
		public Action onLocalPlayerBetChange;

		// Token: 0x0400244C RID: 9292
		public Action onLocalPlayerExitRound;

		// Token: 0x0400244D RID: 9293
		public Action onInitialCardsDealt;

		// Token: 0x0400244E RID: 9294
		public Action onLocalPlayerReadyForInput;

		// Token: 0x0400244F RID: 9295
		public Action onLocalPlayerBust;

		// Token: 0x04002450 RID: 9296
		public Action<BlackjackGameController.EPayoutType> onLocalPlayerRoundCompleted;

		// Token: 0x04002451 RID: 9297
		private bool roundEnded;

		// Token: 0x04002452 RID: 9298
		private Coroutine gameRoutine;

		// Token: 0x04002453 RID: 9299
		private bool dll_Excuted;

		// Token: 0x04002454 RID: 9300
		private bool dll_Excuted;

		// Token: 0x02000751 RID: 1873
		public enum EStage
		{
			// Token: 0x04002456 RID: 9302
			WaitingForPlayers,
			// Token: 0x04002457 RID: 9303
			Dealing,
			// Token: 0x04002458 RID: 9304
			PlayerTurn,
			// Token: 0x04002459 RID: 9305
			DealerTurn,
			// Token: 0x0400245A RID: 9306
			Ending
		}

		// Token: 0x02000752 RID: 1874
		public enum EPayoutType
		{
			// Token: 0x0400245C RID: 9308
			None,
			// Token: 0x0400245D RID: 9309
			Blackjack,
			// Token: 0x0400245E RID: 9310
			Win,
			// Token: 0x0400245F RID: 9311
			Push
		}
	}
}
