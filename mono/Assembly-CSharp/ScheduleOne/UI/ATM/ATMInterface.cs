using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.ATM
{
	// Token: 0x02000B4C RID: 2892
	public class ATMInterface : MonoBehaviour
	{
		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06004CD5 RID: 19669 RVA: 0x00143E4E File Offset: 0x0014204E
		// (set) Token: 0x06004CD6 RID: 19670 RVA: 0x00143E56 File Offset: 0x00142056
		public bool isOpen { get; protected set; }

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x00143E5F File Offset: 0x0014205F
		private float relevantBalance
		{
			get
			{
				if (!this.depositing)
				{
					return NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance;
				}
				return NetworkSingleton<MoneyManager>.Instance.cashBalance;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x00143E7E File Offset: 0x0014207E
		private static float remainingAllowedDeposit
		{
			get
			{
				return 10000f - ATM.WeeklyDepositSum;
			}
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x00143E8C File Offset: 0x0014208C
		private void Awake()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x00143ED9 File Offset: 0x001420D9
		private void OnDestroy()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
		}

		// Token: 0x06004CDB RID: 19675 RVA: 0x00143EFC File Offset: 0x001420FC
		protected virtual void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 2);
			this.activeScreen = this.menuScreen;
			this.canvas.enabled = false;
			for (int i = 0; i < this.amountButtons.Count; i++)
			{
				int fuckYou = i;
				this.amountButtons[i].onClick.AddListener(new UnityAction(delegate()
				{
					this.AmountSelected(fuckYou);
				}));
				if (i == this.amountButtons.Count - 1)
				{
					this.amountButtons[i].transform.Find("Text").GetComponent<Text>().text = "ALL ()";
				}
				else
				{
					this.amountButtons[i].transform.Find("Text").GetComponent<Text>().text = MoneyManager.FormatAmount((float)ATMInterface.amounts[i], false, false);
				}
			}
			this.depositLimitContainer.gameObject.SetActive(true);
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x00144007 File Offset: 0x00142207
		private void PlayerSpawned()
		{
			this.canvas.worldCamera = PlayerSingleton<PlayerCamera>.Instance.Camera;
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x00144020 File Offset: 0x00142220
		protected virtual void Update()
		{
			if (this.isOpen)
			{
				this.onlineBalanceText.text = MoneyManager.FormatAmount(NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance, false, false);
				this.cleanCashText.text = MoneyManager.FormatAmount(NetworkSingleton<MoneyManager>.Instance.cashBalance, false, false);
				this.depositLimitText.text = MoneyManager.FormatAmount(ATM.WeeklyDepositSum, false, false) + " / " + MoneyManager.FormatAmount(10000f, false, false);
				if (ATM.WeeklyDepositSum >= 10000f)
				{
					this.depositLimitText.color = new Color32(byte.MaxValue, 75, 75, byte.MaxValue);
				}
				else
				{
					this.depositLimitText.color = Color.white;
				}
				if (this.activeScreen == this.amountSelectorScreen)
				{
					if (this.depositing)
					{
						this.amountButtons[this.amountButtons.Count - 1].transform.Find("Text").GetComponent<Text>().text = "MAX (" + MoneyManager.FormatAmount(Mathf.Min(NetworkSingleton<MoneyManager>.Instance.cashBalance, ATMInterface.remainingAllowedDeposit), false, false) + ")";
					}
					this.UpdateAvailableAmounts();
					this.confirmAmountButton.interactable = (this.relevantBalance > 0f);
					if (this.depositing)
					{
						if (this.selectedAmountIndex == ATMInterface.amounts.Length)
						{
							this.confirmButtonText.text = "DEPOSIT ALL";
						}
						else
						{
							this.confirmButtonText.text = "DEPOSIT " + MoneyManager.FormatAmount(this.selectedAmount, false, false);
						}
					}
					else
					{
						this.confirmButtonText.text = "WITHDRAW " + MoneyManager.FormatAmount(this.selectedAmount, false, false);
					}
					if (this.relevantBalance < ATMInterface.GetAmountFromIndex(this.selectedAmountIndex, this.depositing))
					{
						this.DefaultAmountSelection();
					}
				}
				if (this.activeScreen == this.menuScreen)
				{
					this.menu_DepositButton.interactable = (ATM.WeeklyDepositSum < 10000f);
				}
				if (this.activeScreen == this.processingScreen)
				{
					this.processingScreenIndicator.localEulerAngles = new Vector3(0f, 0f, this.processingScreenIndicator.localEulerAngles.z - Time.deltaTime * 360f);
				}
			}
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x00144278 File Offset: 0x00142478
		protected virtual void LateUpdate()
		{
			if (this.isOpen && this.activeScreen == this.amountSelectorScreen)
			{
				if (this.selectedAmountIndex == -1)
				{
					this.selectedButtonIndicator.gameObject.SetActive(false);
					return;
				}
				this.selectedButtonIndicator.anchoredPosition = this.amountButtons[this.selectedAmountIndex].GetComponent<RectTransform>().anchoredPosition;
				this.selectedButtonIndicator.gameObject.SetActive(true);
			}
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x001442F4 File Offset: 0x001424F4
		public virtual void SetIsOpen(bool o)
		{
			if (o == this.isOpen)
			{
				return;
			}
			this.isOpen = o;
			this.canvas.enabled = this.isOpen;
			EventSystem.current.SetSelectedGameObject(null);
			if (this.isOpen)
			{
				PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
				Singleton<HUD>.Instance.SetCrosshairVisible(false);
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
				this.SetActiveScreen(this.menuScreen);
				return;
			}
			this.atm.Exit();
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x00144398 File Offset: 0x00142598
		public virtual void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.isOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				if (this.activeScreen == this.menuScreen || this.activeScreen == this.successScreen)
				{
					this.SetIsOpen(false);
					return;
				}
				if (this.activeScreen == this.amountSelectorScreen)
				{
					this.SetActiveScreen(this.menuScreen);
				}
			}
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x00144414 File Offset: 0x00142614
		public void SetActiveScreen(RectTransform screen)
		{
			this.menuScreen.gameObject.SetActive(false);
			this.amountSelectorScreen.gameObject.SetActive(false);
			this.processingScreen.gameObject.SetActive(false);
			this.successScreen.gameObject.SetActive(false);
			this.activeScreen = screen;
			this.activeScreen.gameObject.SetActive(true);
			if (this.activeScreen == this.menuScreen)
			{
				this.menu_TitleText.text = "Hello, " + Player.Local.PlayerName;
				this.menu_DepositButton.Select();
				return;
			}
			if (this.activeScreen == this.amountSelectorScreen)
			{
				this.UpdateAvailableAmounts();
				this.DefaultAmountSelection();
				return;
			}
			if (this.activeScreen == this.successScreen)
			{
				this.doneButton.Select();
			}
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x001444FC File Offset: 0x001426FC
		private void DefaultAmountSelection()
		{
			if (this.amountButtons[0].interactable)
			{
				this.amountButtons[0].Select();
				this.AmountSelected(0);
				return;
			}
			if (this.amountButtons[this.amountButtons.Count - 1].interactable && this.relevantBalance > 0f)
			{
				this.amountButtons[this.amountButtons.Count - 1].Select();
				this.AmountSelected(this.amountButtons.Count - 1);
				return;
			}
			this.AmountSelected(-1);
			for (int i = 0; i < this.amountButtons.Count; i++)
			{
			}
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x001445AF File Offset: 0x001427AF
		public void DepositButtonPressed()
		{
			this.amountSelectorTitle.text = "Select amount to deposit";
			this.depositing = true;
			this.SetActiveScreen(this.amountSelectorScreen);
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x001445D4 File Offset: 0x001427D4
		public void WithdrawButtonPressed()
		{
			this.amountSelectorTitle.text = "Select amount to withdraw";
			this.depositing = false;
			this.amountButtons[this.amountButtons.Count - 1].transform.Find("Text").GetComponent<Text>().text = MoneyManager.FormatAmount((float)ATMInterface.amounts[ATMInterface.amounts.Length - 1], false, false);
			this.SetActiveScreen(this.amountSelectorScreen);
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x0014464C File Offset: 0x0014284C
		public void CancelAmountSelection()
		{
			this.SetActiveScreen(this.menuScreen);
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x0014465A File Offset: 0x0014285A
		public void AmountSelected(int amountIndex)
		{
			this.selectedAmountIndex = amountIndex;
			this.SetSelectedAmount(ATMInterface.GetAmountFromIndex(amountIndex, this.depositing));
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x00144678 File Offset: 0x00142878
		private void SetSelectedAmount(float amount)
		{
			float max;
			if (this.depositing)
			{
				max = Mathf.Min(NetworkSingleton<MoneyManager>.Instance.cashBalance, ATMInterface.remainingAllowedDeposit);
			}
			else
			{
				max = NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance;
			}
			this.selectedAmount = Mathf.Clamp(amount, 0f, max);
			this.amountLabelText.text = MoneyManager.FormatAmount(this.selectedAmount, false, false);
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x001446E0 File Offset: 0x001428E0
		public static float GetAmountFromIndex(int index, bool depositing)
		{
			if (index == -1 || index >= ATMInterface.amounts.Length)
			{
				return 0f;
			}
			if (depositing && index == ATMInterface.amounts.Length - 1)
			{
				return Mathf.Min(NetworkSingleton<MoneyManager>.Instance.cashBalance, ATMInterface.remainingAllowedDeposit);
			}
			return (float)ATMInterface.amounts[index];
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x00144730 File Offset: 0x00142930
		private void UpdateAvailableAmounts()
		{
			for (int i = 0; i < ATMInterface.amounts.Length; i++)
			{
				if (this.depositing && i == ATMInterface.amounts.Length - 1)
				{
					this.amountButtons[this.amountButtons.Count - 1].interactable = (this.relevantBalance > 0f && ATMInterface.remainingAllowedDeposit > 0f);
					return;
				}
				if (this.depositing)
				{
					this.amountButtons[i].interactable = (this.relevantBalance >= (float)ATMInterface.amounts[i] && ATM.WeeklyDepositSum + (float)ATMInterface.amounts[i] <= 10000f);
				}
				else
				{
					this.amountButtons[i].interactable = (this.relevantBalance >= (float)ATMInterface.amounts[i]);
				}
			}
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x0014480D File Offset: 0x00142A0D
		public void AmountConfirmed()
		{
			base.StartCoroutine(this.ProcessTransaction(this.selectedAmount, this.depositing));
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x00144828 File Offset: 0x00142A28
		public void ChangeAmount(float amount)
		{
			this.selectedAmountIndex = -1;
			this.SetSelectedAmount(this.selectedAmount + amount);
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x0014483F File Offset: 0x00142A3F
		protected IEnumerator ProcessTransaction(float amount, bool depositing)
		{
			this.SetActiveScreen(this.processingScreen);
			yield return new WaitForSeconds(1f);
			this.CompleteSound.Play();
			if (depositing)
			{
				if (NetworkSingleton<MoneyManager>.Instance.cashBalance >= amount)
				{
					NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-amount, true, false);
					NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Cash Deposit", amount, 1f, string.Empty);
					ATM.WeeklyDepositSum += amount;
					this.successScreenSubtitle.text = "You have deposited " + MoneyManager.FormatAmount(amount, false, false);
					this.SetActiveScreen(this.successScreen);
				}
				else
				{
					this.SetActiveScreen(this.menuScreen);
				}
			}
			else if (NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= amount)
			{
				NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(amount, true, false);
				NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Cash Withdrawal", -amount, 1f, string.Empty);
				this.successScreenSubtitle.text = "You have withdrawn " + MoneyManager.FormatAmount(amount, false, false);
				this.SetActiveScreen(this.successScreen);
			}
			else
			{
				this.SetActiveScreen(this.menuScreen);
			}
			yield break;
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x0014485C File Offset: 0x00142A5C
		public void DoneButtonPressed()
		{
			this.SetIsOpen(false);
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x0014464C File Offset: 0x0014284C
		public void ReturnToMenuButtonPressed()
		{
			this.SetActiveScreen(this.menuScreen);
		}

		// Token: 0x040039E3 RID: 14819
		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x040039E4 RID: 14820
		[SerializeField]
		protected ATM atm;

		// Token: 0x040039E5 RID: 14821
		[SerializeField]
		protected AudioSourceController CompleteSound;

		// Token: 0x040039E6 RID: 14822
		[Header("Menu")]
		[SerializeField]
		protected RectTransform menuScreen;

		// Token: 0x040039E7 RID: 14823
		[SerializeField]
		protected Text menu_TitleText;

		// Token: 0x040039E8 RID: 14824
		[SerializeField]
		protected Button menu_DepositButton;

		// Token: 0x040039E9 RID: 14825
		[SerializeField]
		protected Button menu_WithdrawButton;

		// Token: 0x040039EA RID: 14826
		[Header("Top bar")]
		[SerializeField]
		protected Text depositLimitText;

		// Token: 0x040039EB RID: 14827
		[SerializeField]
		protected Text onlineBalanceText;

		// Token: 0x040039EC RID: 14828
		[SerializeField]
		protected Text cleanCashText;

		// Token: 0x040039ED RID: 14829
		[SerializeField]
		protected RectTransform depositLimitContainer;

		// Token: 0x040039EE RID: 14830
		[Header("Amount screen")]
		[SerializeField]
		protected RectTransform amountSelectorScreen;

		// Token: 0x040039EF RID: 14831
		[SerializeField]
		protected Text amountSelectorTitle;

		// Token: 0x040039F0 RID: 14832
		[SerializeField]
		protected List<Button> amountButtons = new List<Button>();

		// Token: 0x040039F1 RID: 14833
		[SerializeField]
		protected Text amountLabelText;

		// Token: 0x040039F2 RID: 14834
		[SerializeField]
		protected RectTransform amountBackground;

		// Token: 0x040039F3 RID: 14835
		[SerializeField]
		protected RectTransform selectedButtonIndicator;

		// Token: 0x040039F4 RID: 14836
		[SerializeField]
		protected Button confirmAmountButton;

		// Token: 0x040039F5 RID: 14837
		[SerializeField]
		protected Text confirmButtonText;

		// Token: 0x040039F6 RID: 14838
		[Header("Processing screen")]
		[SerializeField]
		protected RectTransform processingScreen;

		// Token: 0x040039F7 RID: 14839
		[SerializeField]
		protected RectTransform processingScreenIndicator;

		// Token: 0x040039F8 RID: 14840
		[Header("Success screen")]
		[SerializeField]
		protected RectTransform successScreen;

		// Token: 0x040039F9 RID: 14841
		[SerializeField]
		protected Text successScreenSubtitle;

		// Token: 0x040039FA RID: 14842
		[SerializeField]
		protected Button doneButton;

		// Token: 0x040039FC RID: 14844
		private RectTransform activeScreen;

		// Token: 0x040039FD RID: 14845
		public static int[] amounts = new int[]
		{
			20,
			50,
			100,
			500,
			1000,
			5000
		};

		// Token: 0x040039FE RID: 14846
		private bool depositing = true;

		// Token: 0x040039FF RID: 14847
		private int selectedAmountIndex;

		// Token: 0x04003A00 RID: 14848
		private float selectedAmount;
	}
}
