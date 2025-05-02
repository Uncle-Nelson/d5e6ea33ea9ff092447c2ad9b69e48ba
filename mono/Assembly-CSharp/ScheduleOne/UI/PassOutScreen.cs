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
	// Token: 0x02000A2B RID: 2603
	public class PassOutScreen : Singleton<PassOutScreen>
	{
		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06004630 RID: 17968 RVA: 0x001267B6 File Offset: 0x001249B6
		// (set) Token: 0x06004631 RID: 17969 RVA: 0x001267BE File Offset: 0x001249BE
		public bool isOpen { get; protected set; }

		// Token: 0x06004632 RID: 17970 RVA: 0x001267C7 File Offset: 0x001249C7
		protected override void Awake()
		{
			base.Awake();
			this.Canvas.enabled = false;
			this.Group.alpha = 0f;
			this.Group.interactable = false;
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x001267F7 File Offset: 0x001249F7
		private void Continue()
		{
			if (!this.isOpen)
			{
				return;
			}
			this.isOpen = false;
			base.StartCoroutine(this.<Continue>g__Routine|14_0());
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00126816 File Offset: 0x00124A16
		private void LoadSaveClicked()
		{
			this.Close();
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x00126820 File Offset: 0x00124A20
		public void Open()
		{
			if (this.isOpen)
			{
				return;
			}
			this.isOpen = true;
			Singleton<EyelidOverlay>.Instance.Canvas.sortingOrder = 5;
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			this.cashLoss = Mathf.Min(Random.Range(50f, 500f), NetworkSingleton<MoneyManager>.Instance.cashBalance);
			base.StartCoroutine(this.<Open>g__Routine|16_0());
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00126890 File Offset: 0x00124A90
		public void Close()
		{
			this.isOpen = false;
			this.Canvas.enabled = false;
			Singleton<EyelidOverlay>.Instance.Canvas.sortingOrder = -1;
			Singleton<EyelidOverlay>.Instance.AutoUpdate = true;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			if (!Singleton<ArrestNoticeScreen>.Instance.isOpen)
			{
				Player.Activate();
			}
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x001268F4 File Offset: 0x00124AF4
		[CompilerGenerated]
		private IEnumerator <Continue>g__Routine|14_0()
		{
			float fadeTime = 1f;
			for (float i = 0f; i < fadeTime; i += Time.deltaTime)
			{
				this.Group.alpha = Mathf.Lerp(1f, 0f, i / fadeTime);
				yield return new WaitForEndOfFrame();
			}
			this.MainLabel.gameObject.SetActive(false);
			Player.Local.SendPassOutRecovery();
			Player.Local.Health.RecoverHealth(100f);
			Transform child = this.RecoveryPointsContainer.GetChild(Random.Range(0, this.RecoveryPointsContainer.childCount));
			PlayerSingleton<PlayerMovement>.Instance.Teleport(child.position);
			Player.Local.transform.forward = child.forward;
			yield return new WaitForSeconds(0.5f);
			bool fadeBlur = false;
			if (Player.Local.IsArrested)
			{
				Singleton<ArrestNoticeScreen>.Instance.RecordCrimes();
				Player.Local.Free();
				Singleton<ArrestNoticeScreen>.Instance.Open();
				PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
				yield return new WaitForSeconds(1f);
			}
			else
			{
				this.ContextLabel.text = "You awaken in a new location, unsure of how you got there.";
				if (this.cashLoss > 0f)
				{
					NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.cashLoss, true, false);
					this.ContextLabel.text = this.ContextLabel.text + "\n\n<color=#54E717>" + MoneyManager.FormatAmount(this.cashLoss, false, false) + "</color> is missing from your wallet.";
				}
				this.ContextLabel.gameObject.SetActive(true);
				for (float i = 0f; i < fadeTime; i += Time.deltaTime)
				{
					this.Group.alpha = Mathf.Lerp(0f, 1f, i / fadeTime);
					yield return new WaitForEndOfFrame();
				}
				fadeBlur = true;
				yield return new WaitForSeconds(4f);
				for (float i = 0f; i < fadeTime; i += Time.deltaTime)
				{
					this.Group.alpha = Mathf.Lerp(1f, 0f, i / fadeTime);
					yield return new WaitForEndOfFrame();
				}
				this.Group.alpha = 0f;
			}
			yield return new WaitForSeconds(1f);
			float lerpTime = 2f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				Singleton<EyelidOverlay>.Instance.SetOpen(Mathf.Lerp(0f, 1f, i / lerpTime));
				if (fadeBlur)
				{
					Singleton<PostProcessingManager>.Instance.SetBlur(1f - i / lerpTime);
				}
				yield return new WaitForEndOfFrame();
			}
			Singleton<EyelidOverlay>.Instance.SetOpen(1f);
			if (fadeBlur)
			{
				Singleton<PostProcessingManager>.Instance.SetBlur(0f);
			}
			this.Close();
			yield break;
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x00126903 File Offset: 0x00124B03
		[CompilerGenerated]
		private IEnumerator <Open>g__Routine|16_0()
		{
			this.MainLabel.gameObject.SetActive(true);
			this.ContextLabel.gameObject.SetActive(false);
			yield return new WaitForSeconds(0.5f);
			Singleton<EyelidOverlay>.Instance.AutoUpdate = false;
			float lerpTime = 2f;
			float startOpenness = Singleton<EyelidOverlay>.Instance.CurrentOpen;
			float endOpenness = 0f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				Singleton<EyelidOverlay>.Instance.SetOpen(Mathf.Lerp(startOpenness, endOpenness, i / lerpTime));
				Singleton<PostProcessingManager>.Instance.SetBlur(i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			Singleton<EyelidOverlay>.Instance.SetOpen(0f);
			Singleton<PostProcessingManager>.Instance.SetBlur(1f);
			yield return new WaitForSeconds(0.5f);
			this.Anim.Play();
			this.Canvas.enabled = true;
			yield return new WaitForSeconds(3f);
			this.Continue();
			yield break;
		}

		// Token: 0x040033C2 RID: 13250
		public const float CASH_LOSS_MIN = 50f;

		// Token: 0x040033C3 RID: 13251
		public const float CASH_LOSS_MAX = 500f;

		// Token: 0x040033C4 RID: 13252
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040033C5 RID: 13253
		public CanvasGroup Group;

		// Token: 0x040033C6 RID: 13254
		public Transform RecoveryPointsContainer;

		// Token: 0x040033C7 RID: 13255
		public TextMeshProUGUI MainLabel;

		// Token: 0x040033C8 RID: 13256
		public TextMeshProUGUI ContextLabel;

		// Token: 0x040033C9 RID: 13257
		public Animation Anim;

		// Token: 0x040033CA RID: 13258
		private float cashLoss;
	}
}
