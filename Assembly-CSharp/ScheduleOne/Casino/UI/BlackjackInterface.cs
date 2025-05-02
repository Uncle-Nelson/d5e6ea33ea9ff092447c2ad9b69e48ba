using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Casino.UI
{
	// Token: 0x02000775 RID: 1909
	public class BlackjackInterface : Singleton<BlackjackInterface>
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06003423 RID: 13347 RVA: 0x000D97EA File Offset: 0x000D79EA
		// (set) Token: 0x06003424 RID: 13348 RVA: 0x000D97F2 File Offset: 0x000D79F2
		public BlackjackGameController CurrentGame { get; private set; }

		// Token: 0x06003425 RID: 13349 RVA: 0x000D97FC File Offset: 0x000D79FC
		protected override void Awake()
		{
			base.Awake();
			this.BetSlider.onValueChanged.AddListener(new UnityAction<float>(this.BetSliderChanged));
			this.ReadyButton.onClick.AddListener(new UnityAction(this.ReadyButtonClicked));
			this.HitButton.onClick.AddListener(new UnityAction(this.HitClicked));
			this.StandButton.onClick.AddListener(new UnityAction(this.StandClicked));
			this.InputContainerCanvasGroup.alpha = 0f;
			this.InputContainerCanvasGroup.interactable = false;
			this.ScoresContainerCanvasGroup.alpha = 0f;
			this.Canvas.enabled = false;
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x000D98B8 File Offset: 0x000D7AB8
		private void FixedUpdate()
		{
			if (this.CurrentGame == null)
			{
				return;
			}
			bool data = this.CurrentGame.LocalPlayerData.GetData<bool>("Ready");
			this.BetSlider.interactable = (this.CurrentGame.CurrentStage == BlackjackGameController.EStage.WaitingForPlayers && !data);
			if (data)
			{
				this.BetTitleLabel.text = "Waiting for other players...";
			}
			else
			{
				this.BetTitleLabel.text = "Place your bet and press 'ready'";
			}
			if (this.CurrentGame.CurrentStage == BlackjackGameController.EStage.WaitingForPlayers)
			{
				this.BetContainer.gameObject.SetActive(true);
				this.RefreshReadyButton();
			}
			else
			{
				this.BetContainer.gameObject.SetActive(false);
			}
			this.PlayerScoreLabel.text = this.CurrentGame.LocalPlayerScore.ToString();
			if (this.CurrentGame.CurrentStage == BlackjackGameController.EStage.DealerTurn || this.CurrentGame.CurrentStage == BlackjackGameController.EStage.Ending)
			{
				this.DealerScoreLabel.text = this.CurrentGame.DealerScore.ToString();
			}
			else
			{
				this.DealerScoreLabel.text = this.CurrentGame.DealerScore.ToString() + "+?";
			}
			if (this.CurrentGame.CurrentStage == BlackjackGameController.EStage.PlayerTurn && this.CurrentGame.PlayerTurn != null)
			{
				if (this.CurrentGame.PlayerTurn.IsLocalPlayer)
				{
					this.WaitingLabel.text = "Your turn!";
				}
				else
				{
					this.WaitingLabel.text = "Waiting for " + this.CurrentGame.PlayerTurn.PlayerName + "...";
				}
				this.WaitingContainer.gameObject.SetActive(true);
				return;
			}
			if (this.CurrentGame.CurrentStage == BlackjackGameController.EStage.DealerTurn)
			{
				this.WaitingLabel.text = "Dealer's turn...";
				this.WaitingContainer.gameObject.SetActive(true);
				return;
			}
			this.WaitingContainer.gameObject.SetActive(false);
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x000D9AAC File Offset: 0x000D7CAC
		public void Open(BlackjackGameController game)
		{
			this.CurrentGame = game;
			BlackjackGameController currentGame = this.CurrentGame;
			currentGame.onLocalPlayerBetChange = (Action)Delegate.Combine(currentGame.onLocalPlayerBetChange, new Action(this.RefreshDisplayedBet));
			BlackjackGameController currentGame2 = this.CurrentGame;
			currentGame2.onLocalPlayerExitRound = (Action)Delegate.Combine(currentGame2.onLocalPlayerExitRound, new Action(this.LocalPlayerExitRound));
			BlackjackGameController currentGame3 = this.CurrentGame;
			currentGame3.onInitialCardsDealt = (Action)Delegate.Combine(currentGame3.onInitialCardsDealt, new Action(this.ShowScores));
			BlackjackGameController currentGame4 = this.CurrentGame;
			currentGame4.onLocalPlayerReadyForInput = (Action)Delegate.Combine(currentGame4.onLocalPlayerReadyForInput, new Action(this.LocalPlayerReadyForInput));
			BlackjackGameController currentGame5 = this.CurrentGame;
			currentGame5.onLocalPlayerBust = (Action)Delegate.Combine(currentGame5.onLocalPlayerBust, new Action(this.OnLocalPlayerBust));
			BlackjackGameController currentGame6 = this.CurrentGame;
			currentGame6.onLocalPlayerRoundCompleted = (Action<BlackjackGameController.EPayoutType>)Delegate.Combine(currentGame6.onLocalPlayerRoundCompleted, new Action<BlackjackGameController.EPayoutType>(this.OnLocalPlayerRoundCompleted));
			this.PlayerDisplay.Bind(game.Players);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			this.Canvas.enabled = true;
			this.BetSlider.SetValueWithoutNotify(0f);
			game.SetLocalPlayerBet(10f);
			this.RefreshDisplayedBet();
			this.RefreshDisplayedBet();
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x000D9C00 File Offset: 0x000D7E00
		public void Close()
		{
			if (this.CurrentGame != null)
			{
				BlackjackGameController currentGame = this.CurrentGame;
				currentGame.onLocalPlayerBetChange = (Action)Delegate.Remove(currentGame.onLocalPlayerBetChange, new Action(this.RefreshDisplayedBet));
				BlackjackGameController currentGame2 = this.CurrentGame;
				currentGame2.onLocalPlayerExitRound = (Action)Delegate.Remove(currentGame2.onLocalPlayerExitRound, new Action(this.LocalPlayerExitRound));
				BlackjackGameController currentGame3 = this.CurrentGame;
				currentGame3.onInitialCardsDealt = (Action)Delegate.Remove(currentGame3.onInitialCardsDealt, new Action(this.ShowScores));
				BlackjackGameController currentGame4 = this.CurrentGame;
				currentGame4.onLocalPlayerReadyForInput = (Action)Delegate.Remove(currentGame4.onLocalPlayerReadyForInput, new Action(this.LocalPlayerReadyForInput));
				BlackjackGameController currentGame5 = this.CurrentGame;
				currentGame5.onLocalPlayerBust = (Action)Delegate.Remove(currentGame5.onLocalPlayerBust, new Action(this.OnLocalPlayerBust));
				BlackjackGameController currentGame6 = this.CurrentGame;
				currentGame6.onLocalPlayerRoundCompleted = (Action<BlackjackGameController.EPayoutType>)Delegate.Remove(currentGame6.onLocalPlayerRoundCompleted, new Action<BlackjackGameController.EPayoutType>(this.OnLocalPlayerRoundCompleted));
			}
			this.CurrentGame = null;
			this.PlayerDisplay.Unbind();
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			this.Canvas.enabled = false;
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000D9D30 File Offset: 0x000D7F30
		private void BetSliderChanged(float newValue)
		{
			this.CurrentGame.SetLocalPlayerBet(this.GetBetFromSliderValue(newValue));
			this.RefreshDisplayedBet();
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000D9D4A File Offset: 0x000D7F4A
		private float GetBetFromSliderValue(float sliderVal)
		{
			return Mathf.Lerp(10f, 1000f, Mathf.Pow(sliderVal, 2f));
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x000D9D68 File Offset: 0x000D7F68
		private void RefreshDisplayedBet()
		{
			this.BetAmount.text = MoneyManager.FormatAmount(this.CurrentGame.LocalPlayerBet, false, false);
			this.BetSlider.SetValueWithoutNotify(Mathf.Sqrt(Mathf.InverseLerp(10f, 1000f, this.CurrentGame.LocalPlayerBet)));
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x000D9DBC File Offset: 0x000D7FBC
		private void RefreshReadyButton()
		{
			if (NetworkSingleton<MoneyManager>.Instance.cashBalance >= this.CurrentGame.LocalPlayerBet)
			{
				this.ReadyButton.interactable = true;
				this.BetAmount.color = new Color32(84, 231, 23, byte.MaxValue);
			}
			else
			{
				this.ReadyButton.interactable = false;
				this.BetAmount.color = new Color32(231, 52, 23, byte.MaxValue);
			}
			if (this.CurrentGame.LocalPlayerData.GetData<bool>("Ready"))
			{
				this.ReadyLabel.text = "Cancel";
				return;
			}
			this.ReadyLabel.text = "Ready";
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x000D9E78 File Offset: 0x000D8078
		private void LocalPlayerReadyForInput()
		{
			this.SelectionIndicator.gameObject.SetActive(false);
			this.InputContainerCanvasGroup.interactable = true;
			this.InputContainerAnimation.Play(this.InputContainerFadeIn.name);
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x000D9EAE File Offset: 0x000D80AE
		private void ShowScores()
		{
			this.ScoresContainerAnimation.Play(this.InputContainerFadeIn.name);
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x000D9EC7 File Offset: 0x000D80C7
		private void HideScores()
		{
			this.ScoresContainerAnimation.Play(this.InputContainerFadeOut.name);
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x000D9EE0 File Offset: 0x000D80E0
		private void HitClicked()
		{
			this.SelectionIndicator.transform.position = this.HitButton.transform.position;
			this.SelectionIndicator.gameObject.SetActive(true);
			this.CurrentGame.LocalPlayerData.SetData<float>("Action", 1f, true);
			this.InputContainerCanvasGroup.interactable = false;
			this.InputContainerAnimation.Play(this.InputContainerFadeOut.name);
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x000D9F5C File Offset: 0x000D815C
		private void StandClicked()
		{
			this.SelectionIndicator.transform.position = this.StandButton.transform.position;
			this.SelectionIndicator.gameObject.SetActive(true);
			this.CurrentGame.LocalPlayerData.SetData<float>("Action", 2f, true);
			this.InputContainerCanvasGroup.interactable = false;
			this.InputContainerAnimation.Play(this.InputContainerFadeOut.name);
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x000D9FD8 File Offset: 0x000D81D8
		private void LocalPlayerExitRound()
		{
			this.HideScores();
			if (this.InputContainerCanvasGroup.alpha > 0f)
			{
				this.InputContainerCanvasGroup.interactable = false;
				this.InputContainerAnimation.Play(this.InputContainerFadeOut.name);
			}
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x000DA015 File Offset: 0x000D8215
		private void ReadyButtonClicked()
		{
			this.CurrentGame.ToggleLocalPlayerReady();
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x000DA022 File Offset: 0x000D8222
		private void OnLocalPlayerBust()
		{
			if (this.onBust != null)
			{
				this.onBust.Invoke();
			}
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x000DA038 File Offset: 0x000D8238
		private void OnLocalPlayerRoundCompleted(BlackjackGameController.EPayoutType payout)
		{
			float payout2 = this.CurrentGame.GetPayout(this.CurrentGame.LocalPlayerBet, payout);
			this.PayoutLabel.text = MoneyManager.FormatAmount(payout2, false, false);
			switch (payout)
			{
			case BlackjackGameController.EPayoutType.None:
				if (!this.CurrentGame.IsLocalPlayerBust && this.onLose != null)
				{
					this.onLose.Invoke();
					return;
				}
				break;
			case BlackjackGameController.EPayoutType.Blackjack:
				this.PositiveOutcomeLabel.text = "Blackjack!";
				if (this.onBlackjack != null)
				{
					this.onBlackjack.Invoke();
					return;
				}
				break;
			case BlackjackGameController.EPayoutType.Win:
				this.PositiveOutcomeLabel.text = "Win!";
				if (this.onWin != null)
				{
					this.onWin.Invoke();
					return;
				}
				break;
			case BlackjackGameController.EPayoutType.Push:
				if (this.onPush != null)
				{
					this.onPush.Invoke();
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0400252D RID: 9517
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400252E RID: 9518
		public CasinoGamePlayerDisplay PlayerDisplay;

		// Token: 0x0400252F RID: 9519
		public RectTransform BetContainer;

		// Token: 0x04002530 RID: 9520
		public TextMeshProUGUI BetTitleLabel;

		// Token: 0x04002531 RID: 9521
		public Slider BetSlider;

		// Token: 0x04002532 RID: 9522
		public TextMeshProUGUI BetAmount;

		// Token: 0x04002533 RID: 9523
		public Button ReadyButton;

		// Token: 0x04002534 RID: 9524
		public TextMeshProUGUI ReadyLabel;

		// Token: 0x04002535 RID: 9525
		public RectTransform WaitingContainer;

		// Token: 0x04002536 RID: 9526
		public TextMeshProUGUI WaitingLabel;

		// Token: 0x04002537 RID: 9527
		public TextMeshProUGUI DealerScoreLabel;

		// Token: 0x04002538 RID: 9528
		public TextMeshProUGUI PlayerScoreLabel;

		// Token: 0x04002539 RID: 9529
		public Button HitButton;

		// Token: 0x0400253A RID: 9530
		public Button StandButton;

		// Token: 0x0400253B RID: 9531
		public Animation InputContainerAnimation;

		// Token: 0x0400253C RID: 9532
		public CanvasGroup InputContainerCanvasGroup;

		// Token: 0x0400253D RID: 9533
		public AnimationClip InputContainerFadeIn;

		// Token: 0x0400253E RID: 9534
		public AnimationClip InputContainerFadeOut;

		// Token: 0x0400253F RID: 9535
		public RectTransform SelectionIndicator;

		// Token: 0x04002540 RID: 9536
		public Animation ScoresContainerAnimation;

		// Token: 0x04002541 RID: 9537
		public CanvasGroup ScoresContainerCanvasGroup;

		// Token: 0x04002542 RID: 9538
		public TextMeshProUGUI PositiveOutcomeLabel;

		// Token: 0x04002543 RID: 9539
		public TextMeshProUGUI PayoutLabel;

		// Token: 0x04002544 RID: 9540
		public UnityEvent onBust;

		// Token: 0x04002545 RID: 9541
		public UnityEvent onBlackjack;

		// Token: 0x04002546 RID: 9542
		public UnityEvent onWin;

		// Token: 0x04002547 RID: 9543
		public UnityEvent onLose;

		// Token: 0x04002548 RID: 9544
		public UnityEvent onPush;
	}
}
