using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000B3B RID: 2875
	public class CharacterCustomizationUI : MonoBehaviour
	{
		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06004C84 RID: 19588 RVA: 0x00143010 File Offset: 0x00141210
		// (set) Token: 0x06004C85 RID: 19589 RVA: 0x00143018 File Offset: 0x00141218
		public bool IsOpen { get; private set; }

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06004C86 RID: 19590 RVA: 0x00143021 File Offset: 0x00141221
		// (set) Token: 0x06004C87 RID: 19591 RVA: 0x00143029 File Offset: 0x00141229
		public CharacterCustomizationCategory ActiveCategory { get; private set; }

		// Token: 0x06004C88 RID: 19592 RVA: 0x00143032 File Offset: 0x00141232
		private void OnValidate()
		{
			this.Categories = base.GetComponentsInChildren<CharacterCustomizationCategory>(true);
			this.TitleText.text = this.Title;
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x00143054 File Offset: 0x00141254
		private void Awake()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 1);
			this.RigRotationSlider.onValueChanged.AddListener(new UnityAction<float>(delegate(float value)
			{
				this.rigTargetY = value * 359f;
			}));
			this.Categories = base.GetComponentsInChildren<CharacterCustomizationCategory>(true);
			this.TitleText.text = this.Title;
			this.ExitButton.onClick.AddListener(new UnityAction(this.Close));
			for (int i = 0; i < this.Categories.Length; i++)
			{
				Button button = Object.Instantiate<Button>(this.CategoryButtonPrefab, this.ButtonContainer);
				button.GetComponentInChildren<TextMeshProUGUI>().text = this.Categories[i].CategoryName;
				CharacterCustomizationCategory category = this.Categories[i];
				button.onClick.AddListener(new UnityAction(delegate()
				{
					this.SetActiveCategory(category);
				}));
			}
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.MainContainer.gameObject.SetActive(false);
			this.AvatarRig.gameObject.SetActive(false);
			this.SetActiveCategory(null);
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x00143174 File Offset: 0x00141374
		protected virtual void Update()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.RigContainer.localEulerAngles = Vector3.Lerp(this.RigContainer.localEulerAngles, new Vector3(0f, this.rigTargetY, 0f), Time.deltaTime * 5f);
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x001431C8 File Offset: 0x001413C8
		public void SetActiveCategory(CharacterCustomizationCategory category)
		{
			this.ActiveCategory = category;
			for (int i = 0; i < this.Categories.Length; i++)
			{
				this.Categories[i].gameObject.SetActive(this.Categories[i] == category);
				if (this.Categories[i] == category)
				{
					this.Categories[i].Open();
				}
			}
			this.MenuContainer.gameObject.SetActive(category == null);
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x000141BA File Offset: 0x000123BA
		public virtual bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			return false;
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x00143243 File Offset: 0x00141443
		public virtual void OptionSelected(CharacterCustomizationOption option)
		{
			this.PreviewIndicator.gameObject.SetActive(!option.purchased);
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x0014325E File Offset: 0x0014145E
		public virtual void OptionDeselected(CharacterCustomizationOption option)
		{
			Console.Log("Deselected option: " + option.Label, null);
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x00143276 File Offset: 0x00141476
		public virtual void OptionPurchased(CharacterCustomizationOption option)
		{
			this.PreviewIndicator.gameObject.SetActive(false);
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x0014328C File Offset: 0x0014148C
		public virtual void Open()
		{
			if (this.openCloseRoutine != null)
			{
				return;
			}
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			this.currentSettings = Object.Instantiate<BasicAvatarSettings>(Player.Local.CurrentAvatarSettings);
			this.openCloseRoutine = base.StartCoroutine(this.<Open>g__Close|34_0());
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x001432FC File Offset: 0x001414FC
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
				if (this.ActiveCategory != null)
				{
					this.ActiveCategory.Back();
					return;
				}
				this.Close();
			}
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x0014334C File Offset: 0x0014154C
		protected virtual void Close()
		{
			if (this.openCloseRoutine != null)
			{
				return;
			}
			this.SetActiveCategory(null);
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.MainContainer.gameObject.SetActive(false);
			Player.Local.SendAppearance(this.currentSettings);
			this.openCloseRoutine = base.StartCoroutine(this.<Close>g__Close|36_0());
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x001433D1 File Offset: 0x001415D1
		[CompilerGenerated]
		private IEnumerator <Open>g__Close|34_0()
		{
			Singleton<BlackOverlay>.Instance.Open(0.5f);
			yield return new WaitForSeconds(0.6f);
			this.IsOpen = true;
			this.Canvas.enabled = true;
			this.MainContainer.gameObject.SetActive(true);
			this.AvatarRig.gameObject.SetActive(true);
			if (this.LoadAvatarSettingsNaked)
			{
				this.AvatarRig.LoadNakedSettings(Player.Local.Avatar.CurrentSettings, 19);
			}
			else
			{
				this.AvatarRig.LoadAvatarSettings(Player.Local.Avatar.CurrentSettings);
			}
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition.position, this.CameraPosition.rotation, 0f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0f);
			this.SetActiveCategory(null);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			Singleton<BlackOverlay>.Instance.Close(0.5f);
			this.openCloseRoutine = null;
			yield break;
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x001433E0 File Offset: 0x001415E0
		[CompilerGenerated]
		private IEnumerator <Close>g__Close|36_0()
		{
			Singleton<BlackOverlay>.Instance.Open(0.5f);
			yield return new WaitForSeconds(0.6f);
			this.AvatarRig.gameObject.SetActive(false);
			if (PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
				PlayerSingleton<PlayerCamera>.Instance.LockMouse();
				PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, true, true);
				PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0f);
				PlayerSingleton<PlayerMovement>.Instance.canMove = true;
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
			Singleton<BlackOverlay>.Instance.Close(0.5f);
			this.openCloseRoutine = null;
			yield break;
		}

		// Token: 0x040039A4 RID: 14756
		[Header("Settings")]
		public string Title = "Customize";

		// Token: 0x040039A5 RID: 14757
		public CharacterCustomizationCategory[] Categories;

		// Token: 0x040039A6 RID: 14758
		public bool LoadAvatarSettingsNaked;

		// Token: 0x040039A7 RID: 14759
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040039A8 RID: 14760
		public RectTransform MainContainer;

		// Token: 0x040039A9 RID: 14761
		public RectTransform MenuContainer;

		// Token: 0x040039AA RID: 14762
		public TextMeshProUGUI TitleText;

		// Token: 0x040039AB RID: 14763
		public RectTransform ButtonContainer;

		// Token: 0x040039AC RID: 14764
		public Button ExitButton;

		// Token: 0x040039AD RID: 14765
		public Slider RigRotationSlider;

		// Token: 0x040039AE RID: 14766
		public Transform CameraPosition;

		// Token: 0x040039AF RID: 14767
		public Transform RigContainer;

		// Token: 0x040039B0 RID: 14768
		public Avatar AvatarRig;

		// Token: 0x040039B1 RID: 14769
		public RectTransform PreviewIndicator;

		// Token: 0x040039B2 RID: 14770
		[Header("Prefab")]
		public Button CategoryButtonPrefab;

		// Token: 0x040039B3 RID: 14771
		private float rigTargetY;

		// Token: 0x040039B4 RID: 14772
		private Coroutine openCloseRoutine;

		// Token: 0x040039B5 RID: 14773
		protected BasicAvatarSettings currentSettings;
	}
}
