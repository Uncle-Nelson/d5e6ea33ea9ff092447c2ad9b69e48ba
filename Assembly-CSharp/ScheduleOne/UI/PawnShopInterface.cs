using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Items;
using ScheduleOne.Variables;
using ScheduleOne.VoiceOver;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A13 RID: 2579
	public class PawnShopInterface : Singleton<PawnShopInterface>
	{
		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x00122F3C File Offset: 0x0012113C
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x00122F44 File Offset: 0x00121144
		public bool IsOpen { get; private set; }

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x00122F4D File Offset: 0x0012114D
		// (set) Token: 0x06004577 RID: 17783 RVA: 0x00122F55 File Offset: 0x00121155
		public float SelectedPayment { get; private set; }

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x00122F5E File Offset: 0x0012115E
		// (set) Token: 0x06004579 RID: 17785 RVA: 0x00122F66 File Offset: 0x00121166
		public float NPCAnger { get; private set; }

		// Token: 0x0600457A RID: 17786 RVA: 0x00122F70 File Offset: 0x00121170
		protected override void Awake()
		{
			base.Awake();
			this.PawnSlots = new ItemSlot[5];
			for (int i = 0; i < 5; i++)
			{
				this.PawnSlots[i] = new ItemSlot();
				this.PawnSlots[i].AddFilter(new ItemFilter_LegalStatus(ELegalStatus.Legal));
				ItemFilter_ID itemFilter_ID = new ItemFilter_ID(new List<string>
				{
					"cash"
				});
				itemFilter_ID.IsWhitelist = false;
				this.PawnSlots[i].AddFilter(itemFilter_ID);
				ItemSlot itemSlot = this.PawnSlots[i];
				itemSlot.onItemDataChanged = (Action)Delegate.Combine(itemSlot.onItemDataChanged, new Action(this.PawnSlotChanged));
				this.Slots[i].AssignSlot(this.PawnSlots[i]);
			}
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 3);
			this.StartButton.onClick.AddListener(new UnityAction(this.StartButtonPressed));
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x00123078 File Offset: 0x00121278
		protected override void Start()
		{
			base.Start();
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.OnMinPass));
			TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
			instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.OnMinPass));
			TimeManager instance3 = NetworkSingleton<TimeManager>.Instance;
			instance3.onDayPass = (Action)Delegate.Remove(instance3.onDayPass, new Action(this.OnDayPass));
			TimeManager instance4 = NetworkSingleton<TimeManager>.Instance;
			instance4.onDayPass = (Action)Delegate.Combine(instance4.onDayPass, new Action(this.OnDayPass));
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x00123124 File Offset: 0x00121324
		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.OnMinPass));
				TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
				instance2.onDayPass = (Action)Delegate.Remove(instance2.onDayPass, new Action(this.OnDayPass));
			}
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x0012318C File Offset: 0x0012138C
		public void Open()
		{
			this.IsOpen = true;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(true, true);
			Singleton<ItemUIManager>.Instance.EnableQuickMove(new List<ItemSlot>(PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots()), this.PawnSlots.ToList<ItemSlot>());
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
			this.UpdateValueRangeLabels();
			this.CurrentState = PawnShopInterface.EState.WaitingForOffer;
			this.ResetUI();
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x00123254 File Offset: 0x00121454
		public void Close(bool returnItemsToPlayer)
		{
			this.ResetUI();
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0f);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
			Singleton<ItemUIManager>.Instance.SetDraggingEnabled(false, true);
			if (this.routine != null)
			{
				base.StopCoroutine(this.routine);
				this.routine = null;
			}
			if (returnItemsToPlayer)
			{
				foreach (ItemSlot itemSlot in this.PawnSlots)
				{
					if (itemSlot.ItemInstance != null)
					{
						PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(itemSlot.ItemInstance.GetCopy(-1));
					}
				}
			}
			ItemSlot[] pawnSlots = this.PawnSlots;
			for (int i = 0; i < pawnSlots.Length; i++)
			{
				pawnSlots[i].ClearStoredInstance(false);
			}
			Singleton<HUD>.Instance.SetCrosshairVisible(true);
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x00123360 File Offset: 0x00121560
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				if (this.CurrentState == PawnShopInterface.EState.Negotiating)
				{
					this.EndNegotiation();
					return;
				}
				this.Close(true);
			}
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x0012339B File Offset: 0x0012159B
		private void OnMinPass()
		{
			this.ChangeAnger(-0.0013888889f);
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x001233A8 File Offset: 0x001215A8
		private void OnDayPass()
		{
			this.SetAngeredToday(false);
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x001233B4 File Offset: 0x001215B4
		private void Update()
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (Player.Local.CrimeData.CurrentPursuitLevel != PlayerCrimeData.EPursuitLevel.None)
			{
				this.Close(true);
				return;
			}
			if (this.CurrentState == PawnShopInterface.EState.WaitingForOffer)
			{
				this.StartButton.interactable = (this.GetPawnItems().Count > 0);
			}
			else if (this.CurrentState == PawnShopInterface.EState.Negotiating)
			{
				if (Mathf.Abs(this.SelectedPayment - this.LastShopOffer) <= 0.5f)
				{
					this.AcceptCounterButtonLabel.text = "ACCEPT";
				}
				else
				{
					this.AcceptCounterButtonLabel.text = "COUNTER";
				}
			}
			this.AngerSlider.value = Mathf.Lerp(this.AngerSlider.value, 0.1f + this.NPCAnger * 0.9f, Time.deltaTime * 2f);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x00123484 File Offset: 0x00121684
		private List<ItemInstance> GetPawnItems()
		{
			List<ItemInstance> list = new List<ItemInstance>();
			foreach (ItemSlot itemSlot in this.PawnSlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					list.Add(itemSlot.ItemInstance);
				}
			}
			return list;
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x001234C5 File Offset: 0x001216C5
		private void PawnSlotChanged()
		{
			this.UpdateValueRangeLabels();
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x001234D0 File Offset: 0x001216D0
		private void UpdateValueRangeLabels()
		{
			float num = 0f;
			float num2 = 0f;
			for (int i = 0; i < this.PawnSlots.Length; i++)
			{
				if (this.PawnSlots[i].ItemInstance == null)
				{
					this.ValueRangeLabels[i].enabled = false;
				}
				else
				{
					StorableItemDefinition storableItemDefinition = this.PawnSlots[i].ItemInstance.Definition as StorableItemDefinition;
					float num3 = storableItemDefinition.BasePurchasePrice * storableItemDefinition.ResellMultiplier * (float)this.PawnSlots[i].ItemInstance.Quantity;
					float num4 = num3 * 0.5f;
					float num5 = num3 * 2f;
					this.ValueRangeLabels[i].text = string.Format("{0} - {1}", MoneyManager.FormatAmount(num4, false, false), MoneyManager.FormatAmount(num5, false, false));
					num += num4;
					num2 += num5;
				}
			}
			this.TotalValueLabel.text = "Total: <color=#FFD755>" + string.Format("{0} - {1}", MoneyManager.FormatAmount(num, false, false), MoneyManager.FormatAmount(num2, false, false)) + "</color>";
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x001235D2 File Offset: 0x001217D2
		public void StartButtonPressed()
		{
			this.StartNegotiation();
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x001235DA File Offset: 0x001217DA
		private void StartNegotiation()
		{
			if (this.CurrentState != PawnShopInterface.EState.WaitingForOffer)
			{
				return;
			}
			this.CurrentState = PawnShopInterface.EState.Negotiating;
			this.CurrentNegotiationRound = 0;
			this.LastRefusedAmount = float.MaxValue;
			this.routine = base.StartCoroutine(this.<StartNegotiation>g__NegotiationRoutine|67_0());
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x00123610 File Offset: 0x00121810
		private void PlayShopResponse(PawnShopInterface.EShopResponse response, float counter)
		{
			switch (response)
			{
			case PawnShopInterface.EShopResponse.Accept:
			{
				string text = this.AcceptLines[Random.Range(0, this.AcceptLines.Length)];
				this.PawnShopNPC.dialogueHandler.ShowWorldspaceDialogue(text, 30f);
				return;
			}
			case PawnShopInterface.EShopResponse.Counter:
				this.CounterLines[Random.Range(0, this.CounterLines.Length)].Replace("<AMOUNT>", MoneyManager.FormatAmount(counter, false, false));
				return;
			case PawnShopInterface.EShopResponse.Refusal:
			{
				string text2 = this.RefusalLines[Random.Range(0, this.RefusalLines.Length)];
				text2 = text2.Replace("<AMOUNT>", MoneyManager.FormatAmount(counter, false, false));
				this.PawnShopNPC.dialogueHandler.ShowWorldspaceDialogue(text2, 30f);
				this.PawnShopNPC.PlayVO(EVOLineType.No);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x001236D4 File Offset: 0x001218D4
		private PawnShopInterface.EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange)
		{
			counterAmount = playerOffer;
			angerChange = 0f;
			float num = playerOffer / this.InitialShopOffer;
			float num2 = playerOffer / lastShopOffer;
			Console.Log("Original ratio: " + num.ToString() + " - Last ratio: " + num2.ToString(), null);
			float num3 = Mathf.Clamp01(2f - (num + num2) / 2f);
			float num4 = Mathf.Clamp(num3, 0f, 0.9f);
			num4 *= Mathf.Clamp01(1f - this.NPCAnger * 0.5f);
			num4 *= Mathf.Clamp01(1f - (float)this.CurrentNegotiationRound * 0.1f);
			Console.Log("Accept chance: " + num4.ToString(), null);
			float num5 = Random.Range(0f, 1f);
			angerChange = Mathf.Clamp01(1f - num3) * 0.7f;
			if (playerOffer <= lastShopOffer)
			{
				return PawnShopInterface.EShopResponse.Accept;
			}
			if (playerOffer >= this.LastRefusedAmount)
			{
				counterAmount = lastShopOffer;
				return PawnShopInterface.EShopResponse.Refusal;
			}
			if (num5 > num4)
			{
				this.LastRefusedAmount = playerOffer;
				counterAmount = lastShopOffer;
				return PawnShopInterface.EShopResponse.Refusal;
			}
			float num6 = Mathf.Sqrt(num4);
			if (Random.Range(0f, 1f) <= num6)
			{
				angerChange *= 0.5f;
				return PawnShopInterface.EShopResponse.Accept;
			}
			angerChange *= 0.75f;
			float offer = Mathf.Lerp(lastShopOffer, playerOffer, Random.Range(0f, num3));
			counterAmount = this.RoundOffer(offer);
			return PawnShopInterface.EShopResponse.Counter;
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x0012382D File Offset: 0x00121A2D
		private void EndNegotiation()
		{
			if (this.routine != null)
			{
				base.StopCoroutine(this.routine);
				this.routine = null;
			}
			this.CurrentState = PawnShopInterface.EState.WaitingForOffer;
			this.PawnShopNPC.dialogueHandler.HideWorldspaceDialogue();
			this.ResetUI();
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00123868 File Offset: 0x00121A68
		public void PaymentSubmitted(string value)
		{
			float selectedPayment;
			if (float.TryParse(value, out selectedPayment))
			{
				this.SetSelectedPayment(selectedPayment);
				return;
			}
			this.SetSelectedPayment(this.SelectedPayment);
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00123893 File Offset: 0x00121A93
		public void ChangePayment(float change)
		{
			this.SetSelectedPayment(this.SelectedPayment + change);
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x001238A4 File Offset: 0x00121AA4
		public void SetSelectedPayment(float amount)
		{
			Console.Log("Setting selected payment: " + amount.ToString(), null);
			this.SelectedPayment = (float)Mathf.RoundToInt(Mathf.Clamp(amount, 1f, 999999f));
			this.OfferInputField.SetTextWithoutNotify(this.SelectedPayment.ToString());
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x001238FD File Offset: 0x00121AFD
		public void SetPlayerResponse(PawnShopInterface.EPlayerResponse response)
		{
			Console.Log("Player response: " + response.ToString(), null);
			this.PlayerResponse = response;
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00123923 File Offset: 0x00121B23
		public void AcceptOrCounter()
		{
			if (Mathf.Abs(this.SelectedPayment - this.LastShopOffer) <= 0.5f)
			{
				this.SetPlayerResponse(PawnShopInterface.EPlayerResponse.Accept);
				return;
			}
			this.SetPlayerResponse(PawnShopInterface.EPlayerResponse.Counter);
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x0012394D File Offset: 0x00121B4D
		public void Cancel()
		{
			this.SetPlayerResponse(PawnShopInterface.EPlayerResponse.Cancel);
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x00123958 File Offset: 0x00121B58
		private void ChangeAnger(float change)
		{
			this.NPCAnger = Mathf.Clamp01(this.NPCAnger + change);
			if (this.NPCAnger >= 0.8f)
			{
				this.PawnShopNPC.Avatar.EmotionManager.AddEmotionOverride("Angry", "pawn_angry", 0f, 2);
			}
			else if (this.NPCAnger >= 0.5f)
			{
				this.PawnShopNPC.Avatar.EmotionManager.AddEmotionOverride("Annoyed", "pawn_annoyed", 0f, 1);
			}
			else
			{
				this.PawnShopNPC.Avatar.EmotionManager.RemoveEmotionOverride("pawn_angry");
				this.PawnShopNPC.Avatar.EmotionManager.RemoveEmotionOverride("pawn_annoyed");
			}
			if (this.NPCAnger >= 1f)
			{
				Console.Log("NPC is angry! Closing shop.", null);
				this.SetAngeredToday(true);
				if (Random.Range(0f, 1f) > 0.5f)
				{
					string text = this.AngeredLines[Random.Range(0, this.AngeredLines.Length)];
					this.PawnShopNPC.dialogueHandler.ShowWorldspaceDialogue(text, 5f);
				}
				else
				{
					string text2 = this.CrashOutLines[Random.Range(0, this.CrashOutLines.Length)];
					this.PawnShopNPC.dialogueHandler.ShowWorldspaceDialogue(text2, 5f);
					this.PawnShopNPC.behaviour.CombatBehaviour.SetTarget(null, Player.Local.NetworkObject);
					this.PawnShopNPC.behaviour.CombatBehaviour.Enable_Networked(null);
				}
				this.PawnShopNPC.PlayVO(EVOLineType.Angry);
				this.Close(true);
			}
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x00123AF0 File Offset: 0x00121CF0
		private void SetAngeredToday(bool angered)
		{
			Console.Log("Setting angered: " + angered.ToString(), null);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("PawnShopAngeredToday", angered.ToString(), true);
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00123B20 File Offset: 0x00121D20
		private void Think()
		{
			string text = this.ThinkLines[Random.Range(0, this.ThinkLines.Length)];
			this.PawnShopNPC.dialogueHandler.ShowWorldspaceDialogue(text, 3f);
			this.PawnShopNPC.PlayVO(EVOLineType.Think);
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00123B68 File Offset: 0x00121D68
		private void SetOffer(float amount)
		{
			Console.Log("Setting offer: " + amount.ToString(), null);
			string text = this.OfferLines[Random.Range(0, this.OfferLines.Length)];
			text = text.Replace("<AMOUNT>", MoneyManager.FormatAmount(amount, false, false));
			this.LastShopOffer = amount;
			this.SetSelectedPayment(amount);
			this.PawnShopNPC.dialogueHandler.ShowWorldspaceDialogue(text, 30f);
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00123BDC File Offset: 0x00121DDC
		private void FinalizeDeal(float amount)
		{
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(amount, true, true);
			string text = this.DealFinalizedLines[Random.Range(0, this.DealFinalizedLines.Length)];
			this.PawnShopNPC.dialogueHandler.ShowWorldspaceDialogue(text, 5f);
			this.PawnShopNPC.PlayVO(EVOLineType.Acknowledge);
			this.Close(false);
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00123C38 File Offset: 0x00121E38
		private float GetTotalValue()
		{
			float num = 0f;
			foreach (ItemSlot itemSlot in this.PawnSlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					num += this.GetItemValue(itemSlot.ItemInstance);
				}
			}
			return num;
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00123C7C File Offset: 0x00121E7C
		private float RoundOffer(float offer)
		{
			if (offer <= 25f)
			{
				return offer;
			}
			if (offer <= 100f)
			{
				return Mathf.Round(offer / 5f) * 5f;
			}
			if (offer <= 1000f)
			{
				return Mathf.Round(offer / 10f) * 10f;
			}
			if (offer <= 10000f)
			{
				return Mathf.Round(offer / 50f) * 50f;
			}
			if (offer <= 100000f)
			{
				return Mathf.Round(offer / 100f) * 100f;
			}
			if (offer <= 1000000f)
			{
				return Mathf.Round(offer / 500f) * 500f;
			}
			return Mathf.Round(offer / 1000f) * 1000f;
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00123D2C File Offset: 0x00121F2C
		private float GetItemValue(ItemInstance item)
		{
			StorableItemDefinition storableItemDefinition = item.Definition as StorableItemDefinition;
			float num = storableItemDefinition.BasePurchasePrice * storableItemDefinition.ResellMultiplier * (float)item.Quantity;
			int hashCode = (item.Name[0].ToString() + NetworkSingleton<TimeManager>.Instance.DayIndex.ToString()).GetHashCode();
			float time = Mathf.Lerp(0.5f, 2f, Mathf.InverseLerp(-2.1474836E+09f, 2.1474836E+09f, (float)hashCode));
			float num2 = this.RandomCurve.Evaluate(time);
			Console.Log("Value multiplier: " + time.ToString() + " -> " + num2.ToString(), null);
			return num * num2;
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00123DE0 File Offset: 0x00121FE0
		private void ResetUI()
		{
			this.Step1CanvasGroup.alpha = 1f;
			this.Step1CanvasGroup.interactable = true;
			this.Step1CanvasGroup.blocksRaycasts = true;
			this.Step2CanvasGroup.alpha = 0f;
			this.Step2CanvasGroup.interactable = false;
			this.Step2CanvasGroup.blocksRaycasts = false;
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00123E45 File Offset: 0x00122045
		[CompilerGenerated]
		private IEnumerator <StartNegotiation>g__NegotiationRoutine|67_0()
		{
			this.Step1Animation.Play(this.FadeOutAnim.name);
			this.Think();
			yield return new WaitForSeconds(this.Step1Animation[this.FadeOutAnim.name].length);
			yield return new WaitForSeconds(0.75f);
			this.InitialShopOffer = this.RoundOffer(this.GetTotalValue());
			this.SetOffer(this.InitialShopOffer);
			this.SetPlayerResponse(PawnShopInterface.EPlayerResponse.None);
			this.Step2Animation.Play(this.FadeInAnim.name);
			yield return new WaitUntil(() => this.PlayerResponse > PawnShopInterface.EPlayerResponse.None);
			switch (this.PlayerResponse)
			{
			case PawnShopInterface.EPlayerResponse.Accept:
				this.FinalizeDeal(this.InitialShopOffer);
				yield break;
			case PawnShopInterface.EPlayerResponse.Cancel:
				this.EndNegotiation();
				yield break;
			}
			for (;;)
			{
				this.Step2Animation.Play(this.FadeOutAnim.name);
				float counter;
				float change;
				PawnShopInterface.EShopResponse shopResponse = this.EvaluateCounter(this.LastShopOffer, this.SelectedPayment, out counter, out change);
				Console.Log(string.Concat(new string[]
				{
					"Shop response: ",
					shopResponse.ToString(),
					" - Counter: ",
					counter.ToString(),
					" - Anger change: ",
					change.ToString()
				}), null);
				this.ChangeAnger(change);
				if (this.NPCAnger >= 1f)
				{
					break;
				}
				this.Think();
				yield return new WaitForSeconds(this.Step1Animation[this.FadeOutAnim.name].length);
				yield return new WaitForSeconds(0.75f);
				this.SetOffer(counter);
				this.SetPlayerResponse(PawnShopInterface.EPlayerResponse.None);
				this.PlayShopResponse(shopResponse, counter);
				this.Step2Animation.Play(this.FadeInAnim.name);
				yield return new WaitUntil(() => this.PlayerResponse > PawnShopInterface.EPlayerResponse.None);
				switch (this.PlayerResponse)
				{
				case PawnShopInterface.EPlayerResponse.Accept:
					goto IL_2C0;
				case PawnShopInterface.EPlayerResponse.Cancel:
					goto IL_2CE;
				}
				this.CurrentNegotiationRound++;
			}
			yield break;
			IL_2C0:
			this.FinalizeDeal(this.SelectedPayment);
			yield break;
			IL_2CE:
			this.EndNegotiation();
			yield break;
			yield break;
		}

		// Token: 0x04003302 RID: 13058
		public const float PAYMENT_MIN = 1f;

		// Token: 0x04003303 RID: 13059
		public const float PAYMENT_MAX = 999999f;

		// Token: 0x04003304 RID: 13060
		public const float THINK_TIME = 0.75f;

		// Token: 0x04003305 RID: 13061
		public const float MIN_VALUE_MULTIPLIER = 0.5f;

		// Token: 0x04003306 RID: 13062
		public const float MAX_VALUE_MULTIPLIER = 2f;

		// Token: 0x04003307 RID: 13063
		public const int PAWN_SLOT_COUNT = 5;

		// Token: 0x04003309 RID: 13065
		private PawnShopInterface.EState CurrentState;

		// Token: 0x0400330A RID: 13066
		private PawnShopInterface.EPlayerResponse PlayerResponse;

		// Token: 0x0400330B RID: 13067
		private int CurrentNegotiationRound;

		// Token: 0x0400330C RID: 13068
		private float InitialShopOffer;

		// Token: 0x0400330D RID: 13069
		private float LastShopOffer;

		// Token: 0x0400330E RID: 13070
		private float LastRefusedAmount;

		// Token: 0x0400330F RID: 13071
		public NPC PawnShopNPC;

		// Token: 0x04003312 RID: 13074
		public AnimationCurve RandomCurve;

		// Token: 0x04003313 RID: 13075
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003314 RID: 13076
		public RectTransform Container;

		// Token: 0x04003315 RID: 13077
		public ItemSlotUI[] Slots;

		// Token: 0x04003316 RID: 13078
		public TextMeshProUGUI[] ValueRangeLabels;

		// Token: 0x04003317 RID: 13079
		public TextMeshProUGUI TotalValueLabel;

		// Token: 0x04003318 RID: 13080
		public Button StartButton;

		// Token: 0x04003319 RID: 13081
		public Animation Step1Animation;

		// Token: 0x0400331A RID: 13082
		public CanvasGroup Step1CanvasGroup;

		// Token: 0x0400331B RID: 13083
		public Animation Step2Animation;

		// Token: 0x0400331C RID: 13084
		public CanvasGroup Step2CanvasGroup;

		// Token: 0x0400331D RID: 13085
		public AnimationClip FadeInAnim;

		// Token: 0x0400331E RID: 13086
		public AnimationClip FadeOutAnim;

		// Token: 0x0400331F RID: 13087
		public TMP_InputField OfferInputField;

		// Token: 0x04003320 RID: 13088
		public Slider AngerSlider;

		// Token: 0x04003321 RID: 13089
		public TextMeshProUGUI AcceptCounterButtonLabel;

		// Token: 0x04003322 RID: 13090
		[Header("Settings")]
		public string[] OfferLines;

		// Token: 0x04003323 RID: 13091
		public string[] ThinkLines;

		// Token: 0x04003324 RID: 13092
		public string[] AcceptLines;

		// Token: 0x04003325 RID: 13093
		public string[] CounterLines;

		// Token: 0x04003326 RID: 13094
		public string[] RefusalLines;

		// Token: 0x04003327 RID: 13095
		public string[] DealFinalizedLines;

		// Token: 0x04003328 RID: 13096
		public string[] AngeredLines;

		// Token: 0x04003329 RID: 13097
		public string[] CrashOutLines;

		// Token: 0x0400332A RID: 13098
		private ItemSlot[] PawnSlots;

		// Token: 0x0400332B RID: 13099
		private Coroutine routine;

		// Token: 0x02000A14 RID: 2580
		public enum EState
		{
			// Token: 0x0400332D RID: 13101
			WaitingForOffer,
			// Token: 0x0400332E RID: 13102
			Negotiating
		}

		// Token: 0x02000A15 RID: 2581
		public enum EPlayerResponse
		{
			// Token: 0x04003330 RID: 13104
			None,
			// Token: 0x04003331 RID: 13105
			Accept,
			// Token: 0x04003332 RID: 13106
			Counter,
			// Token: 0x04003333 RID: 13107
			Cancel
		}

		// Token: 0x02000A16 RID: 2582
		public enum EShopResponse
		{
			// Token: 0x04003335 RID: 13109
			Accept,
			// Token: 0x04003336 RID: 13110
			Counter,
			// Token: 0x04003337 RID: 13111
			Refusal
		}
	}
}
