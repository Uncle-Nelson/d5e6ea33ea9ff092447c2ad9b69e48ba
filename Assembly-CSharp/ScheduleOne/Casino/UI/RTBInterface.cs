using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Casino.UI
{
	// Token: 0x02000777 RID: 1911
	public class RTBInterface : Singleton<RTBInterface>
	{
		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x000DA31B File Offset: 0x000D851B
		// (set) Token: 0x0600343D RID: 13373 RVA: 0x000DA323 File Offset: 0x000D8523
		public RTBGameController CurrentGame { get; private set; }

		// Token: 0x0600343E RID: 13374 RVA: 0x000DA32C File Offset: 0x000D852C
		protected override void Awake()
		{
			base.Awake();
			this.BetSlider.onValueChanged.AddListener(new UnityAction<float>(this.BetSliderChanged));
			this.ReadyButton.onClick.AddListener(new UnityAction(this.ReadyButtonClicked));
			for (int i = 0; i < this.AnswerButtons.Length; i++)
			{
				int index = i;
				this.AnswerButtons[i].onClick.AddListener(new UnityAction(delegate()
				{
					this.AnswerButtonClicked(index);
				}));
			}
			this.ForfeitButton.onClick.AddListener(new UnityAction(this.ForfeitClicked));
			this.QuestionCanvasGroup.alpha = 0f;
			this.QuestionCanvasGroup.interactable = false;
			this.Canvas.enabled = false;
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x000DA400 File Offset: 0x000D8600
		private void FixedUpdate()
		{
			if (this.CurrentGame == null)
			{
				return;
			}
			this.StatusLabel.text = this.GetStatusText();
			bool data = this.CurrentGame.LocalPlayerData.GetData<bool>("Ready");
			this.BetSlider.interactable = (this.CurrentGame.CurrentStage == RTBGameController.EStage.WaitingForPlayers && !data);
			if (data)
			{
				this.BetTitleLabel.text = "Waiting for other players...";
			}
			else
			{
				this.BetTitleLabel.text = "Place your bet and press 'ready'";
			}
			if (this.CurrentGame.CurrentStage == RTBGameController.EStage.WaitingForPlayers)
			{
				this.BetContainer.gameObject.SetActive(true);
				this.RefreshReadyButton();
				return;
			}
			this.BetContainer.gameObject.SetActive(false);
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x000DA4C0 File Offset: 0x000D86C0
		private string GetStatusText()
		{
			switch (this.CurrentGame.CurrentStage)
			{
			case RTBGameController.EStage.WaitingForPlayers:
				return string.Concat(new string[]
				{
					"Waiting for players... (",
					this.CurrentGame.GetPlayersReadyCount().ToString(),
					"/",
					this.CurrentGame.Players.CurrentPlayerCount.ToString(),
					")"
				});
			case RTBGameController.EStage.RedOrBlack:
				return "Round 1\nPredict if the next card will be red or black.\nYou can also forfeit and cash out.";
			case RTBGameController.EStage.HigherOrLower:
				return "Round 2\nPredict if the next card will be higher or lower than the previous card.\nYou can also forfeit and cash out.";
			case RTBGameController.EStage.InsideOrOutside:
				return "Round 3\nPredict if the next card will be inside or outside the previous two cards (Ace counts as 11).\nYou can also forfeit and cash out.";
			case RTBGameController.EStage.Suit:
				return "Round 4\nPredict the suit of the next card.\nYou can also forfeit and cash out.";
			default:
				return "Unknown";
			}
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x000DA568 File Offset: 0x000D8768
		public void Open(RTBGameController game)
		{
			this.CurrentGame = game;
			RTBGameController currentGame = this.CurrentGame;
			currentGame.onQuestionReady = (Action<string, string[]>)Delegate.Combine(currentGame.onQuestionReady, new Action<string, string[]>(this.QuestionReady));
			RTBGameController currentGame2 = this.CurrentGame;
			currentGame2.onQuestionDone = (Action)Delegate.Combine(currentGame2.onQuestionDone, new Action(this.QuestionDone));
			RTBGameController currentGame3 = this.CurrentGame;
			currentGame3.onLocalPlayerCorrect = (Action)Delegate.Combine(currentGame3.onLocalPlayerCorrect, new Action(this.Correct));
			RTBGameController currentGame4 = this.CurrentGame;
			currentGame4.onLocalPlayerIncorrect = (Action)Delegate.Combine(currentGame4.onLocalPlayerIncorrect, new Action(this.Incorrect));
			RTBGameController currentGame5 = this.CurrentGame;
			currentGame5.onLocalPlayerBetChange = (Action)Delegate.Combine(currentGame5.onLocalPlayerBetChange, new Action(this.RefreshDisplayedBet));
			RTBGameController currentGame6 = this.CurrentGame;
			currentGame6.onLocalPlayerExitRound = (Action)Delegate.Combine(currentGame6.onLocalPlayerExitRound, new Action(this.LocalPlayerExitRound));
			this.PlayerDisplay.Bind(game.Players);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			this.Canvas.enabled = true;
			this.BetSlider.SetValueWithoutNotify(0f);
			game.SetLocalPlayerBet(10f);
			this.RefreshDisplayedBet();
			this.RefreshDisplayedBet();
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x000DA6BC File Offset: 0x000D88BC
		public void Close()
		{
			if (this.CurrentGame != null)
			{
				RTBGameController currentGame = this.CurrentGame;
				currentGame.onQuestionReady = (Action<string, string[]>)Delegate.Remove(currentGame.onQuestionReady, new Action<string, string[]>(this.QuestionReady));
				RTBGameController currentGame2 = this.CurrentGame;
				currentGame2.onQuestionDone = (Action)Delegate.Remove(currentGame2.onQuestionDone, new Action(this.QuestionDone));
				RTBGameController currentGame3 = this.CurrentGame;
				currentGame3.onLocalPlayerCorrect = (Action)Delegate.Remove(currentGame3.onLocalPlayerCorrect, new Action(this.Correct));
				RTBGameController currentGame4 = this.CurrentGame;
				currentGame4.onLocalPlayerIncorrect = (Action)Delegate.Remove(currentGame4.onLocalPlayerIncorrect, new Action(this.Incorrect));
				RTBGameController currentGame5 = this.CurrentGame;
				currentGame5.onLocalPlayerBetChange = (Action)Delegate.Remove(currentGame5.onLocalPlayerBetChange, new Action(this.RefreshDisplayedBet));
				RTBGameController currentGame6 = this.CurrentGame;
				currentGame6.onLocalPlayerExitRound = (Action)Delegate.Remove(currentGame6.onLocalPlayerExitRound, new Action(this.LocalPlayerExitRound));
			}
			this.CurrentGame = null;
			this.PlayerDisplay.Unbind();
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			this.Canvas.enabled = false;
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x000DA7EC File Offset: 0x000D89EC
		private void BetSliderChanged(float newValue)
		{
			this.CurrentGame.SetLocalPlayerBet(this.GetBetFromSliderValue(newValue));
			this.RefreshDisplayedBet();
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x000DA806 File Offset: 0x000D8A06
		private float GetBetFromSliderValue(float sliderVal)
		{
			return Mathf.Lerp(10f, 500f, Mathf.Pow(sliderVal, 2f));
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x000DA824 File Offset: 0x000D8A24
		private void RefreshDisplayedBet()
		{
			this.BetAmount.text = MoneyManager.FormatAmount(this.CurrentGame.LocalPlayerBet, false, false);
			this.BetSlider.SetValueWithoutNotify(Mathf.Sqrt(Mathf.InverseLerp(10f, 500f, this.CurrentGame.LocalPlayerBet)));
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x000DA878 File Offset: 0x000D8A78
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

		// Token: 0x06003447 RID: 13383 RVA: 0x000DA934 File Offset: 0x000D8B34
		private void QuestionReady(string question, string[] answers)
		{
			this.QuestionLabel.text = question;
			this.SelectionIndicator.gameObject.SetActive(false);
			this.ForfeitLabel.text = "Forfeit and collect " + MoneyManager.FormatAmount(this.CurrentGame.MultipliedLocalPlayerBet, false, true);
			this.QuestionCanvasGroup.interactable = true;
			for (int i = 0; i < this.AnswerButtons.Length; i++)
			{
				if (answers.Length > i)
				{
					this.AnswerLabels[i].text = answers[i];
					this.AnswerButtons[i].gameObject.SetActive(true);
				}
				else
				{
					this.AnswerButtons[i].gameObject.SetActive(false);
				}
			}
			this.QuestionContainerAnimation.Play(this.QuestionContainerFadeIn.name);
			this.TimerSlider.value = 1f;
			base.StartCoroutine(this.<QuestionReady>g__Routine|38_0());
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x000DAA18 File Offset: 0x000D8C18
		private void AnswerButtonClicked(int index)
		{
			this.SelectionIndicator.transform.position = this.AnswerButtons[index].transform.position;
			this.SelectionIndicator.gameObject.SetActive(true);
			this.CurrentGame.SetLocalPlayerAnswer((float)index + 1f);
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x000DAA6C File Offset: 0x000D8C6C
		private void ForfeitClicked()
		{
			this.SelectionIndicator.transform.position = this.ForfeitButton.transform.position;
			this.SelectionIndicator.gameObject.SetActive(true);
			this.CurrentGame.RemoveLocalPlayerFromGame(true, 0f);
			this.QuestionDone();
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x000DAAC1 File Offset: 0x000D8CC1
		private void QuestionDone()
		{
			this.QuestionCanvasGroup.interactable = false;
			this.QuestionContainerAnimation.Play(this.QuestionContainerFadeOut.name);
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x000DAAE6 File Offset: 0x000D8CE6
		private void LocalPlayerExitRound()
		{
			this.QuestionCanvasGroup.interactable = false;
			if (this.QuestionCanvasGroup.alpha > 0f)
			{
				this.QuestionContainerAnimation.Stop();
				this.QuestionCanvasGroup.alpha = 0f;
			}
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x000DAB24 File Offset: 0x000D8D24
		private void Correct()
		{
			this.WinningsMultiplierLabel.text = Mathf.RoundToInt(this.CurrentGame.LocalPlayerBetMultiplier).ToString() + "x";
			if (this.CurrentGame.CurrentStage == RTBGameController.EStage.Suit)
			{
				if (this.onFinalCorrect != null)
				{
					this.onFinalCorrect.Invoke();
					return;
				}
			}
			else if (this.onCorrect != null)
			{
				this.onCorrect.Invoke();
			}
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x000DAB93 File Offset: 0x000D8D93
		private void Incorrect()
		{
			if (this.onIncorrect != null)
			{
				this.onIncorrect.Invoke();
			}
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x000DABA8 File Offset: 0x000D8DA8
		private void ReadyButtonClicked()
		{
			this.CurrentGame.ToggleLocalPlayerReady();
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x000DABBD File Offset: 0x000D8DBD
		[CompilerGenerated]
		private IEnumerator <QuestionReady>g__Routine|38_0()
		{
			while (this.CurrentGame != null && this.CurrentGame.IsQuestionActive)
			{
				this.TimerSlider.value = this.CurrentGame.RemainingAnswerTime / 6f;
				yield return new WaitForEndOfFrame();
			}
			yield break;
		}

		// Token: 0x0400254D RID: 9549
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400254E RID: 9550
		public CasinoGamePlayerDisplay PlayerDisplay;

		// Token: 0x0400254F RID: 9551
		public TextMeshProUGUI StatusLabel;

		// Token: 0x04002550 RID: 9552
		public RectTransform BetContainer;

		// Token: 0x04002551 RID: 9553
		public TextMeshProUGUI BetTitleLabel;

		// Token: 0x04002552 RID: 9554
		public Slider BetSlider;

		// Token: 0x04002553 RID: 9555
		public TextMeshProUGUI BetAmount;

		// Token: 0x04002554 RID: 9556
		public Button ReadyButton;

		// Token: 0x04002555 RID: 9557
		public TextMeshProUGUI ReadyLabel;

		// Token: 0x04002556 RID: 9558
		public TextMeshProUGUI WinningsMultiplierLabel;

		// Token: 0x04002557 RID: 9559
		[Header("Question and answers")]
		public RectTransform QuestionContainer;

		// Token: 0x04002558 RID: 9560
		public TextMeshProUGUI QuestionLabel;

		// Token: 0x04002559 RID: 9561
		public Slider TimerSlider;

		// Token: 0x0400255A RID: 9562
		public Button[] AnswerButtons;

		// Token: 0x0400255B RID: 9563
		public TextMeshProUGUI[] AnswerLabels;

		// Token: 0x0400255C RID: 9564
		public Button ForfeitButton;

		// Token: 0x0400255D RID: 9565
		public TextMeshProUGUI ForfeitLabel;

		// Token: 0x0400255E RID: 9566
		public Animation QuestionContainerAnimation;

		// Token: 0x0400255F RID: 9567
		public AnimationClip QuestionContainerFadeIn;

		// Token: 0x04002560 RID: 9568
		public AnimationClip QuestionContainerFadeOut;

		// Token: 0x04002561 RID: 9569
		public CanvasGroup QuestionCanvasGroup;

		// Token: 0x04002562 RID: 9570
		public RectTransform SelectionIndicator;

		// Token: 0x04002563 RID: 9571
		public UnityEvent onCorrect;

		// Token: 0x04002564 RID: 9572
		public UnityEvent onFinalCorrect;

		// Token: 0x04002565 RID: 9573
		public UnityEvent onIncorrect;
	}
}
