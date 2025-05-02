using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A27 RID: 2599
	public class HospitalBillScreen : Singleton<HospitalBillScreen>
	{
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x0012622A File Offset: 0x0012442A
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x00126232 File Offset: 0x00124432
		public bool isOpen { get; protected set; }

		// Token: 0x0600461D RID: 17949 RVA: 0x0012623C File Offset: 0x0012443C
		protected override void Awake()
		{
			base.Awake();
			this.isOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			this.CanvasGroup.alpha = 0f;
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 20);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x001262B6 File Offset: 0x001244B6
		private void Exit(ExitAction action)
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
				this.Close();
			}
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x001262E0 File Offset: 0x001244E0
		private void PlayerSpawned()
		{
			this.PatientNameLabel.text = Player.Local.PlayerName;
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x001262F8 File Offset: 0x001244F8
		public void Open()
		{
			this.isOpen = true;
			this.arrested = Player.Local.IsArrested;
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			this.CanvasGroup.alpha = 1f;
			this.CanvasGroup.interactable = true;
			this.BillNumberLabel.text = Random.Range(10000000, 100000000).ToString();
			float amount = Mathf.Min(250f, NetworkSingleton<MoneyManager>.Instance.cashBalance);
			this.PaidAmountLabel.text = MoneyManager.FormatAmount(amount, true, false);
			Singleton<PostProcessingManager>.Instance.SetBlur(1f);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			Player.Deactivate(false);
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x001263C4 File Offset: 0x001245C4
		public void Close()
		{
			if (!this.CanvasGroup.interactable || !this.isOpen)
			{
				return;
			}
			this.CanvasGroup.interactable = false;
			float num = Mathf.Min(250f, NetworkSingleton<MoneyManager>.Instance.cashBalance);
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-num, true, false);
			if (this.arrested)
			{
				this.CanvasGroup.alpha = 0f;
				this.Canvas.enabled = false;
				this.Container.gameObject.SetActive(false);
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
				this.isOpen = false;
				Singleton<ArrestNoticeScreen>.Instance.Open();
				return;
			}
			base.StartCoroutine(this.<Close>g__CloseRoutine|16_0());
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x00126482 File Offset: 0x00124682
		[CompilerGenerated]
		private IEnumerator <Close>g__CloseRoutine|16_0()
		{
			float lerpTime = 0.3f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				this.CanvasGroup.alpha = Mathf.Lerp(1f, 0f, i / lerpTime);
				Singleton<PostProcessingManager>.Instance.SetBlur(this.CanvasGroup.alpha);
				yield return new WaitForEndOfFrame();
			}
			this.CanvasGroup.alpha = 0f;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			Singleton<PostProcessingManager>.Instance.SetBlur(0f);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			Player.Activate();
			this.isOpen = false;
			yield break;
		}

		// Token: 0x040033B0 RID: 13232
		public const float BILL_COST = 250f;

		// Token: 0x040033B2 RID: 13234
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040033B3 RID: 13235
		public RectTransform Container;

		// Token: 0x040033B4 RID: 13236
		public CanvasGroup CanvasGroup;

		// Token: 0x040033B5 RID: 13237
		public TextMeshProUGUI PatientNameLabel;

		// Token: 0x040033B6 RID: 13238
		public TextMeshProUGUI BillNumberLabel;

		// Token: 0x040033B7 RID: 13239
		public TextMeshProUGUI PaidAmountLabel;

		// Token: 0x040033B8 RID: 13240
		private bool arrested;
	}
}
