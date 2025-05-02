using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009DB RID: 2523
	public class DialogueCanvas : Singleton<DialogueCanvas>
	{
		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x0011D44B File Offset: 0x0011B64B
		public bool isActive
		{
			get
			{
				return this.currentHandler != null;
			}
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x0011D459 File Offset: 0x0011B659
		protected override void Awake()
		{
			base.Awake();
			this.canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 0);
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x0011D490 File Offset: 0x0011B690
		public void DisplayDialogueNode(DialogueHandler diag, DialogueNodeData node, string dialogueText, List<string> choices)
		{
			if (diag != this.currentHandler)
			{
				this.StartDialogue(diag);
			}
			if (this.dialogueRollout != null)
			{
				base.StopCoroutine(this.dialogueRollout);
			}
			this.currentNode = node;
			this.dialogueRollout = base.StartCoroutine(this.RolloutDialogue(dialogueText, choices));
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x0011D4E4 File Offset: 0x0011B6E4
		public void OverrideText(string text)
		{
			this.overrideText = text;
			if (this.dialogueRollout != null)
			{
				base.StopCoroutine(this.dialogueRollout);
			}
			this.dialogueText.text = this.overrideText;
			this.canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x0011D53A File Offset: 0x0011B73A
		public void StopTextOverride()
		{
			this.overrideText = string.Empty;
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x0011D547 File Offset: 0x0011B747
		private void Update()
		{
			if (this.isActive)
			{
				if (Input.GetKeyDown(KeyCode.Space))
				{
					this.spaceDownThisFrame = true;
				}
				else
				{
					this.spaceDownThisFrame = false;
				}
				if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick))
				{
					this.leftClickThisFrame = true;
					return;
				}
				this.leftClickThisFrame = false;
			}
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x0011D581 File Offset: 0x0011B781
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.isActive)
			{
				return;
			}
			if (action.exitType != ExitType.Escape)
			{
				return;
			}
			if (!DialogueHandler.activeDialogue.AllowExit)
			{
				return;
			}
			action.used = true;
			this.currentHandler.EndDialogue();
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x0011D5BE File Offset: 0x0011B7BE
		protected IEnumerator RolloutDialogue(string text, List<string> choices)
		{
			List<int> activeDialogueChoices = new List<int>();
			this.dialogueText.maxVisibleCharacters = 0;
			this.dialogueText.text = text;
			this.canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			float rolloutTime = (float)text.Length * 0.015f;
			if (this.SkipNextRollout)
			{
				this.SkipNextRollout = false;
				rolloutTime = 0f;
			}
			float i = 0f;
			while (i < rolloutTime && !this.spaceDownThisFrame && !this.leftClickThisFrame)
			{
				int maxVisibleCharacters = (int)(i / 0.015f);
				this.dialogueText.maxVisibleCharacters = maxVisibleCharacters;
				yield return new WaitForEndOfFrame();
				i += Time.deltaTime;
			}
			this.dialogueText.maxVisibleCharacters = text.Length;
			this.spaceDownThisFrame = false;
			this.leftClickThisFrame = false;
			this.hasChoiceBeenSelected = false;
			if (this.choiceSelectionResidualCoroutine != null)
			{
				base.StopCoroutine(this.choiceSelectionResidualCoroutine);
			}
			this.continuePopup.gameObject.SetActive(false);
			for (int j = 0; j < this.dialogueChoices.Count; j++)
			{
				this.dialogueChoices[j].gameObject.SetActive(false);
				this.dialogueChoices[j].canvasGroup.alpha = 1f;
				if (choices.Count > j)
				{
					this.dialogueChoices[j].text.text = choices[j];
					this.dialogueChoices[j].button.interactable = true;
					string empty = string.Empty;
					if (this.IsChoiceValid(j, out empty))
					{
						this.dialogueChoices[j].notPossibleGameObject.SetActive(false);
						this.dialogueChoices[j].button.interactable = true;
						ColorBlock colors = this.dialogueChoices[j].button.colors;
						colors.disabledColor = colors.pressedColor;
						this.dialogueChoices[j].button.colors = colors;
						this.dialogueChoices[j].text.GetComponent<RectTransform>().offsetMax = new Vector2(0f, 0f);
					}
					else
					{
						this.dialogueChoices[j].notPossibleText.text = empty.ToUpper();
						this.dialogueChoices[j].notPossibleGameObject.SetActive(true);
						ColorBlock colors2 = this.dialogueChoices[j].button.colors;
						colors2.disabledColor = colors2.normalColor;
						this.dialogueChoices[j].button.colors = colors2;
						this.dialogueChoices[j].button.interactable = false;
						this.dialogueChoices[j].notPossibleText.ForceMeshUpdate(false, false);
						this.dialogueChoices[j].text.GetComponent<RectTransform>().offsetMax = new Vector2(-(this.dialogueChoices[j].notPossibleText.preferredWidth + 20f), 0f);
					}
					activeDialogueChoices.Add(j);
				}
			}
			if (activeDialogueChoices.Count == 0 || (activeDialogueChoices.Count == 1 && choices[0] == ""))
			{
				this.continuePopup.gameObject.SetActive(true);
				yield return new WaitUntil(() => this.spaceDownThisFrame || this.leftClickThisFrame);
				this.continuePopup.gameObject.SetActive(false);
				this.spaceDownThisFrame = false;
				this.leftClickThisFrame = false;
				this.currentHandler.ContinueSubmitted();
			}
			else
			{
				for (int k = 0; k < activeDialogueChoices.Count; k++)
				{
					this.dialogueChoices[activeDialogueChoices[k]].gameObject.SetActive(true);
				}
				while (!this.hasChoiceBeenSelected)
				{
					string empty2 = string.Empty;
					if (Input.GetKey(KeyCode.Alpha1) && this.IsChoiceValid(0, out empty2))
					{
						this.ChoiceSelected(0);
					}
					else if (Input.GetKey(KeyCode.Alpha2) && this.IsChoiceValid(1, out empty2))
					{
						this.ChoiceSelected(1);
					}
					else if (Input.GetKey(KeyCode.Alpha3) && this.IsChoiceValid(2, out empty2))
					{
						this.ChoiceSelected(2);
					}
					else if (Input.GetKey(KeyCode.Alpha4) && this.IsChoiceValid(3, out empty2))
					{
						this.ChoiceSelected(3);
					}
					else if (Input.GetKey(KeyCode.Alpha5) && this.IsChoiceValid(4, out empty2))
					{
						this.ChoiceSelected(4);
					}
					else if (Input.GetKey(KeyCode.Alpha6) && this.IsChoiceValid(5, out empty2))
					{
						this.ChoiceSelected(5);
					}
					else if (Input.GetKey(KeyCode.Alpha6) && this.IsChoiceValid(6, out empty2))
					{
						this.ChoiceSelected(6);
					}
					else if (Input.GetKey(KeyCode.Alpha6) && this.IsChoiceValid(7, out empty2))
					{
						this.ChoiceSelected(7);
					}
					else if (Input.GetKey(KeyCode.Alpha6) && this.IsChoiceValid(8, out empty2))
					{
						this.ChoiceSelected(8);
					}
					yield return new WaitForEndOfFrame();
				}
			}
			yield break;
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x0011D5DB File Offset: 0x0011B7DB
		private IEnumerator ChoiceSelectionResidual(DialogueChoiceEntry choice, float fadeTime)
		{
			yield return new WaitForSeconds(0.25f);
			float realFadeTime = fadeTime - 0.25f;
			for (float i = 0f; i < realFadeTime; i += Time.deltaTime)
			{
				choice.canvasGroup.alpha = Mathf.Sqrt(Mathf.Lerp(1f, 0f, i / realFadeTime));
				yield return new WaitForEndOfFrame();
			}
			choice.gameObject.SetActive(false);
			this.choiceSelectionResidualCoroutine = null;
			yield break;
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x0011D5F8 File Offset: 0x0011B7F8
		private void StartDialogue(DialogueHandler handler)
		{
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.currentHandler = handler;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			Vector3 normalized = (this.currentHandler.LookPosition.transform.position - PlayerSingleton<PlayerCamera>.Instance.transform.position).normalized;
			Quaternion quaternion = Quaternion.LookRotation(new Vector3(normalized.x, 0f, normalized.z), Vector3.up);
			PlayerSingleton<PlayerMovement>.Instance.LerpPlayerRotation(quaternion, 0.3f);
			Vector3 vector = new Vector3(Mathf.Sqrt(Mathf.Pow(normalized.x, 2f) + Mathf.Pow(normalized.z, 2f)), normalized.y, 0f);
			float x = -Mathf.Atan2(vector.y, vector.x) * 57.295776f;
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(PlayerSingleton<PlayerCamera>.Instance.transform.position, quaternion * Quaternion.Euler(x, 0f, 0f), 0.3f, true);
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x0011D734 File Offset: 0x0011B934
		public void EndDialogue()
		{
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			this.continuePopup.gameObject.SetActive(false);
			for (int i = 0; i < this.dialogueChoices.Count; i++)
			{
				this.dialogueChoices[i].gameObject.SetActive(false);
			}
			if (this.dialogueRollout != null)
			{
				base.StopCoroutine(this.dialogueRollout);
			}
			if (this.choiceSelectionResidualCoroutine != null)
			{
				base.StopCoroutine(this.choiceSelectionResidualCoroutine);
			}
			this.canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			this.currentHandler = null;
			this.currentNode = null;
			if (PlayerSingleton<PlayerCamera>.Instance.activeUIElementCount == 0)
			{
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
				PlayerSingleton<PlayerMovement>.Instance.canMove = true;
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
				PlayerSingleton<PlayerCamera>.Instance.LockMouse();
				PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, true, false);
				return;
			}
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, false, false);
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x0011D83C File Offset: 0x0011BA3C
		public void ChoiceSelected(int choiceIndex)
		{
			string empty = string.Empty;
			if (!this.IsChoiceValid(choiceIndex, out empty))
			{
				return;
			}
			this.hasChoiceBeenSelected = true;
			for (int i = 0; i < this.dialogueChoices.Count; i++)
			{
				if (i == choiceIndex)
				{
					this.dialogueChoices[i].button.interactable = false;
					if (this.choiceSelectionResidualCoroutine != null)
					{
						base.StopCoroutine(this.choiceSelectionResidualCoroutine);
					}
					this.choiceSelectionResidualCoroutine = base.StartCoroutine(this.ChoiceSelectionResidual(this.dialogueChoices[i], 0.75f));
				}
				else
				{
					this.dialogueChoices[i].gameObject.SetActive(false);
				}
			}
			this.currentHandler.ChoiceSelected(choiceIndex);
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x0011D8F0 File Offset: 0x0011BAF0
		private bool IsChoiceValid(int choiceIndex, out string reason)
		{
			if (this.currentNode != null && this.currentHandler.CurrentChoices.Count > choiceIndex)
			{
				return this.currentHandler.CheckChoice(this.currentHandler.CurrentChoices[choiceIndex].ChoiceLabel, out reason);
			}
			reason = string.Empty;
			return false;
		}

		// Token: 0x0400319B RID: 12699
		public const float TIME_PER_CHAR = 0.015f;

		// Token: 0x0400319C RID: 12700
		public bool SkipNextRollout;

		// Token: 0x0400319D RID: 12701
		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x0400319E RID: 12702
		public RectTransform Container;

		// Token: 0x0400319F RID: 12703
		[SerializeField]
		protected TextMeshProUGUI dialogueText;

		// Token: 0x040031A0 RID: 12704
		[SerializeField]
		protected GameObject continuePopup;

		// Token: 0x040031A1 RID: 12705
		[SerializeField]
		protected List<DialogueChoiceEntry> dialogueChoices = new List<DialogueChoiceEntry>();

		// Token: 0x040031A2 RID: 12706
		private DialogueHandler currentHandler;

		// Token: 0x040031A3 RID: 12707
		private DialogueNodeData currentNode;

		// Token: 0x040031A4 RID: 12708
		private bool spaceDownThisFrame;

		// Token: 0x040031A5 RID: 12709
		private bool leftClickThisFrame;

		// Token: 0x040031A6 RID: 12710
		private string overrideText = string.Empty;

		// Token: 0x040031A7 RID: 12711
		private Coroutine dialogueRollout;

		// Token: 0x040031A8 RID: 12712
		private Coroutine choiceSelectionResidualCoroutine;

		// Token: 0x040031A9 RID: 12713
		private bool hasChoiceBeenSelected;
	}
}
