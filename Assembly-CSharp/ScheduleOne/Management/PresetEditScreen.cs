using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management.Presets;
using ScheduleOne.Management.Presets.Options.SetterScreens;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Management
{
	// Token: 0x02000586 RID: 1414
	public class PresetEditScreen : MonoBehaviour
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x00090331 File Offset: 0x0008E531
		public bool isOpen
		{
			get
			{
				return this.EditedPreset != null;
			}
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0009033C File Offset: 0x0008E53C
		protected virtual void Awake()
		{
			this.ReturnButton.onClick.AddListener(new UnityAction(this.ReturnButtonClicked));
			this.DeleteButton.onClick.AddListener(new UnityAction(this.DeleteButtonClicked));
			this.InputField.onValueChanged.AddListener(new UnityAction<string>(this.NameFieldChange));
			this.InputField.onEndEdit.AddListener(new UnityAction<string>(this.NameFieldDone));
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 4);
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x000903CB File Offset: 0x0008E5CB
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

		// Token: 0x0600233C RID: 9020 RVA: 0x000903F8 File Offset: 0x0008E5F8
		public virtual void Open(Preset preset)
		{
			this.EditedPreset = preset;
			this.InputField.text = this.EditedPreset.PresetName;
			Canvas.ForceUpdateCanvases();
			this.RefreshIcon();
			this.RefreshTransforms();
			base.gameObject.SetActive(true);
			base.StartCoroutine(this.<Open>g__Delay|13_0());
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0009044C File Offset: 0x0008E64C
		public void Close()
		{
			this.EditedPreset = null;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00090461 File Offset: 0x0008E661
		private void RefreshIcon()
		{
			this.IconBackground.color = this.EditedPreset.PresetColor;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00090480 File Offset: 0x0008E680
		private void RefreshTransforms()
		{
			this.InputField.ForceLabelUpdate();
			this.InputField.textComponent.ForceMeshUpdate(true, true);
			float renderedWidth = this.InputField.textComponent.renderedWidth;
			if (this.InputField.text == string.Empty)
			{
				renderedWidth = ((TextMeshProUGUI)this.InputField.placeholder).renderedWidth;
			}
			this.InputFieldRect.sizeDelta = new Vector2(renderedWidth + 3f, this.InputFieldRect.sizeDelta.y);
			this.InputFieldRect.anchoredPosition = new Vector2(1.5f, this.InputFieldRect.anchoredPosition.y);
			float num = 1.75f;
			float min = 5f;
			this.IconBackgroundRect.anchoredPosition = new Vector2(-Mathf.Clamp(renderedWidth / 2f + num, min, float.MaxValue), this.IconBackgroundRect.anchoredPosition.y);
			this.EditButtonRect.anchoredPosition = new Vector2(Mathf.Clamp(renderedWidth / 2f + num, min, float.MaxValue), this.IconBackgroundRect.anchoredPosition.y);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x000905A9 File Offset: 0x0008E7A9
		private void NameFieldChange(string newVal)
		{
			this.RefreshTransforms();
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x000905B1 File Offset: 0x0008E7B1
		private void NameFieldDone(string piss)
		{
			if (this.IsNameAppropriate(piss))
			{
				this.EditedPreset.SetName(piss);
				return;
			}
			this.InputField.text = this.EditedPreset.PresetName;
			this.RefreshTransforms();
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x000905E5 File Offset: 0x0008E7E5
		private bool IsNameAppropriate(string name)
		{
			return !string.IsNullOrWhiteSpace(name) && !(name == string.Empty) && !(name == "Pablo");
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00090610 File Offset: 0x0008E810
		public void DeleteButtonClicked()
		{
			this.EditedPreset.DeletePreset(Preset.GetDefault(this.EditedPreset.ObjectType));
			this.Close();
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00090633 File Offset: 0x0008E833
		public void ReturnButtonClicked()
		{
			this.Close();
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0009063B File Offset: 0x0008E83B
		[CompilerGenerated]
		private IEnumerator <Open>g__Delay|13_0()
		{
			yield return new WaitForEndOfFrame();
			this.RefreshTransforms();
			yield break;
		}

		// Token: 0x04001A59 RID: 6745
		public Preset EditedPreset;

		// Token: 0x04001A5A RID: 6746
		[Header("References")]
		public RectTransform IconBackgroundRect;

		// Token: 0x04001A5B RID: 6747
		public Image IconBackground;

		// Token: 0x04001A5C RID: 6748
		public RectTransform InputFieldRect;

		// Token: 0x04001A5D RID: 6749
		public TMP_InputField InputField;

		// Token: 0x04001A5E RID: 6750
		public RectTransform EditButtonRect;

		// Token: 0x04001A5F RID: 6751
		public Button ReturnButton;

		// Token: 0x04001A60 RID: 6752
		public Button DeleteButton;

		// Token: 0x02000587 RID: 1415
		[Serializable]
		public class OptionData
		{
			// Token: 0x04001A61 RID: 6753
			public GameObject OptionEntryPrefab;

			// Token: 0x04001A62 RID: 6754
			public OptionSetterScreen OptionSetterScreen;
		}
	}
}
