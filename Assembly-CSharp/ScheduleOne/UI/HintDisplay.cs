using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Input;
using ScheduleOne.UI.Phone;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne.UI
{
	// Token: 0x020009F0 RID: 2544
	public class HintDisplay : Singleton<HintDisplay>
	{
		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600449D RID: 17565 RVA: 0x0011F88A File Offset: 0x0011DA8A
		// (set) Token: 0x0600449E RID: 17566 RVA: 0x0011F892 File Offset: 0x0011DA92
		public bool IsOpen { get; protected set; }

		// Token: 0x0600449F RID: 17567 RVA: 0x0011F89B File Offset: 0x0011DA9B
		protected override void Start()
		{
			base.Start();
			this.Group.alpha = 0f;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x0011F8C4 File Offset: 0x0011DAC4
		public void Update()
		{
			if (!this.IsOpen)
			{
				if (this.hintQueue.Count > 0 && this.Group.alpha == 0f)
				{
					this.ShowHint(this.hintQueue[0].Text, this.hintQueue[0].Duration);
					this.hintQueue.RemoveAt(0);
				}
				return;
			}
			this.timeSinceOpened += Time.deltaTime;
			if (Singleton<CallInterface>.Instance.IsOpen)
			{
				this.Hide();
			}
			this.DismissPrompt.SetLabel((this.hintQueue.Count > 0) ? "Next" : "Dismiss");
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Submit) && !GameInput.IsTyping && this.timeSinceOpened > 0.1f)
			{
				this.Hide();
			}
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x0011F99A File Offset: 0x0011DB9A
		public void ShowHint_10s(string text)
		{
			this.ShowHint(text, 10f);
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x0011F9A8 File Offset: 0x0011DBA8
		public void ShowHint_20s(string text)
		{
			this.ShowHint(text, 20f);
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x0011F9B6 File Offset: 0x0011DBB6
		public void ShowHint(string text)
		{
			this.ShowHint(text, 0f);
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x0011F9C4 File Offset: 0x0011DBC4
		public void ShowHint(string text, float autoCloseTime = 0f)
		{
			text = this.ProcessText(text);
			Console.Log("Showing hint: " + text, null);
			this.timeSinceOpened = 0f;
			this.SetAlpha(1f);
			this.FlashAnim.Play();
			this.Label.text = text;
			this.Label.ForceMeshUpdate(false, false);
			this.Container.sizeDelta = new Vector2(this.Label.renderedWidth + this.Padding.x, this.Label.renderedHeight + this.Padding.y);
			this.Container.anchoredPosition = new Vector2(-this.Container.sizeDelta.x / 2f - this.Offset.x, -this.Container.sizeDelta.y / 2f + this.Offset.y);
			if (this.autoCloseRoutine != null)
			{
				base.StopCoroutine(this.autoCloseRoutine);
			}
			if (autoCloseTime > 0f)
			{
				this.autoCloseRoutine = base.StartCoroutine(this.<ShowHint>g__AutoClose|22_0(autoCloseTime));
			}
			this.IsOpen = true;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x0011FAF0 File Offset: 0x0011DCF0
		public void Hide()
		{
			this.SetAlpha(0f);
			this.IsOpen = false;
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x0011FB04 File Offset: 0x0011DD04
		private void SetAlpha(float alpha)
		{
			HintDisplay.<>c__DisplayClass24_0 CS$<>8__locals1 = new HintDisplay.<>c__DisplayClass24_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.alpha = alpha;
			if (CS$<>8__locals1.alpha > 0f)
			{
				this.Container.gameObject.SetActive(true);
			}
			if (this.fadeRoutine != null)
			{
				base.StopCoroutine(this.fadeRoutine);
			}
			this.fadeRoutine = base.StartCoroutine(CS$<>8__locals1.<SetAlpha>g__Routine|0());
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x0011FB69 File Offset: 0x0011DD69
		public void QueueHint_10s(string message)
		{
			this.hintQueue.Add(new HintDisplay.Hint(message, 10f));
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x0011FB81 File Offset: 0x0011DD81
		public void QueueHint_20s(string message)
		{
			this.hintQueue.Add(new HintDisplay.Hint(message, 20f));
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x0011FB99 File Offset: 0x0011DD99
		public void QueueHint(string message, float time)
		{
			this.hintQueue.Add(new HintDisplay.Hint(message, time));
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x0011FBB0 File Offset: 0x0011DDB0
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
					return "<color=#88CBFF>" + displayNameForControlPath + "</color>";
				}
				return match.Value;
			};
			return Regex.Replace(text, pattern, evaluator).Replace("<h1>", "<color=#88CBFF>").Replace("<h2>", "<color=#F86266>").Replace("<h3>", "<color=#46CB4F>").Replace("</h>", "</color>");
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x0011FC3A File Offset: 0x0011DE3A
		[CompilerGenerated]
		private IEnumerator <ShowHint>g__AutoClose|22_0(float time)
		{
			yield return new WaitForSeconds(time);
			this.Hide();
			this.autoCloseRoutine = null;
			yield break;
		}

		// Token: 0x04003215 RID: 12821
		public const float FadeTime = 0.3f;

		// Token: 0x04003217 RID: 12823
		[Header("References")]
		public RectTransform Container;

		// Token: 0x04003218 RID: 12824
		public TextMeshProUGUI Label;

		// Token: 0x04003219 RID: 12825
		public CanvasGroup Group;

		// Token: 0x0400321A RID: 12826
		public InputPrompt DismissPrompt;

		// Token: 0x0400321B RID: 12827
		public Animation FlashAnim;

		// Token: 0x0400321C RID: 12828
		[Header("Settings")]
		public Vector2 Padding;

		// Token: 0x0400321D RID: 12829
		public Vector2 Offset;

		// Token: 0x0400321E RID: 12830
		private Coroutine autoCloseRoutine;

		// Token: 0x0400321F RID: 12831
		private Coroutine fadeRoutine;

		// Token: 0x04003220 RID: 12832
		private List<HintDisplay.Hint> hintQueue = new List<HintDisplay.Hint>();

		// Token: 0x04003221 RID: 12833
		private float timeSinceOpened;

		// Token: 0x020009F1 RID: 2545
		private class Hint
		{
			// Token: 0x060044AD RID: 17581 RVA: 0x0011FC50 File Offset: 0x0011DE50
			public Hint(string text, float duration)
			{
				this.Text = text;
				this.Duration = duration;
			}

			// Token: 0x04003222 RID: 12834
			public string Text;

			// Token: 0x04003223 RID: 12835
			public float Duration;
		}
	}
}
