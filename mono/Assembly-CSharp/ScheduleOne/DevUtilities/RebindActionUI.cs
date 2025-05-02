using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200070C RID: 1804
	public class RebindActionUI : MonoBehaviour
	{
		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x000CAB79 File Offset: 0x000C8D79
		// (set) Token: 0x060030BD RID: 12477 RVA: 0x000CAB81 File Offset: 0x000C8D81
		public InputActionReference actionReference
		{
			get
			{
				return this.m_Action;
			}
			set
			{
				this.m_Action = value;
				this.UpdateActionLabel();
				this.UpdateBindingDisplay();
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x000CAB96 File Offset: 0x000C8D96
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x000CAB9E File Offset: 0x000C8D9E
		public string bindingId
		{
			get
			{
				return this.m_BindingId;
			}
			set
			{
				this.m_BindingId = value;
				this.UpdateBindingDisplay();
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x000CABAD File Offset: 0x000C8DAD
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x000CABB5 File Offset: 0x000C8DB5
		public InputBinding.DisplayStringOptions displayStringOptions
		{
			get
			{
				return this.m_DisplayStringOptions;
			}
			set
			{
				this.m_DisplayStringOptions = value;
				this.UpdateBindingDisplay();
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x000CABC4 File Offset: 0x000C8DC4
		// (set) Token: 0x060030C3 RID: 12483 RVA: 0x000CABCC File Offset: 0x000C8DCC
		public TextMeshProUGUI actionLabel
		{
			get
			{
				return this.m_ActionLabel;
			}
			set
			{
				this.m_ActionLabel = value;
				this.UpdateActionLabel();
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060030C4 RID: 12484 RVA: 0x000CABDB File Offset: 0x000C8DDB
		// (set) Token: 0x060030C5 RID: 12485 RVA: 0x000CABE3 File Offset: 0x000C8DE3
		public TextMeshProUGUI bindingText
		{
			get
			{
				return this.m_BindingText;
			}
			set
			{
				this.m_BindingText = value;
				this.UpdateBindingDisplay();
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x000CABF2 File Offset: 0x000C8DF2
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x000CABFA File Offset: 0x000C8DFA
		public TextMeshProUGUI rebindPrompt
		{
			get
			{
				return this.m_RebindText;
			}
			set
			{
				this.m_RebindText = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x000CAC03 File Offset: 0x000C8E03
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x000CAC0B File Offset: 0x000C8E0B
		public GameObject rebindOverlay
		{
			get
			{
				return this.m_RebindOverlay;
			}
			set
			{
				this.m_RebindOverlay = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x000CAC14 File Offset: 0x000C8E14
		public RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent
		{
			get
			{
				if (this.m_UpdateBindingUIEvent == null)
				{
					this.m_UpdateBindingUIEvent = new RebindActionUI.UpdateBindingUIEvent();
				}
				return this.m_UpdateBindingUIEvent;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x000CAC2F File Offset: 0x000C8E2F
		public RebindActionUI.InteractiveRebindEvent startRebindEvent
		{
			get
			{
				if (this.m_RebindStartEvent == null)
				{
					this.m_RebindStartEvent = new RebindActionUI.InteractiveRebindEvent();
				}
				return this.m_RebindStartEvent;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x000CAC4A File Offset: 0x000C8E4A
		public RebindActionUI.InteractiveRebindEvent stopRebindEvent
		{
			get
			{
				if (this.m_RebindStopEvent == null)
				{
					this.m_RebindStopEvent = new RebindActionUI.InteractiveRebindEvent();
				}
				return this.m_RebindStopEvent;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x000CAC65 File Offset: 0x000C8E65
		public InputActionRebindingExtensions.RebindingOperation ongoingRebind
		{
			get
			{
				return this.m_RebindOperation;
			}
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000CAC70 File Offset: 0x000C8E70
		public bool ResolveActionAndBinding(out InputAction action, out int bindingIndex)
		{
			bindingIndex = -1;
			InputActionReference action2 = this.m_Action;
			action = ((action2 != null) ? action2.action : null);
			if (action == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(this.m_BindingId))
			{
				return false;
			}
			Guid bindingId = new Guid(this.m_BindingId);
			bindingIndex = action.bindings.IndexOf((InputBinding x) => x.id == bindingId);
			if (bindingIndex == -1)
			{
				Debug.LogError(string.Format("Cannot find binding with ID '{0}' on '{1}'", bindingId, action), this);
				return false;
			}
			return true;
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x000CAD04 File Offset: 0x000C8F04
		public void UpdateBindingDisplay()
		{
			string text = string.Empty;
			string arg = null;
			string arg2 = null;
			InputActionReference action = this.m_Action;
			InputAction inputAction = (action != null) ? action.action : null;
			if (inputAction != null)
			{
				int num = inputAction.bindings.IndexOf((InputBinding x) => x.id.ToString() == this.m_BindingId);
				if (num != -1)
				{
					text = InputActionRebindingExtensions.GetBindingDisplayString(inputAction, num, ref arg, ref arg2, this.displayStringOptions);
				}
			}
			this.m_BindingText.gameObject.SetActive(true);
			if (this.m_BindingText != null)
			{
				this.m_BindingText.text = text;
			}
			RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent = this.m_UpdateBindingUIEvent;
			if (updateBindingUIEvent == null)
			{
				return;
			}
			updateBindingUIEvent.Invoke(this, text, arg, arg2);
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x000CADA8 File Offset: 0x000C8FA8
		public void ResetToDefault()
		{
			InputAction inputAction;
			int num;
			if (!this.ResolveActionAndBinding(out inputAction, out num))
			{
				return;
			}
			if (inputAction.bindings[num].isComposite)
			{
				for (int i = num + 1; i < inputAction.bindings.Count; i++)
				{
					if (!inputAction.bindings[i].isPartOfComposite)
					{
						break;
					}
					InputActionRebindingExtensions.RemoveBindingOverride(inputAction, i);
				}
			}
			else
			{
				InputActionRebindingExtensions.RemoveBindingOverride(inputAction, num);
			}
			this.UpdateBindingDisplay();
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000CAE2C File Offset: 0x000C902C
		public void StartInteractiveRebind()
		{
			this.m_Action.action.Disable();
			InputAction inputAction;
			int num;
			if (!this.ResolveActionAndBinding(out inputAction, out num))
			{
				return;
			}
			if (inputAction.bindings[num].isComposite)
			{
				int num2 = num + 1;
				if (num2 < inputAction.bindings.Count && inputAction.bindings[num2].isPartOfComposite)
				{
					this.PerformInteractiveRebind(inputAction, num2, true);
					return;
				}
			}
			else
			{
				this.PerformInteractiveRebind(inputAction, num, false);
			}
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000CAEB4 File Offset: 0x000C90B4
		private void PerformInteractiveRebind(InputAction action, int bindingIndex, bool allCompositeParts = false)
		{
			InputActionRebindingExtensions.RebindingOperation rebindOperation = this.m_RebindOperation;
			if (rebindOperation != null)
			{
				rebindOperation.Cancel();
			}
			this.m_RebindOperation = InputActionRebindingExtensions.PerformInteractiveRebinding(action, bindingIndex).OnCancel(delegate(InputActionRebindingExtensions.RebindingOperation operation)
			{
				RebindActionUI.InteractiveRebindEvent rebindStopEvent = this.m_RebindStopEvent;
				if (rebindStopEvent != null)
				{
					rebindStopEvent.Invoke(this, operation);
				}
				if (this.m_RebindOverlay != null)
				{
					GameObject rebindOverlay2 = this.m_RebindOverlay;
					if (rebindOverlay2 != null)
					{
						rebindOverlay2.SetActive(false);
					}
				}
				this.UpdateBindingDisplay();
				base.<PerformInteractiveRebind>g__CleanUp|0();
			}).OnComplete(delegate(InputActionRebindingExtensions.RebindingOperation operation)
			{
				GameObject rebindOverlay2 = this.m_RebindOverlay;
				if (rebindOverlay2 != null)
				{
					rebindOverlay2.SetActive(false);
				}
				RebindActionUI.InteractiveRebindEvent rebindStopEvent = this.m_RebindStopEvent;
				if (rebindStopEvent != null)
				{
					rebindStopEvent.Invoke(this, operation);
				}
				this.UpdateBindingDisplay();
				base.<PerformInteractiveRebind>g__CleanUp|0();
				if (allCompositeParts)
				{
					int num = bindingIndex + 1;
					if (num < action.bindings.Count && action.bindings[num].isPartOfComposite)
					{
						this.PerformInteractiveRebind(action, num, true);
					}
				}
				Action action2 = this.onRebind;
				if (action2 == null)
				{
					return;
				}
				action2();
			}).WithControlsExcluding("Mouse");
			if (action.bindings[bindingIndex].isPartOfComposite)
			{
				"Binding '" + action.bindings[bindingIndex].name + "'. ";
			}
			if (this.m_RebindOverlay != null)
			{
				GameObject rebindOverlay = this.m_RebindOverlay;
				if (rebindOverlay != null)
				{
					rebindOverlay.SetActive(true);
				}
			}
			if (this.m_RebindText != null)
			{
				this.m_RebindText.text = "Press key...";
			}
			if (this.m_RebindOverlay == null && this.m_RebindText == null && this.m_RebindStartEvent == null && this.m_BindingText != null)
			{
				this.m_BindingText.text = "<Waiting...>";
			}
			this.m_BindingText.gameObject.SetActive(false);
			RebindActionUI.InteractiveRebindEvent rebindStartEvent = this.m_RebindStartEvent;
			if (rebindStartEvent != null)
			{
				rebindStartEvent.Invoke(this, this.m_RebindOperation);
			}
			this.m_RebindOperation.Start();
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x000CB040 File Offset: 0x000C9240
		protected void OnEnable()
		{
			if (RebindActionUI.s_RebindActionUIs == null)
			{
				RebindActionUI.s_RebindActionUIs = new List<RebindActionUI>();
			}
			RebindActionUI.s_RebindActionUIs.Add(this);
			if (RebindActionUI.s_RebindActionUIs.Count == 1)
			{
				InputSystem.onActionChange += RebindActionUI.OnActionChange;
			}
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x000CB07C File Offset: 0x000C927C
		protected void OnDisable()
		{
			InputActionRebindingExtensions.RebindingOperation rebindOperation = this.m_RebindOperation;
			if (rebindOperation != null)
			{
				rebindOperation.Dispose();
			}
			this.m_RebindOperation = null;
			RebindActionUI.s_RebindActionUIs.Remove(this);
			if (RebindActionUI.s_RebindActionUIs.Count == 0)
			{
				RebindActionUI.s_RebindActionUIs = null;
				InputSystem.onActionChange -= RebindActionUI.OnActionChange;
			}
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x000CB0D0 File Offset: 0x000C92D0
		private static void OnActionChange(object obj, InputActionChange change)
		{
			if (change != 8)
			{
				return;
			}
			InputAction inputAction = obj as InputAction;
			InputActionMap inputActionMap = ((inputAction != null) ? inputAction.actionMap : null) ?? (obj as InputActionMap);
			InputActionAsset y = ((inputActionMap != null) ? inputActionMap.asset : null) ?? (obj as InputActionAsset);
			for (int i = 0; i < RebindActionUI.s_RebindActionUIs.Count; i++)
			{
				RebindActionUI rebindActionUI = RebindActionUI.s_RebindActionUIs[i];
				InputActionReference actionReference = rebindActionUI.actionReference;
				InputAction inputAction2 = (actionReference != null) ? actionReference.action : null;
				if (inputAction2 != null)
				{
					if (inputAction2 != inputAction && inputAction2.actionMap != inputActionMap)
					{
						InputActionMap actionMap = inputAction2.actionMap;
						if (!(((actionMap != null) ? actionMap.asset : null) == y))
						{
							goto IL_95;
						}
					}
					rebindActionUI.UpdateBindingDisplay();
				}
				IL_95:;
			}
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x000CB184 File Offset: 0x000C9384
		private void UpdateActionLabel()
		{
			if (this.m_ActionLabel != null)
			{
				InputActionReference action = this.m_Action;
				InputAction inputAction = (action != null) ? action.action : null;
				this.m_ActionLabel.text = ((inputAction != null) ? inputAction.name : string.Empty);
			}
		}

		// Token: 0x040022C7 RID: 8903
		public Action onRebind;

		// Token: 0x040022C8 RID: 8904
		[Tooltip("Reference to action that is to be rebound from the UI.")]
		[SerializeField]
		private InputActionReference m_Action;

		// Token: 0x040022C9 RID: 8905
		[SerializeField]
		private string m_BindingId;

		// Token: 0x040022CA RID: 8906
		[SerializeField]
		private InputBinding.DisplayStringOptions m_DisplayStringOptions;

		// Token: 0x040022CB RID: 8907
		[Tooltip("Text label that will receive the name of the action. Optional. Set to None to have the rebind UI not show a label for the action.")]
		[SerializeField]
		private TextMeshProUGUI m_ActionLabel;

		// Token: 0x040022CC RID: 8908
		[Tooltip("Text label that will receive the current, formatted binding string.")]
		[SerializeField]
		private TextMeshProUGUI m_BindingText;

		// Token: 0x040022CD RID: 8909
		[Tooltip("Optional UI that will be shown while a rebind is in progress.")]
		[SerializeField]
		private GameObject m_RebindOverlay;

		// Token: 0x040022CE RID: 8910
		[Tooltip("Optional text label that will be updated with prompt for user input.")]
		[SerializeField]
		private TextMeshProUGUI m_RebindText;

		// Token: 0x040022CF RID: 8911
		[Tooltip("Event that is triggered when the way the binding is display should be updated. This allows displaying bindings in custom ways, e.g. using images instead of text.")]
		[SerializeField]
		private RebindActionUI.UpdateBindingUIEvent m_UpdateBindingUIEvent;

		// Token: 0x040022D0 RID: 8912
		[Tooltip("Event that is triggered when an interactive rebind is being initiated. This can be used, for example, to implement custom UI behavior while a rebind is in progress. It can also be used to further customize the rebind.")]
		[SerializeField]
		private RebindActionUI.InteractiveRebindEvent m_RebindStartEvent;

		// Token: 0x040022D1 RID: 8913
		[Tooltip("Event that is triggered when an interactive rebind is complete or has been aborted.")]
		[SerializeField]
		private RebindActionUI.InteractiveRebindEvent m_RebindStopEvent;

		// Token: 0x040022D2 RID: 8914
		private InputActionRebindingExtensions.RebindingOperation m_RebindOperation;

		// Token: 0x040022D3 RID: 8915
		private static List<RebindActionUI> s_RebindActionUIs;

		// Token: 0x0200070D RID: 1805
		[Serializable]
		public class UpdateBindingUIEvent : UnityEvent<RebindActionUI, string, string, string>
		{
		}

		// Token: 0x0200070E RID: 1806
		[Serializable]
		public class InteractiveRebindEvent : UnityEvent<RebindActionUI, InputActionRebindingExtensions.RebindingOperation>
		{
		}
	}
}
