using System;
using System.Text.RegularExpressions;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.ScriptableObjects;
using ScheduleOne.UI.Input;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	// Token: 0x02000A9B RID: 2715
	public class CallInterface : Singleton<CallInterface>
	{
		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x00132364 File Offset: 0x00130564
		// (set) Token: 0x0600490B RID: 18699 RVA: 0x0013236C File Offset: 0x0013056C
		public PhoneCallData ActiveCallData { get; private set; }

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x0600490C RID: 18700 RVA: 0x00132375 File Offset: 0x00130575
		// (set) Token: 0x0600490D RID: 18701 RVA: 0x0013237D File Offset: 0x0013057D
		public bool IsOpen { get; protected set; }

		// Token: 0x0600490E RID: 18702 RVA: 0x00132388 File Offset: 0x00130588
		protected override void Awake()
		{
			base.Awake();
			this.highlight1Hex = ColorUtility.ToHtmlStringRGB(this.Highlight1Color);
			this.ContinuePrompt.gameObject.SetActive(false);
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 1);
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x001323EC File Offset: 0x001305EC
		private void Update()
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Submit) || GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) || GameInput.GetButtonDown(GameInput.ButtonCode.Jump))
			{
				if (this.rolloutRoutine != null)
				{
					this.skipRollout = true;
					return;
				}
				this.Continue();
			}
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x00132426 File Offset: 0x00130626
		private void Exit(ExitAction exit)
		{
			if (exit.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (exit.exitType == ExitType.Escape)
			{
				exit.used = true;
				this.Close();
			}
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x00132450 File Offset: 0x00130650
		public void StartCall(PhoneCallData data, CallerID caller, int startStage = 0)
		{
			if (this.IsOpen)
			{
				Debug.LogWarning("CallInterface: There is already a call in progress; existing call will be forced complete");
				for (int i = this.currentCallStage; i < this.ActiveCallData.Stages.Length; i++)
				{
					if (i > this.currentCallStage)
					{
						this.ActiveCallData.Stages[i].OnStageStart();
					}
					this.ActiveCallData.Stages[i].OnStageEnd();
				}
				this.ActiveCallData.Completed();
			}
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0.2f);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			this.ActiveCallData = data;
			this.IsOpen = true;
			this.ProfilePicture.sprite = caller.ProfilePicture;
			this.MainText.text = string.Empty;
			this.NameLabel.text = caller.Name;
			this.currentCallStage = startStage;
			this.SetIsVisible(true);
			this.ShowStage(0, 0.25f);
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00132578 File Offset: 0x00130778
		public void EndCall()
		{
			if (!this.IsOpen)
			{
				Debug.LogWarning("CallInterface: Attempted to end a call while no call was in progress.");
				return;
			}
			if (this.ActiveCallData != null)
			{
				this.ActiveCallData.Completed();
			}
			if (this.CallCompleted != null)
			{
				this.CallCompleted(this.ActiveCallData);
			}
			this.Close();
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x001325D0 File Offset: 0x001307D0
		private void Close()
		{
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0.2f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.2f);
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			if (this.rolloutRoutine != null)
			{
				base.StopCoroutine(this.rolloutRoutine);
				this.rolloutRoutine = null;
			}
			this.ActiveCallData = null;
			this.IsOpen = false;
			this.SetIsVisible(false);
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00132684 File Offset: 0x00130884
		public void Continue()
		{
			if (this.currentCallStage != -1)
			{
				this.ActiveCallData.Stages[this.currentCallStage].OnStageEnd();
			}
			if (this.currentCallStage == this.ActiveCallData.Stages.Length - 1)
			{
				this.EndCall();
				return;
			}
			this.ShowStage(this.currentCallStage + 1, 0f);
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x001326E4 File Offset: 0x001308E4
		private void ShowStage(int stageIndex, float initialDelay = 0f)
		{
			CallInterface.<>c__DisplayClass32_0 CS$<>8__locals1 = new CallInterface.<>c__DisplayClass32_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.initialDelay = initialDelay;
			CS$<>8__locals1.stageIndex = stageIndex;
			this.currentCallStage = CS$<>8__locals1.stageIndex;
			this.ActiveCallData.Stages[CS$<>8__locals1.stageIndex].OnStageStart();
			this.rolloutRoutine = base.StartCoroutine(CS$<>8__locals1.<ShowStage>g__Routine|0());
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00132744 File Offset: 0x00130944
		private string ProcessText(string text)
		{
			string pattern = "<Input_([a-zA-Z0-9]+)>";
			MatchEvaluator evaluator = delegate(Match match)
			{
				GameInput.ButtonCode code;
				if (Enum.TryParse<GameInput.ButtonCode>(match.Groups[1].Value, out code))
				{
					string text2;
					string controlPath;
					InputActionRebindingExtensions.GetBindingDisplayString(Singleton<GameInput>.Instance.GetAction(code), 0, ref text2, ref controlPath, 0);
					string displayNameForControlPath = Singleton<InputPromptsManager>.Instance.GetDisplayNameForControlPath(controlPath);
					return string.Concat(new string[]
					{
						"<color=#",
						this.highlight1Hex,
						">",
						displayNameForControlPath,
						"</color>"
					});
				}
				return match.Value;
			};
			return Regex.Replace(text, pattern, evaluator).Replace("<h1>", "<color=#" + this.highlight1Hex + ">").Replace("</h>", "</color>");
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x0013279C File Offset: 0x0013099C
		private string GetVisibleText(int charactersShown, string fullText)
		{
			bool flag = false;
			string text = fullText.Substring(0, charactersShown);
			char[] array = text.ToCharArray();
			if ((array[charactersShown - 1] != '<' && !flag) || array[charactersShown - 1] == '>')
			{
			}
			return text;
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x001327D8 File Offset: 0x001309D8
		private void SetIsVisible(bool visible)
		{
			if (this.slideRoutine != null)
			{
				base.StopCoroutine(this.slideRoutine);
			}
			if (visible)
			{
				this.CanvasGroup.alpha = 0f;
				this.Canvas.enabled = true;
				this.Container.gameObject.SetActive(true);
				this.OpenAnim.Play();
				return;
			}
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x04003622 RID: 13858
		public const float TIME_PER_CHAR = 0.015f;

		// Token: 0x04003625 RID: 13861
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003626 RID: 13862
		public RectTransform Container;

		// Token: 0x04003627 RID: 13863
		public Image ProfilePicture;

		// Token: 0x04003628 RID: 13864
		public TextMeshProUGUI NameLabel;

		// Token: 0x04003629 RID: 13865
		public TextMeshProUGUI MainText;

		// Token: 0x0400362A RID: 13866
		public RectTransform ContinuePrompt;

		// Token: 0x0400362B RID: 13867
		public Animation OpenAnim;

		// Token: 0x0400362C RID: 13868
		public AudioSourceController TypewriterEffectSound;

		// Token: 0x0400362D RID: 13869
		public CanvasGroup CanvasGroup;

		// Token: 0x0400362E RID: 13870
		[Header("Settings")]
		public Color Highlight1Color;

		// Token: 0x0400362F RID: 13871
		private int currentCallStage = -1;

		// Token: 0x04003630 RID: 13872
		private Coroutine slideRoutine;

		// Token: 0x04003631 RID: 13873
		private bool skipRollout;

		// Token: 0x04003632 RID: 13874
		private Coroutine rolloutRoutine;

		// Token: 0x04003633 RID: 13875
		private string highlight1Hex;

		// Token: 0x04003634 RID: 13876
		public Action<PhoneCallData> CallCompleted;
	}
}
