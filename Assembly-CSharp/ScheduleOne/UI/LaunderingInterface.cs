using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.Money;
using ScheduleOne.ObjectScripts.Cash;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.Variables;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A00 RID: 2560
	public class LaunderingInterface : MonoBehaviour
	{
		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x001208D9 File Offset: 0x0011EAD9
		protected int maxLaunderAmount
		{
			get
			{
				return (int)Mathf.Min(this.business.appliedLaunderLimit, NetworkSingleton<MoneyManager>.Instance.cashBalance);
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x001208F6 File Offset: 0x0011EAF6
		// (set) Token: 0x060044F6 RID: 17654 RVA: 0x001208FE File Offset: 0x0011EAFE
		public Business business { get; private set; }

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060044F7 RID: 17655 RVA: 0x00120907 File Offset: 0x0011EB07
		public bool isOpen
		{
			get
			{
				return this.canvas != null && this.canvas.gameObject.activeSelf;
			}
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x0012092C File Offset: 0x0011EB2C
		public void Initialize(Business bus)
		{
			this.business = bus;
			this.intObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.intObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
			this.launderCapacityLabel.text = MoneyManager.FormatAmount(this.business.LaunderCapacity, false, false);
			this.canvas.gameObject.SetActive(false);
			this.noEntries.gameObject.SetActive(this.operationToEntry.Count == 0);
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(delegate()
			{
				this.canvas.worldCamera = PlayerSingleton<PlayerCamera>.Instance.Camera;
			}));
			foreach (LaunderingOperation op in this.business.LaunderingOperations)
			{
				this.CreateEntry(op);
			}
			Business.onOperationStarted = (Action<LaunderingOperation>)Delegate.Combine(Business.onOperationStarted, new Action<LaunderingOperation>(this.CreateEntry));
			Business.onOperationStarted = (Action<LaunderingOperation>)Delegate.Combine(Business.onOperationStarted, new Action<LaunderingOperation>(this.UpdateCashStacks));
			Business.onOperationFinished = (Action<LaunderingOperation>)Delegate.Combine(Business.onOperationFinished, new Action<LaunderingOperation>(this.RemoveEntry));
			Business.onOperationFinished = (Action<LaunderingOperation>)Delegate.Combine(Business.onOperationFinished, new Action<LaunderingOperation>(this.UpdateCashStacks));
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 5);
			TimeManager instance = NetworkSingleton<TimeManager>.Instance;
			instance.onMinutePass = (Action)Delegate.Combine(instance.onMinutePass, new Action(this.MinPass));
			this.CloseAmountSelector();
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00120AF0 File Offset: 0x0011ECF0
		private void OnDestroy()
		{
			Business.onOperationStarted = (Action<LaunderingOperation>)Delegate.Remove(Business.onOperationStarted, new Action<LaunderingOperation>(this.CreateEntry));
			Business.onOperationStarted = (Action<LaunderingOperation>)Delegate.Remove(Business.onOperationStarted, new Action<LaunderingOperation>(this.UpdateCashStacks));
			Business.onOperationFinished = (Action<LaunderingOperation>)Delegate.Remove(Business.onOperationFinished, new Action<LaunderingOperation>(this.RemoveEntry));
			Business.onOperationFinished = (Action<LaunderingOperation>)Delegate.Remove(Business.onOperationFinished, new Action<LaunderingOperation>(this.UpdateCashStacks));
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00120B7D File Offset: 0x0011ED7D
		protected virtual void MinPass()
		{
			if (this.isOpen)
			{
				this.UpdateTimeline();
				this.RefreshLaunderButton();
				this.UpdateCurrentTotal();
				this.UpdateEntryTimes();
			}
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00120BA0 File Offset: 0x0011EDA0
		protected void Exit(ExitAction exit)
		{
			if (exit.used)
			{
				return;
			}
			if (this.isOpen)
			{
				if (this.amountSelectorScreen.gameObject.activeSelf)
				{
					exit.used = true;
					this.CloseAmountSelector();
					return;
				}
				if (exit.exitType == ExitType.Escape)
				{
					exit.used = true;
					this.Close();
				}
			}
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00120BF4 File Offset: 0x0011EDF4
		protected void UpdateTimeline()
		{
			foreach (LaunderingOperation launderingOperation in this.business.LaunderingOperations)
			{
				if (!this.operationToNotch.ContainsKey(launderingOperation))
				{
					RectTransform component = Object.Instantiate<GameObject>(this.timelineNotchPrefab, this.notchContainer).GetComponent<RectTransform>();
					component.Find("Amount").GetComponent<TextMeshProUGUI>().text = MoneyManager.FormatAmount(launderingOperation.amount, false, false);
					this.operationToNotch.Add(launderingOperation, component);
					this.notches.Add(component);
				}
			}
			List<RectTransform> list = (from x in this.operationToNotch
			where this.business.LaunderingOperations.Contains(x.Key)
			select x.Value).ToList<RectTransform>();
			for (int i = 0; i < this.notches.Count; i++)
			{
				if (!list.Contains(this.notches[i]))
				{
					Object.Destroy(this.notches[i].gameObject);
					this.notches.RemoveAt(i);
					i--;
				}
			}
			foreach (LaunderingOperation launderingOperation2 in this.business.LaunderingOperations)
			{
				this.operationToNotch[launderingOperation2].anchoredPosition = new Vector2(this.notchContainer.rect.width * (float)launderingOperation2.minutesSinceStarted / (float)launderingOperation2.completionTime_Minutes, this.operationToNotch[launderingOperation2].anchoredPosition.y);
			}
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00120DD4 File Offset: 0x0011EFD4
		protected void UpdateCurrentTotal()
		{
			this.currentTotalAmountLabel.text = MoneyManager.FormatAmount(this.business.currentLaunderTotal, false, false);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00120DF4 File Offset: 0x0011EFF4
		private void CreateEntry(LaunderingOperation op)
		{
			if (this.operationToEntry.ContainsKey(op))
			{
				return;
			}
			RectTransform component = Object.Instantiate<GameObject>(this.entryPrefab, this.entryContainer).GetComponent<RectTransform>();
			component.SetAsLastSibling();
			component.Find("BusinessLabel").GetComponent<TextMeshProUGUI>().text = op.business.PropertyName;
			component.Find("AmountLabel").GetComponent<TextMeshProUGUI>().text = MoneyManager.FormatAmount(op.amount, false, false);
			this.operationToEntry.Add(op, component);
			this.UpdateEntryTimes();
			if (this.noEntries != null)
			{
				this.noEntries.gameObject.SetActive(this.operationToEntry.Count == 0);
			}
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00120EB0 File Offset: 0x0011F0B0
		private void RemoveEntry(LaunderingOperation op)
		{
			if (!this.operationToEntry.ContainsKey(op))
			{
				return;
			}
			RectTransform rectTransform = this.operationToEntry[op];
			if (rectTransform != null)
			{
				Object.Destroy(rectTransform.gameObject);
			}
			this.operationToEntry.Remove(op);
			this.noEntries.gameObject.SetActive(this.operationToEntry.Count == 0);
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00120F18 File Offset: 0x0011F118
		private void UpdateEntryTimes()
		{
			foreach (LaunderingOperation launderingOperation in this.operationToEntry.Keys.ToList<LaunderingOperation>())
			{
				if (this.operationToEntry.ContainsKey(launderingOperation))
				{
					if (this.operationToEntry[launderingOperation] == null)
					{
						Console.LogWarning("Entry is null for operation " + launderingOperation.business.PropertyName, null);
					}
					else
					{
						int num = launderingOperation.completionTime_Minutes - launderingOperation.minutesSinceStarted;
						if (num > 60)
						{
							int num2 = Mathf.CeilToInt((float)num / 60f);
							this.operationToEntry[launderingOperation].Find("TimeLabel").GetComponent<TextMeshProUGUI>().text = num2.ToString() + " hours";
						}
						else
						{
							this.operationToEntry[launderingOperation].Find("TimeLabel").GetComponent<TextMeshProUGUI>().text = num.ToString() + " minutes";
						}
					}
				}
			}
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00121040 File Offset: 0x0011F240
		private void UpdateCashStacks(LaunderingOperation op)
		{
			float num = this.business.currentLaunderTotal;
			for (int i = 0; i < this.CashStacks.Length; i++)
			{
				if (num <= 0f)
				{
					this.CashStacks[i].ShowAmount(0f);
				}
				else
				{
					float num2 = Mathf.Min(num, 1000f);
					this.CashStacks[i].ShowAmount(num2);
					num -= num2;
				}
			}
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x001210A8 File Offset: 0x0011F2A8
		private void RefreshLaunderButton()
		{
			this.launderButton.interactable = (this.business.currentLaunderTotal < this.business.LaunderCapacity && NetworkSingleton<MoneyManager>.Instance.cashBalance > 10f);
			if (this.business.currentLaunderTotal >= this.business.LaunderCapacity)
			{
				this.insufficientCashLabel.text = "The business is already at maximum laundering capacity.";
				this.insufficientCashLabel.gameObject.SetActive(true);
				return;
			}
			if (NetworkSingleton<MoneyManager>.Instance.cashBalance <= 10f)
			{
				this.insufficientCashLabel.text = "You need at least " + MoneyManager.FormatAmount(10f, false, false) + " cash to launder.";
				this.insufficientCashLabel.gameObject.SetActive(true);
				return;
			}
			this.insufficientCashLabel.gameObject.SetActive(false);
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00121180 File Offset: 0x0011F380
		public void OpenAmountSelector()
		{
			this.amountSelectorScreen.gameObject.SetActive(true);
			int num = Mathf.Clamp(100, 10, this.maxLaunderAmount);
			this.selectedAmountToLaunder = num;
			this.amountSlider.minValue = 10f;
			this.amountSlider.maxValue = (float)this.maxLaunderAmount;
			this.amountSlider.SetValueWithoutNotify((float)num);
			this.amountInputField.SetTextWithoutNotify(num.ToString());
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x001211F6 File Offset: 0x0011F3F6
		public void CloseAmountSelector()
		{
			this.amountSelectorScreen.gameObject.SetActive(false);
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x0012120C File Offset: 0x0011F40C
		public void ConfirmAmount()
		{
			int num = Mathf.Clamp(this.selectedAmountToLaunder, 10, this.maxLaunderAmount);
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance((float)(-(float)num), true, false);
			this.business.StartLaunderingOperation((float)num, 0);
			float value = NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("LaunderingOperationsStarted");
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("LaunderingOperationsStarted", (value + 1f).ToString(), true);
			this.UpdateTimeline();
			this.UpdateCurrentTotal();
			this.RefreshLaunderButton();
			this.CloseAmountSelector();
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00121291 File Offset: 0x0011F491
		public void SliderValueChanged()
		{
			if (this.ignoreSliderChange)
			{
				this.ignoreSliderChange = false;
				return;
			}
			this.selectedAmountToLaunder = (int)this.amountSlider.value;
			this.amountInputField.SetTextWithoutNotify(this.selectedAmountToLaunder.ToString());
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x001212CC File Offset: 0x0011F4CC
		public void InputValueChanged()
		{
			this.selectedAmountToLaunder = Mathf.Clamp(int.Parse(this.amountInputField.text), 10, this.maxLaunderAmount);
			this.amountInputField.SetTextWithoutNotify(this.selectedAmountToLaunder.ToString());
			this.amountSlider.SetValueWithoutNotify((float)this.selectedAmountToLaunder);
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00121324 File Offset: 0x0011F524
		public void Hovered()
		{
			if (!this.business.IsOwned || this.isOpen)
			{
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			if (this.business.IsOwned && !this.isOpen)
			{
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				this.intObj.SetMessage("Manage business");
			}
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00121384 File Offset: 0x0011F584
		public void Interacted()
		{
			if (this.business.IsOwned && !this.isOpen)
			{
				this.Open();
			}
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x001213A4 File Offset: 0x0011F5A4
		public virtual void Open()
		{
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			this.intObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.cameraPosition.transform.position, this.cameraPosition.rotation, 0.15f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(65f, 0.15f);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.RefreshLaunderButton();
			this.UpdateTimeline();
			this.UpdateCurrentTotal();
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x0012145C File Offset: 0x0011F65C
		public virtual void Close()
		{
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			this.intObj.SetInteractableState(InteractableObject.EInteractableState.Default);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.15f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.15f);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			base.gameObject.SetActive(false);
		}

		// Token: 0x0400326F RID: 12911
		protected const float fovOverride = 65f;

		// Token: 0x04003270 RID: 12912
		protected const float lerpTime = 0.15f;

		// Token: 0x04003271 RID: 12913
		protected const int minLaunderAmount = 10;

		// Token: 0x04003273 RID: 12915
		[Header("References")]
		[SerializeField]
		protected Transform cameraPosition;

		// Token: 0x04003274 RID: 12916
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x04003275 RID: 12917
		[SerializeField]
		protected Button launderButton;

		// Token: 0x04003276 RID: 12918
		[SerializeField]
		protected GameObject amountSelectorScreen;

		// Token: 0x04003277 RID: 12919
		[SerializeField]
		protected Slider amountSlider;

		// Token: 0x04003278 RID: 12920
		[SerializeField]
		protected TMP_InputField amountInputField;

		// Token: 0x04003279 RID: 12921
		[SerializeField]
		protected RectTransform notchContainer;

		// Token: 0x0400327A RID: 12922
		[SerializeField]
		protected TextMeshProUGUI currentTotalAmountLabel;

		// Token: 0x0400327B RID: 12923
		[SerializeField]
		protected TextMeshProUGUI launderCapacityLabel;

		// Token: 0x0400327C RID: 12924
		[SerializeField]
		protected TextMeshProUGUI insufficientCashLabel;

		// Token: 0x0400327D RID: 12925
		[SerializeField]
		protected RectTransform entryContainer;

		// Token: 0x0400327E RID: 12926
		[SerializeField]
		protected RectTransform noEntries;

		// Token: 0x0400327F RID: 12927
		public CashStackVisuals[] CashStacks;

		// Token: 0x04003280 RID: 12928
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject timelineNotchPrefab;

		// Token: 0x04003281 RID: 12929
		[SerializeField]
		protected GameObject entryPrefab;

		// Token: 0x04003282 RID: 12930
		[Header("UI references")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x04003283 RID: 12931
		private int selectedAmountToLaunder;

		// Token: 0x04003284 RID: 12932
		private Dictionary<LaunderingOperation, RectTransform> operationToNotch = new Dictionary<LaunderingOperation, RectTransform>();

		// Token: 0x04003285 RID: 12933
		private List<RectTransform> notches = new List<RectTransform>();

		// Token: 0x04003286 RID: 12934
		private bool ignoreSliderChange = true;

		// Token: 0x04003287 RID: 12935
		private Dictionary<LaunderingOperation, RectTransform> operationToEntry = new Dictionary<LaunderingOperation, RectTransform>();
	}
}
