using System;
using System.Collections;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Law;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009F6 RID: 2550
	public class HUD : Singleton<HUD>
	{
		// Token: 0x060044BF RID: 17599 RVA: 0x0011FE6B File Offset: 0x0011E06B
		protected override void Awake()
		{
			base.Awake();
			this.eventSystem = EventSystem.current;
			this.managementSlotContainer.gameObject.SetActive(true);
			this.HideTopScreenText();
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x0011FE95 File Offset: 0x0011E095
		public void SetCrosshairVisible(bool vis)
		{
			this.crosshair.gameObject.SetActive(vis);
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x0011FEA8 File Offset: 0x0011E0A8
		public void SetBlackOverlayVisible(bool vis, float fadeTime)
		{
			if (this.blackOverlayFade != null)
			{
				base.StopCoroutine(this.blackOverlayFade);
			}
			this.blackOverlayFade = base.StartCoroutine(this.FadeBlackOverlay(vis, fadeTime));
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x0011FED2 File Offset: 0x0011E0D2
		protected virtual void Update()
		{
			this.RefreshFPS();
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x0011FEDC File Offset: 0x0011E0DC
		private void FixedUpdate()
		{
			if (!Singleton<GameInput>.InstanceExists)
			{
				return;
			}
			this.SleepPrompt.gameObject.SetActive(NetworkSingleton<TimeManager>.Instance.CurrentTime == 400);
			if (NetworkSingleton<CurfewManager>.InstanceExists)
			{
				if (NetworkSingleton<CurfewManager>.Instance.IsCurrentlyActive)
				{
					this.CurfewPrompt.text = "Police curfew in effect until 5AM";
					this.CurfewPrompt.color = new Color32(byte.MaxValue, 108, 88, 60);
					this.CurfewPrompt.gameObject.SetActive(true);
				}
				else if (NetworkSingleton<CurfewManager>.Instance.IsEnabled && NetworkSingleton<TimeManager>.Instance.IsCurrentTimeWithinRange(2030, 500))
				{
					this.CurfewPrompt.text = "Police curfew starting soon";
					this.CurfewPrompt.color = new Color32(byte.MaxValue, 182, 88, 60);
					this.CurfewPrompt.gameObject.SetActive(true);
				}
				else
				{
					this.CurfewPrompt.gameObject.SetActive(false);
				}
			}
			this.UpdateQuestEntryTitle();
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x0011FFEC File Offset: 0x0011E1EC
		private void UpdateQuestEntryTitle()
		{
			int num = 0;
			for (int i = 0; i < this.QuestEntryContainer.childCount; i++)
			{
				if (this.QuestEntryContainer.GetChild(i).gameObject.activeSelf)
				{
					num++;
				}
			}
			this.QuestEntryTitle.enabled = (num > 1);
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x0012003C File Offset: 0x0011E23C
		private void RefreshFPS()
		{
			this._previousFPS.Add(1f / Time.unscaledDeltaTime);
			if (this._previousFPS.Count > this.SampleSize)
			{
				this._previousFPS.RemoveAt(0);
			}
			this.fpsLabel.text = Mathf.Floor(this.GetAverageFPS()).ToString() + " FPS";
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x001200A8 File Offset: 0x0011E2A8
		private float GetAverageFPS()
		{
			float num = 0f;
			for (int i = 0; i < this._previousFPS.Count; i++)
			{
				num += this._previousFPS[i];
			}
			return num / (float)this._previousFPS.Count;
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x001200EE File Offset: 0x0011E2EE
		protected virtual void LateUpdate()
		{
			if (!this.radialIndicatorSetThisFrame)
			{
				this.radialIndicator.enabled = false;
			}
			this.radialIndicatorSetThisFrame = false;
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x0012010B File Offset: 0x0011E30B
		protected IEnumerator FadeBlackOverlay(bool visible, float fadeTime)
		{
			if (visible)
			{
				this.blackOverlay.enabled = true;
				PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement("Blackout");
			}
			float startAlpha = this.blackOverlay.color.a;
			float endAlpha = 1f;
			if (!visible)
			{
				endAlpha = 0f;
			}
			for (float i = 0f; i < fadeTime; i += Time.unscaledDeltaTime)
			{
				this.blackOverlay.color = new Color(this.blackOverlay.color.r, this.blackOverlay.color.g, this.blackOverlay.color.b, Mathf.Lerp(startAlpha, endAlpha, i / fadeTime));
				yield return new WaitForEndOfFrame();
			}
			this.blackOverlay.color = new Color(this.blackOverlay.color.r, this.blackOverlay.color.g, this.blackOverlay.color.b, endAlpha);
			this.blackOverlayFade = null;
			if (!visible)
			{
				this.blackOverlay.enabled = false;
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement("Blackout");
			}
			yield break;
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00120128 File Offset: 0x0011E328
		public void ShowRadialIndicator(float fill)
		{
			this.radialIndicatorSetThisFrame = true;
			this.radialIndicator.fillAmount = fill;
			this.radialIndicator.enabled = true;
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x0012014C File Offset: 0x0011E34C
		public void ShowTopScreenText(string t)
		{
			this.topScreenText.text = t;
			this.topScreenText_Background.sizeDelta = new Vector2(this.topScreenText.preferredWidth + 30f, this.topScreenText_Background.sizeDelta.y);
			this.topScreenText_Background.gameObject.SetActive(true);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x001201A7 File Offset: 0x0011E3A7
		public void HideTopScreenText()
		{
			this.topScreenText_Background.gameObject.SetActive(false);
		}

		// Token: 0x04003231 RID: 12849
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003232 RID: 12850
		public RectTransform canvasRect;

		// Token: 0x04003233 RID: 12851
		public Image crosshair;

		// Token: 0x04003234 RID: 12852
		[SerializeField]
		protected Image blackOverlay;

		// Token: 0x04003235 RID: 12853
		[SerializeField]
		protected Image radialIndicator;

		// Token: 0x04003236 RID: 12854
		[SerializeField]
		protected GraphicRaycaster raycaster;

		// Token: 0x04003237 RID: 12855
		[SerializeField]
		protected TextMeshProUGUI topScreenText;

		// Token: 0x04003238 RID: 12856
		[SerializeField]
		protected RectTransform topScreenText_Background;

		// Token: 0x04003239 RID: 12857
		public Text fpsLabel;

		// Token: 0x0400323A RID: 12858
		public RectTransform cashSlotContainer;

		// Token: 0x0400323B RID: 12859
		public RectTransform cashSlotUI;

		// Token: 0x0400323C RID: 12860
		public RectTransform onlineBalanceContainer;

		// Token: 0x0400323D RID: 12861
		public RectTransform onlineBalanceSlotUI;

		// Token: 0x0400323E RID: 12862
		public RectTransform managementSlotContainer;

		// Token: 0x0400323F RID: 12863
		public ItemSlotUI managementSlotUI;

		// Token: 0x04003240 RID: 12864
		public RectTransform HotbarContainer;

		// Token: 0x04003241 RID: 12865
		public RectTransform SlotContainer;

		// Token: 0x04003242 RID: 12866
		public ItemSlotUI discardSlot;

		// Token: 0x04003243 RID: 12867
		public Image discardSlotFill;

		// Token: 0x04003244 RID: 12868
		public TextMeshProUGUI selectedItemLabel;

		// Token: 0x04003245 RID: 12869
		public RectTransform QuestEntryContainer;

		// Token: 0x04003246 RID: 12870
		public TextMeshProUGUI QuestEntryTitle;

		// Token: 0x04003247 RID: 12871
		public CrimeStatusUI CrimeStatusUI;

		// Token: 0x04003248 RID: 12872
		public BalanceDisplay OnlineBalanceDisplay;

		// Token: 0x04003249 RID: 12873
		public BalanceDisplay SafeBalanceDisplay;

		// Token: 0x0400324A RID: 12874
		public CrosshairText CrosshairText;

		// Token: 0x0400324B RID: 12875
		public RectTransform UnreadMessagesPrompt;

		// Token: 0x0400324C RID: 12876
		public TextMeshProUGUI SleepPrompt;

		// Token: 0x0400324D RID: 12877
		public TextMeshProUGUI CurfewPrompt;

		// Token: 0x0400324E RID: 12878
		[Header("Settings")]
		public Gradient RedGreenGradient;

		// Token: 0x0400324F RID: 12879
		private int SampleSize = 60;

		// Token: 0x04003250 RID: 12880
		private List<float> _previousFPS = new List<float>();

		// Token: 0x04003251 RID: 12881
		private EventSystem eventSystem;

		// Token: 0x04003252 RID: 12882
		private Coroutine blackOverlayFade;

		// Token: 0x04003253 RID: 12883
		private bool radialIndicatorSetThisFrame;
	}
}
